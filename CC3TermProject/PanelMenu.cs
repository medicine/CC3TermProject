using System;
using System.IO;
using System.Text;

namespace TermTest
{
    class PanelMenu
    {
        public void Start()
        {
            CursorVisible = false;
            Title = "Daquioag, Andrew Neil T. - CC2 Term Project";
            ForegroundColor = ConsoleColor.Green;
            Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            LoadingBar.WriteProgressBar(0);
            for (var i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
                Write("          ");
                SetCursorPosition((WindowWidth) / 2, CursorTop);
                LoadingBar.WriteProgressBar(i, true);
            }
            RunMenu();
        }
        public void RunMenu()
        {
            border();
            ModulePanel modulepanel = new ModulePanel();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\RunMenu.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "  Drug Information & Effects", "  Frequently Asked Questions", "     Module Machine (1-6)", "        Read and Write", "     About the Programmer", "         Exit Program" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.LeftRun();
            switch (selectedIndex)
            {
                case 0:
                    RunLegalInfo();
                    break;
                case 1:
                    RunFAQInfo();
                    break;
                case 2:
                    modulepanel.RunModuleMachine();
                    break;
                case 3:
                    ReadAndWrite();
                    break;
                case 4:
                    About();
                    break;
                case 5:
                    ExitPanelMenu();
                    break;
            }
        }

        public void ReadAndWrite()
        {
            border();

            string prompt = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n x                          :J????7??!:                                   .!?7.             :7YYJ?^               :!?~    .~?7.       .~?!           .7?!                       \r\n x                           .P@@@7:~G@&5.                                ^G@@@^            :#@@7.?&^             :P@@@J  .J&@@G.      Y@@5           !&@B.  .~7:                \r\n x                            J@@&:  ^&@@J   .!?J??7^    :!J??J7^    .~?JJ?P@@&^            ^&@@Y?GJ.               ?@@@J   ~&@@P.     :#P. :!?~!JJ!. .7Y? .Y#@@G7^  .!?J??!^    \r\n x                            J@@&:  :&@@?  ?&@G^:B@@P  Y@@5:^B@@5. ~B@@J^!B@@&^            .G@@@G.  ~GB?            J@@@?   ~@@@P    ^BY  7#@@&JG@@Y^G@@@^ 7@@@P~: J&@G^:B@@5   \r\n x                            J@@@J:^P@&Y. !@@@J75&&B?  ~5G5Y7P@@&:.#@@P   J@@&^          :5&P5@@@5: G@@Y             J@@@?  J#&@@P  !#?    G@@B .?J^ J@@&^ :&@@Y  !@@@J75&&B?   \r\n x                            J@@&75@@@B^  !@@@P!~^.   .Y#@?  J@@&:.&@@Y   J@@&^         ^&@@: ?&@@#Y&B!               Y@@@?5B:!@@@5?#!     P@@B      ?@@&^ :&@@Y  7@@@P!~^.     \r\n x                            5@@@~ ~G@@@G?.P@@&Y~^^~?^Y@@&^.!#@@@J J@@B.  5@@@J.        !@@@P!^7#@@@@Y:~J              Y@@@P.  7@@@B^     .B@@#:     Y@@@! .B@@#?!.P@@&Y~^^~?~  \r\n x                           ^PPPPJ   !5PJ~  !5B##BPY~ ^5B#G5YJGGJ~  !P#P??5#B5!          ~YPGGPY?~75G#BP!               JGJ     !P5:      !PPPP7    :PPPPJ  ^YPP?:  !5B##BPY~   \r\n x                                           ...       ..            ..  .                                                                                           ...      \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            string[] options = { "      Create New Record", "       Display Records", "        Delete Record", "      Back to Main Menu" };
            Menu mainMenu = new Menu(prompt, options);

            int selectedIndex = mainMenu.LeftRun();
            switch (selectedIndex)
            {
                case 0:
                    CreateNewRecord();
                    break;
                case 1:
                    DisplayRecords();
                    break;
                case 2:
                    DeleteRecord();
                    break;
                case 3:
                    RunMenu();
                    break;
            }
        }
        public void CreateNewRecord()
        {
            Clear();
            border();
            CursorVisible = true;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                      Enter the details for the new record: \n");
            Console.Write(" x                                      Drug Name: ");
            string drugName = Console.ReadLine();

            Console.Write(" x                                      Drug Type: ");
            string drugType = Console.ReadLine();

            Console.Write(" x                                      Generic Name: ");
            string genericName = Console.ReadLine();

            Console.Write(" x                                      Dosage: ");
            string dosage = Console.ReadLine();

            Console.Write(" x                                      Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\records.txt";
            SaveRecordToFile(filePath, drugName, drugType, genericName, dosage, price);

            DisplayOptions();
        }

        private void SaveRecordToFile(string filePath, string drugName, string drugType, string genericName, string dosage, decimal price)
        {
            int recordNumber = GetNextRecordNumber(filePath);

            string record = $"Record {recordNumber}:".PadRight(20) +
                            $"{drugName.PadRight(20)}" +
                            $"{drugType.PadRight(20)}" +
                            $"{genericName.PadRight(20)}" +
                            $"{dosage.PadRight(20)}" +
                            $"{price}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(record);
            }
        }

        private int GetNextRecordNumber(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] records = File.ReadAllLines(filePath);
                if (records.Length > 0)
                {
                    string lastRecord = records[records.Length - 1];
                    if (lastRecord.StartsWith("Record "))
                    {
                        int recordNumber;
                        if (int.TryParse(lastRecord.Substring(7, lastRecord.IndexOf(':') - 7), out recordNumber))
                        {
                            return recordNumber + 1;
                        }
                    }
                }
            }
            return 1;
        }

        private void DisplayOptions()
        {
            border();
            CursorVisible = false;
            string prompt = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n x                                        New record created and saved successfully!";
            string[] options = { "Back" };
            Menu mainMenu = new Menu(prompt, options);

            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    ReadAndWrite();
                    break;
            }
        }

        public void DisplayRecords()
        {
            Clear();
            cborder();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\n");
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\records.txt";

            string[] records = File.ReadAllLines(filePath);

            int consoleWidth = Console.WindowWidth;

            foreach (string record in records)
            {
                int leftMargin = (consoleWidth - record.Length) / 4;
                Console.SetCursorPosition(leftMargin, Console.CursorTop);
                Console.WriteLine(record);
            }
            Console.WriteLine("\n\n\n\n");
            Console.SetCursorPosition(consoleWidth / 2 - 10, Console.WindowHeight - 5);
            Console.WriteLine("[Enter] Return to Main Menu");

            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }

            ReadAndWrite();
        }

        public void DeleteRecord()
        {
            Clear();
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\records.txt";

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            CursorVisible = true;
            Console.Write(" x                                        Enter the record number to delete (or 'x' to delete all): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "x")
            {
                File.WriteAllText(filePath, string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n x                                        All records deleted successfully!");
            }
            else
            {
                int recordNumber;
                bool isNumeric = int.TryParse(input, out recordNumber);

                if (isNumeric)
                {
                    string[] records = File.ReadAllLines(filePath);
                    int totalRecords = records.Length;

                    bool recordFound = false;
                    for (int i = 0; i < totalRecords; i++)
                    {
                        if (records[i].StartsWith($"Record {recordNumber}:"))
                        {
                            recordFound = true;
                            records[i] = null;
                            break;
                        }
                    }

                    if (recordFound)
                    {
                        List<string> updatedRecords = records.Where(record => record != null).ToList();
                        File.WriteAllLines(filePath, updatedRecords);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n x                                        Record deleted successfully!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n                                          Record not found!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                                          Invalid input!");
                }
            }
            CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n x                                        [Enter] Return to Main Menu");
            Console.ReadLine();

            ReadAndWrite();
        }

        private void About()
        {
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\About.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "      Return to Main Menu" };

            Menu About = new Menu(prompt, options);
            int selectedIndex = About.LeftRun();

            switch (selectedIndex)
            {
                case 0:
                    RunMenu();
                    break;
            }
            ExitPanelMenu();
        }

        private void ExitPanelMenu()
        {
            border();
            Environment.Exit(0);
        }
        private void RunFAQInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\RunFAQInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "1. Why do only some people get addicted to drugs?", "2. Are all drugs addictive? What makes them addictive?", "3. Can I get addicted if I do it just once and a while?", "4. You drink alcohol. It can’t be that dangerous, right?", "5. Are prescription drugs safe? They are legal and some of my friends at school use them.", "6. What about marijuana? It’s a plant, it’s natural.", "7. Is medical marijuana safer than the pot that’s on the street?", "8. How do I know if someone is addicted to drugs?", "9. What can I do to help my friend who is addicted to drugs?\n\n\n\n\n", "Return to Main Menu" };
            Menu RunFAQInfo = new Menu(prompt, options);
            int selectedIndex = RunFAQInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    FAQ1();
                    break;
                case 1:
                    FAQ2();
                    break;
                case 2:
                    FAQ3();
                    break;
                case 3:
                    FAQ4();
                    break;
                case 4:
                    FAQ5();
                    break;
                case 5:
                    FAQ6();
                    break;
                case 6:
                    FAQ7();
                    break;
                case 7:
                    FAQ8();
                    break;
                case 8:
                    FAQ9();
                    break;
                case 9:
                    RunMenu();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ1()
        {
            Clear();
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ1.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ1 = new Menu(prompt, options);
            int selectedIndex = FAQ1.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ2()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ2.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ2 = new Menu(prompt, options);
            int selectedIndex = FAQ2.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ3()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ3.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ3 = new Menu(prompt, options);
            int selectedIndex = FAQ3.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ4()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ4.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ4 = new Menu(prompt, options);
            int selectedIndex = FAQ4.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ5()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ5.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ5 = new Menu(prompt, options);
            int selectedIndex = FAQ5.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ6()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ6.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ6 = new Menu(prompt, options);
            int selectedIndex = FAQ6.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ7()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ7.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ7 = new Menu(prompt, options);
            int selectedIndex = FAQ7.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void FAQ8()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ8.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ8 = new Menu(prompt, options);
            int selectedIndex = FAQ8.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }

        private void FAQ9()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\FAQ9.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu FAQ9 = new Menu(prompt, options);
            int selectedIndex = FAQ9.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFAQInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void RunLegalInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\RunLegalInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Types", "Benefits", "Risk Factors", "Substance Risks\n\n x                                            Information about Illegal Drugs\n", "Illegal Types", "Effects and Abuse", "Risk factors\n", "OTC Drug Abuse Information\n", "Return to Main Menu" };
            Menu LegalInfoMenu = new Menu(prompt, options);
            int selectedIndex = LegalInfoMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    LegalTypes();
                    break;
                case 1:
                    LegalBenefits();
                    break;
                case 2:
                    LegalRiskFactors();
                    break;
                case 3:
                    LegalSubstanceRisks();
                    break;
                case 4:
                    IllegalTypes();
                    break;
                case 5:
                    DrugEffectsAndAbuse();
                    break;
                case 6:
                    OTCRiskFactors();
                    break;
                case 7:
                    OTCDrugAbuseInfo();
                    break;
                case 8:
                    RunMenu();
                    break;
            }
            ExitPanelMenu();
        }
        private void LegalBenefits()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\LegalBenefits.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu LegalBenefits = new Menu(prompt, options);
            int selectedIndex = LegalBenefits.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }

        private void LegalRiskFactors()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\LegalRiskFactors.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu LegalRiskFactors = new Menu(prompt, options);
            int selectedIndex = LegalRiskFactors.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void LegalTypes()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\LegalTypes.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Opioids", "Sedatives", "Stimulants\n", "Return" };
            Menu LegalTypes = new Menu(prompt, options);
            int selectedIndex = LegalTypes.Run();

            switch (selectedIndex)
            {
                case 0:
                    OpioidInfo();
                    break;
                case 1:
                    SedativeInfo();
                    break;
                case 2:
                    StimulantInfo();
                    break;
                case 3:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }

        private void OpioidInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\OpioidInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu OpioidInfo = new Menu(prompt, options);
            int selectedIndex = OpioidInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    LegalTypes();
                    break;
            }
            ExitPanelMenu();
        }

        private void SedativeInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\SedativeInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu SedativeInfo = new Menu(prompt, options);
            int selectedIndex = SedativeInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    LegalTypes();
                    break;
            }
            ExitPanelMenu();
        }

        private void StimulantInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\StimulantInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu StimulantInfo = new Menu(prompt, options);
            int selectedIndex = StimulantInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    LegalTypes();
                    break;
            }
            ExitPanelMenu();
        }
        private void LegalSubstanceRisks()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\LegalSubstanceRisks.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu LegalSubstanceRisks = new Menu(prompt, options);
            int selectedIndex = LegalSubstanceRisks.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void IllegalTypes()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\IllegalTypes.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Depressants", "Stimulants", "Hallucinogens", "Canabis\n", "Return" };
            Menu IllegalTypes = new Menu(prompt, options);
            int selectedIndex = IllegalTypes.Run();

            switch (selectedIndex)
            {
                case 0:
                    DepressantsInfo();
                    break;
                case 1:
                    StimulantsInfo();
                    break;
                case 2:
                    HallucinogensInfo();
                    break;
                case 3:
                    CanabisInfo();
                    break;
                case 4:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void DepressantsInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\DepressantsInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu DepressantsInfo = new Menu(prompt, options);
            int selectedIndex = DepressantsInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    IllegalTypes();
                    break;
            }
            ExitPanelMenu();
        }
        private void StimulantsInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\StimulantsInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu StimulantsInfo = new Menu(prompt, options);
            int selectedIndex = StimulantsInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    IllegalTypes();
                    break;
            }
            ExitPanelMenu();
        }
        private void HallucinogensInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\HallucinogensInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu HallucinogensInfo = new Menu(prompt, options);
            int selectedIndex = HallucinogensInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    IllegalTypes();
                    break;
            }
            ExitPanelMenu();
        }
        private void CanabisInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\CannabisInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu CanabisInfo = new Menu(prompt, options);
            int selectedIndex = CanabisInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    IllegalTypes();
                    break;
            }
            ExitPanelMenu();
        }
        private void DrugEffectsAndAbuse()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\DrugEffectsAndAbuse.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu DrugEffectsAndAbuse = new Menu(prompt, options);
            int selectedIndex = DrugEffectsAndAbuse.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void OTCRiskFactors()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\OTCRiskFactors.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu OTCRiskFactors = new Menu(prompt, options);
            int selectedIndex = OTCRiskFactors.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void OTCDrugAbuseInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\OTCDrugAbuseInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Cough medicines", "Cold medicines", "Motion sickness pills\n\n", "Substance Abuse Effects", "Complications", "Prevention", "Physical dependence and addiction\n", "Return" };
            Menu OTCDrugAbuseInfo = new Menu(prompt, options);
            int selectedIndex = OTCDrugAbuseInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    CoughMedicinesInfo();
                    break;
                case 1:
                    ColdMedicinesInfo();
                    break;
                case 2:
                    MotionPills();
                    break;
                case 3:
                    SubAbuseDrug();
                    break;
                case 4:
                    OTCComplications();
                    break;
                case 5:
                    HowToPrevent();
                    break;
                case 6:
                    OTCPhysical();
                    break;
                case 7:
                    RunLegalInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void CoughMedicinesInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\CoughMedicinesInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu CoughMedicinesInfo = new Menu(prompt, options);
            int selectedIndex = CoughMedicinesInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    OTCDrugAbuseInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void ColdMedicinesInfo()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\ColdMedicinesInfo.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu ColdMedicinesInfo = new Menu(prompt, options);
            int selectedIndex = ColdMedicinesInfo.Run();

            switch (selectedIndex)
            {
                case 0:
                    OTCDrugAbuseInfo();
                    break;
            }
            ExitPanelMenu();
        }

        private void MotionPills()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\MotionPills.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu MotionPills = new Menu(prompt, options);
            int selectedIndex = MotionPills.Run();

            switch (selectedIndex)
            {
                case 0:
                    OTCDrugAbuseInfo();
                    break;
            }
            ExitPanelMenu();
        }

        private void SubAbuseDrug()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\SubAbuseDrug.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu SubAbuseDrug = new Menu(prompt, options);
            int selectedIndex = SubAbuseDrug.Run();

            switch (selectedIndex)
            {
                case 0:
                    OTCDrugAbuseInfo();
                    break;
            }
            ExitPanelMenu();
        }

        private void OTCComplications()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\OTCComplications.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu OTCComplications = new Menu(prompt, options);
            int selectedIndex = OTCComplications.Run();

            switch (selectedIndex)
            {
                case 0:
                    OTCDrugAbuseInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void HowToPrevent()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\HowToPrevent.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu HowToPrevent = new Menu(prompt, options);
            int selectedIndex = HowToPrevent.Run();

            switch (selectedIndex)
            {
                case 0:
                    OTCDrugAbuseInfo();
                    break;
            }
            ExitPanelMenu();
        }
        private void OTCPhysical()
        {
            border();
            string filePath = "C:\\Users\\zvnei\\source\\repos\\CC3TermProject\\CC3TermProject\\data\\OTCPhysical.txt";
            string prompt = File.ReadAllText(filePath);
            string[] options = { "Return" };
            Menu OTCPhysical = new Menu(prompt, options);
            int selectedIndex = OTCPhysical.Run();

            switch (selectedIndex)
            {
                case 0:
                    OTCDrugAbuseInfo();
                    break;
            }
            ExitPanelMenu();
        }
        static class LoadingBar
        {
            const char _block = '■';
            const string _back = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";

            public static void WriteProgressBar(int percent, bool update = true)
            {
                ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = GetColorFromPercent(percent);

                int left = (WindowWidth - 12) / 2;
                SetCursorPosition(left, CursorTop);
                Write("          ");
                if (update)
                    Write(_back);
                Write("[");
                var p = (int)((percent / 10f) + .5f);
                for (var i = 0; i < 10; ++i)
                {
                    if (i >= p)
                        Write(' ');
                    else
                        Write(_block);
                }
                Write($"] {percent,3}%");

                Console.ForegroundColor = originalColor;
            }

            static ConsoleColor GetColorFromPercent(int percent)
            {
                if (percent <= 10)
                    return ConsoleColor.Red;
                else if (percent <= 20)
                    return ConsoleColor.Yellow;
                else if (percent <= 30)
                    return ConsoleColor.Green;
                else if (percent <= 40)
                    return ConsoleColor.Blue;
                else if (percent <= 50)
                    return ConsoleColor.Magenta;
                else if (percent <= 60)
                    return ConsoleColor.Red;
                else if (percent <= 70)
                    return ConsoleColor.Yellow;
                else if (percent <= 80)
                    return ConsoleColor.Green;
                else if (percent <= 90)
                    return ConsoleColor.Blue;
                else
                    return ConsoleColor.Magenta;
            }

            private static void SetCursorPosition(int left, int top) => Console.SetCursorPosition(left, top);
            private static int WindowWidth => Console.WindowWidth;
            private static int CursorTop => Console.CursorTop;
            private static void Write(string value) => Console.Write(value);
            private static void Write(char value) => Console.Write(value);
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

        static void cborder()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);

            Console.Write("╔");
            for (int i = 1; i < Console.WindowWidth - 1; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╗");

            for (int row = 1; row < Console.WindowHeight - 2; row++) 
            {
                Console.SetCursorPosition(0, row);
                Console.Write("║");
                Console.SetCursorPosition(Console.WindowWidth - 1, row);
                Console.WriteLine("║");
            }

            Console.Write("╚");
            for (int i = 1; i < Console.WindowWidth - 1; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╝");

            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }

        static void AnimateTextFile(string filePath)
        {
            // Read the contents of the text file
            string content = File.ReadAllText(filePath);

            // Create a StringBuilder to store the modified content
            StringBuilder modifiedContent = new StringBuilder(content);

            // Randomize specific characters
            Random random = new Random();
            string charactersToRandomize = "@&^:~!#?";
            int delay = 100; // Delay in milliseconds

            // Animation loop
            while (true)
            {
                // Iterate through each character in the content
                for (int i = 0; i < content.Length; i++)
                {
                    // Check if the character needs to be randomized
                    if (charactersToRandomize.Contains(content[i]))
                    {
                        // Randomize the character
                        char randomizedChar = charactersToRandomize[random.Next(charactersToRandomize.Length)];

                        // Replace the character in the modified content
                        modifiedContent[i] = randomizedChar;
                    }
                }

                // Clear the console and display the modified content
                Console.Clear();
                Console.WriteLine(modifiedContent.ToString());

                // Delay for a short period
                Thread.Sleep(delay);
            }
        }
    }
}
