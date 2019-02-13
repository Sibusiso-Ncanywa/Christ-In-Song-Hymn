using LizHackMethods.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ChristInSong.Core
{
    /// <summary>
    /// A view model for the overview favourites list
    /// </summary>
    public class FavouriteListItemViewModel:BaseViewModel
    {
        #region Public singiletons

        /// <summary>
        /// Allows acces to the favpurite song list stored.
        /// </summary>
        public static ObservableCollection<FavouriteItemViewModel> AccessToFavouriteSongs
        {
            get => CoreDi.VM_Application_Dna.SavedSongs;
            set
            {
                // make sure the list has changed
                if (CoreDi.VM_Application_Dna.SavedSongs == value)
                    return;

                // update the list of events
                CoreDi.VM_Application_Dna.SavedSongs = value;
            }
        }
        
        /// <summary>
        /// Flag indicating the song is added.
        /// </summary>
        public bool? IsAdded { get; set; } = null;
        
       
        #endregion

        #region Public members

        /// <summary>
        /// The favourite list of favourite songs
        /// </summary>
        public ObservableCollection<FavouriteItemViewModel> SavedSongs
        {
            get => AccessToFavouriteSongs;
            set
            {
                // make sure the list has changed
                if (AccessToFavouriteSongs == value)
                    return;

                // update the list of events
                AccessToFavouriteSongs = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public FavouriteListItemViewModel()
        {

        }

        #endregion

    }
}
