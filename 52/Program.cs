// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double MID(int[,] Array)
{
    int sum = 0;
    double mid = 0;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    
        for (int j = 0; j < Array.GetLength(1); j++)
        {
                sum +=  Array[0, j];
                mid += sum / Array.GetLength(1);
            System.Console.Write($"{mid};");
            }

    return mid;
}

MID(EnterArr());
