using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalApplication
{
    internal class Book
    {
        public string CallNumber { get; set; }
        public Label BookLabel { get; set; }
        public Panel BookPanel { get; set; }
//===========================================================================
        public string GenerateRadomCallNumber()
        { 
            return CallNumber = RandomAuthor() + RandomNumberValue();
              
        }
//===============================================================================
        //Generate Random value between 1 to 1000 
        private string RandomNumberValue()
        {
            Random random = new Random();

            // Generate a random double with 3 decimal places between 1 and 1000
            double randomValue = random.NextDouble() * (1000 - 1) + 1;

            // Format the random value to have exactly 3 decimal places
            string formattedRandomValue = string.Format("{0:0.000}", randomValue);

            return formattedRandomValue;

        }
//===============================================================================
        //Generate Random 3 Capital Letters Represent Author
        private string RandomAuthor()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] randomChars = new char[3];

            for (int i = 0; i < 3; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomChars);
        }
    }
}

