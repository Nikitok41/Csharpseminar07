/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

//вставил на всякий случай возможность изменения рандомности чисел

int[,] RandomArrayCreation(int rows , int colums , int minRandom , int maxRandom)
{
    Random rnd = new Random();
    int[,] array = new int[rows,colums];
    for ( int i = 0 ; i < rows ; i ++)
        for ( int j = 0 ; j < colums ; j ++)
            array[i,j] = rnd.Next(minRandom,maxRandom+1);
return array;
}

//Метод ввода и проверки на число

int NumberInput(string text)
{
    bool isInputInt = true;
    int number =0;
    while (isInputInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if (numberInt <= 0) Console.WriteLine("Введите число больше нуля");
            else
            {
                number = numberInt;
                isInputInt = false;
            } 
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

void ArrayPrint(int[,] array)
{
    Console.Write("\n");
    for ( int i = 0 ; i < array.GetLength(0) ; i ++)
    {
        for ( int j = 0 ; j < array.GetLength(1) ; j ++)
            Console.Write($"\t{array[i,j]}"); 
        Console.Write("\n");
    }
}

void LookUpValueByRowCol(int[,] array)
{
    int lookUpRow = NumberInput("строку поиска");
    if (lookUpRow > array.GetLength(0)) Console.Write($"\n{lookUpRow} - > в массиве меньше строк");
    else 
    {
        int lookUpColum = NumberInput("колонку поиска");
        if (lookUpRow > array.GetLength(1)) Console.Write($"\n{lookUpRow} - > в массиве меньше колоно");
        else Console.Write($"\nпо адресу ({lookUpRow},{lookUpColum}) - > лежит {array[lookUpRow-1,lookUpColum-1]}");
    }
}


int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");

int[,] array= RandomArrayCreation( rows:rows,
                                    colums:colums,
                                    minRandom:0,
                                    maxRandom:9);
ArrayPrint(array);
Console.Write("\n");
LookUpValueByRowCol(array);