// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
int day = int.Parse (Console.ReadLine());
string[] array = 
{
    "Неделя начинается с понедельника",
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье"
};

if (day < 7 || day >=0)
{
    Console.WriteLine(array [day]);
}

else if (day > 7 || day <0)
{
    Console.WriteLine("В неделе 7 дней!");
}