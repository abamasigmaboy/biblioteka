using MatrixLib;
    {
        int n = 7;
        double[,] a = new double[n, n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                a[i, j] = rnd.NextDouble() *  10; 
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(a);
        MatrixTasks.SwapMinMaxOnMainDiagonal(a);
        Console.WriteLine("\nПосле обмена min и max на главной диагонали:");
        PrintMatrix(a);
    }
    public PrintMatrix(double[,] a)
    {
        int n0 = a.GetLength(0);
        int n1 = a.GetLength(1);
        for (int i = 0; i < n0; i++)
        {
            for (int j = 0; j < n1; j++)
                Console.Write($"{a[i, j]:F2}\t");
            Console.WriteLine();
        }
    }

