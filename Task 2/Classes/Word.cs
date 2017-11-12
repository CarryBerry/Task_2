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
        //public bool BeginsWithConsonantLetter
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public List<Symbol> Symbols { get; protected set; }

        private string _word;

        public Word(string word)
        {
            _word = word;

            Symbols = new List<Symbol>();
            foreach (char symbol in word)
            {
                Symbols.Add(new Symbol(symbol));
            }
        }

        public bool BeginsWithConsonantLetter(SentenceItem item)
        {
            const string pattern = @"[aAeEiIoOuU]";
            return !string.IsNullOrEmpty(item.Value) && !(Regex.Matches(item.Value[0].ToString(), pattern).Count > 0);
        }
    
        public int Count
        {
            get
            {
                return Symbols.Count;
            }
        }
    }
}
