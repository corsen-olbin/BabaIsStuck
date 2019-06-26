using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabaIsStuck
{
    public class Sentence
    {
        public NounTypes Noun { get; set; }

        public VerbTypes Verb { get; set; }

        public DescriptorTypes Descriptor { get; set; }

        public List<ConjunctionTypes> Conjunctions = new List<ConjunctionTypes>();

        public List<DescriptorTypes> ExtraDescriptors = new List<DescriptorTypes>();

        public static Sentence Create(NounTypes noun, VerbTypes verb, DescriptorTypes descriptor)
        {
            Sentence sentence = new Sentence
            {
                Noun = noun,
                Verb = verb,
                Descriptor = descriptor
            };
            return sentence;
        }

        public bool Compare(Sentence sentence)
        {
            if (sentence.Verb != this.Verb)
                return false;
            if (sentence.Noun != this.Noun)
                return false;
            if (sentence.Descriptor != this.Descriptor)
                return false;
            // add comparison of conjunctions and extra descriptors
            return true;
        }

        public bool IsComplete()
        {
            if (Noun != NounTypes.Undefined)
                return false;
            if (Verb != VerbTypes.Undefined)
                return false;
            if (Descriptor != DescriptorTypes.Undefined)
                return false;
            if (ExtraDescriptors.Count != Conjunctions.Count)
                return false;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!IsComplete())
                throw IncompleteSentenceException();


            return sb.ToString();
        }
    }
}
