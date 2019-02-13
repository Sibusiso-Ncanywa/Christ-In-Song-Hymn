using LizHackMethods.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LizHackMethods.Classes
{
    /// <summary>
    /// The song class
    /// </summary>
    public class SongClass : IComparable, IComparer, IEqualityComparer, IEquatable<SongClass>
    {
        /// <summary>
        ///  the name of the song
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// the key signature of the song
        /// </summary>
        public string KeySignature { get; set; }

        /// <summary>
        /// number of the song
        /// </summary>
        public string SongNumber { get; set; }

        /// <summary>
        /// keeps track of how many times the song has been used
        /// </summary>
        public int UsedForTimes { get; private set; }

        /// <summary>
        /// The lyrics of the song
        /// </summary>
        public string Lyrics { get; set; }

        /// <summary>
        /// The type of the song.
        /// It can be Christ in song or an Advent hymn.
        /// </summary>
        public HymnType ChristInSongOrAdventHymn { get; set; }

        /// <summary>
        /// Default constructor.s
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="lyrics"></param>
        /// <param name="usedFor"></param>
        public SongClass(string name, string KeySignature, string Number, string lyrics, int usedFor)
        {
            this.KeySignature = KeySignature;
            Name = name;
            SongNumber = Number;
            Lyrics = lyrics;
            UsedForTimes = usedFor;
        }

        /// <summary>
        /// Customised constructor.
        /// used to store the number of times it has been used.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="usedFor"></param>
        public SongClass(string songName, string number, string usedFor, HymnType Type)
        {
            Name = songName;
            ChristInSongOrAdventHymn = Type;
            SongNumber = number;
            UsedForTimes = Convert.ToInt32(usedFor);
        }

        /// <summary>
        /// increment the usedfor value by one
        /// </summary>
        public void IncrementNumUsedFor() => UsedForTimes++;

        /// <summary>
        /// get the song number and the number of the times the song has been used.
        /// format: number, Number of times used
        /// </summary>
        /// <returns></returns>
        public string GetNumberAndTimesUsed() => $"{SongNumber},{UsedForTimes}";

        /// <summary>
        /// gets the Name, Key Signature, Number respectively.
        /// </summary>
        /// <returns></returns>
        public List<string> GetNameKeyNumber() => new List<string> { Name, KeySignature, SongNumber };

        /// <summary>
        /// Checks if the "UsedForTimes" number is bigger, smaller, or equal to
        /// </summary>
        /// <param name="obj"> song to compare to</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            SongClass song = (SongClass)obj;
            if ((UsedForTimes.CompareTo(song.UsedForTimes) == 1) && ChristInSongOrAdventHymn == song.ChristInSongOrAdventHymn) return 1;
            else if ((UsedForTimes.CompareTo(song.UsedForTimes) == 0) && ChristInSongOrAdventHymn == song.ChristInSongOrAdventHymn) return 0;
            else return -1;
        }

        /// <summary>
        /// Checks if object one is bigger or smaller that object 2
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public int Compare(object one, object two)
        {
            SongClass song1 = (SongClass)one;
            SongClass song2 = (SongClass)two;
            return Convert.ToInt32(song1.SongNumber) >= Convert.ToInt32(song2.SongNumber) ? 1 : -1;
        }

        /// <summary>
        /// checks if the two objects are equal
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public new bool Equals(object one, object two)
        {
            SongClass song1 = (SongClass)one;
            SongClass song2 = (SongClass)two;
            bool songNum = Convert.ToInt32(song1.SongNumber) == Convert.ToInt32(song2.SongNumber);
            bool songtype = song1.ChristInSongOrAdventHymn == song2.ChristInSongOrAdventHymn;
            return songNum && songtype ? true : false;
        }

        /// <summary>
        /// checks if the song is equal to the <paramref name="other"/>
        /// </summary>
        /// <param name="other"> the song to equate to </param>
        /// <returns></returns>
        public bool Equals(SongClass other)
        {
            bool songNum = Convert.ToInt32(SongNumber) == Convert.ToInt32(other.SongNumber);
            bool songtype = ChristInSongOrAdventHymn == other.ChristInSongOrAdventHymn;
            return songNum && songtype ? true : false;
        }

        public int GetHashCode(object obj) => throw new NotImplementedException();

        //public override string ToString()
        //{
        //    // SongNumber | Hymn Type | Song Title
        //    string TypeIs = ChristInSongOrAdventHymn == HymnType.AdventHymn ? "AH" : "CIS";
        //    return $"{SongNumber} | {TypeIs} | {Name.Trim()}";
        //}

    }
}
