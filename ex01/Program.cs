// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] Arr(int num) // метод объявления массива и заполнения его случайными 3х значными числами
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}
void PrArr(int[] array) // метод вывода на печать массива в виде [345, 897, 568, 234]
{
    Console.Write($"[");
    int x = (array.Length-1);
    for (int i = 0; i < x; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[x]}]");
}
void Chet(int[] array) // метод проверки чисел в массиве на четность и подсчет их количества
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
            count++;
    }
    Console.Write($" -> {count}");
}
int Number(string mess) // метод получения значения (для переменной) вводимого с клавиатуры
{
    Console.Write(mess);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}
int[] array = Arr(Number("Введите размер массива: "));
PrArr(array);
Chet(array);