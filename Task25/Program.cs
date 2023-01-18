using static System.Console;

Write("Введите число A: ");
int A = int.Parse(ReadLine()!);
Write("Введите степень B: ");
int B = int.Parse(ReadLine()!);

int answer = Pow(A,B);
WriteLine($"Число {A} в степени {B} = {answer}");






int Pow(int number1, int number2)
{
    int result = number1;
    for(int i = 0; i < number2-1; i++)
    {
        result*=number1;
    }
    return result;
}