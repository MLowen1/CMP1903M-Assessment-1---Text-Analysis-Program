using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: AnalyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string input)
        {
            //List of integers to hold the first five measurements:          
            List<int> values = new List<int>();

            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {

                values.Add(0);
            }

            //Loop over the letters in the input
            for (int i = 0; i < input.Length; i++)
            {

                //1. Number of sentences
                //Increment sentence count for each punctuation
                if (input[i] == '!' || input[i] == '?' ||
                    input[i] == '.')
                {
                    values[0]++;
                }

                //2. Number of vowels
                //Increment vowel count for each vowel
                if (input[i] == 'a' || input[i] == 'A' ||
                    input[i] == 'e' || input[i] == 'E' ||
                    input[i] == 'i' || input[i] == 'I' ||
                    input[i] == 'o' || input[i] == 'O' ||
                    input[i] == 'u' || input[i] == 'U')
                {

                    values[1]++;
                }

                //3. Number of consonants
                //Increment consonant count for each consonant
                else if ((input[i] >= 'a' && input[i] <= 'z') ||
                         (input[i] >= 'A' && input[i] <= 'Z'))
                {

                    values[2]++;
                }

                //4. Number of upper case letters
                //Increment uppercase count for each uppercase letter
                if (Char.IsUpper(input[i]))
                {

                    values[3]++;
                }

                //5. Number of lower case letters
                //Increment lowercase count for each lowercase letter
                else if (Char.IsLower(input[i]))
                {

                    values[4]++;
                }
            }

            //Return the list of counts
            return values;
        }

        // Custom Method - generates a dictionary of count per letter.
        public Dictionary<char, int> CountLetters(string input)
        {

            Dictionary<char, int> letters = new Dictionary<char, int>();

            //For each letter in the input, increment its count
            foreach (char letter in input)
            {

                if (!letters.ContainsKey(letter))
                {

                    letters.Add(letter, 0);
                }

                letters[letter]++;
            }

            return letters;
        }

        // Custom Method - extracts long words based on minLength
        public List<string> ExtractLongWords(string text, int minLength = 7)
        {
            List<string> longWords = new List<string>();

            //Split text into list of words
            List<string> words = text.Split(" ").ToList();
            foreach (string word in words)
            {

                //If word length is at least minLength, add it to the long words list
                if (word.Length >= minLength)
                {

                    longWords.Add(word);
                }
            }

            return longWords;
        }
    }
}