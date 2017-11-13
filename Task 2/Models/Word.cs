using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Word : IWord
    {
        public bool BeginsWithConsonantLetter(ISentenceItem element)
        {
            Regex Vowels = new Regex(@"[aAeEiIoOuU]");

            if (element.SentenceItemType == SentenceItemType.Word)
            {
                return (element.Value != null && char.IsLetter(element.Value[0]) && !Vowels.IsMatch(char.ToLower(element.Value[0]).ToString()));
            }
            return false;
        }

        public int GetWordLength(ISentenceItem element)
        {
            return element.Value.Length;
        }

        public int GetWordIndex(ISentenceItem element)
        {
            return element.Value.First();
        }

        public void ReplaceValue(int wordLenght, ISentenceItem element, string newValue)
        {
            if (GetWordLength(element) == wordLenght)
            {
                element.Value = newValue;
            }
        }
    }
}
