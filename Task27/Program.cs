// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();

int Inputint(string prompt)
{
    System.Console.Write($"{prompt} >");
    return Convert.ToInt32(Console.ReadLine());

}

int numberSumm(int number)
{
    int result = 0;
    for (int i = 1; number > 0; i++)
    {
        result = number % 10 + result;
        number = number / 10;
    }
    return result;
}

int userNumber = Inputint("Введите число");
System.Console.WriteLine($"Сумма цифр числа {userNumber} = {numberSumm(userNumber)}");