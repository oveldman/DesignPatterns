using System;
namespace Memento.Pattern
{
    public class SavedMessage
    {
        public string Subject { get; private set; }
        public string Message { get; private set; }

        public SavedMessage(string subject, string message)
        {
            Subject = subject;
            Message = message;
        }
    }
}
