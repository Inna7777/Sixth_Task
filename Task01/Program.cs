// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
//чисел больше 0 ввёл пользователь.

int[] InputMas(int M)
{
    //Console.Write("Введите колличество чисел  ");
    //M = Convert.ToInt32(Console.ReadLine());
    int[] mas = new int[M];
    int i = 0;
    while (i < M)
    {
        Console.WriteLine($"Введите {i + 1}-е число");
        //mas[i] = Convert.ToInt32(Console.ReadLine());
        mas[i] = GetNumber("");
        i++;
    }
    return mas;
}

int CountNegativ(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el < 0)
        {
            count++;
        }
    }
    return count;
}

int GetNumber(string message)
{
    int result;
    while (true)
    {
        if (message.Length > 0)
        {
            Console.WriteLine(message);
        }
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}
int M = GetNumber("Введите количесво чисел");
int[] mas = InputMas(M);
int negativeValues = CountNegativ(mas);
Console.WriteLine($"Отрицательных чисел-{negativeValues}");
