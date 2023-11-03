Console.Write("Введите количество строк в массиве: ");
int n= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Random random = new Random();

double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
    double[, ] matrix = new double[m, n];

    for (int i = 0; i < m; i++) {
      for (int j = 0; j < n; j++) {
        matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1) + random.NextDouble();
      }
    }

    return matrix;
  }
void PrintArray(double[, ] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
      for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j]:f2}\t");
      }
      Console.WriteLine();
    }
  }

 void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;

      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
