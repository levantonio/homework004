// 27. 
// 1. принимает на вход число
// 2. выдает сумму цифр в чисел
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int lastnum = 0; 
    int result = 0;
    
    while (num != 0)
    {
        lastnum = num - num % 10;
        result = result + (num - lastnum);
        num = lastnum / 10;   
    }
    return result;    
}
if(number > 0)
{
int sumdigit = SumDigit(number);
Console.WriteLine($"Сумма чисел в числе {number} = {sumdigit}");
}
else Console.WriteLine($"число {number} не натуральное");
