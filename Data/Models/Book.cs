using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreapi.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public DateTime? DateStart { get; set; } //? is used for nullable
        public DateTime? DateRead { get; set; }  //? is used for nullable

    }
}
