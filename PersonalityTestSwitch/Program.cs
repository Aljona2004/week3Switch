using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisetada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töötakas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "olrd üksarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            switch(userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
