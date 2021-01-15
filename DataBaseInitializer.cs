using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using ComicBookGalleryModel.Models;

namespace ComicBookGalleryModel
{
    internal class DataBaseInitializer
        : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var series1 = new Series()
            {
                Title = "The amazing Spider-Man"
            };

            var series2 = new Series()
            {
                Title = "The Invincible Iron-Man"
            };

            var artist1 = new Artist()
            {
                Name = "Stan Lee"
            };

            var artist2 = new Artist()
            {
                Name = "Graham Chukwumaobi"
            };

            var artist3 = new Artist()
            {
                Name = "Steve Dicko"
            };

            var role1 = new Role()
            {
                Name = "Script"
            };

            var role2 = new Role()
            {
                Name = "Pencil"
            };

            var comicBook1 = new ComicBook()
            {
                Series = series1,
                IssueNumber = 1,
                PublishedOn = DateTime.Today
            };
            comicBook1.AddArtist(artist1, role1);
            comicBook1.AddArtist(artist2, role2);

            var comicBook2 = new ComicBook()
            {
                Series = series1,
                IssueNumber = 2,
                PublishedOn = DateTime.Today
            };

            comicBook2.AddArtist(artist1, role1);
            comicBook2.AddArtist(artist2, role2);

            var comicBook3 = new ComicBook()
            {
                Series = series2,
                IssueNumber = 3,
                PublishedOn = DateTime.Today
            };

            comicBook3.AddArtist(artist2, role1);
            comicBook3.AddArtist(artist3, role2);

            context.ComicBooks.Add(comicBook1);
            context.ComicBooks.Add(comicBook2);
            context.ComicBooks.Add(comicBook2);
            context.SaveChanges();
        }
    }
}
