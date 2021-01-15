using ComicBookGalleryModel.Models;
using System;
using System.Linq;
using System.Data.Entity;

namespace ComicBookGalleryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .Include(cb => cb.Artists.Select(a => a.Artist))
                    .Include(cb => cb.Artists.Select(a => a.Role))
                    .ToList();
                foreach (var comicBook in comicBooks)
                {
                    var artistsRoleName = comicBook.Artists
                        .Select(a => $"{a.Artist.Name} - {a.Role.Name}").ToList();
                    var artistsRolesDisplayText = string.Join(", ", artistsRoleName);


                    Console.WriteLine(comicBook.DisplayText);
                    Console.WriteLine(artistsRolesDisplayText);
                }
                Console.ReadLine();
            }
        }
    }
}
