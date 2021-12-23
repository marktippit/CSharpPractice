using System;

namespace chap8Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //8.3
            //Arrays are a grouping of related data items of the same type, fixed-length

            //declaring Arrays in c#
            int[] array = new int[5];
            //int[] b;
            //b = new int[12];

            //these are static arrays that are fixed length
            //you can resize though i.e.
            //Array.Resize(ref c, 5);//array C is now size 5 (0,1,2,3,4) instead if 12
            

            Console.WriteLine($"{"Index"}{"Value",8}");//Headings

            //output each array element's value
            for (int counter = 0; counter < array.Length; counter++)
            {
                Console.WriteLine(($"{counter,5}{array[counter], 8}"));
            }
            */

            /*
            //8.4 Computing the sum of the elements of an array
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            //sum the elements in the array
            for(int counter = 0; counter < array.Length; counter++)
            {
                total += array[counter];
            }

            Console.WriteLine($"Total sum in array = {total}");
            */
            /*
            //8.5 foreach loops
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            foreach (int number in array)
            {
                total += number;
            }
            Console.WriteLine($"Total sum in array = {total}");
            */

            /*
            int[] array = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 }; //distribution

            Console.WriteLine("Grade Distribution");

            //for each array element, output a bar of the chart

            for (var counter = 0; counter < array.Length; counter++)
            {
                if(counter ==10)
                    Console.Write("  100: ");
                else
                {
                    Console.Write($"{counter * 10:D2}-{counter *10+9:D2}: ");
                }

                //display bar of asterisks
                for( var stars = 0; stars < array[counter]; stars++ )
                    Console.Write("*");
                Console.WriteLine();
            }
            */

            /**/
            //8.5 exception handling

            //student responses array
            int[] responses = {1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3,
                               2, 3, 3, 2, };

            var frequency = new int[6];
            //for each answer, select responses element and use that value
            //as frequency index to determine element increment

            for (var answer = 0; answer < responses.Length; answer++)
            {
                try
                {
                    ++frequency[responses[answer]];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(
                        $"  responses[{answer}] = {responses[answer]}\n");
                }
            }

            Console.WriteLine($"{"Rating"}{"Frequency",10}");

            //output each array element's value
            for (var rating = 1; rating < frequency.Length; rating++)
            {
                Console.WriteLine($"{rating,6}{frequency[rating], 10}");
            }

        }
    }
}
