using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ComicBookGalleryModel
{
    public class Context :DbContext
    {
        public Context() : base("ComicBookGallery")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }
        //public Context() : base("ComicBookGallery")//or: base(@"Data Source=(localdb\MSSQLLocalDB;Initial Catalogue=ComicBookGalleryConnectionString;Integrated Security=True;MultipleActiveResultSets=True")
        //{

        //}
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
