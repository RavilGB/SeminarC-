
/*

Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

             |
      2      |       1
             |
-------------------------->
             |
      3      |       4
*/



//функция получения числа с консоли
/*
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }

    return result;
}

//получение четверти, в которой лежит точка с координатами (x, y)
int GetQuarter(int x, int y)
{
    if(x > 0 && y >0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int x = GetNumber("Введите координату Х:");
int y = GetNumber("Введите координату У:");

int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в {quarter} четверти.");
*/



void Zadacha17()
{
    Random random = new Random();
    int x =  random.Next(-10, 11);
    int y =  random.Next(-10, 11);
    Console.WriteLine($"Точка с координатами ({x}, {y}");

    if (x > 0 && y > 0) Console.WriteLine("Точка лежит в 1-ой четверти");
    else if (x < 0 && y > 0) Console.WriteLine("Точка лежит в 2-ой четверти");
    else if (x < 0 && y < 0) Console.WriteLine("Точка лежит в 3-ой четверти");
    else if (x > 0 && y < 0) Console.WriteLine("Точка лежит в 4-ой четверти");
    else Console.WriteLine("Точка лежит на координатной прямой");

}
void Zadacha18()
{
    Random random = new Random();
    int quarter =  random.Next(0, 5);
    Console.WriteLine(quarter);
    if (quarter == 1) {Console.WriteLine("x > 0, y > 0");}
    else if (quarter == 2) {Console.WriteLine("x < 0, y > 0");}
    else if (quarter == 3) {Console.WriteLine("x < 0, y < 0");}
    else if (quarter == 4) {Console.WriteLine("x > 0, y < 0");}
    else Console.WriteLine("Некорректные данные");
}



    



//for (int i = 1; i < 10; i++);
//Zadacha17();
//Zadacha18();


