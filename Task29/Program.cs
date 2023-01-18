using static System.Console;

Write("Введите минимальное возможное число: ");
int minimum = int.Parse(ReadLine());
Write("Введите максмиальное возможное число: ");
int maximum = int.Parse(ReadLine());

int [] ar = createArray(minimum, maximum);
printArray(ar);

int [] createArray(int min, int max)
{
    int [] array = new int [8];
    Random ran = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = ran. Next(min,max+1);
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
    WriteLine($"{arr[arr.Length-1]}]");
}