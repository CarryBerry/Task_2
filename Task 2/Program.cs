using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Classes;
using System.Configuration;
using Task_2.Interfaces;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutputTextToConsoleHelper helper = new OutputTextToConsoleHelper();

            //helper.OutputOriginalText();
            //helper.SortSentencesByWordsCount();
            //helper.GetWordsByLenght();
            //helper.DeleteWordsOfGivenLengthWhichStartsWithConsonantLetter();
            //helper.ReplaceWordBySubstring();

            OutputTextToFileHelper writer = new OutputTextToFileHelper();

            writer.OutputOriginalText();
            writer.SortSentencesByWordsCount();
            writer.GetWordsByLenght();
            writer.DeleteWordsOfGivenLengthWhichStartsWithConsonantLetter();
            writer.ReplaceWordBySubstring();

        }
    }
}