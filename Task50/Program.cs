Console.Clear();
Console.Write("Введите число рядов: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int collumns = int.Parse(Console.ReadLine()!);
int [,] numbers = new int [rows, collumns];
for (int i = 0; i < rows; i++)
{
    for (int n = 0; n < collumns; n++ )
        {
            numbers [i, n] = new Random().Next(-100,100);
            Console.Write($" {numbers[i, n]} ");
        }
    Console.WriteLine();
}
Console.Write("Введите столбец необходимого числа: ");
int CollumnSearch = int.Parse(Console.ReadLine()!);
Console.Write("Введите ряд необходимого числа: ");
int RowSearch = int.Parse(Console.ReadLine()!);
if (CollumnSearch > collumns-1 || RowSearch > rows-1)
    Console.WriteLine("Такой позиции нет");
else
    Console.WriteLine($"Число на данной позиции - {numbers[RowSearch,CollumnSearch]}");
