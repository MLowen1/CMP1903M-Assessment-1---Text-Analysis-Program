using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // Custom exception class created in addition to the classes provided in the base code.
    // InvalidChoiceException is thrown when the user makes an invalid choice
    public class InvalidChoiceException : Exception
    {
        public InvalidChoiceException(string message) : base(message) { }
    }
}