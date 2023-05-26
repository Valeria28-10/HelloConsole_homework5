// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76

double[] GenerateArray(int Lenght)
{
    double[] array = new double[Lenght];
    for(int i = 0; i < Lenght; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}

double[] array = GenerateArray(10);
double minValue = array[0];
double maxValue = array[0];
for (int i = 0; i < 10; i++)
{
    if(maxValue < array[i]) maxValue = array[i];
    else if(minValue > array[i]) minValue = array[i]; 
}
Console.WriteLine($"max = {maxValue}, min = {minValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {maxValue - minValue}");
