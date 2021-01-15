using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicBookGalleryModel.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required, StringLength(100)]

        public string Name { get; set; }
    }
}
