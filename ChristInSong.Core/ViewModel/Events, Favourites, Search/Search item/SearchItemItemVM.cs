using LizHackMethods.Enums;
using LizHackMethods.LogicMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// View model for a fav song item
    /// </summary>
    public class SearchItemVM : BaseViewModel
    {

        #region Public properties

        /// <summary>
        /// The dispplay name of this fav song item
        /// </summary>
        public string NameOfSong { get; set; }

        /// <summary>
        /// The number and type of the song
        /// </summary>
        public string NumberAndType { get; set; }

        /// <summary>
        /// The numbe rof times the song has been used.
        /// </summary>
        public string NumberOfTimesUsed { get; set; }

        /// <summary>
        /// The initials of the song
        /// </summary>
        public string InitialOfTheSongType { get; set; }

        /// <summary>
        /// The color of the background of the initials.
        /// The values are in hex. example: ff00ff for red and blue mixed
        /// </summary>
        public string BackgroundColorRGB { get; set; }

        /// <summary>
        /// True if this Item is currently selected
        /// </summary>
        public bool IsSelected { get; set; } = false;
        
        /// <summary>
        /// The current song's index in the list of favourite songs
        /// </summary>
        public int IndexInTheList { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Go to the Display song page and views the current song
        /// </summary>
        public ICommand ViewThisSong { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SearchItemVM()
        {
            GenerateCommands();
        }

        #endregion

        #region Command methods
      
        /// <summary>
        /// Goes to the selected song hymnal and views it.
        /// </summary>
        /// <param name="parameter"> The song number </param>
        /// <returns></returns>
        private void ViewSongAsyc()
        {
            // get song details
            string[] songANDtype = NumberAndType.Split('|');
            string songNum = songANDtype[0].Trim();
            HymnType TheeType = InitialOfTheSongType == "CIS" ? HymnType.ChristInSong : HymnType.AdventHymn;
            
            // if the song type is bogus do nothing
            if ((int)TheeType > 1 || (int)TheeType < 0) return;

            // give the song to the application vm
            CoreDi.VM_Application_Dna.SearchSideMenuVisible = false;

            //Go to the displaysong Page
            CoreDi.VM_Application_Dna.GoToDisplaySongPageVoid(ApplicationPageType.DisplaySong, songNum, TheeType);
            
        }
        
        #endregion

        #region Helper methods

        /// <summary>
        /// generates the commands of this view model
        /// </summary>
        private void GenerateCommands()
        {
            ViewThisSong = new RelayCommand(ViewSongAsyc);
        }
        
        #endregion

    }
}
