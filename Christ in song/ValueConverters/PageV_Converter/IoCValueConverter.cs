using ChristInSong.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Christ_in_song
{
    /// <summary>
    /// converts the <see cref="ApplicationPageType"/> to an actual view/page
    /// </summary>
    public class IoCValueConverter : BaseValueConverter<IoCValueConverter>
       {
              public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
              {
                     // Find the appropriate page
                     switch ((string)parameter)
                     {
                            case nameof(ApplicationViewModel):
                                   return CoreDi.VM_Application_Dna;

                            default:
                                   Debugger.Break();
                                   return null;
                     }
              }

              public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
              {
                     throw new NotImplementedException();
              }
       }
}
