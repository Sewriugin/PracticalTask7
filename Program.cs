// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//     Урок 7. Как не нужно писать код. Часть 1
// Задача 47: Задайте двумерный массив размером m x n, 
// заполнить случайными вещественными числами.
//             1) m = 3, n = 4
//             0,5  7   -2  -0,2
//             1   -3,3  8  -9,9
//             8    7,8 -7,1 9

Console.WriteLine("Задача 47");
int m = 3;
int n = 4;
double[,] array = new double[m,n];
void FillArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            //matr[i, j] = new Random().NextDouble();
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 1000)) / 10;
        }
    }
}
void Print(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Print(array);
Console.WriteLine();

//----------------------------------------------------
// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение, 
// этого элемента или же указание что такого элемента нет
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задача 50");
void fillArray50(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void printArray50(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m,n] + " ");
        }
        Console.WriteLine();
    }
}

void findElements(int[,] array, int findElement)
{
    int count = 0;
    int result = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (array[m, n] != findElement) 
            {
                result = findElement;
            }
            else
            if (array[m, n] == findElement)
            {
                result = findElement;
                count++;
            }
        }
    }
    if (count == 0)
    Console.WriteLine(findElement + " -> " + "такого числа в массиве нет");
    else
    Console.WriteLine("Элемент поиска: " + findElement  + " => найдено: " + count);
}
    int[,] arr = createArray(3, 4);// вызов метода createArray
    fillArray50(arr);// вызов метода fillArray
    printArray50(arr);// вызов метода printArray
    findElements(arr, findElement: 17);
    Console.WriteLine();

//----------------------------------------------------
// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце. 
// этого элемента или же указание что такого элемента нет
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
// Среднее арифметическое каждого столбца:
// 4,6; 5,6; 3,6; 3

    Console.WriteLine("Задача 52");

    int[,] createArray(int n, int m)
    {
        return new int[n, m];
    }

    void fillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void printArray(int[,] array)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                Console.Write(array[m,n] + " ");
            }
            Console.WriteLine();
        }
    }

    void arithmeticMean(int[,] array)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            int count = 0;
            double sum = 0;
            for (int n = 0; n < array.GetLength(0); n++)
            {
                sum = sum + array[n, m];
                count++;   
            }
            sum = Math.Round(sum/count, 2);
            Console.WriteLine("arithmetic mean column " + m + " = " + sum);
        }
        Console.WriteLine();
    }
        int[,] arr52 = createArray(3,4);// вызов метода createArray
        fillArray(arr52);// вызов метода fillArray
        printArray(arr52);// вызов метода printArray
        arithmeticMean(arr52);// вызов метода arithmeticMean (среднее арифметическое значение)

