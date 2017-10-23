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
        static void Main(string[] args)
        {
            string strText = "Intro: \n" +
                "It’s the year 1888. \n" +
                "It's 2:00 am in the morning when you left the pub.\n" +
                "You walk through a dark alley when suddenly you got hit from behind on year head.\n" +
                "You started to wake up.\n" +
                "Where am I \n" +
                "Old man: you have been captured by me. \n" +
                "You have to find your way out of my sewers. \n" +
                "Start by finding the key to open your cell door. \n";

            for (int i = 0; i < strText.Length; i++)
            {
                Console.Write(strText[i]);
                Thread.Sleep(175);
            }

            Console.ReadLine();



        }
    }
}
