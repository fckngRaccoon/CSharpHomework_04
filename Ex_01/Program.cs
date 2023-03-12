int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse (readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Ошибка! Меньше нуля!");
        return false;
    }
    return true;
}

int powerBase = Prompt("Основание: ");
int exponent = Prompt("Показатель: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Итог: {(Power(powerBase, exponent))}");
}