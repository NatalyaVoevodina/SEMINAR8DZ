void Fillarray(int[,] array)
{
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j]) // проверка на неповторяемость чисел
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = temp[count];
        count++;
      }
    }
  }
 

void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

int [,] SortUbiv(int[,] array)
{
    {
        //int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] > array[i, k + 1])
                    {
                        //temp = array[i, k + 1];
                        //array[i, k + 1] = array[i, k]; 
                        //array[i, k] = temp;
                        (array [i,k], array [i,k+1]) = (array [i,k+1], array[i,k]);
                    }
                }
            }

        }

    }
    return array;
}
     
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
Fillarray(array);
Printarray(array);
Console.WriteLine();
SortUbiv(array);
Printarray(array);




