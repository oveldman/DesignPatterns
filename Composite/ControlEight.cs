using System;
using Composite.Pattern;

namespace Composite
{
    public class ControlEight
    {
        public void Run()
        {
            IElement root = new Container("Admin page");
            root.Add(new Label("Title"));
            root.Add(new Label("Description"));

            IElement footer = new Container("Footer");
            footer.Add(new Label("Contact link"));
            root.Add(footer);

            IElement error = new Label("Error message");
            root.Add(error);
            root.Remove(error);

            root.Draw(1);
        }
    }
}
