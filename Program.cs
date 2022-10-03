// Task 34

Console.WriteLine("Введите количество элементов массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];

int evenCount = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
    if (array[i] % 2 == 0) evenCount++;
}
Console.WriteLine();
Console.WriteLine(evenCount);
