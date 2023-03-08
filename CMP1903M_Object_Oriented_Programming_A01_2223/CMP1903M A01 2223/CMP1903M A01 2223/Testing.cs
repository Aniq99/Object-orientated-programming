using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void main(string[] args)
        {
            // New pack object 
            new Pack();
            
           

            // Fisher-Yates Shuffle
            Pack.shuffleCardPack(1);

            // Ensuring that only one card has been dealt
            Pack.deal();
            Debug.Assert(Pack.getPackSize() == 51);

            // Ensuring that 20 cards have been dealt
            Pack.dealCard(10);
            Debug.Assert(Pack.getPackSize() == 41);

            new Pack();

            // Riffle Shuffle 
            Pack.shuffleCardPack(2);

            // Ensuring that only one card has been dealt
            Pack.deal();
            Debug.Assert(Pack.getPackSize() == 51);

            // Ensuring that 20 cards have been dealt
            Pack.dealCard(10);
            Debug.Assert(Pack.getPackSize() == 41);

            new Pack();

            // No Shuffle 
            Pack.shuffleCardPack(3);

            // Ensuring that only one card has been dealt
            Pack.deal();
            Debug.Assert(Pack.getPackSize() == 51);

            // Ensuring that 20 cards have been dealt
            Pack.dealCard(10);
            Debug.Assert(Pack.getPackSize() == 41);

            Console.Read();
        }
    }
}