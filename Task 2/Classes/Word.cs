using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Word : SentenceItem, IWord
    {
        public bool BeginsWithConsonantLetter
        {
            get
            {
                Regex reg = new Regex(@"[а-я]*н[а-я]*е", RegexOptions.IgnoreCase);
                return (_value != null && char.IsLetter(_value[0].Value) && reg.IsMatch(char.ToLower(_value[0].Value).ToString()));
            }
        }

        public Word(string _string)
        {
            _value = _string.Select(c => new Symbol(c)).ToArray();
        }

        public Word(ICollection<ISymbol> value)
        {
            _value = value.ToArray();
        }
    }
}
