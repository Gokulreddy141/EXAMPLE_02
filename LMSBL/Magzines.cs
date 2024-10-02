using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class Magazines : LibraryItem
    {
        public int NoOfPages { get; set; }
        public Publication Publication { get; set; }

        public Magazines()
        {
            // Default constructor logic here
        }
    }
}
