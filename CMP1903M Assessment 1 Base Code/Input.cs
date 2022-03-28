﻿using System;
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
            //Prompt the user to enter text
            Console.Clear();
            Console.WriteLine("Please enter text below via keyboard." +
                              "\nPress Enter to finish a line." +
                              "\nEnd the text input using ***: ");

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
        //public string fileTextInput(string fileName)
        {
            Console.Clear();
            Console.WriteLine("Enter the file path, default path is TestFile.txt");
            string fileName = "TestFile.txt";
            //Read whole file into text variable
            string text = File.ReadAllText(fileName);
            //Get text leading up to the first '*'
            text = text.Split('*')[0];

            return text;
        }

        public string ExitProgram()
        {

            Console.WriteLine("\n End");
            Environment.Exit(0);


            //UserInput userInput = new UserInput();
            //string inputOption = userInput.getUserInputChoice();
            return null;
        }
    }
}