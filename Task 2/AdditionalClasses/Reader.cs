using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Reader
    {
        private string _line = string.Empty;
        
        public IEnumerable<string> ReadFile (string file)
        {
            FileStream stream = new FileStream(file, FileMode.Open);
            
            ICollection<string> result = new List<string>();

            List<string> text = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                {
                    while (reader.Peek() > -1)
                    {
                        var str = reader.ReadLine();

                        text.AddRange(Text(str, reader.EndOfStream));
                    }

                    reader.Close();
                }
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("I need a file: text.txt\nPress any key to exit...");
                Console.ReadKey();
                Environment.Exit(ex.HResult);
            }

            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(ex.HResult);
            }

            result = text;
            return result;
        }
        
       
        private IEnumerable<string> Text(string line, bool isLastLine)
        {
            line = String.Join(" ", _line, line);
            List<string> sentences = new List<string>();
            string remained = line;
            while (remained.Length > 0)
            {
                int pointIndex = remained.IndexOf('.');
                int exlamationIndex = remained.IndexOf('!');
                int questionIndex = remained.IndexOf('?');
                if (pointIndex < 0 && exlamationIndex < 0 && questionIndex < 0)
                {
                    if (isLastLine)
                    {
                        sentences.Add(remained);
                    }
                    break;
                }
                int endOfSentence = pointIndex < 0 ? remained.Length : pointIndex;
                if (exlamationIndex > -1 && exlamationIndex < endOfSentence)
                    endOfSentence = exlamationIndex;
                if (questionIndex > -1 && questionIndex < endOfSentence)
                    endOfSentence = questionIndex;
                sentences.Add(remained.Substring(0, endOfSentence + 1));
                remained = remained.Substring(endOfSentence + 1);
                _line = remained;
            }
            return sentences;
        }
    }
}
