using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ArmakomLogReader
{
    public class LogLevels
    {
        public static Dictionary<string, Color> LevelColors { get; set; }

        public static void FillLevelColors()
        {
            LevelColors = new Dictionary<string, Color>();
            LevelColors.Add(LogLevelEnum.Debug.ToString(),  Color.FromArgb(223, 223, 223));
            LevelColors.Add(LogLevelEnum.Error.ToString(),  Color.FromArgb(255, 196, 218));
            LevelColors.Add(LogLevelEnum.Info.ToString() ,  Color.FromArgb(188, 245, 191));
            LevelColors.Add(LogLevelEnum.Fatal.ToString() , Color.FromArgb(255, 117, 117));
            LevelColors.Add(LogLevelEnum.Warn.ToString() , Color.FromArgb(255, 155, 89));
        }

        public enum LogLevelEnum
        {
            Trace,
            Debug,
            Info,
            Warn,
            Error,
            Fatal
        }

        public static IEnumerable<LogLevelEnum> GetLevelEnum()
        {
            return EnumUtil.GetValues<LogLevelEnum>();
        }

        public static Color GetLevelColor(string level)
        {
            if (LevelColors.ContainsKey(level))
            {
                return LevelColors[level];
            }
            return Color.WhiteSmoke;
        }
    }

    public static class EnumUtil 
    {
        public static IEnumerable<T> GetValues<T>() 
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }  
}
