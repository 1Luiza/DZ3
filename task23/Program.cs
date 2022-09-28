/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] TableOfCubesOfNumbers (int number)
{
    int[] result = new int [number];
    for(int i = 1; i <= number; i++ )
    {
        result[i - 1] = (int)(Math.Pow(i, 3));
    }
    return result;
} 
int[] table = TableOfCubesOfNumbers(number);
{
    for(int i = 0; i < table.Length; i++)
    {
        Console.Write(table[i]+" ");
    }
}