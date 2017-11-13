using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Text
    {
        private ICollection<ISentence> _sentences;
        private Sentence _qustionMark;

        public Text(ICollection<ISentence> sent, Sentence questionMark)
        {
            _sentences = sent;
            _qustionMark = questionMark;
        }

        public void AddSentence(ISentence sentence)
        {
            _sentences.Add(sentence);
        }

        public void RemoveSentence(ISentence sentence)
        {
            _sentences.Remove(sentence);
        }

        public IEnumerable<ISentence> SortSentencesByWordsCount()
        {
            return _sentences.OrderBy(x => x.GetWordsCount());
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _sentences);
        }

        public IEnumerable<ISentence> GetQuestionSentences()
        {
            return (from chosenSentence in _sentences
                    let count = chosenSentence.GetElementsCount()
                    let chosenElement = chosenSentence.GetElementByIndex(count - 1)
                    where chosenElement != null
                    where _qustionMark.IsInterrogative(chosenElement)
                    select chosenSentence).ToList();
        }

        public void DeleteWordsOfGivenLengthWhichStartsWithConsonantLetter(int wordLenght)
        {
            _sentences.ToList().ForEach(x => x.DeleteWordsOfGivenLengthWhichStartsWithConsonantLetter(wordLenght));
        }

        public void ReplaceWordBySubstring(int indexSentense, int wordLenght, string newValue)
        {
            var currentSentence = _sentences.ElementAt(indexSentense);
            currentSentence.ReplaceWordBySubstring(wordLenght, newValue);
        }

        public IEnumerable<string> GetWordsByLenght(int wordLenght)
        {
            IWord word = new Word();
            ICollection<ISentenceItem> buffer = new List<ISentenceItem>();
            foreach (var currentSentence in GetQuestionSentences())
            {
                for (int i = 0; i < currentSentence.GetWordsCount(); i++)
                {
                    var currentElement = currentSentence.GetElementByIndex(i);
                    buffer.Add(currentElement);
                }
            }
            return buffer.ToArray()
                .Where(x => word.GetWordLength(x) == wordLenght)
                .Select(x => x.Value.ToUpper()).Distinct().ToArray();
        }
    }
}
