using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrisMovieScanner.Models
{
    public class Scan
    {
        public string[] Folders { get; set; }
        public string[] Extensions { get; set; }
        public List<VideoFile> Videos { get; set; }

        public void SortVideos()
        {
            Videos.Sort(delegate (VideoFile v1, VideoFile v2)
            { return v1.FileName.CompareTo(v2.FileName); });
        }


    }
}
