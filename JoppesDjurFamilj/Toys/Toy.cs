using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoppesDjurFamilj.Toys
{
    public abstract class Toy
    {
        protected int quality;

        public int Quality { get { return quality; } }
        public Toy(int quality)
        {
            this.quality = quality;
        }
    }
}
