using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristInSong.Core
{
       /// <summary>
       /// The design time data for a <see cref="EventItemVM"/>
       /// </summary>
       public class EventItemVMDesignModel : EventItemVM
       {
              #region Public Singleton
              // Singleton is a single instance of something, e.g and instance of a class

              /// <summary>
              /// Gets a new fav songlistItem, A single instance
              /// </summary>
              public static EventItemVMDesignModel Instance => new EventItemVMDesignModel();
              
              #endregion

              #region constructor

              /// <summary>
              /// Default constructor
              /// </summary>
              public EventItemVMDesignModel()
              {
                     NameOfEvent = "LizHack SA";
                     FullPathOfPoster = "C:\\Users\\Lizalise LizHackSA\\Pictures\\Wallpaper HD\\LizHack.jpg";
                     IsSelected = false;
              }

              #endregion

       }
}
