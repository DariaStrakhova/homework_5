/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

int sum = 0;

for (int x = 0; x < numbers.Length; x+=2)
{
    sum = sum + numbers[x];
}
   
Console.WriteLine($"Cумма чисел на нечётных позициях = {sum}");
