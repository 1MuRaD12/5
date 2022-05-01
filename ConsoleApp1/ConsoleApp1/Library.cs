using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Library
    {
        public List<Book> books = new List<Book>();



        public List<Book> FindAllBooksByName(string value)
        {
            return books.FindAll(book => book.Name.Contains(value));
        }
        public void RemoveAllBooksByNme(string value)
        {
            books.RemoveAll(book => book.Name.Contains(value));
        }
        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value));
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return books.FindAll(book => book.PageCount >= min && book.PageCount <= max);
        }
        public void RemoveBookByCode(string value)
        {
            Book want = books.Find(book => book.Code == value);
            if (want != null)
            {
                books.Remove(want);
            }
        }
    }
}
