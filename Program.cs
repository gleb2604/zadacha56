/*
Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Write("Введите размер строки: ");
int rowsLenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int columsLenght = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rowsLenght,columsLenght];

getRandomMatrix(matrix);
printMatrix(matrix);
 minSummRows(matrix);



void getRandomMatrix(int[,] matrix)
{   
    int LeftRange = 0;
    int RightRange = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(LeftRange,RightRange);
        }   
    }
}

void printMatrix(int[,] matrix){
    for(int i = 0; i< matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
           Console.Write(matrix[i,j] + " ");
        }
        
        Console.WriteLine();
    }
}
void minSummRows(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");

}ad