using Dna;
using Microsoft.Extensions.DependencyInjection;

namespace ChristInSong.Core
{
    /// <summary>
    /// Extension methods for the framework construction
    /// </summary>
    public static class FrameworkConstructionExtensionCore
    {
        /// <summary>
        /// Injects the view models needed for construction
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddCsIViewModels(this FrameworkConstruction construction)
        {
            /// Bind to a single instance of the <see cref="ApplicationViewModel"/>
            construction.Services.AddSingleton<ApplicationViewModel>();

            /// Bind to a single instance of the <see cref="EventViewModel"/>
            construction.Services.AddSingleton<EventViewModel>();

            /// Bind to a single instance of the <see cref="ApplicationViewModel"/>
            // construction.Services.AddSingleton<ApplicationViewModel>();

            // return the construction chaining
            return construction;
        }
        
    }
}
