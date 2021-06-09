using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 10)
            {
                return 0;
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 5)
            {
                return 1;
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 1)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }
    }
}
