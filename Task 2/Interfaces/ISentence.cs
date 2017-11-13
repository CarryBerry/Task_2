using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Interfaces
{
    public interface ISentence
    {
        bool IsInterrogative(ISentenceItem element);

        void AddElementToEnd(ISentenceItem element);

        int GetWordsCount();

        int GetElementsCount();

        ISentenceItem GetElementByIndex(int index);

        void DeleteWordsOfGivenLengthWhichStartsWithConsonantLetter(int wordLenght);

        void ReplaceWordBySubstring(int wordLenght, string newValue);
    }
}
