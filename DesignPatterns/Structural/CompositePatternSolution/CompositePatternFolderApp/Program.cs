using System;
using System.Collections.Generic;

namespace CompositePatternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new Folder("Movies");
            movies.AddItem(new File("Titanic","600MB"));
            var comedy = new Folder("Comedy Movies");
            comedy.AddItem(new File("3 Idiots", "900MB"));
            var horrorComedy = new Folder("HorrorComedy");
            horrorComedy.AddItem(new File("Scary Movie", "100MB"));
            comedy.AddItem(horrorComedy);
            movies.AddItem(comedy);
            movies.Display();

            Console.ReadKey();
        }
    }
}
