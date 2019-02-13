using LizHackMethods.Enums;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    public class DisplayASongViewModel : BaseViewModel
    {
        #region private members

        #endregion

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
        public HymnType HymnType { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Goes to the edit song page
        /// </summary>
        public ICommand EditThisSong { get; set; }

        /// <summary>
        /// Goes to the home page
        /// </summary>
        public ICommand GoToHome { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default contructor
        /// </summary>
        public DisplayASongViewModel()
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
                HymnType = theExpectedSongToView.ChristInSongOrAdventHymn;

                // get the cached key signature of the song
                var key = GeneralMethods.GetKeySignatureCache(TheSongNumber, HymnType);

                switch (string.IsNullOrEmpty(key))
                {
                    case true:
                        KeySignatureOfSong = theExpectedSongToView.KeySignature;
                        break;

                    case false:
                        KeySignatureOfSong = key;
                        break;
                }
                
                // wait for 1 milisecond
                await Task.Delay(TimeSpan.FromMilliseconds(200));

            });
            // fire off the property changed event
            ChangedTheProperty();

            //  generate methods
            GenerateCommands();
        }

        #endregion

        #region Command methods

        /// <summary>
        /// Goes to the edit song page
        /// </summary>
        /// <returns></returns>
        private async Task EditThisSongAsync()
        {
            //Go to the Edit song Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.EditSong);

            // wait for one milisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Goes to the home page
        /// </summary>
        /// <returns></returns>
        private async Task GoToHomeAsync()
        {
            //Go to the Home Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);

            // wait for one milisecond and continue
            await Task.Delay(1);
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
            OnPropertyChanged(nameof(HymnType));
        }

        /// <summary>
        /// generates the commands of this view model
        /// </summary>
        private void GenerateCommands()
        {
            #region Commands with parameters 

            EditThisSong = new RelayCommand(async () => await EditThisSongAsync());

            #endregion

            #region Commands without parameters

            GoToHome = new RelayCommand(async () => await GoToHomeAsync());


            #endregion

        }

        #endregion

    }
}
