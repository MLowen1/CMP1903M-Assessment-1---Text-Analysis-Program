//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            string text = "";
            while (true)
            {
                //Instantiate objects required:

                //Create "UserInput" object - "UserInput" is a custom class in addition to the classes provided the base code:
                //Collects the users input.
                UserInput userInput = new UserInput();

                //Create "Input" object:
                //Handles the text input methods and quitting the program.
                Input input = new Input();

                //Create an "Analyse" object:
                //Calcualtes and returns the analysis of text.
                Analyse analyse = new Analyse();

                //Create a "Report" object:
                //Handles reporting of the analysis.
                Report report = new Report();



            //Start label for beginning the loop.
            Start:

                //Vairables

                text = "";
                //if (text != null)
                //text = null; }

                //Clears the console at the start of the loop.
                Console.Clear();

                //The "inputOption" variable is created and contains information about the user choice which is passed from "getUserInputChoice" in the "User Input" class.
                string inputOption = userInput.InputChoice();

                //Clears the console after the initial user input.
                Console.Clear();

                switch (inputOption)
                {
                    case "1":
                        Console.WriteLine("Manual text entry via keyboard selected...");
                        break;
                    case "2":
                        Console.WriteLine("Read text from a selected file selected...");
                        break;
                    case "3":
                        Console.WriteLine("Quit program selected...");
                        break;
                }

                string choiceConfirmation = userInput.ChoiceConfirmation();

                switch (choiceConfirmation)
                {
                    case "1":
                        break;
                    case "2":
                        goto Start;
                    case "3":
                        //handles the user asking to quit
                        Console.Clear();
                        string exitConfirmation = userInput.QuitConfirmation();

                        switch (exitConfirmation)
                        {

                            case "1":
                                Console.Write("yes");

                                break;

                            case "2":
                                Console.Write("No");
                                break;
                        }

                        text = input.ExitProgram();
                        Environment.Exit(0);
                        goto End;
                }

                //The input method, based on the users choice in "User Input", is selceted using a switch statement.
                switch (inputOption)
                {
                    //Case 1 - Manual text input via keyboard:
                    //Calls the "manualTextInput" function from the "Input" class.
                    case "1":

                        text = input.ManualTextInput();
                        Console.Clear();
                        Console.WriteLine("manual" +
                                          "\n----------\n" +
                                           text +
                                          "\n----------\n");
                        break;

                    //Case 2 - Text loaded from file:
                    //Calls the "fileTextInput" function from the "Input" class.
                    case "2":
                        text = input.FileTextInput();
                        Console.Clear();
                        Console.WriteLine("Input read from file:" +
                                          "\n----------\n" +
                                           text +
                                          "\n----------\n");
                        break;

                    //Case 3 - Quit program:
                    //Calls the "exitProgram" function from the "Input" class.
                    case "3":
                        //handles the user asking to quit
                        Console.Clear();
                        text = input.ExitProgram();

                        break;
                }

                //Pass the text input to the 'AnalyseText' method
                //Receive a list of integers back
                List<int> parameters = analyse.AnalyseText(text);

                //Report the results of the analysis

                report.ReportParameters(parameters);

                //Get and show the frequency of individual letters
                Console.WriteLine("The frequency of individual letters:");
                Dictionary<char, int> letterCounts = analyse.CountLetters(text);
                report.OutputDictionary(letterCounts);

                //Console.WriteLine("");
                //Console.WriteLine("Do you want to generate a report of long words (LongWords.txt)? (y/N)");
                string longWordsOption = userInput.LongWordReport();

                //Select input method based on user choice
                switch (longWordsOption)
                {
                    case "1":
                        //Write report of long words to LongWords.txt
                        List<string> longWords = analyse.ExtractLongWords(text);
                        report.WriteListToFile(longWords, "LongWords.txt");
                        Console.WriteLine("Long words have been written to: LongWords.txt");
                        string runAgainChoice1 = userInput.RunProgramAgain();

                        switch (runAgainChoice1)
                        {
                            case "1":
                                goto Start;
                                break;
                            case "2":

                                Environment.Exit(0);
                                goto End;
                                break;

                        }
                        break;

                    case "2":

                        string runAgainChoice = userInput.RunProgramAgain();

                        switch (runAgainChoice)
                        {
                            case "1":
                                text = "-";
                                goto Start;
                                break;
                            case "2":

                                Environment.Exit(0);
                                goto End;
                                text = "-";
                                break;

                        }

                        //This needs chaging from quit program to run the program again
                        //Create a method in user input to ask the user if they want too run the program again
                        //Creat a method in Input to make the program run again from the beginning

                        Console.WriteLine("placeholder test"); // This is where you need to give the user the option to run the program again or quit the program.


                        string exitConfirmation = userInput.QuitConfirmation();
                        Console.WriteLine(exitConfirmation);


                        // runAgain.UserInput// Call the program run again function
                        break;
                }

            End:;
            }
        }
    }
}