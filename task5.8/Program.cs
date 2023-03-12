  void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}
  
        // количество строк - m, столбцов - n.
        int m = 4;
        int n = 4;

        //С помощью переменной numb задаются числа внутри массива начиная с 1.
        int numb = 1;

        int[,] array = new int[m,n];

        //Заполнение периметра массива по часовой стрелке.
        for (int y = 0; y < n; y++) {
            array[0,y] = numb;
            numb++;
        }
        for (int x = 1; x < m; x++) {
            array[x, n - 1] = numb;
            numb++;
        }
        for (int y = n - 2; y >= 0; y--) {
            array[m - 1,y] = numb;
            numb++;
        }
        for (int x = m - 2; x > 0; x--) {
            array[x, 0] = numb;
            numb++;
        }

        //координаты след ячейки
        int c = 1;
        int d = 1;

        while (numb < m * n) 
        {
                       //вправо.
            while (array[c,d + 1] == 0) {
                array[c,d] = numb;
                numb++;
                d++;
            }

            // вниз.
            while (array[c + 1, d] == 0) {
                array[c,d] = numb;
                numb++;
                c++;
            }

            // влево.
            while (array[c, d - 1] == 0) {
                array[c, d] = numb;
                numb++;
                d--;
            }

            // вверх.
            while (array[c - 1, d] == 0) {
                array[c, d] = numb;
                numb++;
                c--;
            }
        }

        //убираем не заполненную ячейку в центре (0)
        for (int x = 0; x < m; x++) {
            for (int y = 0; y < n; y++) {
                if (array[x,y] == 0) {
                    array[x,y] = numb;
                }
            }
        }
        PrintArray(array);




