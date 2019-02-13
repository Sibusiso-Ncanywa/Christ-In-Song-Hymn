using LizHackMethods.Classes;
using LizHackMethods.Enums;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// The Application state as a view model
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Protected members

        /// <summary>
        /// Stores the favourite songs
        /// </summary>
        protected ObservableCollection<FavouriteItemViewModel> mProtectedFavourites = new ObservableCollection<FavouriteItemViewModel>();

        /// <summary>
        /// Stores the events
        /// </summary>
        protected ObservableCollection<EventItemVM> mProtectedEvents = new ObservableCollection<EventItemVM>();

        /// <summary>
        /// Stores all songs as search items
        /// </summary>
        protected ObservableCollection<SearchItemVM> mProtectedSearchItems = new ObservableCollection<SearchItemVM>();
        #endregion

        #region Private members

        /// <summary>
        /// The song to be viewed
        /// </summary>
        private string TheSongToView { get; set; }

        /// <summary>
        /// The hype of hymn to use
        /// </summary>
        private int TypeOfHymnUsed { get; set; }
        
        /// <summary>
        /// Event to view full screen
        /// </summary>
        private EventItemVM TheEventToView { get; set; }

        #endregion

        #region Public members
        
        /// <summary>
        /// True if the fav list should be shown
        /// </summary>
        public bool FavListSideMenuVisible { get; set; } = false;

        /// <summary>
        /// True if the side menu should be visible
        /// </summary>
        public bool SearchSideMenuVisible { get; set; } = false;

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPageType CurrentPage { get; private set; } = ApplicationPageType.Welcome;

        /// <summary>
        /// The song to add to the favorites list
        /// </summary>
        public string SongNumberChosen { get; set; }

        /// <summary>
        /// Flag indicating if the favorites list is loading.
        /// </summary>
        public bool IsLoadingFavourites { get; set; }
        
        /// <summary>
        /// Flag indicating if the adding of a favorite song item is successful.
        /// </summary>
        public bool IsDoneSaving { get; set; }

        /// <summary>
        /// Flag for hiding the favorite menu bar of other favorites.
        /// </summary>
        public bool HideOtherMenu { get; set; } = false;

        #endregion

        #region Events
        
        /// <summary>
        /// The list of events stored
        /// </summary>
        public ObservableCollection<EventItemVM> SavedEvents
        {
            get => mProtectedEvents;
            set
            {
                // if the value hasn't changed...
                if (mProtectedEvents == value)
                    return;

                // otherwise
                mProtectedEvents = value;
            }
        }

        /// <summary>
        /// Adds to the event list
        /// </summary>
        /// <param name="eventItem"> event to add </param>
        /// <returns></returns>
        public ObservableCollection<EventItemVM> AddToTheEventList(EventItemVM eventItem)
        {
            SavedEvents.Add(eventItem);
            return SavedEvents;
        }

        /// <summary>
        /// Gets the cached favorite songs
        /// </summary>
        private void GetTheCachedEvents()
        {
            // A list of fav song list saved locally
            var TheCache = GeneralMethods.GetEventDetails();

            // check if there are songs found
            if (TheCache.Count < 0) return;

            // add the events to the view model
            for (var i = 0; i < TheCache.Count; i++)
            {
                // make a temp item
                var temp = TheCache[i].Split('|');
                // create a favourite song list item
                mProtectedEvents.Add(new EventItemVM
                {
                    NameOfEvent = temp[0],
                    FullPathOfPoster = temp[1],
                    IsNewEvent = false
                });
            }
        }

        #endregion

        #region Favourites

        /// <summary>
        /// The list of favourite songs stored
        /// </summary>
        public ObservableCollection<FavouriteItemViewModel> SavedSongs
        {
            get => mProtectedFavourites;
            set
            {
                // if the value hasn't changed...
                if (mProtectedFavourites == value)
                    return;

                // otherwise
                mProtectedFavourites = value;
            }

        }

        /// <summary>
        /// Adds to the favourite song list
        /// </summary>
        /// <param name="FavouriteSongItem"> song to add </param>
        /// <returns></returns>
        public ObservableCollection<FavouriteItemViewModel> AddToTheFavouriteSongList(FavouriteItemViewModel FavouriteSongItem)
        {
            SavedSongs.Add(FavouriteSongItem);
            return SavedSongs;
        }

        /// <summary>
        /// Gets the cached favorite songs
        /// </summary>
        private void GetTheCachedFavourites()
        {
            // A list of fav song list saved locally
            var TheCache = GeneralMethods.GetCachedFavoriteSongList();

            // check if there are songs found
            if (TheCache.Count < 0) return;

            // add the events to the view model
            for (var i = 0; i < TheCache.Count; i++)
            {
                var song = TheCache[i];
                // create a favourite song list item
                mProtectedFavourites.Add(new FavouriteItemViewModel
                {
                    Name = song.Name,
                    SongNumber = song.SongNumber,
                    Inintials = song.ChristInSongOrAdventHymn == HymnType.AdventHymn ? "AH" : "CIS",
                    SongNumberAndType = song.ChristInSongOrAdventHymn == HymnType.AdventHymn ? $"{song.SongNumber} | Advent Hymn" : $"{song.SongNumber} | Christ In Song",
                    TheHymnType = song.ChristInSongOrAdventHymn,
                    NewFavourite = false,
                    BackgroundRGB = GeneralMethods.StringColourSelector()
                });
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Adds a song to the list of Favourite songs and also to the song cache file
        /// </summary>
        public ICommand AddTheSongCommand { get; set; }
        
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ApplicationViewModel()
        {
            Task.Run(async () =>
            {
                // used to show the instructions menu
                IsLoadingFavourites = true;

                // wait for 1 milisecond
                await Task.Delay(TimeSpan.FromSeconds(10));

                // reset is loading to false
                IsLoadingFavourites = false;
            });

            // Get the cached events
            GetTheCachedEvents();

            // Get the cached favourite songs
            GetTheCachedFavourites();

            // get all songs and convert to search Items
            mProtectedSearchItems = ConvertTOSearchItems(GeneralMethods.FindAllSongs());

            // generates commands
            AddTheSongCommand = new RelayCommand(AddTheSongVoidMethod);

        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Adds a song to the favourite song list
        /// </summary>
        public void AddTheSongVoidMethod()
        {
            // check the song
            if(string.IsNullOrEmpty(SongNumberChosen))
            {
                GUI_RelatedMethodsCore.InformTheUser("Eish San! I could't find the song. Sorry...");
                return;
            }

            // get the song number
            var TheSongIs = GeneralMethods.FindTheFavouriteSong(SongNumberChosen);

            // check if the song is not null
            if (TheSongIs is null) return;

            // add the song to the favourite song cche file
            var Added = GeneralMethods.SaveFavSongToCache(TheSongIs);

            // check if the saving was successfull
            if (!Added) return;

            // get the hymn type in text form
            var stringVerOfHymnType = GeneralMethods.StringVersionOfHymnType(TheSongIs.ChristInSongOrAdventHymn);

            // the new song to the list
           var newFavSong = new FavouriteItemViewModel
            {
                Inintials = TheSongIs.ChristInSongOrAdventHymn == HymnType.AdventHymn ? "AH" : "CIS",
                Name = TheSongIs.Name.Trim(),
                SongNumberAndType = $"{TheSongIs.SongNumber} | {stringVerOfHymnType}",
                SongNumber = TheSongIs.SongNumber,
                TheHymnType = TheSongIs.ChristInSongOrAdventHymn,
                BackgroundRGB = GeneralMethods.StringColourSelector(),
                NewFavourite = true
            };

            // Add the song at the begining of the list
            SavedSongs.Insert(0, newFavSong);

            DoneWorking();
        }

        /// <summary>
        /// Informs the user that the work was successful
        /// </summary>
        public void DoneWorking()
        {
            // inform the user
            Task.Run(async () =>
            {
                // used to show the instructions menu
                IsDoneSaving = true;

                // wait for 1 milisecond
                await Task.Delay(TimeSpan.FromSeconds(5));

                // reset is loading to false
                IsDoneSaving = false;
            });
        }

        #endregion
        
        #region Navigation  Methods

        /// <summary>
        /// Gets the event to be show in full screen
        /// </summary>
        /// <returns></returns>
        public EventItemVM GetFullScreenEvent() => TheEventToView;

        /// <summary>
        /// Gets the song number and the type of hymn used of the song to be viewed.
        /// </summary>
        /// <returns></returns>
        public string GetTheSongToView() => $"{TheSongToView}|{TypeOfHymnUsed}";
        
        /// <summary>
        /// Navigate to specified to the Edit/Display song page
        /// </summary>
        /// <param name="page"> The page to go to</param>
        public void GoToDisplaySongPageVoid(ApplicationPageType page, string songToView, HymnType type)
        {
            // set the song to view the type of hymn to use
            TheSongToView = songToView;
            TypeOfHymnUsed = (int)type;

            // set the current page
            CurrentPage = page;

            // show side menu if current page is home
            FavListSideMenuVisible = false;
        }
        
        /// <summary>
        /// Navigate to specified to the View Full screen Event image
        /// </summary>
        /// <param name="page"> The page to go to</param>
        /// <param name="page"> The the event to view</param>
        public void GoToViewFullScreenPageVoid(ApplicationPageType page, EventItemVM eventItem)
        {
            // set the song to view the type of hymn to use
            TheEventToView = eventItem;

            // set the current page
            CurrentPage = page;

            // 
            FavListSideMenuVisible = false;
        }
        
        /// <summary>
        /// Navigate to specified page
        /// </summary>
        /// <param name="page"> The page to go to</param>
        public void GoToPage(ApplicationPageType page)
        {
            // set the current page
            CurrentPage = page;

            // show side menu if current page is home
            FavListSideMenuVisible = page == ApplicationPageType.Home;
            
            // Hide the search bar on other pages
            if (page != ApplicationPageType.Home) SearchSideMenuVisible = false;

        }

        #endregion

        #region Search Methods

        /// <summary>
        /// Gets all songs and converst them to search items
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<SearchItemVM> ConvertAllSongsToSearchItems() => mProtectedSearchItems;

        /// <summary>
        /// Converts from The songclass to the view model list
        /// </summary>
        /// <param name="VmList"> the list to convert </param>
        /// <returns></returns>
        public static ObservableCollection<SearchItemVM> ConvertTOSearchItems(ObservableCollection<SongClass> VmList)
        {
            // temp store the list
            var SearchList = new ObservableCollection<SearchItemVM>();
            NewMethod(VmList, SearchList);

            // return the songlist
            return SearchList;
        }

        /// <summary>
        /// Converts from Songclass to search Item and add to the search item list.
        /// </summary>
        /// <param name="VmList"> The songclass list</param>
        /// <param name="SearchList"> The list to to convert </param>
        private static void NewMethod(ObservableCollection<SongClass> VmList, ObservableCollection<SearchItemVM> SearchList)
        {
            // loop through the vmlist and create a songlist 
            for (var i = 0; i < VmList.Count; i++)
            {
                // get the hymn type of the song
                var initials = VmList[i].ChristInSongOrAdventHymn == HymnType.ChristInSong ? "CIS" : "AH";
                var songName = VmList[i].Name;

                var fulltype = VmList[i].ChristInSongOrAdventHymn == HymnType.ChristInSong ? "Christ In Song" : "Advent Hymn";
                var Songnumber = VmList[i].SongNumber;
                var numberAndType = $"{Songnumber} | {fulltype}";
                var bgColour = GeneralMethods.StringColourSelector();

                // add the song to the list
                SearchList.Add(new SearchItemVM
                {
                    InitialOfTheSongType = initials,
                    NameOfSong = songName,
                    NumberAndType = numberAndType,
                    BackgroundColorRGB = bgColour,
                    IsSelected = false
                });
            }
        }

        #endregion
    }
}
