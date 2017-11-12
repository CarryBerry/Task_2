using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Interfaces
{
    public interface ISentence
    {
        List<IWord> Words { get; }

        int WordsCount { get; }

        bool IsInterrogative { get; }

        char Separator { get; }
    }
}
