using System;
using System.Globalization;
using System.Windows.Documents;
using ChristInSong.Core;

namespace Christ_in_song
{
    /// <summary>
    /// A converter that takes in a path string to a document and converts it to a XPS document sequence
    /// </summary>
    public class StringFullPathToDocumentConverter : BaseValueConverter<StringFullPathToDocumentConverter>
    {
        #region Temp Store document details

        private static FixedDocumentSequence MDocument = null;
        private static string PathToDocument = string.Empty; 

        #endregion

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value as string is null)
                return null;
            var filename = GeneralMethods.GetFileFolderName((string)value);
            if (((MDocument != null) && (PathToDocument == filename)))
                return MDocument;

            PathToDocument = filename;
            MDocument = GUI_RelatedMethodsCore.ShowTheDocument(value as string);
            return MDocument;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
