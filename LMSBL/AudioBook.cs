using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class AudioBook : LibraryItem
    {
        public Author Author { get; set; }
        public double Duration { get; set; }

        public AudioBook()
        {
            // Default constructor logic here
        }
    }
}
