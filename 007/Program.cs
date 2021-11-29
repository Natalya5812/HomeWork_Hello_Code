// Выяснить является ли число чётным
Console.Write ("Введите целое число: ");
int A = int.Parse (Console.ReadLine ());

if (A % 2 == 0)
{
    Console.WriteLine (A + " является четным числом");

}
else
{
    Console.WriteLine (A + " не является четным числом");
}