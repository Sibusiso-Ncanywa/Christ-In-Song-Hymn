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
    public partial class TheHomeWindow : Window
    {
        public TheHomeWindow()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);
        }

        private void TheHome_Window_Activated(object sender, EventArgs e)
        {
            // Hide the overlay
            (DataContext as WindowViewModel).DimmableOverlayVisible = false;
        }

        private void TheHome_Window_Deactivated(object sender, EventArgs e)
        {
            //Show the  overlay 
            (DataContext as WindowViewModel).DimmableOverlayVisible = true;

        }
    }
}
