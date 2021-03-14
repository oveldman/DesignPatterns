using System;
namespace Facade.Pattern
{
    public class House
    {
        private Human _human;
        private Elevator _elevator;
        private Door _door;

        public House()
        {
            _human = new Human();
            _elevator = new Elevator();
            _door = new Door();
        }

        public void GoInside()
        {
            _human.Walk();
            _elevator.GoUp();
            _door.Open();
        }
    }
}
