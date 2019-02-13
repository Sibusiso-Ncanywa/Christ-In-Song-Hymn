using Dna;

namespace ChristInSong.Core
{
    /// <summary>
    /// The IoC for the application
    /// </summary>
    public static class CoreDi
    {
        /// <summary>
        /// Shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static IUIManager UI_Dna => Framework.Service<IUIManager>();

        /// <summary>
        /// Shortcut to access the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static ApplicationViewModel VM_Application_Dna => Framework.Service<ApplicationViewModel>();

        /// <summary>
        /// Shortcut to access the <see cref="EventViewModel"/>
        /// </summary>
        public static EventViewModel VM_Event_Dna => Framework.Service<EventViewModel>();

    }
}
