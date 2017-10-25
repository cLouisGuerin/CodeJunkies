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
            Console.WindowHeight = 20;
            Console.WindowWidth = 128;

            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|    o.OOoOoo                                      oOoOOoOOo o                 .oOOOo.                                       |");
            Console.WriteLine("|     O                                                o     O                 o     o                                       |");
            Console.WriteLine("|     o                                                o     o                 O.                                            |");
            Console.WriteLine("|     ooOO                                             O     O                  `OOoo.                                       |");
            Console.WriteLine("|     O       .oOo  .oOo  .oOoO' .oOo. .oOo.           o     OoOo. .oOo.             `O .oOo. 'o     O .oOo. `OoOo. .oOo     |");
            Console.WriteLine("|     o       `Ooo. O     O   o  O   o OooO'           O     o   o OooO'              o OooO'  O  o  o OooO'  o     `Ooo.    |");
            Console.WriteLine("|     O           O o     o   O  o   O O               O     o   O O           O.    .O O      o  O  O O      O         O    |");
            Console.WriteLine("|     ooOooOoO `OoO' `OoO' `OoO'o oOoO' `OoO'          o'    O   o `OoO'        `oooO'  `OoO'  `Oo'oO' `OoO'  o     `OoO'    |");
            Console.WriteLine("|                                 O                                                                                          |");
            Console.WriteLine("|                                 o'            Press Enter To Continue                                                      |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|     2017 - CodeJunkies                                                                                                     |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.SetCursorPosition(2, 17);
            Console.ReadLine();



            Console.Clear();


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


            //toilet
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                               +----------------------------------------+                                   |");
            Console.WriteLine("|                                               |                                        |                                   |");
            Console.WriteLine("|                                               |   +---+                      +------+  |                                   |");
            Console.WriteLine("|                                               |   |   |                      |      |  |                                   |");
            Console.WriteLine("|                                               |   |   |    +----+            |      |  |                                   |");
            Console.WriteLine("|                                               |   +---+    |    |            |      |  |                                   |");
            Console.WriteLine("|                                               |            |    |            |    +-+  |                                   |");
            Console.WriteLine("|                                               |   +---+    +    +            |      |  |                                   |");
            Console.WriteLine("|                                               |    +-+      +  +             |      |  |                                   |");
            Console.WriteLine("|                                               |     |        ++              |      |  |                                   |");
            Console.WriteLine("|                                               +------------------------------+------+--+                                   |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");


            //mortuarium
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("| +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+                                                     |");
            Console.WriteLine("| |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |                                        +--------+   |");
            Console.WriteLine("| |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |                                        |        |   |");
            Console.WriteLine("| +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+                                        |        |   |");
            Console.WriteLine("|                                                                                                               |        |   |");
            Console.WriteLine("| +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+                                        |        |   |");
            Console.WriteLine("| |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |                                        |        |   |");
            Console.WriteLine("| |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |  |  X  |               XXXXXXXXXXXXXXXXX        |      +-+   |");
            Console.WriteLine("| +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+  +-----+               X               X        |        |   |");
            Console.WriteLine("|                                                                                      X               X        |        |   |");
            Console.WriteLine("|                                                                                      X               X        |        |   |");
            Console.WriteLine("|                                                                                      X               X        |        |   |");
            Console.WriteLine("+---------------------------------------------------------------------------------------------------------------+--------+---+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");

            //hall
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|       +--------+                   +--------+                 +--------+                             +--------+            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("|       |      +-+                   |      +-+                 |      +-+                             |      +-+            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("|       |        |                   |        |                 |        |                             |        |            |");
            Console.WriteLine("+-------+--------+-------------------+--------+-----------------+--------+-----------------------------+--------+------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");


            //dining room
            Console.WriteLine("+-------------+-------------------------------------------------------------------------------------------+------------------+");
            Console.WriteLine("|             |                                                                                           |                  |");
            Console.WriteLine("|             |                                             +------------------------+                    |                  |");
            Console.WriteLine("|             |                                             |      %%% %%%%%%%       |                    |                  |");
            Console.WriteLine("|             |                                             |     %%%% %%%%%%%%%%%   |                    |                  |");
            Console.WriteLine("|             |                 XX     XX                   |   %%%%% %         %%%  |        +-----+     |                  |");
            Console.WriteLine("|             |                   XX XX                     |  %%%%% %   @    @   %% |        |     |     |                  |");
            Console.WriteLine("|             |       X             X              X        | %%%%%% % (_  ()  )  %% |        |     |     |                  |");
            Console.WriteLine("|             |       X             X              X        | %%  %%% %          %%  |        |     |     |                  |");
            Console.WriteLine("|             |       X     XXXXXXXXXXXXXXXXXX     X        | %    %%%% %  uvuuu %%  |        |   +-+     |                  |");
            Console.WriteLine("|             |       X        X          X        X        |       %%%% %%%%%%%%%   |        |     |     |                  |");
            Console.WriteLine("|             |       XXXXXX   X          X   XXXXXX        +------------------------+        |     |     |                  |");
            Console.WriteLine("|             |       X    X   X          X   X    X                                          |     |     |                  |");
            Console.WriteLine("|             |       X    X   X          X   X    X                                          |     |     |                  |");
            Console.WriteLine("+-------------+-------------------------------------------------------------------------------+-----+-----+------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");




            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            

            //basement
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|       8             8aba    aYa                                                                                            |");
            Console.WriteLine("|       8             8  aba    aYa                                                                                          |");
            Console.WriteLine("|       8      aaaaaa88a   aba    aYa                                                ================================        |");
            Console.WriteLine("|       8      8aba    aYa   a8aaaaaaa                                                ||    || ^(.)<||>(.)^ ||    ||         |");
            Console.WriteLine("|       8      8  aba    aYa  8       8                                               ||    ||      ||      ||    ||         |");
            Console.WriteLine("|       8aaaaaa8a   aba    aYa8       8                                               ||  (__D      ||      C__)  ||         |");
            Console.WriteLine("|       8aba    aYa   a8aaaaaaa       8                                               ||  (__D      ||      C__)  ||         |");
            Console.WriteLine("|       8  aba    aYa  8              8                                               ||  (__D      ||      C__)  ||         |");
            Console.WriteLine("|       8a   aba    aYa8              8                                               ||  (__D      ||      C__)  ||         |");
            Console.WriteLine("|        aYa   a8aaaaaaa              8                                               ||    ||      ||      ||    ||         |");
            Console.WriteLine("|          aYa  8                     8                                              ================================        |");
            Console.WriteLine("|            aYa8                     8                                                                                      |");
            Console.WriteLine("|             aaaaaaaaaaaaaaaaaaaaaaaa8                                                                                      |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------+");


           







        }
    }
}
