// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
int[] FillArray(int size)  // метод заполнения массива, параметр метода является размером массива
{
    int[] myArray = new int[size]; // объявление и иницифлизация массива
    for (int i = 0; i < myArray.Length; i++) // цикл перебора массива
    {
        myArray[i] = new Random().Next(0, 100); // кладем в каждый элемет массива рандомное число от 0 до 100
    }
    return myArray; //  возвращаем массив
}

void PrintArray(int[] array) // метод вывода массива
{
    for (int i = 0; i < array.Length; i++) // цикл перебора массива
    {
        System.Console.Write($"{array[i]},"); 
    }
    System.Console.WriteLine(); 
}

int InputSizeArray(string msg) // метод ввода числа
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = 8; 
int[] myArray = FillArray(sizeArray); // заполняем массив рандомным числом от 0 до 100
PrintArray(myArray); // выводим массив


