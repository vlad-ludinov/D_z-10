using static System.Console;

Write("Введите число: ");
string number = ReadLine();

int sum = SumNumberOfNumber(number);
WriteLine($"Сумма цифр в числе {number} = {sum}");

int SumNumberOfNumber(string num)
{
    int result = 0;
    for(int i = 0; i < num.Length; i++)
    {
        result += num[i];
    }
    return result;
}