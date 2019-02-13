using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristInSong.Core
{
    /// <summary>
    /// The design time data for a <see cref="FavoriteSongItemVM"/>
    /// </summary>
    public class SearchItemDesignModel : SearchItemVM
    {
        #region Public Singleton

        // Singleton is a single instance of something, e.g and instance of a class

        /// <summary>
        /// Gets a new fav songlistItem, A single instance
        /// </summary>
        public static SearchItemDesignModel Instance => new SearchItemDesignModel();

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SearchItemDesignModel()
        {
            InitialOfTheSongType = "CIS";
            NameOfSong = "Watchman blow the gospel trumpet";
            NumberAndType = "1 | Christ In Song";
            BackgroundColorRGB = "ffa800";
            IsSelected = false;
        }

        #endregion

    }
}
