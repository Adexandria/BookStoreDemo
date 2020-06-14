using System;
using System.Collections.Generic;
using System.Text;

namespace Book.info
{
    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public bool Trendy { get; set; }
       
        public bool New { get; set; }
        public bool BestOfTheWeek { get; set; }
        public ICollection<Details> Description { get; set; }
        public double Price { get; set; }


    }
}
