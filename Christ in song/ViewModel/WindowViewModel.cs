using ChristInSong.Core;
using System.Windows;
using System.Windows.Input;

namespace Christ_in_song
{
    /// <summary>
    /// The view model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {

        #region private members

        /// <summary>
        /// The window this model view controls
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// margin around the window to allow drop shadow
        /// </summary>
        private int mOuterMarginSize = 4;

        /// <summary>
        /// The curved edge of the window itself
        /// </summary>
        private int mWindowRadius = 8;

        /// <summary>
        /// The last known dock position
        /// </summary>
        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;

        #endregion

        #region Commands

        /// <summary>
        /// The command to minimise the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command to maximise the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// The command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to show the system menu of the window
        /// </summary>
        public ICommand MenuCommand { get; set; }

        /// <summary>
        /// the command to maximise a window and hide the buttons
        /// </summary>
        public ICommand MaxAndHide { get; set; }


        #endregion

        #region Public Members

        /// <summary>
        /// The smallest width the window can go to
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 1000;

        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 600;

        /// <summary>
        /// True if the window should be border-less because it is docked or maximized
        /// </summary>
        public bool Borderless => (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked);

        /// <summary>
        /// Size of the resize area around the window
        /// </summary>
        public int ResizeBorder => Borderless ? 0 : 4;

        /// <summary>
        /// The size of the resize border around the window, taking int account the outer margin
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder + OuterMarginSize);

        /// <summary>
        /// The padding of the inner content of the main window
        /// </summary>
        public Thickness InnerContentPadding => new Thickness(1/*ResizeBorder*/);

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            // If it is maximized or docked, no border
            get => Borderless ? 0 : mOuterMarginSize;
            set => mOuterMarginSize = value;
        }

        /// <summary>
        /// margin around the window to allow drop shadow
        /// </summary>
        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);

        /// <summary>
        /// The curved edge of the window itself
        /// </summary>
        public int WindowRadius
        {
            // If it is maximized or docked, no border
            get => Borderless ? 0 : mWindowRadius;
            set => mWindowRadius = value;
        }

        /// <summary>
        /// The curved edge of the window itself
        /// </summary>
        public CornerRadius WindowCornerRadius => new CornerRadius(4);

        /// <summary>
        /// the height of the title bar/caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 40;

        /// <summary>
        /// the height of the title bar/caption of the window
        /// </summary>
        public GridLength TitleHeightGridLength => new GridLength(TitleHeight + ResizeBorder);

        /// <summary>
        /// True if the window should have a dimmed overlay
        /// </summary>
        public bool DimmableOverlayVisible { get; set; }
        
        #endregion

        #region constructor

        /// <summary>
        /// default contructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            mWindow = window;

            // listen for the window resizing
            mWindow.StateChanged += (sende, e) =>
            {
                         // fire off an event for all properties that affeccted by a resize
                         WindowResized();
            };

            // Create commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            // ^ says: if the window state is 0 then maximise window, otherwise go to normal window
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);

            CloseCommand = new RelayCommand(() => GUI_RelatedMethodsCore.CloseAllWindows());

            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

            //// fix window resize issue
            var resizer = new WindowResizer(mWindow);

            //// Listen out for dock changes
            resizer.WindowDockChanged += (dock) =>
            {
                         // Store last position
                         mDockPosition = dock;

                         // Fire off resize events
                         WindowResized();
            };
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Gets the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            // Position of the mouse relative to the window
            var position = Mouse.GetPosition(mWindow);

            // Add the window position so its a "ToScreen"
            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }

        /// <summary>
        /// If the window resizes to a special position (docked or maximized)
        /// this will update all required property change events to set the borders and radius values
        /// </summary>
        private void WindowResized()
        {
            // Fire off events for all properties that are affected by a resize
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));

        }
        #endregion
    }
}
