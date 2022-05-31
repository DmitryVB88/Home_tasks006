// Задайте массив размером M x N заполненный вещественными числами. 

Console.Clear();
double[,] matrix = new double [4,5];
Random random = new Random();

void PrintArray (double[,] matr)
{
   for(int i = 0; i < matr.GetLength(0); i++) 
    {
       for(int j = 0; j < matr.GetLength(1); j++)
       {
           Console.Write($"{matr[i, j]} "); 
       }
           Console.WriteLine();
    }
}

void FillArray (double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.NextDouble()*12;
        }
    }    
}



double[,] matr = new double[3,4];
FillArray(matr);
Console.WriteLine();
PrintArray(matr);
