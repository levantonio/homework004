// 25.
// 1. Написать цикл который принимает на вход 2 числа num1 и num2
// 2. Возводит num1 в натуральную степень num2
// 3,5 -> 243
// 2,4 -> 16

Console.WriteLine("Введите натуральное число number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int NumberDegree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = num1 * result;
    }
    return result;
}
if(number2 > 0)
{
int numberdegree = NumberDegree(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {numberdegree}");
}
else Console.WriteLine($"Число {number2} не натуральное!!!");