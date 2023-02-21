// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] EnterArr()
{
    System.Console.WriteLine("Введите количество строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] Rand = new int[m, n];
    for (int i = 0; i < Rand.GetLength(0); i++)
    {
        for (int j = 0; j < Rand.GetLength(1); j++)
        {
            Rand[i, j] = new Random().Next(-10, 10);
            System.Console.Write($"{Rand[i, j],4} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return Rand;
}

void NUM(int[,] Array)
{
    System.Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] == num) 
            {
            System.Console.Write("число есть в массиве ");
            }
            if (Array[i, j] != num)
            {
            System.Console.Write("Числа нет в массиве ");
            } 
        }
        
    }
}

NUM(EnterArr());

