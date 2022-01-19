using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Flash : Storage
    {
        public int USB_3_0 { get; set; }
        public int Memory { get; set; }

        public Flash(int uSB_3_0, int memory)
        {
            USB_3_0 = uSB_3_0;
            Memory = memory;
        }

        public override string ToString()
        {
            return $"\nUSB 3.0 : {USB_3_0}\nMemory : {Memory}";
        }

    }
}
