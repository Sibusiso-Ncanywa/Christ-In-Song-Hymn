using System;

namespace ChristInSong.Core
{
    /// <summary>
    /// A view model for any pop-up menus
    /// </summary>
    public class WelcomePopupViewModel : BasePopupViewModel
    {
        #region Public Properties
        
        /// <summary>
        /// Header text of pop up
        /// </summary>
        public string HeaderText { get; set; }

        /// <summary>
        /// The message to show
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// Sets the default setting for the menu
        /// </summary>
        public bool ShowMenu { get; set; } = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public WelcomePopupViewModel()
        {
            ChangeTheContents();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Get the contents
        /// </summary>
        private void ChangeTheContents()
        {
            string thedayofweek = DateTime.Now.DayOfWeek == DayOfWeek.Saturday ? "Sabbath" : Convert.ToString(DateTime.Now.DayOfWeek);

            if ((DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour > 18) || (DateTime.Now.DayOfWeek == DayOfWeek.Saturday && DateTime.Now.Hour < 18))
            {
                thedayofweek = "Sabbath";
            }

            HeaderText = Convert.ToString(thedayofweek);
            var messagefound = GeneralMethods.GetTodaysMessage();
            Message = messagefound is null ? "No message to day" : messagefound;
            ShowMenu = messagefound is null ? false : true;
        }


        #endregion
    }
}
