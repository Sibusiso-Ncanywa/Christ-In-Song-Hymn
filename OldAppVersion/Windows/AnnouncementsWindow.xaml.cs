//using Microsoft.Win32;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Shapes;
//using System.IO;

//namespace Christ_in_song
//{
//    /// <summary>
//    /// Interaction logic for Announcements.xaml
//    /// </summary>
//    public partial class Announcements : System.Windows.Window
//    {
//        public Announcements()
//        {
//           // InitializeComponent();
//            //this.DataContext = new WindowViewModel(this);
//        }

//        /// <summary>
//        /// Goes back to the menu
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void AnnouncHomeBtn_Click(object sender, RoutedEventArgs e)
//        {
//            // go back to hoome window
//            HomeChristInSongWindow __homeWindow = new HomeChristInSongWindow();
//            this.Hide();
//            __homeWindow.Show();
            
//        }
        
//        /// <summary>
//        /// Browse for the document
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void AnnouncBrowseBtn_Click(object sender, RoutedEventArgs e)
//        {
//            // open the file dialog
//            OpenFileDialog openFile = new OpenFileDialog()
//            {
//                // do not allow multi selection
//                Multiselect = false,
//                // accept only these extensions
//                Filter = "Word Documents(*.doc;*.docx)|*.doc;*.docx"
//            };
//            // if the dialog window is not shown do nothing
//            if (!(bool)openFile.ShowDialog(this)) return;

//            // store the path to the file
//            string filePath = openFile.FileName;

//            // get the file name
//            //string fileNameGot = GeneralMethods.GetFileFolderName(filePath);

//            // show the file name 
//            //FileNameView.Text = fileNameGot;
//            //FileNameView.Tag = filePath;
//        }

//        /// <summary>
//        /// View the document.
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void ViewTheDocument_Click(object sender, RoutedEventArgs e)
//        {
//            //string docPath = (string)FileNameView.Tag;
//           // string wordDocument = docPath;
//            //if (string.IsNullOrEmpty(wordDocument) || !File.Exists(wordDocument))
//            //{
//            //    MessageBox.Show("The file is invalid. Please select an existing file again.","Attention!");
//            //}
//            //else
//            //{
//            //    // create a new xps document
//            //    string convertedXpsDoc = string.Concat(System.IO.Path.GetTempPath(), "\\", Guid.NewGuid().ToString(), ".xps");

//            //    //// get the xps file with content
//            //    //XpsDocument xpsDocument = GeneralMethods.ConvertWordToXps(wordDocument, convertedXpsDoc);
//            //    //if (xpsDocument == null)
//            //    //{
//            //    //    return;
//            //    //}

//            //    // document view is assigned the doc to be viewed
//            //    //DocViewerAnnounc.Document = xpsDocument.GetFixedDocumentSequence();
//            //}
//        }
//    }
//}
