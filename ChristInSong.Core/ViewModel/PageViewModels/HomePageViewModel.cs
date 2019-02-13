using LizHackMethods.Enums;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// The view model for a welcome page window
    /// </summary>
    public class HomePageViewModel : BaseViewModel
    {
        #region private members

        /// <summary>
        /// The song number chosen by the user
        /// </summary>
        private string mSongNumberChosen;

        #endregion
        
        #region Protected member

        /// <summary>
        /// The last searched text in the list
        /// </summary>
        protected string mLastSearchedText;

        /// <summary>
        /// The text to search for
        /// </summary>
        protected string mSearchText;

        /// <summary>
        /// A collection of both hymn "books"
        /// </summary>
        protected ObservableCollection<SearchItemVM> mListOfAllSongs = CoreDi.VM_Application_Dna.ConvertAllSongsToSearchItems();

        /// <summary>
        /// Flag indicating that the search is open
        /// </summary>
        protected bool mSearchIsOpen;

        #endregion

        #region Public members
        
        /// <summary>
        /// A collection of both hymn "books".
        /// DO NOT CALL THIS LIST!!!!!!!
        /// </summary>
        public ObservableCollection<SearchItemVM> TheCollectionOfCiS_AHymn
        {
            get => mListOfAllSongs;
            set
            {
                // make sure the list has changed
                if (mListOfAllSongs == value)
                    return;
                mListOfAllSongs = value;

                // update the filtered list
                TheFilteredList = new ObservableCollection<SearchItemVM>(mListOfAllSongs);
            }
        }

        /// <summary>
        /// A collection of both hymns that include any search filtering
        /// </summary>
        public ObservableCollection<SearchItemVM> TheFilteredList { get; set; }

        /// <summary>
        /// The text to search for when we do a search
        /// </summary>
        public string SearchText
        {
            get => mSearchText;
            set
            {
                if (mSearchText == value)
                    return;
                // update the value
                mSearchText = value;

                // if search is empty
                if (string.IsNullOrEmpty(SearchText))
                    // search to restore messages
                    SearchMethod();
            }
         }

        /// <summary>
        /// Flag indicating if the search dialog is open
        /// </summary>
        public bool SearchIsOpen
        {
            get => mSearchIsOpen;
            set
            {
                if (mSearchIsOpen == value)
                    return;

                // update value
                mSearchIsOpen = value;

                // set the filtered list to empty
                TheFilteredList = new ObservableCollection<SearchItemVM>();

                // if dialog closes
                if (!mSearchIsOpen)
                { 
                    // clear the search text
                    SearchText = string.Empty;
                }
            }
        }

        /// <summary>
        /// Indicator if the search is running
        /// </summary>
        public bool SearchIsRunning { get; set; } = false;
        
        /// <summary>
        /// Flag indicating if the search was successful
        /// </summary>
        public bool SearchItemNotFound { get; set; }

        /// <summary>
        /// Flag indicating if the file is loading.
        /// </summary>
        public bool IsLoadingFile { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Go to the Developer page
        /// </summary>
        public ICommand GoToDevDetails { get; set; }

        /// <summary>
        /// Go to the Display song page
        /// </summary>
        public ICommand GoToAdventHymn { get; set; }

        /// <summary>
        /// Go to the Display song page
        /// </summary>
        public ICommand GoToChristInSong { get; set; }

        /// <summary>
        /// Go to the Announcements page
        /// </summary>
        public ICommand GoToAnnouncements { get; set; }

        /// <summary>
        /// Go to the Events page
        /// </summary>
        public ICommand GoToEvents { get; set; }

        /// <summary>
        /// Go to the Doxology page
        /// </summary>
        public ICommand GoToDoxology { get; set; }

        /// <summary>
        /// Go to the Sermon slides page
        /// </summary>
        public ICommand GoToSermonSlides { get; set; }


        /// <summary>
        /// Command for opening the search dialog
        /// </summary>
        public ICommand OpenSearchCommand { get; set; }

        /// <summary>
        /// Command for  when the user want to search
        /// </summary>
        public ICommand SearchCommand { get; set; }

        /// <summary>
        /// Command for clearing the search text
        /// </summary>
        public ICommand ClearSearchCommand { get; set; }

        /// <summary>
        /// Command for  Closing the search dialog
        /// </summary>
        public ICommand CloseSearchCommand { get; set; }
   
        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public HomePageViewModel()
        {
            //  generate methods
            GenerateCommands();

            // set the filter list
            TheFilteredList = new ObservableCollection<SearchItemVM>();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Goes to the doxology page
        /// </summary>
        /// <returns></returns>
        private async Task DoxologyAsync()
        {
            //Go to the Doxology page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Doxology);

            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Goes to the Events page
        /// </summary>
        /// <returns></returns>
        private async Task EventsAsync()
        {
            //Go to the Events Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Events);

            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Goes to the announcement page
        /// </summary>
        /// <returns></returns>
        private async Task AnnouncementsAsync()
        {
            //Go to the Announcements Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Announcements);
                 
            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Goes to the developer info page
        /// </summary>
        private async Task GoToDevPageAsync()
        {
            //Go to the Developer details Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.DeveloperInfo);

            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Goes to the Christ in song hymnal
        /// </summary>
        /// <param name="parameter"> The song number </param>
        /// <returns></returns>
        private async Task ChristInSongAsycAsync(object parameter)
        {
            // get the song number chosen
            mSongNumberChosen = (string)parameter;

            // check if the song number is a valid number
            if (!GeneralMethods.IsStringValid(mSongNumberChosen)) return;

            // check if the song exists
            if (!GeneralMethods.CheckIfTheSongExists(mSongNumberChosen, HymnType.ChristInSong))
                return;

            // give the song to the application VM
            //Go to the display-song Page
            CoreDi.VM_Application_Dna.GoToDisplaySongPageVoid(ApplicationPageType.DisplaySong, mSongNumberChosen, HymnType.ChristInSong);

            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Goes to the Advent hymnal
        /// </summary>
        /// <param name="parameter"> The song number </param>
        /// <returns></returns>
        private async Task AdventHymnAsync(object parameter)
        {
            // get the song number chosen
            mSongNumberChosen = (string)parameter;

            // check if the song number is a valid number
            if (!GeneralMethods.IsStringValid(mSongNumberChosen)) return;

            // check if the song exist
            if (!GeneralMethods.CheckIfTheSongExists(mSongNumberChosen, HymnType.AdventHymn))
                return;

            //Go to the Display-song Page
            CoreDi.VM_Application_Dna.GoToDisplaySongPageVoid(ApplicationPageType.DisplaySong, mSongNumberChosen, HymnType.AdventHymn);

            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Open the search dialog
        /// </summary>
        public void OpenTheSearchDialog()
        {
            // Toggle between true and false for the visibility of the search result menu
            SearchIsOpen = true;
            CoreDi.VM_Application_Dna.SearchSideMenuVisible = true;
        }
        
        /// <summary>
        /// Searches the current title and filters the list
        /// </summary>
        public void SearchMethod()
        {
            var List = new ObservableCollection<SearchItemVM>();
            // make sure that we don't research
            if ((string.IsNullOrEmpty(mLastSearchedText) && string.IsNullOrEmpty(SearchText)) || string.Equals(mLastSearchedText, SearchText))
                return;
            // if we have no text, or no items
            if (string.IsNullOrEmpty(SearchText) || TheCollectionOfCiS_AHymn == null || TheCollectionOfCiS_AHymn.Count <= 0)
            {
                // make filter list the same
                List = new ObservableCollection<SearchItemVM>();
                TheFilteredList = List;
                mLastSearchedText = SearchText;
                return;
            }
            
            // Find all songs with the given text
            List = new ObservableCollection<SearchItemVM>(TheCollectionOfCiS_AHymn.Where(songTitle => songTitle.NameOfSong.Contains(SearchText)));
            TheFilteredList = List;

            // inform the user
            if (TheFilteredList.Count <= 0)
            {
                // inform the user
                Task.Run(async () =>
                {
                    // used to show the instructions menu
                    SearchItemNotFound = true;

                    // wait for 1 millisecond
                    await Task.Delay(TimeSpan.FromSeconds(5));

                    // reset is loading to false
                    SearchItemNotFound = false;
                });
            }

            // set last search
            mLastSearchedText = SearchText;

        }

        /// <summary>
        /// Clears the search text
        /// </summary>
        public void ClearSearchMethod()
        {
            // if there is some search text
            if (!string.IsNullOrEmpty(SearchText))
                // clear the text
                SearchText = string.Empty;
            // otherwise
            else
            {
                // close the search dialog
                SearchIsOpen = false;
                CoreDi.VM_Application_Dna.SearchSideMenuVisible = false;
            }
        }

        /// <summary>
        /// Close the search dialog
        /// </summary>
        public void CloseSearchMethod()
        {
            // Toggle between true and false for the visibility of the search result menu
            SearchIsOpen = false;
            CoreDi.VM_Application_Dna.SearchSideMenuVisible  = false;
        }

        /// <summary>
        ///  Go to the sermon slides page
        /// </summary>
        private async Task GoToSermonSlidesMethod()
        {
            // TO-DO: Go to the sermon Slides page

            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// generates the commands of this view model
        /// </summary>
        private void GenerateCommands()
        {

            #region Commands without parameters
            
            OpenSearchCommand = new RelayCommand(OpenTheSearchDialog);
            CloseSearchCommand = new RelayCommand(CloseSearchMethod);
            SearchCommand = new RelayCommand(SearchMethod);
            ClearSearchCommand = new RelayCommand(ClearSearchMethod);
            GoToSermonSlides = new RelayCommand(async () => await GoToSermonSlidesMethod());

            GoToEvents = new RelayCommand(async () => await EventsAsync());
            GoToDoxology = new RelayCommand(async () => await DoxologyAsync());
            GoToDevDetails = new RelayCommand(async () => await GoToDevPageAsync());
            GoToAnnouncements = new RelayCommand(async () => await AnnouncementsAsync());

            #endregion

            #region Commands with parameters

            GoToAdventHymn = new RelayParameterizedCommand(async (parameter) => await AdventHymnAsync(parameter));
            GoToChristInSong = new RelayParameterizedCommand(async (parameter) => await ChristInSongAsycAsync(parameter));

            #endregion

        }

        #endregion

    }
}
