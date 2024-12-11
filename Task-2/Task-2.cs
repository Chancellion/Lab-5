using System;

public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int[] Add(int[] a, int[] b)
    {
        if (a.Length != b.Length)
            throw new ArgumentException("Масиви повинні бути однакової довжини");

        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] + b[i];
        }
        return result;
    }
    public int[,] Add(int[,] a, int[,] b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
            throw new ArgumentException("Матриці повинні бути однакових розмірів");

        int[,] result = new int[a.GetLength(0), a.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }
        return result;
    }
    public int[,,] Add(int[,,] a, int[,,] b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1) || a.GetLength(2) != b.GetLength(2))
            throw new ArgumentException("Тензори повинні бути однакових розмірів");

        int[,,] result = new int[a.GetLength(0), a.GetLength(1), a.GetLength(2)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int k = 0; k < a.GetLength(2); k++)
                {
                    result[i, j, k] = a[i, j, k] + b[i, j, k];
                }
            }
        }
        return result;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
        MathOperations mathOps = new MathOperations();
        int sum = mathOps.Add(565, 342);
        Console.WriteLine("Сума чисел: " + sum);

        int[] array1 = { 15, 25, 64 };
        int[] array2 = { 44, 51, 11 };
        int[] arraySum = mathOps.Add(array1, array2);
        Console.WriteLine("Сума масивів: " + string.Join(", ", arraySum));
    }
}
