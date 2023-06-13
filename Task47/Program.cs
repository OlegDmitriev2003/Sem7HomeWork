Console.Clear();
int end = -100;
int begin = 100;
Console.Write("Введите число рядов: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int collumns = int.Parse(Console.ReadLine()!);
double [,] numbers = new double [rows, collumns];
for (int i = 0; i < rows; i++)
    for (int n = 0; n < collumns; n++)
        {
            numbers [i,n] = Math.Round(new Random().NextDouble()*(end-begin)+begin, 2);
            Console.WriteLine(numbers[i,n]);
        }


