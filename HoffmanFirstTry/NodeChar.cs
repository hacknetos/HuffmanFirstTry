using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoffmanFirstTry
{
    internal class NodeChar : Node
    {
        

        public NodeChar(char letter,int value)
        {
            this.letter = letter;
            this.value = value;
        }
    }
}
