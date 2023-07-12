/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
/*
int GetNumber(string msn)
{
    int number;
    Console.Write($"{msn}=> ");

    while(true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
        {
            return number;
        }
        Console.WriteLine($"This number {temp} is not correct. Try again: ");
    }
}
*/


int FaindEl(int[,]arrey,int m, int n )
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
           if(m>=0 && m<arrey.GetLength(0) && n>=0 && n< arrey.GetLength(1)) 
           {
            return arrey[m,n];
           }
            Console.WriteLine($"This number not exist.");
            
        }  
        
    }
    return arrey[m,n]; 
}

int[,]array = CreateArray(3, 4, 0, 100);
PrintArray(array);
Console.WriteLine($"input number row: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input number col: ");
int n = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(FaindEl(array,m, n));

