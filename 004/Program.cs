// Даны два числа. Показать большее и меньшее число

Console.Write ("Введите первое число: ");
double A = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введите второе число: ");
double B = Convert.ToDouble (Console.ReadLine ());

if (A > B)
{
    Console.WriteLine (A + " = MAX; MIN = " + B);
}
else
{
    Console.WriteLine (B + " = MAX; MIN = " + A);
}