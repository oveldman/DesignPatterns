using System;
namespace Interpreter.Pattern
{
    public abstract class Translator
    {
        protected string Language;

        public Translator()
        {
        }

        public void Translate(Context context)
        {
            string translation = context.Original switch
            {
                "Hallo" => TranslateHallo(),
                "Bye" => TranslateBye(),
                _ => TranslationNotFound(),
            };

            Console.WriteLine("Translation of " + Language + " " + context.Original + " = " + translation);
        }

        protected abstract string TranslateHallo();

        protected abstract string TranslateBye();

        protected string TranslationNotFound()
        {
            return "Translation not found!";
        }
    }
}
