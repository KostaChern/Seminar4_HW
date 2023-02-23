// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Inputint(string prompt)
{
    System.Console.Write($"{prompt}  --> ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num >= 0)
    {
        return true;
    }
    System.Console.WriteLine("Попробуйте снова. Второе число должно быть ПОЛОЖИТЕЛЬНЫМ!");
    return false;
}


int degree(int usNum1, int usNum2)
{

    int result = usNum1 * usNum1;
    for (int i = 2; i < usNum2; i++)
    {
        result = result * usNum1;
    }
    return result;

}


int usNum1 = Inputint("Введите число");
int usNum2 = Inputint("Введите положительное число");

if (Validate(usNum2))
{
    System.Console.WriteLine($"{usNum1} в степени {usNum2} = {degree(usNum1, usNum2)}");

}

