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
            //text variable:
            string text = "";

            while (true)
            {
                //Instantiate classs required:

                //Create "UserInput" class - "UserInput" is a custom class in addition to the classes provided the base code:
                //Collects the users input.
                UserInput userInput = new UserInput();

                //Create "Input" class:
                //Handles the text input methods and quitting the program.
                Input input = new Input();

                //Create an "Analyse" class:
                //Calcualtes and returns the analysis of text.
                Analyse analyse = new Analyse();

                //Create a "Report" class:
                //Handles reporting of the analysis.
                Report report = new Report();


            //"Start" label allows the "goto" statement to be used to transfer control to this point in the program.
            //The loop is reset to this point if the user choses to run the program again.
            Start:

                //Variables
                text = "";

                //Clears the console at the start of the loop.
                Console.Clear();

                //The "inputOption" variable is created and contains information about the user choice which is passed from "InputChoice()" in the "User Input" class.
                string inputOption = userInput.InputChoice();

                //Clears the console after the initial user input.
                Console.Clear();

                //This switch case determines which input option the user has selected and displays a feedback message based on their choice.
                //"Please select an option number:"
                switch (inputOption)
                {

                    //"Case 1" - Manual text entry via keyboard:
                    case "1":
                        Console.WriteLine("Manual text entry via keyboard selected..." +
                                          "\n");
                        break;
                    //"Case 2" - Read text from a file:
                    case "2":
                        Console.WriteLine("Read text from a file selected..." +
                                          "\n");
                        break;
                    //"Case 2" - End the program:
                    case "3":
                        Console.WriteLine("Quit program selected..." +
                                          "\n");
                        break;
                }

                //The "choiceConfirmation" variable is created and contains information about the user choice which is passed from "ChoiceConfirmation()" in the "User Input" class.
                //This second variable is created to allow a second switch case to be used.
                string choiceConfirmation = userInput.ChoiceConfirmation();

                //This switch case determines which input option the user has selected and then prompts the user to confirm whether the the option have selected is correct. If the selected option is correct then the program will continue. If the selected option is incrorect then the program will loop back to the "Start" label in order to allow the user to pick a new input option. The user is also given the option to quit the program.
                //"Have you selected the correct option?"
                switch (choiceConfirmation)
                {

                    //"Case 1" - Yes:
                    case "1":
                        //If "Case 1" is selected then break.
                        Console.Clear();
                        break;

                    //"Case 2" - No:
                    case "2":
                        //If "Case 2" is selected the return to the beginning of the program.
                        Console.Clear();
                        goto Start;
                }

                //This switch case calls the selected input method from the "Input" class, based on the users choice in "InputChoice".
                //"Please select an option number:
                switch (inputOption)
                {

                    //"Case 1" - Manual text entry via keyboard:
                    //Calls the "ManualTextInput" method from the "Input" class.
                    case "1":

                        //The "text" variable is passed the information fromm the input in "ManualTextInput".
                        text = input.ManualTextInput();
                        //Clears the console and displays a feedback message based on the text input.
                        Console.Clear();
                        Console.WriteLine("Manual text entered:" +
                                          "\n----------\n" +
                                           text +
                                          "\n----------\n");
                        break;

                    //"Case 2" - Read text from a file:
                    //Calls the "FileTextInput" method from the "Input" class.
                    case "2":

                        text = input.FileTextInput();
                        //Clears the console and displays a feedback message based on the text input.
                        Console.Clear();
                        Console.WriteLine("Input text read from file:" +
                                          "\n----------\n" +
                                           text +
                                          "\n----------\n");
                        break;

                    //"Case 3" - End the program:
                    //Calls the "ExitProgram" method from the "Input" class.
                    case "3":

                        Console.Clear();
                        text = input.ExitProgram();

                        break;
                }

                //Pass the text input to the 'AnalyseText' method.
                //Receive a list of integers back.
                List<int> parameters = analyse.AnalyseText(text);

                //Report the results of the analysis.
                report.ReportParameters(parameters);

                //Get and show the frequency of individual letters using the "Dictionary" method.
                Console.WriteLine("The frequency of individual letters:");
                Dictionary<char, int> letterCounts = analyse.CountLetters(text);
                report.OutputDictionary(letterCounts);

                //The "longWordsOption" variable is created and contains information about the user choice which is passed from "LongWordsReport()" in the "User Input" class.
                string longWordsOption = userInput.LongWordReport();

                //This switch case calls the selected option from the "UserInput" class, based on the users choice in "InputChoice".
                //"Do you want to generate a report of long words?"
                switch (longWordsOption)
                {

                    //"Case 1" - Yes:
                    //"Case 1" - Write report of long words to LongWords.txt
                    case "1":
                       
                        List<string> longWords = analyse.ExtractLongWords(text);
                        report.WriteListToFile(longWords, "LongWords.txt");

                        Console.Clear();
                        Console.WriteLine("Long words have been written to: LongWords.txt" +
                                          "\n");

                        break;

                    //"Case 2" - No:
                    //Ask the user if they would like to run the program again:
                    case "2":
                        break;

                }

                //The "runAgainChoice" variable is assigned and passed the information inputted in the "RunProgramAgain()" method in the "User Input" class.
                string runAgainChoice = userInput.RunProgramAgain();

                switch (runAgainChoice)
                {

                    //"Case 1" - Yes:
                    //"goto" statement jumps to the "End" label at the end of the program.
                    case "1":

                        goto Start;

                    //"Case 2" - No:
                    //Calls the "ExitProgram" method from the "Input" class.
                    //"goto" statement jumps to the "End" label at the end of the program.
                    case "2":

                        Environment.Exit(0);
                        goto End;
                }

            //"End" label allows the "goto" statement to be used to transfer control to this point in the program.
            End:;
            }
        }
    }
}