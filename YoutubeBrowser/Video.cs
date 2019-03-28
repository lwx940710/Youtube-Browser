﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YoutubeBrowser
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public Image Thumbnail { get; set; }
    }
}
