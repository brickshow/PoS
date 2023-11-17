using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampagoFinalPro
{

    internal class ItemsStorage
    {
        static int selectedRow = 0;
        static int selectedColumn = 0;
        //3d array for items
        string[,,] itemsCoffee;

        // Class constructor
        public ItemsStorage()
        {
            // Initialize the static 3D array values
            itemsCoffee = new string[,,] {
            {
                {"[1] --> Espresso  ","             [7] --> Latte/Iced Latte","             [13] --> Black Coffee"},
                {"[2] --> Mocha     ","             [8] --> Americano       ","             [14] --> Cappuccino"},
                {"[3] --> Flat White","             [9] --> Cafe au Lait    ","             [15] --> Macchiato"}
            },
            {
                {"[4] --> Cold Brew","             [10] --> Cold Brew", "             [16] --> Frappe"},
                {"[5] --> Vietnamese Coffee", "     [11] --> Affogato", "                     [17] --> Red Eye "},
                {"[6] --> Australian Coffee", "     [12] --> Jamaican Coffee", "             [18] --> Coffee milk"}
            }
        };
        }

        // Method to print the entire 3D array
        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\t\t╔════════════════════════《*》════════════════════════╗");
            Console.WriteLine(@"                                ║  ▄▄▄▄▄ ▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄   ▄▄▄▄▄ ▄▄▄▄  ║
                                ║ █─▄▄▄─█─▄▄─█▄─▄▄─█▄─▄▄─█▄─▄▄─█▄─▄▄─█ █─▄▄▄─█─▄▄─█ ║
                                ║ █─███▀█─██─██─▄████─▄████─▄█▀██─▄█▀█ █─███▀█─██─█ ║
                                ║ ▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀ ▀▄▄▄▄▄▀▄▄▄▄▀ ║");
            Console.WriteLine("╔═══════════════════════════════╚════════════════════════《*》════════════════════════╝══════════════════════════════╗"); Console.WriteLine();
            for (int i = 0; i < itemsCoffee.GetLength(1); i++)
            {
                for (int j = 0; j < itemsCoffee.GetLength(2); j++)
                {
                    if (i == selectedRow && j == selectedColumn)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.Write(itemsCoffee[0, i, j].PadRight(15));

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            keyMenuChoices();
        }

        public void greetings()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string wordAnimate1 = "Hello Good day, Welcome to Coffee co online coffee shop";
            string wordAnimate2 = "Please select a coffee that you want to order. Thank you";
            string chooseItem = "Use UP and DOWN arrow key to choose Coffee                          ";

            for (int i = 0; i < wordAnimate1.Length; i++)
            {
                // Display the word up to the current letter
                Console.Write(wordAnimate1.Substring(0, i + 1));

                // Pause for a short duration to control the speed of the animation
                Thread.Sleep(50);

                // Move the cursor back to overwrite the existing characters in the console
                Console.SetCursorPosition(Console.CursorLeft - (i + 1), Console.CursorTop);
            }

            for (int i = 0; i < wordAnimate2.Length; i++)
            {
                // Display the word up to the current letter
                Console.Write(wordAnimate2.Substring(0, i + 1));

                // Pause for a short duration to control the speed of the animation
                Thread.Sleep(50);

                // Move the cursor back to overwrite the existing characters in the console
                Console.SetCursorPosition(Console.CursorLeft - (i + 1), Console.CursorTop);
            }

            for (int i = 0; i < chooseItem.Length; i++)
            {
                // Display the word up to the current letter
                Console.Write(chooseItem.Substring(0, i + 1));

                // Pause for a short duration to control the speed of the animation
                Thread.Sleep(50);

                // Move the cursor back to overwrite the existing characters in the console
                Console.SetCursorPosition(Console.CursorLeft - (i + 1), Console.CursorTop);
            }
            // Add a newline at the end
            Console.WriteLine();
        }

        public void keyMenuChoices()
        {
            
            Console.CursorVisible = false;

            ConsoleKeyInfo keyInfo;
            do
            {
                //Console.Clear();

                keyInfo = Console.ReadKey();

                // Handle arrow key presses
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveUp();
                        break;

                    case ConsoleKey.DownArrow:
                        MoveDown();
                        break;

                    case ConsoleKey.LeftArrow:
                        MoveLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        MoveRight();
                        break;
                }

            } while (keyInfo.Key != ConsoleKey.Enter);
        }

        public void MoveUp()
        {
            if (selectedRow > 0)
            {
                selectedRow--;
            }
        }

        public void MoveDown()
        {
            if (selectedRow < itemsCoffee.GetLength(1) - 1)
            {
                selectedRow++;
            }
        }

        public void MoveLeft()
        {
            if (selectedColumn > 0)
            {
                selectedColumn--;
            }
        }

        public void MoveRight()
        {
            if (selectedColumn < itemsCoffee.GetLength(2) - 1)
            {
                selectedColumn++;

            }
        }
    }
}
