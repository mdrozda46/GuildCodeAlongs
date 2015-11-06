using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    public partial class Player
    {
        public string Name { get; private set; }
        public int score { get; set; }

        // constructor
        public Player()
        {
            Name = "New Player";
        }

    }
}
