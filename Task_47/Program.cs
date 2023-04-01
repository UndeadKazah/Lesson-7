double[,] a = new double[3, 4];

Random random = new Random();
for (int m = 0; m < 5; m++)
{
    for (int n = 0; n < 4; n++)
    {
        a[m, n] = random.NextDouble() * 10; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[m, n]);
    }
    Console.WriteLine();
}