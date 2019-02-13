
using ChristInSong.Core;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Christ_in_song
{
    /// <summary>
    /// A converter that takes in a <see cref="IconType"/> and returns 
    /// the FontAwesome string for that icon
    /// </summary>
    public class FullPathToImageConverter : BaseValueConverter<FullPathToImageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = value as string;
            if (string.IsNullOrEmpty(path)) return null;
            try
            {
                return new BitmapImage(new Uri(path));
            }
            catch(Exception ex)
            {
                GUI_RelatedMethodsCore.InformTheUser(ex.Message.ToString());
                return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
