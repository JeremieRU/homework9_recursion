int TakeConsoleInt(string str = "")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}

string FromNto1(int n)
{
    if (n == 0)
        return $"{n.ToString()} - Введён ноль!";
    if (n > 0)
        return $"{FromNto1POS(n)}";
    return $"{FromNto1NEG(n)}";
}

string FromNto1POS(int n)
{
    if (n == 1)
        return $"{n.ToString()}";
    else
        return $"{n.ToString()}, {FromNto1POS(n - 1)}";
}

string FromNto1NEG(int n)
{
    if (n == 1)
        return $"{n.ToString()}";
    else
        return $"{n.ToString()}, {FromNto1NEG(n + 1)}";
}

int SumFromMtoN(int m, int n)
{
    if (m == n)
        return m;
    return m + (SumFromMtoN(m + 1, n));
}

int AkermanF(int m, int n)                          //ломается на значенияx 4,2; 4,1 - ещё считает
{
    if (m < 0 || n < 0)
        return -1;
    if (m == 0)
        return n + 1;
    if (m != 0 && n == 0)
        return AkermanF(m - 1, 1);
    return AkermanF(m - 1, AkermanF(m, n - 1));
}

switch (TakeConsoleInt("Введите номер задачи(64, 66, 68): "))
{
    default:
        Console.Write("Введён некорректный номер задачи");
        break;
    case 64:
        Console.Write("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.\nN = 5 -> 5, 4, 3, 2, 1\nN = 8 -> 8, 7, 6, 5, 4, 3, 2, 1\n");
        int n64 = TakeConsoleInt("Введите число N: ");
        Console.WriteLine($"{FromNto1(n64)}");
        break;
    case 66:
        Console.Write("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\nM = 1; N = 15 -> 120\nM = 4; N = 8. -> 30\n");
        int m66 = TakeConsoleInt("Введите число M: ");
        int n66 = TakeConsoleInt("Введите число N: ");
        Console.Write($"M = {m66}; N = {n66} -> {SumFromMtoN(m66, n66)}");
        break;
    case 68:
        Console.Write("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\nm = 2, n = 3 -> A(m,n) = 9\nm = 3, n = 2 -> A(m,n) = 29\n");
        int m68 = TakeConsoleInt("Введите число M: ");
        int n68 = TakeConsoleInt("Введите число N: ");
        Console.Write($"m = {m68}, n = {n68} -> A({m68},{n68} = {AkermanF(m68, n68)})");
        break;
}