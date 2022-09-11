int GRN1()//"Генератор случайных чисел"
{
    int n = new Random().Next(10, 100);
    return n;
}
int GRN2()//"Генератор случайных чисел"
{
    int m = new Random().Next(1, 10);
    return m;
}

void CN()//"Сравнение чисел"
{
    int n = GRN1();
    int m = GRN2();
    Console.Write(n);
    Console.Write(", ");
    Console.WriteLine(m);
    if (n % m == 0)
        Console.WriteLine("кратно");
    else 
        Console.Write("не кратно, остаток " + n % m);
}

CN();
