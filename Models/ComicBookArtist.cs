﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBookGalleryModel.Models
{
    public class ComicBookArtist
    {
        public int Id { get; set; }
        public int ComicBookId { get; set; }
        public int ArtistId { get; set; }
        public int RoleId { get; set; }

        public ComicBook ComicBook { get; set; }
        public Artist Artist { get; set; }
        public Role Role { get; set; }
    }
}
