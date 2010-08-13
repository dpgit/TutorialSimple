// arrays.cs
using System;
class DeclareArraysSample
{
    static void f()
    {
        // Single-dimensional array
        int[] numbers = new int[5];

        // Multidimensional array
        string[,] names = new string[5, 4];

        // Array-of-arrays (jagged array)
        byte[][] scores = new byte[5][];

        // Create the jagged array
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = new byte[i + 3];
        }

        // Print length of each row
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
        }
    }

    static void g(int[] a)
    {
        foreach(int i in a)
            Console.Write("{0} ", i);
    }

    public static void Main()
    {
        f();

        int[] a = { 1, 2, 3, 4, 5 };
        g(a);
    }
}
