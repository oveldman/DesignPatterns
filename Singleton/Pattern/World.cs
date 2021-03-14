using System;
namespace Singleton.Pattern
{
    public class World
    {
        public string Seed { get; private set; }
        private static World _instance;
        private Random _random = new Random();
        private static object syncLock = new object();

        protected World()
        {
            string[] randomSeeds = { "Earth", "Mario World", "Japan" };

            int index = _random.Next(randomSeeds.Length);
            Seed = randomSeeds[index];
        }

        public static World Instance()
        {
            if (_instance == null)
            {
                lock (syncLock) {
                    if (_instance == null) {
                        _instance = new World();
                    }
                }
            }

            return _instance;
        }

    }
}
