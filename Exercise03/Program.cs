/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая преобразует десятчиное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Печать массива на экран
void PrintArray(int[] arrayPruint)
{
    for (int index = 0; index < arrayPruint.Length; index++)
    {
        Console.Write(arrayPruint[index]);
    }
}

//Перевод из десятичного в двоичное
int[] ConvertDecimalToBinary(int decimalNum)
{
    int count = 0;
    int temp = decimalNum;
    while (temp > 0)
    {
        temp /= 2;
        count++;
    }
    int length = count;
    int[] binaryNum = new int[length];
    for (int i = length; i > 0; i--)
    {
        binaryNum[i - 1] = decimalNum % 2;
        decimalNum /= 2;
    }
    return binaryNum;
}

//Получение числа от пользователя
int GetVar()
{  
    Console.Write($"Введите положительное десятичное число: ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Преобразование пока недоступно :) Повторите ввод заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа преобразовывает десятичное число в двоичное.");
int decimalNumber = GetVar();
int[] binaryNumber = ConvertDecimalToBinary(decimalNumber);
Console.Write($"{decimalNumber} -> ");
PrintArray(binaryNumber);

Author();