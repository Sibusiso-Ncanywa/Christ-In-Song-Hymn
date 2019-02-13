using LizHackMethods.Classes;
using LizHackMethods.Enums;
using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;
using Word = Microsoft.Office.Interop.Word;

namespace ChristInSong.Core
{
    /// <summary>
    /// Hosts GUI related methods for the Christ in song Application
    /// </summary>
    public static class GUI_RelatedMethodsCore
    {
        #region Document open/save methods

        /// <summary>
        ///  Convert the word document to xps document
        /// </summary>
        /// <param name="wordFilename">Word document Path</param>
        /// <param name="xpsFilename">Xps document Path</param>
        /// <returns></returns>
        public static XpsDocument ConvertWordToXps(string wordFilename, string xpsFilename)
        {
            // Create a WordApplication and host word document
            var wordApp = new Word.Application();
            try
            {
                // open the document in the word application
                wordApp.Documents.Open(wordFilename);

                // hide the word document
                wordApp.Application.Visible = false;

                // Minimize the opened word document
                wordApp.WindowState = WdWindowState.wdWindowStateMinimize;

                // assign the document
                var doc = wordApp.ActiveDocument;

                // save the new file
                doc.SaveAs(xpsFilename, WdSaveFormat.wdFormatXPS);

                // create the new file
                var xpsDocument = new XpsDocument(xpsFilename, FileAccess.Read);

                // return the new file
                return xpsDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Attention");
                return null;
            }
            finally
            {
                // close the application
                wordApp.Documents.Close();
                ( (_Application)wordApp ).Quit(WdSaveOptions.wdDoNotSaveChanges);
            }
        }

        /// <summary>
        /// return a document sequence of the document in path given
        /// </summary>
        /// <param name="pathToDoc"> The document to convert </param>
        /// <returns></returns>
        public static FixedDocumentSequence ShowTheDocument(string pathToDoc)
        {
            // check if the path is valid or if it's null
            if (string.IsNullOrEmpty(pathToDoc) || !File.Exists(pathToDoc))
            {
               InformTheUser("The file is invalid. Please select an existing file again.");
                return null;
            }

            // create a new xps document
            var convertedXpsDoc = string.Concat(Path.GetTempPath(), "\\", Guid.NewGuid().ToString(), ".xps");

            // get the xps file with content
            var xpsDocument = ConvertWordToXps(pathToDoc, convertedXpsDoc);
            if (xpsDocument == null)
            {
                return null;
            }

            // return a fixed document view of the xps document
            return xpsDocument.GetFixedDocumentSequence();
        }

        #endregion
        
        #region Open/Save dialog/windows

        /// <summary>
        /// Reports to the user that the song is not found.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="type"></param>
        public static void SongNotFound(string number, HymnType type)
        {
            var typeOfHymn = "";
            switch (type)
            {
                case HymnType.AdventHymn:
                    typeOfHymn = "Advent Hymn";
                    break;
                case HymnType.ChristInSong:
                    typeOfHymn = "Christ In Song hymn";
                    break;
            }
            // inform the user
            InformTheUser($" Song number {number} is not present in the {typeOfHymn}.");
        }

        /// <summary>
        /// Show the user the message passed. 
        /// By default the message Icon is set to ERROR.
        /// </summary>
        /// <param name="message"> The message to show the user </param>
        public static void InformTheUser(string THEmessage, string TheTitle = null)
        {
            // if there is no message do nothing
            if (string.IsNullOrEmpty(THEmessage)) return;
            CoreDi.UI_Dna.ShowMessage(new MessageBoxDialogViewModel
            {
                Title = TheTitle is null ? "Attention" : TheTitle,
                Message = THEmessage,
                OkText = "OK"
            });
        }

        /// <summary>
        /// closes all windows open.
        /// </summary>
        public static void CloseAllWindows()
        {
            // close all windows in the applications
            foreach (System.Windows.Window w in System.Windows.Application.Current.Windows)
                w?.Close();
        }

        /// <summary>
        /// Get the file from file explorer and return the file name and path.
        /// Returns an array of string with Pos[0] = File name, Pos[1] = File path
        /// </summary>
        /// <param name="window"> The current window </param>
        /// <param name="filterType"> The type of file </param>
        /// <returns> Returns an array of string with Pos[0] = File name, Pos[1] = File path </returns>
        public static string[] GetTheFile(FileFilters filterType)
        {
            // used to store the filter pipeline
            var TheFilter = "";

            // find the type of filter to be used
            switch (filterType)
            {
                case FileFilters.Document:
                    TheFilter = "Word Documents(*.doc;*.docx)|*.doc;*.docx";
                    break;
                case FileFilters.Picture:
                    TheFilter = "Image/Picture (*.png;*.jpg)|*.png;*.jpg";
                    break;
                default:
                    // by default assume an image filter
                    TheFilter = "Image/Picture (*.png;*.jpg)|*.png;*.jpg";
                    break;
            }

            // open the file dialog
            var openFile = new OpenFileDialog()
            {
                // do not allow multi selection
                Multiselect = false,
                // accept only these extensions
                Filter = TheFilter
            };

            // if the dialog window is not shown return an empty array
            if (!(bool)openFile.ShowDialog()) return new string[2];

            // store the path to the file
            var filePath = openFile.FileName;

            // get the file name
            var fileNameGot = GeneralMethods.GetFileFolderName(filePath);

            if(filterType == FileFilters.Document)
                // Save the file to the announcements folder
                GeneralMethods.AddAnnouncementFileToTemp(filePath, fileNameGot);

            // return the array with the filename and the path to the file
            return new string[2]
            {
                 fileNameGot,
                 filePath
            };
        }

        #endregion
        
    }
}
