using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Book
    {
        public string Name { get; set; }

        public static int Id;

        public string AuthorName { get; set; }

        public int PageCount { get; set; }

        public string Code { get; set; }

        public Book( string name, string authorname ,int pagecount , string code)
        {
            Id++;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;

            Code = code.Remove(1).ToUpper() + Id;
        }
    }
}
