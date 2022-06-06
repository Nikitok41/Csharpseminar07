/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

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
            number = numberInt;
            if (number <= 0) Console.WriteLine("Введите число больше нуля");
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

//Метод создания массива размером rows/colums и заполенние его случайными числами от 0 до 10

double[,] RandomArrayCreation(int rows , int colums)
{
    Random rnd = new Random();
    double[,] array = new double[rows,colums];
    for ( int i = 0 ; i < rows ; i ++)
        for ( int j = 0 ; j < colums ; j ++)
            array[i,j] = rnd.NextDouble()*10;
return array;
}

void ArrayPrint(double[,] array)
{
    Console.Write("\n");
    for ( int i = 0 ; i < array.GetLength(0) ; i ++)
    {
        for ( int j = 0 ; j < array.GetLength(1) ; j ++)
            Console.Write($"{array[i,j]:N1} "); 
        Console.Write("\n");
    }
}

int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");

double[,] array = RandomArrayCreation(rows,colums);
ArrayPrint(array);