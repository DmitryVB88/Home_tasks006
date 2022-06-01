// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Clear();
Console.Write("Введите число n = ");
int n = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите число m = ");
int m = int.Parse(Console.ReadLine()?? "");
int[,] matrix = new int[n, m];
for(int row = 0; row < matrix.GetLength(0); row++)
  {
       for(int column = 0; column < matrix.GetLength(1); column++)
       {
       matrix[row, column] = new Random().Next(2, 10);
       }
    
}  

for(int row = 0; row < matrix.GetLength(0); row++)
  {
       for(int column = 0; column < matrix.GetLength(1); column++)
       {
              Console.Write($"{matrix[row, column] = row + column} ");
       }
       Console.WriteLine();
  }

