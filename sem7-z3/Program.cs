// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате
// The averages in columns are:
// x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число,на которое увеличивается элемент: ");
int k = Convert.ToInt32(Console.ReadLine());

void PrintArray (int [,] matrix)
    {
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1);j++)
            {
                Console.Write($"{matrix[i,j]}"+"\t");
            }
            Console.WriteLine();
        }
    }



int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] newMatrix = new int[n,m];
        int currentValue = 1;
        for (int i=0; i<n; i++)
        {
            for (int j=0; j<m; j++)
            {
                newMatrix[i,j] = currentValue;
                currentValue += k;
            }
        }
        return newMatrix;
        System.Console.WriteLine();
    }

void PrintListAvr (double [] list)
    {
        Console.WriteLine("The averages in columns are:");
        foreach (double el in list)
        {
            Console.Write($"{el:f2}"+"\t");

        }
        Console.WriteLine();
    }

double [] FindAverageInColumns (int [,] matrix)
    { 
        double runningSum=0;
        double [] columns = new double [matrix.GetLength(1)];
        for (int j=0; j<matrix.GetLength(1);j++)
        {
            runningSum=0;
            for (int i=0; i<matrix.GetLength(0);i++)
            {
                runningSum=runningSum+matrix[i,j];
            }
            columns[j]=runningSum/matrix.GetLength(0);
        }
        return columns;
    }

int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
        