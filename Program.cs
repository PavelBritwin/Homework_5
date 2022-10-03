// Task 34

Console.WriteLine("Введите количество элементов массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
    if (i % 2 == 1) sum += array[i];
}
Console.WriteLine();
Console.WriteLine(sum);
