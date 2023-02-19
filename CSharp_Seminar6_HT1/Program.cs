// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//  Преобразование строки ввода (последовательность чиселб разделенных запятой или пробелом)
//  в числовой массив
int [] InputArray (string message)
{
    Console.WriteLine (message);
    string [] numbersEnter = Console.ReadLine().Split (new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    int [] numbers = numbersEnter.Select(Int32.Parse).ToArray();
    return (numbers);
}
// подсчет количества введенных чисел > 0
int PositiveNumbCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0) count++; 
    }
    return count;
}
int [] numbs = InputArray ("Введите последовательность чисел, разделяя их запятыми или пробелами:");
int result = PositiveNumbCount (numbs);

Console.WriteLine ($"В массиве [{string.Join (", ", numbs)}] введено {result} чисел > 0"); 
