using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    struct Distance
    {
        public int cm;
        string name;


        public Distance(int c)
        {
            cm = c;
            name = "";
        }

        public int GetMeter()
        {
            return cm / 100;
        }
    }
}
