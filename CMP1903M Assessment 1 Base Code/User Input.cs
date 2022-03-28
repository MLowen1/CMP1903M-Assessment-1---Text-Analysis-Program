using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // The "UserInput" custom class holds the methods for managing most user inputs.
    public class UserInput
    {
        // The "getUserInputChoice" method gathers and validates the user's input method choice. This was created in addition to methods provided with the base code.
        // This method encapsulates error handling for the user input through the custom "Invalid User Input Exception" class.
        public string InputChoice()
        {
            //Prompts user to pick an input choice.
            Console.WriteLine("Please select an option number:" +
                              "\n" +
                              "\n1: Manual text entry via keyboard " +
                              "\n2: Read text from a selected file " +
                              "\n3: Quit program" +
                              "\n");

            //A variable is created based on the users input.
            string inputChoice = Console.ReadLine().ToLower();

            //Validates the user choice
            try
            {
                //If the variable created does not equal 1,2 or 3. Throw the custom exeption class.
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

        // The "ChoiceConfirmation" method prompts the user to check that they have selected the correct chouce and gives them an option to change the choice..
        // This method encapsulates error handling for the user input through the custom "Invalid User Input Exception" class.  This was created in addition to methods provided with the base code.
        public string ChoiceConfirmation()
        {
            //Prompts user to input wheter the option the chose is correct.
            Console.WriteLine("Have you selected the correct option?" +
                              "\n" +
                              "\n1: Yes" +
                              "\n2: No" +
                              "\n");

            //A variable is created based on the users input.
            string confirmationChoice = Console.ReadLine().ToLower();

            //Validates the user choice
            try
            {
                //If the variable created does not equal 1 or 2. Throw the custom exeption class.
                if (confirmationChoice != "1" && confirmationChoice != "2")
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

        // The "QuitConfirmation" method handles the input for confirming whether to quit the program or not.  This was created in addition to methods provided with the base code.
        // This method encapsulates error handling for the user input through the custom "Invalid User Input Exception" class.
        public string QuitConfirmation()
        {
            //Handles the option for the user to quit the program.
            Console.WriteLine("Quit program selected..." +
                              "\nAre you sure you would like to quit?" +
                              "\n1: Yes" +
                              "\n2: No" +
                              "\n");

            //A variable is created based on the users input.
            string quitChoice = Console.ReadLine();

            //Validates the user choice
            try
            {
                //If the variable created does not equal 1 or 2. Throw the custom exeption class.
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

        // The "LongWordReport" handles input for confirming whether to produce a long word report or not.  This was created in addition to methods provided with the base code.
        // This method encapsulates error handling for the user input through the custom "Invalid User Input Exception" class.
        public string LongWordReport()
        {
            //Handles the option for generating a long words report.
            Console.WriteLine("\nDo you want to generate a report of long words (LongWords.txt)?, Select an option below:" +
                              "\n1: Yes" +
                              "\n2: No" +
                              "\n");

            //A variable is created based on the users input.
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

        // This methos asks the user whether to run the program again.  This was created in addition to methods provided with the base code.
        // This method encapsulates error handling for the user input through the custom "Invalid User Input Exception" class.
        public string RunProgramAgain()
        {
            Console.Clear();
            Console.WriteLine("Do you want to run the program again?" +
                              "\n1: Yes " +
                              "\n2: No " +
                              "\n");

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