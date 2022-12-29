// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// */


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];


// void FillArrayRandomNumbers(int[] array)
// {
//  for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// int count = 0;

// for (int i = 0; i < size; i++)
// {
//     if((numbers[i] % 2) == 0)
//     i++;
//     count++;

// }
// Console.WriteLine($" {count} из них чётные");
// void PrintArray(int[] array)
// {
//  for(int i = 0; i < array.Length; i++)
//     {
//          Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//  Console.WriteLine("Введите размер массива");
//  int size = Convert.ToInt32(Console.ReadLine());
//  int[] numbers = new int[size];



//  void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//              numbers[i] = new Random().Next(1,10);
//         }
// }
//  int sum = 0;
// for (int i = 0; i < size; i++)
// {
//    if(numbers[i] % 2 == 0)
//    sum = sum+= numbers[i];
// }



// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив:");
// PrintArray(numbers);

// Console.WriteLine();
// Console.Write(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76
// */

// int size = 10;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int max = numbers[0];
// int min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//  if (numbers[i] > max)
//     {
//  max = numbers[i];
//     }
//  else if (numbers[i] < min)
//     {
//  min = numbers[i];
//     }
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



// void FillArrayRandomNumbers(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 555);
//     }
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }