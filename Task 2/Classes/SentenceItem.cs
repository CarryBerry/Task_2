using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public abstract class SentenceItem : ISentenceItem
    {
        protected ISymbol[] _value;

        public ICollection<ISymbol> Value
        {
            get { return _value; }
        }

        public int Length
        {
            get { return _value.Count(); }
        }
    }
}
