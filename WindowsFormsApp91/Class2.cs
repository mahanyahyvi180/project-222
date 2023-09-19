using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp91
{
   public class Tarkib
    {

        public int x
        {
            get;
            set;
        }

        public int n
        {
            get;
            set;
        }

        public int Composition(mydelegate t)
        {
            return Convert.ToInt32(t(n) / t(x) * t(n - x));
        }
    }
}
