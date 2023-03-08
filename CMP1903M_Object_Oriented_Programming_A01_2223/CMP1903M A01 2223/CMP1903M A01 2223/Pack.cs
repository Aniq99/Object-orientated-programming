using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
       private static List<Card> pack = new List<Card>();
        public Pack()
        {
            //Initialise the card pack here
            for (int i = 1; i <= 13; i++) {
				for(int j = 1; j <= 4; j++) {
					// Create a new card with the value and suit, then add it to the pack
					Card card = new Card() {Value = (i), Suit = (j)};
					pack.Add(card);
				}
            }
			
			// Check to see if the created pack is of the correct size
			if(getPackSize() == 52) {
				Console.WriteLine("Successfully created pack.");
			} else {
				Console.WriteLine("Something went wrong with the pack creation. Pack of size {0} was created.", getPackSize());
			}
		}

		private static void fisherYates()
		{
            Console.WriteLine("Fisher Yates Shuffle requested...");
            Random rng = new Random();
            int packSize = getPackSize();
            for (int i = 0; i < (packSize - 1); i++)
            {
                // Generate a random number
                int rand = i + rng.Next(packSize - i);

                // Swap the cards around based on the random numbers
                Card temp = pack[rand];
                pack[rand] = pack[i];
                pack[i] = temp;
            }
        }

		private static void riffleShuffle()
		{
            // Riffle shuffle
            Console.WriteLine("Riffle Shuffle requested...");
            // Create two lists to hold both halves of the list 
            List<Card> topHalf = new List<Card>();
            List<Card> bottomHalf = new List<Card>();

            // Add the first 26 cards to one list and the last 26 to the other
            for (int i = 0, j = 26; i < 26; i++, j++)
            {
                topHalf.Add(pack[i]);
                bottomHalf.Add(pack[j]);
            }

            // Empty the pack 
            pack.Clear();

            // Add cards from both lists to form the riffle shuffle pack
            for (int i = 0; i < 26; i++)
            {
                pack.Add(topHalf[i]);
                pack.Add(bottomHalf[i]);
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
			/* if tOS = 1 -> Fisher Yates Shuffle
				else if tOS = 2 -> Riffle Shuffle
				else do nothing */
			switch(typeOfShuffle) {
				case 1:
					// Fisher yates shuffle
					fisherYates();
					
					Console.WriteLine("Pack Shuffled.");
					return true;

				case 2:
                    //riffle shuffle
                    riffleShuffle();

					Console.WriteLine("Pack Shuffled.");
					return true;

				case 3:
					// No shuffle
					Console.WriteLine("No shuffle requested...");
					return true;
			}

			// returns false if typeOfShuffle is not between 1 and 3 
			return false;
        }
        public static Card deal()
        {
            //Deals one card from the pack
			Card dealtCard = pack.ElementAt(0);
			Console.WriteLine("Dealt card: Value - {0}  Suit - {1}", dealtCard.Value, dealtCard.Suit);
			pack.Remove(dealtCard);
			return dealtCard;
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'

			// Temporary list to hold dealt cards 
			List<Card> dealtCards = new List<Card>();

			// Add the first "amount" of cards to tempList and remove from the pack
			for(int i = 0; i < amount; i++) {
				dealtCards.Add(pack[0]);
				pack.RemoveAt(0);
				Console.WriteLine("Dealt card: Value - {0}  Suit - {1}", dealtCards[i].Value, dealtCards[i].Suit);
			}

			return dealtCards;
        }

        public static int getPackSize()
        {
            return pack.Count;
        }

    }
}
