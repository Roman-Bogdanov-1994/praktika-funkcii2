int GRN()//"Генератор случайных чисел"
{
    int n = new Random().Next(100, 1000);
    return n;
}

void DMN()//"Удаление среднего числа"
{
    int n = GRN();
    Console.WriteLine(n);
    int a = n / 100;
    int b = n % 10;
        Console.Write(a);
        Console.Write(b);

}

DMN();