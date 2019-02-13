using LizHackMethods.Classes;
using LizHackMethods.Enums;
using LizHackMethods.LogicMethods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace ChristInSong.Core
{
    /// <summary>
    /// Has the methods that deal with the logic only
    /// </summary>
    public static class GeneralMethods
    {
        #region Global variables

        /// <summary>
        /// Format for saving AH song lyrics
        /// </summary>
        private static readonly string SongCacheMetadata = "song number | lyrics";

        /// <summary>
        /// Format for saving AH key signatures
        /// </summary>
        private static readonly string KeySignatureMetadata = "song number | Key signature";

        /// <summary>
        /// Metadata head for cache file of favorite songs.
        /// Format:  songNumber | Number of times Used | Type of song.
        /// </summary>
        private static readonly string FavouriteSongCacheMetadata = "songNumber | Number of times Used | Type of Hymn";
       
        #endregion

        #region Advent hymn file/folder paths

        /// <summary>
        /// File to save the updated lyrics for AH
        /// </summary>
        private static readonly string AdventHymnCacheFile = "cache/UpdatedAdventSongs.cis";
        
        /// <summary>
        /// File to save the updated key signature for AH
        /// </summary>
        private static readonly string AdventHymnKeySignatureFile = "cache/UpdatedAdventHymnKeySignatures.cis";

        #endregion

        #region Christ In song file/folder paths

        /// <summary>
        /// file to save updated lyrics for Christ in song
        /// </summary>
        private static readonly string CIS_SongCache = "cache/UpdatedSongs.cis";

        /// <summary>
        /// file to save key signatures for Christ in song
        /// </summary>
        private static readonly string CIS_KeySignatureCache = "cache/UpdatedKeySignatures.cis";

        #endregion
        
        #region General paths

        /// <summary>
        /// Name of the Cache folder
        /// </summary>
        private static readonly string CacheFolder = "cache";

        /// <summary>
        /// Path to the favorite song list file
        /// </summary>
        private static readonly string FavSongs = "cache/FavSongsList.cis";

        /// <summary>
        /// Path to the event cache file
        /// </summary>
        private static readonly string EventDetail = "cache/EventDetail.cis";

        /// <summary>
        /// Path to the announcements file
        /// </summary>
        private static readonly string AnnouncementsFilePath = "cache/Announcements.cis";

        /// <summary>
        /// Path to the folder of saved event posters.
        /// </summary>
        private static readonly string PostersFolder = "eventPosters";

        /// <summary>
        /// Path to the folder of saved event posters.
        /// </summary>
        private static readonly string ToRemovePostersFolder = "DELETEtheseFiles";

        #endregion
        
        

        #region File folder methods

        /// <summary>
        /// Check if the file  exists.
        /// Return True if file exist, otherwise return false.
        /// </summary>
        /// <param name="filePath" > Path of the file </param>
        /// <returns> 
        /// True : If exist.
        /// False: IF file don't exist
        /// </returns>
        public static bool CheckFileInCacheFolder(string filePathGiven)
        {
            // check if the directory exists
            if (!Directory.Exists(CacheFolder))
            {
                // create the directory and return
                // A file cannot exist without being hosted by a folder
                Directory.CreateDirectory(CacheFolder);
                return false;
            }

            // check if the file exist
            if (!File.Exists(filePathGiven)) return false;
            
            // The file/folder exist
            return true;
        }

        /// <summary>
        /// Find the file or folder name from the full path and returns the name.
        /// </summary>
        /// <param name="path"> Path of file or folder </param>
        /// <returns> returns the name of file/folder </returns>
        public static string GetFileFolderName(string path)
        {
            // examples of paths possible
            // C:\something\ a folder
            // C:\something/ a folder
            // C:\a folder

            // if the re is no path provided return an empty string 
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            // replace all \ with /
            var normalisePathGiven = path.Replace('/', '\\');

            // find the last index of the last backslash
            var lastIndex = normalisePathGiven.LastIndexOf('\\');

            // if we don't find the backslash, return the path itself
            if (lastIndex <= 0)
                return path;

            // return the name after the last backslash
            return path.Substring(lastIndex + 1);
        }

        #endregion

        #region Favorite song methods

        /// <summary>
        /// Gets the favorite song list that is saved locally 
        /// </summary>
        /// <returns></returns>
        public static List<SongClass> GetCachedFavoriteSongList()
        {
            #region Checking for file and directory

            // check if the Favorite list file exists
            CheckFavouriteCacheFile();

            #endregion

            // look for the songs and save them in this list
            var songList = new List<SongClass>();

            // open the file for reading
            TextReader reader = File.OpenText(FavSongs);
            // get the metadata header
            var metadata = reader.ReadLine();
            // read the second line
            var line = reader.ReadLine();
            /// Read all lines and create a favorite song list
            while (line != null)
            {

                #region Find the details and extract them

                // check if the line is not empty,
                if (string.IsNullOrEmpty(line.Trim(' ')))
                {
                    // if so read the next line...
                    line = reader.ReadLine();
                    continue;
                }

                // Split the read string into 2
                var tempArray = line.Split('|');

                // check if the array has more than zero elements
                if(tempArray.Length <= 0)
                {
                    reader.ReadLine();
                    continue;
                }

                // extract stored details
                // the song number
                var songNumber = tempArray[0];
                // the number of times the song has been used
                var NumberOfTimesUsed = tempArray[1];
                // the hymn type
                var theType = (HymnType)Convert.ToInt32(tempArray[2]);

                // temp store for song details
                var TempDetails = new List<string>();

                // find the song details
                switch (theType)
                {
                    case HymnType.AdventHymn:
                        // find the details of the song
                        TempDetails = AdventHymnMethods.GetAdventSong(songNumber);
                        break;
                    case HymnType.ChristInSong:
                        // find the details of the song
                        TempDetails = CIS_LogicMethods.GetSong(songNumber);
                        break;
                }

                #endregion

                // create a new song and add the song to the song list
                songList.Add(new SongClass(TempDetails[1].Trim(), songNumber, NumberOfTimesUsed, theType));

                // read a new line
                line = reader.ReadLine();
            }

            // close the file 
            reader.Close();

            // sort the list
            songList.Sort();

            // return the list
            return songList;
        }
        
        /// <summary>
        /// save the favorites in a file
        /// </summary>
        /// <param name="songs"></param>
        public static bool SaveFavSongToCache(SongClass songToSave)
        {
            #region Check for favourites cache file

            // check if the Favourite list file exists
            CheckFavouriteCacheFile();

            #endregion

            #region Write to the favCache file

            // get the already stored favourite songs
            var CachedFavourites = GetCachedFavoriteSongList();
            
            // add the metadata to the first line
            var Lines = $"{FavouriteSongCacheMetadata}\n";

            // loop through the list of favs
            // and check if the song to be saved is not already in the list
            for (var i = 0; i < CachedFavourites.Count; i++)
            {
                // the array is from the split 
                var tempArray = CachedFavourites[i].GetNumberAndTimesUsed().Split(',');
                // get song type
                var songType = (int)CachedFavourites[i].ChristInSongOrAdventHymn;

                // checks
                var Exist = ((tempArray[0] == songToSave.SongNumber) && (songType == (int)songToSave.ChristInSongOrAdventHymn)) ? true : false;
                if (Exist)
                {
                    // inform the user.
                   GUI_RelatedMethodsCore.InformTheUser("The song is already a favourite");
                    // and stop the operation
                    return false;
                }

                // add to the line
                Lines += $"{tempArray[0]}|{tempArray[1]}|{songType}\n";
            }
            
            // Add the song to write to the line to write
            var NumberAndTimesUsed = songToSave.GetNumberAndTimesUsed().Split(',');
            Lines += $"{ songToSave.SongNumber}|{NumberAndTimesUsed[1]}|{(int)songToSave.ChristInSongOrAdventHymn}";

            // write to the file
            File.WriteAllText(FavSongs, Lines);

            // file successfully saved.
            return true;
            #endregion

        }

        /// <summary>
        /// It removes the song to the favorite songs cache file.
        /// return true if it was removed successful, otherwise return false.
        /// </summary>
        /// <param name="song"> The song to remove </param>
        public static bool RemoveFavSongFromCache(string songNumber, HymnType Thetype)
        {
            #region Check for favourites cache file

            // check if the Favourite list file exists
            CheckFavouriteCacheFile();

            #endregion

            #region Get the song 

            var songToRemove = FindSong(songNumber, Thetype);

            #endregion

            #region Read and Write to the favCache file

            // get the already stored favourite songs
            var CachedFavourites = GetCachedFavoriteSongList();

            // check if the list is not empty,
            // and if it's empty do nothing
            if (CachedFavourites.Count <= 0) return true;

            // The lines to write to the file
            var Lines = $"{FavouriteSongCacheMetadata}\n";

            // flag indicating that the song was removed
            var removed = false;

            // loop through the list of favs
            // and check if the song to be removed exits in the list,
            // if it does, remove if it doesn't do nothing
            for (var i = 0; i < CachedFavourites.Count; i++)
            {
                // the array is from the split 
                var tempArray = CachedFavourites[i].GetNumberAndTimesUsed().Split(',');
                // get song type
                var songType = (int)CachedFavourites[i].ChristInSongOrAdventHymn;

                // checks
                var Exist = ((tempArray[0] == songToRemove.SongNumber) && (songType == (int)songToRemove.ChristInSongOrAdventHymn)) ? true : false;
                // if the song exits in the file, change the bool value to true,
                if (Exist)
                {
                    removed = true;
                    continue;
                }

                // add to the line
                Lines += $"{tempArray[0]}|{tempArray[1]}|{songType}\n";
            }

            // write to the file
            File.WriteAllText(FavSongs, Lines);

            // return the outcome
            return removed;
            #endregion
        }
        
        /// <summary>
        /// Check if the file is saved
        /// </summary>
        private static void CheckFavouriteCacheFile()
        {
            TextWriter TheFileToWriteTo;
            if (!CheckFileInCacheFolder(FavSongs))
            {
                TheFileToWriteTo = File.CreateText(FavSongs);
                TheFileToWriteTo.Close();
            }
        }
        
        /// <summary>
        /// It extracts the song number and the type of hymn to be used from the given string. Both these should be separated by a '#'.
        /// The format should be: SongNumber#HymType
        /// HymnType is either: (AH/ah) or (CIS/cis)
        /// </summary>
        /// <param name="SongNumberAndTye"> the song number and type</param>
        /// <returns></returns>
        public static SongClass FindTheFavouriteSong(string SongNumberAndTye)
        {
            // check if the '#' is used
            var index = 0;
            // if so check how many times
            for(var i = 0; i< SongNumberAndTye.Length; i++)
            {
                if (SongNumberAndTye[i] == '#') index++;
            }


            if(index <= 0 || index > 1)
            {
                var message = "Please read the instructions and try again.";
                GUI_RelatedMethodsCore.InformTheUser(message);
                return null;
            }

            // Get the song details
            var SongAndType = SongNumberAndTye.Split('#');

            // get the song number 
            var numberOfTheSong = SongAndType[0].Trim(' ');

            // check the hymn type if it's valid
            var TheHymn = SongAndType[1].Trim(' ').ToLower();

            // find the song
            SongClass TheSongFound = null;
            switch (TheHymn)
            {
                case "ah":
                    TheSongFound = FindSong(numberOfTheSong, HymnType.AdventHymn);
                    break;
                case "cis":
                    TheSongFound = FindSong(numberOfTheSong, HymnType.ChristInSong);
                    break;
            }

            // check if the song exist
            if(TheSongFound is null)
            {
                GUI_RelatedMethodsCore.InformTheUser("Eish san! I couldn't find the song. Sorry...");
                return null;
            }

            // return the song found
            return TheSongFound;
        }
        
        #endregion

        #region Methods for events

        /// <summary>
        /// Saves event details to the cache file.
        /// If the file already exist it will return False, otherwise return true.
        /// </summary>
        /// <param name="name"> event name </param>
        /// <param name="source"> source of the poster </param>
        /// <returns> True: 
        /// Exist
        /// False: Doesn't exist
        /// </returns>
        public static bool SaveEventDetails(string name, string sourcePath)
        {
            #region Check if file exists

            // check if the file exist
            if (!CheckFileInCacheFolder(EventDetail))
            {
                var metadata = "Event name | Path to poster";
                TextWriter writeToIt = File.CreateText(EventDetail);
                writeToIt.WriteLine(metadata);
                writeToIt.Close();
            }

            // check if the posters folder exists
            if(!Directory.Exists(PostersFolder)) Directory.CreateDirectory(PostersFolder);

            #endregion

            #region Check if the file exist in the cache file

            // Get the events already stored in the cache file.
            // this list will be used to check if the file being added is already in the list or not
            var theEvents = GetEventDetails();

            var PosterOfNewEvent = GetFileFolderName(sourcePath);
            // compare the path, and if it exist show a message box
            for (var i = 0; i < theEvents.Count(); i++)
            {
                var temp = theEvents[i].Split('|');
                // check if the names are the same
                if (PosterOfNewEvent == GetFileFolderName(temp[1])) return false;
            }

            #endregion

            #region Write to the file

            // Only add the file to the cache file if and only if it's not there already

            // open the file
            TextWriter writer = File.AppendText(EventDetail);

            // copy the poster to the POSTER FOLDER FOR BACKUP PURPOSES.
            var newFulPath = $"{PostersFolder}\\{PosterOfNewEvent}";
            File.Copy(sourcePath, newFulPath,true);

            // line to write to the file
            var line = $"{name}|{newFulPath}";

            // write to the file
            writer.WriteLine(line);

            // close the file
            writer.Close();

            #endregion

            // file was not found in the cache file, and was saved.
            return true;
        }
        
        /// <summary>
        /// CALL THIS ON START UP.
        /// It deletes the poster from the given path.
        /// This deletes the ONLY THE BACKUP WE MADE FOR THE POSTER.
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteThePosters()
        {
            // check if the delete folder exist...
            // if it doesn't exist or has no files on it then do nothing
            if (!Directory.Exists(ToRemovePostersFolder)) return;
            if (Directory.GetFiles(ToRemovePostersFolder).Length <= 0) return;

            // every file will have this...
            var len = "file:///".Length;

            // recover the backed up file
            var filesCached = Directory.GetFiles(PostersFolder);
            var filesToRemove = Directory.GetFiles(ToRemovePostersFolder);

            // loop through and find the poster of the event
            for (var i = 0; i < filesToRemove.Length; i++)
            {
                for(var k = 0;k< filesCached.Length; k++)
                {
                    // get files
                    var fileNameToRemove = GetFileFolderName(filesToRemove[i]);
                    var fileNameOnCachefile = GetFileFolderName(filesCached[k]);

                    // if the file names are the same...
                    if (fileNameToRemove == fileNameOnCachefile)
                    {
                        // take the string after the length...
                        var ToRemove = filesToRemove[i];
                        var CacheToDelete = filesCached[k];

                        // replace / with \
                        ToRemove = ToRemove.Replace('/', '\\');
                        CacheToDelete = CacheToDelete.Replace('/', '\\');
                        
                        // delete both files
                        File.Delete(ToRemove);
                        File.Delete(CacheToDelete);
                    }
                }
            }

            // delete the directory
            Directory.Delete(ToRemovePostersFolder,true);

        }

        /// <summary>
        /// reads from the event file cache file and returns the event list stored.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetEventDetails()
        {
            #region Check if file exists

            // If the cache folder/file is not found return a new list.
            if (!CheckFileInCacheFolder(EventDetail)) return new List<string>();

            // check if the posters folder exists
            if (!Directory.Exists(PostersFolder))
            {
                Directory.CreateDirectory(PostersFolder);
                // return true because the event was not even there, so by creating a new file and folder we are moving the event
                return new List<string>();
            }

            #endregion

            #region Read the Event details file

            // open the file
            TextReader reader = File.OpenText(EventDetail);
            
            // read metadata line from the file
            var metadataline = reader.ReadLine();

            // storage for event details
            var theCacheEventDetails = new List<string>();

            // read from the file
            var line = reader.ReadLine();

            // read each line while we haven't reached the end of the file
            while (line != null)
            {
                // add the line to the list
                theCacheEventDetails.Add(line);
                // read the next line
                line = reader.ReadLine();
            }

            // close the file
            reader.Close();

            // return the list of string
            return theCacheEventDetails;

            #endregion
        }

        /// <summary>
        /// It removes the given image from the cached file, it overwrites and write the new collection.
        /// </summary>
        /// <param name="image"></param>
        public static void RemoveEventCached(string Name, string imagePath)
        {

            // check if the delete folder exist\
            if (!Directory.Exists(ToRemovePostersFolder))
            {
                Directory.CreateDirectory(ToRemovePostersFolder);
            }

            // read all the stored events and store them in the list
            var events = GetEventDetails();

            // the event to remove
            var eventName = Name;
            var pathOfEvent = imagePath;

            #region Look for the file to remove

            // Loop through the events and remove the event in the image give
            for (var i = 0; i < events.Count; i++)
            {
                var temp = events[i].Split('|');
                // the if parameters

                // get file name
                var fileToRemove = GetFileFolderName(pathOfEvent);
                var fileOnTheOnCache = GetFileFolderName(temp[1]);

                // Remove the file from the list
                if (fileToRemove == fileOnTheOnCache)
                {
                    // copy the file to the file to delete folder
                    var pathIS = $"{ToRemovePostersFolder}\\{fileToRemove}";

                    // path of the event to be deleted
                    pathOfEvent = pathOfEvent.Replace('/', '\\');

                    // copy event poster
                    File.Copy(pathOfEvent, pathIS,true);

                    // remove the event
                    events.RemoveAt(i);
                    break;
                }
            }

            #endregion

            #region Write the event back to the file

            // write to the file
            // open the file
            TextWriter writer = File.CreateText(EventDetail);

            // Metadata header
            var metadata = "Event name| Path to poster";
            //  write the metadata
            writer.WriteLine(metadata);

            // store the events to the cache file
            foreach (var item in events)
            {
                // write to the file
                writer.WriteLine(item);
            }

            // close the file
            writer.Close();

            #endregion

        }

        #endregion

        #region General song methods

        /// <summary>
        /// Checks if the song exists.
        /// Return: True if it exists.
        /// Return: False if ti doesn't exist.
        /// </summary>
        /// <param name="song"> song number</param>
        /// <param name="songType"> Hymnal type that the song belongs</param>
        /// <returns></returns>
        private static bool IsSongInHymnal(string song, HymnType songType)
        {
            // create a temp list of strings
            List<string> TempDetails;
            switch (songType)
            {
                case HymnType.AdventHymn:
                    // find the details of the song
                    TempDetails = AdventHymnMethods.GetAdventSong(song);

                    // if the song is not found return false
                    if (TempDetails.Count <= 0) return false;

                    // return true
                    return true;

                case HymnType.ChristInSong:
                    // find the details of the song
                    TempDetails = CIS_LogicMethods.GetSong(song);

                    // if the song is not found false
                    if (TempDetails.Count <= 0) return false;

                    // return true 
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Checks if the song exists in the Hymnal chosen.
        /// Returns True if the song was found in the list of songs.
        /// Returns False if the song was not found in the list of songs
        /// </summary>
        /// <param name="SongNumber"> Song number </param>
        /// <param name="HymnalType"> Type of Hymnal </param>
        /// <returns></returns>
        public static bool CheckIfTheSongExists(string SongNumber, HymnType HymnalType)
        {
            switch (HymnalType)
            {
                case HymnType.ChristInSong:

                    // check if the song exists
                    if (!IsSongInHymnal(SongNumber, HymnType.ChristInSong))
                    {
                        GUI_RelatedMethodsCore.SongNotFound(SongNumber, HymnType.ChristInSong);
                        return false;
                    }

                    // do this
                    // return true
                    return true;

                case HymnType.AdventHymn:

                    // check if the son exist
                    if (!IsSongInHymnal(SongNumber, HymnType.AdventHymn))
                    {
                        GUI_RelatedMethodsCore.SongNotFound(SongNumber, HymnType.AdventHymn);
                        return false;
                    }

                    // instead return true
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Converts the hymn type to string.
        /// </summary>
        /// <param name="type"> type of hymn</param>
        /// <returns></returns>
        public static string GetHymnType(HymnType type)
        {
            switch (type)
            {
                case HymnType.ChristInSong:
                    return "Christ In Song";
                case HymnType.AdventHymn:
                    return "Advent Hymn";
                default:
                    return null;
            }
        }

        /// <summary>
        /// Converts string given to a hymn type.
        /// </summary>
        /// <param name="type"> type of hymn in a string format</param>
        /// <returns> return the hymn type </returns>
        public static HymnType ConvertToHymnType(string type)
        {
            var CorrectFormat = type.Trim();
            switch (CorrectFormat)
            {
                case "Christ In Song":
                    return HymnType.ChristInSong;
                case "Advent Hymn":
                    return HymnType.AdventHymn;
                default:
                    return HymnType.ChristInSong;
            }
        }
        
        /// <summary>
        /// Looks for the selected number given.
        /// </summary>
        /// <param name="number"> Number of the song</param>
        /// <param name="ChristInSong"> Is it a Christ In Song hymn? True/False </param>
        /// <returns> Song with properties </returns>
        public static SongClass FindSong(string number, HymnType type)
        {
            #region Local variables
            // create temp song
            SongClass song = null;

            // temp store the details of the song
            var TempDetails = new List<string>();

            // used to store song details
            string The_number;
            string The_name;
            string Thec_key;
            string The_lyrics;
            int numUsedFor;

            #endregion

            switch (type)
            {
                case HymnType.AdventHymn:

                    // chaeck it the song exists
                    if (!IsSongInHymnal(number, HymnType.AdventHymn)) return null;

                    // find the details of the song
                    TempDetails = AdventHymnMethods.GetAdventSong(number);

                    // extract the values from the list
                    The_number = TempDetails[0];
                    The_name = TempDetails[1].Trim();
                    Thec_key = TempDetails[2];
                    The_lyrics = TempDetails[3];

                    // find the number of time the song has been used
                    numUsedFor = AdventHymnMethods.IncrementAdventgetUsedForNum(The_number);

                    // create a new Advent hym song
                    song = new SongClass(The_name, Thec_key, The_number, The_lyrics, numUsedFor)
                    {
                        // set the type of the song
                        ChristInSongOrAdventHymn = HymnType.AdventHymn
                    };
                    return song;

                case HymnType.ChristInSong:
                    // check if the song exist
                    if (!IsSongInHymnal(number, HymnType.ChristInSong)) return null;

                    // find the details of the song
                    TempDetails = CIS_LogicMethods.GetSong(number);

                    // extract the values from the list
                    The_number = TempDetails[0];
                    The_name = TempDetails[1].Trim();
                    Thec_key = TempDetails[2];
                    The_lyrics = TempDetails[3];

                    // find the number of time the song has been used
                    numUsedFor = CIS_LogicMethods.IncrementAndgetUsedForNum(The_number);

                    // create a new Christ in song class
                    song = new SongClass(The_name, Thec_key, The_number, The_lyrics, numUsedFor)
                    {
                        // set the type of the song
                        ChristInSongOrAdventHymn = HymnType.ChristInSong
                    };
                    return song;

                default:
                    return null;
            }
        }

        /// <summary>
        /// takes in a combo of song nummber and return a song class.
        /// The combo should be in the format: SONG NUMBER | TYPE OF HYMN.
        /// </summary>
        /// <returns></returns>
        public static SongClass ExtractAndReturnSong(string songAndTypeOfHymn)
        {
            // song number | hymn type
            // song details 
            var songDetails = songAndTypeOfHymn.Split('|');

            // check if the songDetails is not empty
            if (songDetails.Length < 0) return null;

            // extract the song details 
            var numberOfThe = songDetails[0].Trim();
            var typeOfHymnal = (HymnType)Convert.ToInt32(songDetails[1].Trim());

            // return the song found
            return FindSong(numberOfThe, typeOfHymnal);
        }

        /// <summary>
        /// Finds all songs in both hymnals
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<SongClass> FindAllSongs()
        {
            var songs = new ObservableCollection<SongClass>();
            var CISnum = 1;
            while (true)
            {
                var song = FindSong($"{CISnum}", HymnType.ChristInSong);
                if (song is null) break;
                songs.Add(song);
                CISnum++;
            }

            var AHnum = 1;
            while (true)
            {
                var song = FindSong($"{AHnum}", HymnType.AdventHymn);
                if (song is null) break;
                songs.Add(song);
                AHnum++;
            }
            return songs;
        }

        /// <summary>
        /// Converts the hymn type to a string.
        /// </summary>
        /// <param name="type"> the hymn type to convert </param>
        /// <returns></returns>
        public static string StringVersionOfHymnType(HymnType type)
        {
            switch (type)
            {
                case HymnType.AdventHymn:
                    return "Advent Hymn";
                case HymnType.ChristInSong:
                    return "Christ In Song";
                default:
                    return null;
            }
        }
        
        #endregion

        #region Song lyric cache methods

        /// <summary>
        /// Get the path of the song cache according to the hymn type given.
        /// </summary>
        /// <param name="type"> Hymnal used </param>
        /// <returns></returns>
        private static string SongLyricCachePath(HymnType type)
        {
            switch (type)
            {
                case HymnType.AdventHymn:
                    return AdventHymnCacheFile;
                case HymnType.ChristInSong:
                    return CIS_SongCache;
                default:
                    return "";
            }

        }
        
        /// <summary>
        /// Gets the lyrics of a from the cache file
        /// </summary>
        /// <param name="songNumber"> song to look for </param>
        /// <param name="type"> Hymn type of the song </param>
        /// <returns></returns>
        public static string GetSongLyricCache(string songNumber, HymnType Thetype)
        {
            // the reader
            TextReader reader;
            // get the path of the lyrics
            var pathToCachedSong = SongLyricCachePath(Thetype);

            #region Checking for file and directory

            // check if the file exist
            if (!CheckFileInCacheFolder(pathToCachedSong))
                return "";
            #endregion

            #region Read from the file and look for the song

            reader = File.OpenText(pathToCachedSong);
            // read the metadata head
            var metadata = reader.ReadLine();
            // read the line after the metadata
            var lineRead = reader.ReadLine();

            while (lineRead != null)
            {
                #region Check the start of the song

                // check for the beginning of the song
                if (!lineRead.StartsWith("@"))
                {
                    lineRead = reader.ReadLine();
                    continue;
                }

                #endregion

                #region get the song details

                lineRead = lineRead.Trim('@');
                var songDetails = lineRead.Split('|');

                #endregion

                #region Compare song number in cache file with the given song number

                // the song number is the same get th cached lyrics
                if (Convert.ToInt32(songDetails[0].Trim()) != Convert.ToInt32(songNumber))
                {
                    lineRead = reader.ReadLine();
                    continue;
                }

                #endregion

                #region Store the lyrics to the SongLyrics string

                // the extracted line with the first line of the song
                lineRead = songDetails[1];

                // songDetails.
                var SongLyrics = "";

                while ((lineRead != null) && lineRead.IndexOf('_') < 0)
                {
                    if (string.IsNullOrEmpty(SongLyrics))
                    {
                        SongLyrics = lineRead + "\n";
                        lineRead = reader.ReadLine();
                        continue;
                    }

                    SongLyrics += $"{lineRead}\n";

                    lineRead = reader.ReadLine();
                }

                // find the the index of the underscore
                var underscoreIndex = lineRead.IndexOf('_');

                // get the string before the under score
                // read up untill the character before the underscore
                if ((underscoreIndex - 1) > 0)
                {
                    SongLyrics += lineRead.Substring(0, underscoreIndex - 1);
                }
                else
                {
                    SongLyrics += lineRead.Substring(0, 1);
                }

                #endregion

                #region return lyrics and close the file

                // close the file and return the lyrics
                reader.Close();
                return $"{SongLyrics}";

                #endregion
            }

            #endregion

            // close the file and return the lyrics
            reader.Close();
            // song not found return an empty string
            return "";
        }

        /// <summary>
        /// Writes the updated version of lyrics to the cache file.
        /// </summary>
        /// <param name="songnumber"> The song number </param>
        /// <param name="newLyrics"> The new lyrics </param>
        /// <param name="type"> The hymnal used. <see cref="HymnType"/>. </param>
        public static void SaveSongLyricToCache(string songnumber, string newLyrics, HymnType type)
        {

            #region Pre checks

            // check if the song to update exist

            // find the song 
            var detailsOfSong = new List<string>();
            var pathToSongLyricCache = SongLyricCachePath(type);

            switch (type)
            {
                case HymnType.AdventHymn:
                    detailsOfSong = AdventHymnMethods.GetAdventSong(songnumber);
                    break;
                case HymnType.ChristInSong:
                    detailsOfSong = CIS_LogicMethods.GetSong(songnumber);
                    break;
            }

            // If song not found do nothing.
            if (detailsOfSong.Count < 0)
                return;

            #endregion

            #region Write to the file

            // create the writing "machine"
            TextWriter textCIS;

            // create the file if it doesn't exist
            if (!CheckFileInCacheFolder(pathToSongLyricCache))
            {
                // create the file
                textCIS = File.CreateText(pathToSongLyricCache);
                // write the metadata head
                textCIS.WriteLine(SongCacheMetadata);
                // create the string to write
                var Newline = $"{songnumber}|{newLyrics}";
                // write to the file
                textCIS.WriteLine($"@{Newline}_");
            }
            else
            {
                // if the file lready exist 
                // Remove the current song, it will return a string but ignore it
                RemoveSongCache(songnumber, type);

                // write the song to the file
                textCIS = File.AppendText(pathToSongLyricCache);

                // write to the cis file
                var Newline = $"{songnumber}|{newLyrics}";
                textCIS.WriteLine($"@{Newline}_");
            }

            // close the file
            textCIS.Close();

            #endregion

        }
        
        /// <summary>
        /// Remove song for the cache and return old lyrics
        /// </summary>
        /// <param name="songNumber"> The song to remove </param>
        /// <param name="songNumber"> The hymnal type </param>
        /// <returns></returns>
        public static string RemoveSongCache(string songNumber, HymnType Thetype)
        {

            // get the path of the lyrics
            var pathToCachedSong = SongLyricCachePath(Thetype);

            #region Checking for file and directory

            // check if the file exist
            if (!CheckFileInCacheFolder(pathToCachedSong))
                return "";
            #endregion

            #region Read from the file and look for the song

            // the reader
            TextReader reader;

            reader = File.OpenText(pathToCachedSong);
            // read the metadata head
            var metadata = reader.ReadLine();
            // read the line after the metadata
            var lineRead = reader.ReadLine();

            // Temp store for other song which will not be removed
            var OtherSongs = $"{SongCacheMetadata}\n";

            while (lineRead != null)
            {
                #region Check the start of the song

                // check for the beginning of the song
                if (!lineRead.StartsWith("@"))
                {
                    lineRead = reader.ReadLine();
                    continue;
                }

                #endregion

                #region get the song details

                lineRead = lineRead.Trim('@');
                var songDetails = lineRead.Split('|');

                #endregion

                #region Compare song number in cache file with the given song number

                // the song number is the same get th cached lyrics
                if (Convert.ToInt32(songDetails[0].Trim()) == Convert.ToInt32(songNumber))
                {
                    lineRead = reader.ReadLine();
                    continue;
                }

                #endregion

                #region Store the lyrics to the SongLyrics string

                while ((lineRead != null) && lineRead.IndexOf('_') < 0)
                {
                    OtherSongs += $"{lineRead}\n";

                    lineRead = reader.ReadLine();
                }

                // Add line with underscore
                OtherSongs += lineRead;

                #endregion
            }

            // close the file
            reader.Close();

            #endregion

            #region write other songs to the file

            // delete the file
            File.Delete(pathToCachedSong);
            
            // save lyrics
            File.WriteAllText(pathToCachedSong, OtherSongs);

            #endregion

            #region return original lyrics

            // return original lyrics
            switch (Thetype)
            {
                case HymnType.AdventHymn:
                    return AdventHymnMethods.GetAdventSong(songNumber)[3];
                case HymnType.ChristInSong:
                    return CIS_LogicMethods.GetSong(songNumber)[3];
                default:
                    return "";
            }

            #endregion

        }

        #endregion

        #region Song key signature cache methods
        
        /// <summary>
        /// Get the path of the key signature cache according to the hymn type given.
        /// </summary>
        /// <param name="type"> Hymnal used </param>
        /// <returns></returns>
        private static string SongKeySignatureCachePath(HymnType type)
        {
            switch (type)
            {
                case HymnType.AdventHymn:
                    return AdventHymnKeySignatureFile;
                case HymnType.ChristInSong:
                    return CIS_KeySignatureCache;
                default:
                    return "";
            }

        }
        
        /// <summary>
        /// Remove key signature of the given song from cache and return old key signature.
        /// </summary>
        /// <param name="songNumber"> Song number </param>
        /// <param name="TheType"> Hymn type of the song </param>
        /// <returns></returns>
        public static string RemoveKeySignatureCache(string TheSongNumber, HymnType TheType)
        {
            // format Song Number | key signature

            // song number to look for
            var numOfsong = TheSongNumber;
            
            // Get the path
            var songKeySigPath = SongKeySignatureCachePath(TheType);

            #region Checking for file and directory

            // check if the file exist
            if (!CheckFileInCacheFolder(songKeySigPath))
                return "";

            #endregion

            #region Read from file

            // open the file for reading
            TextReader reader = File.OpenText(songKeySigPath);

            // read the meatadata header
            var metadata = reader.ReadLine();

            // read the next line
            var lineRead = reader.ReadLine();


            // to store other songs for later saving 
            var tosaveKeys = new List<string>();
            while (lineRead != null)
            {
                // format Song Number | key signature

                // songDetails.
                var songDetails = lineRead.Split('|');

                // add other song key and leave out the current
                if (Convert.ToInt32(songDetails[0]) != Convert.ToInt32(numOfsong))
                {
                    tosaveKeys.Add(lineRead);
                    lineRead = reader.ReadLine();
                }

                // go to next line
                lineRead = reader.ReadLine();
            }

            // goto nextline
            reader.Close();

            #endregion

            #region write other songs to the file

            // overwrite the file, and write the metadata
            File.Delete(songKeySigPath);

            // create the file
            TextWriter writer = File.CreateText(songKeySigPath);
            // write the metadata
            writer.WriteLine(metadata);
            // write all lines
            foreach (var item in tosaveKeys)
            {
                writer.WriteLine(item);
            }
            // close the file
            writer.Close();

            #endregion

            #region return original  key signature

            switch (TheType)
            {
                case HymnType.AdventHymn:
                    return AdventHymnMethods.GetAdventSong(numOfsong)[2];
                case HymnType.ChristInSong:
                    return CIS_LogicMethods.GetSong(numOfsong)[2];
                default:
                    return "";
            }

            #endregion

        }

        /// <summary>
        /// Gets the key signatures from the cache file.
        /// </summary>
        /// <param name="songNumber"> song to look for </param>
        /// <param name="TheType"> The hymn type used </param>
        /// <returns></returns>
        public static string GetKeySignatureCache(string TheSongNumber, HymnType TheType)
        {
            // the reader
            TextReader reader;

            // the path used
            var pathToKeySignatureCache = SongKeySignatureCachePath(TheType);

            #region Checking for file and directory

            // check if the file exist
            if (!CheckFileInCacheFolder(pathToKeySignatureCache))
                return "";

            #endregion

            #region Read from the file and look for the song

            // open the file for reading
            reader = File.OpenText(pathToKeySignatureCache);
            // read the metadata
            var metadata = reader.ReadLine();
            // read the next line
            var lineRead = reader.ReadLine();

            while (lineRead != null)
            {
                // songDetails.
                var songDetails = lineRead.Split('|');

                #region Compare song number with the given song number

                //  if the song number is the same get the cached key signature
                if (Convert.ToInt32(songDetails[0]) == Convert.ToInt32(TheSongNumber))
                {
                    reader.Close();
                    return songDetails[1];
                }

                #endregion

                // goto nextline
                lineRead = reader.ReadLine();
            }

            #endregion

            // close the file
            reader.Close();

            // song not found return an empty string
            return "";
        }

        /// <summary>
        /// Write the updated version of the key signature to the cache file
        /// </summary>
        /// <param name="songnumber"> The song that the key belongs to </param>
        /// <param name="key"> The new key signature </param>
        /// <param name="type"> The hymn type of the song </param>
        public static void SaveSongKeySignatureToCache(string songnumber, string key, HymnType type)
        {
            #region Pre checks

            // check if the song to update exist

            // find the song 
            var detailsOfSong = new List<string>();
            var pathToSongKeySignatureCache = SongKeySignatureCachePath(type);

            switch (type)
            {
                case HymnType.AdventHymn:
                    detailsOfSong = AdventHymnMethods.GetAdventSong(songnumber);
                    break;
                case HymnType.ChristInSong:
                    detailsOfSong = CIS_LogicMethods.GetSong(songnumber);
                    break;
            }

            // If song not found do nothing.
            if (detailsOfSong.Count < 0)
                return;

            #endregion

            #region Write to the file

            // create the writing "machine"
            TextWriter textCIS;

            // create the file if it doesn't exist
            if (!CheckFileInCacheFolder(pathToSongKeySignatureCache))
            {
                // create the file
                textCIS = File.CreateText(pathToSongKeySignatureCache);
                // write the metadata head
                textCIS.WriteLine(KeySignatureMetadata);
                // create the string to write
                var Newline = $"{songnumber}|{key}";
                // write to the file
                textCIS.WriteLine(Newline);
            }
            else
            {
                // if the file lready exist 
                // Remove the current song, it will return a string but ignore it
                RemoveKeySignatureCache(songnumber, type);

                // write the song to the file
                textCIS = File.AppendText(pathToSongKeySignatureCache);

                // write to the cis file
                var Newline = $"{songnumber}|{key}";
                textCIS.WriteLine(Newline);
            }

            // close the file
            textCIS.Close();

            #endregion

        }

        #endregion
        
        #region Announcements methods
        
        /// <summary>
        /// Add the announcements file to the temp folder
        /// </summary>
        /// <returns></returns>
        public static void AddAnnouncementFileToTemp(string filePath, string fileNAme)
        {
            // if the file doesn't exist the do nothing
            if (!Directory.Exists(ToRemovePostersFolder))
            {
                // if it's not found create it
                Directory.CreateDirectory(ToRemovePostersFolder);
            }

            // copy file to the delete poster folder
            var NewPath = $"{ToRemovePostersFolder}/{fileNAme}";
            File.Copy(filePath, NewPath,true);

            // string with the file name and the new path
            string FileNameAndPAth = $"{fileNAme}|{NewPath}";

            // check if the cache folder exist
            CheckFileInCacheFolder(AnnouncementsFilePath);

            // create the file and write the contents
            File.WriteAllText(AnnouncementsFilePath, FileNameAndPAth);
        }

        /// <summary>
        /// Get the announcements file from the temp folder and return it.
        /// </summary>
        /// <returns></returns>
        public static string[] ViewTempFile()
        {
            // if the file doesn't exist the do nothing
            if (!Directory.Exists(ToRemovePostersFolder)) return new string[2];

            // read from the anouncements file and view the results
            TextReader reader = File.OpenText(AnnouncementsFilePath);
            string lineOfTheFile = reader.ReadLine();

            // Get the file 
            var Details = lineOfTheFile.Split('|');

            // Get the details
            var fileName = Details[0];
            var filePath = Path.GetFullPath(Details[1]);

            // return the array with the filename and the path to the file
            return new string[2]
            {
                fileName,
                filePath
            };
        }

        #endregion

        #region Just General methods

        /// <summary>
        /// Randomly generates a colour
        /// </summary>
        /// <returns></returns>
        public static string StringColourSelector()
        {
            // random generator
            var random = new Random();

            // List of predifined colours
            var myColours = new List<string>() { "ffa800", "ff4747", "00c541", "713cdb" };

            //Select randomly from the colors
            var colorFound = myColours[random.Next(0, myColours.Count)];

            // return the colour found
            return colorFound;
        }
        
        /// <summary>
        /// checks if the number typed is a valid number.
        /// If the value to be checked is not a whole number then assign the <see cref="bool"/> to false. 
        /// </summary>
        /// <param name="sender"></param>
        /// /// <param name="int_double"></param>
        public static bool IsStringValid(string stringToCheck)
        {
            // The list of accepted characters
            var acceptedCharacters = "0123456789";

            if (string.IsNullOrEmpty(stringToCheck))
            {
                GUI_RelatedMethodsCore.InformTheUser("Song number is not valid!");
                return false;
            }

            // loop through the given string and look for invalid input
            for (var i = 0; i < stringToCheck.Length; i++)
            {
                // check if the character is part of the accepted characters
                if (!acceptedCharacters.Contains(stringToCheck[i]))
                {
                    // inform the user about the error
                    GUI_RelatedMethodsCore.InformTheUser($"{stringToCheck[i]} is not an accepted character!", "Invalid Character");
                    return false;
                }
            }

            return true;
        }
        
        /// <summary>
        /// Show the user this message in splash screen
        /// </summary>
        /// <returns></returns>
        public static string GetTodaysMessage()
        {
            var hour = DateTime.Now.Hour;

            var thedayofweek = DateTime.UtcNow.DayOfWeek;
            switch (thedayofweek)
            {
                case DayOfWeek.Sunday:
                    return "A happy Sunday";
                case DayOfWeek.Monday:
                    return "A happy Monday";
                case DayOfWeek.Tuesday:
                    return "A happy Tuesday";
                case DayOfWeek.Wednesday:
                    return "A happy Wednesday";
                case DayOfWeek.Thursday:
                    return "A happy Thursday";
                case DayOfWeek.Friday:
                    return DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour > 18 ? "A happy Sabbath" : "A happy Friday";
                case DayOfWeek.Saturday:
                    return DateTime.Now.DayOfWeek == DayOfWeek.Saturday && DateTime.Now.Hour < 18 ? "A happy Sabbath" : "A happy Sunday";
            }
            return null;
        }

        #endregion

    }
}
