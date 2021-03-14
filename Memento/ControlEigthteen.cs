using System;
using Memento.Pattern;

namespace Memento
{
    public class ControlEigthteen
    {
        public void Run()
        {
            Memory systemMemory = new Memory();
            ForumMessage message = new ForumMessage();
            message.Subject = "Test Memento";
            message.Message = "Better test memento";

            systemMemory.SavedMessage = message.SaveMessage();

            message.Subject = "Tester";
            message.Message = "Change the value here";

            message.RestoreSavedMessage(systemMemory.SavedMessage);
        }
    }
}
