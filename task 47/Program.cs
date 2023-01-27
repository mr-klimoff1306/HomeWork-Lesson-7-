/*
Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

int rows = 3;
int colums = 4;
double[,] numbers = new double[rows, colums];
FillArray(numbers);
PrintArray(numbers);

// Заполнение массива рандомными числами
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "|  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

