using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class GenreList
    {   
        
        public int GenreListID { get; set; }

        [Display(Name = "Genres")]
        public string GenreListName { get; set; }
    }
}
