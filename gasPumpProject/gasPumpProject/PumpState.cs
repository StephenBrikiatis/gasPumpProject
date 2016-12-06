using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    abstract class PumpState
    {

        public abstract void usePump();
        public abstract float usePump(int a, int b, float c);
    }
}
