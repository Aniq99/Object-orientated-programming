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
            Pack testPack1 = new Pack();
            Pack testPack2 = new Pack();
            Pack testPack3 = new Pack();

            // Fisher-Yates Shuffle
            testPack1.shuffleCardPack(1);

            // Ensuring that only one card has been dealt
            testPack1.deal();
            Debug.Assert(testPack1.Count == 51);

            // Ensuring that 20 cards have been dealt
            testPack1.dealCard(10);
            Debug.Assert(testPack1.Count == 41);

            // Riffle Shuffle 
            testPack2.shuffleCardPack(2);

            // Ensuring that only one card has been dealt
            testPack2.deal();
            Debug.Assert(testPack1.Count == 51);

            // Ensuring that 20 cards have been dealt
            testPack2.dealCard(10);
            Debug.Assert(testPack1.Count == 41);

            // No Shuffle 
            testPack3.shuffleCardPack(3);

            // Ensuring that only one card has been dealt
            testPack3.deal();
            Debug.Assert(testPack1.Count == 51);

            // Ensuring that 20 cards have been dealt
            testPack3.dealCard(10);
            Debug.Assert(testPack1.Count == 41);
        }
    }
}