using static System.Console;






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