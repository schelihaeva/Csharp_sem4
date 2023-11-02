Random random = new Random();

  public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
    double[, ] matrix = new double[m, n];

    for (int i = 0; i < m; i++) {
      for (int j = 0; j < n; j++) {
        matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1) + random.NextDouble();
      }
    }

    return matrix;
  }

  public static void PrintArray(double[, ] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
      for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j]:f2}\t");
      }
      Console.WriteLine();
    }
  }

  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

