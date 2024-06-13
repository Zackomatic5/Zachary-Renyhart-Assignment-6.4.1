using System.IO;

namespace Zachary_Renyhart_Assignment_6._4._1
{
    internal class Program
    {
        //You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
        //You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.DO NOT allocate another 2D matrix and do the rotation.
        static void Main(string[] args)
        {
            int num = 3;
            //[,] - Means multidimentional array
            int[,] array = { { 1, 2, 3 }, 
                             { 4, 5, 6 }, 
                             { 7, 8, 9 } };
            Console.WriteLine("This is the starting Matrix");
            Print(array);
            Console.WriteLine();

            for (int i = 0; i < num /2; i++)
            {//Remember I & J's initial values are 0.
                for (int j = 0; j < num -1-i; j++)
                {
                    //This holds the temp value from the array.
                    //Pay attention to the commas below to see what operation is doing what!
                    int temp = array[i, j]; // Temp stores the current element [0,0] in a temporary variable while the loop runs.

                    
               //Array [i,j] is [0,0]   //This is [2,0] Num-1 = 2, i = 0.
                    array[i,j] = array[num-1-j, i]; //Move the element from the bottom-left to the top-left.

                                            //This is [2,2] num-1 = 2 and num-1=2. 
                    array[num - 1 - j, i] = array[num-1-i, num-1-j]; // Move the element from the bottom-right to the bottom-left.

                                                        //This is J = 0, Num-1-i = 2 so [0,2]
                    array[num - 1 - i, num - 1 - j] = array[j, num - 1 - i]; //Move the element from the top-right to the bottom-right.
                        
                    //This is moving Temp [0,0] to [0,2]
                    array[j, num-1-i] = temp; //Move the element from the top-left to the top-right.
                    
                }
                //After the 90 degree rotation the outer elements of the matrix are shifted --> by one position, and the inner elements are shifted accordingly layer by layer.
            }
            Console.WriteLine("This is the Matrix rotated 90 degrees");
            Print(array);
        }
        //This is prtining the 2 dimentional matrix
        static void Print(int[,] array)
        {
            int num = 3; //If I is less than 3 or "n"
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
            //When you call the Print method with a 2D array as an argument.
            //it iterates through each element of the array and prints them in row-major order, separated by spaces, with each row printed on a separate line.
        }
    }
}
