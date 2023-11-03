// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// // // Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// // // minValue - мин. число для рандома, maxValue - макс. число для рандома

int[,] SumOfRow [int[,], matrix , int row] // [кол-во строк, кол-во столбцов]
{
    int sum = 0;
for (int i = 0; i < matrix.GetLength(1); i++) // строчки, m = matrix.GetLength(0)
{

sum+ = matrix[rows,i];
}
return sum;
}
System.Console.Write();
