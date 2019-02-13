using System;
using System.Globalization;

namespace Christ_in_song
{
    /// <summary>
    /// Converts a bool to a string
    /// </summary>
    public class BoolToStringConverter : BaseValueConverter<BoolToStringConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture) => 
            value is null ? string.Empty : value is false ? "Announcements" : "Loading The Anouncements page, please wait...";

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
