using System;
using System.Collections.Generic;
using System.Text;

namespace homework09._06._2022
{
    class Book : Product
    {
        public string Author;
        public string Genre;
        public override void GetInfo()
        {
            Console.WriteLine($"author {Author} genre: {Genre} name: {Name}");
        }
    }
}
