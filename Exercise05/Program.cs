int[] CreateRandomeArray(int num)
{
    int[] array = new int[num];
    Random randome = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randome.Next(1, 100);
    }
    return array;
}

//Печать массива на экран
void PrintArray(int[] arrayPrint)
{
    Console.Write("[");
    for (int index = 0; index < arrayPrint.Length; index++)
    {
        if (index == (arrayPrint.Length - 1))
            Console.WriteLine($"{arrayPrint[index]}]");
        else
            Console.Write($"{arrayPrint[index]}, ");
    }
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int GetVar()
{
    Console.Write("Введите количество элементов массива: ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                        + "Повторите ввод количества элементов массива:");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

int num = GetVar();
int[] array = CreateRandomeArray(num);
Console.Write("Полученный массив:   ");
PrintArray(array);
Console.Write("Копированный массив: ");
PrintArray(CopyArray(array));
