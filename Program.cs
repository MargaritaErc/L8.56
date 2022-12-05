// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int [,]array = new int[new Random ().Next(2,7), new Random().Next(2,7)];
for (int i = 0; i<array.GetLength(0); i++);
{
    for (int j = 0; j< array.GetLength(1); j++)
    {
        array [i,j] = new Random().Next(0,12);
        Console.WriteLine(array[i, j] + "  ");
}
Console.WriteLine();
}
Console.WriteLine("________");

int sum = 0;
int minsum = Int32.MaxValue;
int minrow = 0;
 for (int i =0; i<array.GetLength(0);i++)
 {
    for(int j = 0;j < array.GetLength(1); j++ )
    {
        sum +=array[i,j];
    }
    if (sum<minsum)
    {
        minsum=sum;
        minrow=i;
    }
    sum=0;
 }
 Console.WriteLine("Номер строки с наименьшей суммой элементов" +minrow);