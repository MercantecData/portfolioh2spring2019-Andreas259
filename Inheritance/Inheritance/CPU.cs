using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class CPU
    {
        public float Mhz { get; private set; }
        public int Cores { get; private set; }

        public CPU(float mhz, int cores)
        {
            Mhz = mhz;
            Cores = cores;
        }
    }
}
