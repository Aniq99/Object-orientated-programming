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
            Pack.testPack1.shuffleCardPack(1);

            // Ensuring that only one card has been dealt
            Pack.testPack1.deal();
            Debug.Assert(Pack.testPack1.pack.Count == 51);

            // Ensuring that 20 cards have been dealt
            Pack.testPack1.dealCard(10);
            Debug.Assert(Pack.testPack1.pack.Count == 41);

            // Riffle Shuffle 
            Pack.testPack2.shuffleCardPack(2);

            // Ensuring that only one card has been dealt
            Pack.testPack2.deal();
            Debug.Assert(Pack.testPack1.pack.Count == 51);

            // Ensuring that 20 cards have been dealt
            Pack.testPack2.dealCard(10);
            Debug.Assert(Pack.testPack1.pack.Count == 41);

            // No Shuffle 
            Pack.testPack3.shuffleCardPack(3);

            // Ensuring that only one card has been dealt
            Pack.testPack3.deal();
            Debug.Assert(Pack.testPack1.pack.Count == 51);

            // Ensuring that 20 cards have been dealt
            Pack.testPack3.dealCard(10);
            Debug.Assert(Pack.testPack1.pack.Count == 41);
        }
    }
}