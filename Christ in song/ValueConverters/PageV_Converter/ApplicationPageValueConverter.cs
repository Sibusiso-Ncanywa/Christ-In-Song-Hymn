using ChristInSong.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ_in_song
{
       /// <summary>
       /// converts the <see cref="ApplicationPageType"/> to an actual view/page
       /// </summary>
       public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
       {
              public override object Convert(object value, Type targetType = null, object parameter = null, CultureInfo culture = null)
              {
                     // Find the appropriate page
                     switch ((ApplicationPageType)value)
                     {
                            case ApplicationPageType.Welcome:
                                   return new WelcomePage();

                            case ApplicationPageType.Home:
                                   return new HomePage();

                            case ApplicationPageType.DisplaySong:
                                   return new DisplaySongPage();

                            case ApplicationPageType.EditSong:
                                   return new EditSongPage();

                            case ApplicationPageType.Events:
                                   return new EventsPage();

                            case ApplicationPageType.Announcements:
                                   return new AnnouncementsPage();

                            case ApplicationPageType.Doxology:
                                   return new DoxologyPage();

                            case ApplicationPageType.DeveloperInfo:
                                   return new DeveloperInfoPage();

                            case ApplicationPageType.FullscreenView:
                                   return new FullscreenViewPage();

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
