/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void palindrom (int number)
{
    int firstDigit = number / 10000;
    int fifthDigit = number % 10;
    if (firstDigit == fifthDigit)
    {
        number = number / 10;
        int secondDigit = (number / 100) % 10;
        int fourthDigit = number % 10;
        if(secondDigit == fourthDigit)
        {
            Console.WriteLine("Да");
        } 
    else Console.WriteLine("Нет");        
    }
}
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
palindrom(number);