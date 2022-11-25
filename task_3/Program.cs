// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] numbers = FillArray();

int[] FillArray()
{   
    int[] NullArray =  new int[8];
    for (int i = 0; i < 8; i++)
    {
        NullArray[i] = new Random().Next(0, 9);
    }
    return NullArray;
}
void PrintArray(int[] Array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
}

int[] Arr = FillArray();
PrintArray(Arr);