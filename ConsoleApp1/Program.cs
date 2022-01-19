using ConsoleApp1;
using System;
using System.Threading;

int Speed = 0, Memory = 0, fileCount = 0, dvdFace = 0;
string NameOfTheMedia = "", Model = "";

Menu menu = new();

void start()
{
    Console.Clear();

    ConsoleKey key;

    Console.WriteLine("[ 1 ] Flash\n[ 2 ] DVD\n[ 3 ] HDD");
   
    key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.D1)
    {

        Console.Clear();

        try
        {
            Console.Write("File Size [ GB ] : ");
            fileCount = int.Parse(Console.ReadLine());

            Console.Write("Media Name : ");
            NameOfTheMedia = Console.ReadLine();

            Console.Write("Model Name : ");
            Model = Console.ReadLine();

            Console.Write("Flash Speed : ");
            Speed = int.Parse(Console.ReadLine());

            Console.Write("Memory [ GB ] : ");
            Memory = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("\nOnly digits can be entered !");
            Thread.Sleep(1000);
            start();
        }

        Flash flash = new Flash(Speed, Memory);

        menu.Menuu(flash, NameOfTheMedia, Model, fileCount, 1);

    }
    else if (key == ConsoleKey.D2)
    {
        Console.Clear();

        try
        {
            Console.Write("DVD Face [ 1 or 2 ] : ");
            dvdFace = int.Parse(Console.ReadLine());

            if(dvdFace < 1 || dvdFace > 2)
            {
                Console.WriteLine("\nOnly digits can be entered !");
                Thread.Sleep(1000);
                start();
            }
            else
            {
                Console.Write("File Size [ GB ] : ");
                fileCount = int.Parse(Console.ReadLine());

                Console.Write("Media Name : ");
                NameOfTheMedia = Console.ReadLine();

                Console.Write("Model Name : ");
                Model = Console.ReadLine();

                Console.Write("DVD Speed : ");
                Speed = int.Parse(Console.ReadLine());

            }
        }
        catch (Exception)
        {
            Console.WriteLine("\nOnly digits can be entered !");
            Thread.Sleep(1000);
            start();
        }

        DVD dvd = new DVD(Speed, dvdFace);

        menu.Menuu(dvd, NameOfTheMedia, Model, fileCount, 2);

    }
    else if (key == ConsoleKey.D3)
    {

        Console.Clear();

        try
        {
            Console.Write("File Size [ GB ] : ");
            fileCount = int.Parse(Console.ReadLine());

            Console.Write("Media Name : ");
            NameOfTheMedia = Console.ReadLine();

            Console.Write("Model Name : ");
            Model = Console.ReadLine();

            Console.Write("HDD Speed : ");
            Speed = int.Parse(Console.ReadLine());

            Console.Write("Memory [ GB ] : ");
            Memory = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("\nOnly digits can be entered !");
            Thread.Sleep(1000);
            start();
        }

        HDD hdd = new HDD(Speed, Memory);

        menu.Menuu(hdd, NameOfTheMedia, Model, fileCount, 3);

    }
    else
    {
        Console.WriteLine("\nWrong choice !");
        Thread.Sleep(1000);
        start();
    }
}

start();
