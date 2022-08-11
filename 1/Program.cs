// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);


void getCount(string[] localArray)
{
    int count = 0;

    for (int i = 0; i < localArray.Length; i++)
    {
        int a = int.Parse(array[i]);

        if (a > 0)
        count++;
    }
    Console.WriteLine($"{count}");
}

getCount(array);