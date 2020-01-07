using System;

namespace operations
{
    public class Randomising
    {
        private static object random;

        public static int Randomise(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
            //return num;
        }
    }
}