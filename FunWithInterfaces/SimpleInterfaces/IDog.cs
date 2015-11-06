using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    public interface IDog
    {
        string Name { get; set; }
        void Bark();
        string GoForAWalk();
    }
}
