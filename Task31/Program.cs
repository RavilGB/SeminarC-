/*инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }

    return array;
}

//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получает сумму положительных элементов в массиве
int GetPositiveSumm(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            summ += arr[i];
    }

    return summ;
}
//получает сумму отрицательных элементов в массиве
int GetNegativeSumm(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
            summ += arr[i];
    }

    return summ;
}

(int, int) GetPositiveAndNegativeSumm(int[] array)
{
    int positive = 0;
    int negative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            positive += array[i];
        else
            negative += array[i];
    }

    return (positive, negative);
}

int[] arr = InitArray(12);
PrintArray(arr);
int positiveSumm = GetPositiveSumm(arr);
int negativeSumm = GetNegativeSumm(arr);

(int pos, int neg) = GetPositiveAndNegativeSumm(arr);

Console.WriteLine($"Сумма положительных: {positiveSumm}. Сумма отрицательных: {negativeSumm}");

Console.WriteLine($"Сумма положительных: {pos}. Сумма отрицательных: {neg}");

//задача 32: Напишите программу замена элементов массива: положительные элементы замените
 //на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }

    return array;
}

//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] NewArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i] * -1;
    }
    return result;
    
}

int[]array = InitArray(5);
PrintArray(array);
int[]result  =  NewArray(array) ;

PrintArray(result);
*/

//задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
// заполняем массив
/*int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }

    return array;
}

//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool IsExist(int[]arr, int number)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == number) return true;
    }
    return  false;
}


int[] array= InitArray(5);
PrintArray(array);
Console.WriteLine("введите чиcло: ");
int num = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine(IsExist(array,num));
*/
//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
/*
int[] GetArray(int length)
{
    Random rnd = new Random();
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-100,300);
    }
    return array;
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >=10 && array[i]<= 99) count++;
    }
    return count;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


Console.WriteLine("Ведите размер массива");
int[] array = GetArray(int.Parse(Console.ReadLine()));

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"{Count(array)}");
*/
//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


int [] GetArray(int length)
{
    Random rnd = new Random();
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 5);
    }
    return array;
}

int[] NewArray(int[] array)
{
    int[] arr;
    int len = 0;
    if (array.Length%2 == 0) 
    {
        len = array.Length/2;
        arr = new int [len];
    }
    else 
    {
        len = array.Length/2 + 1;
        arr = new int [len];
        arr[len-1] = array[len];
    }
    
    for (int i = 0; i < array.Length/2; i++)
    {
        arr[i] = array[i]*array[array.Length - i - 1];
    }
    return arr;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


Console.WriteLine("Ведите размер массива");
int[] array = GetArray(int.Parse(Console.ReadLine()));
PrintArray(array);
int [] arr = NewArray(array);
Console.WriteLine();
PrintArray(arr);
