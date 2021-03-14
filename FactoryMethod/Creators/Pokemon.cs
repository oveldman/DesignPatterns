using System;
using FactoryMethod.Concretes;

namespace FactoryMethod.Creators
{
    public class Pokemon : Game
    {
        public override void CreateCharacters()
        {
            GetCharacters().Add(new Ash());
            GetCharacters().Add(new Brock());
        }
    }
}
