using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Classes;

namespace Task_2.Interfaces
{
    public interface IPunctuation : ISentenceItem
    {
        Symbol Value { get; }
    }
}
