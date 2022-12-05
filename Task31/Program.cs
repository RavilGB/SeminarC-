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




