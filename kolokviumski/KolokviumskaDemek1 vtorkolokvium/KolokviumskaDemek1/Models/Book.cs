using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KolokviumskaDemek1.Models
{
    public class Book
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Genre { get; set; }
        
        [Range(10000, 99999)]
        public int ISBN { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }
        public Book()
        {
            Libraries = new List<Library>();
        }
    }
}