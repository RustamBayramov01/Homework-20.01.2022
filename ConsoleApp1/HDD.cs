using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HDD : Storage
    {
        public int USB_2_0 { get; set; }
        public int Memory { get; set; }

        public HDD(int uSB_2_0, int memory)
        {
            USB_2_0 = uSB_2_0;
            Memory = memory;
        }

        public override string ToString()
        {
            return $"\nUSB 2.0 : {USB_2_0}, Memory : {Memory}";
        }
    }
}
