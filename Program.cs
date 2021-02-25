using System;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = {0,2,4,6,8,10};
            int[] arrayB = {1,3,5,7,9};
            int[] arrayC = {3,1,4,1,5,9,2,6,5,3,5,9};

            Console.WriteLine("Mean of all three arrays: ");
            Console.WriteLine($"Mean of arrayA: {Counts(arrayA)}");
            Console.WriteLine($"Mean of arrayB: {Counts(arrayB)}");
            Console.WriteLine($"Mean of arrayC: {Counts(arrayC)}\n");


            Console.WriteLine("Rotate Array");
            PrintArray(arrayA);
            PrintArray(RotateArray("right", 2, arrayA));
            Console.WriteLine();

            Console.WriteLine("Sort Array");
            PrintArray(arrayC);
            PrintArray(SortArray(arrayC));
            Console.WriteLine();

            Console.WriteLine("Reverse Array");
            PrintArray(arrayB);
            PrintArray(ReverseArray(arrayB));
            Console.WriteLine();

        }

        static public int[] SortArray(int[] arr) 
        {

            int arrayLength = arr.Length - 1;


            for (int i = 0; i < arrayLength ; i++)
            {
                for (int j = 0; j < arrayLength - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                
            }
            return arr;
        }

        static public double Counts(int[] arr) 
        {
       
            int numInArray = 0;
            int sum;
            double average;
            for (int i = 0; i < arr.Length; i++)
            {
                numInArray++;
            }

            sum = Sum(arr);

            average = (double)sum / numInArray;

            return average;
        }

        static int Sum(int[] arr) 
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static int[] ReverseArray(int[] arr) 
        {
            int[] reverse = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reverse[i] = arr[arr.Length - 1 - i];

            }
            
            return reverse;
        }

        static int[] RotateArray(int numOfSteps, int[] array) 
        {
            int[] rotate = new int[array.Length];
            if (numOfSteps < 1) numOfSteps += array.Length;
         
            for (int i = 0; i < array.Length; i++)
            {
                rotate[(i + numOfSteps) % array.Length] = array[i];
            }
            return rotate;
        }

        static int[] RotateArray(string direction, int numOfSteps, int[] array)
        {
            if (direction.ToLower()== "left")
            {
                numOfSteps = -numOfSteps;
            }

            return RotateArray(numOfSteps, array);
        }

        static void PrintArray(int[] arr) 
        {
            try
            {
                if (arr != null) {
                    Console.Write("{");

                    Console.Write(arr[0]);
                    for (int i = 1; i < arr.Length; i++)
                    {
                        Console.Write($",{arr[i]}");
                    }

                    Console.Write("}\n");
                }
                else 
                {
                    throw new ArgumentException("Array is Empty");
                }
            }
            catch (ArgumentException nEx)
            {
                Console.WriteLine(nEx.Message);
            }
        }
    }
}
