using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
		private int val;
		private int suit;
        public int Value { 
            get { return val; } 
            set { 
                // Ensures that the value is between 1 and 13
                if((value > 0) && (value < 14)) {
                    val = value; 
                }
            }
        }
        public int Suit { 
            get { return suit; } 
            set { 
                // Ensures that the suit is between 1 and 4 
                if((value > 0) && (value < 5)) {
                    suit = value; 
                }
            }
        }
    }
}
