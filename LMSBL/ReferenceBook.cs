using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class ReferenceBook : LibraryItem
    {
        public Author Author { get; set; }
        public int NoOfPages { get; set; }

        public ReferenceBook()
        {
            // Default constructor logic here
        }
    }
}
