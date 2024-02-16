using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal class Battlemenu
    {
        public void PrintBattleMenu()
        {
            Console.WriteLine("Make your selection:\n1: Attack\n2: Items\n3: Block\n4: Surrender\n\nPress esc to go back...");
            while(true)
            {
                if(Console.KeyAvailable) //make sure key is available
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); //see if esc is pressed
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("returning to the previous menu...");
                    }
                    else
                    {
                        switch (key.KeyChar)
                        {
                            case (char)1:
                                Console.WriteLine("You've chosen to attack");
                                //attack logic here
                                return; //gets us out of menu after use
                            case (char)2:
                                Console.WriteLine("You've chosen to use an item");
                                //item logic here
                                return;
                            case (char)3:
                                Console.WriteLine("You've chosen to block");
                                //block logic here
                                return;
                            case (char)4:
                                Console.WriteLine("You've chosen to surrender");
                                //surrender logic here
                                return;
                        }
                    }
                }
            }
        }
    }
}
