using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Sentence : ISentence
    {
        //public List<ISentenceItem> Sentences { get; set; }

        //public int WordsCount()
        //{
        //    int _count = 0;
        //    foreach (var w in Sentences)
        //    {
        //        if (w is Word) _count++;
        //    }
        //    return _count;
        //}

        private string _sentence = "";

        public char Separator { get; protected set; }

        public List<IWord> Words { get; protected set; }

        public bool IsInterrogative
        {
            get
            {
                return _sentence.Last().ToString() == "?";
            }
        }

        private Sentence(string sentence, char separator)
        {
            this._sentence = sentence;
            this.Separator = separator;
        }

        public static Sentence Parse(string sentence)
        {
            var simpleSentence = Regex.Replace(sentence.Trim(), "[^a-zA-Z0-9 ]", "");
            var words = simpleSentence.Split(' ');
            var result = new Sentence(sentence.Trim(), sentence.LastOrDefault());

            foreach (var word in words)
            {
                result.Words.Add(new Word(word));
            }
            return result;
        }

        public int WordsCount
        {
            get
            {
                return Words.Count();
            }
        }
    }
}
