using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Animation;
using ChristInSong.Core;
using System.ComponentModel;

namespace Christ_in_song
{
       /// <summary>
       /// Base page for all ages to gain functionality
       /// </summary>
       public class BasePage: UserControl
       {
              #region Public properties

              /// <summary>
              /// The animation the play when the page is first loaded
              /// </summary>
              public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

              /// <summary>
              /// The animation the play when the page is unloaded
              /// </summary>
              public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

              /// <summary>
              /// The time taken for the animation to take complete
              /// </summary>
              public float SlideSeconds { get; set; } = 0.8f;

              /// <summary>
              /// A flag to indicate if this page should animate out on load.
              /// Useful for when we are moving the page to another frame
              /// </summary>
              public bool ShouldAnimateOut { get; set; }

              #endregion

              #region Constructor

              /// <summary>
              /// The default constructor.
              /// </summary>
              public BasePage()
              {
                     // Don't bother animating in design time
                     if (DesignerProperties.GetIsInDesignMode(this))
                            return;

                     // If we are animating in, hide to begin with
                     if (PageLoadAnimation != PageAnimation.None)
                            Visibility = Visibility.Collapsed;

                     // Listen out for the page loading
                     Loaded += BasePage_LoadedAsync;
                     
              }

              #endregion

              #region The animation load / unload

              /// <summary>
              /// Once the page is loaded perform any required animation.
              /// </summary>
              /// <param name="sender"></param>
              /// <param name="e"></param>
              private async void BasePage_LoadedAsync(object sender, System.Windows.RoutedEventArgs e)
              {
                     // If we are setup to animate out on load
                     if (ShouldAnimateOut)
                            // Animate out the page
                            await AnimateOutAsync();
                     // Otherwise...
                     else
                            // Animate the page in
                            await AnimateInAsync();
              }

              /// <summary>
              /// Animate this page
              /// </summary>
              /// <returns></returns>
              public async Task AnimateInAsync()
              {
                     // Make sure we have something to do
                     if (PageLoadAnimation == PageAnimation.None)
                            return;

                     switch (PageLoadAnimation)
                     {
                            case PageAnimation.SlideAndFadeInFromRight:

                                   // Start the animation
                                   await this.SlideAndFadeInAsync(AnimationSlideInDirection.Right, false, SlideSeconds, size: (int)Application.Current.MainWindow.Width);

                                   break;
                     }

              }

              /// <summary>
              /// Animates the page out
              /// </summary>
              /// <returns></returns>
              public async Task AnimateOutAsync()
              {
                     // Make sure we have something to do
                     if (PageUnloadAnimation == PageAnimation.None)
                            return;

                     switch (PageUnloadAnimation)
                     {
                            case PageAnimation.SlideAndFadeOutToLeft:

                                   // Start the animation
                                   await this.SlideAndFadeOutAsync(AnimationSlideInDirection.Left, SlideSeconds);

                                   break;
                     }
              }

              #endregion

       }

       /// <summary>
       /// A base page with added view model support
       /// </summary>
       public class BasePage<VModel> : BasePage
           where VModel : BaseViewModel, new()
       {

              #region Private members

              /// <summary>
              /// The View Model Associated with this page
              /// </summary>
              private VModel mViewModel { get; set; }

              #endregion

              #region Public properties

              /// <summary>
              /// The View Model Associated with this page
              /// </summary>
              public VModel ViewModel
              {
                     get => mViewModel;
                     set
                     {
                            // if the value has not changed do nothing
                            if (mViewModel == value)
                                   return;

                            // Update the value
                            mViewModel = value;

                            // set the data context
                            DataContext = mViewModel;
                     }
              }

              #endregion

              #region Constructor

              /// <summary>
              /// The default constructor.
              /// </summary>
              public BasePage() : base()
              {
                     // create a default view model
                     ViewModel = new VModel();
              }

              #endregion

              
       }
}
