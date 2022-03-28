using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string ManualTextInput()
        {
            string text = "";
            //Prompt the user to enter text
            Console.Clear();
            Console.WriteLine("Please enter text below via keyboard:" +
                              "\n" +
                              "\nPress ENTER to finish a line and use *** to end the text input: " +
                              "\n");

            //Read user input, until they terminate with an '*'
            while (!text.EndsWith("***"))
            {
                text += Console.ReadLine();
            }
            //string manual = Console.ReadLine();
            //return manual;
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput()  
        {
            
            Console.WriteLine("Enter the file path, default path is \"Test File.txt\".");
            //string fileName = "TestFile.txt";
            string fileName = Console.ReadLine() ?? string.Empty;
            //Read whole file into text variable
            string text;

            try
            {
                text = File.ReadAllText(fileName).ReplaceLineEndings(" ");

                //Get text leading up to the first '*'
                text = text.Split('*')[0].Trim(' ', '*', ',', '.'); // Trims text input to prevent errors in analysis.;
            }

            catch
            { // Handles exceptions where filePath is an invalid file path.
                Console.Clear();
                Console.WriteLine("You have submitted an invalid file path.\n" +
                                  "Please submit a valid file path.\n");
                text = FileTextInput();
            }
            return text;
        }

        //Mthod created to handle ending and quitting the program.  This was created in addition to methods provided with the base code.
        public string ExitProgram()
        {

            Console.WriteLine("\n End");
            Environment.Exit(0);

            return null;
        }
    }
}