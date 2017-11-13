using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Classes
{
    public class OutputTextToConsoleHelper
    {
        private string line = String.Empty;
        private string fileName = "text.txt";
        private Reader reader = new Reader();
        private Parser parser = new Parser();
        private IEnumerable<string> listSentences = new List<string>();



        public void OutputOriginalText()
        {
            listSentences = reader.ReadFile(fileName);
            var text = parser.Parse(listSentences);
            Console.WriteLine("\t\t\t\tOriginal Text\n");
            Console.WriteLine(parser.Parse(listSentences));
            Console.WriteLine();
        }

        public void SortSentencesByWordsCount()
        {
            listSentences = reader.ReadFile(fileName);
            var text = parser.Parse(listSentences);

            
            Console.WriteLine("Sotrting sentences by words in it: ");
            Console.WriteLine(line);
            foreach (var item in text.SortSentencesByWordsCount())
            {
                Console.WriteLine("{0}  {1} words", item, item.GetWordsCount());
            }
        }

        public void GetWordsByLenght()
        {
            var text = parser.Parse(listSentences);
            
            Console.WriteLine("Getting words by length in interrogative sentences: ");
            Console.WriteLine(line);
            Console.WriteLine("Enter the length of the word you want to see: ");
            var length = Convert.ToInt32(Console.ReadLine());
            var temp = text.GetWordsByLenght(length);
            foreach (var i in temp)
            {
                Console.WriteLine(i);
            }
        }

        public void DeleteWordsOfGivenLengthWhichStartsWithConsonantLetter()
        {
            listSentences = reader.ReadFile(fileName);
            var text = parser.Parse(listSentences);

            Console.WriteLine("Deleting words of given length which starts with consonant letter\n");
            
            Console.WriteLine("Enter the length of the words you want to remove: ");

            var length2 = Convert.ToInt32(Console.ReadLine());

            text.DeleteWordsOfGivenLengthWhichStartsWithConsonantLetter(length2);

            Console.WriteLine("\n", text);
        }

        public void ReplaceWordBySubstring()
        {
            listSentences = reader.ReadFile(fileName);

            var text = parser.Parse(listSentences);

            Console.WriteLine("Replacing words by substring: \n");
            
            Console.WriteLine("Enter the number of sentence the words in that you want to replace");

            var sentence = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the word you want to replace");

            var length3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter substring");

            var change = Convert.ToString(Console.ReadLine());

            text.ReplaceWordBySubstring(sentence - 1, length3, change);

            Console.WriteLine(line);

            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
    }
