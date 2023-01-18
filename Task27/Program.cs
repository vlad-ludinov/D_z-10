using static System.Console;

int SumNumberOfNumber(string number)
{
    int result = 0;
    for(int i = 0; i < number.Length; i++)
    {
        result += number[i];
    }
    return result;
}