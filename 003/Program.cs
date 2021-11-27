// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
int dayofweek = int.Parse (Console.ReadLine());
if (dayofweek == 1)
 {
     Console.WriteLine ("Первый день недели - это Понедельник");
 }
else if (dayofweek == 2)
 {
     Console.WriteLine ("Второй день недели - это Вторник");
     }
else if (dayofweek == 3)
 {
     Console.WriteLine ("Третий день недели - это Среда");
     }
 else if (dayofweek == 4)
 {
     Console.WriteLine ("Четвертый день недели - это Четверг");
     }
else if (dayofweek == 5)
 {
     Console.WriteLine ("Пятый день недели - это Пятница");
     }  
     else if (dayofweek == 6)
 {
     Console.WriteLine ("Шестой день недели - это Суббота");
     }  
     else if (dayofweek == 7)
 {
     Console.WriteLine ("Седьмой день недели - это Воскресенье");
     }  
     else
     {
            Console.WriteLine ("Неподходящее значение");
     }


