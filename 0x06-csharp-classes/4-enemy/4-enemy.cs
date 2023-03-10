using System;

namespace Enemies
{
    /// <summary>
    /// This class is empty
    /// </summary>
    public class Zombie
    {
        // Private field thats defines the health of the zombie
        private int health;
        // Private field that defines the name of the zombie
        private string name = "(No name)";
        /// <summary> Gets or sets the name of the zombie</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary> Initializes a new instance of <see cref="Zombie"/> class.</summary>
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

        /// <summary>Gets the health of a zombie</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}