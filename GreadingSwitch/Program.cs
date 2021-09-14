using System;

namespace GreadingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinnet kasutaja sai;
            //kui kasutaja sai "5", programm kuvab konsoolis "suurepärane";
            //kui kasutaja sai "4", programm kuvab konsoolis "väga hea";
            //kui kasutaja sai "3", programm kuvab konsoolis "hea";
            //kui kasutaja sai "3", programm kuvab konsoolis "rahuldav";
            //kui kasutaja sai "1", programm kuvab konsoolis "puudulik";
            //muul juhul programm kirjutab konsoolis "puudulik";

            Console.WriteLine("Sisesta mis hinnet said:");
            string userMark = Console.ReadLine();

            switch (userMark)
            {
                case "5":
                    Console.WriteLine("suurepärane");
                    break;
                case "4":
                    Console.WriteLine("väga hea");
                    break;
                case "3":
                    Console.WriteLine("hea");
                    break;
                case "2":
                    Console.WriteLine("rahuldav");
                    break;
                case "1":
                    Console.WriteLine("puudulik");
                    default
                    Console.WriteLine($"{userMark} puudulik.");
                    break;

            }
    }
}
