using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChristInSong.Core;

namespace Christ_in_song
{
    /// <summary>
    /// Converts a full path to a specific image type of a drive, folder or file
    /// </summary>
    public class StringFullPathToBitmapImageConverter : BaseValueConverter<StringFullPathToBitmapImageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // path  t the image
            string path = value as string;

            // return nothing if there's no image
            if (path is null) return null;
            try
            {
                // the image
                return new BitmapImage(new Uri(Path.GetFullPath(path)));
            }
            catch(Exception ex)
            {
                GUI_RelatedMethodsCore.InformTheUser(ex.Message.ToString());
                // return nothing
                return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    
}
