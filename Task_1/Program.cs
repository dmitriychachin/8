/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/

//создание массива
int[]  GetArray( int n)
{
    int[] array = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

//Создание библиотеки
int [,] dictonary(int [] array, int m)
{
    int [,] matrix = new int [m, 2];
    int n = 0;
    Array.Sort(array);
    //int m = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            matrix [1, n] = matrix[1,n] + 1;
        }
        else 
        {
            matrix [0, n + 1] = array[i];
        }   
    }
}

//Красивая библиотека
int [,] bDictonary(int [,] matrix)
{
    int count = 0;

    for (int n = 0; n < matrix.GetLength(0); n++)
    {
      if (matrix[0 , n] == 0 && matrix[0 ,n + 1] == 0)
      {
        break;
      }
      else
      {
        count++;
      }  
    }


    int [,] bmatrix = new int [2,count];

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < count; j++)
        {
            bmatrix[i,j] = matrix[i,j];
        }
    }
    return bmatrix;

}

void printArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int n = 7;

int [] startArray = GetArray(n);

Array.Sort(startArray);

printArray(startArray);

int m = startArray.Length;

int [] secArray = startArray;

int [,] dic = dictonary(secArray, m);

int [,] bdic = bDictonary(dic);

Console.WriteLine();

PrintMatrix(bdic);








//matrix[0 , n] != 0 && matrix[0 ,n + 1] == 0








//copyArray[i] = array[i];




















/*
int [,] dictonary(int [,] matrix)
{
    int [,] dictonsry = new int [m,1];

    for (int i = 0; i < matrix.GetLenght(0); i++)
    {
        for (int j = 0; j < matrix.GetLenght(1); j++)
        {
            if (matrix[i,j] == matrix [i,j + 1])
            {
                dictonsry = 
            }
        }
    }
}
*/