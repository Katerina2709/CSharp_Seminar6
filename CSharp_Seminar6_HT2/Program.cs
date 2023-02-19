// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  ввод и конвертация из строки в целые числа коэффицентов обеих линейных функций
double [,] EnterLinesFactors()
{
    double [,] factors = new double [2, 2];
    Console.WriteLine("Введите коэффициенты линейных функций y=k1*x+b1 и y=k2*x+b2");
    for (int i = 0; i < 2; i++)
    {
        Console.Write ($"b{i + 1} = ");
        factors [i,0] = Convert.ToDouble(Console.ReadLine());
        Console.Write ($"k{i + 1} = ");
        factors [i,1] = Convert.ToDouble(Console.ReadLine());
    }
    return factors;

}

// нахождение координат точки пеесечения двух прямых
double [] CoordCrossPoint (double [,] array)
{
    double [] coordinates = new double [2];
    coordinates [0] = (array [1,0] - array[0,0]) / (array [0,1] - array[1,1]);
    coordinates [1] = array [0,1] * coordinates [0] + array[0,0];
    return coordinates;    
}

double [,] factorLines =  EnterLinesFactors();

if (factorLines [0,1] != factorLines [1,1])
{
    double [] coord = CoordCrossPoint (factorLines);  
    Console.WriteLine ($"Точка пересечения прямых: ({string.Join (", ", coord)})");
}
else
{
    if (factorLines [0,0] == factorLines [1,0])
        Console.WriteLine ("Прямые совпадают");
    else
    {
        Console.WriteLine ("Прямые параллельны");
    }    
}


