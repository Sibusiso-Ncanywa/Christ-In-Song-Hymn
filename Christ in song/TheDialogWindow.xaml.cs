using ChristInSong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Christ_in_song
{
    /// <summary>
    /// Interaction logic for TheHomeWindow.xaml
    /// </summary>
    public partial class TheDialogWindow : Window
    {
        #region Private properties

        /// <summary>
        /// The view model of this window 
        /// </summary>
        private DialogWindowViewModel mViewModel;

        #endregion

        #region Public properties

        /// <summary>
        /// The view model of this window 
        /// </summary>
        public DialogWindowViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                // set the view model
                mViewModel = value;

                // Update the data context
                DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// The constructor
        /// </summary>
        public TheDialogWindow()
        {
            InitializeComponent();
        }
        
        #endregion
    }
}
