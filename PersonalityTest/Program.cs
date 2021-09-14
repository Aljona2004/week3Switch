using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //programm küsib kasutaja sisetada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töötakas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "olrd üksarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töötakas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else 
            {
                Console.WriteLine($"Oled {userColor} ükssarvik");
            }
        }

    }
}
