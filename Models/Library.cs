using System.Collections.Generic;

namespace MVCLibrary.Models
{
    public class Library 
    {
        public string Address { get; set; }
        public int Phone { get; set; }
        public int  squareFeet { get; set; }
        public string Hours { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public  List<Book> Books = new List<Book>();
    }
}