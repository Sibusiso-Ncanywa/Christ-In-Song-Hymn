using LizHackMethods.Enums;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChristInSong.Core
{

    /// <summary>
    /// A view model for the overview favourites list
    /// </summary>
    public class FavouriteListItemDesignViewModel : FavouriteListItemViewModel
    {
        /// <summary>
        /// The static singleton of the class
        /// </summary>
        public static FavouriteListItemDesignViewModel Instance => new FavouriteListItemDesignViewModel();

        public FavouriteListItemDesignViewModel() => SavedSongs = new ObservableCollection<FavouriteItemViewModel>
            {
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                    SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "FF00FF",
                    NewFavourite = true,
                },
                new FavouriteItemViewModel
                {
                    Inintials = "CIS",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.ChristInSong,
                    BackgroundRGB = "FF0025",
                    NewFavourite = true
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "FF00aa",
                    NewFavourite = true
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "FF5800",
                    NewFavourite = true
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "88FF00"
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "00FF98"
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "FF00ac"
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "cf0000"
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "FFdd00"
                },
                new FavouriteItemViewModel
                {
                    Inintials = "AH",
                    Name = "Watchman blow the gospel trumpet",
                    SongNumberAndType = "1 | Christ In Song",
                     SongNumber = "1",
                    TheHymnType = HymnType.AdventHymn,
                    BackgroundRGB = "eeFF00"
                }
            };

    }
}
