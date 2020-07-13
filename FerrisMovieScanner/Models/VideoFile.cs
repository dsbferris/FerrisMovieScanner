using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrisMovieScanner.Models
{
    public class VideoFile
    {
        public string FilePath { get; set; }
        public double Size { get; set; }
        public string SizeReadable { get { return BytesHumanReadable(Size); } }




        public string FileName { get { return Path.GetFileName(FilePath); } }



        public static string BytesHumanReadable(double len)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }

        public static int Sort(VideoFile f1, VideoFile f2)
        {
            throw new NotImplementedException();
        }
    }


}
