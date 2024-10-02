using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class LibraryItem
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public bool Available { get; set; }

        public string CheckAvailability()
        {
            return Available ? "Available" : "Not Available";
        }

        public LibraryItem()
        {
           
        }
    }
}
