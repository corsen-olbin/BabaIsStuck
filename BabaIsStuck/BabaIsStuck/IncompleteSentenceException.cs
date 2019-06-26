using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabaIsStuck
{
    public class IncompleteSentenceException : Exception
    {
        public IncompleteSentenceException() { }

        public IncompleteSentenceException(Sentence sentence)
            : base($"Sentence starting with {sentence.Noun.ToString()} is incomplete.")
        {

        }
    }
}
