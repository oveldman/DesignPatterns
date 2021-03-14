using System;
using FactoryMethod.Concretes;
using FactoryMethod.Creators;

namespace FactoryMethod
{
    public class ControlThird
    {
        public void Run()
        {
            Game[] games = new Game[2];
            games[0] = new Pokemon();
            games[1] = new Fallout4();

            foreach (Game game in games)
            {
                Console.WriteLine(game.GetType().Name + "--");
                foreach (AbstractCharacter character in game.GetCharacters())
                {
                    Console.WriteLine(" " + character.GetType().Name);
                }
            }
        }
    }
}
