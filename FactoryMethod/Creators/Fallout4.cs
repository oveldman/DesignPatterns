using System;
using FactoryMethod.Concretes;

namespace FactoryMethod.Creators
{
    public class Fallout4 : Game
    {
        public override void CreateCharacters()
        {
            GetCharacters().Add(new Dogmeat());
            GetCharacters().Add(new Goodfeels());
        }
    }
}
