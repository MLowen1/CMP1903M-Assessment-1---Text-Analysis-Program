using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // The "UserInput" custom class holds the methods for managing user inputs.
    public class UserInput
    {
        // The "getUserInputChoice" method gathers and validates the user's input method choice.
        // This method encapsulates error handling for the user input.
        public string InputChoice()
        {
            //Prompts user to pick a choice
            Console.WriteLine("Please select an option number:" +
                              "\n1: Manual text entry via keyboard " +
                              "\n2: Read text from a selected file " +
                              "\n3: Quit program");

            string inputChoice = Console.ReadLine().ToLower();

            //Validates the user choice
            try
            {
                if (inputChoice != "1" && inputChoice != "2" && inputChoice != "3")
                {
                    throw new InvalidChoiceException(inputChoice);
                }
                //Return the choice if valid
                return inputChoice;
            }

            catch (Exception ex)
            {
                //Write an error message if choice is invalid
                Console.Clear();
                Console.WriteLine("'{0}' is not a valid option. Please try again.", ex.Message);
                //Repeat the process
                return InputChoice();
            }
        }

        public string ChoiceConfirmation()
        {
            Console.WriteLine("Have you selected the correct option?" +
                "\n1: Yes" +
                "\n2: No" +
                "\n3: Quit Program");

            string confirmationChoice = Console.ReadLine().ToLower();

            try
            {
                if (confirmationChoice != "1" && confirmationChoice != "2" && confirmationChoice != "3")
                {
                    throw new InvalidChoiceException(confirmationChoice);
                }
                //Return the choice if valid
                return confirmationChoice;
            }

            catch (Exception ex)
            {
                //Write an error message if choice is invalid
                Console.Clear();
                Console.WriteLine("'{0}' is not a valid option. Please try again.", ex.Message);
                //Repeat the process
                return ChoiceConfirmation();
            }
        }

        public string QuitConfirmation()
        {
            //Console.Clear();
            Console.WriteLine("Quit program selected..." +
                              "\nAre you sure you would like to quit?" +
                              "\n1: Yes" +
                              "\n2: No");
            string quitChoice = Console.ReadLine();

            try
            {
                if (quitChoice != "1" && quitChoice != "2")
                {
                    throw new InvalidChoiceException(quitChoice);
                }
                //Return the choice if valid
                return quitChoice;
            }

            catch (Exception ex)
            {
                //Write an error message if choice is invalid
                Console.Clear();
                Console.WriteLine("'{0}' is not a valid option. Please try again.", ex.Message);
                //Repeat the process
                return QuitConfirmation();
            }
        }
        public string LongWordReport()
        {
            //Console.WriteLine("");
            //Console.WriteLine("Do you want to generate a report of long words (LongWords.txt)? (y/N)");
            Console.WriteLine("\nDo you want to generate a report of long words (LongWords.txt)?, Select an option below:" +
                              "\n1: Yes" +
                              "\n2: No");

            string longWordsChoice = Console.ReadLine().ToLower();

            //Validates the user choice
            try
            {
                if (longWordsChoice != "1" && longWordsChoice != "2")
                {
                    throw new InvalidChoiceException(longWordsChoice);
                }
                //Return the choice if valid
                return longWordsChoice;
            }

            catch (Exception ex)
            {
                //Write an error message if choice is invalid
                Console.Clear();
                Console.WriteLine("'{0}' is not a valid option. Please try again.", ex.Message);
                //Repeat the process
                return LongWordReport();
            }
        }

        public string RunProgramAgain()
        {
            Console.WriteLine("Do you want to run the program again?" +
                              "\n1: Yes " +
                              "\n2: No ");

            string runAgainChoice = Console.ReadLine();

            try
            {
                if (runAgainChoice != "1" && runAgainChoice != "2")
                {
                    throw new InvalidChoiceException(runAgainChoice);
                }
                //Return the choice if valid
                return runAgainChoice;
            }

            catch (Exception ex)
            {
                //Write an error message if choice is invalid
                Console.Clear();
                Console.WriteLine("'{0}' is not a valid option. Please try again.", ex.Message);
                //Repeat the process
                return RunProgramAgain();
            }

        }
    }
}