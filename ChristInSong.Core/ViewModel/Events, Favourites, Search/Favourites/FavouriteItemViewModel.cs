using LizHackMethods.Enums;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// A view model for each favourite song item
    /// </summary>
    public class FavouriteItemViewModel:BaseViewModel
    {

        #region Public members

        /// <summary>
        /// The name of the song.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The Hymnal that the song belongs to.
        /// </summary>
        public HymnType TheHymnType { get; set; }

        /// <summary>
        /// The number of the song.
        /// </summary>
        public string SongNumber { get; set; }

        /// <summary>
        /// The hymn type of the song
        /// </summary>
        public string SongNumberAndType { get; set; }

        /// <summary>
        /// The Ininitias of the <see cref="TheHymnType"/>.
        /// </summary>
        public string Inintials { get; set; }

        /// <summary>
        /// The bckground colour of the <see cref="Inintials"/> in hex
        /// for example: FF00FF00 fro red and bluew mixed.
        /// </summary>
        public string BackgroundRGB { get; set; }

        /// <summary>
        /// True if the favourite is newly added
        /// </summary>
        public bool NewFavourite { get; set; }

        /// <summary>
        /// Flag indicating the song is removed
        /// </summary>
        public bool? IsRemoved { get; set; } = null;
        
        /// <summary>
        /// Flag for showing or hiding the favourite item menu
        /// </summary>
        public bool IsShowingMenu { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Command to view the current song
        /// </summary>
        public ICommand ViewFavouriteCommand { get; set; }

        /// <summary>
        /// Command to remove the current song
        /// </summary>
        public ICommand RemoveFavouriteCommand { get; set; }

        /// <summary>
        /// Command to show the menu
        /// </summary>
        public ICommand ShowMenuCommand { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// The default constructor
        /// </summary>
        public FavouriteItemViewModel()
        {
            // Generate commands
            ViewFavouriteCommand = new RelayCommand(ViewSongCommandVoidMethod);
            RemoveFavouriteCommand = new RelayCommand(RemoveSongCommandVoidMethod);
            ShowMenuCommand = new RelayCommand(ShowMenuCommandVoidMethod);
        }

        #endregion

        #region Command methods

        /// <summary>
        /// Views the current song
        /// </summary>
        public void ViewSongCommandVoidMethod()
        {
            // reset show menu
            IsShowingMenu = false;

            if (this is null) return;

            //Go to the display song Page
            CoreDi.VM_Application_Dna.GoToDisplaySongPageVoid(ApplicationPageType.DisplaySong, SongNumber, TheHymnType);
        }

        /// <summary>
        /// Shows/Hides the menu
        /// </summary>
        public void ShowMenuCommandVoidMethod()
        {
            IsShowingMenu ^= true;
        }

        /// <summary>
        /// Removes the poster
        /// </summary>
        public void RemoveSongCommandVoidMethod()
        {
            // reset show menu
            IsShowingMenu = false;

            // get the events
            var SongsStored = CoreDi.VM_Application_Dna.SavedSongs;

            // create a new list that doesn't have the event to remove
            ObservableCollection<FavouriteItemViewModel> itemVMs;

            // populate the new list with the events that will not be removed.
            itemVMs = new ObservableCollection<FavouriteItemViewModel>(
                SongsStored.Where(TheSongToRemove => !TheSongToRemove.Equals(this)));

            // Remove the song from the list
            if(!GeneralMethods.RemoveFavSongFromCache(SongNumber, TheHymnType))
            {
                GUI_RelatedMethodsCore.InformTheUser("The song could not be removed.");
                return;
            }
            
            /// set the new list of the songs
            /// update the list
            CoreDi.VM_Application_Dna.SavedSongs = itemVMs;

            // Inform the user of the success
            CoreDi.VM_Application_Dna.DoneWorking();
        }

        #endregion

    }
}
