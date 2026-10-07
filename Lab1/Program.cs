using System.ComponentModel.Design;

internal class Program
{
    public static void Main(string[] args)
    {
        Program menu = new Program();
        menu.Menu();
    }

    public void Menu()
    {
        Program menu = new Program();
        int num;
        Console.WriteLine("1. Задание 1. Методы");
        Console.WriteLine("2. Задание 2. Условия");
        Console.WriteLine("3. Задание 3. Циклы");
        Console.WriteLine("4. Задание 4. Массивы");
        Console.Write("Выберите задание: ");
        num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                {
                    menu.FirstTask();
                    break;
                }
            case 2:
                {
                    menu.SecondTask();
                    break;
                }
            case 3:
                {
                    menu.ThirdTask();
                    break;
                }
            case 4:
                {
                    menu.FourthTask();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    public void FirstTask()
    {
        Methods metod = new Methods();
        int num;
        Console.WriteLine("1. Сумма последних двух знаков");
        Console.WriteLine("2. Положительное ли число");
        Console.WriteLine("3. Есть ли буква среди A-Z");
        Console.WriteLine("4. Делитель");
        Console.WriteLine("5. Сумма цифр из разряда единиц");
        Console.Write("Выберите задачу: ");
        num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                {
                    int x, answer;
                    Console.Write("Введите число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.SumLastNums(x);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 2:
                {
                    int x;
                    bool answer;
                    Console.Write("Введите число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.IsPositive(x);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 3:
                {
                    char x;
                    bool answer;
                    Console.Write("Введите букву: ");
                    x = Convert.ToChar(Console.Read());
                    answer = metod.IsUpperCase(x);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 4:
                {
                    int a, b;
                    bool answer;
                    Console.Write("Введите число a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    answer = metod.IsDivisor(a, b);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 5:
                {
                    int a, b;
                    int answer;
                    Console.Write("Введите число a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} это {answer}\n");
                    a = answer;
                    b = 123;
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} это {answer}\n");
                    a = answer;
                    b = 14;
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} это {answer}\n");
                    a = answer;
                    b = 1;
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} это {answer}");
                    break;
                }
            default:
                {
                    break;
                }
        }
    }


    public void SecondTask()
    {
        Methods metod = new Methods();
        int num;
        Console.WriteLine("1. Безопасное деление");
        Console.WriteLine("2. Строка сравнения");
        Console.WriteLine("3. Тройная сумма");
        Console.WriteLine("4. Возраст");
        Console.WriteLine("5. Вывод дней недели");
        Console.Write("Выберите задачу: ");
        num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                {
                    int x, y;
                    double answer;
                    Console.Write("Введите число x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    answer = metod.SafeDiv(x, y);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 2:
                {
                    int x, y;
                    string answer;
                    Console.Write("Введите число x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    answer = metod.MakeDecision(x, y);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 3:
                {
                    int x, y, z;
                    bool answer;
                    Console.Write("Введите число x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число z: ");
                    z = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Sum3(x, y, z);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 4:
                {
                    int x;
                    string answer;
                    Console.Write("Введите возраст: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Age(x);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 5:
                {
                    string x;
                    Console.Write("Введите день недели: ");
                    x = Console.ReadLine();
                    Console.WriteLine("Результат:");
                    metod.PrintDays(x);
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
    public void ThirdTask()
    {
        Methods metod = new Methods();
        int num;
        Console.WriteLine("1. Числа наоборот");
        Console.WriteLine("2. Степень числа");
        Console.WriteLine("3. Одинаковость");
        Console.WriteLine("4. Левый треугольник");
        Console.WriteLine("5. Угадайка");
        Console.Write("Выберите задачу: ");
        num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                {
                    int x;
                    string answer;
                    Console.Write("Введите число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.ReverseListNums(x);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 2:
                {
                    int x, y;
                    int answer;
                    Console.Write("Введите число x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Pow(x, y);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 3:
                {
                    int x;
                    bool answer;
                    Console.Write("Введите число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.EqualNum(x);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 4:
                {
                    int x;
                    Console.Write("Введите высоту: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат:");
                    metod.LeftTriangle(x);
                    break;
                }
            case 5:
                {
                    metod.GuessGame();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    public void FourthTask()
    {
        Methods metod = new Methods();
        Random rand = new Random();
        int[] array = new int[rand.Next(5, 11)];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-5, 10);
        }
        int num;
        Console.WriteLine("1. Поиск последнего значения");
        Console.WriteLine("2. Добавление в массив");
        Console.WriteLine("3. Реверс");
        Console.WriteLine("4. Объединение");
        Console.WriteLine("5. Удалить негатив");
        Console.Write("Выберите задачу: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Массив:");
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine("]");
        switch (num)
        {
            case 1:
                {
                    int x;
                    int answer;
                    Console.Write("Введите число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.FindLast(array, x);
                    Console.WriteLine($"Результат: {answer}");
                    break;
                }
            case 2:
                {
                    int x, pos;
                    int[] answer;
                    Console.Write("Введите число x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите позицию: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Add(array, x, pos);
                    Console.WriteLine("Результат: ");
                    Console.Write("[ ");
                    for (int i = 0; i < answer.Length; i++)
                    {
                        Console.Write($"{answer[i]} ");
                    }
                    Console.WriteLine("]");
                    break;
                }
            case 3:
                {
                    metod.Reverse(array);
                    Console.WriteLine($"Результат:");
                    Console.Write("[ ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"{array[i]} ");
                    }
                    Console.WriteLine("]");
                    break;
                }
            case 4:
                {
                    int[] massive = new int[rand.Next(3, 6)];
                    for (int i = 0; i < massive.Length; i++)
                    {
                        massive[i] = rand.Next(-5, 10);
                    }
                    Console.WriteLine("Массив 2:");
                    Console.Write("[ ");
                    for (int i = 0; i < massive.Length; i++)
                    {
                        Console.Write($"{massive[i]} ");
                    }
                    Console.WriteLine("]");
                    int[] answer;
                    answer = metod.Concat(array, massive);
                    Console.WriteLine($"Результат:");
                    Console.Write("[ ");
                    for (int i = 0; i < answer.Length; i++)
                    {
                        Console.Write($"{answer[i]} ");
                    }
                    Console.WriteLine("]");
                    break;
                }
            case 5:
                {
                    int[] answer;
                    answer = metod.DeleteNegative(array);
                    Console.WriteLine($"Результат:");
                    Console.Write("[ ");
                    for (int i = 0; i < answer.Length; i++)
                    {
                        Console.Write($"{answer[i]} ");
                    }
                    Console.WriteLine("]");
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}
