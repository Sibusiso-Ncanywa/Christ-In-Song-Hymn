using ChristInSong.Core;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Christ_in_song
{
    /// <summary>
    /// The View Model for the custom flat window
    /// </summary>
    public class DialogWindowViewModel : WindowViewModel
    {
        #region Public Properties

        /// <summary>
        /// The title of this dialog window
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The content to host inside the dialog
        /// </summary>
        public Control Content { get; set; }

        /// <summary>
        /// The current dialog window
        /// </summary>
        public Window ThisDialog { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public DialogWindowViewModel(Window window) : base(window)
        {
            ThisDialog = window;
            CloseCommand = new RelayCommand(CloseTheDialog);

            // Make minimum size smaller
            WindowMinimumWidth = 350;
            WindowMinimumHeight = 150;

            // Make title bar smaller
            TitleHeight = 35;
        }

        /// <summary>
        /// Close the current dialog window
        /// </summary>
        private void CloseTheDialog()
        {
            ThisDialog.Close();
        }

        #endregion
    }
}
