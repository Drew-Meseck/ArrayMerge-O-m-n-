using System;

namespace ArrayMerge_O_m_n_
{
    class Program
    {
        /// <summary>
        /// Drew H. Meseck
        /// v0.0.1 (Alpha - Algorithmic Proof)
        /// LANGUAGE: C#
        /// Professor Owrang
        /// 
        /// DESCRIPTION:
        /// Algorithm that merges two sorted lists in O(n+m) time
        /// if n and m are the sizes of the respective lists.
        /// The function Merge(int[] l1, int[] l2) takes two SORTED
        /// lists and returns an efficiently spaced (no excess) array
        /// that is the sorted combination of those two lists.
        /// 
        /// This demonstration of the program then prints those lists,
        /// the lists used to test this were the two from class (L1 and
        /// L2 as shown below) and these lists in various combinations:
        /// 
        /// {1, 6, 9, 25, 32, 75, 120}
        /// {6, 7, 64, 85, 129, 189}
        /// {7, 9, 10, 15, 18, 500}
        /// 
        /// These lists were designed to tests extreme cases against one
        /// another in order to identify where there may be issues in 
        /// the consistency of correctness in the algorithm.
        /// 
        /// The existance of a singular while loop in the algorithm confirms
        /// that, in the worst case, the algorithm will complete in O(m+n)
        /// time.
        /// </summary>
        static void Main()
        {
            int[] L1 = { 5, 10, 55, 100 };
            int[] L2 = { 15, 55, 60, 200, 300 };

            PrintArray(Merge(L1, L2));
        }

        //ALGORITHM BEGINS HERE
        public static int[] Merge(int[] L1, int[] L2)
        {
            int[] L3 = new int[L1.Length + L2.Length]; //Initialize length of new list.
            int n = 0; //Index for list 1
            int m = 0; //Index for list 2
            int x = 0; //Index for list 3
            while(n <= L1.Length || m <= L2.Length)
            {
                if(n < L1.Length && m < L2.Length)
                {
                    if (L1[n] < L2[m])
                    {
                        L3[x] = L1[n];
                        x++;
                        n++;
                    }
                    else
                    {
                        L3[x] = L2[m];
                        m++;
                        x++;
                    }
                }else if(n == L1.Length && m != L2.Length)
                {
                    L3[x] = L2[m];
                    m++;
                    x++;
                }else if(m == L2.Length && n != L1.Length)
                {
                    L3[x] = L1[n];
                    x++;
                    n++;
                }
                else
                {
                    return L3;
                }
            }
            return L3;
        } //END ALGORITHM

        public static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write("]");
        }
    }
}
