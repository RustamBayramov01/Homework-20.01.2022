using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Storage
    {

        public string NameOfTheMedia { get; set; }
        public string Model { get; set; }
        public int FileCount { get; set; }


        public Storage(string nameOfTheMedia, string model, int fileCount)
        {
            NameOfTheMedia = nameOfTheMedia;
            Model = model;
            FileCount = fileCount;
        }


        public Storage() { }


        // Tutumu həcmi
        public void TheSizeOfTheMediaType(Object memory)
        {
            Console.Clear();
            Console.WriteLine(memory);
            Console.WriteLine("\nBack after 3 seconds");
        }



        // törəmə classlarda riyazi hesablamalar edilməlidir ki neçə ədəd media lazımdır və neçə saat çəkəcək
        public void CopyMethod(Object copymethod, int selection)
        {
            Console.Clear();

            int fsize = FileCount * 780;

            if(selection == 1)
            {
                Flash flash ;
                flash = (Flash)copymethod;

                Console.WriteLine($"{fsize / ( flash.Memory * 1000 )} : Media Required");
                Console.WriteLine($"{fsize / (flash.USB_3_0)} : Seconds Required");
            }
            else if(selection == 2)
            {

                double memory = 0;

                DVD dvd;
                dvd = (DVD)copymethod;

                if(dvd.Type == 1) memory = 4.7;
                else memory = 9.0;

                Console.WriteLine($"{fsize / (memory * 1000)} : Media Required");
                Console.WriteLine($"{fsize / (dvd.ReadWriteSpeed)} : Seconds Required");

            }
            else if(selection == 3)
            {
                HDD hdd;
                hdd = (HDD)copymethod;

                Console.WriteLine($"{fsize / (hdd.Memory * 1000)} : Media Required");
                Console.WriteLine($"{fsize / (hdd.USB_2_0)} : Seconds Required");
            }
        }



        // nə qədər boş yer qaldığını qaytarmalıdır
        public void FreeMemory(Object memory, int selection)
        {
            Console.Clear();

            int fsize = FileCount * 780;

            if(selection == 1)
            {
                Flash flash;
                flash = (Flash)memory;

                if(fsize > flash.Memory * 1000) Console.WriteLine($"{fsize - flash.Memory * 1000} : MB free Memory");
                else Console.WriteLine("There is not enough space !");

            }
            else if (selection == 2)
            {

                double dvdMemory = 0;

                DVD dvd;
                dvd = (DVD)memory;

                if (dvd.Type == 1) memory = 4.7;
                else memory = 9.0;

                if (fsize > dvdMemory * 1000) Console.WriteLine($"{fsize - dvdMemory * 1000} : MB free Memory");
                else Console.WriteLine("There is not enough space !");

            }
            else if (selection == 3)
            {
                HDD hdd;
                hdd = (HDD)memory;

                if (fsize > hdd.Memory * 1000) Console.WriteLine($"{fsize - hdd.Memory * 1000} : MB free Memory");
                else Console.WriteLine("There is not enough space !");
            }
        }




        // Qurğu haqqında tam informasiya verən metod
        public void PrintDeviceİnfo(Object memory)
        {
            Console.Clear();
            Console.WriteLine($"Media Name : {NameOfTheMedia}\nModel Name : {Model}");
            Console.WriteLine(memory);
            Console.WriteLine("\nBack after 3 seconds");

        }
    }
}
