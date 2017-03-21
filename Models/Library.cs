using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCLibrary.Models
{
    public class Library 
    {
        public int Id { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Name { get; set; }
        public List<Book> Books = new List<Book>();
    }
}