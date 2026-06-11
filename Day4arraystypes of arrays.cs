//arrays = array is a collection of data of same data types in which multiple values can be stored.
// Types of array :-
//  Single dimensional array = it is a common type of array in which data can be stored in one line.
//  Multi dimensional array = it is a type of array in which data is stored in rows and column.
//  Jagged array = it is a type of array where each row can have a different number of elements.


//Single dimensional array
using System;
namespace arrayexample
{
    class Program
    {
        static void Main()
        {
            int[] marks = { 80, 90, 70, 85 };

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
//output = 80
//         90
//         70
//         85


//Multi dimensional array
using System;

class Program
{
    static void Main()
    {
        int[,] arr = { { 10, 20 },
            { 30, 40 } };

        Console.WriteLine(arr[0, 0]); // 10
        Console.WriteLine(arr[1, 1]); // 40
    }
}

//output :-  10
//           40 


//Jagged array
using System;

class Program
{
    static void Main()
    {
        int[][] numbers =
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Console.Write(numbers[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
//output:-1 2 3
//        4 5
//        6 7 8 9
