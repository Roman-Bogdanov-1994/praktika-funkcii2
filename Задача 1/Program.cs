int GRN()//"Генератор случайных чисел
{
    int n = new Random().Next(10, 100);
    return n;
}

void CN()
{
    int n = GRN();//Сравнение чисел
    Console.WriteLine(n);
    int a = n / 10;
    int b = n % 10;
    if (a > b)
        Console.WriteLine(a);
    else if (b > a)
        Console.WriteLine(b);
    else
       Console.WriteLine("=");
}

CN();