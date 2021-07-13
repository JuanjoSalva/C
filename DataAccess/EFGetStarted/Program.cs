using System;
using System.Linq;
using static System.Console;

namespace EFGetStarted
{
    class Program
    {
        static void Main()
        {
            using (var db = new BloggingContext())
            {
                // Create
                WriteLine("Inserting a new blog");
                //db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                db.Add(new Blog { Url = "https://devblogs.microsoft.com/dotnet/tag/c/" });
                db.SaveChanges();

                Pausa();

                // Read
                WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();
                WriteLine($"Primer blog: {blog.Url}");

                Pausa();

                // Update
                WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                Pausa();

                // Delete
                WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();

                Pausa();
            }
        }

        static void Pausa()
        {
            WriteLine("Pres any key to continue");
            ReadKey();
        }
    }
}