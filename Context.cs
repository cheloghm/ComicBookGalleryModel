using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ComicBookGalleryModel
{
    public class Context :DbContext
    {
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
