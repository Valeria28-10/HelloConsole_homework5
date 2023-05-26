// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int Lenght)
{
    int[] array = new int[Lenght];
    for(int i = 0; i < Lenght; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}
int[] array = GenerateArray(10);
int count_evenNumber = 0;
 for(int i = 0; i < 10; i++)
 {
    if(array[i]%2 ==0)
    {
        count_evenNumber += 1;
    }
 }
Console.WriteLine($"Количество четных чисел в массиве: {count_evenNumber}");