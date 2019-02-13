using ChristInSong.Core;
using LizHackMethods.Classes;
using LizHackMethods.Enums;
using System;
using System.Collections.Generic;

namespace LizHackMethods.LogicMethods
{
    /// <summary>
    /// Methods Relating to the Christ In Song hymnal
    /// </summary>
    public static class CIS_LogicMethods
    {
        /// <summary>
        /// Gets the Doxology lyrics of Christ in song.
        /// </summary>
        /// <returns></returns>
        public static string CisDoxlogy() => ChristInSongHymn.Doxology.GetLyrics();

        /// <summary>
        /// Looks for the number given and ouput the number of times the song has been used.
        /// </summary>
        /// <param name="songNumber"> the song number to look for </param>
        /// <returns> the number of times used for </returns>
        public static int IncrementAndgetUsedForNum(string songNumber)
        {
            // make an int copy of the song number
            var songNum = Convert.ToInt32(songNumber);
            //look for the song number
            switch (songNum)
            {
                case 1:
                    ChristInSongHymn.Song_1.incrementUsedTimes();
                    return ChristInSongHymn.Song_1.GetUsedTimes();
                case 2:
                    ChristInSongHymn.Song_2.incrementUsedTimes();
                    return ChristInSongHymn.Song_2.GetUsedTimes();
                case 3:
                    ChristInSongHymn.Song_3.incrementUsedTimes();
                    return ChristInSongHymn.Song_3.GetUsedTimes();
                case 4:
                    ChristInSongHymn.Song_4.incrementUsedTimes();
                    return ChristInSongHymn.Song_4.GetUsedTimes();
                case 5:
                    ChristInSongHymn.Song_5.incrementUsedTimes();
                    return ChristInSongHymn.Song_5.GetUsedTimes();
                case 6:
                    ChristInSongHymn.Song_6.incrementUsedTimes();
                    return ChristInSongHymn.Song_6.GetUsedTimes();
                case 7:
                    ChristInSongHymn.Song_7.incrementUsedTimes();
                    return ChristInSongHymn.Song_7.GetUsedTimes();
                case 8:
                    ChristInSongHymn.Song_8.incrementUsedTimes();
                    return ChristInSongHymn.Song_8.GetUsedTimes();
                case 9:
                    ChristInSongHymn.Song_9.incrementUsedTimes();
                    return ChristInSongHymn.Song_9.GetUsedTimes();
                case 10:
                    ChristInSongHymn.Song_10.incrementUsedTimes();
                    return ChristInSongHymn.Song_10.GetUsedTimes();
                case 11:
                    ChristInSongHymn.Song_11.incrementUsedTimes();
                    return ChristInSongHymn.Song_11.GetUsedTimes();
                case 12:
                    ChristInSongHymn.Song_12.incrementUsedTimes();
                    return ChristInSongHymn.Song_12.GetUsedTimes();
                case 13:
                    ChristInSongHymn.Song_13.incrementUsedTimes();
                    return ChristInSongHymn.Song_13.GetUsedTimes();
                case 14:
                    ChristInSongHymn.Song_14.incrementUsedTimes();
                    return ChristInSongHymn.Song_14.GetUsedTimes();
                case 15:
                    ChristInSongHymn.Song_15.incrementUsedTimes();
                    return ChristInSongHymn.Song_15.GetUsedTimes();
                case 16:
                    ChristInSongHymn.Song_16.incrementUsedTimes();
                    return ChristInSongHymn.Song_16.GetUsedTimes();
                case 17:
                    ChristInSongHymn.Song_17.incrementUsedTimes();
                    return ChristInSongHymn.Song_17.GetUsedTimes();
                case 18:
                    ChristInSongHymn.Song_18.incrementUsedTimes();
                    return ChristInSongHymn.Song_18.GetUsedTimes();
                case 19:
                    ChristInSongHymn.Song_19.incrementUsedTimes();
                    return ChristInSongHymn.Song_19.GetUsedTimes();
                case 20:
                    ChristInSongHymn.Song_20.incrementUsedTimes();
                    return ChristInSongHymn.Song_20.GetUsedTimes();
                case 21:
                    ChristInSongHymn.Song_21.incrementUsedTimes();
                    return ChristInSongHymn.Song_21.GetUsedTimes();
                case 22:
                    ChristInSongHymn.Song_22.incrementUsedTimes();
                    return ChristInSongHymn.Song_22.GetUsedTimes();
                case 23:
                    ChristInSongHymn.Song_23.incrementUsedTimes();
                    return ChristInSongHymn.Song_23.GetUsedTimes();
                case 24:
                    ChristInSongHymn.Song_24.incrementUsedTimes();
                    return ChristInSongHymn.Song_24.GetUsedTimes();
                case 25:
                    ChristInSongHymn.Song_25.incrementUsedTimes();
                    return ChristInSongHymn.Song_25.GetUsedTimes();
                case 26:
                    ChristInSongHymn.Song_26.incrementUsedTimes();
                    return ChristInSongHymn.Song_26.GetUsedTimes();
                case 27:
                    ChristInSongHymn.Song_27.incrementUsedTimes();
                    return ChristInSongHymn.Song_27.GetUsedTimes();
                case 28:
                    ChristInSongHymn.Song_28.incrementUsedTimes();
                    return ChristInSongHymn.Song_28.GetUsedTimes();
                case 29:
                    ChristInSongHymn.Song_29.incrementUsedTimes();
                    return ChristInSongHymn.Song_29.GetUsedTimes();
                case 30:
                    ChristInSongHymn.Song_30.incrementUsedTimes();
                    return ChristInSongHymn.Song_30.GetUsedTimes();
                case 31:
                    ChristInSongHymn.Song_31.incrementUsedTimes();
                    return ChristInSongHymn.Song_31.GetUsedTimes();
                case 32:
                    ChristInSongHymn.Song_32.incrementUsedTimes();
                    return ChristInSongHymn.Song_32.GetUsedTimes();
                case 33:
                    ChristInSongHymn.Song_33.incrementUsedTimes();
                    return ChristInSongHymn.Song_33.GetUsedTimes();
                case 34:
                    ChristInSongHymn.Song_34.incrementUsedTimes();
                    return ChristInSongHymn.Song_34.GetUsedTimes();
                case 35:
                    ChristInSongHymn.Song_35.incrementUsedTimes();
                    return ChristInSongHymn.Song_35.GetUsedTimes();
                case 36:
                    ChristInSongHymn.Song_36.incrementUsedTimes();
                    return ChristInSongHymn.Song_36.GetUsedTimes();
                case 37:
                    ChristInSongHymn.Song_37.incrementUsedTimes();
                    return ChristInSongHymn.Song_37.GetUsedTimes();
                case 38:
                    ChristInSongHymn.Song_38.incrementUsedTimes();
                    return ChristInSongHymn.Song_38.GetUsedTimes();
                case 39:
                    ChristInSongHymn.Song_39.incrementUsedTimes();
                    return ChristInSongHymn.Song_39.GetUsedTimes();
                case 40:
                    ChristInSongHymn.Song_40.incrementUsedTimes();
                    return ChristInSongHymn.Song_40.GetUsedTimes();
                case 41:
                    ChristInSongHymn.Song_41.incrementUsedTimes();
                    return ChristInSongHymn.Song_41.GetUsedTimes();
                case 42:
                    ChristInSongHymn.Song_42.incrementUsedTimes();
                    return ChristInSongHymn.Song_42.GetUsedTimes();
                case 43:
                    ChristInSongHymn.Song_43.incrementUsedTimes();
                    return ChristInSongHymn.Song_43.GetUsedTimes();
                case 44:
                    ChristInSongHymn.Song_44.incrementUsedTimes();
                    return ChristInSongHymn.Song_44.GetUsedTimes();
                case 45:
                    ChristInSongHymn.Song_45.incrementUsedTimes();
                    return ChristInSongHymn.Song_45.GetUsedTimes();
                case 46:
                    ChristInSongHymn.Song_46.incrementUsedTimes();
                    return ChristInSongHymn.Song_46.GetUsedTimes();
                case 47:
                    ChristInSongHymn.Song_47.incrementUsedTimes();
                    return ChristInSongHymn.Song_47.GetUsedTimes();
                case 48:
                    ChristInSongHymn.Song_48.incrementUsedTimes();
                    return ChristInSongHymn.Song_48.GetUsedTimes();
                case 49:
                    ChristInSongHymn.Song_49.incrementUsedTimes();
                    return ChristInSongHymn.Song_49.GetUsedTimes();
                case 50:
                    ChristInSongHymn.Song_50.incrementUsedTimes();
                    return ChristInSongHymn.Song_50.GetUsedTimes();
                case 51:
                    ChristInSongHymn.Song_51.incrementUsedTimes();
                    return ChristInSongHymn.Song_51.GetUsedTimes();
                case 52:
                    ChristInSongHymn.Song_52.incrementUsedTimes();
                    return ChristInSongHymn.Song_52.GetUsedTimes();
                case 53:
                    ChristInSongHymn.Song_53.incrementUsedTimes();
                    return ChristInSongHymn.Song_53.GetUsedTimes();
                case 54:
                    ChristInSongHymn.Song_54.incrementUsedTimes();
                    return ChristInSongHymn.Song_54.GetUsedTimes();
                case 55:
                    ChristInSongHymn.Song_55.incrementUsedTimes();
                    return ChristInSongHymn.Song_55.GetUsedTimes();
                case 56:
                    ChristInSongHymn.Song_56.incrementUsedTimes();
                    return ChristInSongHymn.Song_56.GetUsedTimes();
                case 57:
                    ChristInSongHymn.Song_57.incrementUsedTimes();
                    return ChristInSongHymn.Song_57.GetUsedTimes();
                case 58:
                    ChristInSongHymn.Song_58.incrementUsedTimes();
                    return ChristInSongHymn.Song_58.GetUsedTimes();
                case 59:
                    ChristInSongHymn.Song_59.incrementUsedTimes();
                    return ChristInSongHymn.Song_59.GetUsedTimes();
                case 60:
                    ChristInSongHymn.Song_60.incrementUsedTimes();
                    return ChristInSongHymn.Song_60.GetUsedTimes();
                case 61:
                    ChristInSongHymn.Song_61.incrementUsedTimes();
                    return ChristInSongHymn.Song_61.GetUsedTimes();
                case 62:
                    ChristInSongHymn.Song_62.incrementUsedTimes();
                    return ChristInSongHymn.Song_62.GetUsedTimes();
                case 63:
                    ChristInSongHymn.Song_63.incrementUsedTimes();
                    return ChristInSongHymn.Song_63.GetUsedTimes();
                case 64:
                    ChristInSongHymn.Song_64.incrementUsedTimes();
                    return ChristInSongHymn.Song_64.GetUsedTimes();
                case 65:
                    ChristInSongHymn.Song_65.incrementUsedTimes();
                    return ChristInSongHymn.Song_65.GetUsedTimes();
                case 66:
                    ChristInSongHymn.Song_66.incrementUsedTimes();
                    return ChristInSongHymn.Song_66.GetUsedTimes();
                case 67:
                    ChristInSongHymn.Song_67.incrementUsedTimes();
                    return ChristInSongHymn.Song_67.GetUsedTimes();
                case 68:
                    ChristInSongHymn.Song_68.incrementUsedTimes();
                    return ChristInSongHymn.Song_68.GetUsedTimes();
                case 69:
                    ChristInSongHymn.Song_69.incrementUsedTimes();
                    return ChristInSongHymn.Song_69.GetUsedTimes();
                case 70:
                    ChristInSongHymn.Song_70.incrementUsedTimes();
                    return ChristInSongHymn.Song_70.GetUsedTimes();
                case 71:
                    ChristInSongHymn.Song_71.incrementUsedTimes();
                    return ChristInSongHymn.Song_71.GetUsedTimes();
                case 72:
                    ChristInSongHymn.Song_72.incrementUsedTimes();
                    return ChristInSongHymn.Song_72.GetUsedTimes();
                case 73:
                    ChristInSongHymn.Song_73.incrementUsedTimes();
                    return ChristInSongHymn.Song_73.GetUsedTimes();
                case 74:
                    ChristInSongHymn.Song_74.incrementUsedTimes();
                    return ChristInSongHymn.Song_74.GetUsedTimes();
                case 75:
                    ChristInSongHymn.Song_75.incrementUsedTimes();
                    return ChristInSongHymn.Song_75.GetUsedTimes();
                case 76:
                    ChristInSongHymn.Song_76.incrementUsedTimes();
                    return ChristInSongHymn.Song_76.GetUsedTimes();
                case 77:
                    ChristInSongHymn.Song_77.incrementUsedTimes();
                    return ChristInSongHymn.Song_77.GetUsedTimes();
                case 78:
                    ChristInSongHymn.Song_78.incrementUsedTimes();
                    return ChristInSongHymn.Song_78.GetUsedTimes();
                case 79:
                    ChristInSongHymn.Song_79.incrementUsedTimes();
                    return ChristInSongHymn.Song_79.GetUsedTimes();
                case 80:
                    ChristInSongHymn.Song_80.incrementUsedTimes();
                    return ChristInSongHymn.Song_80.GetUsedTimes();
                case 81:
                    ChristInSongHymn.Song_81.incrementUsedTimes();
                    return ChristInSongHymn.Song_81.GetUsedTimes();
                case 82:
                    ChristInSongHymn.Song_82.incrementUsedTimes();
                    return ChristInSongHymn.Song_82.GetUsedTimes();
                case 83:
                    ChristInSongHymn.Song_83.incrementUsedTimes();
                    return ChristInSongHymn.Song_83.GetUsedTimes();
                case 84:
                    ChristInSongHymn.Song_84.incrementUsedTimes();
                    return ChristInSongHymn.Song_84.GetUsedTimes();
                case 85:
                    ChristInSongHymn.Song_85.incrementUsedTimes();
                    return ChristInSongHymn.Song_85.GetUsedTimes();
                case 86:
                    ChristInSongHymn.Song_86.incrementUsedTimes();
                    return ChristInSongHymn.Song_86.GetUsedTimes();
                case 87:
                    ChristInSongHymn.Song_87.incrementUsedTimes();
                    return ChristInSongHymn.Song_87.GetUsedTimes();
                case 88:
                    ChristInSongHymn.Song_88.incrementUsedTimes();
                    return ChristInSongHymn.Song_88.GetUsedTimes();
                case 89:
                    ChristInSongHymn.Song_89.incrementUsedTimes();
                    return ChristInSongHymn.Song_89.GetUsedTimes();
                case 90:
                    ChristInSongHymn.Song_90.incrementUsedTimes();
                    return ChristInSongHymn.Song_90.GetUsedTimes();
                case 91:
                    ChristInSongHymn.Song_91.incrementUsedTimes();
                    return ChristInSongHymn.Song_91.GetUsedTimes();
                case 92:
                    ChristInSongHymn.Song_92.incrementUsedTimes();
                    return ChristInSongHymn.Song_92.GetUsedTimes();
                case 93:
                    ChristInSongHymn.Song_93.incrementUsedTimes();
                    return ChristInSongHymn.Song_93.GetUsedTimes();
                case 94:
                    ChristInSongHymn.Song_94.incrementUsedTimes();
                    return ChristInSongHymn.Song_94.GetUsedTimes();
                case 95:
                    ChristInSongHymn.Song_95.incrementUsedTimes();
                    return ChristInSongHymn.Song_95.GetUsedTimes();
                case 96:
                    ChristInSongHymn.Song_96.incrementUsedTimes();
                    return ChristInSongHymn.Song_96.GetUsedTimes();
                case 97:
                    ChristInSongHymn.Song_97.incrementUsedTimes();
                    return ChristInSongHymn.Song_97.GetUsedTimes();
                case 98:
                    ChristInSongHymn.Song_98.incrementUsedTimes();
                    return ChristInSongHymn.Song_98.GetUsedTimes();
                case 99:
                    ChristInSongHymn.Song_99.incrementUsedTimes();
                    return ChristInSongHymn.Song_99.GetUsedTimes();
                case 100:
                    ChristInSongHymn.Song_100.incrementUsedTimes();
                    return ChristInSongHymn.Song_100.GetUsedTimes();
                case 101:
                    ChristInSongHymn.Song_101.incrementUsedTimes();
                    return ChristInSongHymn.Song_101.GetUsedTimes();
                case 102:
                    ChristInSongHymn.Song_102.incrementUsedTimes();
                    return ChristInSongHymn.Song_102.GetUsedTimes();
                case 103:
                    ChristInSongHymn.Song_103.incrementUsedTimes();
                    return ChristInSongHymn.Song_103.GetUsedTimes();
                case 104:
                    ChristInSongHymn.Song_104.incrementUsedTimes();
                    return ChristInSongHymn.Song_104.GetUsedTimes();
                case 105:
                    ChristInSongHymn.Song_105.incrementUsedTimes();
                    return ChristInSongHymn.Song_105.GetUsedTimes();
                case 106:
                    ChristInSongHymn.Song_106.incrementUsedTimes();
                    return ChristInSongHymn.Song_106.GetUsedTimes();
                case 107:
                    ChristInSongHymn.Song_107.incrementUsedTimes();
                    return ChristInSongHymn.Song_107.GetUsedTimes();
                case 108:
                    ChristInSongHymn.Song_108.incrementUsedTimes();
                    return ChristInSongHymn.Song_108.GetUsedTimes();
                case 109:
                    ChristInSongHymn.Song_109.incrementUsedTimes();
                    return ChristInSongHymn.Song_109.GetUsedTimes();
                case 110:
                    ChristInSongHymn.Song_110.incrementUsedTimes();
                    return ChristInSongHymn.Song_110.GetUsedTimes();
                case 111:
                    ChristInSongHymn.Song_111.incrementUsedTimes();
                    return ChristInSongHymn.Song_111.GetUsedTimes();
                case 112:
                    ChristInSongHymn.Song_112.incrementUsedTimes();
                    return ChristInSongHymn.Song_112.GetUsedTimes();
                case 113:
                    ChristInSongHymn.Song_113.incrementUsedTimes();
                    return ChristInSongHymn.Song_113.GetUsedTimes();
                case 114:
                    ChristInSongHymn.Song_114.incrementUsedTimes();
                    return ChristInSongHymn.Song_114.GetUsedTimes();
                case 115:
                    ChristInSongHymn.Song_115.incrementUsedTimes();
                    return ChristInSongHymn.Song_115.GetUsedTimes();
                case 116:
                    ChristInSongHymn.Song_116.incrementUsedTimes();
                    return ChristInSongHymn.Song_116.GetUsedTimes();
                case 117:
                    ChristInSongHymn.Song_117.incrementUsedTimes();
                    return ChristInSongHymn.Song_117.GetUsedTimes();
                case 118:
                    ChristInSongHymn.Song_118.incrementUsedTimes();
                    return ChristInSongHymn.Song_118.GetUsedTimes();
                case 119:
                    ChristInSongHymn.Song_119.incrementUsedTimes();
                    return ChristInSongHymn.Song_119.GetUsedTimes();
                case 120:
                    ChristInSongHymn.Song_120.incrementUsedTimes();
                    return ChristInSongHymn.Song_120.GetUsedTimes();
                case 121:
                    ChristInSongHymn.Song_121.incrementUsedTimes();
                    return ChristInSongHymn.Song_121.GetUsedTimes();
                case 122:
                    ChristInSongHymn.Song_122.incrementUsedTimes();
                    return ChristInSongHymn.Song_122.GetUsedTimes();
                case 123:
                    ChristInSongHymn.Song_123.incrementUsedTimes();
                    return ChristInSongHymn.Song_123.GetUsedTimes();
                case 124:
                    ChristInSongHymn.Song_124.incrementUsedTimes();
                    return ChristInSongHymn.Song_124.GetUsedTimes();
                case 125:
                    ChristInSongHymn.Song_125.incrementUsedTimes();
                    return ChristInSongHymn.Song_125.GetUsedTimes();
                case 126:
                    ChristInSongHymn.Song_126.incrementUsedTimes();
                    return ChristInSongHymn.Song_126.GetUsedTimes();
                case 127:
                    ChristInSongHymn.Song_127.incrementUsedTimes();
                    return ChristInSongHymn.Song_127.GetUsedTimes();
                case 128:
                    ChristInSongHymn.Song_128.incrementUsedTimes();
                    return ChristInSongHymn.Song_128.GetUsedTimes();
                case 129:
                    ChristInSongHymn.Song_129.incrementUsedTimes();
                    return ChristInSongHymn.Song_129.GetUsedTimes();
                case 130:
                    ChristInSongHymn.Song_130.incrementUsedTimes();
                    return ChristInSongHymn.Song_130.GetUsedTimes();
                case 131:
                    ChristInSongHymn.Song_131.incrementUsedTimes();
                    return ChristInSongHymn.Song_131.GetUsedTimes();
                case 132:
                    ChristInSongHymn.Song_132.incrementUsedTimes();
                    return ChristInSongHymn.Song_132.GetUsedTimes();
                case 133:
                    ChristInSongHymn.Song_133.incrementUsedTimes();
                    return ChristInSongHymn.Song_133.GetUsedTimes();
                case 134:
                    ChristInSongHymn.Song_134.incrementUsedTimes();
                    return ChristInSongHymn.Song_134.GetUsedTimes();
                case 135:
                    ChristInSongHymn.Song_135.incrementUsedTimes();
                    return ChristInSongHymn.Song_135.GetUsedTimes();
                case 136:
                    ChristInSongHymn.Song_136.incrementUsedTimes();
                    return ChristInSongHymn.Song_136.GetUsedTimes();
                case 137:
                    ChristInSongHymn.Song_137.incrementUsedTimes();
                    return ChristInSongHymn.Song_137.GetUsedTimes();
                case 138:
                    ChristInSongHymn.Song_138.incrementUsedTimes();
                    return ChristInSongHymn.Song_138.GetUsedTimes();
                case 139:
                    ChristInSongHymn.Song_139.incrementUsedTimes();
                    return ChristInSongHymn.Song_139.GetUsedTimes();
                case 140:
                    ChristInSongHymn.Song_140.incrementUsedTimes();
                    return ChristInSongHymn.Song_140.GetUsedTimes();
                case 141:
                    ChristInSongHymn.Song_141.incrementUsedTimes();
                    return ChristInSongHymn.Song_141.GetUsedTimes();
                case 142:
                    ChristInSongHymn.Song_142.incrementUsedTimes();
                    return ChristInSongHymn.Song_142.GetUsedTimes();
                case 143:
                    ChristInSongHymn.Song_143.incrementUsedTimes();
                    return ChristInSongHymn.Song_143.GetUsedTimes();
                case 144:
                    ChristInSongHymn.Song_144.incrementUsedTimes();
                    return ChristInSongHymn.Song_144.GetUsedTimes();
                case 145:
                    ChristInSongHymn.Song_145.incrementUsedTimes();
                    return ChristInSongHymn.Song_145.GetUsedTimes();
                case 146:
                    ChristInSongHymn.Song_146.incrementUsedTimes();
                    return ChristInSongHymn.Song_146.GetUsedTimes();
                case 147:
                    ChristInSongHymn.Song_147.incrementUsedTimes();
                    return ChristInSongHymn.Song_147.GetUsedTimes();
                case 148:
                    ChristInSongHymn.Song_148.incrementUsedTimes();
                    return ChristInSongHymn.Song_148.GetUsedTimes();
                case 149:
                    ChristInSongHymn.Song_149.incrementUsedTimes();
                    return ChristInSongHymn.Song_149.GetUsedTimes();
                case 150:
                    ChristInSongHymn.Song_150.incrementUsedTimes();
                    return ChristInSongHymn.Song_150.GetUsedTimes();
                case 151:
                    ChristInSongHymn.Song_151.incrementUsedTimes();
                    return ChristInSongHymn.Song_151.GetUsedTimes();
                case 152:
                    ChristInSongHymn.Song_152.incrementUsedTimes();
                    return ChristInSongHymn.Song_152.GetUsedTimes();
                case 153:
                    ChristInSongHymn.Song_153.incrementUsedTimes();
                    return ChristInSongHymn.Song_153.GetUsedTimes();
                case 154:
                    ChristInSongHymn.Song_154.incrementUsedTimes();
                    return ChristInSongHymn.Song_154.GetUsedTimes();
                case 155:
                    ChristInSongHymn.Song_155.incrementUsedTimes();
                    return ChristInSongHymn.Song_155.GetUsedTimes();
                case 156:
                    ChristInSongHymn.Song_156.incrementUsedTimes();
                    return ChristInSongHymn.Song_156.GetUsedTimes();
                case 157:
                    ChristInSongHymn.Song_157.incrementUsedTimes();
                    return ChristInSongHymn.Song_157.GetUsedTimes();
                case 158:
                    ChristInSongHymn.Song_158.incrementUsedTimes();
                    return ChristInSongHymn.Song_158.GetUsedTimes();
                case 159:
                    ChristInSongHymn.Song_159.incrementUsedTimes();
                    return ChristInSongHymn.Song_159.GetUsedTimes();
                case 160:
                    ChristInSongHymn.Song_160.incrementUsedTimes();
                    return ChristInSongHymn.Song_160.GetUsedTimes();
                case 161:
                    ChristInSongHymn.Song_161.incrementUsedTimes();
                    return ChristInSongHymn.Song_161.GetUsedTimes();
                case 162:
                    ChristInSongHymn.Song_162.incrementUsedTimes();
                    return ChristInSongHymn.Song_162.GetUsedTimes();
                case 163:
                    ChristInSongHymn.Song_163.incrementUsedTimes();
                    return ChristInSongHymn.Song_163.GetUsedTimes();
                case 164:
                    ChristInSongHymn.Song_164.incrementUsedTimes();
                    return ChristInSongHymn.Song_164.GetUsedTimes();
                case 165:
                    ChristInSongHymn.Song_165.incrementUsedTimes();
                    return ChristInSongHymn.Song_165.GetUsedTimes();
                case 166:
                    ChristInSongHymn.Song_166.incrementUsedTimes();
                    return ChristInSongHymn.Song_166.GetUsedTimes();
                case 167:
                    ChristInSongHymn.Song_167.incrementUsedTimes();
                    return ChristInSongHymn.Song_167.GetUsedTimes();
                case 168:
                    ChristInSongHymn.Song_168.incrementUsedTimes();
                    return ChristInSongHymn.Song_168.GetUsedTimes();
                case 169:
                    ChristInSongHymn.Song_169.incrementUsedTimes();
                    return ChristInSongHymn.Song_169.GetUsedTimes();
                case 170:
                    ChristInSongHymn.Song_170.incrementUsedTimes();
                    return ChristInSongHymn.Song_170.GetUsedTimes();
                case 171:
                    ChristInSongHymn.Song_171.incrementUsedTimes();
                    return ChristInSongHymn.Song_171.GetUsedTimes();
                case 172:
                    ChristInSongHymn.Song_172.incrementUsedTimes();
                    return ChristInSongHymn.Song_172.GetUsedTimes();
                case 173:
                    ChristInSongHymn.Song_173.incrementUsedTimes();
                    return ChristInSongHymn.Song_173.GetUsedTimes();
                case 174:
                    ChristInSongHymn.Song_174.incrementUsedTimes();
                    return ChristInSongHymn.Song_174.GetUsedTimes();
                case 175:
                    ChristInSongHymn.Song_175.incrementUsedTimes();
                    return ChristInSongHymn.Song_175.GetUsedTimes();
                case 176:
                    ChristInSongHymn.Song_176.incrementUsedTimes();
                    return ChristInSongHymn.Song_176.GetUsedTimes();
                case 177:
                    ChristInSongHymn.Song_177.incrementUsedTimes();
                    return ChristInSongHymn.Song_177.GetUsedTimes();
                case 178:
                    ChristInSongHymn.Song_178.incrementUsedTimes();
                    return ChristInSongHymn.Song_178.GetUsedTimes();
                case 179:
                    ChristInSongHymn.Song_179.incrementUsedTimes();
                    return ChristInSongHymn.Song_179.GetUsedTimes();
                case 180:
                    ChristInSongHymn.Song_180.incrementUsedTimes();
                    return ChristInSongHymn.Song_180.GetUsedTimes();
                case 181:
                    ChristInSongHymn.Song_181.incrementUsedTimes();
                    return ChristInSongHymn.Song_181.GetUsedTimes();
                case 182:
                    ChristInSongHymn.Song_182.incrementUsedTimes();
                    return ChristInSongHymn.Song_182.GetUsedTimes();
                case 183:
                    ChristInSongHymn.Song_183.incrementUsedTimes();
                    return ChristInSongHymn.Song_183.GetUsedTimes();
                case 184:
                    ChristInSongHymn.Song_184.incrementUsedTimes();
                    return ChristInSongHymn.Song_184.GetUsedTimes();
                case 185:
                    ChristInSongHymn.Song_185.incrementUsedTimes();
                    return ChristInSongHymn.Song_185.GetUsedTimes();
                case 186:
                    ChristInSongHymn.Song_186.incrementUsedTimes();
                    return ChristInSongHymn.Song_186.GetUsedTimes();
                case 187:
                    ChristInSongHymn.Song_187.incrementUsedTimes();
                    return ChristInSongHymn.Song_187.GetUsedTimes();
                case 188:
                    ChristInSongHymn.Song_188.incrementUsedTimes();
                    return ChristInSongHymn.Song_188.GetUsedTimes();
                case 189:
                    ChristInSongHymn.Song_189.incrementUsedTimes();
                    return ChristInSongHymn.Song_189.GetUsedTimes();
                case 190:
                    ChristInSongHymn.Song_190.incrementUsedTimes();
                    return ChristInSongHymn.Song_190.GetUsedTimes();
                case 191:
                    ChristInSongHymn.Song_191.incrementUsedTimes();
                    return ChristInSongHymn.Song_191.GetUsedTimes();
                case 192:
                    ChristInSongHymn.Song_192.incrementUsedTimes();
                    return ChristInSongHymn.Song_192.GetUsedTimes();
                case 193:
                    ChristInSongHymn.Song_193.incrementUsedTimes();
                    return ChristInSongHymn.Song_193.GetUsedTimes();
                case 194:
                    ChristInSongHymn.Song_194.incrementUsedTimes();
                    return ChristInSongHymn.Song_194.GetUsedTimes();
                case 195:
                    ChristInSongHymn.Song_195.incrementUsedTimes();
                    return ChristInSongHymn.Song_195.GetUsedTimes();
                case 196:
                    ChristInSongHymn.Song_196.incrementUsedTimes();
                    return ChristInSongHymn.Song_196.GetUsedTimes();
                case 197:
                    ChristInSongHymn.Song_197.incrementUsedTimes();
                    return ChristInSongHymn.Song_197.GetUsedTimes();
                case 198:
                    ChristInSongHymn.Song_198.incrementUsedTimes();
                    return ChristInSongHymn.Song_198.GetUsedTimes();
                case 199:
                    ChristInSongHymn.Song_199.incrementUsedTimes();
                    return ChristInSongHymn.Song_199.GetUsedTimes();
                case 200:
                    ChristInSongHymn.Song_200.incrementUsedTimes();
                    return ChristInSongHymn.Song_200.GetUsedTimes();
                case 201:
                    ChristInSongHymn.Song_201.incrementUsedTimes();
                    return ChristInSongHymn.Song_201.GetUsedTimes();
                case 202:
                    ChristInSongHymn.Song_202.incrementUsedTimes();
                    return ChristInSongHymn.Song_202.GetUsedTimes();
                case 203:
                    ChristInSongHymn.Song_203.incrementUsedTimes();
                    return ChristInSongHymn.Song_203.GetUsedTimes();
                case 204:
                    ChristInSongHymn.Song_204.incrementUsedTimes();
                    return ChristInSongHymn.Song_204.GetUsedTimes();
                case 205:
                    ChristInSongHymn.Song_205.incrementUsedTimes();
                    return ChristInSongHymn.Song_205.GetUsedTimes();
                case 206:
                    ChristInSongHymn.Song_206.incrementUsedTimes();
                    return ChristInSongHymn.Song_206.GetUsedTimes();
                case 207:
                    ChristInSongHymn.Song_207.incrementUsedTimes();
                    return ChristInSongHymn.Song_207.GetUsedTimes();
                case 208:
                    ChristInSongHymn.Song_208.incrementUsedTimes();
                    return ChristInSongHymn.Song_208.GetUsedTimes();
                case 209:
                    ChristInSongHymn.Song_209.incrementUsedTimes();
                    return ChristInSongHymn.Song_209.GetUsedTimes();
                case 210:
                    ChristInSongHymn.Song_210.incrementUsedTimes();
                    return ChristInSongHymn.Song_210.GetUsedTimes();
                case 211:
                    ChristInSongHymn.Song_211.incrementUsedTimes();
                    return ChristInSongHymn.Song_211.GetUsedTimes();
                case 212:
                    ChristInSongHymn.Song_212.incrementUsedTimes();
                    return ChristInSongHymn.Song_212.GetUsedTimes();
                case 213:
                    ChristInSongHymn.Song_213.incrementUsedTimes();
                    return ChristInSongHymn.Song_213.GetUsedTimes();
                case 214:
                    ChristInSongHymn.Song_214.incrementUsedTimes();
                    return ChristInSongHymn.Song_214.GetUsedTimes();
                case 215:
                    ChristInSongHymn.Song_215.incrementUsedTimes();
                    return ChristInSongHymn.Song_215.GetUsedTimes();
                case 216:
                    ChristInSongHymn.Song_216.incrementUsedTimes();
                    return ChristInSongHymn.Song_216.GetUsedTimes();
                case 217:
                    ChristInSongHymn.Song_217.incrementUsedTimes();
                    return ChristInSongHymn.Song_217.GetUsedTimes();
                case 218:
                    ChristInSongHymn.Song_218.incrementUsedTimes();
                    return ChristInSongHymn.Song_218.GetUsedTimes();
                case 219:
                    ChristInSongHymn.Song_219.incrementUsedTimes();
                    return ChristInSongHymn.Song_219.GetUsedTimes();
                case 220:
                    ChristInSongHymn.Song_220.incrementUsedTimes();
                    return ChristInSongHymn.Song_220.GetUsedTimes();
                case 221:
                    ChristInSongHymn.Song_221.incrementUsedTimes();
                    return ChristInSongHymn.Song_221.GetUsedTimes();
                case 222:
                    ChristInSongHymn.Song_222.incrementUsedTimes();
                    return ChristInSongHymn.Song_222.GetUsedTimes();
                case 223:
                    ChristInSongHymn.Song_223.incrementUsedTimes();
                    return ChristInSongHymn.Song_223.GetUsedTimes();
                case 224:
                    ChristInSongHymn.Song_224.incrementUsedTimes();
                    return ChristInSongHymn.Song_224.GetUsedTimes();
                case 225:
                    ChristInSongHymn.Song_225.incrementUsedTimes();
                    return ChristInSongHymn.Song_225.GetUsedTimes();
                case 226:
                    ChristInSongHymn.Song_226.incrementUsedTimes();
                    return ChristInSongHymn.Song_226.GetUsedTimes();
                case 227:
                    ChristInSongHymn.Song_227.incrementUsedTimes();
                    return ChristInSongHymn.Song_227.GetUsedTimes();
                case 228:
                    ChristInSongHymn.Song_228.incrementUsedTimes();
                    return ChristInSongHymn.Song_228.GetUsedTimes();
                case 229:
                    ChristInSongHymn.Song_229.incrementUsedTimes();
                    return ChristInSongHymn.Song_229.GetUsedTimes();
                case 230:
                    ChristInSongHymn.Song_230.incrementUsedTimes();
                    return ChristInSongHymn.Song_230.GetUsedTimes();
                case 231:
                    ChristInSongHymn.Song_231.incrementUsedTimes();
                    return ChristInSongHymn.Song_231.GetUsedTimes();
                case 232:
                    ChristInSongHymn.Song_232.incrementUsedTimes();
                    return ChristInSongHymn.Song_232.GetUsedTimes();
                case 233:
                    ChristInSongHymn.Song_233.incrementUsedTimes();
                    return ChristInSongHymn.Song_233.GetUsedTimes();
                case 234:
                    ChristInSongHymn.Song_234.incrementUsedTimes();
                    return ChristInSongHymn.Song_234.GetUsedTimes();
                case 235:
                    ChristInSongHymn.Song_235.incrementUsedTimes();
                    return ChristInSongHymn.Song_235.GetUsedTimes();
                case 236:
                    ChristInSongHymn.Song_236.incrementUsedTimes();
                    return ChristInSongHymn.Song_236.GetUsedTimes();
                case 237:
                    ChristInSongHymn.Song_237.incrementUsedTimes();
                    return ChristInSongHymn.Song_237.GetUsedTimes();
                case 238:
                    ChristInSongHymn.Song_238.incrementUsedTimes();
                    return ChristInSongHymn.Song_238.GetUsedTimes();
                case 239:
                    ChristInSongHymn.Song_239.incrementUsedTimes();
                    return ChristInSongHymn.Song_239.GetUsedTimes();
                case 240:
                    ChristInSongHymn.Song_240.incrementUsedTimes();
                    return ChristInSongHymn.Song_240.GetUsedTimes();
                case 241:
                    ChristInSongHymn.Song_241.incrementUsedTimes();
                    return ChristInSongHymn.Song_241.GetUsedTimes();
                case 242:
                    ChristInSongHymn.Song_242.incrementUsedTimes();
                    return ChristInSongHymn.Song_242.GetUsedTimes();
                case 243:
                    ChristInSongHymn.Song_243.incrementUsedTimes();
                    return ChristInSongHymn.Song_243.GetUsedTimes();
                case 244:
                    ChristInSongHymn.Song_244.incrementUsedTimes();
                    return ChristInSongHymn.Song_244.GetUsedTimes();
                case 245:
                    ChristInSongHymn.Song_245.incrementUsedTimes();
                    return ChristInSongHymn.Song_245.GetUsedTimes();
                case 246:
                    ChristInSongHymn.Song_246.incrementUsedTimes();
                    return ChristInSongHymn.Song_246.GetUsedTimes();
                case 247:
                    ChristInSongHymn.Song_247.incrementUsedTimes();
                    return ChristInSongHymn.Song_247.GetUsedTimes();
                case 248:
                    ChristInSongHymn.Song_248.incrementUsedTimes();
                    return ChristInSongHymn.Song_248.GetUsedTimes();
                case 249:
                    ChristInSongHymn.Song_249.incrementUsedTimes();
                    return ChristInSongHymn.Song_249.GetUsedTimes();
                case 250:
                    ChristInSongHymn.Song_250.incrementUsedTimes();
                    return ChristInSongHymn.Song_250.GetUsedTimes();
                case 251:
                    ChristInSongHymn.Song_251.incrementUsedTimes();
                    return ChristInSongHymn.Song_251.GetUsedTimes();
                case 252:
                    ChristInSongHymn.Song_252.incrementUsedTimes();
                    return ChristInSongHymn.Song_252.GetUsedTimes();
                case 253:
                    ChristInSongHymn.Song_253.incrementUsedTimes();
                    return ChristInSongHymn.Song_253.GetUsedTimes();
                case 254:
                    ChristInSongHymn.Song_254.incrementUsedTimes();
                    return ChristInSongHymn.Song_254.GetUsedTimes();
                case 255:
                    ChristInSongHymn.Song_255.incrementUsedTimes();
                    return ChristInSongHymn.Song_255.GetUsedTimes();
                case 256:
                    ChristInSongHymn.Song_256.incrementUsedTimes();
                    return ChristInSongHymn.Song_256.GetUsedTimes();
                case 257:
                    ChristInSongHymn.Song_257.incrementUsedTimes();
                    return ChristInSongHymn.Song_257.GetUsedTimes();
                case 258:
                    ChristInSongHymn.Song_258.incrementUsedTimes();
                    return ChristInSongHymn.Song_258.GetUsedTimes();
                case 259:
                    ChristInSongHymn.Song_259.incrementUsedTimes();
                    return ChristInSongHymn.Song_259.GetUsedTimes();
                case 260:
                    ChristInSongHymn.Song_260.incrementUsedTimes();
                    return ChristInSongHymn.Song_260.GetUsedTimes();
                case 261:
                    ChristInSongHymn.Song_261.incrementUsedTimes();
                    return ChristInSongHymn.Song_261.GetUsedTimes();
                case 262:
                    ChristInSongHymn.Song_262.incrementUsedTimes();
                    return ChristInSongHymn.Song_262.GetUsedTimes();
                case 263:
                    ChristInSongHymn.Song_263.incrementUsedTimes();
                    return ChristInSongHymn.Song_263.GetUsedTimes();
                case 264:
                    ChristInSongHymn.Song_264.incrementUsedTimes();
                    return ChristInSongHymn.Song_264.GetUsedTimes();
                case 265:
                    ChristInSongHymn.Song_265.incrementUsedTimes();
                    return ChristInSongHymn.Song_265.GetUsedTimes();
                case 266:
                    ChristInSongHymn.Song_266.incrementUsedTimes();
                    return ChristInSongHymn.Song_266.GetUsedTimes();
                case 267:
                    ChristInSongHymn.Song_267.incrementUsedTimes();
                    return ChristInSongHymn.Song_267.GetUsedTimes();
                case 268:
                    ChristInSongHymn.Song_268.incrementUsedTimes();
                    return ChristInSongHymn.Song_268.GetUsedTimes();
                case 269:
                    ChristInSongHymn.Song_269.incrementUsedTimes();
                    return ChristInSongHymn.Song_269.GetUsedTimes();
                case 270:
                    ChristInSongHymn.Song_270.incrementUsedTimes();
                    return ChristInSongHymn.Song_270.GetUsedTimes();
                case 271:
                    ChristInSongHymn.Song_271.incrementUsedTimes();
                    return ChristInSongHymn.Song_271.GetUsedTimes();
                case 272:
                    ChristInSongHymn.Song_272.incrementUsedTimes();
                    return ChristInSongHymn.Song_272.GetUsedTimes();
                case 273:
                    ChristInSongHymn.Song_273.incrementUsedTimes();
                    return ChristInSongHymn.Song_273.GetUsedTimes();
                case 274:
                    ChristInSongHymn.Song_274.incrementUsedTimes();
                    return ChristInSongHymn.Song_274.GetUsedTimes();
                case 275:
                    ChristInSongHymn.Song_275.incrementUsedTimes();
                    return ChristInSongHymn.Song_275.GetUsedTimes();
                case 276:
                    ChristInSongHymn.Song_276.incrementUsedTimes();
                    return ChristInSongHymn.Song_276.GetUsedTimes();
                case 277:
                    ChristInSongHymn.Song_277.incrementUsedTimes();
                    return ChristInSongHymn.Song_277.GetUsedTimes();
                case 278:
                    ChristInSongHymn.Song_278.incrementUsedTimes();
                    return ChristInSongHymn.Song_278.GetUsedTimes();
                case 279:
                    ChristInSongHymn.Song_279.incrementUsedTimes();
                    return ChristInSongHymn.Song_279.GetUsedTimes();
                case 280:
                    ChristInSongHymn.Song_280.incrementUsedTimes();
                    return ChristInSongHymn.Song_280.GetUsedTimes();
                case 281:
                    ChristInSongHymn.Song_281.incrementUsedTimes();
                    return ChristInSongHymn.Song_281.GetUsedTimes();
                case 282:
                    ChristInSongHymn.Song_282.incrementUsedTimes();
                    return ChristInSongHymn.Song_282.GetUsedTimes();
                case 283:
                    ChristInSongHymn.Song_283.incrementUsedTimes();
                    return ChristInSongHymn.Song_283.GetUsedTimes();
                case 284:
                    ChristInSongHymn.Song_284.incrementUsedTimes();
                    return ChristInSongHymn.Song_284.GetUsedTimes();
                case 285:
                    ChristInSongHymn.Song_285.incrementUsedTimes();
                    return ChristInSongHymn.Song_285.GetUsedTimes();
                case 286:
                    ChristInSongHymn.Song_286.incrementUsedTimes();
                    return ChristInSongHymn.Song_286.GetUsedTimes();
                case 287:
                    ChristInSongHymn.Song_287.incrementUsedTimes();
                    return ChristInSongHymn.Song_287.GetUsedTimes();
                case 288:
                    ChristInSongHymn.Song_288.incrementUsedTimes();
                    return ChristInSongHymn.Song_288.GetUsedTimes();
                case 289:
                    ChristInSongHymn.Song_289.incrementUsedTimes();
                    return ChristInSongHymn.Song_289.GetUsedTimes();
                case 290:
                    ChristInSongHymn.Song_290.incrementUsedTimes();
                    return ChristInSongHymn.Song_290.GetUsedTimes();
                case 291:
                    ChristInSongHymn.Song_291.incrementUsedTimes();
                    return ChristInSongHymn.Song_291.GetUsedTimes();
                case 292:
                    ChristInSongHymn.Song_292.incrementUsedTimes();
                    return ChristInSongHymn.Song_292.GetUsedTimes();
                case 293:
                    ChristInSongHymn.Song_293.incrementUsedTimes();
                    return ChristInSongHymn.Song_293.GetUsedTimes();
                case 294:
                    ChristInSongHymn.Song_294.incrementUsedTimes();
                    return ChristInSongHymn.Song_294.GetUsedTimes();
                case 295:
                    ChristInSongHymn.Song_295.incrementUsedTimes();
                    return ChristInSongHymn.Song_295.GetUsedTimes();
                case 296:
                    ChristInSongHymn.Song_296.incrementUsedTimes();
                    return ChristInSongHymn.Song_296.GetUsedTimes();
                case 297:
                    ChristInSongHymn.Song_297.incrementUsedTimes();
                    return ChristInSongHymn.Song_297.GetUsedTimes();
                case 298:
                    ChristInSongHymn.Song_298.incrementUsedTimes();
                    return ChristInSongHymn.Song_298.GetUsedTimes();
                case 299:
                    ChristInSongHymn.Song_299.incrementUsedTimes();
                    return ChristInSongHymn.Song_299.GetUsedTimes();
                case 300:
                    ChristInSongHymn.Song_300.incrementUsedTimes();
                    return ChristInSongHymn.Song_300.GetUsedTimes();
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
        public static List<string> GetSong(string songNumber)
        {
            // make an int copy the song number 
            var songNum = Convert.ToInt32(songNumber);
            //look for the song number
            switch (songNum)
            {
                case 1:
                    return ChristInSongHymn.Song_1.SongDetails();
                case 2:
                    return ChristInSongHymn.Song_2.songDetails();
                case 3:
                    return ChristInSongHymn.Song_3.songDetails();
                case 4:
                    return ChristInSongHymn.Song_4.songDetails();
                case 5:
                    return ChristInSongHymn.Song_5.songDetails();
                case 6:
                    return ChristInSongHymn.Song_6.songDetails();
                case 7:
                    return ChristInSongHymn.Song_7.songDetails();
                case 8:
                    return ChristInSongHymn.Song_8.songDetails();
                case 9:
                    return ChristInSongHymn.Song_9.songDetails();
                case 10:
                    return ChristInSongHymn.Song_10.songDetails();
                case 11:
                    return ChristInSongHymn.Song_11.songDetails();
                case 12:
                    return ChristInSongHymn.Song_12.songDetails();
                case 13:
                    return ChristInSongHymn.Song_13.songDetails();
                case 14:
                    return ChristInSongHymn.Song_14.songDetails();
                case 15:
                    return ChristInSongHymn.Song_15.songDetails();
                case 16:
                    return ChristInSongHymn.Song_16.songDetails();
                case 17:
                    return ChristInSongHymn.Song_17.songDetails();
                case 18:
                    return ChristInSongHymn.Song_18.songDetails();
                case 19:
                    return ChristInSongHymn.Song_19.songDetails();
                case 20:
                    return ChristInSongHymn.Song_20.songDetails();
                case 21:
                    return ChristInSongHymn.Song_21.songDetails();
                case 22:
                    return ChristInSongHymn.Song_22.songDetails();
                case 23:
                    return ChristInSongHymn.Song_23.songDetails();
                case 24:
                    return ChristInSongHymn.Song_24.songDetails();
                case 25:
                    return ChristInSongHymn.Song_25.songDetails();
                case 26:
                    return ChristInSongHymn.Song_26.songDetails();
                case 27:
                    return ChristInSongHymn.Song_27.songDetails();
                case 28:
                    return ChristInSongHymn.Song_28.songDetails();
                case 29:
                    return ChristInSongHymn.Song_29.songDetails();
                case 30:
                    return ChristInSongHymn.Song_30.songDetails();
                case 31:
                    return ChristInSongHymn.Song_31.songDetails();
                case 32:
                    return ChristInSongHymn.Song_32.songDetails();
                case 33:
                    return ChristInSongHymn.Song_33.songDetails();
                case 34:
                    return ChristInSongHymn.Song_34.songDetails();
                case 35:
                    return ChristInSongHymn.Song_35.songDetails();
                case 36:
                    return ChristInSongHymn.Song_36.songDetails();
                case 37:
                    return ChristInSongHymn.Song_37.songDetails();
                case 38:
                    return ChristInSongHymn.Song_38.songDetails();
                case 39:
                    return ChristInSongHymn.Song_39.songDetails();
                case 40:
                    return ChristInSongHymn.Song_40.songDetails();
                case 41:
                    return ChristInSongHymn.Song_41.songDetails();
                case 42:
                    return ChristInSongHymn.Song_42.songDetails();
                case 43:
                    return ChristInSongHymn.Song_43.songDetails();
                case 44:
                    return ChristInSongHymn.Song_44.songDetails();
                case 45:
                    return ChristInSongHymn.Song_45.songDetails();
                case 46:
                    return ChristInSongHymn.Song_46.songDetails();
                case 47:
                    return ChristInSongHymn.Song_47.songDetails();
                case 48:
                    return ChristInSongHymn.Song_48.songDetails();
                case 49:
                    return ChristInSongHymn.Song_49.songDetails();
                case 50:
                    return ChristInSongHymn.Song_50.songDetails();
                case 51:
                    return ChristInSongHymn.Song_51.songDetails();
                case 52:
                    return ChristInSongHymn.Song_52.songDetails();
                case 53:
                    return ChristInSongHymn.Song_53.songDetails();
                case 54:
                    return ChristInSongHymn.Song_54.songDetails();
                case 55:
                    return ChristInSongHymn.Song_55.songDetails();
                case 56:
                    return ChristInSongHymn.Song_56.songDetails();
                case 57:
                    return ChristInSongHymn.Song_57.songDetails();
                case 58:
                    return ChristInSongHymn.Song_58.songDetails();
                case 59:
                    return ChristInSongHymn.Song_59.songDetails();
                case 60:
                    return ChristInSongHymn.Song_60.songDetails();
                case 61:
                    return ChristInSongHymn.Song_61.songDetails();
                case 62:
                    return ChristInSongHymn.Song_62.songDetails();
                case 63:
                    return ChristInSongHymn.Song_63.songDetails();
                case 64:
                    return ChristInSongHymn.Song_64.songDetails();
                case 65:
                    return ChristInSongHymn.Song_65.songDetails();
                case 66:
                    return ChristInSongHymn.Song_66.songDetails();
                case 67:
                    return ChristInSongHymn.Song_67.songDetails();
                case 68:
                    return ChristInSongHymn.Song_68.songDetails();
                case 69:
                    return ChristInSongHymn.Song_69.songDetails();
                case 70:
                    return ChristInSongHymn.Song_70.songDetails();
                case 71:
                    return ChristInSongHymn.Song_71.songDetails();
                case 72:
                    return ChristInSongHymn.Song_72.songDetails();
                case 73:
                    return ChristInSongHymn.Song_73.songDetails();
                case 74:
                    return ChristInSongHymn.Song_74.songDetails();
                case 75:
                    return ChristInSongHymn.Song_75.songDetails();
                case 76:
                    return ChristInSongHymn.Song_76.songDetails();
                case 77:
                    return ChristInSongHymn.Song_77.songDetails();
                case 78:
                    return ChristInSongHymn.Song_78.songDetails();
                case 79:
                    return ChristInSongHymn.Song_79.songDetails();
                case 80:
                    return ChristInSongHymn.Song_80.songDetails();
                case 81:
                    return ChristInSongHymn.Song_81.songDetails();
                case 82:
                    return ChristInSongHymn.Song_82.songDetails();
                case 83:
                    return ChristInSongHymn.Song_83.songDetails();
                case 84:
                    return ChristInSongHymn.Song_84.songDetails();
                case 85:
                    return ChristInSongHymn.Song_85.songDetails();
                case 86:
                    return ChristInSongHymn.Song_86.songDetails();
                case 87:
                    return ChristInSongHymn.Song_87.songDetails();
                case 88:
                    return ChristInSongHymn.Song_88.songDetails();
                case 89:
                    return ChristInSongHymn.Song_89.songDetails();
                case 90:
                    return ChristInSongHymn.Song_90.songDetails();
                case 91:
                    return ChristInSongHymn.Song_91.songDetails();
                case 92:
                    return ChristInSongHymn.Song_92.songDetails();
                case 93:
                    return ChristInSongHymn.Song_93.songDetails();
                case 94:
                    return ChristInSongHymn.Song_94.songDetails();
                case 95:
                    return ChristInSongHymn.Song_95.songDetails();
                case 96:
                    return ChristInSongHymn.Song_96.songDetails();
                case 97:
                    return ChristInSongHymn.Song_97.songDetails();
                case 98:
                    return ChristInSongHymn.Song_98.songDetails();
                case 99:
                    return ChristInSongHymn.Song_99.songDetails();
                case 100:
                    return ChristInSongHymn.Song_100.songDetails();
                case 101:
                    return ChristInSongHymn.Song_101.songDetails();
                case 102:
                    return ChristInSongHymn.Song_102.songDetails();
                case 103:
                    return ChristInSongHymn.Song_103.songDetails();
                case 104:
                    return ChristInSongHymn.Song_104.songDetails();
                case 105:
                    return ChristInSongHymn.Song_105.songDetails();
                case 106:
                    return ChristInSongHymn.Song_106.songDetails();
                case 107:
                    return ChristInSongHymn.Song_107.songDetails();
                case 108:
                    return ChristInSongHymn.Song_108.songDetails();
                case 109:
                    return ChristInSongHymn.Song_109.songDetails();
                case 110:
                    return ChristInSongHymn.Song_110.songDetails();
                case 111:
                    return ChristInSongHymn.Song_111.songDetails();
                case 112:
                    return ChristInSongHymn.Song_112.songDetails();
                case 113:
                    return ChristInSongHymn.Song_113.songDetails();
                case 114:
                    return ChristInSongHymn.Song_114.songDetails();
                case 115:
                    return ChristInSongHymn.Song_115.songDetails();
                case 116:
                    return ChristInSongHymn.Song_116.songDetails();
                case 117:
                    return ChristInSongHymn.Song_117.songDetails();
                case 118:
                    return ChristInSongHymn.Song_118.songDetails();
                case 119:
                    return ChristInSongHymn.Song_119.songDetails();
                case 120:
                    return ChristInSongHymn.Song_120.songDetails();
                case 121:
                    return ChristInSongHymn.Song_121.songDetails();
                case 122:
                    return ChristInSongHymn.Song_122.songDetails();
                case 123:
                    return ChristInSongHymn.Song_123.songDetails();
                case 124:
                    return ChristInSongHymn.Song_124.songDetails();
                case 125:
                    return ChristInSongHymn.Song_125.songDetails();
                case 126:
                    return ChristInSongHymn.Song_126.songDetails();
                case 127:
                    return ChristInSongHymn.Song_127.songDetails();
                case 128:
                    return ChristInSongHymn.Song_128.songDetails();
                case 129:
                    return ChristInSongHymn.Song_129.songDetails();
                case 130:
                    return ChristInSongHymn.Song_130.songDetails();
                case 131:
                    return ChristInSongHymn.Song_131.songDetails();
                case 132:
                    return ChristInSongHymn.Song_132.songDetails();
                case 133:
                    return ChristInSongHymn.Song_133.songDetails();
                case 134:
                    return ChristInSongHymn.Song_134.songDetails();
                case 135:
                    return ChristInSongHymn.Song_135.songDetails();
                case 136:
                    return ChristInSongHymn.Song_136.songDetails();
                case 137:
                    return ChristInSongHymn.Song_137.songDetails();
                case 138:
                    return ChristInSongHymn.Song_138.songDetails();
                case 139:
                    return ChristInSongHymn.Song_139.songDetails();
                case 140:
                    return ChristInSongHymn.Song_140.songDetails();
                case 141:
                    return ChristInSongHymn.Song_141.songDetails();
                case 142:
                    return ChristInSongHymn.Song_142.songDetails();
                case 143:
                    return ChristInSongHymn.Song_143.songDetails();
                case 144:
                    return ChristInSongHymn.Song_144.songDetails();
                case 145:
                    return ChristInSongHymn.Song_145.songDetails();
                case 146:
                    return ChristInSongHymn.Song_146.songDetails();
                case 147:
                    return ChristInSongHymn.Song_147.songDetails();
                case 148:
                    return ChristInSongHymn.Song_148.songDetails();
                case 149:
                    return ChristInSongHymn.Song_149.songDetails();
                case 150:
                    return ChristInSongHymn.Song_150.songDetails();
                case 151:
                    return ChristInSongHymn.Song_151.songDetails();
                case 152:
                    return ChristInSongHymn.Song_152.songDetails();
                case 153:
                    return ChristInSongHymn.Song_153.songDetails();
                case 154:
                    return ChristInSongHymn.Song_154.songDetails();
                case 155:
                    return ChristInSongHymn.Song_155.songDetails();
                case 156:
                    return ChristInSongHymn.Song_156.songDetails();
                case 157:
                    return ChristInSongHymn.Song_157.songDetails();
                case 158:
                    return ChristInSongHymn.Song_158.songDetails();
                case 159:
                    return ChristInSongHymn.Song_159.songDetails();
                case 160:
                    return ChristInSongHymn.Song_160.songDetails();
                case 161:
                    return ChristInSongHymn.Song_161.songDetails();
                case 162:
                    return ChristInSongHymn.Song_162.songDetails();
                case 163:
                    return ChristInSongHymn.Song_163.songDetails();
                case 164:
                    return ChristInSongHymn.Song_164.songDetails();
                case 165:
                    return ChristInSongHymn.Song_165.songDetails();
                case 166:
                    return ChristInSongHymn.Song_166.songDetails();
                case 167:
                    return ChristInSongHymn.Song_167.songDetails();
                case 168:
                    return ChristInSongHymn.Song_168.songDetails();
                case 169:
                    return ChristInSongHymn.Song_169.songDetails();
                case 170:
                    return ChristInSongHymn.Song_170.songDetails();
                case 171:
                    return ChristInSongHymn.Song_171.songDetails();
                case 172:
                    return ChristInSongHymn.Song_172.songDetails();
                case 173:
                    return ChristInSongHymn.Song_173.songDetails();
                case 174:
                    return ChristInSongHymn.Song_174.songDetails();
                case 175:
                    return ChristInSongHymn.Song_175.songDetails();
                case 176:
                    return ChristInSongHymn.Song_176.songDetails();
                case 177:
                    return ChristInSongHymn.Song_177.songDetails();
                case 178:
                    return ChristInSongHymn.Song_178.songDetails();
                case 179:
                    return ChristInSongHymn.Song_179.songDetails();
                case 180:
                    return ChristInSongHymn.Song_180.songDetails();
                case 181:
                    return ChristInSongHymn.Song_181.songDetails();
                case 182:
                    return ChristInSongHymn.Song_182.songDetails();
                case 183:
                    return ChristInSongHymn.Song_183.songDetails();
                case 184:
                    return ChristInSongHymn.Song_184.songDetails();
                case 185:
                    return ChristInSongHymn.Song_185.songDetails();
                case 186:
                    return ChristInSongHymn.Song_186.songDetails();
                case 187:
                    return ChristInSongHymn.Song_187.songDetails();
                case 188:
                    return ChristInSongHymn.Song_188.songDetails();
                case 189:
                    return ChristInSongHymn.Song_189.songDetails();
                case 190:
                    return ChristInSongHymn.Song_190.songDetails();
                case 191:
                    return ChristInSongHymn.Song_191.songDetails();
                case 192:
                    return ChristInSongHymn.Song_192.songDetails();
                case 193:
                    return ChristInSongHymn.Song_193.songDetails();
                case 194:
                    return ChristInSongHymn.Song_194.songDetails();
                case 195:
                    return ChristInSongHymn.Song_195.songDetails();
                case 196:
                    return ChristInSongHymn.Song_196.songDetails();
                case 197:
                    return ChristInSongHymn.Song_197.songDetails();
                case 198:
                    return ChristInSongHymn.Song_198.songDetails();
                case 199:
                    return ChristInSongHymn.Song_199.songDetails();
                case 200:
                    return ChristInSongHymn.Song_200.songDetails();
                case 201:
                    return ChristInSongHymn.Song_201.songDetails();
                case 202:
                    return ChristInSongHymn.Song_202.songDetails();
                case 203:
                    return ChristInSongHymn.Song_203.songDetails();
                case 204:
                    return ChristInSongHymn.Song_204.songDetails();
                case 205:
                    return ChristInSongHymn.Song_205.songDetails();
                case 206:
                    return ChristInSongHymn.Song_206.songDetails();
                case 207:
                    return ChristInSongHymn.Song_207.songDetails();
                case 208:
                    return ChristInSongHymn.Song_208.songDetails();
                case 209:
                    return ChristInSongHymn.Song_209.songDetails();
                case 210:
                    return ChristInSongHymn.Song_210.songDetails();
                case 211:
                    return ChristInSongHymn.Song_211.songDetails();
                case 212:
                    return ChristInSongHymn.Song_212.songDetails();
                case 213:
                    return ChristInSongHymn.Song_213.songDetails();
                case 214:
                    return ChristInSongHymn.Song_214.songDetails();
                case 215:
                    return ChristInSongHymn.Song_215.songDetails();
                case 216:
                    return ChristInSongHymn.Song_216.songDetails();
                case 217:
                    return ChristInSongHymn.Song_217.songDetails();
                case 218:
                    return ChristInSongHymn.Song_218.songDetails();
                case 219:
                    return ChristInSongHymn.Song_219.songDetails();
                case 220:
                    return ChristInSongHymn.Song_220.songDetails();
                case 221:
                    return ChristInSongHymn.Song_221.songDetails();
                case 222:
                    return ChristInSongHymn.Song_222.songDetails();
                case 223:
                    return ChristInSongHymn.Song_223.songDetails();
                case 224:
                    return ChristInSongHymn.Song_224.songDetails();
                case 225:
                    return ChristInSongHymn.Song_225.songDetails();
                case 226:
                    return ChristInSongHymn.Song_226.songDetails();
                case 227:
                    return ChristInSongHymn.Song_227.songDetails();
                case 228:
                    return ChristInSongHymn.Song_228.songDetails();
                case 229:
                    return ChristInSongHymn.Song_229.songDetails();
                case 230:
                    return ChristInSongHymn.Song_230.songDetails();
                case 231:
                    return ChristInSongHymn.Song_231.songDetails();
                case 232:
                    return ChristInSongHymn.Song_232.songDetails();
                case 233:
                    return ChristInSongHymn.Song_233.songDetails();
                case 234:
                    return ChristInSongHymn.Song_234.songDetails();
                case 235:
                    return ChristInSongHymn.Song_235.songDetails();
                case 236:
                    return ChristInSongHymn.Song_236.songDetails();
                case 237:
                    return ChristInSongHymn.Song_237.songDetails();
                case 238:
                    return ChristInSongHymn.Song_238.songDetails();
                case 239:
                    return ChristInSongHymn.Song_239.songDetails();
                case 240:
                    return ChristInSongHymn.Song_240.songDetails();
                case 241:
                    return ChristInSongHymn.Song_241.songDetails();
                case 242:
                    return ChristInSongHymn.Song_242.songDetails();
                case 243:
                    return ChristInSongHymn.Song_243.songDetails();
                case 244:
                    return ChristInSongHymn.Song_244.songDetails();
                case 245:
                    return ChristInSongHymn.Song_245.songDetails();
                case 246:
                    return ChristInSongHymn.Song_246.songDetails();
                case 247:
                    return ChristInSongHymn.Song_247.songDetails();
                case 248:
                    return ChristInSongHymn.Song_248.songDetails();
                case 249:
                    return ChristInSongHymn.Song_249.songDetails();
                case 250:
                    return ChristInSongHymn.Song_250.songDetails();
                case 251:
                    return ChristInSongHymn.Song_251.songDetails();
                case 252:
                    return ChristInSongHymn.Song_252.songDetails();
                case 253:
                    return ChristInSongHymn.Song_253.songDetails();
                case 254:
                    return ChristInSongHymn.Song_254.songDetails();
                case 255:
                    return ChristInSongHymn.Song_255.songDetails();
                case 256:
                    return ChristInSongHymn.Song_256.songDetails();
                case 257:
                    return ChristInSongHymn.Song_257.songDetails();
                case 258:
                    return ChristInSongHymn.Song_258.songDetails();
                case 259:
                    return ChristInSongHymn.Song_259.songDetails();
                case 260:
                    return ChristInSongHymn.Song_260.songDetails();
                case 261:
                    return ChristInSongHymn.Song_261.songDetails();
                case 262:
                    return ChristInSongHymn.Song_262.songDetails();
                case 263:
                    return ChristInSongHymn.Song_263.songDetails();
                case 264:
                    return ChristInSongHymn.Song_264.songDetails();
                case 265:
                    return ChristInSongHymn.Song_265.songDetails();
                case 266:
                    return ChristInSongHymn.Song_266.songDetails();
                case 267:
                    return ChristInSongHymn.Song_267.songDetails();
                case 268:
                    return ChristInSongHymn.Song_268.songDetails();
                case 269:
                    return ChristInSongHymn.Song_269.songDetails();
                case 270:
                    return ChristInSongHymn.Song_270.songDetails();
                case 271:
                    return ChristInSongHymn.Song_271.songDetails();
                case 272:
                    return ChristInSongHymn.Song_272.songDetails();
                case 273:
                    return ChristInSongHymn.Song_273.songDetails();
                case 274:
                    return ChristInSongHymn.Song_274.songDetails();
                case 275:
                    return ChristInSongHymn.Song_275.songDetails();
                case 276:
                    return ChristInSongHymn.Song_276.songDetails();
                case 277:
                    return ChristInSongHymn.Song_277.songDetails();
                case 278:
                    return ChristInSongHymn.Song_278.songDetails();
                case 279:
                    return ChristInSongHymn.Song_279.songDetails();
                case 280:
                    return ChristInSongHymn.Song_280.songDetails();
                case 281:
                    return ChristInSongHymn.Song_281.songDetails();
                case 282:
                    return ChristInSongHymn.Song_282.songDetails();
                case 283:
                    return ChristInSongHymn.Song_283.songDetails();
                case 284:
                    return ChristInSongHymn.Song_284.songDetails();
                case 285:
                    return ChristInSongHymn.Song_285.songDetails();
                case 286:
                    return ChristInSongHymn.Song_286.songDetails();
                case 287:
                    return ChristInSongHymn.Song_287.songDetails();
                case 288:
                    return ChristInSongHymn.Song_288.songDetails();
                case 289:
                    return ChristInSongHymn.Song_289.songDetails();
                case 290:
                    return ChristInSongHymn.Song_290.songDetails();
                case 291:
                    return ChristInSongHymn.Song_291.songDetails();
                case 292:
                    return ChristInSongHymn.Song_292.songDetails();
                case 293:
                    return ChristInSongHymn.Song_293.songDetails();
                case 294:
                    return ChristInSongHymn.Song_294.songDetails();
                case 295:
                    return ChristInSongHymn.Song_295.songDetails();
                case 296:
                    return ChristInSongHymn.Song_296.songDetails();
                case 297:
                    return ChristInSongHymn.Song_297.songDetails();
                case 298:
                    return ChristInSongHymn.Song_298.songDetails();
                case 299:
                    return ChristInSongHymn.Song_299.songDetails();
                case 300:
                    return ChristInSongHymn.Song_300.songDetails();
                default:
                    return new List<string>();
            }
        }

        /// <summary>
        /// Changes the lyrics on the program, and it
        /// Changes the lyrics of the song and store them in a cache file.
        /// </summary>
        /// <param name="songNumber"></param>
        /// <param name="LyricsToUpdate"></param>
        public static void UpdateSongLyrics(string songNumber, string LyricsToUpdate)
        {
            // make a copy of the song
            var songNum = Convert.ToInt32(songNumber);
            // look for the song number
            switch (songNum)
            {
                case 1:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_1.changeLyrics(LyricsToUpdate);
                    break;
                case 2:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_2.changeLyrics(LyricsToUpdate);
                    break;
                case 3:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_3.changeLyrics(LyricsToUpdate);
                    break;
                case 4:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_4.changeLyrics(LyricsToUpdate);
                    break;
                case 5:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_5.changeLyrics(LyricsToUpdate);
                    break;
                case 6:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_6.changeLyrics(LyricsToUpdate);
                    break;
                case 7:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_7.changeLyrics(LyricsToUpdate);
                    break;
                case 8:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_8.changeLyrics(LyricsToUpdate);
                    break;
                case 9:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_9.changeLyrics(LyricsToUpdate);
                    break;
                case 10:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_10.changeLyrics(LyricsToUpdate);
                    break;
                case 11:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_11.changeLyrics(LyricsToUpdate);
                    break;
                case 12:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_12.changeLyrics(LyricsToUpdate);
                    break;
                case 13:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_13.changeLyrics(LyricsToUpdate);
                    break;
                case 14:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_14.changeLyrics(LyricsToUpdate);
                    break;
                case 15:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_15.changeLyrics(LyricsToUpdate);
                    break;
                case 16:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_16.changeLyrics(LyricsToUpdate);
                    break;
                case 17:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_17.changeLyrics(LyricsToUpdate);
                    break;
                case 18:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_18.changeLyrics(LyricsToUpdate);
                    break;
                case 19:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_19.changeLyrics(LyricsToUpdate);
                    break;
                case 20:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_20.changeLyrics(LyricsToUpdate);
                    break;
                case 21:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_21.changeLyrics(LyricsToUpdate);
                    break;
                case 22:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_22.changeLyrics(LyricsToUpdate);
                    break;
                case 23:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_23.changeLyrics(LyricsToUpdate);
                    break;
                case 24:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_24.changeLyrics(LyricsToUpdate);
                    break;
                case 25:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_25.changeLyrics(LyricsToUpdate);
                    break;
                case 26:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_26.changeLyrics(LyricsToUpdate);
                    break;
                case 27:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_27.changeLyrics(LyricsToUpdate);
                    break;
                case 28:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_28.changeLyrics(LyricsToUpdate);
                    break;
                case 29:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_29.changeLyrics(LyricsToUpdate);
                    break;
                case 30:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_30.changeLyrics(LyricsToUpdate);
                    break;
                case 31:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_31.changeLyrics(LyricsToUpdate);
                    break;
                case 32:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_32.changeLyrics(LyricsToUpdate);
                    break;
                case 33:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_33.changeLyrics(LyricsToUpdate);
                    break;
                case 34:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_34.changeLyrics(LyricsToUpdate);
                    break;
                case 35:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_35.changeLyrics(LyricsToUpdate);
                    break;
                case 36:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_36.changeLyrics(LyricsToUpdate);
                    break;
                case 37:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_37.changeLyrics(LyricsToUpdate);
                    break;
                case 38:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_38.changeLyrics(LyricsToUpdate);
                    break;
                case 39:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_39.changeLyrics(LyricsToUpdate);
                    break;
                case 40:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_40.changeLyrics(LyricsToUpdate);
                    break;
                case 41:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_41.changeLyrics(LyricsToUpdate);
                    break;
                case 42:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_42.changeLyrics(LyricsToUpdate);
                    break;
                case 43:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_43.changeLyrics(LyricsToUpdate);
                    break;
                case 44:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_44.changeLyrics(LyricsToUpdate);
                    break;
                case 45:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_45.changeLyrics(LyricsToUpdate);
                    break;
                case 46:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_46.changeLyrics(LyricsToUpdate);
                    break;
                case 47:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_47.changeLyrics(LyricsToUpdate);
                    break;
                case 48:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_48.changeLyrics(LyricsToUpdate);
                    break;
                case 49:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_49.changeLyrics(LyricsToUpdate);
                    break;
                case 50:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_50.changeLyrics(LyricsToUpdate);
                    break;
                case 51:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_51.changeLyrics(LyricsToUpdate);
                    break;
                case 52:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_52.changeLyrics(LyricsToUpdate);
                    break;
                case 53:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_53.changeLyrics(LyricsToUpdate);
                    break;
                case 54:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_54.changeLyrics(LyricsToUpdate);
                    break;
                case 55:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_55.changeLyrics(LyricsToUpdate);
                    break;
                case 56:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_56.changeLyrics(LyricsToUpdate);
                    break;
                case 57:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_57.changeLyrics(LyricsToUpdate);
                    break;
                case 58:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_58.changeLyrics(LyricsToUpdate);
                    break;
                case 59:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_59.changeLyrics(LyricsToUpdate);
                    break;
                case 60:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_60.changeLyrics(LyricsToUpdate);
                    break;
                case 61:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_61.changeLyrics(LyricsToUpdate);
                    break;
                case 62:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_62.changeLyrics(LyricsToUpdate);
                    break;
                case 63:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_63.changeLyrics(LyricsToUpdate);
                    break;
                case 64:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_64.changeLyrics(LyricsToUpdate);
                    break;
                case 65:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_65.changeLyrics(LyricsToUpdate);
                    break;
                case 66:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_66.changeLyrics(LyricsToUpdate);
                    break;
                case 67:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_67.changeLyrics(LyricsToUpdate);
                    break;
                case 68:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_68.changeLyrics(LyricsToUpdate);
                    break;
                case 69:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_69.changeLyrics(LyricsToUpdate);
                    break;
                case 70:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_70.changeLyrics(LyricsToUpdate);
                    break;
                case 71:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_71.changeLyrics(LyricsToUpdate);
                    break;
                case 72:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_72.changeLyrics(LyricsToUpdate);
                    break;
                case 73:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_73.changeLyrics(LyricsToUpdate);
                    break;
                case 74:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_74.changeLyrics(LyricsToUpdate);
                    break;
                case 75:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_75.changeLyrics(LyricsToUpdate);
                    break;
                case 76:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_76.changeLyrics(LyricsToUpdate);
                    break;
                case 77:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_77.changeLyrics(LyricsToUpdate);
                    break;
                case 78:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_78.changeLyrics(LyricsToUpdate);
                    break;
                case 79:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_79.changeLyrics(LyricsToUpdate);
                    break;
                case 80:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_80.changeLyrics(LyricsToUpdate);
                    break;
                case 81:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_81.changeLyrics(LyricsToUpdate);
                    break;
                case 82:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_82.changeLyrics(LyricsToUpdate);
                    break;
                case 83:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_83.changeLyrics(LyricsToUpdate);
                    break;
                case 84:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_84.changeLyrics(LyricsToUpdate);
                    break;
                case 85:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_85.changeLyrics(LyricsToUpdate);
                    break;
                case 86:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_86.changeLyrics(LyricsToUpdate);
                    break;
                case 87:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_87.changeLyrics(LyricsToUpdate);
                    break;
                case 88:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_88.changeLyrics(LyricsToUpdate);
                    break;
                case 89:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_89.changeLyrics(LyricsToUpdate);
                    break;
                case 90:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_90.changeLyrics(LyricsToUpdate);
                    break;
                case 91:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_91.changeLyrics(LyricsToUpdate);
                    break;
                case 92:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_92.changeLyrics(LyricsToUpdate);
                    break;
                case 93:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_93.changeLyrics(LyricsToUpdate);
                    break;
                case 94:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_94.changeLyrics(LyricsToUpdate);
                    break;
                case 95:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_95.changeLyrics(LyricsToUpdate);
                    break;
                case 96:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_96.changeLyrics(LyricsToUpdate);
                    break;
                case 97:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_97.changeLyrics(LyricsToUpdate);
                    break;
                case 98:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_98.changeLyrics(LyricsToUpdate);
                    break;
                case 99:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_99.changeLyrics(LyricsToUpdate);
                    break;
                case 100:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_100.changeLyrics(LyricsToUpdate);
                    break;
                case 101:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_101.changeLyrics(LyricsToUpdate);
                    break;
                case 102:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_102.changeLyrics(LyricsToUpdate);
                    break;
                case 103:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_103.changeLyrics(LyricsToUpdate);
                    break;
                case 104:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_104.changeLyrics(LyricsToUpdate);
                    break;
                case 105:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_105.changeLyrics(LyricsToUpdate);
                    break;
                case 106:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_106.changeLyrics(LyricsToUpdate);
                    break;
                case 107:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_107.changeLyrics(LyricsToUpdate);
                    break;
                case 108:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_108.changeLyrics(LyricsToUpdate);
                    break;
                case 109:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_109.changeLyrics(LyricsToUpdate);
                    break;
                case 110:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_110.changeLyrics(LyricsToUpdate);
                    break;
                case 111:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_111.changeLyrics(LyricsToUpdate);
                    break;
                case 112:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_112.changeLyrics(LyricsToUpdate);
                    break;
                case 113:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_113.changeLyrics(LyricsToUpdate);
                    break;
                case 114:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_114.changeLyrics(LyricsToUpdate);
                    break;
                case 115:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_115.changeLyrics(LyricsToUpdate);
                    break;
                case 116:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_116.changeLyrics(LyricsToUpdate);
                    break;
                case 117:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_117.changeLyrics(LyricsToUpdate);
                    break;
                case 118:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_118.changeLyrics(LyricsToUpdate);
                    break;
                case 119:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_119.changeLyrics(LyricsToUpdate);
                    break;
                case 120:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_120.changeLyrics(LyricsToUpdate);
                    break;
                case 121:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_121.changeLyrics(LyricsToUpdate);
                    break;
                case 122:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_122.changeLyrics(LyricsToUpdate);
                    break;
                case 123:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_123.changeLyrics(LyricsToUpdate);
                    break;
                case 124:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_124.changeLyrics(LyricsToUpdate);
                    break;
                case 125:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_125.changeLyrics(LyricsToUpdate);
                    break;
                case 126:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_126.changeLyrics(LyricsToUpdate);
                    break;
                case 127:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_127.changeLyrics(LyricsToUpdate);
                    break;
                case 128:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_128.changeLyrics(LyricsToUpdate);
                    break;
                case 129:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_129.changeLyrics(LyricsToUpdate);
                    break;
                case 130:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_130.changeLyrics(LyricsToUpdate);
                    break;
                case 131:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_131.changeLyrics(LyricsToUpdate);
                    break;
                case 132:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_132.changeLyrics(LyricsToUpdate);
                    break;
                case 133:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_133.changeLyrics(LyricsToUpdate);
                    break;
                case 134:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_134.changeLyrics(LyricsToUpdate);
                    break;
                case 135:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_135.changeLyrics(LyricsToUpdate);
                    break;
                case 136:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_136.changeLyrics(LyricsToUpdate);
                    break;
                case 137:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_137.changeLyrics(LyricsToUpdate);
                    break;
                case 138:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_138.changeLyrics(LyricsToUpdate);
                    break;
                case 139:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_139.changeLyrics(LyricsToUpdate);
                    break;
                case 140:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_140.changeLyrics(LyricsToUpdate);
                    break;
                case 141:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_141.changeLyrics(LyricsToUpdate);
                    break;
                case 142:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_142.changeLyrics(LyricsToUpdate);
                    break;
                case 143:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_143.changeLyrics(LyricsToUpdate);
                    break;
                case 144:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_144.changeLyrics(LyricsToUpdate);
                    break;
                case 145:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_145.changeLyrics(LyricsToUpdate);
                    break;
                case 146:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_146.changeLyrics(LyricsToUpdate);
                    break;
                case 147:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_147.changeLyrics(LyricsToUpdate);
                    break;
                case 148:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_148.changeLyrics(LyricsToUpdate);
                    break;
                case 149:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_149.changeLyrics(LyricsToUpdate);
                    break;
                case 150:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_150.changeLyrics(LyricsToUpdate);
                    break;
                case 151:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_151.changeLyrics(LyricsToUpdate);
                    break;
                case 152:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_152.changeLyrics(LyricsToUpdate);
                    break;
                case 153:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_153.changeLyrics(LyricsToUpdate);
                    break;
                case 154:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_154.changeLyrics(LyricsToUpdate);
                    break;
                case 155:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_155.changeLyrics(LyricsToUpdate);
                    break;
                case 156:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_156.changeLyrics(LyricsToUpdate);
                    break;
                case 157:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_157.changeLyrics(LyricsToUpdate);
                    break;
                case 158:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_158.changeLyrics(LyricsToUpdate);
                    break;
                case 159:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_159.changeLyrics(LyricsToUpdate);
                    break;
                case 160:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_160.changeLyrics(LyricsToUpdate);
                    break;
                case 161:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_161.changeLyrics(LyricsToUpdate);
                    break;
                case 162:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_162.changeLyrics(LyricsToUpdate);
                    break;
                case 163:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_163.changeLyrics(LyricsToUpdate);
                    break;
                case 164:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_164.changeLyrics(LyricsToUpdate);
                    break;
                case 165:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_165.changeLyrics(LyricsToUpdate);
                    break;
                case 166:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_166.changeLyrics(LyricsToUpdate);
                    break;
                case 167:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_167.changeLyrics(LyricsToUpdate);
                    break;
                case 168:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_168.changeLyrics(LyricsToUpdate);
                    break;
                case 169:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_169.changeLyrics(LyricsToUpdate);
                    break;
                case 170:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_170.changeLyrics(LyricsToUpdate);
                    break;
                case 171:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_171.changeLyrics(LyricsToUpdate);
                    break;
                case 172:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_172.changeLyrics(LyricsToUpdate);
                    break;
                case 173:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_173.changeLyrics(LyricsToUpdate);
                    break;
                case 174:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_174.changeLyrics(LyricsToUpdate);
                    break;
                case 175:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_175.changeLyrics(LyricsToUpdate);
                    break;
                case 176:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_176.changeLyrics(LyricsToUpdate);
                    break;
                case 177:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_177.changeLyrics(LyricsToUpdate);
                    break;
                case 178:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_178.changeLyrics(LyricsToUpdate);
                    break;
                case 179:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_179.changeLyrics(LyricsToUpdate);
                    break;
                case 180:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_180.changeLyrics(LyricsToUpdate);
                    break;
                case 181:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_181.changeLyrics(LyricsToUpdate);
                    break;
                case 182:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_182.changeLyrics(LyricsToUpdate);
                    break;
                case 183:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_183.changeLyrics(LyricsToUpdate);
                    break;
                case 184:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_184.changeLyrics(LyricsToUpdate);
                    break;
                case 185:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_185.changeLyrics(LyricsToUpdate);
                    break;
                case 186:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_186.changeLyrics(LyricsToUpdate);
                    break;
                case 187:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_187.changeLyrics(LyricsToUpdate);
                    break;
                case 188:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_188.changeLyrics(LyricsToUpdate);
                    break;
                case 189:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_189.changeLyrics(LyricsToUpdate);
                    break;
                case 190:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_190.changeLyrics(LyricsToUpdate);
                    break;
                case 191:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_191.changeLyrics(LyricsToUpdate);
                    break;
                case 192:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_192.changeLyrics(LyricsToUpdate);
                    break;
                case 193:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_193.changeLyrics(LyricsToUpdate);
                    break;
                case 194:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_194.changeLyrics(LyricsToUpdate);
                    break;
                case 195:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_195.changeLyrics(LyricsToUpdate);
                    break;
                case 196:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_196.changeLyrics(LyricsToUpdate);
                    break;
                case 197:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_197.changeLyrics(LyricsToUpdate);
                    break;
                case 198:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_198.changeLyrics(LyricsToUpdate);
                    break;
                case 199:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_199.changeLyrics(LyricsToUpdate);
                    break;
                case 200:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_200.changeLyrics(LyricsToUpdate);
                    break;
                case 201:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_201.changeLyrics(LyricsToUpdate);
                    break;
                case 202:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_202.changeLyrics(LyricsToUpdate);
                    break;
                case 203:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_203.changeLyrics(LyricsToUpdate);
                    break;
                case 204:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_204.changeLyrics(LyricsToUpdate);
                    break;
                case 205:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_205.changeLyrics(LyricsToUpdate);
                    break;
                case 206:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_206.changeLyrics(LyricsToUpdate);
                    break;
                case 207:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_207.changeLyrics(LyricsToUpdate);
                    break;
                case 208:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_208.changeLyrics(LyricsToUpdate);
                    break;
                case 209:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_209.changeLyrics(LyricsToUpdate);
                    break;
                case 210:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_210.changeLyrics(LyricsToUpdate);
                    break;
                case 211:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_211.changeLyrics(LyricsToUpdate);
                    break;
                case 212:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_212.changeLyrics(LyricsToUpdate);
                    break;
                case 213:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_213.changeLyrics(LyricsToUpdate);
                    break;
                case 214:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_214.changeLyrics(LyricsToUpdate);
                    break;
                case 215:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_215.changeLyrics(LyricsToUpdate);
                    break;
                case 216:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_216.changeLyrics(LyricsToUpdate);
                    break;
                case 217:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_217.changeLyrics(LyricsToUpdate);
                    break;
                case 218:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_218.changeLyrics(LyricsToUpdate);
                    break;
                case 219:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_219.changeLyrics(LyricsToUpdate);
                    break;
                case 220:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_220.changeLyrics(LyricsToUpdate);
                    break;
                case 221:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_221.changeLyrics(LyricsToUpdate);
                    break;
                case 222:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_222.changeLyrics(LyricsToUpdate);
                    break;
                case 223:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_223.changeLyrics(LyricsToUpdate);
                    break;
                case 224:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_224.changeLyrics(LyricsToUpdate);
                    break;
                case 225:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_225.changeLyrics(LyricsToUpdate);
                    break;
                case 226:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_226.changeLyrics(LyricsToUpdate);
                    break;
                case 227:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_227.changeLyrics(LyricsToUpdate);
                    break;
                case 228:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_228.changeLyrics(LyricsToUpdate);
                    break;
                case 229:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_229.changeLyrics(LyricsToUpdate);
                    break;
                case 230:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_230.changeLyrics(LyricsToUpdate);
                    break;
                case 231:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_231.changeLyrics(LyricsToUpdate);
                    break;
                case 232:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_232.changeLyrics(LyricsToUpdate);
                    break;
                case 233:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_233.changeLyrics(LyricsToUpdate);
                    break;
                case 234:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_234.changeLyrics(LyricsToUpdate);
                    break;
                case 235:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_235.changeLyrics(LyricsToUpdate);
                    break;
                case 236:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_236.changeLyrics(LyricsToUpdate);
                    break;
                case 237:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_237.changeLyrics(LyricsToUpdate);
                    break;
                case 238:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_238.changeLyrics(LyricsToUpdate);
                    break;
                case 239:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_239.changeLyrics(LyricsToUpdate);
                    break;
                case 240:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_240.changeLyrics(LyricsToUpdate);
                    break;
                case 241:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_241.changeLyrics(LyricsToUpdate);
                    break;
                case 242:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_242.changeLyrics(LyricsToUpdate);
                    break;
                case 243:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_243.changeLyrics(LyricsToUpdate);
                    break;
                case 244:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_244.changeLyrics(LyricsToUpdate);
                    break;
                case 245:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_245.changeLyrics(LyricsToUpdate);
                    break;
                case 246:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_246.changeLyrics(LyricsToUpdate);
                    break;
                case 247:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_247.changeLyrics(LyricsToUpdate);
                    break;
                case 248:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_248.changeLyrics(LyricsToUpdate);
                    break;
                case 249:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_249.changeLyrics(LyricsToUpdate);
                    break;
                case 250:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_250.changeLyrics(LyricsToUpdate);
                    break;
                case 251:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_251.changeLyrics(LyricsToUpdate);
                    break;
                case 252:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_252.changeLyrics(LyricsToUpdate);
                    break;
                case 253:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_253.changeLyrics(LyricsToUpdate);
                    break;
                case 254:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_254.changeLyrics(LyricsToUpdate);
                    break;
                case 255:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_255.changeLyrics(LyricsToUpdate);
                    break;
                case 256:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_256.changeLyrics(LyricsToUpdate);
                    break;
                case 257:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_257.changeLyrics(LyricsToUpdate);
                    break;
                case 258:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_258.changeLyrics(LyricsToUpdate);
                    break;
                case 259:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_259.changeLyrics(LyricsToUpdate);
                    break;
                case 260:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_260.changeLyrics(LyricsToUpdate);
                    break;
                case 261:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_261.changeLyrics(LyricsToUpdate);
                    break;
                case 262:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_262.changeLyrics(LyricsToUpdate);
                    break;
                case 263:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_263.changeLyrics(LyricsToUpdate);
                    break;
                case 264:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_264.changeLyrics(LyricsToUpdate);
                    break;
                case 265:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_265.changeLyrics(LyricsToUpdate);
                    break;
                case 266:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_266.changeLyrics(LyricsToUpdate);
                    break;
                case 267:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_267.changeLyrics(LyricsToUpdate);
                    break;
                case 268:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_268.changeLyrics(LyricsToUpdate);
                    break;
                case 269:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_269.changeLyrics(LyricsToUpdate);
                    break;
                case 270:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_270.changeLyrics(LyricsToUpdate);
                    break;
                case 271:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_271.changeLyrics(LyricsToUpdate);
                    break;
                case 272:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_272.changeLyrics(LyricsToUpdate);
                    break;
                case 273:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_273.changeLyrics(LyricsToUpdate);
                    break;
                case 274:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_274.changeLyrics(LyricsToUpdate);
                    break;
                case 275:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_275.changeLyrics(LyricsToUpdate);
                    break;
                case 276:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_276.changeLyrics(LyricsToUpdate);
                    break;
                case 277:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_277.changeLyrics(LyricsToUpdate);
                    break;
                case 278:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_278.changeLyrics(LyricsToUpdate);
                    break;
                case 279:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_279.changeLyrics(LyricsToUpdate);
                    break;
                case 280:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_280.changeLyrics(LyricsToUpdate);
                    break;
                case 281:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_281.changeLyrics(LyricsToUpdate);
                    break;
                case 282:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_282.changeLyrics(LyricsToUpdate);
                    break;
                case 283:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_283.changeLyrics(LyricsToUpdate);
                    break;
                case 284:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_284.changeLyrics(LyricsToUpdate);
                    break;
                case 285:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_285.changeLyrics(LyricsToUpdate);
                    break;
                case 286:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_286.changeLyrics(LyricsToUpdate);
                    break;
                case 287:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_287.changeLyrics(LyricsToUpdate);
                    break;
                case 288:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_288.changeLyrics(LyricsToUpdate);
                    break;
                case 289:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_289.changeLyrics(LyricsToUpdate);
                    break;
                case 290:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_290.changeLyrics(LyricsToUpdate);
                    break;
                case 291:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_291.changeLyrics(LyricsToUpdate);
                    break;
                case 292:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_292.changeLyrics(LyricsToUpdate);
                    break;
                case 293:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_293.changeLyrics(LyricsToUpdate);
                    break;
                case 294:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_294.changeLyrics(LyricsToUpdate);
                    break;
                case 295:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_295.changeLyrics(LyricsToUpdate);
                    break;
                case 296:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_296.changeLyrics(LyricsToUpdate);
                    break;
                case 297:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_297.changeLyrics(LyricsToUpdate);
                    break;
                case 298:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_298.changeLyrics(LyricsToUpdate);
                    break;
                case 299:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_299.changeLyrics(LyricsToUpdate);
                    break;
                case 300:
                    GeneralMethods.SaveSongLyricToCache(songNumber, LyricsToUpdate,HymnType.ChristInSong);
                    ChristInSongHymn.Song_300.changeLyrics(LyricsToUpdate);
                    break;
                default:
                    break;
            }
        }
        
    }
}
