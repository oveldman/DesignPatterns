using System;
namespace Interpreter.Pattern
{
    public class DutchTranslator : Translator
    {
        public DutchTranslator()
        {
            Language = "Dutch";
        }

        protected override string TranslateBye()
        {
            return "Doei";
        }

        protected override string TranslateHallo()
        {
            return "Dag";
        }
    }
}
