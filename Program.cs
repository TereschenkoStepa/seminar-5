// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// //[345, 897, 568, 234] -> 2
// Console.WriteLine("Введите длину массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// RandonNumbers(numbers);
// Console.WriteLine("В этом массиве: ");
// PrintArray(numbers);

// void RandonNumbers(int[] numbers)
// {
//     for (int i = 0; i < size; i++)
//     {
//         numbers[i] = new Random().Next(100, 1000);
//     }
// }


// int count = 0;

// for (int x = 0; x < numbers.Length; x++)
// {
//     if (numbers[x] % 2 == 0)
//         count++;
// }
// Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
// int size = ReadInt("Введите размерность массива: ");
// int min = ReadInt("Введите минимальное число массива: ");
// int max = ReadInt("Введите максимальное число массива: ");
// int[] numbers = new int[size];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         result += numbers[i];
//     }
// }
// Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

// // Методы
// void FillArrayRandomNumbers(int[] array) //Заполнение массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
// }

// void PrintArray(int[] array) //Вывод массива на экран
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)  //Функция ввода
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76  */
int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");


// Методы
void FillArrayRandomNumbers(int[] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}