using System;
namespace Interpreter.Pattern
{
    public class JapanTranslator : Translator
    {
        public JapanTranslator()
        {
            Language = "Japanese";
        }

        protected override string TranslateBye()
        {
            return "Sayōnara";
        }

        protected override string TranslateHallo()
        {
            return "Kon'nichiwa";
        }
    }
}
