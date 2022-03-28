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
            Console.WriteLine("Number of sentences entered = {0}", parameters[0] +
                              "Number of vowels = {0}", parameters[1] +
                              "Number of consonants = {0}", parameters[2] +
                              "Number of upper case letters = {0}", parameters[3] +
                              "Number of lower case letters = {0}", parameters[4]);
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