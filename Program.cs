// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int [,] CreatAndShowArray(int rows, int columns)  
// {      
//     // Инициализация массива
//     int[,] newArray = new int[rows, columns];  
    
//     if( rows > 0 && columns > 0)
//     {
//         // создание массива
//         for (int i = 0; i < rows; i++)
//         {
//             for(int j = 0; j < columns; j++)
//             {
//             newArray[i,j] = new Random().Next(1, 11);
//             }
//         }

//         // Отображение массива
//         for(int i = 0; i < rows ;i++ ) 
//             {
//                 for(int j = 0; j < columns; j++)  
//                 {
//                 Console.Write(newArray[i,j] + " ");
//                 }
//                 Console.WriteLine(); 
//             }
//         Console.WriteLine();    
//         return newArray;
//     }
//     else 
//     {
//         Console.WriteLine("Ошибка ввода данных");
//         return newArray;
//     }

// }

// Console.Write("Введите кол-во строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = CreatAndShowArray(rows, columns);

// // Сортировка массива по строкам
// int [,] orderArrayRows(int [,] arr)
// {
//     // Сортировка массива
//     for (int i = 0; i < arr.GetLength(0); i++) // двигаемся по строкам
//     {
//         for (int j = arr.GetLength(1) - 1; j > 0; j--) // двигаемся по столбцам назад
//         {
//             for (int k = 0; k < j; k++) // доп. переменная
//             {
//                 if (arr[i, k] < arr[i, k + 1])
//                 {
//                     int temp = arr[i, k];
//                     arr[i, k] = arr[i, k + 1];
//                     arr[i, k + 1] = temp;
//                 }
//             }
//         }
//     }

//     // вывод на экран отсортированного массива
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//                 Console.Write(arr[i , j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return arr;
// }

// orderArrayRows(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// int [,] CreatAndShowArray(int rows, int columns)  
// {      
//     // Инициализация массива
//     int[,] newArray = new int[rows, columns];  
    
//     if( rows > 0 && columns > 0)
//     {
//         // создание массива
//         for (int i = 0; i < rows; i++)
//         {
//             for(int j = 0; j < columns; j++)
//             {
//             newArray[i,j] = new Random().Next(1, 11);
//             }
//         }

//         // Отображение массива
//         for(int i = 0; i < rows ;i++ ) 
//             {
//                 for(int j = 0; j < columns; j++)  
//                 {
//                 Console.Write(newArray[i,j] + " ");
//                 }
//                 Console.WriteLine(); 
//             }
//         Console.WriteLine();    
//         return newArray;
//     }
//     else 
//     {
//         Console.WriteLine("Ошибка ввода данных");
//         return newArray;
//     }

// }

// // пользовательский ввод для создания массива
// Console.Write("Введите кол-во строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // вывод массива
// int [,] myArray = CreatAndShowArray(rows, columns);

// void findStringhWithMinSum(int [,] array)
// {
//     int count_size = array.GetLength(0); // размер массива сумм
//     int [] sum = new int [count_size]; // массив сумм каждой строки
//     // Ищем и выводим сумму каждой строки
//     for(int i = 0; i < array.GetLength(0); i++ ) 
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum [i] = sum [i] + array[i, j];
//             }
//             Console.WriteLine($"Сумма строка {i+1} равна {sum[i]}");
//         }

//     // Ищем наименьшую сумму
//     int minSum = 0;
//     for (int i = 0; i < sum.GetLength(0); i++)
//     {
//         minSum = sum[0];
//         if (sum[i] < minSum)
//         {
//             minSum = sum[i];
//         }
//     }
//     Console.Write($"Минимальная сумма {minSum}"); 
// }

// findStringhWithMinSum(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,] CreatAndShowArray(int rows, int columns)  
// {      
//     // Инициализация массива
//     int[,] newArray = new int[rows, columns];  
    
//     if( rows > 0 && columns > 0)
//     {
//         // создание массива
//         for (int i = 0; i < rows; i++)
//         {
//             for(int j = 0; j < columns; j++)
//             {
//             newArray[i,j] = new Random().Next(1, 11);
//             }
//         }

//         // Отображение массива
//         for(int i = 0; i < rows ;i++ ) 
//             {
//                 for(int j = 0; j < columns; j++)  
//                 {
//                 Console.Write(newArray[i,j] + " ");
//                 }
//                 Console.WriteLine(); 
//             }
//         Console.WriteLine();    
//         return newArray;
//     }
//     else 
//     {
//         Console.WriteLine("Ошибка ввода данных");
//         return newArray;
//     }

// }

// // пользовательский ввод для создания массива
// Console.Write("Введите кол-во строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // вывод массива
// Console.WriteLine("Массив 1");
// int [,] myArray_1 = CreatAndShowArray(rows, columns);
// Console.WriteLine("Массив 2");
// int [,] myArray_2 = CreatAndShowArray(myArray_1.GetLength(0), myArray_1.GetLength(1));

// void MultiplyTwoArray(int [,] array_1, int [,] array_2)
// {
//     int [,] multiplyArray = new int[array_1.GetLength(0), array_1.GetLength(1)];
//     for (int i = 0; i < array_1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array_1.GetLength(1); j++)
//         {
//             multiplyArray[i, j] = array_1[i,j] * array_2[i, j];
//         }
//     }
//     // Отображение массива
//     Console.WriteLine("Произведение двух массивов");
//     for(int i = 0; i < rows ;i++ ) 
//         {
//             for(int j = 0; j < columns; j++)  
//             {
//                 Console.Write(multiplyArray[i,j] + " ");
//             }
//             Console.WriteLine(); 
//         }
//     Console.WriteLine();
// }

// MultiplyTwoArray(myArray_1, myArray_2);

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void RandomNumber(int row, int col, int dep)
// {
//     // Создание массива рандомных чисел (возможно повторение)
//     int[,,] array = new int [row, col, dep];

//     // проверочный массив в одну строку, сюда складываем все значения основного массива
//     int[] resultArray = new int[row*col*dep];

//     // счётчик для проверки
//     int index = 0;

//     // создание рандомных значений
//     for (int i = 0; i < row; i++) // по оси Х
//     {
//         for(int j = 0; j < col; j++) // по оси Y
//         {
//             for(int k = 0; k < dep; k++) // по оси Z
//             {
//                 // создаём рандомное число
//                 array[i,j,k] = new Random().Next(10,100);

//                 // перебираем готовые числа в проверочном массива для поиска повторов значений
//                 for (int resultIndex = 0; resultIndex < row*col*dep;)
//                 {
//                     // для одинаковых значений ищем новое значение
//                     if (resultArray[resultIndex] == array[i,j,k])
//                     {
//                         // новое рандомное число
//                        array[i,j,k] = new Random().Next(10,100);
//                        // обнуляем для проверки однострочного массива по новой
//                        resultIndex = 0;
//                     }
//                     else resultIndex++;
//                 }
//                 // записываем число из главного массива в проверочный-однострочный
//                 resultArray[index] = array[i,j,k];
//                 index++;
//             }
//         }
//     }

//     // Отображение массива
//     for (int i = 0; i < row; i++) // по оси Х
//     {
//         for(int j = 0; j < col; j++) // по оси Y
//         {
//             Console.Write("|");
//             for(int k = 0; k < dep; k++) // по оси Z
//             {
//                 Console.Write($"{array[i, j, k],1}({i},{j},{k})|");
//             }
//             Console.WriteLine();            
//         }
//     }
// }


// // Пользовательский ввод трёхмерного массива
// Console.WriteLine("Введите кол-во элементов по оси Х");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во элементов по оси Y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во элементов по оси Z");
// int z = Convert.ToInt32(Console.ReadLine());

// RandomNumber(x, y, z);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] spiralArray (int number)
{
    // начало массива
    int i = 0;
    int j = 0;
    int[,] array = new int[4,4];
    array[i,j] = number;

    // строка 1 запись слево направо i=0 j=0
    while(j+1 < 4)
    {
        j++; number++; // по строке и увеличиваем числа
        array[i,j] = number;
    }
    // стобец 4 запись сверху вниз i=0 j=4
    while(i+1 < 4)
    {
        i++; number++; // по столбцу и увеличиваем числа
        array[i,j] = number;
    }
    // строка 4 запись справо налевао i=4; j=4
    while(j-1 >= 0)
    {
        j--; number++; // по строке назад и увеличиваем числа
        array[i,j] = number;
    }
    // стоблец 1 запись снизу вверх i=4 j=0
    while(array[i-1,j] == 0)
    {
        i--; number++; // по столбцу и увеличиваем числа
        array[i,j] = number;
    }
    // строка 2 запись слева направо i=1 j=0
    while(array[i,j+1] == 0)
    {
        j++; number++; // по строке и увеличиваем числа
        array[i,j] = number;
    }
    // строка 3 запись справо налеова i=2 j=2
    while(array[i+1,j] == 0)
    {
        i++; number++; // по столбцу и увеличиваем числа
        array[i,j] = number;
    }
    // последнее число в центре
    j--;
    number++;
    array[i,j] = number; 
    return array; 
}

// отобразить получившийся массив
void ShowArray(int[,]array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
            else Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    } 
}

Console.WriteLine("Стартуем с числа ");
int number = Convert.ToInt32(Console.ReadLine());


ShowArray(spiralArray(number));