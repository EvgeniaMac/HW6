// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PositivNumber (int count)
{
    int [] number = new int [count];
    int positivNumber = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите положительное или отрицательное число № {i+1} из {count}: ");
        number[i] = Convert.ToInt32(Console.ReadLine());
        positivNumber += number[i] > 0 ? 1:0;
    }
    Console.Write("Вы ввели положительных чисел: " + positivNumber);
}
int count = 4;
PositivNumber(count);