using System.Threading.Tasks;
using System.Windows;
using ChristInSong.Core;

namespace Christ_in_song
{
    /// <summary>
    /// The Applications implementation of the <see cref="UIManager"/>
    /// </summary>
    public class UIManager:IUIManager
    {
        /// <summary>
        /// Displays a single message to the user
        /// </summary>
        /// <param name="viewModel"> The view model </param>
        /// <returns></returns>
        public Task ShowMessage(MessageBoxDialogViewModel viewModel)
        {
            return new DialogMessageBox().ShowDialog(viewModel);
        }
    }
}
