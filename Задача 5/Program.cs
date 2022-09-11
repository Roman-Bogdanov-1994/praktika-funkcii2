Console.WriteLine("Введиле два числа");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
// if (a * a == b)
//     Console.WriteLine("a^2 = b");
// else 
//    Console.WriteLine("a^2 = " + a * a);
if (a * a == b)
     Console.WriteLine("a^2 = b");
else if (b * b == a)
     Console.WriteLine("b^2 = a");
else     
    Console.WriteLine("Ни одно число не квадрат другого");