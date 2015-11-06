using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Strings
    {
        // Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". 
        public string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);
        }
    }
}
