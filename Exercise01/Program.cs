/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/
/*
Напишите программу, которая перевернёт одномерный массив.
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Переворот массива
int[] FlipArray(int[] oldArray)
{
    int[] newArray = new int[oldArray.Length];
    for (int i = 0; i < oldArray.Length; i++)
    {
        newArray[i] = oldArray[oldArray.Length - 1 - i];
    }
    return newArray;
}

//Печать массива на экран
void PrintArray(int[] arrayPruint)
{
    Console.Write("[");
    for (int index = 0; index < arrayPruint.Length; index++)
    {
        if (index == (arrayPruint.Length - 1))
            Console.WriteLine($"{arrayPruint[index]}]");
        else
            Console.Write($"{arrayPruint[index]}, ");
    }
}

//Генерация случайного массива
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

//Получение числа от пользователя
int GetVar()
{  
    Console.Write("Введите количество элементов массива: ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Массив не может быть создан. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа генерирует массив случайных чисел по указанному количеству элементов.");
Console.WriteLine("После программа создаёт ещё один массив, который перевёрнут относительно первого.");
int number = GetVar();
int[] array = CreateRandomeArray(number);
Console.Write($"Сгенерированный массив: ");
PrintArray(array);
int[] flipArray = FlipArray(array);
Console.Write($"Перевёрнутый массив:    ");
PrintArray(flipArray);

Author();