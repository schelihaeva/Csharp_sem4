// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по убыванию.




Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// // // Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// // // minValue - мин. число для рандома, maxValue - макс. число для рандома
int[,] MatrixOperations(int m, int n, int minValue, int maxValue)
{
int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
{
// i, j, k, m
for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
{
matrix[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return matrix;
}


void PrintMatrix(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++) // строчки
{
for (int j = 0; j < matr.GetLength(1); j++) // столбцы
{
Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
}
Console.WriteLine();
}
}

// void SortRowsDescending(int[,] matr)
// {
// int indexLastRow = matr.GetLength(0) + 1; // Индекс посл. стр
// //  int dummy = m[i];
// //                     m[i] = m[min];
// //                     m[min] = dummy;

// // 1 2 3
// // ..........
// // 4 5 6
// for (int i = 0; i < matr.GetLength(0); i++)
// {
// int temp = matr[i]; // temp = matr[0,0]; temp = 1
// matr[i] = matr[minValue]; // matr[0,0] = 4
// // 4 2 3
// // ..........
// // 4 5 6
// matr[minValue] = temp; // temp = 1
// // 4 2 3
// // ..........
// // 1 5 6

// }
// }

int SortRowsDescending(int[,] matrix);
int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
{
    {
        for(int k =0;matrix.GetLength(1)-1; k++)
        {
            if(matrix[i,k] < matrix[i,k-1])
            {
                int result = matrix[i,k+1];
                matrix[i,k+1] = matrix[i,k];
                matrix[i,k] = result;
            }
        }
    }
}
}
return result;


int[,] array2D = MatrixOperations(rows, columns, 0, 10);
PrintMatrix(array2D);
Console.WriteLine("Результат: ");
SortRowsDescending (array2D);
PrintMatrix(array2D);


// int[,] ChangeMatrix(int[,] matrix)
// {
// int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)]; // result - копия матрицы
// for (int i = 0; i < matrix.GetLength(0); i++) // строчки
// {
// for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
// {
// result[j, i] = matrix[i, j];
// }
// }
// return result;
// }