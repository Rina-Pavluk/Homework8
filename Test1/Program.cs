// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine($"Введите размер массива и диапазон случайных значений:");
// int m = InputNumbers("Введите столбец: ");
// int n = InputNumbers("Введите строку: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 58
// using System;
 

// static class MatrixExt
// {
    
//     public static int RowsCount(this int[,] matrix)
//     {
//         return matrix.GetUpperBound(0) + 1;
//     }
 
    
//     public static int ColumnsCount(this int[,] matrix)
//     {
//         return matrix.GetUpperBound(1) + 1;
//     }   
// }
 
// class Program
// {
    
//     static int[,] GetMatrixFromConsole(string name)
//     {
//         Console.Write("Количество строк матрицы {0}:    ", name);
//         var n = int.Parse(Console.ReadLine());
//         Console.Write("Количество столбцов матрицы {0}: ", name);
//         var m = int.Parse(Console.ReadLine());
 
//         var matrix = new int[n, m];
//         for (var i = 0; i < n; i++)
//         {
//             for (var j = 0; j < m; j++)
//             {
//                 Console.Write("{0}[{1},{2}] = ", name, i, j);
//                 matrix[i, j] = int.Parse(Console.ReadLine());
//             }
//         }
 
//         return matrix;
//     }
 
   
//     static void PrintMatrix(int[,] matrix)
//     {
//         for (var i = 0; i < matrix.RowsCount(); i++)
//         {
//             for (var j = 0; j < matrix.ColumnsCount(); j++)
//             {
//                 Console.Write(matrix[i, j].ToString().PadLeft(4));
//             }
 
//             Console.WriteLine();
//         }
//     }
 
    
//     static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
//     {       
//         if (matrixA.ColumnsCount() != matrixB.RowsCount())
//         {
//             throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//         }
 
//         var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];
 
//         for (var i = 0; i < matrixA.RowsCount(); i++)
//         {
//             for (var j = 0; j < matrixB.ColumnsCount(); j++)
//             {
//                 matrixC[i, j] = 0;
 
//                 for (var k = 0; k < matrixA.ColumnsCount(); k++)
//                 {
//                     matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//                 }
//             }
//         }
 
//         return matrixC;
//     }
 
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Программа для умножения матриц");
 
//         var a = GetMatrixFromConsole("A");
//         var b = GetMatrixFromConsole("B");
 
//         Console.WriteLine("Матрица A:");
//         PrintMatrix(a);
 
//         Console.WriteLine("Матрица B:");
//         PrintMatrix(b);
 
//         var result = MatrixMultiplication(a, b);
//         Console.WriteLine("Произведение матриц:");
//         PrintMatrix(result);
 
//         Console.ReadLine();
//     }


// Задача 60

// Console.WriteLine($"Введите размер массива A x B x C:");
// int x = InputNumbers("Введите A: ");
// int y = InputNumbers("Введите B: ");
// int z = InputNumbers("Введите C: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"A({i}) B({j}) ");
//       for (int t = 0; t < array3D.GetLength(2); t++)
//       {
//         Console.Write( $"C({t})={array3D[i,j,t]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int a = 0; x < array3D.GetLength(0); a++)
//   {
//     for (int b = 0; b < array3D.GetLength(1); b++)
//     {
//       for (int c = 0; c < array3D.GetLength(2); c++)
//       {
//         array3D[a, b, c] = temp[count];
//         count++;
//       }
//     }
//   }
// }