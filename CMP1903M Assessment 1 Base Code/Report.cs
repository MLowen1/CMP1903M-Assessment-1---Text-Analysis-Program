using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // Handles reporting of the analysis
    class Report
    {
        // Custom Method - outputs a report of all parameters listed below
        public void ReportParameters(List<int> parameters)
        {
            //Adjusted these "Console.WriteLine's" following feedback from (07076286). The initial feedback described that the reporting was not spaced out very well making it difficult to read. As I was looking at improving the code I noticed that it wasn't reporting as intended due to using a single "Console.WriteLine()". I've split this across multiple lines for the sake of the report showing correctly.
            Console.WriteLine("\nReport:");
            Console.WriteLine("\nNumber of sentences entered = {0}", parameters[0]);
            Console.WriteLine("\nNumber of vowels = {0}", parameters[1]);
            Console.WriteLine("\nNumber of consonants = {0}", parameters[2]);
            Console.WriteLine("\nNumber of upper case letters = {0}", parameters[3]);
            Console.WriteLine("\nNumber of lower case letters = {0}", parameters[4]);

        }

        // Custom Method - outputs a dictionary in "key: value" format
        public void OutputDictionary(Dictionary<char, int> dict)
        {
            foreach (KeyValuePair<char, int> entry in dict)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }

        // Custom Method - writing List to file using fileName
        public void WriteListToFile(List<string> list, string fileName)
        {
            File.WriteAllLines(fileName, list);
        }
    }
}