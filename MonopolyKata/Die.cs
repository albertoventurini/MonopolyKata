using System;

namespace MonopolyKata
{
    public class Die
    {
        private readonly int _faces;
        private readonly Random _random;

        public int Faces
        {
            get { return _faces;  }
        }

        public Die(int faces)
        {
            _faces = faces;
            _random = new Random(DateTime.Now.Millisecond);
        }

        public int Roll()
        {
            return _random.Next(1, _faces);
        }
    }
}