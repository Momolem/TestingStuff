using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Stuff {
    class Program {
        static void Main(string[] args) {
            //Higher lower 
            bool richtig = false;

            Random rnd = new Random();
            while(true) {
                int solution = rnd.Next(1, 60);
                Console.Out.Write("Errate die Zahl");
                richtig = false;
                while (!richtig)
                {
                    int antwort = Int32.Parse(Console.In.ReadLine());

                    if(antwort > solution)
                    {
                        Console.Out.WriteLine("Zu hoch!");
                    } else if(antwort < solution)
                    {
                        Console.Out.WriteLine("Zu niedrig!");
                    } else
                    {
                        Console.Out.WriteLine("Richtig!");
                        richtig = true;
                    }

                }
            }
        }
    }
}
