using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new pack object
            new Pack();    
           
            //get input from user on how they wouldd like to shuffle the pack
            string choice = "";
            Console.WriteLine("How would you like to shuffle the pack?");
            Console.WriteLine("1 for Fisher-Yates Shuffle\n2 for Riffle Shuffle\n3 for No Shuffle");

            bool isValid = false;
            
            // loop to ensure that the input is a number
            while(!isValid) {
                Console.Write("Choice: ");
                choice = Console.ReadLine();
        
                try {
                    //try and convert users input into an integer
                    int shuffle = Convert.ToInt32(choice);
                    isValid = Pack.shuffleCardPack(shuffle);


                } catch (FormatException) {
                    //catches an exception if the user doesn't enter a number
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            }
            int size = Pack.getPackSize();

            Console.WriteLine("Size of shuffled decks: {0}\n", size);
            int dealNum = 0;

            //loop to ensure input from user is number that is between 1 and 52(inc.)
            while(dealNum < 1 || dealNum > size) {
                Console.Write("Choose a number of cards to deal: ");
                string dealTotal = Console.ReadLine();
                try {
                    dealNum = Convert.ToInt32(dealTotal);
                } catch (FormatException) {
                    Console.Write("Invalid input. Please enter a number.");
                }
                            

            }

            //deals number of cards user requested
            switch(dealNum) {
                case 1:
                    Pack.deal();
                    break;
                default:
                    Pack.dealCard(dealNum);
                    break;
            }

            Console.Read();

        }
    }
}
