using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DVD : Storage
    {
        public int ReadWriteSpeed { get; set; }
        public int Type { get; set; }

        public DVD(int readWriteSpeed, int type)
        {
            ReadWriteSpeed = readWriteSpeed;
            Type = type;
        }

        public override string ToString()
        {
            return $"\nDVD Speed : {ReadWriteSpeed}\nType : {Type}";
        }
    }
}
