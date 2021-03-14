using System;
using System.Collections.Generic;
using FactoryMethod.Concretes;

namespace FactoryMethod.Creators
{
    public abstract class Game
    {
        private List<AbstractCharacter> _characters = new List<AbstractCharacter>();

        public Game()
        {
            CreateCharacters();
        }

        public List<AbstractCharacter> GetCharacters()
        {
            return _characters;
        }

        public abstract void CreateCharacters();
    }
}
