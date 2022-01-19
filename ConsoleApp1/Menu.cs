using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Menu
    {
        Storage storage;

        public void Menuu(Object other, string nameOfTheMedia, string model, int fileCount, int selection)
        { 

            Console.Clear();

            ConsoleKey key;

            Console.WriteLine("[ 1 ] The size of the media type\n[ 2 ] Copy Method\n[ 3 ] Free Memory\n[ 4 ] Device İnfo");

            key = Console.ReadKey(true).Key;

            if(key == ConsoleKey.D1)
            {
                storage = new(nameOfTheMedia, model, fileCount);
                storage.TheSizeOfTheMediaType(other);
                Thread.Sleep(3000);
                Menuu(other, nameOfTheMedia, model, fileCount, selection);
            }
            else if(key == ConsoleKey.D2)
            {
                storage = new(nameOfTheMedia, model, fileCount);
                storage.CopyMethod(other, selection);
                Thread.Sleep(3000);
                Menuu(other, nameOfTheMedia, model, fileCount, selection);
            }
            else if (key == ConsoleKey.D3)
            {
                storage = new(nameOfTheMedia, model, fileCount);
                storage.FreeMemory(other, selection);
                Thread.Sleep(3000);
                Menuu(other, nameOfTheMedia, model, fileCount, selection);
            }
            else if (key == ConsoleKey.D4)
            {
                storage = new(nameOfTheMedia, model, fileCount);
                storage.PrintDeviceİnfo(other);
                Thread.Sleep(3000);
                Menuu(other, nameOfTheMedia, model, fileCount, selection);
            }
            else
            {
                Console.WriteLine("\nWrong choice !");
                Thread.Sleep(1000);
                Menuu(other, nameOfTheMedia, model, fileCount, selection);
            }
        }

    }
}
