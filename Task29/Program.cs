using static System.Console;

Write("Введите минимальное возможное число");
int minimum = int.Parse(ReadLine());
Write("Введите максмиальное возможное число");
int maximum = int.Parse(ReadLine());


int [] createArray()
{
    int [] array = new int [8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(min,max);
    }
    return array;
}

void printArray(int [] arr)
{
    Write("Сгенерированный массив: [");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Write($"{arr[i]}, ");
    }
    WriteLine($"{arr[i]}]");
}