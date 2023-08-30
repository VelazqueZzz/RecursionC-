using System;
using System.ComponentModel.Design;

class RecursionDemo
{
    static int factorial(int n)
    {
        if (n == 1) return 1;
        else return n * factorial(n - 1);
    }
    static int fibs(int n)
    {
        if (n == 1 || n == 2) return 1;
        else return fibs(n - 1) + fibs(n - 2);
    }
    static int sum(int n)
    {
        if (n == 0) return 0;
        else return n + sum(n - 1);
    }
    static void show(int[] a,int k)
    {
        Console.Write(a[k] + " ");
        if (k == a.Length - 1)
        {
            Console.WriteLine();
        }
        else
        {
            show(a, k + 1);
        }
    }
    static void show(int[] a)
    {
        show(a, 0);
    }
    static void Main()
    {
        Console.WriteLine("Factorial chisla:");
        for (int k = 1; k < 10; k++)
        {
            Console.WriteLine(k + "!=" + factorial(k));
        }
        Console.WriteLine("Chisla Fabonacci:");
        for(int k = 1; k <= 10; k++)
        {
            Console.Write(fibs(k) + " ");
        }
        Console.WriteLine();
        Console.Write("summa chisel ot 1 do 100: ");
        Console.WriteLine(sum(100));
        int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
        Console.WriteLine("Chislovoi massiv:");
        show(A);
        Console.WriteLine("Elementi, nachinaya s tret'ego:");
        show(A, 2);

    }
}