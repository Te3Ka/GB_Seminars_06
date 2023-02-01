/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу по выводу массива числел Фибоначчи для заданного элемента.
Нельзя использовать рекурсию.
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

void PrintArray(uint[] arrayPruint)
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

uint[] Fibonacci(uint number)
{
    uint[] arrayFib = new uint[number];
    arrayFib[0] = 0;
    arrayFib[1] = 1;
    for(int i = 2; i < number; i++)
    {
        arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
    }
    return arrayFib;
}

uint GetVar()
{  
    Console.Write("Введите номер числа Фиббоначчи: ");
    uint.TryParse(Console.ReadLine(), out uint num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1, введите заново: ");
        uint.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

uint num = GetVar();
Fibonacci(num);
PrintArray(Fibonacci(num));