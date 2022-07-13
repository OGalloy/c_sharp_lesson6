/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
//Инициализация массива.
//Инициализация переменной подсчёта целых чисел.
int count = 0; 
Console.WriteLine("Программа для подсчёта количества чисел,");
Console.WriteLine("которые больше ноля.");
calcPositiveVAlue();
Console.WriteLine("Количество чисел больше ноля: {0}", count);
//Функция подсчёта положительных чисел с использованием рекурсии.
int calcPositiveVAlue()
{   
    Console.WriteLine("Введите целое число или q для вывода результата.");
    string value = Console.ReadLine();
    if (value != "q")
    {
        if (Convert.ToInt32(value) > 0) count += 1;
        return calcPositiveVAlue();
    }
    return 0;
}


