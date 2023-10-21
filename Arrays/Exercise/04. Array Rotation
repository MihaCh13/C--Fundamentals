using System;

class Program
{
    static void Main(string[] args)
    {
        // Въвеждаме масив от стрингове и брой ротации
        string[] num = Console.ReadLine().Split(" ");
        int length = num.Length;
        int spins = int.Parse(Console.ReadLine());

        // Преобразуваме стринговия масив в масив от цели числа
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(num[i]);
        }

        // Изпълняваме ротациите
        for (int i = 0; i < spins; i++)
        {
            RotateArray(array);
        }

        // Извеждаме получения масив
        Console.WriteLine(string.Join(" ", array));
    }

    // Методът RotateArray извършва една ротация наляво
    static void RotateArray(int[] array)
    {
        int temp = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = temp;
    }
}
