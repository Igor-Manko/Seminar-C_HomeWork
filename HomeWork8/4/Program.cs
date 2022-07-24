// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

void FillArrayThree(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                 Console.Write($"({i},{j},{k})-{arr[i, j, k] = new Random().Next(10,100)} ");
                //Console.Write($" {arr[i, j, k] = new Random().Next(10, 100)}");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array = new int [2,2,2];
FillArrayThree(array);
