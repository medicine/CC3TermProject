// Programmer: Daquioag, Andrew Neil T.
// Date: 11/27/22 - 05/01/23
// Hours: 117
// Course and Section: BSCS 1-1

global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Text;
global using System.Runtime.InteropServices;
global using static System.Console;

namespace TermTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 200;
            Console.WindowHeight = 50;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
            PanelMenu panelmenu = new PanelMenu();
            panelmenu.Start();
        }
    }
}