using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract1Testing
{
    public class CheckText
    {
        public int scoreCounter = 0;

        public void checkNumber(string inputText) 
        {
            this.scoreCounter = inputText.Any(x => char.IsNumber(x)) ? ++this.scoreCounter : this.scoreCounter;
        }
            
        public void checkLowercase(string inputText) 
        {
            this.scoreCounter = inputText.Any(x => char.IsLetter(x) && char.IsLower(x)) ? ++this.scoreCounter : this.scoreCounter;
        }

        public void checkCapital(string inputText) 
        {
            scoreCounter = inputText.Any(x => char.IsLetter(x) && char.IsUpper(x)) ? ++this.scoreCounter : this.scoreCounter;
        }

        public void checkMore10Letters(string inputText) 
        {
            scoreCounter = inputText.Length >= 10 ? ++this.scoreCounter : scoreCounter;
        }

        public void checkSpecial(string inputText) 
        {
            scoreCounter = inputText.Any(x => !char.IsLetter(x) && !char.IsNumber(x)) ? ++this.scoreCounter : this.scoreCounter;
        } 
    }
}
