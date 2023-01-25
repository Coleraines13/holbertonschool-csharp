using System;

namespace Enemies
{
    /// <summary>
    /// This class is empty
    /// </summary>
    public class zombie
    {
        /// <summary>Defines the health of zombie</summary>
        public int health;
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new instance of <see cref="Zombie"/> class and checks if value is gretaer than 0</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}