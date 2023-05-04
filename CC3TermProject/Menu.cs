using System;
using System.IO;
using System.Text;


namespace TermTest
{
    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        private void MenuOpt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            border();
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string arrow;

                if (i == SelectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    arrow = ">";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    arrow = " ";
                }
                WriteLine($" x                                        {arrow}   {currentOption}");
            }
        }

        private void LeftMenuOpt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            border();
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    prefix = ">";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    prefix = " ";
                }
                WriteLine($" x                                                                              {prefix}    {currentOption}");
            }
        }

        public int Run()
        {
            Clear();
            border();
            ConsoleKey ckey;
            do
            {
                MenuOpt();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                ckey = keyInfo.Key;

                if (ckey == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (ckey == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (ckey != ConsoleKey.Enter);
            return SelectedIndex;
        }
        public int LeftRun()
        {
            Clear();
            border();
            ConsoleKey ck;
            do
            {
                LeftMenuOpt();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                ck = keyInfo.Key;

                if (ck == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (ck == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (ck != ConsoleKey.Enter);
            return SelectedIndex;
        }
        static void border()
        {
            for (int row = 1; row < Console.WindowHeight; row++)
            {
                Console.SetCursorPosition(1, row);
                Console.Write("x");
                Console.SetCursorPosition(Console.WindowWidth - 2, row);
                Console.Write("x");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(1, 1);
            Console.Write("marijuana─blunt─weed─heroin─horse─smack─cocaine─coke─crack─ecstacy─mdma─molly─flakka─gravel─krokodil─morphine─lsd─blotter─acid─meth─crank─mushrooms─boomers─salvia─magicmint─spice─bliss─rocks─smacked");
            Console.SetCursorPosition(1, Console.WindowHeight - 2);
            Console.Write("\n smacked─rocks─bliss─spice─magicmint─salvia─boomers─mushrooms─crank─meth─acid─blotter─lsd─morphine─krokodil─gravel─flakka─molly─mdma─ecstacy─crack─coke─cocaine─smack─horse─heroin─weed─blunt─marijuana");
            Console.SetCursorPosition(0, 0);
        }
    }
}