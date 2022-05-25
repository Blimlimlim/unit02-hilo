using System;
using System.Collections.Generic;

namespace unit02_hilo
{
    public class Card
    {
        /// <summary>
        /// The value assigned to the card object.
        /// </summary>
        public int value;
        // public Card(int a)
        // {
        //     value = a;
        // }


        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
        
        }

        /// <summary>
        /// Generates a random value and assigns it to the card object.
        /// </summary>
        public void Pull()
        {
            Random random = new Random();
            value = random.Next(1, 12);
        }
        
        
    }
}