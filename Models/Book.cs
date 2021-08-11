using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int Book_id { get; set; }
        public String Book_name { get; set; }
        public Author Author { get; set; }
        public int Book_pages_number { get; set; }
        public String b_category { get; set; }
        public String b_desc { get; set; }
    }
}
