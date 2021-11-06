/*
Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from  to  for three categories: problem clarity, originality, and difficulty.

We define the rating for Alice's challenge to be the triplet , and the rating for Bob's challenge to be the triplet .

Your task is to find their comparison points by comparing  with ,  with , and  with .

If , then Alice is awarded  point.
If , then Bob is awarded  point.
If , then neither person receives a point.
Comparison points is the total points a person earned.

Given  and , can you compare the two challenges and print their respective comparison points?


The first line contains  space-separated integers, a0, a1, and a2, describing the respective values in triplet . 
The second line contains  space-separated integers, b0, b1, and b2, describing the respective values in triplet .

Constraints

Output Format

Print two space-separated integers denoting the respective comparison points earned by Alice and Bob.

Sample Input

5 6 7
3 6 10
Sample Output

1 1 
Explanation

In this example:

a0 > b0, so Alice receives  point.
b0 > a0, so nobody receives a point.
a0 = b0, so Bob receives  point.
Alice's comparison score is , and Bob's comparison score is . Thus, we print 1 1 (Alice's comparison score followed by Bob's comparison score) on a single line.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] a0A1A2 = Console.ReadLine().Split(' ');

            int a0 = Convert.ToInt32(a0A1A2[0]);

            int a1 = Convert.ToInt32(a0A1A2[1]);

            int a2 = Convert.ToInt32(a0A1A2[2]);

            string[] b0B1B2 = Console.ReadLine().Split(' ');

            int b0 = Convert.ToInt32(b0B1B2[0]);

            int b1 = Convert.ToInt32(b0B1B2[1]);

            int b2 = Convert.ToInt32(b0B1B2[2]);

            int[] result = solve(a0, a1, a2, b0, b1, b2);

            Console.WriteLine(string.Join(" ", result));
        }

        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] cmp = { a0, a1, a2 };
            int[] cmp2 = { b0, b1, b2 };
            int[] ans = new int[2];

            for (int i = 0; i < 3; i++)
            {
                if (cmp[i] > cmp2[i])
                    ans[0] += 1;
                else if (cmp2[i] > cmp[i])
                    ans[1] += 1;
            }


            return ans;

        }
    }
}
