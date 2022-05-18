using System;

namespace Compare_the_triplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
            {

                int[] tripletAlice = { a0, a1, a2 };
                int[] tripletBob = { b0, b1, b2 };

                int alice = 0;
                int bob = 0;

                for (int i = 0; i < tripletAlice.Length; i++)
                {
                    if (tripletAlice[i] > tripletBob[i])
                    {
                        alice++;
                    }
                    else if (tripletAlice[i] < tripletBob[i])
                    {
                        bob++;
                    }

                }
                int[] result = { alice, bob };
                return result;
            }
            static void Main(string[] args)
            {
                string[] tokens_a0 = Console.ReadLine().Split(' ');
                int a0 = Convert.ToInt32(tokens_a0[0]);
                int a1 = Convert.ToInt32(tokens_a0[1]);
                int a2 = Convert.ToInt32(tokens_a0[2]);
                string[] tokens_b0 = Console.ReadLine().Split(' ');
                int b0 = Convert.ToInt32(tokens_b0[0]);
                int b1 = Convert.ToInt32(tokens_b0[1]);
                int b2 = Convert.ToInt32(tokens_b0[2]);
                int[] result = solve(a0, a1, a2, b0, b1, b2);
                Console.WriteLine(String.Join(" ", result));
            }
        }

    }
}
