using static System.Console;






int [] createArray()
{
    int [] array = new int [8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(min,max);
    }
}