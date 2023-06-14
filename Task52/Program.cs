Console.Clear();
int avrg = 0;
Console.Write("Введите размер матрицы: ");
int rows = int.Parse(Console.ReadLine()!);
int collumns = rows;
int [,] numbers = new int [rows, collumns];
for (int i = 0; i < collumns; i++)
{
    for (int n = 0; n < rows; n++ )
        {
            numbers [i, n] = new Random().Next(0,100);
            Console.Write($" {numbers[i, n]} ");
        }
    Console.WriteLine();
}
for (int z = 0; z < collumns; z++)
{
    for (int v = 0; v < rows; v++)
        avrg = avrg + numbers [v,z];
Console.WriteLine($"Среднее арифмеическое столбца {z} = {avrg/rows}");
avrg = 0;
}