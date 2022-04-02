using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsTracker
{
    public class Comic
    {
        public String Name { get; set; }   
        public bool Finished { get; set; }
        public Comic(String name,bool finished)
        {
            this.Name = name;
            this.Finished = finished;
        }
    }
}
