using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public struct Otrezki
    {
        public int start;
        public int end;
        public byte status;
        public Otrezki(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }
    
}
