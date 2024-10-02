using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class Book : LibraryItem
    {
        public Author Author { get; set; }
        public int NoOfPages { get; set; }

        public Book()
        {
            
        }
    }
}
