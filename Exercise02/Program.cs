/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая принимает три числа от пользователя.
А после проверяет, может ли существовать треугольник с такими длинами сторон.
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Проверка существования треугольника
bool CheckTriangle(int ab, int bc, int ac)
{
    if ((ab < bc + ac) && (bc < ab + ac) && (ac < ab + bc))
    {
        return true;
    }
    return false;
}

//Получение числа от пользователя
int GetVar(string name)
{  
    Console.Write($"Введите длину стороны {name}: ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Такая длина стороны существовать не может. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа проверяет существование треуголькика по введённым длинам сторон.");
int AB = GetVar("AB");
int BC = GetVar("BC");
int AC = GetVar("AC");

Console.WriteLine($"Треугольник {(CheckTriangle(AB, BC, AC) ? "" : "не ")}существует.");

Author();