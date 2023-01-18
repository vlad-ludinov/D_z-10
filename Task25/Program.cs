using static System.Console;

int Pow(int number1, int number2)
{
    int result = number1;
    for(int i = 0; i < number2-1; i++)
    {
        result*=number1;
    }
    return result;
}