
double[] FillArray(int size)
{
    double[] mas = new double[size];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return mas;
}

void PrintArray(double[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write(mas[i] + "; ");
    }
    Console.WriteLine(mas[mas.Length - 1] + "]");
}

double[] MaxMinDiff(double[] array)
{
    double[] diff = new double[3];
    double min = array[0];
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            diff[0] = min;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
            diff[1] = max;
        }
    }
    diff[2] = Math.Round(max - min, 2);
    return diff;
}

try
{
    System.Console.WriteLine("Введите размерность массива");
    int k = Convert.ToInt32(Console.ReadLine());
    double[] array = FillArray(k);
    PrintArray(array);
    double[] mas = MaxMinDiff(array);
    Console.WriteLine($"Разница между максимальным ({mas[1]}) и минимальным ({mas[0]}) элементами массива = {mas[2]}");
}
catch
{
    Console.WriteLine("Надо было вводить целое положительное число!");
}