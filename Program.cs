// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int MeanSum(int[,] array)
{
    int numRows = array.GetLength(0);
    double meanSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i < array.GetLength(0))
            {
                meanSum = meanSum + array[i, j];
            }
        }
        meanSum = meanSum / numRows;
        System.Console.Write($"{meanSum}; ");
        meanSum = 0;
    }
    return (int)meanSum;
}

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
MeanSum(myArray);
