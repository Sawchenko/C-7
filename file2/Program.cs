Random rnd = new Random();
int n = rnd.Next(3, 8);
int m = rnd.Next(3, 8);

Console.Write($"Введите строку- максимум {n}: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write($"Введите столбец- максимум {m}: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

Random rnd1 = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = rnd1.Next(10, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();

}
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();