// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
//получение числа с консоли
/*
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    
    return result;
}

int GetSumm(int number)
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }

    return summ;
}

int number = GetNumber("Введите число");
int summ = GetSumm(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {summ}");

*/
//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество
 //цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
//получение числа с консоли
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

