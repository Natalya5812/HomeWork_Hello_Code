// Найти максимальное из трех чисел
Console.Write ("Введите первое число: ");
Double A = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введите второе число: ");
Double B = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введите третье число: ");
Double C = Convert.ToDouble (Console.ReadLine ());
Double MAX = A;

if (MAX < A)
{
Console.WriteLine ("MAX = " + A);
}
else if (MAX < B)
{
Console.WriteLine ("MAX = " + B);
}
else if (MAX < C)
{
Console.WriteLine ("MAX = " + C);
}

