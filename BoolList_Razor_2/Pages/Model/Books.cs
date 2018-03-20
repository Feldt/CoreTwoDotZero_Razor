using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoolList_Razor_2.Pages.Model
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String ISBN  { get; set; }
        public int Avaibility { get; set; }
        public double Price { get; set; }
    }
}
