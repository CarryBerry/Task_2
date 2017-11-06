using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Interfaces
{
    public interface ISentence : ISentenceItem, IEnumerable<ISentenceItem>
    {
        int WordsCount { get; }
        bool InterrogativeSentence { get; }
    }
}
