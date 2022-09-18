// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Clear();
// Console.Write("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"В массиве чётных чисел {count}" );

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         if (i!=(numbers.Length-1))
//               Console.Write($"{numbers[i]}, ");
//         else 
//               Console.Write($"{numbers[i]}");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Clear();
// Console.Write("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Наш массив:");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];
//     Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(0,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             if (i!=(numbers.Length-1))
//               Console.Write($"{numbers[i]}, ");
//             else 
//               Console.Write($"{numbers[i]}");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }




// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size]; // использовал int, можно и double
FillArrayRandomNumbers(numbers);
Console.WriteLine("Наш массив: ");
PrintArray(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,100);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            if (i!=(numbers.Length-1))
              Console.Write($"{numbers[i]}, ");
            else 
              Console.Write($"{numbers[i]}");
        }
    Console.Write("]");
    Console.WriteLine();
}