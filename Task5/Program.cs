/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
voir7: да так в том и секрет*/

int num = Int32.Parse(Console.ReadLine());
if (num > 999 && num<100)
{
Console.WriteLine("Wrong number");
return;
}
int num2 = num % 10;
Console.WriteLine(num2);

