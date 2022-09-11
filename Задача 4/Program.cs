Console.WriteLine("Введиле число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("На что делим?");
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a % b % c == 0)
    Console.WriteLine("Кратно, ответ " + a / b / c);
else 
   Console.WriteLine("Не кратно, ответ " + a / b / c + " Остаток " + a % b % c);