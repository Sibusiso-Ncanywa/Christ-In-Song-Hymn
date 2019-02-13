using ChristInSong.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Christ_in_song
{
       /// <summary>
       /// Interaction logic for PageHost.xaml
       /// </summary>
       public partial class PageHost : UserControl
       {

              #region Dependancy Properties

              /// <summary>
              /// The current page to show in the page host
              /// </summary>
              public BasePage CurrentPage
              {
                     get => (BasePage)GetValue(CurrentPageProperty);
                     set => SetValue(CurrentPageProperty, value);
              }

              /// <summary>
              /// Registers <see cref="CurrentPage"/> as a depedency property
              /// </summary>
              public static readonly DependencyProperty CurrentPageProperty =
                  DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(CurrentPagePropertyChanged));

              #endregion

              #region Constructor

              /// <summary>
              /// Default Constructor
              /// </summary>
              public PageHost()
              {
                     InitializeComponent();

                     // if we are in design mode show the current page
                     // the dependency property doesn't fire
                     if (DesignerProperties.GetIsInDesignMode(this))
                     {
                            NewPage.Content = (BasePage)new ApplicationPageValueConverter().Convert(CoreDi.VM_Application_Dna.CurrentPage);
                     }
              }
              #endregion

              #region Property Changed events

              /// <summary>
              /// Called when the <see cref="CurrentPage"/> value has changed
              /// </summary>
              /// <param name="d"></param>
              /// <param name="e"></param>
              private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
              {
                     // Get frames
                     var NewPageFrame = ( d as PageHost ).NewPage;
                     var OldPageFrame = ( d as PageHost ).OldPage;

                     // Store the curent page content as the old page content
                     var OldPageContent = NewPageFrame.Content;

                     // remove current page from new page frame
                     NewPageFrame.Content = null;

                     // move the previous page to the oldpage frame
                     OldPageFrame.Content = OldPageContent;

                     // Animate out the previous page when the loaded event fire
                     // right after this call due to moving frames
                     if(OldPageContent is BasePage oldPage)
                     {
                            // Tell the old page to animate out
                            oldPage.ShouldAnimateOut = true;

                            // Once it's done remove the old page
                            Task.Delay((int)( oldPage.SlideSeconds * 1000 )).ContinueWith((t) =>
                            {
                                   // Remove the old page
                                   Application.Current.Dispatcher.Invoke(() => oldPage.Content == null);
                            });
                     }

                     // set the new page content
                     NewPageFrame.Content = e.NewValue;
              }

              #endregion
       }
}
