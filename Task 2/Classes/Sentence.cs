using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Sentence : ISentence
    {
        private ICollection<ISentenceItem> _items;

        public Sentence(ICollection<ISentenceItem> Items)
        {
            _items = Items;
        }

        public bool InterrogativeSentence
        {
            get
            {
                return _items.Last().ToString() == "?";
            }
        }

        public int Length
        {
            get
            {
                return _items.Sum(i => i.Length);
            }
        }

        public int WordsCount
        {
            get
            {
                return _items.Where(i => i is IWord).Count();
            }
        }
    }
}
