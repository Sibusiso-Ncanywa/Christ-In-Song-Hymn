using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ChristInSong.Core
{
       /// <summary>
       /// The design time data for a <see cref="EventsListVM"/>
       /// </summary>
       public class EventListDesignModel : EventsListVM
       {
              #region Public Singleton
              // Singleton is a single instance of something, e.g and instance of a class

              /// <summary>
              /// Gets a new fav songlistItem, A single instance
              /// </summary>
              public static EventListDesignModel Instance => new EventListDesignModel();

              #endregion

              #region constructor

              /// <summary>
              /// Default constructor
              /// </summary>
              public EventListDesignModel()
              {
                     // Dummy data
                     Events = new ObservableCollection<EventItemVM>
                     {
                              new EventItemVM
                              {
                                     NameOfEvent = "Gusheshe",
                                     FullPathOfPoster = "C:\\Users\\Lizalise LizHackSA\\Pictures\\Wallpaper HD\\Gusheshe.jpg",
                                     IsSelected = false
                              },
                              new EventItemVM
                              {
                                     NameOfEvent = "Tree",
                                     FullPathOfPoster = "C:\\Users\\Lizalise LizHackSA\\Pictures\\Wallpaper HD\\tree.jpg",
                                     IsSelected = false
                              },
                              new EventItemVM
                              {
                                     NameOfEvent = "Calm Blue water",
                                     FullPathOfPoster = "C:\\Users\\Lizalise LizHackSA\\Pictures\\Wallpaper HD\\calm.jpg",
                                     IsSelected = false
                              },
                              new EventItemVM
                              {
                                     NameOfEvent = "Flower",
                                     FullPathOfPoster = "C:\\Users\\Lizalise LizHackSA\\Pictures\\Wallpaper HD\\51241.jpg",
                                     IsSelected = false
                              },
                              new EventItemVM
                              {
                                     NameOfEvent = "Night Sky",
                                     FullPathOfPoster = "C:\\Users\\Lizalise LizHackSA\\Pictures\\Wallpaper HD\\nightsky.jpg",
                                     IsSelected = false
                              },
                              new EventItemVM
                              {
                                     NameOfEvent = "Bubble",
                                     FullPathOfPoster = "C:\\Users\\Lizalise LizHackSA\\Pictures\\Wallpaper HD\\bubble.jpg",
                                     IsSelected = false
                              }
                     };
              }

              #endregion

       }
}
