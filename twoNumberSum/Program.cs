using System;




namespace twoNumberSum
{
    class Program
    {
        public static void main(String args)
        {
            new int[] array{ 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;
            TwoNumberSum();
        }
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            //Brute Force Method
            for (int i = 0; i < array.Length; i++)
            {
                int first = array[0];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int second = array[j];

                    if (targetSum == first + second)
                        return new int[] { first, second };
                }
            }
            return new int[0];
        }
    }
}


