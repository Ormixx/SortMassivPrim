using SortedArrayExample.AllTogether;
using System;


public class MainClass
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int size = 100;
        IArrayOperations arrayManipulator = new SortedArray(size);

        for (int i = 0; i < size; i++)
        {
            arrayManipulator.Add(random.Next(50));
        }

        arrayManipulator.Display();

        long randomValueToSearch = random.Next(50);
        if (arrayManipulator.Contains(randomValueToSearch))
        {
            Console.WriteLine($"Значение было найдено: {randomValueToSearch}");
        }
        else
        {
            Console.WriteLine($"Не удалось найти значение: {randomValueToSearch}");
        }

        Console.WriteLine($"Минимальное значение: {arrayManipulator.GetMin()}");
        Console.WriteLine($"Максимальное значение: {arrayManipulator.GetMax()}");
    }
}