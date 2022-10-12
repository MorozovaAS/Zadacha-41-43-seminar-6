void Zadacha1()
{
    System.Console.WriteLine("Введите числа через запятую(,): ");
    string words = Console.ReadLine();
    string[] nums = words.Split(",");
    int amount = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        int numbers = Int32.Parse(nums[i]);
        if (numbers > 0)
        {
            amount += 1;
        }
    }
    Console.WriteLine("Количество чисел больше нуля равно: " + amount);
}

void Zadacha2()
{
    double ReadData(string msg)
    {
        System.Console.Write(msg);
        double number = double.Parse(System.Console.ReadLine());
        return number;
    }

    void PrintData(string msg)
    {
        System.Console.WriteLine(msg);
    }

    double FindX(double b1, double b2, double k1, double k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        return x;
    }
    double FindY(double b1, double k1, double x)
    {
        double y = k1 * x + b1;
        return y;
    }

    void Line(double b1, double b2, double k1, double k2, double x, double y)
    {
        if (k1 != k2)
        {
            PrintData("Точка пересечения двух прямых (" + x + ";" + y + ")");
        }
        else if (k1 == k2 && b1 != b2)
        {
            PrintData("Прямые параллельны");
        }
        else if (k1 == k2 && b1 == b2)
        {
            PrintData("Прямые совпадают");
        }
    }
    double b1 = ReadData("Введите значение b1: ");
    double k1 = ReadData("Введите значение k1: ");
    double b2 = ReadData("Введите значение b2: ");
    double k2 = ReadData("Введите значение k2: ");
    double x = FindX(b1, b2, k1, k2);
    double y = FindY(b1, k1, x);
    Line(b1, b2, k1, k2, x, y);
}
