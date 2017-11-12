using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Symbol
    {

        private char _symbol;
        public Symbol(char symbol)
        {
            _symbol = symbol;
        }

        public char StringSymbol()
        {
            return _symbol;
        }
    }
}
