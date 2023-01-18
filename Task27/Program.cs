using static System.Console;

Write("Введите число: ");
string number = ReadLine();



int SumNumberOfNumber(string num)
{
    int result = 0;
    for(int i = 0; i < num.Length; i++)
    {
        result += num[i];
    }
    return result;
}