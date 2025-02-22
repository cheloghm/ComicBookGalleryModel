﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicBookGalleryModel.Models
{
    
    public class Artist
    {
        public Artist()
        {
            ComicBooks = new List<ComicBookArtist>();
        }
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }

        
        public string Test { get; set; }
        public ICollection<ComicBookArtist> ComicBooks { get; set; }
    }
}
