using System;
using System.Globalization;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Christ_in_song
{
    /// <summary>
    /// Converts a full path to a specific image type of a drive, folder or file
    /// </summary>
    public class HeaderToImageConverter : BaseValueConverter<HeaderToImageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (string)value == "DeveloperImage"
                ? new ImageBrush(new BitmapImage(new Uri($"pack://application:,,,/Images/DevelopersImage/LizHack_smile.png")))
                : new ImageBrush(new BitmapImage(new Uri($"pack://application:,,,/Images/mediaLogos/{value}.png")));

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
