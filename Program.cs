﻿// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] CreatAndShowArray(int rows, int columns)  
{      
    // Инициализация массива
    int[,] newArray = new int[rows, columns];  
    
    if( rows > 0 && columns > 0)
    {
        // создание массива
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
            newArray[i,j] = new Random().Next(1, 11);
            }
        }

        // Отображение массива
        for(int i = 0; i < rows ;i++ ) 
            {
                for(int j = 0; j < columns; j++)  
                {
                Console.Write(newArray[i,j] + " ");
                }
                Console.WriteLine(); 
            }
        Console.WriteLine();    
        return newArray;
    }
    else 
    {
        Console.WriteLine("Ошибка ввода данных");
        return newArray;
    }

}

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreatAndShowArray(rows, columns);

// Сортировка массива по строкам
int[,] orderArrayRows(int [,] array)
{
       for(int i = 0; i < array.GetLength(0); i++ )
       {
            for(int j = array.GetLength(1) - 1; j > 0; j-- ) 
            {
                for (int k = 0; k < 0; k++)
                {
                    if( array[i, k] > array[i, k + 1] )
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }
    return array;
}

int [,] sortedArray = orderArrayRows(myArray);

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // задание строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
Show2DArray(sortedArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка



// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

