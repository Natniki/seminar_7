/*/
Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] CreateArray(int row, int col, int min, int max)  
{
    Random rand = new Random();
    int [,] array = new int [row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
        array[i, j] = rand.Next(min, max+1);    
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
        Console.Write($"{array[i,j]}\t");
        }
    Console.WriteLine();
    }
}


float FindRes(int[,]arrey)//выводит массив из среднеарифметических значений
{
    float res = 0;
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arrey.GetLength(0); i++)
        {
            sum += arrey[i,j];
            res = sum/arrey.GetLength(0);
        }
        Console.Write($"{string.Join(", ", res)}\t");
    }
   return res;
}
int[,]myArray = CreateArray(3, 4, 0, 10);
PrintArray(myArray);
Console.WriteLine();;
FindRes(myArray);
 Console.WriteLine();


