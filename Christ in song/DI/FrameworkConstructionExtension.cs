using ChristInSong.Core;
using Dna;
using Microsoft.Extensions.DependencyInjection;

namespace Christ_in_song
{
    public static class FrameworkConstructionExtension
    {
        /// <summary>
        /// Injects the client services needed for construction
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddCsIClientServices(this FrameworkConstruction construction)
        {
            // Binding a UI
            construction.Services.AddTransient <IUIManager, UIManager>();

            // return the construction chaining
            return construction;
        }
    }
}
