using ChristInSong.Core;
using LizHackMethods.Classes;
using LizHackMethods.Enums;
using System;
using System.Collections.Generic;

namespace LizHackMethods.LogicMethods
{
    public class AdventHymnMethods
    {

        /// <summary>
        /// Looks for the number given and ouput the number of times the song has been used.
        /// THIS METHOD IS FOR ADVENT HYM ONLY!
        /// </summary>
        /// <param name="songNumber"> the song number to look for </param>
        /// <returns> the number of times used for </returns>
        public static int IncrementAdventgetUsedForNum(string songNumber)
        {
            var songNum = Convert.ToInt32(songNumber);
            //look for the song number
            switch (songNum)
            {
                case 1:
                    TheAdventHymn.Advent_1.incrementUsedTimes();
                    return TheAdventHymn.Advent_1.GetUsedTimes();
                case 2:
                    TheAdventHymn.Advent_2.incrementUsedTimes();
                    return TheAdventHymn.Advent_2.GetUsedTimes();
                case 3:
                    TheAdventHymn.Advent_3.incrementUsedTimes();
                    return TheAdventHymn.Advent_3.GetUsedTimes();
                case 4:
                    TheAdventHymn.Advent_4.incrementUsedTimes();
                    return TheAdventHymn.Advent_4.GetUsedTimes();
                case 5:
                    TheAdventHymn.Advent_5.incrementUsedTimes();
                    return TheAdventHymn.Advent_5.GetUsedTimes();
                case 6:
                    TheAdventHymn.Advent_6.incrementUsedTimes();
                    return TheAdventHymn.Advent_6.GetUsedTimes();
                case 7:
                    TheAdventHymn.Advent_7.incrementUsedTimes();
                    return TheAdventHymn.Advent_7.GetUsedTimes();
                case 8:
                    TheAdventHymn.Advent_8.incrementUsedTimes();
                    return TheAdventHymn.Advent_8.GetUsedTimes();
                case 9:
                    TheAdventHymn.Advent_9.incrementUsedTimes();
                    return TheAdventHymn.Advent_9.GetUsedTimes();
                case 10:
                    TheAdventHymn.Advent_10.incrementUsedTimes();
                    return TheAdventHymn.Advent_10.GetUsedTimes();
                case 11:
                    TheAdventHymn.Advent_11.incrementUsedTimes();
                    return TheAdventHymn.Advent_11.GetUsedTimes();
                default:
                    return -1;
            }
        }

        /// <summary>
        /// Looks for the song and then return the details in this order:
        /// Number, Name, KeySignature, Lyrics
        /// </summary>
        /// <param name="songNumber"> the song number to look for </param>
        /// <returns> A list containing Number in pos[0], Name, KeySignature in pos[1], Lyrics in pos[2]. It returns an empty list if song not found</returns>
        public static List<string> GetAdventSong(string songNumber)
        {
            var songNum = Convert.ToInt32(songNumber);
            //look for the song number
            switch (songNum)
            {
                case 1:
                    return TheAdventHymn.Advent_1.songDetails();
                case 2:
                    return TheAdventHymn.Advent_2.songDetails();
                case 3:
                    return TheAdventHymn.Advent_3.songDetails();
                case 4:
                    return TheAdventHymn.Advent_4.songDetails();
                case 5:
                    return TheAdventHymn.Advent_5.songDetails();
                case 6:
                    return TheAdventHymn.Advent_6.songDetails();
                case 7:
                    return TheAdventHymn.Advent_7.songDetails();
                case 8:
                    return TheAdventHymn.Advent_8.songDetails();
                case 9:
                    return TheAdventHymn.Advent_9.songDetails();
                case 10:
                    return TheAdventHymn.Advent_10.songDetails();
                case 11:
                    return TheAdventHymn.Advent_11.songDetails();
                default:
                    return new List<string>();
            }
        }

        /// <summary>
        /// Changes the lyrics on the program, and it
        /// Changes the lyrics of the song and store them in a cache file.
        /// </summary>
        /// <param name="songNumber"> Song number </param>
        /// <param name="LyricsToUpdate"> New lyrics </param>
        public static void UpdateAdventSongLyrics(string songNumber, string LyricsToUpdate)
        {
            var songNum = Convert.ToInt32(songNumber);
            //look for the song number
            switch (songNum)
            {
                case 1:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_1.changeLyrics(LyricsToUpdate);
                    break;
                case 2:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_2.changeLyrics(LyricsToUpdate);
                    break;
                case 3:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_3.changeLyrics(LyricsToUpdate);
                    break;
                case 4:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_4.changeLyrics(LyricsToUpdate);
                    break;
                case 5:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_5.changeLyrics(LyricsToUpdate);
                    break;
                case 6:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_6.changeLyrics(LyricsToUpdate);
                    break;
                case 7:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_7.changeLyrics(LyricsToUpdate);
                    break;
                case 8:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_8.changeLyrics(LyricsToUpdate);
                    break;
                case 9:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_9.changeLyrics(LyricsToUpdate);
                    break;
                case 10:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_10.changeLyrics(LyricsToUpdate);
                    break;
                case 11:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate, HymnType.AdventHymn);
                    TheAdventHymn.Advent_11.changeLyrics(LyricsToUpdate);
                    break;
                default:
                    break;
            }
        }
        
    }
}
