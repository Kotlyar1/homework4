Console.Write("Введите число A: ");
string a = Console.ReadLine();

Console.Write("Введите число B: ");
string b = Console.ReadLine();

double degreeResult;

double RaiseToAdegree(double number, int degreeOfNumber)
{
    double degree = 1;
    for (int i = 0; i < degreeOfNumber; i++)
    {
        degree *= number;
    }
    return degree;
}

void ExcepttionHandling(string enterA, string enterB)
{
    bool yesDoble = double.TryParse(enterA, out double resultNumber);
    bool yesInt = int.TryParse(enterB, out int result);

    if(yesInt && yesDoble && result > 0)
    {
        degreeResult = RaiseToAdegree(resultNumber, result);
        Console.WriteLine("{0} в степени {1} = {2}",
                        resultNumber, result, degreeResult);
    }
    else
    {
        Console.WriteLine("{0}, {1} -> Некоректный ввод!\nВведите числа от 1 или равные 1", a, b);
    }
}
ExcepttionHandling(a, b);
