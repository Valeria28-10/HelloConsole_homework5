// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int Lenght)
{
    int[] array = new int[Lenght];
    for(int i = 0; i < Lenght; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}
int lenght = 7;
int[] array = GenerateArray(lenght);
int sumOddPosition = 0;
for(int i = 0; i < lenght; i++)
{
    if(i % 2 != 0)
    {
        sumOddPosition += array[i];
    }
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sumOddPosition}");