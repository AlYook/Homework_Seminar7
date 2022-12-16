// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число поиска: ");
int num = int.Parse(Console.ReadLine());
int rows;
int columns;

int[,] array = GetArrayMatrix(rows = 4, columns = 4, 0, 10);
PrintArray(array);
CheckNum(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CheckNum(int[,] array)
{
    bool find = false;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j] == num)
            {
            Console.WriteLine($"число {num}: строка {i}, столбец {j}");
            find = true;
            }               
        }
    }
    if (find == false)
    {
        Console.WriteLine($"число {num} не найдено");
    }
}