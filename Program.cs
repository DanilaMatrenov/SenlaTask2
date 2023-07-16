try
{
    Console.Write("Введите первое число ");
    int first = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число ");
    int second = int.Parse(Console.ReadLine());
    int nod, nok;
    static int nods(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }

        }
        return a;
    }
    Console.WriteLine("Нод " + nods(first, second));
    nok = (first * second) / nods(first, second);
    Console.WriteLine("Нок " + nok.ToString());
}
catch { Console.WriteLine("Ошибка в числах повторите попытку"); }