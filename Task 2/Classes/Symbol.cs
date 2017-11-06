using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Symbol : ISymbol
    {
        private char _value;
        public char Value { get { return _value; } }

        public Symbol(char source)
        {
            _value = source;
        }
    }
}
