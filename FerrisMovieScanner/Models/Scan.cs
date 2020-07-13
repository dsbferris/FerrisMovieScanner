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
        public VideoFile[] Videos { get; set; }
    }
}
