using System.Threading.Tasks;

namespace ChristInSong.Core
{
    /// <summary>
    /// The UIMAnager that handles any UI interaction in the application
    /// </summary>
    public interface IUIManager
    {
        /// <summary>
        /// Displays a single message to the user
        /// </summary>
        /// <param name="viewModel"> The view model </param>
        /// <returns></returns>
        Task ShowMessage(MessageBoxDialogViewModel viewModel);
    }
}
