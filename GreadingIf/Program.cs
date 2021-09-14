using System;

namespace GreadingIf
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

            if (userMark == "5")
            {
                Console.WriteLine("suurepärane.");
            }
            else if (userMark == "4")
            {
                Console.WriteLine("väga hea.");
            }
            else if (userMark == "3")
            {
                Console.WriteLine("hea");
            }
            else if (userMark == "2")
            {
                Console.WriteLine("rahuldav");
            }
            else if (userMark == "1")
            {
                Console.WriteLine("puudulik");
            }
            else
            {
                Console.WriteLine($" {userMark} puudulik");
            }

        }
    }
}
