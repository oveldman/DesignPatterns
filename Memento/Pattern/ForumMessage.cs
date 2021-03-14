using System;
namespace Memento.Pattern
{
    public class ForumMessage
    {
        private string _subject;
        private string _message;

        public SavedMessage SaveMessage()
        {
            Console.WriteLine("Saving message...");
            return new SavedMessage(_subject, _message);
        }

        public string Subject
        {
            get { return _subject; }
            set {
                _subject = value;
                Console.WriteLine("Set Subject to: " + value);
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                Console.WriteLine("Set Message to: " + value);
            }
        }

        public void RestoreSavedMessage(SavedMessage savedMessage)
        {
            Console.WriteLine("Restoring saved message...");
            Subject = savedMessage.Subject;
            Message = savedMessage.Message;
        }
    }
}
