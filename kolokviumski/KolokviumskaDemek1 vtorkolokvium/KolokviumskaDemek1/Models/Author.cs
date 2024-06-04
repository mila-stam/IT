using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KolokviumskaDemek1.Models
{
    public class Author
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Book> ReleasedBooks { get; set; }
        public Author()
        {
            ReleasedBooks = new List<Book>();
        }
    }
}