using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ChristInSong.Core;

namespace Christ_in_song
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseDialogUserControl:UserControl
    {

        #region Private members

        /// <summary>
        /// The dialog window will be contained within
        /// </summary>
        private TheDialogWindow mDialogWindow;

        #endregion

        #region Public members

        /// <summary>
        /// The minimum width of the dialog window.
        /// </summary>
        public int WindowMinimumWidth { get; set; } = 350;

        /// <summary>
        /// The minimum width of the dialog window.
        /// </summary>
        public int WindowMinimumHeight { get; set; } = 150;

        /// <summary>
        /// The height of the title bar
        /// </summary>
        public int TitleHeight { get; set; } = 30;

        /// <summary>
        /// The title for this dialog window
        /// </summary>
        public string Title { get; set; } = "SDA Hymnal";

        #endregion

        #region Public Commands

        /// <summary>
        /// Closes this dialog
        /// </summary>
        public ICommand CloseCommand { get; private set; }

        #endregion


        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BaseDialogUserControl()
        {
            // if we are in design mode show the current page
            // the dependancy propety doesn't fire
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                // create a new dialog window
                mDialogWindow = new TheDialogWindow();
                mDialogWindow.ViewModel = new DialogWindowViewModel(mDialogWindow);
            }

            // close the current dialog
            CloseCommand = new RelayCommand(() => mDialogWindow.Close());
        }
        #endregion

        #region helper function

        /// <summary>
        /// Displays a single message to the user
        /// </summary>
        /// <param name="viewModel"> The view model </param>
        /// <param name="viewModel"> The view model type for this control </param>
        /// <returns></returns>
        public Task ShowDialog<T>(T viewModel)
            where T : BaseDialogViewModel
        {
            // Create a task to await the dialog closing
            var TaskCompletionSource = new TaskCompletionSource<bool>();

            // Run the UI THread
            Application.Current.Dispatcher.Invoke(() =>
            {
                // run this but do not catch the crash
                try
                {
                    // Match the controls to the expected sizes of the dialog windows view model
                    mDialogWindow.ViewModel.WindowMinimumWidth = WindowMinimumWidth;
                    mDialogWindow.ViewModel.WindowMinimumHeight = WindowMinimumHeight;
                    mDialogWindow.ViewModel.TitleHeight = TitleHeight;
                    mDialogWindow.ViewModel.Title = string.IsNullOrEmpty(viewModel.Title) ? Title : viewModel.Title;
                    
                    // set this control to the dialog window content
                    mDialogWindow.ViewModel.Content = this;

                    // set up the datacontext
                    DataContext = viewModel;

                    // Show in the center of this current window
                    mDialogWindow.Owner = Application.Current.MainWindow;
                    mDialogWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;

                    // show the dialog
                    mDialogWindow.ShowDialog();
                }
                finally
                {
                    // ;et the caller know we are finished
                    TaskCompletionSource.TrySetResult(true);
                }
            });

            return TaskCompletionSource.Task;
        }

        #endregion

    }
}
