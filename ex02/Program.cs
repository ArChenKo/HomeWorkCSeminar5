// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Number(string mess) // метод получения значения (для переменной) вводимого с клавиатуры
{
    Console.Write(mess);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}
int[] Arr(int num) // метод объявления массива и заполнения его случайными числами
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}
void PrArr(int[] array) // метод вывода на печать массива в виде [n1, n2,... , nx]
{
    Console.Write($"[");
    int x = (array.Length-1);
    for (int i = 0; i < x; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[x]}]");
}
void SumNechet(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        result+=array[i];
    }
    Console.Write($" -> {result}");
}

int[] array = Arr(Number("Введите размер массива: "));
PrArr(array);
SumNechet(array);