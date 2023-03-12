//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void MultiplyMatrix(int[,] firstMartrix, int[,] secondMatrix, int[,] multiplyMatrix)
{
  for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < multiplyMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMatrix[k,j];
      }
      multiplyMatrix[i,j] = sum;
    }
  }
}


void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Введите размеры матриц");
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк 2-й матрицы: "); 
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число столбцов 2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secondMatrix = new int[q, p];
FillArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatrix);

if (n != p)
{
    Console.WriteLine("Умножение матрицы невозможно");
}
else
{
int[,] multiplyMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMatrix, multiplyMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(multiplyMatrix);
}




