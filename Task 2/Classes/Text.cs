using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Text : IText
    {
        private ICollection<ISentence> _sentences;

        public ICollection<ISentence> Sentences
        {
            get { return _sentences; }
        }

        public Text(ICollection<ISentence> sentences)
        {
            _sentences = sentences;
        }

        public int SentencesCount
        {

            get
            {
                return _sentences.Count();
            }
        }

        public void OutputTextToFile(string fileName)
        {
            TextWriter writer = File.CreateText(fileName);

            foreach (var sentence in _sentences)
            {
                writer.WriteLine(sentence.ToString());
            }
        }
    }
}
