// Написать программу вычисления значения функции y = f(a)
// y = a-1, a>=0;
// y = |a|, a<0

Console.Write("Введите значение 'a': ");
int a = int.Parse(Console.ReadLine());

if(a >= 0)
{
    Console.WriteLine("y = " + (a - 1));
}
else
{
    Console.WriteLine("y = " + Math.Abs(a));
}