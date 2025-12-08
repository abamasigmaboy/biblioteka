namespace MatrixLib
{
    public static class MatrixTasks
    {
        public static void SwapMinMaxOnMainDiagonal(double[,] a)
        {
            int n = a.GetLength(0);

            int iMin = 0, iMax = 0;
            double min = a[0, 0], max = a[0, 0];

            for (int i = 1; i < n; i++)
            {
                double v = a[i, i];
                if (v < min) { min = v; iMin = i; }
                if (v > max) { max = v; iMax = i; }
            }

            double tmp = a[iMin, iMin];
            a[iMin, iMin] = a[iMax, iMax];
            a[iMax, iMax] = tmp;
        }
    }
}
