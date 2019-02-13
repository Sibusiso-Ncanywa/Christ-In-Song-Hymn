using LizHackMethods.Enums;

namespace ChristInSong.Core
{
    /// <summary>
    /// A view model for each favourite song item
    /// </summary>
    public class FavouriteItemDesignViewModel:FavouriteItemViewModel
    {

        #region Public singleton

        public static FavouriteItemDesignViewModel Instance => new FavouriteItemDesignViewModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public FavouriteItemDesignViewModel()
        {
            Inintials = "CIS";
            Name = "Watchman blow the gospel trumpet";
            SongNumberAndType = "1 | Christ In Song";
            BackgroundRGB = "FF00FF00";
            NewFavourite = true;
            TheHymnType = HymnType.ChristInSong;
        }
        
        #endregion
    }
}
