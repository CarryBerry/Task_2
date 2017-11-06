using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Punctuation : SentenceItem, IPunctuation
    {
        public Punctuation(ICollection<ISymbol> chars) 
        {
            _value = chars.ToArray();
        }

        public Punctuation(string connotation)
        {
            _value = connotation.Select(c => new Symbol(c)).ToArray();

        }

        public string PunctuationValue
        {
            get
            {
                return new string(_value.Select(v => v.Value).ToArray());
            }
        }
    }
}
