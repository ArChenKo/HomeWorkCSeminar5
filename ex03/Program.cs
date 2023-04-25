// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] Number() // метод определения параметров массива, вводимых с клавиатуры
{
    int[] a = new int[2];
    Console.Write("Введите размер массива: ");
    a[0] = int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимальное значение числа в массиве: ");
    a[1] = int.Parse(Console.ReadLine()!);
    return a;
}
double[] Arr(int[] arra) // метод объявления массива и заполнения его случайными числами
{
    double[] array = new double[arra[0]];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(arra[1]);
    }
    return array;
}
void PrArr(double[] array) // метод вывода на печать массива в виде [n1, n2,... , nx]
{
    Console.Write($"[");
    int x = (array.Length - 1);
    for (int i = 0; i < x; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[x]}]");
}
void Sum(double[] array) // метод нахождения минимального и максимального значений и 
                         // вывода их разницы
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double sum = max - min;
    Console.Write($" -> {sum}");
}

double[] array = Arr(Number());
PrArr(array);
Sum(array);