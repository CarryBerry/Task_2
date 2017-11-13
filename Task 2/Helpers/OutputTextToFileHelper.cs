using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Classes
{
    public class OutputTextToFileHelper
    {
        private string line = String.Empty;
        private static string fileName = "Text.txt";
        private static string fileNameSave = "EditedText.txt";
        private Reader reader = new Reader();
        private Parser parser = new Parser();
        private IEnumerable<string> listSentences = new List<string>();
        TextWriter writer = File.CreateText(fileNameSave);

        public void OutputOriginalText()
        {
            listSentences = reader.ReadFile(fileName);
            var text = parser.Parse(listSentences);
            writer.WriteLine("\t\t\t\tOriginal Text\n");
            writer.WriteLine(parser.Parse(listSentences));
            writer.WriteLine();
        }
            

        public void SortSentencesByWordsCount()
        {
            listSentences = reader.ReadFile(fileName);
            var text = parser.Parse(listSentences);


            Console.WriteLine("Sotrting sentences by words in it completed. ");
            writer.WriteLine(line);
            foreach (var item in text.SortSentencesByWordsCount())
            {
                writer.WriteLine("{0}  {1} words", item, item.GetWordsCount());
            }
        }

        public void GetWordsByLenght()
        {
            listSentences = reader.ReadFile(fileName);
            var text = parser.Parse(listSentences);

            Console.WriteLine("\nGetting words by length in interrogative sentences: ");
            writer.WriteLine(line);
            Console.WriteLine("Enter the length of the word in interrogative sentence you want to see: ");
            var length = Convert.ToInt32(Console.ReadLine());
            var temp = text.GetWordsByLenght(length);
            foreach (var i in temp)
            {
                writer.WriteLine(i);
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

            writer.WriteLine("\n", text);
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

            writer.WriteLine(line);

            writer.WriteLine(text);

            Console.ReadKey();
        }
    }
}
