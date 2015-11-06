using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Conditionals
    {
        /* We have two children, a and b, and the parameters aSmile and 
           bSmile indicate if each is smiling. We are in trouble if they 
           are both smiling or if neither of them is smiling. Return true 
           if we are in trouble. 
        */
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
                return true;

            if (!aSmile && !bSmile)
                return true;

            return false;
        }
    }
}
