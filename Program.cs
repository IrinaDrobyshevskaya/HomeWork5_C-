//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int [4];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
    if (array[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Количество чётных чисел = {count}");


//Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int [4];
int sum = 0;

for (int i = 0; i < array.Length; i+=2)
{
    array[i] = new Random().Next(1,99);
    sum = sum + array[i];
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Всего {array.Length} чисел(-а), сумма элементов на нечётных позициях = {sum}");

//Задача 38: Задайте массив вещественных 
//чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int [] array = new int [] {3, 7, 22, 2, 78};
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
        if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");
