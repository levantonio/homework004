// 29.
// написать программу которая
// 1. выводит массив из 8 элементов заполненный псевдослучайными числами в случайном порядке
// [2,5,7,8,98,74,52,15]

int[] array = new int[8]; //[]квадратные скобки- это значит массив по умолчанию он заполнен 0 8-нулей ([8])


void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);
