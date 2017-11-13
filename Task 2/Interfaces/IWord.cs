using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Classes;

namespace Task_2.Interfaces
{
    public interface IWord
    {
        int GetWordLength(ISentenceItem element);

        bool BeginsWithConsonantLetter(ISentenceItem element);

        void ReplaceValue(int wordLenght, ISentenceItem element, string newValue);
    }
}
