using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristInSong.Core
{
    /// <summary>
    /// The page type 
    /// </summary>
    public enum ApplicationPageType
    {
        /// <summary>
        /// The home page
        /// </summary>
        Home = 0,

        /// <summary>
        /// The page to diplay a song chosen
        /// </summary>
        DisplaySong = 1,

        /// <summary>
        /// The edit song page
        /// </summary>
        EditSong = 2,

        /// <summary>
        /// The events page
        /// </summary>
        Events = 3,

        /// <summary>
        /// The anouncements page
        /// </summary>
        Announcements = 4,

        /// <summary>
        /// The Doxology page
        /// </summary>
        Doxology = 5,

        /// <summary>
        /// The developer Info page
        /// </summary>
        DeveloperInfo = 6,

        /// <summary>
        /// The Welcome page
        /// </summary>
        Welcome = 7,

        /// <summary>
        /// The Fullscreen view page
        /// </summary>
        FullscreenView = 8
    }
}
