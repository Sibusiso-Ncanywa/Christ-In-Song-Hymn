using LizHackMethods.Enums;
using LizHackMethods.LogicMethods;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// The view model for a welcome page window
    /// </summary>
    public class EditSongViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The name/title of the song
        /// </summary>
        public string NameOfSong { get; set; }

        /// <summary>
        /// The key signature of the song
        /// </summary>
        public string KeySignatureOfSong { get; set; }

        /// <summary>
        /// The Song number of the song
        /// </summary>
        public string TheSongNumber { get; set; }

        /// <summary>
        /// The Lyrics of the song
        /// </summary>
        public string SongLyrics { get; set; }

        /// <summary>
        /// The type of hymnal this song belongs to
        /// </summary>
        public HymnType TheHymnTypeOfSong { get; set; }

        /// <summary>
        /// Flag indicating if the page is loading or not
        /// </summary>
        public bool IsLoading { get; set; }

        /// <summary>
        /// Flag indicating if the page is loading or not
        /// </summary>
        public bool IsDoneSaving { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Go to the Display song page
        /// </summary>
        public ICommand GoToDisplaySongPage { get; set; }
        
        /// <summary>
        /// Go to the Doxology page
        /// </summary>
        public ICommand GoToHomePage { get; set; }

        /// <summary>
        /// Add song to favorite list
        /// </summary>
        public ICommand RemoveSongCache { get; set; }

        /// <summary>
        /// Go to the Developer page
        /// </summary>
        public ICommand SaveSongDetails { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default contructor
        /// </summary>
        public EditSongViewModel()
        {
            // get the favourite songlist from the cache file
            // This task waits for ten seconds before showing the message
            Task.Run(async () =>
            {
                // instead use this:
                var songToView = CoreDi.VM_Application_Dna.GetTheSongToView();

                // pass the read string to the methods and return the song to sing
                var theExpectedSongToView = GeneralMethods.ExtractAndReturnSong(songToView);

                /// if <see cref="theExpectedSonToView"/> is null go back to the home page
                if (theExpectedSongToView == null)
                {
                    //Go to the Home Page
                    CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);

                    // inform the user
                    GUI_RelatedMethodsCore.InformTheUser("The song was not found!");
                }

                
                // exctact the info
                NameOfSong = theExpectedSongToView.Name;
                TheSongNumber = theExpectedSongToView.SongNumber;
                SongLyrics = theExpectedSongToView.Lyrics;
                TheHymnTypeOfSong = theExpectedSongToView.ChristInSongOrAdventHymn;

                // get the cached key signature of the song
                var key = GeneralMethods.GetKeySignatureCache(TheSongNumber, TheHymnTypeOfSong);

                switch (string.IsNullOrEmpty(key))
                {
                    case true:
                        KeySignatureOfSong = theExpectedSongToView.KeySignature;
                        break;

                    case false:
                        KeySignatureOfSong = key;
                        break;
                }

                // display the instructions
                IsLoading = true;

                // fire off the property changed event
                ChangedTheProperty();
                
                //  generate methods
                GenerateCommands();

                // wait for 1 milisecond
                await Task.Delay(TimeSpan.FromSeconds(20));

                IsLoading = false;

            });
            
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Goes to the home page
        /// </summary>
        /// <returns></returns>
        private void GoToHomePageVoidMethod()
        {
            //Go to the Events Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);
        }
        
        /// <summary>
        /// Goes to the display song page
        /// </summary>
        /// <returns></returns>
        private void GoToDisplaySongPageVoidMethod()
        {
            //Go to the Display song Page
            switch (TheHymnTypeOfSong)
            {
                case HymnType.AdventHymn:
                    CoreDi.VM_Application_Dna.GoToDisplaySongPageVoid(ApplicationPageType.DisplaySong, TheSongNumber, HymnType.AdventHymn);
                    break;
                case HymnType.ChristInSong:
                    CoreDi.VM_Application_Dna.GoToDisplaySongPageVoid(ApplicationPageType.DisplaySong, TheSongNumber, HymnType.ChristInSong);
                    break;
                
            }
        }

        /// <summary>
        /// Removes the cached details of the song.
        /// The song details are: Lyrics and the key signature of the song.
        /// </summary>
        /// <returns></returns>
        private void RemoveSongCacheVoidMethod()
        {

            switch (TheHymnTypeOfSong)
            {
                // Save the song
                case HymnType.AdventHymn:
                    SongLyrics = GeneralMethods.RemoveSongCache(TheSongNumber,HymnType.AdventHymn);
                    KeySignatureOfSong = GeneralMethods.RemoveKeySignatureCache(TheSongNumber,HymnType.AdventHymn);
                    break;
                case HymnType.ChristInSong:
                    SongLyrics = GeneralMethods.RemoveSongCache(TheSongNumber,HymnType.ChristInSong);
                    KeySignatureOfSong = GeneralMethods.RemoveKeySignatureCache(TheSongNumber,HymnType.ChristInSong);
                    break;
            }

            // show the done message
            Task.Run(async () =>
            {
                // show when done
                IsDoneSaving = true;

                // wait for 3 seconds
                await Task.Delay(TimeSpan.FromSeconds(3));
                // reset the value
                IsDoneSaving = false;
            });
            
        }

        /// <summary>
        /// Saves the song details to the cache file.
        /// the details are: Lyrics and the key signature of the song
        /// </summary>
        /// <returns></returns>
        private void SaveSongDetailsVoidMethod()
        {
            switch(TheHymnTypeOfSong)
            {
                // Save the song
                case HymnType.AdventHymn:
                    AdventHymnMethods.UpdateAdventSongLyrics(TheSongNumber, SongLyrics);
                    GeneralMethods.SaveSongKeySignatureToCache(TheSongNumber, KeySignatureOfSong,HymnType.AdventHymn);
                    break;

                case HymnType.ChristInSong:
                    CIS_LogicMethods.UpdateSongLyrics(TheSongNumber, SongLyrics);
                    GeneralMethods.SaveSongKeySignatureToCache(TheSongNumber, KeySignatureOfSong,HymnType.ChristInSong);
                    break;
            }

            // show the done message
            Task.Run(async () =>
            {
                // show when done
                IsDoneSaving = true;

                // wait for 3 seconds
                await Task.Delay(TimeSpan.FromSeconds(3));
                // reset the value
                IsDoneSaving = false;
            });
        }
        
        #endregion

        #region Helper methods

        /// <summary>
        /// Fires off the property changed event
        /// </summary>
        private void ChangedTheProperty()
        {
            OnPropertyChanged(nameof(NameOfSong));
            OnPropertyChanged(nameof(KeySignatureOfSong));
            OnPropertyChanged(nameof(TheSongNumber));
            OnPropertyChanged(nameof(SongLyrics));
            OnPropertyChanged(nameof(TheHymnTypeOfSong));
        }

        /// <summary>
        /// generates the commands
        /// </summary>
        private void GenerateCommands()
        {
            GoToHomePage = new RelayCommand(GoToHomePageVoidMethod);
            GoToDisplaySongPage = new RelayCommand(GoToDisplaySongPageVoidMethod);
            RemoveSongCache = new RelayCommand(RemoveSongCacheVoidMethod);
            SaveSongDetails = new RelayCommand(SaveSongDetailsVoidMethod);
        }


        #endregion

    }
}
