namespace ChristInSong.Core
{
    /// <summary>
    /// Details for a message box dialog
    /// </summary>
    public class MessageBoxDialogViewModel:BaseDialogViewModel
    {
        #region Public members

        /// <summary>
        /// The message to be shown.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The text to use for the ok buttons
        /// </summary>
        public string OkText { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MessageBoxDialogViewModel()
        {

        }
        #endregion
    }
}
