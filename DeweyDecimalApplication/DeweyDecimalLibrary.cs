using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2_Dictionary
{
    public class DeweyDecimalLibrary
    {
        private Random random = new Random();

        private Dictionary<string, string> deweyCatergories = new Dictionary<string, string> {
            {"000","General Knowledge"},
            {"100","Philosophy & Pschology"},
            {"200","Religion"},
            {"300","Social Science"},
            {"400","Languages"},
            {"500","Science"},
            {"600","Technology" },
            {"700","Arts & Recreation"},
            {"800","Literature"},
            {"900","History & Geography"}

        };
//============================================================================================================
        public DeweyDecimalLibrary()
        {
              
        }
//============================================================================================================
 private string GenerateAuthorValue()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();

            return new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        } 
//==========================================<Add Both Values>===================================================
public string RandomCallNumber()
        {
             int wholeNumber = random.Next(0, 1000);
             int decimalNumber = random.Next(0, 1000);  
             
            string finalString = GenerateAuthorValue() + " " + wholeNumber.ToString() + "," + decimalNumber.ToString();
            return finalString;
        }
private string GenerateRandomCatergoryNumber(int minRange)
        {
            string tempNumber;
            string finalString;
            int maxRange = minRange + 100;

            
            int wholeNumber = random.Next(minRange,maxRange); 

            //Generate the decimal value to be added to the Category Number
            int decimalNumber = random.Next(100, 1000); 

          if(wholeNumber < 100)
            {
                //Example : "021,... Number Example

                tempNumber = "0" + wholeNumber.ToString(); 
                finalString = GenerateAuthorValue() + " " + tempNumber + ","+decimalNumber.ToString();
                return finalString;
                
            }else 
            if(wholeNumber <= 10)
            {
                //Example : "001,... Number Example

                tempNumber = "00" + wholeNumber.ToString();
                finalString = GenerateAuthorValue()+" "+tempNumber + "," + decimalNumber.ToString();
                return finalString;
            }
            else
            {
                
                finalString = GenerateAuthorValue() + " " + wholeNumber.ToString() + "," + decimalNumber.ToString();
                return finalString;
            }
            

        }
//==================================================================================================================
        public Dictionary<string, string> GeneratePair(Dictionary<string, string> RandomPairs)
        {
            Dictionary<string, string> correctAnswers = new Dictionary<string, string>();

          foreach (KeyValuePair<string, string> pair in RandomPairs)
            {
                string answer = GenerateRandomCatergoryNumber(Convert.ToInt32(pair.Key));
                string question = pair.Value;
                correctAnswers.Add(question,answer);
            }          
            return correctAnswers;
        }
//====================================================================================================================
       
    }

    

}

