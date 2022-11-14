int ReadIntegerNumber(string message) 
{ 
    Console.Write(message); 
    return int.Parse(Console.ReadLine() ?? "0"); 
} 
void FillMatrix(int[,] matr,int min, int max)
{
Random random = new Random();
for (int m = 0; m < matr.GetLength(0); m++)
    for (int n = 0; n < matr.GetLength(1); n++)
        matr[m, n] = random.Next(min,max); 
}
void PrintMatrix(int[,] matr)
{
for (int m = 0; m < matr.GetLength(0); m++)
    {
    for (int n = 0; n < matr.GetLength(1); n++)
        Console.Write($"{matr[m, n]}\t ");
    Console.WriteLine();
    }
}
//Найти произведение двух матриц
int [,]MatrixMultiplication(int[,] matrA,int[,] matrB,int[,] matrC)
{
for (int m = 0; m < matrC.GetLength(0); m++)
        for (int n = 0; n < matrC.GetLength(1); n++)
            for (int k = 0; k < matrB.GetLength(0); k++)
                    matrC[m, n] += matrA[m, k]*matrB[k, n];       
return matrC;  
}
// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int []СolumnLineElement(int[,] matr)
{
int [] array = new int[2];
int min = matr[0, 0];
for (int m = 0; m < matr.GetLength(0); m++)
    {
    for (int n = 0; n < matr.GetLength(1); n++)
            if(min>matr[m, n])
            {
                min = matr[m, n];
                array[0] = m;
                array[1] = n;
            }
    }
return array;
}
void Line(int[,] matr, int [] array)
{
for (int m = array[0]; m < matr.GetLength(0)-1; m++)
        for (int n = 0; n < matr.GetLength(1); n++)
            matr[m, n]=matr[m+1, n];
}
void Сolumn(int[,] matr, int [] array)
{
for (int m = 0; m < matr.GetLength(0); m++)
        for (int n = array[1]; n < matr.GetLength(1)-1; n++)
                matr[m, n]=matr[m, n+1];;
}
void PrintModifiedMatrix(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0)-1; m++)
    {
        for (int n = 0; n < matr.GetLength(1)-1; n++)
                Console.Write($"{matr[m, n]}\t ");
    Console.WriteLine();
    }
}
// Сформировать трехмерный массив не повторяющимися двузначными числами показать  
// его построчно на экран выводя индексы соответствующего элемента  
void FillMatrix3D(int[,,] Matrix3D, int min, int max) 
{ 
    Random random = new Random(); 
    for (int m = 0; m < Matrix3D.GetLength(0); m++) 
        for (int n = 0; n < Matrix3D.GetLength(1); n++) 
            for (int k = 0; k < Matrix3D.GetLength(2); k++) 
                Matrix3D[m, n, k] = random.Next(min, max);
} 
void PrintMatrix3D(int[,,] Matrix3D) 
{ 
    for (int m = 0; m < Matrix3D.GetLength(0); m++) 
    {    for (int n = 0; n < Matrix3D.GetLength(1); n++) 
        { 
            for (int k = 0; k < Matrix3D.GetLength(2); k++) 
            {
                Console.Write(Matrix3D[m, n, k] + $" [{m},{n},{k}]\t");
            }
            Console.WriteLine();
        } 
        Console.WriteLine();
    } 
} 
//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void FillTriangle(int[,] triangle) 
{ 
    for (int i = 0; i < triangle.GetLength(0); i++) 
    { 
        triangle[i, 0] = 1; 
        triangle[i, i] = 1; 
    } 
    for (int i = 2; i < triangle.GetLength(0); i++)  
    { 
        for (int j = 1; j <= i; j++) 
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j]; 
    } 
} 
void IsoscelesTriangle(int [,] triangle,int cellWidth) 
{ 
    int col = cellWidth * triangle.GetLength(0); 
    for (int i = 0; i < triangle.GetLength(0); i++) 
    { 
        for (int j = 0; j <= i; j++) 
        { 
            Console.SetCursorPosition (col, i + 1); 
            if (triangle[i, j] != 0) Console.Write($"{triangle[i,j]}"); 
            col += cellWidth * 2;  
        } 
        col = cellWidth * triangle.GetLength(0) - cellWidth * (i+1); 
    } 
    Console.WriteLine(); 
} 

//Найти произведение двух матриц
int LineA = ReadIntegerNumber("Введите размер Матрицы А: ");
int ColumnA = ReadIntegerNumber("Введите размер Матрицы А: ");
Console.WriteLine();
int LineB = ReadIntegerNumber("Введите размер Матрицы B: ");
int ColumnB = ReadIntegerNumber("Введите размер Матрицы B: ");
Console.WriteLine();
int min = ReadIntegerNumber("Введите значение min: ");
int max = ReadIntegerNumber("Введите значение max: ");

int[,] MatrixA = new int[LineA, ColumnA];
int[,] MatrixB = new int[LineB, ColumnB];
int[,] MatrixC = new int[LineA, ColumnB];

FillMatrix(MatrixA,min,max);
Console.WriteLine();
PrintMatrix(MatrixA);

FillMatrix(MatrixB,min,max);
Console.WriteLine();
PrintMatrix(MatrixB);
Console.WriteLine();

if (LineB==ColumnA)
{
MatrixC=MatrixMultiplication(MatrixA,MatrixB,MatrixC);
Console.WriteLine($"Результат произведение двух матриц: ");
PrintMatrix(MatrixC);
}
else Console.WriteLine($" Такие матрицы нельзя перемножить, так "+
"как количество столбцов матрицы А не равно количеству строк матрицы В.");
Console.ReadKey();
Console.Clear();

// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int LineM = ReadIntegerNumber("Введите размер Матрицы : ");
int ColumnN = ReadIntegerNumber("Введите размер Матрицы : ");
Console.WriteLine();
int min1 = ReadIntegerNumber("Введите значение min: ");
int max1 = ReadIntegerNumber("Введите значение max: ");

int[,] matrix = new int[LineM, ColumnN];
Console.WriteLine();
Console.WriteLine("Начальная матрица: ");
FillMatrix(matrix,min1,max1);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

int [] СolumnLine = new int[2];
СolumnLine = СolumnLineElement(matrix);

Console.WriteLine ($"Строка с минимальным элементом  {СolumnLine[0]}");
Console.WriteLine ($"Столбец с минимальным элементом  {СolumnLine[1]}");
Console.WriteLine();

Line(matrix,СolumnLine);
Сolumn(matrix,СolumnLine);
Console.WriteLine("Матрица с удаленной строкой и столбцом: ");
PrintModifiedMatrix(matrix);    

Console.ReadKey();
Console.Clear();

//Сформировать трехмерный массив не повторяющимися двузначными 
//числами показать его построчно на экран выводя индексы соответствующего элемента

int m = ReadIntegerNumber("Введите кол-во элеменов по оси m : "); 
int n = ReadIntegerNumber("Введите кол-во элеменов по оси n : "); 
int k = ReadIntegerNumber("Введите кол-во элеменов по оси k : "); 
 
int[,,] Matrix3D = new int[m, n, k]; 
FillMatrix3D(Matrix3D, 10, 100); 
Console.WriteLine(); 
PrintMatrix3D(Matrix3D);
Console.ReadKey();
Console.Clear();

//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int line = ReadIntegerNumber("Введите кол-во строк: "); //10
const int cellWidth = 3; // 3
int[,] triangle = new int[line, line]; 
FillTriangle(triangle); 
IsoscelesTriangle(triangle, cellWidth);

Console.ReadKey();
Console.Clear();