using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Parser
    {
        public Text Parse(IEnumerable<string> sentences)
        {
            {
                var text = new Text(new List<ISentence>(), new Sentence());
                const string pattern = @"(\w+)|(\p{P})";

                foreach (var currentSentence in sentences)
                {
                    var sentence = new Sentence(new List<ISentenceItem>(), new Word());
                    var matches = Regex.Matches(currentSentence, pattern);

                    foreach (Match match in matches)
                    {
                        sentence.AddElementToEnd(Regex.IsMatch(match.Value, @"(\p{P})")
                        ? new SentenceItem(match.Value, SentenceItemType.PunctuationSign)
                        : new SentenceItem(match.Value, SentenceItemType.Word));
                    }
                    text.AddSentence(sentence);
                }
                return text;
            }
        }
    }
}
