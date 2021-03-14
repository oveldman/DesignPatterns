using System;
namespace Interpreter.Pattern
{
    public class GermanTranslator : Translator
    {
        public GermanTranslator()
        {
            Language = "German";
        }

        protected override string TranslateBye()
        {
            return "Tschüss";
        }

        protected override string TranslateHallo()
        {
            return "Hallo";
        }
    }
}
