// Task 38

Console.WriteLine("Введите количество элементов массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];

int min = 99;
int max = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]} ");
    if (min > array[i]) min = array[i];
    if (max < array[i]) max = array[i];
}
Console.WriteLine();
Console.WriteLine(max - min);
