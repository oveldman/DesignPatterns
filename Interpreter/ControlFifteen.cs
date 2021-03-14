using System;
using System.Collections.Generic;
using Interpreter.Pattern;

namespace Interpreter
{
    public class ControlFifteen
    {
        public void Run()
        {
            Context first = new Context("Hallo");
            Context second = new Context("Bye");
            Context third = new Context("Random");

            List<Translator> allTranslators = new List<Translator>();
            allTranslators.Add(new DutchTranslator());
            allTranslators.Add(new GermanTranslator());
            allTranslators.Add(new JapanTranslator());

            foreach (Translator translator in allTranslators)
            {
                translator.Translate(first);
                translator.Translate(second);
                translator.Translate(third);
            }
        }
    }
}
