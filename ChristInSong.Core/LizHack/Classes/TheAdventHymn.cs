using LizHackMethods.LogicMethods;
using System.Collections.Generic;
using LizHackMethods.Enums;
using ChristInSong.Core;

namespace LizHackMethods.Classes
{
       public class TheAdventHymn
       {
              #region Helper Methods

              /// <summary>
              /// Gets the song details and stores them in a list.
              /// Number, Name, KeySignature, Lyrics respectively.
              /// </summary>
              /// <returns></returns>
              private static List<string> GetSongDetails(string number, string name, string keySig, string lyrics)
              {
                     string theLyrics = GetTheLyrics(number, lyrics);
                     return new List<string> { number, name, keySig, theLyrics };
              }

              /// <summary>
              /// Gets the lyrics of the song.
              /// </summary>
              /// <returns></returns>
              private static string GetTheLyrics(string Number, string theLyrics)
              {
                     string result = GeneralMethods.GetSongLyricCache(Number,HymnType.AdventHymn);

                     // if no cache was found load the original lyrics
                     if (result != "")
                            return result;

                     // create temp store
                     string tempLyrics = null;

                     // fix the format of the lyrics
                     string[] tempLyricArray = theLyrics.Split('|');

                     foreach (string line in tempLyricArray)
                     {
                            // if adding for first time
                            if (string.IsNullOrEmpty(tempLyrics))
                            {
                                   tempLyrics = line;
                            }
                            else
                            {
                                   tempLyrics += $"\n{line}";
                            }
                     }

                     return tempLyrics;
              }

              /// <summary>
              /// It increments the number of times the song has been used.
              /// </summary>
              private static int IncrementUsedTimesNum(int number) => number + 1;

              /// <summary>
              /// It returns the numberr of times the song has been used.
              /// </summary>
              private static int GetSongUsedTimes(int number) => number;

              /// <summary>
              /// changes the lyrics of the song.
              /// </summary>
              /// <param name="newLyrics"> string of the new lyrics </param>
              private static string ChangeSongLyrics(string TheNewLyrics)
              {
                     string newVersion = TheNewLyrics;
                     return newVersion;
              }

              /// <summary>
              /// Changes the key signature of the song.
              /// </summary>
              /// <param name="newKeySig"></param>
              private static string ChangeSongKeySignature(string newKey) => newKey;

              /// <summary>
              /// Recovers the lyrics of the song and replaces the lyrics.
              /// </summary>
              /// <returns></returns>
              private static string RecoverLyrics(string number, string lyrics)
              {
                     return GetTheLyrics(number, lyrics);
              }

              #endregion


              public static class Advent_1
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " Before Jehovah’s Awful Throne";
                     private static readonly string Number = "1";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. Before Jehovah’s awful throne," +
                 "|Ye nations, bow with sacred joy;" +
                 "|Know that the Lord is God alone;" +
                 "|He can create, and He destroy." +
                 "|" +
                 "|2. His sovereign power, without our aid," +
                 "|Made us of clay, and formed us men;" +
                 "|And when like wandering sheep we strayed," +
                 "|He brought us to His fold again" +
                 "|" +
                 "|3. We’ll crowd His gates with thankful songs," +
                 "|High as the heavens our voices raise;" +
                 "|And earth, with her ten thousand tongues," +
                 "|Shall fill His courts with sounding praise." +
                 "|" +
                 "|4. Wide as the world is His command," +
                 "|Vast as Eternity His love;" +
                 "|Firm as a rock His truth shall stand," +
                 "|When rolling years shall cease" +
                 "|to move" +
                 "|" +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. Before Jehovah’s awful throne," +
                 "|Ye nations, bow with sacred joy;" +
                 "|Know that the Lord is God alone;" +
                 "|He can create, and He destroy." +
                 "|" +
                 "|2. His sovereign power, without our aid," +
                 "|Made us of clay, and formed us men;" +
                 "|And when like wandering sheep we strayed," +
                 "|He brought us to His fold again" +
                 "|" +
                 "|3. We’ll crowd His gates with thankful songs," +
                 "|High as the heavens our voices raise;" +
                 "|And earth, with her ten thousand tongues," +
                 "|Shall fill His courts with sounding praise." +
                 "|" +
                 "|4. Wide as the world is His command," +
                 "|Vast as Eternity His love;" +
                 "|Firm as a rock His truth shall stand," +
                 "|When rolling years shall cease" +
                 "|to move" +
                 "|" +
                 "|"
                 ;

              }

              public static class Advent_2
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " Let All Men Sing Jehovah’s Praises";
                     private static readonly string Number = "2";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. Let all men sing Jehovah’s praises; " +
                 "|Sing to the living God above!" +
                 "|His goodness stands above the ages, " +
                 "|It is eternal like His love." +
                 "|Come Israel sing your Sov’reign’s praises, " +
                 "|" +
                 "|Sing of His fame and majesty;" +
                 "|His goodness stands above the ages " +
                 "|And lasts throughout eternity." +
                 "|" +
                 "|2. God is my strength and my salvation;" +
                 "|He is my psalm, my joy, and my song." +
                 "|He is my daily inspiration;" +
                 "|I’ll sing His praises all day long." +
                 "|" +
                 "|He hears the song that I am singing" +
                 "|Of blessings given me each day," +
                 "|My song within His courts is ringing:" +
                 "|His strength goes with me all the way." +
                 "|" +
                 "|3. This day was blessed at creation," +
                 "|This day which God has sanctified." +
                 "|Let us rejoice in His salvation" +
                 "|Who in these temple courts abide." +
                 "|" +
                 "|O Lord, grant us Thy richest blessing" +
                 "|Free us from earthly cares today" +
                 "|Let every saint, Thy name confessing," +
                 "|Be prospered at Thy hand, we pray." +
                 "|" +
                 "|4. Thou art my God, I’ll sing Thy praises," +
                 "|I will exalt Thy majesty!" +
                 "|Thy goodness lasts through endless ages" +
                 "|Thy mercy to eternity." +
                 "|" +
                 "|Let all men sing Jehovah’s praises" +
                 "|Sing to the living God above." +
                 "|His goodness stands above the ages" +
                 "|And lasts throughout eternity." +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. Let all men sing Jehovah’s praises; " +
                 "|Sing to the living God above!" +
                 "|His goodness stands above the ages, " +
                 "|It is eternal like His love." +
                 "|Come Israel sing your Sov’reign’s praises, " +
                 "|" +
                 "|Sing of His fame and majesty;" +
                 "|His goodness stands above the ages " +
                 "|And lasts throughout eternity." +
                 "|" +
                 "|2. God is my strength and my salvation;" +
                 "|He is my psalm, my joy, and my song." +
                 "|He is my daily inspiration;" +
                 "|I’ll sing His praises all day long." +
                 "|" +
                 "|He hears the song that I am singing" +
                 "|Of blessings given me each day," +
                 "|My song within His courts is ringing:" +
                 "|His strength goes with me all the way." +
                 "|" +
                 "|3. This day was blessed at creation," +
                 "|This day which God has sanctified." +
                 "|Let us rejoice in His salvation" +
                 "|Who in these temple courts abide." +
                 "|" +
                 "|O Lord, grant us Thy richest blessing" +
                 "|Free us from earthly cares today" +
                 "|Let every saint, Thy name confessing," +
                 "|Be prospered at Thy hand, we pray." +
                 "|" +
                 "|4. Thou art my God, I’ll sing Thy praises," +
                 "|I will exalt Thy majesty!" +
                 "|Thy goodness lasts through endless ages" +
                 "|Thy mercy to eternity." +
                 "|" +
                 "|Let all men sing Jehovah’s praises" +
                 "|Sing to the living God above." +
                 "|His goodness stands above the ages" +
                 "|And lasts throughout eternity." +
                 "|"
                 ;

              }

              public static class Advent_3
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " O Worship The Lord";
                     private static readonly string Number = "3";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. O worship the Lord in the beauty of holiness," +
                 "|Bow down before Him, His glory proclaim;" +
                 "|With gold of obedience, and incense of lowliness," +
                 "|Kneel and adore Him; the Lord is His name." +
                 "|" +
                 "|2. Low at His feet lay thy burden" +
                 "|of carefulness;" +
                 "|High on His heart He will bear" +
                 "|it for thee," +
                 "|" +
                 "|Comfort thy sorrows, and " +
                 "|answer thy prayerfulness," +
                 "|Guiding thy steps as may best" +
                 "|for thee be." +
                 "|" +
                 "|3. Fear not to enter His courts in the slenderness" +
                 "|Of the poor wealth thou wouldst reckon as thine." +
                 "|Truth in  its beauty and love in its tenderness," +
                 "|These are the offerings to lay on His shrine." +
                 "|" +
                 "|4. These, though we bring them in trembling and fearfulness," +
                 "|He will accept for the Name that is" +
                 "| dear;" +
                 "|Mornings of joy give for evenings of tearfulness," +
                 "|Trust for our trembling, and hope for " +
                 "|our fear. " +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. O worship the Lord in the beauty of holiness," +
                 "|Bow down before Him, His glory proclaim;" +
                 "|With gold of obedience, and incense of lowliness," +
                 "|Kneel and adore Him; the Lord is His name." +
                 "|" +
                 "|2. Low at His feet lay thy burden" +
                 "|of carefulness;" +
                 "|High on His heart He will bear" +
                 "|it for thee," +
                 "|" +
                 "|Comfort thy sorrows, and " +
                 "|answer thy prayerfulness," +
                 "|Guiding thy steps as may best" +
                 "|for thee be." +
                 "|" +
                 "|3. Fear not to enter His courts in the slenderness" +
                 "|Of the poor wealth thou wouldst reckon as thine." +
                 "|Truth in  its beauty and love in its tenderness," +
                 "|These are the offerings to lay on His shrine." +
                 "|" +
                 "|4. These, though we bring them in trembling and fearfulness," +
                 "|He will accept for the Name that is" +
                 "| dear;" +
                 "|Mornings of joy give for evenings of tearfulness," +
                 "|Trust for our trembling, and hope for " +
                 "|our fear. " +
                 "|"
                 ;

              }

              public static class Advent_4
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " Angel Voices Ever Singing ";
                     private static readonly string Number = "4";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. Angel voices ever singing round Thy throne of light;" +
                 "|Angel harps, forever ringing, rest not day nor night" +
                 "|Thousands only live to bless Thee," +
                 "|And confess Thee Lord of might." +
                 "|" +
                 "|2. Thou who art beyond the farthest" +
                 "| mortal eye can scan," +
                 "|Can it be that Thou regardest songs of sinful man?" +
                 "|Can we feel that Thou art near us," +
                 "|And wilt bear us? Yea, we can. " +
                 "|" +
                 "|3. Yea, we know Thy love rejoices o’er each work of Thine;" +
                 "|Thou didst ears and hands and voices for Thy praise combine;" +
                 "|Craftsman's art and music’s measure" +
                 "|For Thy pleasure didst design." +
                 "|" +
                 "|4. Here, great God, today we offer of " +
                 "|Thine own to Thee;" +
                 "|And for Thine acceptance proffer, all unworthily," +
                 "|Hearts and minds and hands and " +
                 "|voices," +
                 "|In our choicest melody. " +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. Angel voices ever singing round Thy throne of light;" +
                 "|Angel harps, forever ringing, rest not day nor night" +
                 "|Thousands only live to bless Thee," +
                 "|And confess Thee Lord of might." +
                 "|" +
                 "|2. Thou who art beyond the farthest" +
                 "| mortal eye can scan," +
                 "|Can it be that Thou regardest songs of sinful man?" +
                 "|Can we feel that Thou art near us," +
                 "|And wilt bear us? Yea, we can. " +
                 "|" +
                 "|3. Yea, we know Thy love rejoices o’er each work of Thine;" +
                 "|Thou didst ears and hands and voices for Thy praise combine;" +
                 "|Craftsman's art and music’s measure" +
                 "|For Thy pleasure didst design." +
                 "|" +
                 "|4. Here, great God, today we offer of " +
                 "|Thine own to Thee;" +
                 "|And for Thine acceptance proffer, all unworthily," +
                 "|Hearts and minds and hands and " +
                 "|voices," +
                 "|In our choicest melody. " +
                 "|"
                 ;

              }

              public static class Advent_5
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " All People That on Earth Do Dwell  ";
                     private static readonly string Number = "5";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. All people that on earth do dwell," +
                 "|Sing to the Lord with cheerful voice;" +
                 "|Him serve with fear, His praise forth tell;" +
                 "|Come ye before Him and rejoice." +
                 "|" +
                 "|2. The Lord ye know is God indeed;" +
                 "|Without our aid he did us make;" +
                 "|We are His folk, He doth us feed;" +
                 "|And for His sheep He doth us take. " +
                 "|" +
                 "|3. O enter then, His gates with praise," +
                 "|Approach with joy His courts unto;" +
                 "|Praise, laud, and bless His Name always," +
                 "|For it is seemly so to do." +
                 "|" +
                 "|4. For why? The Lord our God is good," +
                 "|His mercy is forever sure;" +
                 "|His truth at all times firmly stood," +
                 "|And shall from age to age endure." +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. All people that on earth do dwell," +
                 "|Sing to the Lord with cheerful voice;" +
                 "|Him serve with fear, His praise forth tell;" +
                 "|Come ye before Him and rejoice." +
                 "|" +
                 "|2. The Lord ye know is God indeed;" +
                 "|Without our aid he did us make;" +
                 "|We are His folk, He doth us feed;" +
                 "|And for His sheep He doth us take. " +
                 "|" +
                 "|3. O enter then, His gates with praise," +
                 "|Approach with joy His courts unto;" +
                 "|Praise, laud, and bless His Name always," +
                 "|For it is seemly so to do." +
                 "|" +
                 "|4. For why? The Lord our God is good," +
                 "|His mercy is forever sure;" +
                 "|His truth at all times firmly stood," +
                 "|And shall from age to age endure." +
                 "|"
                 ;

              }

              public static class Advent_6
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " Lord of All Being, Throned Afar   ";
                     private static readonly string Number = "6";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. Lord of all being, throned afar," +
                 "|Thy glory flames from sun and star;" +
                 "|Centre and soul of every sphere," +
                 "|Yet to each loving heart how near!" +
                 "|Yet to each loving heart how near!" +
                 "|" +
                 "|2. Sun of our life, Thy quickening ray" +
                 "|Sheds on our path the glow of day;" +
                 "|Star of our hope, Thy softened light" +
                 "|Cheers the long watches of the night," +
                 "|Cheers the long watches of the night." +
                 "|" +
                 "|3. Our midnight is Thy smile withdrawn;" +
                 "|Our noontide is Thy gracious dawn;" +
                 "|Our rainbow arch, Thy mercy’s sign;" +
                 "|All, save the clouds of sin, are Thine," +
                 "|All, save the clouds of sin, are Thine." +
                 "|" +
                 "|4. Lord of all life, below, above." +
                 "|Whose light is truth, whose warmth is love," +
                 "|Before Thy ever-blazing throne" +
                 "|We ask no lustre of our own," +
                 "|We ask no lustre of our own." +
                 "|" +
                 "|5. Grant us Thy truth to make us free," +
                 "|And kindling hearts that burn for Thee;" +
                 "|Till all Thy living altars claim" +
                 "|One holy light, one heavenly flame!" +
                 "|One holy light, one heavenly flame." +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. Lord of all being, throned afar," +
                 "|Thy glory flames from sun and star;" +
                 "|Centre and soul of every sphere," +
                 "|Yet to each loving heart how near!" +
                 "|Yet to each loving heart how near!" +
                 "|" +
                 "|2. Sun of our life, Thy quickening ray" +
                 "|Sheds on our path the glow of day;" +
                 "|Star of our hope, Thy softened light" +
                 "|Cheers the long watches of the night," +
                 "|Cheers the long watches of the night." +
                 "|" +
                 "|3. Our midnight is Thy smile withdrawn;" +
                 "|Our noontide is Thy gracious dawn;" +
                 "|Our rainbow arch, Thy mercy’s sign;" +
                 "|All, save the clouds of sin, are Thine," +
                 "|All, save the clouds of sin, are Thine." +
                 "|" +
                 "|4. Lord of all life, below, above." +
                 "|Whose light is truth, whose warmth is love," +
                 "|Before Thy ever-blazing throne" +
                 "|We ask no lustre of our own," +
                 "|We ask no lustre of our own." +
                 "|" +
                 "|5. Grant us Thy truth to make us free," +
                 "|And kindling hearts that burn for Thee;" +
                 "|Till all Thy living altars claim" +
                 "|One holy light, one heavenly flame!" +
                 "|One holy light, one heavenly flame." +
                 "|"
                 ;

              }

              public static class Advent_7
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " The Lord Jehovah Reigns   ";
                     private static readonly string Number = "7";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. The Lord Jehovah reigns, His throne is built on high;" +
                 "|The garments He assumes are light and majesty." +
                 "|His glories shine with beams so bright" +
                 "|No mortal eye can bear the sight." +
                 "|" +
                 "|2. The thunders of His hand keep the wide world in awe;" +
                 "|His wrath and justice stand to guard His holy law." +
                 "|And where His love resolves to bless," +
                 "|His truth confirms and seals the grace." +
                 "|" +
                 "|3. Through all His mighty works amazing wisdom shines;" +
                 "|Confounds the powers of hell, and all their dark designs." +
                 "|Strong is His arm, and shall fulfil" +
                 "|His great decrees and sovereign will." +
                 "|" +
                 "|4. And will this sovereign King of glory condescend," +
                 "|And will He write His name my Father and my Friend?" +
                 "|I love His name. I love His word;" +
                 "|Join all my powers to praise the Lord!" +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. The Lord Jehovah reigns, His throne is built on high;" +
                 "|The garments He assumes are light and majesty." +
                 "|His glories shine with beams so bright" +
                 "|No mortal eye can bear the sight." +
                 "|" +
                 "|2. The thunders of His hand keep the wide world in awe;" +
                 "|His wrath and justice stand to guard His holy law." +
                 "|And where His love resolves to bless," +
                 "|His truth confirms and seals the grace." +
                 "|" +
                 "|3. Through all His mighty works amazing wisdom shines;" +
                 "|Confounds the powers of hell, and all their dark designs." +
                 "|Strong is His arm, and shall fulfil" +
                 "|His great decrees and sovereign will." +
                 "|" +
                 "|4. And will this sovereign King of glory condescend," +
                 "|And will He write His name my Father and my Friend?" +
                 "|I love His name. I love His word;" +
                 "|Join all my powers to praise the Lord!" +
                 "|"
                 ;

              }

              public static class Advent_8
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " O for a Heart to Praise My God!   ";
                     private static readonly string Number = "8";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. O for a heart to praise my God!" +
                 "|A heart from sin set free," +
                 "|A heart that always feels Thy blood," +
                 "|So freely shed for me." +
                 "|" +
                 "|2. A heart resigned, submissive meek," +
                 "|My dear Redeemer’s throne," +
                 "|Where only Christ is heard to speak," +
                 "|Where Jesus reigns alone." +
                 "|" +
                 "|3. A heart in every thought renewed," +
                 "|And full of love divine," +
                 "|Perfect, and right, and pure, and good," +
                 "|A copy, Lord, of Thine." +
                 "|" +
                 "|4. Thy nature, gracious Lord, impart;" +
                 "|Come quickly from above;" +
                 "|Write Thy new name upon my heart," +
                 "|Thy new, best name of Love." +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. O for a heart to praise my God!" +
                 "|A heart from sin set free," +
                 "|A heart that always feels Thy blood," +
                 "|So freely shed for me." +
                 "|" +
                 "|2. A heart resigned, submissive meek," +
                 "|My dear Redeemer’s throne," +
                 "|Where only Christ is heard to speak," +
                 "|Where Jesus reigns alone." +
                 "|" +
                 "|3. A heart in every thought renewed," +
                 "|And full of love divine," +
                 "|Perfect, and right, and pure, and good," +
                 "|A copy, Lord, of Thine." +
                 "|" +
                 "|4. Thy nature, gracious Lord, impart;" +
                 "|Come quickly from above;" +
                 "|Write Thy new name upon my heart," +
                 "|Thy new, best name of Love." +
                 "|"
                 ;

              }

              public static class Advent_9
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " Praise the Lord With Joy Exceeding   ";
                     private static readonly string Number = "9";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. Praise the Lord with joy exceeding," +
                 "|Thou, my soul, hast cause to sing;" +
                 "|While I live and have my being" +
                 "|Joyful lays to Him I’ll bring;" +
                 "|And, while in this earthly frame," +
                 "|E’er exalt His holy name." +
                 "|" +
                 "|2. Trust not prices for salvation," +
                 "|Nor the arm of flesh for aid;" +
                 "|For their might and expectation" +
                 "|Soon in lowly dust are laid." +
                 "|Man has but a fleeting breath," +
                 "|And his glory fades at death. " +
                 "|" +
                 "|3. Happy is the man who waiteth" +
                 "|For his help on Jacob’s God." +
                 "|Who both heav’n and earth created" +
                 "|Yea, whose hope is in the Lord." +
                 "|He who doth on God depend" +
                 "|Will His truth and right defend. " +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. Praise the Lord with joy exceeding," +
                 "|Thou, my soul, hast cause to sing;" +
                 "|While I live and have my being" +
                 "|Joyful lays to Him I’ll bring;" +
                 "|And, while in this earthly frame," +
                 "|E’er exalt His holy name." +
                 "|" +
                 "|2. Trust not prices for salvation," +
                 "|Nor the arm of flesh for aid;" +
                 "|For their might and expectation" +
                 "|Soon in lowly dust are laid." +
                 "|Man has but a fleeting breath," +
                 "|And his glory fades at death. " +
                 "|" +
                 "|3. Happy is the man who waiteth" +
                 "|For his help on Jacob’s God." +
                 "|Who both heav’n and earth created" +
                 "|Yea, whose hope is in the Lord." +
                 "|He who doth on God depend" +
                 "|Will His truth and right defend. " +
                 "|"
                 ;

              }

              public static class Advent_10
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = "With Reverence Let the Saints Appear    ";
                     private static readonly string Number = "10";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. With reverence let the saints appear," +
                 "|And bow before the Lord;" +
                 "|His high commands with reverence hear," +
                 "|And tremble at His word; and tremble at His word." +
                 "|" +
                 "|2. How terrible Thy glories be!" +
                 "|How bright Thine armies shine!" +
                 "|Where is the power that vies with Thee," +
                 "|Or truth compared with Thine? or truth compared with Thine? " +
                 "|" +
                 "|3. Sing, all ye ransomed of the Lord," +
                 "|Your great Deliverer sing;" +
                 "|Ye pilgrims now for Zion bound," +
                 "|Be joyful in your King; be joyful in your King." +
                 "|" +
                 "|4. O Jesus, Lord of earth and heaven," +
                 "|Our life and joy, to Thee" +
                 "|Be honour, thanks, and blessing given" +
                 "|Through all eternity; through all eternity." +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. With reverence let the saints appear," +
                 "|And bow before the Lord;" +
                 "|His high commands with reverence hear," +
                 "|And tremble at His word; and tremble at His word." +
                 "|" +
                 "|2. How terrible Thy glories be!" +
                 "|How bright Thine armies shine!" +
                 "|Where is the power that vies with Thee," +
                 "|Or truth compared with Thine? or truth compared with Thine? " +
                 "|" +
                 "|3. Sing, all ye ransomed of the Lord," +
                 "|Your great Deliverer sing;" +
                 "|Ye pilgrims now for Zion bound," +
                 "|Be joyful in your King; be joyful in your King." +
                 "|" +
                 "|4. O Jesus, Lord of earth and heaven," +
                 "|Our life and joy, to Thee" +
                 "|Be honour, thanks, and blessing given" +
                 "|Through all eternity; through all eternity." +
                 "|"
                 ;

              }

              public static class Advent_11
              {

                     /// <summary>
                     /// Gets the song details and stores them in a list.
                     /// Number, Name, KeySignature, Lyrics respectively.
                     /// </summary>
                     public static List<string> songDetails()
                     {
                            return GetSongDetails(Number, Name, KeySignature, Lyrics);
                     }

                     /// <summary>
                     /// Gets the lyrics of the song.
                     /// </summary>
                     public static string getLyrics()
                     {
                            return GetTheLyrics(Number, Lyrics);
                     }

                     /// <summary>
                     /// It increments the number of times the song has been used.
                     /// </summary>
                     public static void incrementUsedTimes()
                     {
                            numberOfTimesUsed = IncrementUsedTimesNum(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// It returns the numberr of times the song has been used.
                     /// </summary>
                     public static int GetUsedTimes()
                     {
                            return GetSongUsedTimes(numberOfTimesUsed);
                     }

                     /// <summary>
                     /// changes the lyrics of the song.
                     /// </summary>
                     /// <param name="newLyrics"> string of the new lyrics </param>
                     public static void changeLyrics(string newLyrics)
                     {
                            Lyrics = ChangeSongLyrics(newLyrics);
                     }

                     /// <summary>
                     /// Changes the key signature of the song.
                     /// </summary>
                     /// <param name="newKeySig"></param>
                     public static void changeKeySignature(string newKeySig)
                     {
                            KeySignature = ChangeSongKeySignature(newKeySig);
                     }

                     /// <summary>
                     /// Recovers the lyrics of the song and replaces the lyrics.
                     /// </summary>
                     public static string recover_Lyrics()
                     {
                            Lyrics = recoverLyrics;
                            return RecoverLyrics(Number, Lyrics);
                     }

                     private static readonly string Name = " Come, Thou Almighty King    ";
                     private static readonly string Number = "11";
                     private static string KeySignature = "To be Added";
                     private static int numberOfTimesUsed = 0;
                     private static string Lyrics = "|" +
                 "|1. Come, Thou Almighty King," +
                 "|Help us Thy name to sing," +
                 "|Help us to praise." +
                 "|Father all glorious," +
                 "|O’er all victorious," +
                 "|Come and reign over us," +
                 "|Ancient of days" +
                 "|" +
                 "|2. Come, holy Comforter," +
                 "|Thy sacred witness bear" +
                 "|In this glad hour:" +
                 "|Thou who almighty art," +
                 "|Rule now in every heart," +
                 "|And ne’er from us depart," +
                 "|Spirit of power." +
                 "|" +
                 "|3. Thou art the mighty One," +
                 "|On earth Thy will be done" +
                 "|From shore to shore." +
                 "|Thy sovereign majesty" +
                 "|May we in glory see," +
                 "|And to eternity" +
                 "|Love and adore." +
                 "|"
                 ;
                     private static string recoverLyrics = "|" +
                 "|1. Come, Thou Almighty King," +
                 "|Help us Thy name to sing," +
                 "|Help us to praise." +
                 "|Father all glorious," +
                 "|O’er all victorious," +
                 "|Come and reign over us," +
                 "|Ancient of days" +
                 "|" +
                 "|2. Come, holy Comforter," +
                 "|Thy sacred witness bear" +
                 "|In this glad hour:" +
                 "|Thou who almighty art," +
                 "|Rule now in every heart," +
                 "|And ne’er from us depart," +
                 "|Spirit of power." +
                 "|" +
                 "|3. Thou art the mighty One," +
                 "|On earth Thy will be done" +
                 "|From shore to shore." +
                 "|Thy sovereign majesty" +
                 "|May we in glory see," +
                 "|And to eternity" +
                 "|Love and adore." +
                 "|"
                 ;

              }

       }
}
