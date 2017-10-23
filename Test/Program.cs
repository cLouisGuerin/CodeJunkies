using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test
{
    class Program
    {
        public static bool Escape { get; private set; }

        static void Main(string[] args)
        {
            string strText = "Intro: \n" +
               "It’s the year 1888. \n" +
               "It's 2:00 am in the morning when you left the pub.\n" +
               "You walk through a dark alley when suddenly you got hit from behind on your head.\n" +
               "You slowly regained conciousness.\n" +
               "Where am I? \n" +
               "Old man: you have been captured by me. \n" +
               "You have to find your way out of my sewers, if you can that is. \n" +
               "Start by finding the key to open your cell door. \n";

            for (int i = 0; i < strText.Length; i++)
            {
                Console.Write(strText[i]);
                Thread.Sleep(165);
            }

            Console.ReadLine();
            abcd
            string command;
            command = Console.ReadLine();

            do
            {
                if (Escape == true)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You Made it out! ");
                    Console.WriteLine("Press any key to exit ");
                    Console.ReadLine();

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You didn't make it out in time, want to try again? (Y/N) ");
                    
                }
               

            }
            while (command == "Y");
            
            







        }
    }
}
