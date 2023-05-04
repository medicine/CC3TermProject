using System;
using System.IO;
using System.Text;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;

namespace TermTest
{
    class ModulePanel
    {
        public void RunModuleMachine()
        {
            PanelMenu panelmenu = new PanelMenu();
            string prompt = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n x                                                                                                                          \r\n x                                                                                         ^:                ^:             \r\n x                                              ~PP^        !PG5:                        :G@@7             ~B@&7            \r\n x                                             7@@@~ ~7:  ~B&#@@5                       :B@@@~             P@@@5            \r\n x                                            !@@@G.Y@@? J@P^P@@Y    ::...              5@@@P          .  :&@@@!   :7J7.    \r\n x                                           .B@@@75@G@?Y@? !@@@?  !G&@#BBBJ.    .7YP5JY@@@@!  !J!    !#7 ~@@@#:  ?&@PBB.   \r\n x                                           7@@@#G@77@&&! .B@@@~ ?@@@B?^^Y@P   !#@@@@@@@@@B. J@@&:  ~&@~ 7@@@G  ?@@G J@~   \r\n x                                           5@@@@@5 :GG~  7@@@#:^&@@B:   :#@^ !&@@Y:P@@@@@5 ^&@@G  ^#@B. 7@@@5 :&@@J~&P.   \r\n x                                           G@@@@#:       G@@@G 7@@@Y    ^&#..B@@G ~@&#@@@? J@@@Y :#@@Y  !@@@Y 7@@@#BY. ^: \r\n x                                          .B@@@@7       :#@@@5 ~@@@P   ^B@J ^&@@J G@?7@@@7 5@@@?^#GP@J  ^&@@J 7@@@5. :5@Y \r\n x                                           Y@@@P        :#@@@?  Y@@@Y!5@@J  :&@@P5@P :#@@? !@@@&@G.!@#^ .B@@J .P@@@5P@@5. \r\n x                                           .YGY:         Y@@@J   !P#@&#5^    ?@@@@P.  !B@P  !G#BJ.  !57  7@@?  .7P##B5~   \r\n x                                                          7YY^     .::        ^77^     .^.    .           ^~.     ..      \r\n\r\n\r\n\r\n\n\n";
            string[] options = { "Module 1.1 - 1.10", "Module 2.1 - 2.10", "Module 3.1 - 3.10", "Module 4.1 - 4.10", "Module 5.1 - 5.10", "Module 6.1 - 6.10\n", "Return" };
            Menu RunModuleMachine = new Menu(prompt, options);
            border();
            int selectedIndex = RunModuleMachine.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
                case 1:
                    Module2();
                    break;
                case 2:
                    Module3();
                    break;
                case 3:
                    Module4();
                    break;
                case 4:
                    Module5();
                    break;
                case 5:
                    Module6();
                    break;
                case 6:
                    panelmenu.RunMenu();
                    break;
            }
            ReturnModulePanel();
        }

        public void Module1()
        {
            CursorVisible = false;
            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                            Select Module [1] \n";
            string[] options = { "Module 1.1 (Volume of Sphere)", "Module 1.2 (Temp Conversion)", "Module 1.3 (Peso-Dollar Conversion)", "Module 1.4 (Measurement Conversion)", "Module 1.5 (Two Variables)", "Module 1.6 (Circumference of a circle)", "Module 1.7 (Three variables declaration)", "Module 1.8 (Purchase Price)", "Module 1.9 (Economic order quantity)", "Module 1.10 (Radius of a circle)\n", "Return"};
            Menu Module1 = new Menu(prompt, options);
            border();
            int selectedIndex = Module1.Run();

            switch (selectedIndex)
            {
                case 0:
                    M11();
                    break;
                case 1:
                    M12();
                    break;
                case 2:
                    M13();
                    break;
                case 3:
                    M14();
                    break;
                case 4:
                    M15();
                    break;
                case 5:
                    M16();
                    break;
                case 6:
                    M17();
                    break;
                case 7:
                    M18();
                    break;
                case 8:
                    M19();
                    break;
                case 9:
                    M110();
                    break;
                case 10:
                    RunModuleMachine();
                    break;
            }
            ReturnModulePanel();
        }
        public void Module2()
        {
            CursorVisible = false;
            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                            Select Module [2]\n";
            string[] options = { "Module 2.1 (Determine Vowel or Consonants)", "Module 2.2 (Determine Date value)", "Module 2.3 (Determine Temperature value)", "Module 2.4 (Determine type of aircraft)", "Module 2.5 (Determine type of ship)", "Module 2.6 (Determine Earthquake range)", "Module 2.7 (Number to word conversion)", "Module 2.8 (Ordinary numbers to roman numerals)", "Module 2.9 (Compute and asses tuition fee)", "Module 2.10 (Grade equivalent)\n", "Return" };
            Menu Module2 = new Menu(prompt, options);
            border();
            int selectedIndex = Module2.Run();

            switch (selectedIndex)
            {
                case 0:
                    M21();
                    break;
                case 1:
                    M22();
                    break;
                case 2:
                    M23();
                    break;
                case 3:
                    M24();
                    break;
                case 4:
                    M25();
                    break;
                case 5:
                    M26();
                    break;
                case 6:
                    M27();
                    break;
                case 7:
                    M28();
                    break;
                case 8:
                    M29();
                    break;
                case 9:
                    M210();
                    break;
                case 10:
                    RunModuleMachine();
                    break;
            }
            ReturnModulePanel();
        }

        public void Module3()
        {
            CursorVisible = false;
            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                            Select Module [3]\n";
            string[] options = { "Module 3.1 (Calculate looping sequence number)", "Module 3.2 (Produce Number sequence)", "Module 3.3 (Produce number sequence (reverse order))", "Module 3.4 (Calculate factorial value)", "Module 3.5 (Fibonacci sequence numbers)", "Module 3.6 (Calculate power value)", "Module 3.7 (Sum of square of numbers)", "Module 3.8 (Calculate sum of sequence of numbers)", "Module 3.9 (Reverses input numbers)", "Module 3.10 (Sum of power N)\n", "Return" };
            Menu Module2 = new Menu(prompt, options);
            border();
            int selectedIndex = Module2.Run();

            switch (selectedIndex)
            {
                case 0:
                    M31();
                    break;
                case 1:
                    M32();
                    break;
                case 2:
                    M33();
                    break;
                case 3:
                    M34();
                    break;
                case 4:
                    M35();
                    break;
                case 5:
                    M36();
                    break;
                case 6:
                    M37();
                    break;
                case 7:
                    M38();
                    break;
                case 8:
                    M39();
                    break;
                case 9:
                    M40();
                    break;
                case 10:
                    RunModuleMachine();
                    break;
            }
            ReturnModulePanel();
        }

        public void Module4()
        {
            CursorVisible = false;
            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                            Select Module [4]\n";
            string[] options = { "Module 4.1 (Area of a Circle)", "Module 4.2 (Inches to centimeters)", "Module 4.3 (Fahrenheit into Celsius degree)", "Module 4.4 (Celsius into Fahrenheit degree)", "Module 4.5 (Fibonacci series numbers)", "Module 4.6 (Power value of a number)", "Module 4.7 (Sum of the squares)", "Module 4.8 (Calculates the sum of the sequence number)", "Module 4.9 (Peso – Dollar conversion)", "Module 4.10 (Sum of powers)\n", "Return" };
            Menu Module2 = new Menu(prompt, options);
            border();
            int selectedIndex = Module2.Run();

            switch (selectedIndex)
            {
                case 0:
                    M41();
                    break;
                case 1:
                    M42();
                    break;
                case 2:
                    M43();
                    break;
                case 3:
                    M44();
                    break;
                case 4:
                    M45();
                    break;
                case 5:
                    M46();
                    break;
                case 6:
                    M47();
                    break;
                case 7:
                    M48();
                    break;
                case 8:
                    M49();
                    break;
                case 9:
                    M410();
                    break;
                case 10:
                    RunModuleMachine();
                    break;
            }
            ReturnModulePanel();
        }

        public void Module5()
        {
            CursorVisible = false;
            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                            Select Module [5]\n";
            string[] options = { "Module 5.1 (Calculate sum and average of numbers)", "Module 5.2 (Determine lowest value)", "Module 5.3 (One-dimension array accept five numbers)", "Module 5.4 (Two-dimension array determine ODD nos.)", "Module 5.5 (Search Number)", "Module 5.6 (Two-dimension sum and average of nos.)", "Module 5.7 (Two-dimension Highest-Lowest Number)", "Module 5.8 (Two-dimension ODD or Even Number)", "Module 5.9 (Two-dimension sum of row and column)", "Module 5.10 (Search Number)\n", "Return" };
            Menu Module2 = new Menu(prompt, options);
            border();
            int selectedIndex = Module2.Run();

            switch (selectedIndex)
            {
                case 0:
                    M51();
                    break;
                case 1:
                    M52();
                    break;
                case 2:
                    M53();
                    break;
                case 3:
                    M54();
                    break;
                case 4:
                    M55();
                    break;
                case 5:
                    M56();
                    break;
                case 6:
                    M57();
                    break;
                case 7:
                    M58();
                    break;
                case 8:
                    M59();
                    break;
                case 9:
                    M510();
                    break;
                case 10:
                    RunModuleMachine();
                    break;
            }
            ReturnModulePanel();
        }

        public void Module6()
        {
            CursorVisible = false;
            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                            Select Module [6]\n";
            string[] options = { "Module 6.1 (Code Program)", "Module 6.2 (Code Program reverse)", "Module 6.3 (String Palindrome)", "Module 6.4 (String substitution program 1)", "Module 6.5 (String substitution program 2)", "Module 6.6 (Display Capital)", "Module 6.7 (Display Country)", "Module 6.8 (Currency Program)", "Module 6.9 (Noun program)", "Module 6.10 (Noun program)\n", "Return" };
            Menu Module2 = new Menu(prompt, options);
            border();
            int selectedIndex = Module2.Run();

            switch (selectedIndex)
            {
                case 0:
                    M61();
                    break;
                case 1:
                    M62();
                    break;
                case 2:
                    M63();
                    break;
                case 3:
                    M64();
                    break;
                case 4:
                    M65();
                    break;
                case 5:
                    M66();
                    break;
                case 6:
                    M67();
                    break;
                case 7:
                    M68();
                    break;
                case 8:
                    M69();
                    break;
                case 9:
                    M610();
                    break;
                case 10:
                    RunModuleMachine();
                    break;
            }
            ReturnModulePanel();
        }

        public void M11()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            double num1 = 4, num2 = 3;
            double vol, pie = 3.1416, rad;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Create a program to compute the volume of a sphere. Use the formula: V= (4/3)*r 3 where  is equal to 3.1416 approximately.\n                                        The variable r is the radius. Display the volume of a sphere.\n");
            Console.WriteLine("                                        Input the value of Radius: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            rad = Convert.ToDouble(Console.ReadLine());

            vol = (num1 / num2) * pie * rad * rad * rad;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {num1} / {num2} x {pie} x {rad} x {rad} x {rad} = {vol}\n                                          Volume: {vol}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M12()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            double celsius, fahrenheit;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that converts the input Celsius degree into its equivalent Fahrenheit degree. Use the formula: F= (9/5)*C+32.\n");
            Console.WriteLine("                                        Input the value of Celsius: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {celsius} x 9 / 5 + 32 = {fahrenheit}\n                                          Fahrenheit: {fahrenheit}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M13()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            double usd, php, v = 53.95;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that converts the input dollar to its peso exchange rate equivalent.\n                                        Assume that the present exchange rate is 53.95 pesos against the dollar. Then display the peso equivalent exchange rate.\n");
            Console.WriteLine("                                        US Dollar: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            usd = Convert.ToDouble(Console.ReadLine());

            php = usd * v;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {usd} x {v} = {php}\n                                          Philippine Peso: {php}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M14()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            double inch, cm, v = 2.54;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that converts an input inch(es) into its equivalent centimeters. Take note that one inch is equivalent to 2.54 cms.\n");
            Console.WriteLine("                                        Input the value of Inches: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            inch = Convert.ToDouble(Console.ReadLine());

            cm = inch * v;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {inch} x {v} = {cm}\n                                          Centimeters: {cm}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M15()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            int x, y, z;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that exchanges the value of two variables : x and y.\n                                        The output must be: The value of variable y will become the value of variable x, and vise versa.\n");
            Console.WriteLine("                                        Input the value of X: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("                                        Input the value of Y: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            y = Convert.ToInt16(Console.ReadLine());

            z = x;
            x = y;
            y = z;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          X and Y alternated each other.\n                                          Value of X: {x} now, ({y}) earlier.\n                                          Value of Y: {y} now, ({x}) earlier.\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M16()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            double pi = 3.1416, c = 2, rad;
            int num;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Design a program to find the circumference of a circle.\n                                        Use the formula: C=2r, where  is approximately equivalent to 3.1416.\n");
            Console.WriteLine("                                        Input the radius of circle: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            num = Convert.ToInt16(Console.ReadLine());

            rad = c * pi * num;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {c} x {pi} x {num} = {rad}\n                                          Circumference: {rad}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M17()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            int x, y;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        You can solve the worded-problem number 5 with the use of three variables declaration.\n                                        Now try to solve it with only two variables declaration.\n                                        Formulate with an equation that exchanges the value of variable x and y.\n\n                                        The hint is: use 3 equations that involve with plus and minus operations.\n");
            Console.WriteLine("                                        Input the value of X: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("                                        Input the value of Y: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            y = Convert.ToInt16(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          X and Y alternated each other.\n                                          Value of X: {x} now, ({y}) earlier.\n                                          Value of Y: {y} now, ({x}) earlier.\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M18()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            int d, p, s, y;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that takes as input the purchase price of an item (P),\n                                         its expected number of years of service (Y) and its expected salvage value (S)\n                                        Then outputs the yearly depreciation for the item (D). Use the formula: D= (P-S)/Y\n");
            Console.WriteLine("                                        Item Purchase Price: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            p = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("                                        Years of Service: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("                                        Expected Salvage Value: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            s = Convert.ToInt16(Console.ReadLine());

            d = (p - s) / y;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {p} - {s} / {y} = {d}\n                                          Item Yearly Depreciation: {d}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M19()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            double eoq = 0, s, r, i;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Determine the most economical quantity to be stocked for each product that a manufacturing company has in its inventory.\n                                        This quantity, called economic order quantity (EOQ) is calculated as follows: EOQ= sqrt (2RS) / I\n");
            Console.WriteLine("                                        Yearly Production Requirement: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            r = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("                                        Setup cost per order: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            s = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("                                        Inventory carrying cost per unit: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            i = Convert.ToInt16(Console.ReadLine());

            eoq = Math.Sqrt(2 * r * s) / i;

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Square root of ({2} x {r} x {s}) / {i} = {eoq}\n                                          Economic Order Quantity: {eoq}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M110()
        {
            Clear();
            border();
            Console.CursorVisible = true;
            double area, pi = 3.1416, rad;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program to compute the radius of a circle.\n                                        Derive your formula from the given equation: A=r2, then display the output.\n");
            Console.WriteLine("                                        Enter Area of Circle: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            area = Convert.ToDouble(Console.ReadLine());

            rad = Math.Sqrt(area / pi);

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Square root of ({area} / {pi}) = {rad}\n                                          Radius: {rad}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module1();
                    break;
            }
        }
        public void M21()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                char letter;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that determines if the input letter is a VOWEL or CONSONANT.\n                                        The vowels are: A E I O U. Your program must be able to handle a capital or small input letter\n");
                Console.WriteLine("                                        Enter an alphabet letter (A-Z or a-z): ");
                Console.CursorLeft = Console.WindowWidth / 5;
                string input = Console.ReadLine();
                if (input.Length == 1 && Char.IsLetter(input[0]))
                {
                    letter = Convert.ToChar(input);

                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
                    letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                    {
                        Console.CursorVisible = false;
                        string vowel = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          The alphabet is made up of 26 letters, 5 of which are vowels (a, e, i, o, u) and the rest of which are consonants.\n\n                                          Great! The letter {letter} is a vowel :)\n";
                        string[] vopt = { "Return" };
                        Menu vo = new Menu(vowel, vopt);
                        int v = vo.Run();
                        switch (v)
                        {
                            case 0:
                                Module2();
                                break;
                        }
                    }
                    else
                    {
                        Console.CursorVisible = false;
                        string vowel = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          The alphabet is made up of 26 letters, 5 of which are vowels (a, e, i, o, u) and the rest of which are consonants.\n\n                                          Great! The letter {letter} is a consonant :)\n";
                        string[] vopt = { "Return" };
                        Menu vo = new Menu(vowel, vopt);
                        int v = vo.Run();
                        switch (v)
                        {
                            case 0:
                                Module2();
                                break;
                        }
                    }
                }
            }
        }
        public void M22()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int m;
                int d;
                int y;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that accepts dates written in numerical form and then output them as a complete form.\n                                        For example, the input: 2 26 1986 should produce the output: February 26, 1986\n");
                Console.WriteLine("                                        Input Date (M DD YYYY): ");
                Console.CursorLeft = Console.WindowWidth / 5;
                var line = Console.ReadLine();
                var data = line.Split(' ');
                m = int.Parse(data[0]);
                d = int.Parse(data[1]);
                y = int.Parse(data[2]);

                switch (m)
                {
                    case 1:
                        Console.CursorVisible = false;
                        string jan = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          January {d}, {y}\n";
                        string[] january = { "Return" };
                        Menu Month1 = new Menu(jan, january);
                        int jan1 = Month1.Run();
                        Module2(); break;
                    case 2:
                        Console.CursorVisible = false;
                        string feb = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          February {d}, {y}\n";
                        string[] february = { "Return" };
                        Menu Month2 = new Menu(feb, february);
                        int feb1 = Month2.Run();
                        Module2(); break;
                    case 3:
                        Console.CursorVisible = false;
                        string mar = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          March {d}, {y}\n";
                        string[] march = { "Return" };
                        Menu Month3 = new Menu(mar, march);
                        int mar1 = Month3.Run();
                        Module2(); break;
                    case 4:
                        Console.CursorVisible = false;
                        string apr = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          April {d}, {y}\n";
                        string[] april = { "Return" };
                        Menu Month4 = new Menu(apr, april);
                        int apr1 = Month4.Run();
                        Module2(); break;
                    case 5:
                        Console.CursorVisible = false;
                        string my = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          May {d}, {y}\n";
                        string[] may = { "Return" };
                        Menu Month5 = new Menu(my, may);
                        int may1 = Month5.Run();
                        Module2(); break;
                    case 6:
                        Console.CursorVisible = false;
                        string jun = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          June {d}, {y}\n";
                        string[] june = { "Return" };
                        Menu Month6 = new Menu(jun, june);
                        int jun1 = Month6.Run();
                        Module2(); break;
                    case 7:
                        Console.CursorVisible = false;
                        string jul = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          July {d}, {y}\n";
                        string[] july = { "Return" };
                        Menu Month7 = new Menu(jul, july);
                        int jul1 = Month7.Run();
                        Module2(); break;
                    case 8:
                        Console.CursorVisible = false;
                        string aug = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          August {d}, {y}\n";
                        string[] august = { "Return" };
                        Menu Month8 = new Menu(aug, august);
                        int aug1 = Month8.Run();
                        Module2(); break;
                    case 9:
                        Console.CursorVisible = false;
                        string sep = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          September {d}, {y}\n";
                        string[] september = { "Return" };
                        Menu Month9 = new Menu(sep, september);
                        int sep1 = Month9.Run();
                        Module2(); break;
                    case 10:
                        Console.CursorVisible = false;
                        string oct = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          October {d}, {y}\n";
                        string[] october = { "Return" };
                        Menu Month10 = new Menu(oct, october);
                        int oct1 = Month10.Run();
                        Module2(); break;
                    case 11:
                        Console.CursorVisible = false;
                        string nov = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          November {d}, {y}\n";
                        string[] november = { "Return" };
                        Menu Month11 = new Menu(nov, november);
                        int nov1 = Month11.Run();
                        Module2(); break;
                    case 12:
                        Console.CursorVisible = false;
                        string dec = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          December {d}, {y}\n";
                        string[] december = { "Return" };
                        Menu Month12 = new Menu(dec, december);
                        int dec1 = Month12.Run();
                        Module2(); break;
                    default:
                        Console.WriteLine("Invalid! Please try again.");
                        break;
                }

            }
        }
        public void M23()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int temp;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that examines the value of a variable called temp.\n                                        Then display the following messages, depending on the value assigned to temp.\n\n                                        Temperature Message\n\n                                        Less than 0 ICE\n                                        Between 0 and 100 WATER\n                                        Exceeds 100 STEAM\n");
                Console.WriteLine("                                        Enter a temperature to check: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                temp = Convert.ToInt32(Console.ReadLine());

                if (temp < 0)
                {
                    Console.CursorVisible = false;
                    string ice = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {temp} celsius is less than 0 therefore this is considered as Ice.\n";
                    string[] ic = { "Return" };
                    Menu i = new Menu(ice, ic);
                    int icee = i.Run();
                    switch (icee)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else if (temp >= 0 && temp <= 100)
                {
                    Console.CursorVisible = false;
                    string water = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {temp} celsius is between 0 - 100 therefore this is considered as Water.\n";
                    string[] wt = { "Return" };
                    Menu w = new Menu(water, wt);
                    int wat = w.Run();
                    switch (wat)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else
                {
                    Console.CursorVisible = false;
                    string steam = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {temp} celsius exceeds 100 therefore this is considered as Steam.\n";
                    string[] st = { "Return" };
                    Menu s = new Menu(steam, st);
                    int ste = s.Run();
                    switch (ste)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }

            }
        }
        public void M24()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int speed, length;

                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\n\n\n                                        Write a program for the Air Force to label an aircraft as military or\n                                        civilian. The program is to be given the plane’s observed speed in km/h and its estimated length\n                                        in meters. For Planes traveling in excess of 1100 km/h, and longer than 52 meters, you should\n                                        label them as “civilian” aircraft, and shorter such as 500 km/h and 20 meters as “military”\n                                        aircraft. For planes traveling at slower speeds, you will issue an “It’s a bird” message.");
                Console.WriteLine("\n                                        Enter km/h speed of the plane: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                speed = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("                                        Enter length of the plane: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                length = Convert.ToInt32(Console.ReadLine());

                if ((speed > 1100) && (length > 52))
                {
                    Console.CursorVisible = false;
                    string civilian = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {speed} km/h and {length} meters is the estimated L&M for planes therefore this is a 'civilian' aircraft.\n";
                    string[] civil = { "Return" };
                    Menu c = new Menu(civilian, civil);
                    int civ = c.Run();
                    switch (civ)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else if ((speed > 500) && (length > 20))
                {
                    Console.CursorVisible = false;
                    string military = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {speed} km/h and {length} meters is the estimated L&M for planes therefore this is a 'military' aircraft.\n";
                    string[] militar = { "Return" };
                    Menu m = new Menu(military, militar);
                    int mil = m.Run();
                    switch (mil)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else
                {
                    Console.CursorVisible = false;
                    string birdy = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {speed} km/h and {length} meters is not for aircraft so i think this is just a bird.\n";
                    string[] bird = { "Return" };
                    Menu b = new Menu(birdy, bird);
                    int bir = b.Run();
                    switch (bir)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
            }
        }
        public void M25()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                char c;
                Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                                        Write a program that determines the class of the Ship depending on its\n                                        class ID (identifier). Here are the criteria. The class ID serves as the input data and the Ship class\n                                        as the output information.\n\n                                        Class ID Ship Class\n                                        B or b Battleship\n                                        C or c Cruiser\n                                        D or d Destroyer\n                                        F or f Frigate");
                Console.WriteLine("\n                                        Enter class ID to check ship type: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                c = Convert.ToChar(Console.ReadLine().ToUpper());

                if (c == 'B')
                {
                    Console.WriteLine("\n\n\n                                        This is a Battleship.");
                }
                else if (c == 'C')
                {
                    Console.WriteLine("\n\n\n                                        This is a Cruiser.");
                }
                else if (c == 'D')
                {
                    Console.WriteLine("\n\n\n                                        This is a Destroyer.");
                }
                else if (c == 'F')
                {
                    Console.WriteLine("\n\n\n                                        This is a Frigate.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\n                                        You have entered invalid class id, please try again.");
                }
                Console.CursorVisible = false;

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module2();
            }
        }
        public void M26()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                double n;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        The National Earthquake Information Center has the following criteria to determine the earthquake’s damage.\n                                        Here are the given Richter scale criteria and their corresponding characterization.\n                                        The Richter scale serves as the input data and the characterization as output information.\n\n                                        Richter Characterization Numbers (n)\n                                        N - 5.0   Little or no damage\n                                        5.5 - 6.5   Serious damage\n                                        6.5 - 7.5   Disaster\n                                        7.5 above   Catastrophe\n");
                Console.WriteLine("                                        Enter the value of magnitude: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                n = Convert.ToDouble(Console.ReadLine());

                if (n < 5.0)
                {
                    Console.CursorVisible = false;
                    string magnitude = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          This scale has little or no damage.\n";
                    string[] mlevel = { "Return" };
                    Menu ml = new Menu(magnitude, mlevel);
                    int mle = ml.Run();
                    switch (mle)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else if (n >= 5.0 && n <= 5.5)
                {
                    Console.CursorVisible = false;
                    string magnitude = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          This scale has some damage.\n";
                    string[] mlevel = { "Return" };
                    Menu ml = new Menu(magnitude, mlevel);
                    int mle = ml.Run();
                    switch (mle)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else if (n >= 5.5 && n <= 6.5)
                {
                    Console.CursorVisible = false;
                    string magnitude = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          This scale has serious damage.\n";
                    string[] mlevel = { "Return" };
                    Menu ml = new Menu(magnitude, mlevel);
                    int mle = ml.Run();
                    switch (mle)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else if (n >= 6.5 && n <= 7.5)
                {
                    Console.CursorVisible = false;
                    string magnitude = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          This scale is a disaster.\n";
                    string[] mlevel = { "Return" };
                    Menu ml = new Menu(magnitude, mlevel);
                    int mle = ml.Run();
                    switch (mle)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else if (n >= 7.5 && n <= 15)
                {
                    Console.CursorVisible = false;
                    string magnitude = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          This scale is a catastrophe.\n";
                    string[] mlevel = { "Return" };
                    Menu ml = new Menu(magnitude, mlevel);
                    int mle = ml.Run();
                    switch (mle)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
                else
                {
                    Console.CursorVisible = false;
                    string magnitude = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Invalid! Please try again.\n";
                    string[] mlevel = { "Return" };
                    Menu ml = new Menu(magnitude, mlevel);
                    int mle = ml.Run();
                    switch (mle)
                    {
                        case 0:
                            Module2();
                            break;
                    }
                }
            }
        }
        public void M27()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that accepts a number and outputs its equivalent in words.\n                                        Enter a number: 1380 Output: One Thousand Three Hundred Eighty Take note that the maximum input number is 3000.\n");
                Console.WriteLine("                                        Input value to convert in words: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                int n = int.Parse(Console.ReadLine());

                if (n > 3000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                                        Invalid input. Number must be between 1 and 3000.\n");
                    Console.CursorVisible = false;
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    M27();
                }

                Console.Write("                                        Output: ");

                int t = n / 1000;
                int h = (n / 100) % 10;
                int e = (n / 10) % 10;
                int o = n % 10;

                switch (t)
                {
                    case 1:
                        Console.Write("One Thousand ");
                        break;
                    case 2:
                        Console.Write("Two Thousand ");
                        break;
                    case 3:
                        Console.Write("Three Thousand ");
                        break;
                }

                switch (h)
                {
                    case 1:
                        Console.Write("One Hundred ");
                        break;
                    case 2:
                        Console.Write("Two Hundred ");
                        break;
                    case 3:
                        Console.Write("Three Hundred ");
                        break;
                    case 4:
                        Console.Write("Four Hundred ");
                        break;
                    case 5:
                        Console.Write("Five Hundred ");
                        break;
                    case 6:
                        Console.Write("Six Hundred ");
                        break;
                    case 7:
                        Console.Write("Seven Hundred ");
                        break;
                    case 8:
                        Console.Write("Eight Hundred ");
                        break;
                    case 9:
                        Console.Write("Nine Hundred ");
                        break;
                }

                if (h != 0 && (e != 0 || o != 0))
                {
                    Console.Write("and ");
                }

                switch (e)
                {
                    case 2:
                        Console.Write("Twenty ");
                        break;
                    case 3:
                        Console.Write("Thirty ");
                        break;
                    case 4:
                        Console.Write("Forty ");
                        break;
                    case 5:
                        Console.Write("Fifty ");
                        break;
                    case 6:
                        Console.Write("Sixty ");
                        break;
                    case 7:
                        Console.Write("Seventy ");
                        break;
                    case 8:
                        Console.Write("Eighty ");
                        break;
                    case 9:
                        Console.Write("Ninety ");
                        break;
                }

                if (e > 1)
                {
                    switch (o)
                    {
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                    }
                }
                Console.CursorVisible = false;

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.WriteLine("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module2();
            }
        }
        public void M28()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that accepts an ordinary number and outputs its equivalent Roman numerals.\n");
                Console.WriteLine("                                        Input value to convert in Roman Numerals (1-3000): ");
                Console.CursorLeft = Console.WindowWidth / 5;
                int num = int.Parse(Console.ReadLine());

                if (num < 1 || num > 3000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                                          Invalid input. Number must be between 1 and 3000.\n");
                    Console.CursorVisible = false;
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    M28();
                }

                string n = "";

                int[] v = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] r = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

                for (int i = 0; i < v.Length; i++)
                {
                    while (num >= v[i])
                    {
                        n += r[i];
                        num -= v[i];
                    }
                }

                Console.WriteLine("\n                                        The equivalent Roman numeral is: " + n);
                Console.CursorVisible = false;

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Module2();
            }
        }
        public void M29()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int tf, mop, total;
                int cash, two, three;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that computes and assesses the tuition fee of the students in one trimester,\n                                        based on the given mode of payment below:\n\n                                        Plan (key) Discount (-) or Interest (+)\n                                        Cash (1) 10 % discount\n                                        Two-Installment (2) 5 % discount\n                                        Three-Installment(3) 10 % interest\n");
                Console.WriteLine("                                        Enter Tuition Fee: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                tf = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n                                        Mode of Payment: ");
                Console.WriteLine("\n                                        [1] Cash (10% Discount)\n                                        [2] Two Installment (5% Discount) \n                                        [3] Three Installment (5% Interest)\n");
                Console.CursorLeft = Console.WindowWidth / 5;
                mop = Convert.ToInt32(Console.ReadLine());

                cash = (int)(tf - (tf * 0.10));
                two = (int)(tf - (tf * 0.05));
                three = (int)(tf + (tf * 0.10));

                switch (mop)
                {
                    case 1: Console.WriteLine("\n                                        You chose to pay by Cash, 10% Discount will be added now.\n\n                                        Your total tuition fee is: " + cash); break;
                    case 2: Console.WriteLine("\n                                        You chose to pay by Two Installment, 5% Discount will be added now.\n\n                                        Your total tuition fee is: " + two); break;
                    case 3: Console.WriteLine("\n                                        You chose to pay by Three Installment, 5% Interest will be added now.\n\n                                        Your total tuition fee is: " + three); break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                                        Invalid! Please try again.");
                        break;
                }
                Console.CursorVisible = false;

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Module2();
            }
        }
        public void M210()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int gr;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that accepts an input grade in percentile form and output its grade equivalent.\n");
                Console.WriteLine("                                        Enter your percentile grade to calculate point scale: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                gr = Convert.ToInt32(Console.ReadLine());

                if (gr >= 98 && gr <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n                                        Your point scale is 1.00");
                }
                else if (gr >= 95 && gr <= 97)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n                                        Your point scale is 1.25");
                }
                else if (gr >= 92 && gr <= 94)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n                                        Your point scale is 1.50");
                }
                else if (gr >= 89 && gr <= 91)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n                                        Your point scale is 1.75");
                }
                else if (gr >= 85 && gr <= 88)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n                                        Your point scale is 2.00");
                }
                else if (gr >= 82 && gr <= 84)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n                                        Your point scale is 2.25");
                }
                else if (gr >= 80 && gr <= 81)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                                        Your point scale is 2.50");
                }
                else if (gr >= 77 && gr <= 79)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                                        Your point scale is 2.75");
                }
                else if (gr >= 75 && gr <= 76)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n                                        Your point scale is 3.00");
                }
                else
                {
                    Console.CursorVisible = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                                        You have entered invalid grade, please try again.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(1000);
                    M210();
                }
                Console.CursorVisible = false;

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module2();
            }
        }

        public void M31()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int n, i = 0;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that calculates and produces these two columns sequence numbers using the three looping statements:\n\n                                        Sequence nos. Squared\n                                        1             1\n                                        2             4\n                                        3             9                                                                                                                                                 \r\n                                        4             16\n                                        5             25\n");
                Console.WriteLine("                                        Enter a number to get sequence & squared numbers: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                n = Convert.ToInt32(Console.ReadLine());

                Console.CursorVisible = false;
                Console.Clear();

                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");

                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("                                        {0}   {1}", i, (i * i));
                }

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");

                int j = 1;
                while (j <= n)
                {
                    Console.WriteLine("                                        {0}   {1}", j, (j * j));
                    j++;
                }

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");

                int k = 1;
                do
                {
                    Console.WriteLine("                                        {0}   {1}", k, (k * k));
                    k++;
                }
                while (k <= n);

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }

        public void M32()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int i, n;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program which produces the given sequence nos. (in alternate arrangement) using the three looping statements:                                           \r\n                                        1, 5, 2, 4, 3, 3, 4, 2, 5, 1,\n");
                Console.WriteLine("                                        Enter a number to convert in sequence: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                n = Convert.ToInt32(Console.ReadLine());

                Console.CursorVisible = false;
                Console.Clear();

                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");

                for (i = 1, n = 5; i < 6; i++, n--)
                    if (i == 1)
                        Console.Write("                                        {0},{1}", i, n);
                    else
                        Console.Write(",{0},{1}", i, n);
                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");

                int a = 0;
                int b = 5;

                while (++a < 6)
                {
                    if (a == 1)
                        Console.Write("                                        {0},{1}", a, b);
                    else
                        Console.Write(",{0},{1}", a, b);
                    b--;
                }
                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");

                int x = 1;
                int y = 5;
                do
                {
                    if (x == 1)
                        Console.Write("                                        {0},{1}", x, y);
                    else
                        Console.Write(",{0},{1}", x, y);
                    y--;
                }
                while (++x < 6);

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }

        public void M33()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int i, n;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program which produces the given sequence nos. (in alternate arrangement) using the three looping statements:                                           \r\n                                        5, 1, 4, 2, 3, 3, 2, 4, 1, 5\n");
                Console.WriteLine("                                        Enter a number to convert in sequence (alternate): ");
                Console.CursorLeft = Console.WindowWidth / 5;
                i = Convert.ToInt32(Console.ReadLine());

                Console.CursorVisible = false;
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");

                for (i = 1, n = 5; i < 6; i++, n--)
                    if (i == 1)
                    {
                        Console.Write("                                        {0},{1}", n, i);
                    }
                    else
                    {
                        Console.Write(",{0},{1}", n, i);
                    }

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");

                i = 0;
                n = 5;
                while (++i < 6)
                {
                    if (i == 1)
                        Console.Write("                                        {0},{1}", n, i);
                    else
                        Console.Write(",{0},{1}", n, i);
                    n--;
                }
                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");

                i = 1;
                n = 5;
                do
                {
                    if (i == 1)
                    {
                        Console.Write("                                        {0},{1}", n, i);
                    }
                    else
                    {
                        Console.Write(",{0},{1}", n, i);
                    }
                    n--;
                }
                while (++i < 6);

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }
        public void M34()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                int i, n;
                int f = 1;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program to calculate the factorial value of the input number n! Use the incrementation formula ( i++ )                                                  \r\n                                        for your solution instead of decrementation formula (i--) which we had already use and applied in our previous example.\n\n                                        Apply the three looping statements for your solutions:\n                                        Enter a no. 4 Factorial value is: 24 (The computation is: 1*2*3*4=24)\n");
                Console.WriteLine("                                        Enter a number to convert in sequence (alternate): ");
                Console.CursorLeft = Console.WindowWidth / 5;
                n = Convert.ToInt32(Console.ReadLine());

                Console.CursorVisible = false;
                Console.Clear();

                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");
                Console.Write("                                        Solution: ");
                for (i = 1; i <= n; i++)
                {
                    Console.Write(i);
                    f = f * i;

                    if (i >= n)
                        Console.Write(" = " + f);
                    else
                        Console.Write(" * ");
                }
                Console.WriteLine("\n                                        The factorial value of {0} is {1}", n, f);

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");
                Console.Write("                                        Solution: ");
                i = 1;
                int p = 1;
                while (i <= n)
                {
                    Console.Write(i);
                    p = p * i;
                    if (i >= n)
                        Console.Write(" = " + p);
                    else
                        Console.Write(" * ");
                    i++;
                }
                Console.WriteLine("\n                                        The factorial value of {0} is {1}", n, p);

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");
                Console.Write("                                        Solution: ");
                i = 1;
                int o = 1;
                do
                {
                    Console.Write(i);
                    o = o * i;
                    if (i >= n)
                        Console.Write(" = " + o);
                    else
                        Console.Write(" * ");
                    i++;
                } while (i <= n);
                Console.WriteLine("\n                                        The factorial value of {0} is {1}", n, o);

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }
        public void M35()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                string sequence = "";
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                      Write a program that generates and displays the Fibonacci sequence numbers of n (as input).                                                                     \r\n                                        In Fibonacci, the current third number is the sum of two previous numbers.\n\n                                        Apply three solutions using the three loop statements:\n                                        Sample input/output dialogue: Enter a no. 9 Fibonacci series: 1 1 2 3 5 8 13 21 34\n");
                Console.WriteLine("                                        Enter a number to convert in Fibonacci sequence: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                int n = int.Parse(Console.ReadLine());

                Console.CursorVisible = false;
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");

                for (int i = 1, j = 1, k = 0; k < n; k++)
                {
                    sequence += i + ", ";
                    int sum = i + j;
                    i = j;
                    j = sum;
                }
                Console.WriteLine(sequence.PadLeft(70, ' '));
                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");
                sequence = "";
                int a = 1, b = 1, c = 0;
                while (c < n)
                {
                    sequence += a + ", ";
                    int sum = a + b;
                    a = b;
                    b = sum;
                    c++;
                }
                Console.WriteLine(sequence.PadLeft(70, ' '));

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");
                sequence = "";
                int x = 1, y = 1, z = 0;
                do
                {
                    sequence += x + ", ";
                    int sum = x + y;
                    x = y;
                    y = sum;
                    z++;
                } while (z < n);
                Console.WriteLine(sequence.PadLeft(70, ' '));

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }
        public void M36()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that calculates the power value of the input base number and exponent number.                                                                   \r\n                                        Apply three solutions using the three looping statements:\n\n                                        Sample input/output dialogue\n                                        Enter base no. 5 Input data\n                                        Enter exponent no. 3 Second input data                                                                                                                          \r\n                                        Power value: 125 Output value                                                                                                                                   \r\n                                        (The computation is: 53 = 5 * 5 * 5 = 125)                                                                                                                      \r\n");
                Console.WriteLine("                                        Enter number to calculate power: ");

                Console.Write("                                        Input base: ");
                int bn = Convert.ToInt32(Console.ReadLine());
                Console.Write("                                        Input exponent: ");
                int ex = Convert.ToInt32(Console.ReadLine());
                int r = 1;
                Console.CursorVisible = false;
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");

                for (int i = 0; i < ex; i++)
                {
                    r *= bn;
                }
                Console.Write("                                        Power value: " + r);
                Console.WriteLine("\n                                        The computation is: " + bn + "^" + ex + " = " + bn + " * " + bn + " * ... * " + bn + " = " + r);

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");

                r = 1;
                int count = 0;
                while (count < ex)
                {
                    r *= bn;
                    count++;
                }
                Console.Write("                                        Power value: " + r);
                Console.WriteLine("\n                                        The computation is: " + bn + "^" + ex + " = " + bn + " * " + bn + " * ... * " + bn + " = " + r);

                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");

                r = 1;
                count = 0;
                do
                {
                    r *= bn;
                    count++;
                } while (count < ex);
                Console.Write("                                        Power value: " + r);
                Console.WriteLine("\n                                        The computation is: " + bn + "^" + ex + " = " + bn + " * " + bn + " * ... * " + bn + " = " + r);

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }
        public void M37()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program to scan a number n and then output the sum of the squares from 1 to n. Thus, if the input is 4,\n                                        the output should be 30 because : 12 + 22 + 32 + 42 1 + 4 + 9 + 16 = 30\n");
                Console.WriteLine("                                        Enter number to calculate power: \n");

                Console.WriteLine("                                        Enter a number to get sum of squares: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                int n = Convert.ToInt32(Console.ReadLine());

                Console.CursorVisible = false;
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'");

                int s = 0;

                for (int i = 1; i <= n; i++)
                {
                    s += i * i;
                }
                Console.Write($"\n                                        The sum of the squares from 1 to {n} is: {s}\n");
                Console.WriteLine("                                        Solution: 1^2 + 2^2 + ... + " + n + "^2 = " + s);

                Thread.Sleep(1000);
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'");
                
                s = 0;
                int c = 1;
                
                while (c <= n)
                {
                    s += c * c;
                    c++;
                }
                Console.Write($"\n                                        The sum of the squares from 1 to {n} is: {s}\n");
                Console.WriteLine("                                        Solution: 1^2 + 2^2 + ... + " + n + "^2 = " + s);
                Thread.Sleep(1000);
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'");

                s = 0;
                c = 1;

                do
                {
                    s += c * c;
                    c++;
                } while (c <= n);
                Console.Write($"\n                                        The sum of the squares from 1 to {n} is: {s}\n");
                Console.WriteLine("                                        Solution: 1^2 + 2^2 + ... + " + n + "^2 = " + s);

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }
        public void M38()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program to calculate the sum of the sequence no. from 1 to n. Thus if the input is 6,\n                                        the output should be 21 because: (Apply the three looping statements in your solutions) 1 + 2 + 3 + 4 + 5 + 6 = 21\n");
                Console.WriteLine("\n                                        Enter a number to get sum of squares: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                int n = Convert.ToInt32(Console.ReadLine());
                int s = 0;
                string sequence = "";

                Console.CursorVisible = false;
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'");

                for (int i = 1; i <= n; i++)
                {
                    s += i;
                    if (i == n)
                    {
                        sequence += i + " = " + s;
                    }
                    else
                    {
                        sequence += i + " + ";
                    }
                }
                Console.WriteLine(sequence.PadLeft(66, ' '));

                Thread.Sleep(1000);
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'");

                s = 0;
                int c = 1;
                sequence = "";

                while (c <= n)
                {
                    s += c;
                    if (c == n)
                    {
                        sequence += c + " = " + s;
                    }
                    else
                    {
                        sequence += c + " + ";
                    }
                    c++;
                }
                Console.WriteLine(sequence.PadLeft(66, ' '));

                Thread.Sleep(1000);
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'");

                s = 0;
                c = 1;
                sequence = "";

                do
                {
                    s += c;
                    if (c == n)
                    {
                        sequence += c + " = " + s;
                    }
                    else
                    {
                        sequence += c + " + ";
                    }
                    c++;
                } while (c <= n);

                Console.WriteLine(sequence.PadLeft(66, ' '));

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }
        public void M39()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program that reverses the input number n. Formulate an equation to come up with the answer:\n                                        (Apply the three loop statements in your solutions) Sample input/output dialogue:\n\n                                        Enter a number: 1238 Input data\n                                        Reverse number: 8321 Output value\n");
                Console.WriteLine("                                        Enter a number to reverse: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                int n = Convert.ToInt32(Console.ReadLine());

                Console.CursorVisible = false;
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");

                Console.Write("                                        Reverse order is: ");
                int r = 0;

                for (int i = n; i != 0; i /= 10)
                {
                    r = r * 10 + i % 10;
                }
                Console.Write(r);

                Thread.Sleep(1000);
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");

                Console.Write("                                        Reverse order is: ");
                r = 0;
                int temp = n;

                while (temp != 0)
                {
                    r = r * 10 + temp % 10;
                    temp /= 10;
                }
                Console.Write(r);

                Thread.Sleep(1000);
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");

                Console.Write("                                        Reverse order is: ");
                r = 0;
                temp = n;

                do
                {
                    r = r * 10 + temp % 10;
                    temp /= 10;
                } while (temp != 0);
                Console.Write(r);

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }
        public void M40()
        {
            Clear();
            {
                border();
                Console.CursorVisible = true;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Write a program to scan a number n and then output the sum of the powers from 1 to n. Thus, if the input is 4,                                                  \r\n                                        the output should be 288 because: 1 1 + 22 + 33 + 44 1 + 4 + 27 + 256 = 288\n");
                Console.WriteLine("                                        Enter a number to get sum of power: ");
                Console.CursorLeft = Console.WindowWidth / 5;
                int n = int.Parse(Console.ReadLine());
                Console.CursorVisible = false;
                Console.Clear();
                border();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        1st solution - using 'for loop'\n");

                int sum = 0;
                string solution = "";

                for (int i = 1; i <= n; i++)
                {
                    sum += (int)Math.Pow(i, i);
                    solution += i + "^" + i + " + ";
                }

                solution = solution.Remove(solution.Length - 3);
                solution += " = " + sum;
                Console.WriteLine(solution.PadLeft(67, ' '));

                Thread.Sleep(1000);
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        2nd solution - using 'while loop'\n");

                sum = 0;
                solution = "";
                int j = 1;

                while (j <= n)
                {
                    sum += (int)Math.Pow(j, j);
                    solution += j + "^" + j + " + ";
                    j++;
                }

                solution = solution.Remove(solution.Length - 3);
                solution += " = " + sum;
                Console.WriteLine(solution.PadLeft(67, ' '));

                Thread.Sleep(1000);
                Console.Clear();
                border();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        3rd solution - using 'do-while loop'\n");

                sum = 0;
                solution = "";
                int k = 1;

                do
                {
                    sum += (int)Math.Pow(k, k);
                    solution += k + "^" + k + " + ";
                    k++;
                } while (k <= n);

                solution = solution.Remove(solution.Length - 3);
                solution += " = " + sum;
                Console.WriteLine(solution.PadLeft(67, ' '));

                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;

                for (int l = 3; l > 0; l--)
                {
                    Console.CursorLeft = originalLeft;
                    Console.CursorTop = originalTop;
                    Console.Write("\n                                        Returning in " + l + " seconds...");
                    Thread.Sleep(1000);
                }
                Module3();
            }
        }

        public void M41()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            static double AreaOfCircle(double rad)
            {
                double pi = 3.1416;
                double area = pi * rad * rad;
                return area;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.1\n\n                                        Write a function-oriented program to calculate the area of a circle.\n                                        Use the formula: A=r2 where Pi() is equal to 3.1416 (approximately).\n");
            Console.WriteLine("                                        Enter the radius of the circle: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            double rad = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(rad);

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Solution:\n                                          3.1416 x {rad} x {rad} =\n                                          Volume: {area} cm²\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M42()
        {

            Clear();
            border();
            Console.CursorVisible = true;

            static double InchesToCm(double inch)
            {
                return inch * 2.54;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.2\n\n                                        Write a function-oriented program that converts the input inches into its equivalent centimeters.\n                                        One inch is equal to 2.54 cms. Display the converted centimeters value.\n");
            Console.WriteLine("                                        Enter the length in inches: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            double inch = double.Parse(Console.ReadLine());
            double cm = InchesToCm(inch);

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Solution:\n                                          {inch} x 2.54 = \n                                          Centimeters: {cm}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M43()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            static double FahrenToCelsius(double f)
            {
                return (5.0 / 9.0) * (f - 32.0);
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.4\n\n                                        Write a function-oriented program to convert an input Fahrenheit into Celsius degree.\n                                        Use the formula C = (5.0/9.0) * F - 32.0. Display the Celsius degree.\n");
            Console.WriteLine("                                        Enter fahrenheit value: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            double f = double.Parse(Console.ReadLine());
            double c = FahrenToCelsius(f);

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {f}F Fahrenheit is equivalent to \n                                          {c}C Degree Celsius\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M44()
        {

            Clear();
            border();
            Console.CursorVisible = true;

            static double CelsiusToFahren(double c)
            {
                return (9.0 / 5.0 * c) + 32.0;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.4\n\n                                        Write a function-oriented program to convert an input Celsius into Fahrenheit degree.\n                                        Use the formula F = (9.0/5.0) * C + 32. Display the Fahrenheit degree.\n");
            Console.WriteLine("                                        Enter a celsius value: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            double c = double.Parse(Console.ReadLine());
            double f = CelsiusToFahren(c);

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {c}C Degree Celsius is equivalent to \n                                          {f}F Fahrenheit\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }
        public void M45()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            static int FibonacciSeries(int n)
            {
                if (n <= 1)
                {
                    return 1;
                }
                return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.5\n\n                                        Write a function-oriented program that generates the Fibonacci series numbers of n (as input) and display them.\n                                        In Fibonacci, the current third number is the sum of two previous numbers.\n");
            Console.WriteLine("                                        Input a number to convert: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            int n = int.Parse(Console.ReadLine());

            string fib = "";
            for (int i = 0; i < n; i++)
            {
                fib += FibonacciSeries(i) + " ";
            }

            Console.CursorVisible = false;
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          The Fibonacci series up to {n} is:\n                                          {fib}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M46()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            static double CalculatePowerValue(double baseNumber, int exponentNumber)
            {
                double powerValue = 1;

                for (int i = 1; i <= exponentNumber; i++)
                {
                    powerValue *= baseNumber;
                }

                return powerValue;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.6\n\n                                        Write a function-oriented program that calculates the power value of\n                                        the input base number and exponent number. Then display the power value.\n");
            Console.WriteLine("                                        Enter base number: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            double baseNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("                                        Enter exponent number: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            int exponentNumber = int.Parse(Console.ReadLine());

            double powerValue = CalculatePowerValue(baseNumber, exponentNumber);

            Console.CursorVisible = false;
            Console.WriteLine($"Power value: {powerValue}");
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Power value: {powerValue} \n                                          (The computation is {baseNumber}^{exponentNumber} = {string.Join(" * ", Enumerable.Repeat(baseNumber, exponentNumber))} = {powerValue})\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M47()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int SumSquares(int n)
            {
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += i * i;
                }

                return sum;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.7\n\n                                        Write a function-oriented program that calculates the sum of the\n                                        squares from 1 to n. Thus, if the input is 3, the output should be 14 because:\n                                        1^2 + 2^2 + 3^2 = 1 + 4 + 9 = 14\n");
            Console.WriteLine("                                        Enter a number: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            int number = int.Parse(Console.ReadLine());

            Console.CursorVisible = false;
            int sumOfSquares = SumSquares(number);
            string computation = $"({string.Join(" + ", Enumerable.Range(1, number).Select(i => $"{i * i}"))} = {sumOfSquares})";
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          The sum of squares from 1 to {number} is: {sumOfSquares}\n                                          The computation is: {computation}\n";
            string[] options = { "Return" };

            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M48()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int SumSequence(int n)
            {
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                return sum;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.8\n\n                                        Write a function-oriented program that calculates the sum of the\n                                        sequence number from 1 to n. Thus, if the input is 5, the output should be 15 because:\n                                        1 + 2 + 3 + 4 + 5 = 15\n");
            Console.WriteLine("                                        Enter a number: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            int number = int.Parse(Console.ReadLine());

            Console.CursorVisible = false;
            int sumOfSequence = SumSequence(number);

            string computation = string.Join(" + ", Enumerable.Range(1, number)) + $" = {sumOfSequence}";
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          The sum of sequence from 1 to {number} is: {sumOfSequence}\n                                          The computation is: {computation}\n";
            string[] options = { "Return" };

            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M49()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            double ConvertToPesos(double dollars)
            {
                const double pesoRate = 53.80;
                return dollars * pesoRate;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.9\n\n                                        Write a function-oriented program to convert the input dollar(s) into its\n                                        equivalent peso. Assume that one dollar is equivalent to 53.80 pesos.\n");
            Console.WriteLine("                                        Enter the amount in dollars: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            double dollars = double.Parse(Console.ReadLine());

            Console.CursorVisible = false;
            double pesos = ConvertToPesos(dollars);

            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          {dollars:C} is equivalent to {pesos:C} pesos.\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M410()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int CalculateSumOfPowers(int n)
            {
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += (int)Math.Pow(i, 2);
                }

                return sum;
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 4.10\n\n                                        Write a function-oriented program that scans a number n and then\n                                        output the sum of the powers from 1 to n. Thus, if the input is 3, the output should be 14 because:\n                                        1^2 + 2^2 + 3^2 = 1 + 4 + 9 = 14\n");
            Console.WriteLine("                                        Enter a number: ");
            Console.CursorLeft = Console.WindowWidth / 5;
            int number = int.Parse(Console.ReadLine());

            Console.CursorVisible = false;
            int sumOfPowers = CalculateSumOfPowers(number);

            string computation = string.Join(" + ", Enumerable.Range(1, number).Select(i => $"{i * i}")) + $" = {sumOfPowers}";
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          The sum of the powers from 1 to {number} is: {sumOfPowers}\n                                          The computation is: {computation}\n";
            string[] options = { "Return" };

            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module4();
                    break;
            }
        }

        public void M51()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[] values = new int[5];
            int sum = 0;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.1\n\n                                        Write a program using one-dimensional array that calculates the sum\n                                        and average of the five input values from the keyboard and prints the calculated sum and average.\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("                                        Enter a value: ");
                values[i] = int.Parse(Console.ReadLine());
                sum += values[i];
            }

            double average = (double)sum / 5;
            Clear();
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Sum: {string.Join(" + ", values)} = {sum}\n                                          Average: ({string.Join(" + ", values)}) / {values.Length} = {average}\n";
            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M52()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[] values = new int[5];
            int min = int.MaxValue;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.2\n\n                                        Write a program using one-dimensional array that determines the\n                                        lowest value among the five input values typed from the keyboard and prints the difference of\n                                        each value from the lowest.\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("                                        Enter a value: ");
                values[i] = int.Parse(Console.ReadLine());

                if (values[i] < min)
                {
                    min = values[i];
                }
            }

            int[] differences = new int[5];

            for (int i = 0; i < 5; i++)
            {
                differences[i] = values[i] - min;
            }

            Clear();
            string prompt = $"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          The lowest value is: {min}\n\n";

            for (int i = 0; i < 5; i++)
            {
                prompt += $"                                          {values[i]} - {min} = {differences[i]}\n";
            }

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M53()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[] values = new int[5];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.3\n\n                                        Write a program using one-dimensional array that accepts five input values from the keyboard.\n                                        It should also accept a number to search. This number is to be searched if it is among the five input values.\n                                        If it is found, display the message “Searched number is found!”, otherwise display “Search number is lost!”.\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("                                        Enter a value: ");
                values[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\n                                        Enter a number to search: ");
            int searchNumber = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < 5; i++)
            {
                if (values[i] == searchNumber)
                {
                    found = true;
                    break;
                }
            }

            string prompt = found ? "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Searched number is found!\n" : "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Search number is lost!\n";
            Console.WriteLine("                                        {0}", prompt);

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M54()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[,] numbers = new int[1, 12];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.4\n\n                                        Write a program using a two-dimensional array that determines the ODD numbers\n                                        among the 12 input values typed from the keyboard and prints the list of these ODD numbers.\n");

            for (int i = 0; i < 12; i++)
            {
                Console.Write("                                        Enter a number [{0}]: ", i + 1);
                numbers[0, i] = int.Parse(Console.ReadLine());
            }

            string oddNumbersString = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Odd numbers are: ";
            
            for (int i = 0; i < 12; i++)
            {
                if (numbers[0, i] % 2 == 1)
                {
                    oddNumbersString += numbers[0, i] + " ";
                }
            }

            oddNumbersString += "\n";

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(oddNumbersString, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M55()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[,] numbers = new int[1, 12];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.5\n\n                                        Write a program using a two-dimensional array that searches a number\n                                        and displays the number of times it occurs on the list of 12 input values.\n");

            for (int i = 0; i < 12; i++)
            {
                Console.Write("                                        Enter a number [{0}]: ", i + 1);
                numbers[0, i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\n                                        Enter a number to search: ");
            int searchNumber = int.Parse(Console.ReadLine());

            int occurrences = 0;
            string positions = "";

            for (int i = 0; i < 12; i++)
            {
                if (numbers[0, i] == searchNumber)
                {
                    occurrences++;

                    if (positions == "")
                    {
                        positions = ", Array Value [" + (i + 1) + "]";
                    }
                    else
                    {
                        positions += ", [" + (i + 1) + "]";
                    }
                }
            }

            string outputString = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Occurrence(s): " + occurrences.ToString() + "" + positions + "\n";

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(outputString, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M56()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[,] numbers = new int[3, 4];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.6\n\n                                        Write a program using a two-dimensional array that calculates the sum\n                                        and average of the twelve input values which the user would type from the keyboard and prints the calculated sum and average.\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int inputIndex = i * 4 + j + 1;
                    Console.Write("                                        Enter a number [{0}]: ", inputIndex);
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            string sumCalculation = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int number = numbers[i, j];
                    sum += number;

                    if (sumCalculation == "")
                    {
                        sumCalculation += number.ToString();
                    }
                    else
                    {
                        sumCalculation += " + " + number.ToString();
                    }
                }
            }

            double average = (double)sum / 12;
            string averageCalculation = String.Format("{0} / 12", sum);

            string outputString = String.Format("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Sum: {0} ({1})\n                                          Average: {2:F2} ({3})\n", sum, sumCalculation, average, averageCalculation);

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(outputString, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M57()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[,] numbers = new int[1, 12];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.7\n\n                                        Write a program using a two-dimensional array that determines the highest and lowest\n                                        of the 12 input values.\n");

            for (int i = 0; i < 12; i++)
            {
                Console.Write("                                        Enter a number [{0}]: ", i + 1);
                numbers[0, i] = int.Parse(Console.ReadLine());
            }

            int highest = numbers[0, 0];
            int lowest = numbers[0, 0];

            for (int i = 1; i < 12; i++)
            {
                if (numbers[0, i] > highest)
                {
                    highest = numbers[0, i];
                }

                if (numbers[0, i] < lowest)
                {
                    lowest = numbers[0, i];
                }
            }

            string outputString = String.Format("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Highest value: {0}\n                                          Lowest value: {1}\n", highest, lowest);

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(outputString, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M58()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[,] numbers = new int[1, 12];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.8\n\n                                        Write a program using a two-dimensional array that lists the Odd numbers and Even numbers\n                                        separately in a given 12 input values.\n");

            for (int i = 0; i < 12; i++)
            {
                Console.Write("                                        Enter a number [{0}]: ", i + 1);
                numbers[0, i] = int.Parse(Console.ReadLine());
            }

            string oddNumbersString = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Odd numbers are: ";
            string evenNumbersString = "                                          Even numbers are: ";

            for (int i = 0; i < 12; i++)
            {
                if (numbers[0, i] % 2 == 1)
                {
                    oddNumbersString += numbers[0, i] + " ";
                }
                else
                {
                    evenNumbersString += numbers[0, i] + " ";
                }
            }

            oddNumbersString += "\n";
            evenNumbersString += "\n";

            string outputString = oddNumbersString + evenNumbersString;

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(outputString, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M59()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[,] n = new int[3, 3];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.9\n\n                                        Write a program using two-dimensional arrays that computes the sum\n                                        of data in rows and sum of data in columns of the 3x3 (three by three) array variable n[3,3].\n");

            Console.WriteLine("                                        Enter 9 numbers for the 3x3 array:\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"                                        Row [{i},{j}] = ");
                    n[i, j] = int.Parse(Console.ReadLine());
                }
            }

            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Array row with sums:\n\n";
            for (int i = 0; i < 3; i++)
            {
                int sumRow = 0;
                for (int j = 0; j < 3; j++)
                {
                    sumRow += n[i, j];
                }
                prompt += $"                                          {n[i, 0]} {n[i, 1]} {n[i, 2]} = {sumRow}\n";
            }

            int[] sumColumn = new int[3];
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    sumColumn[j] += n[i, j];
                }
            }

            prompt += "                                          -----------------\n";
            prompt += $"                                          {sumColumn[0]} {sumColumn[1]} {sumColumn[2]}\n";

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M510()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            int[] numbers = new int[5];

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 5.10\n\n                                        Write a program using one-dimensional array that searches a number if\n                                        it is found on the list of the given 5 input numbers and locate its exact location in the list.\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("                                        Enter a number [{0}]: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\n                                        Enter a number to be searched: ");
            int searchNumber = int.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    index = i + 1;
                    break;
                }
            }

            string prompt = index != -1 ? "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          " + searchNumber.ToString() + " is found in array value [" + index.ToString() + "].\n" : "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          " + searchNumber.ToString() + " is not found!\n";
            Console.WriteLine("                                          {0}", prompt);

            string[] options = { "Return" };
            Menu ReturnModule = new Menu(prompt, options);
            int selectedIndex = ReturnModule.Run();

            switch (selectedIndex)
            {
                case 0:
                    Module5();
                    break;
            }
        }

        public void M61()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                      Machine Problem 6.1\n\n x                                      Write a program using standard string functions that accepts a price of an item and display its coded value.\n x                                      The base of the key is: X C O M P U T E R S ----- 1 2 3 4 5 6 7 8 9\n\n x                                      Sample input/output dialogue:\n\n x                                      Enter price: 489.50\n x                                      Coded value: PRS.UX\n");

            Console.Write("                                        Enter price: ");
            string price = Console.ReadLine();

            string bk = "XCOMPUTERS123456789";
            string val = "";

            foreach (char c in price)
            {
                if (char.IsDigit(c))
                {
                    int index = int.Parse(c.ToString());
                    val += bk[index];
                }
                else
                {
                    val += c;
                }
            }

            Console.WriteLine("                                          Coded value: " + val);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Coded value: " + val, options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M62()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.2\n\n                                        Write a program using string functions that accepts a coded value of an item and display its equivalent tag price.\n\n                                        The base of the key is: 0 1 2 3 4 5 6 7 8 9 ----- X C O M P U T E R S\n\n                                        Sample input/output dialogue:\n\n                                        Enter coded value: TR.XX\n                                        Tag price: 68.00\n");

            Console.Write("                                        Enter coded value: ");
            string cval = Console.ReadLine().ToUpper();

            string key = "XCOMPUTERS";
            string num = "0123456789";
            StringBuilder dval = new StringBuilder();

            for (int i = 0; i < cval.Length; i++)
            {
                char currentChar = cval[i];

                if (key.IndexOf(currentChar) != -1)
                {
                    dval.Append(num[key.IndexOf(currentChar)]);
                }
                else
                {
                    dval.Append(currentChar);
                }
            }

            double tag = double.Parse(dval.ToString());
            Console.WriteLine("                                          Tag price: {0:F2}", tag);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Tag price: " + tag.ToString("F2"), options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M63()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.3\n\n                                        Write a program using string functions that determines if the input word is a palindrome.\n                                        A palindrome is a word that produces the same word when it is reversed.\n                                        \n                                        Sample input: AMA\n                                        Reversed: AMA “It is a palindrome”\n                                        \n                                        Enter a word: STI\n                                        Reversed: ITS “It is not a palindrome”\n");

            Console.Write("                                        Enter a word: ");
            string word = Console.ReadLine();

            string rev = ReverseWord(word);

            Console.WriteLine("                                        Reversed: {0}", rev);

            string pal;
            if (word.Equals(rev, StringComparison.OrdinalIgnoreCase))
            {
                pal = "“It is a palindrome”";
            }
            else
            {
                pal = "“It is not a palindrome”";
            }
            Console.WriteLine("                                        " + pal);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Reversed: " + rev + "\n                                          " + pal, options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }


        private static string ReverseWord(string word)
        {
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            return new string(wordArray);
        }

        public void M64()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.4\n\n                                        Write a simple encryption program using string functions which apply the substitution method.\n                                        Substitution Table:\n\n                                        A = *\n                                        E = $\n                                        I = /\n                                        O = +\n                                        U = -\n\n                                        Sample input:\n\n                                        Enter message: meet me at 9:00 a.m. in the park\n                                        Encrypted message: m$$t m$ *t 9:00 *.m. /n th$ p*rk\n");

            Console.Write("                                        Enter message: ");
            string message = Console.ReadLine();

            StringBuilder encrypt = new StringBuilder();

            foreach (char c in message)
            {
                switch (c)
                {
                    case 'A': case 'a': encrypt.Append('*'); break;
                    case 'E': case 'e': encrypt.Append('$'); break;
                    case 'I': case 'i': encrypt.Append('/'); break;
                    case 'O': case 'o': encrypt.Append('+'); break;
                    case 'U': case 'u': encrypt.Append('-'); break;
                    default: encrypt.Append(c); break;
                }
            }

            Console.WriteLine("                                        Encrypted message: {0}", encrypt.ToString());

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Encrypted message: " + encrypt.ToString(), options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M65()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.5\n\n                                        Write a simple decryption program using string functions which will apply the Substitution Method.\n                                        Substitution Table:\n\n                                        * = A\n                                        $ = E\n                                        / = I\n                                        + = O\n                                        - = U\n\n                                        Sample input:\n\n                                        Enter message: m$$t m$ *t 9:00 *.m. /n th$ p*rk\n                                        Encrypted message: meet me at 9:00 a.m. in the park\n");

            Console.Write("                                        Enter message: ");
            string letter = Console.ReadLine();
            StringBuilder decrypt = new StringBuilder();

            foreach (char c in letter)
            {
                switch (c)
                {
                    case '*':
                        decrypt.Append('A');
                        break;
                    case '$':
                        decrypt.Append('E');
                        break;
                    case '/':
                        decrypt.Append('I');
                        break;
                    case '+':
                        decrypt.Append('O');
                        break;
                    case '-':
                        decrypt.Append('U');
                        break;
                    default:
                        decrypt.Append(c);
                        break;
                }
            }

            Console.WriteLine("\n                                        Decrypted message: {0}", decrypt.ToString());

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Decrypted message: " + decrypt.ToString(), options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M66()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.6\n\n                                        Write a program using string functions that will accept the name of the country as an input value\n                                        and will display the corresponding capital.\n\n                                        Here is the list of the countries and their capitals.\n\n                                        COUNTRY\t\tCAPITAL\n\n                                        Canada\t\tOttawa\n                                        United States\tWashington D.C.\n                                        U.S.S.R.\tMoscow\n                                        Italy\t\tRome\n                                        Philippines\tManila\n");

            Console.Write("                                        Enter the name of a country: ");
            string country = Console.ReadLine();

            string capital = "";

            switch (country.ToLower())
            {
                case "canada":
                    capital = "Ottawa";
                    break;
                case "united states":
                    capital = "Washington D.C.";
                    break;
                case "u.s.s.r.":
                    capital = "Moscow";
                    break;
                case "italy":
                    capital = "Rome";
                    break;
                case "philippines":
                    capital = "Manila";
                    break;
                default:
                    capital = "Unknown";
                    break;
            }

            Console.WriteLine("                                        Capital: {0}", capital);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Capital: " + capital, options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M67()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.7\n\n                                        Write a program using string functions that will accept the name of the capital as input value\n                                        and will display the corresponding country.\n\n                                        CAPITAL\t\tCOUNTRY\n\n                                        Ottawa\t\tCanada\n                                        Washington \tUnited States\n                                        Moscow\t\tRussia\n                                        Rome\t\tItaly\n                                        Manila\t\tPhilippines\n");

            Console.Write("                                        Enter the name of a capital: ");
            string capital = Console.ReadLine();

            string country = "";

            switch (capital.ToLower())
            {
                case "ottawa":
                    country = "Canada";
                    break;
                case "washington":
                    country = "United States";
                    break;
                case "moscow":
                    country = "Russia";
                    break;
                case "rome":
                    country = "Italy";
                    break;
                case "manila":
                    country = "Philippines";
                    break;
                default:
                    country = "Unknown";
                    break;
            }

            Console.WriteLine("                                        Country: {0}", country);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Country: " + country, options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M68()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.8\n\n                                        Write a program that will accept the currency value and the name of the country and will display the equivalent in U.S. dollars.\n\n                                        COUNTRY\t\tCURRENCY\tU.S. DOLLAR EQUIVALENT\n\n                                        British\t\tPound\t\t0.60 / dollar\n                                        Canadian\tDollar\t\t1.30 / dollar\n                                        Japanese\tYen\t\t140 / dollar\n                                        German\t\tMark\t\t1.70 / dollar\n                                        Philippines\tPeso\t\t53 / dollar\n");

            Console.Write("                                        Enter the name of a country: ");
            string country = Console.ReadLine();

            Console.Write("                                        Enter the name of the currency: ");
            string currency = Console.ReadLine();

            double usdEquivalent = 0;

            switch (country.ToLower())
            {
                case "british":
                    if (currency.ToLower() == "pound")
                        usdEquivalent = 0.6;
                    break;
                case "canadian":
                    if (currency.ToLower() == "dollar")
                        usdEquivalent = 1.3;
                    break;
                case "japanese":
                    if (currency.ToLower() == "yen")
                        usdEquivalent = 1 / 140.0;
                    break;
                case "german":
                    if (currency.ToLower() == "mark")
                        usdEquivalent = 1.7;
                    break;
                case "philippines":
                    if (currency.ToLower() == "peso")
                        usdEquivalent = 1 / 53.0;
                    break;
            }

            if (usdEquivalent == 0)
                Console.WriteLine("                                        Invalid country or currency.");
            else
                Console.WriteLine("                                        U.S. Dollar Equivalent: {0}", usdEquivalent);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          U.S. Dollar Equivalent: " + usdEquivalent, options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M69()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.9\n\n                                        Write a program that takes nouns and forms their plurals based on these rules:\n\n                                        a. If a noun ends in 'y', remove the 'y' and add 'ies'\n                                        b. If a noun ends in 's', 'ch', or 'sh', add 'es'\n                                        c. In all other cases, just add 's'\n");

            Console.Write("                                        Enter a noun: ");
            string noun = Console.ReadLine();

            string plural = "";

            if (noun.EndsWith("y"))
            {
                plural = noun.Remove(noun.Length - 1) + "ies";
            }
            else if (noun.EndsWith("s") || noun.EndsWith("ch") || noun.EndsWith("sh"))
            {
                plural = noun + "es";
            }
            else
            {
                plural = noun + "s";
            }

            Console.WriteLine("                                        Plural form: {0}", plural);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Plural form: " + plural, options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        public void M610()
        {
            Clear();
            border();
            Console.CursorVisible = true;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                        Machine Problem 6.10\n\n                                        Write a program that takes data, a word at a time, and reverses the words of the line.\n\n                                        Sample input/output dialogue:\n\n                                        Input string value: birds and bees\n                                        Reversed: bees and birds\n");

            Console.Write("                                        Enter a string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            Array.Reverse(words);
            string reversed = string.Join(" ", words);

            Console.WriteLine("                                        Reversed: {0}", reversed);

            string[] options = { "Return" };
            Menu m = new Menu("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                          Reversed: " + reversed, options);
            int s = m.Run();

            switch (s)
            {
                case 0:
                    Module6();
                    break;
            }
        }

        private void ReturnModulePanel()
        {
            Environment.Exit(0);
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