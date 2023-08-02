// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string FindNumbers(int numb)
{
    if (numb == 1) return numb.ToString();
    else return numb + ", " + FindNumbers(numb-1);
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numb = GetInput("Введите число N:");
Console.Write(FindNumbers(numb));