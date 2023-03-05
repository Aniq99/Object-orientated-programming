using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack playPack = new Pack();
            string choice = "";

            Console.WriteLine("How would you like to shuffle the pack?");
            Console.WriteLine("1 for Fisher-Yates Shuffle\n2 for Riffle Shuffle\n3 for No Shuffle");

            bool isValid = false;
            
            // Check to ensure that the input is a number
            while(!isValid) {
                Console.Write("Choice: ");
                choice = Console.ReadLine();
        
                try {
                    int shuffle = Convert.ToInt32(choice);
                    isValid = playPack.shuffleCardPack(shuffle);

                } catch (FormatException e) {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            }

            Console.WriteLine("Size of shuffled decks: {0}\n", playPack.Count);
            int dealNum = 0;

            while(dealNum < 1 || dealNum > playPack.Count) {
                Console.Write("Choose a number of cards to deal: ");
                string dealTotal = Console.ReadLine();
                try {
                    dealNum = Convert.ToInt32(dealTotal);
                } catch (FormatException e) {
                    Console.Write("Invalid input. Please enter a number.");
                }
            }

            switch(dealNum) {
                case 1:
                    playPack.deal();
                    break;
                default:
                    playPack.dealCard(dealNum);
                    break;
            }

        }
    }
}
