using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

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
        string text;
        int num = 0;
        Console.WriteLine("1. Çàäàíèå 1. Ìåòîäû");
        Console.WriteLine("2. Çàäàíèå 2. Óñëîâèÿ");
        Console.WriteLine("3. Çàäàíèå 3. Öèêëû");
        Console.WriteLine("4. Çàäàíèå 4. Ìàññèâû");
        Console.Write("Âûáåğèòå çàäàíèå: ");
        text = Console.ReadLine();
        while (num > 4 || num < 1)
        {
            while (!int.TryParse(text, out _))
            {
                Console.WriteLine("Ââåäåí íåêîğåêòíûé ñèìâîë");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
            num = Convert.ToInt32(text);
            if (num > 4 || num < 1)
            {
                Console.WriteLine("Ââåäåíî íåêîğåêòíîå ÷èñëî");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
        }
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
        string text;
        int num = 0;
        Console.WriteLine("1. Ñóììà ïîñëåäíèõ äâóõ çíàêîâ");
        Console.WriteLine("2. Ïîëîæèòåëüíîå ëè ÷èñëî");
        Console.WriteLine("3. Åñòü ëè áóêâà ñğåäè A-Z");
        Console.WriteLine("4. Äåëèòåëü");
        Console.WriteLine("5. Ñóììà öèôğ èç ğàçğÿäà åäèíèö");
        Console.Write("Âûáåğèòå çàäà÷ó: ");
        text = Console.ReadLine();
        while (num > 4 || num < 1)
        {
            while (!int.TryParse(text, out _))
            {
                Console.WriteLine("Ââåäåí íåêîğåêòíûé ñèìâîë");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
            num = Convert.ToInt32(text);
            if (num > 4 || num < 1)
            {
                Console.WriteLine("Ââåäåíî íåêîğåêòíîå ÷èñëî");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
        }
        switch (num)
        {
            case 1:
                {
                    int x, answer;
                    Console.Write("Ââåäèòå ÷èñëî: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.SumLastNums(x);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 2:
                {
                    int x;
                    bool answer;
                    Console.Write("Ââåäèòå ÷èñëî: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.IsPositive(x);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 3:
                {
                    char x;
                    bool answer;
                    Console.Write("Ââåäèòå áóêâó: ");
                    x = Convert.ToChar(Console.Read());
                    answer = metod.IsUpperCase(x);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 4:
                {
                    int a, b;
                    bool answer;
                    Console.Write("Ââåäèòå ÷èñëî a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ÷èñëî b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    answer = metod.IsDivisor(a, b);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 5:
                {
                    int a, b;
                    int answer;
                    Console.Write("Ââåäèòå ÷èñëî a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ÷èñëî b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} ıòî {answer}\n");
                    a = answer;
                    b = 123;
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} ıòî {answer}\n");
                    a = answer;
                    b = 14;
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} ıòî {answer}\n");
                    a = answer;
                    b = 1;
                    answer = metod.LastNumSum(a, b);
                    Console.Write($"{a} + {b} ıòî {answer}");
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
        string text;
        int num = 0;
        Console.WriteLine("1. Áåçîïàñíîå äåëåíèå");
        Console.WriteLine("2. Ñòğîêà ñğàâíåíèÿ");
        Console.WriteLine("3. Òğîéíàÿ ñóììà");
        Console.WriteLine("4. Âîçğàñò");
        Console.WriteLine("5. Âûâîä äíåé íåäåëè");
        Console.Write("Âûáåğèòå çàäà÷ó: ");
        text = Console.ReadLine();
        while (num > 4 || num < 1)
        {
            while (!int.TryParse(text, out _))
            {
                Console.WriteLine("Ââåäåí íåêîğåêòíûé ñèìâîë");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
            num = Convert.ToInt32(text);
            if (num > 4 || num < 1)
            {
                Console.WriteLine("Ââåäåíî íåêîğåêòíîå ÷èñëî");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
        }
        switch (num)
        {
            case 1:
                {
                    int x, y;
                    double answer;
                    Console.Write("Ââåäèòå ÷èñëî x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ÷èñëî y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    answer = metod.SafeDiv(x, y);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 2:
                {
                    int x, y;
                    string answer;
                    Console.Write("Ââåäèòå ÷èñëî x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ÷èñëî y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    answer = metod.MakeDecision(x, y);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 3:
                {
                    int x, y, z;
                    bool answer;
                    Console.Write("Ââåäèòå ÷èñëî x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ÷èñëî y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ÷èñëî z: ");
                    z = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Sum3(x, y, z);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 4:
                {
                    int x;
                    string answer;
                    Console.Write("Ââåäèòå âîçğàñò: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Age(x);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 5:
                {
                    string x;
                    Console.Write("Ââåäèòå äåíü íåäåëè: ");
                    x = Console.ReadLine();
                    Console.WriteLine("Ğåçóëüòàò:");
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
        string text;
        int num = 0;
        Console.WriteLine("1. ×èñëà íàîáîğîò");
        Console.WriteLine("2. Ñòåïåíü ÷èñëà");
        Console.WriteLine("3. Îäèíàêîâîñòü");
        Console.WriteLine("4. Ëåâûé òğåóãîëüíèê");
        Console.WriteLine("5. Óãàäàéêà");
        Console.Write("Âûáåğèòå çàäà÷ó: ");
        text = Console.ReadLine();
        while (num > 4 || num < 1)
        {
            while (!int.TryParse(text, out _))
            {
                Console.WriteLine("Ââåäåí íåêîğåêòíûé ñèìâîë");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
            num = Convert.ToInt32(text);
            if (num > 4 || num < 1)
            {
                Console.WriteLine("Ââåäåíî íåêîğåêòíîå ÷èñëî");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
        }
        switch (num)
        {
            case 1:
                {
                    int x;
                    string answer;
                    Console.Write("Ââåäèòå ÷èñëî: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.ReverseListNums(x);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 2:
                {
                    int x, y;
                    int answer;
                    Console.Write("Ââåäèòå ÷èñëî x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ÷èñëî y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Pow(x, y);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 3:
                {
                    int x;
                    bool answer;
                    Console.Write("Ââåäèòå ÷èñëî: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.EqualNum(x);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 4:
                {
                    int x;
                    Console.Write("Ââåäèòå âûñîòó: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ğåçóëüòàò:");
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
        string text;
        int num = 0;
        Console.WriteLine("1. Ïîèñê ïîñëåäíåãî çíà÷åíèÿ");
        Console.WriteLine("2. Äîáàâëåíèå â ìàññèâ");
        Console.WriteLine("3. Ğåâåğñ");
        Console.WriteLine("4. Îáúåäèíåíèå");
        Console.WriteLine("5. Óäàëèòü íåãàòèâ");
        Console.Write("Âûáåğèòå çàäà÷ó: ");
        text = Console.ReadLine();
        while (num > 4 || num < 1)
        {
            while (!int.TryParse(text, out _))
            {
                Console.WriteLine("Ââåäåí íåêîğåêòíûé ñèìâîë");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
            num = Convert.ToInt32(text);
            if (num > 4 || num < 1)
            {
                Console.WriteLine("Ââåäåíî íåêîğåêòíîå ÷èñëî");
                Console.Write("Âûáåğèòå çàäàíèå: ");
                text = Console.ReadLine();
            }
        }
        Console.WriteLine("Ìàññèâ:");
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
                    Console.Write("Ââåäèòå ÷èñëî: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    answer = metod.FindLast(array, x);
                    Console.WriteLine($"Ğåçóëüòàò: {answer}");
                    break;
                }
            case 2:
                {
                    int x, pos;
                    int[] answer;
                    Console.Write("Ââåäèòå ÷èñëî x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ââåäèòå ïîçèöèş: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                    answer = metod.Add(array, x, pos);
                    Console.WriteLine("Ğåçóëüòàò: ");
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
                    Console.WriteLine($"Ğåçóëüòàò:");
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
                    Console.WriteLine("Ìàññèâ 2:");
                    Console.Write("[ ");
                    for (int i = 0; i < massive.Length; i++)
                    {
                        Console.Write($"{massive[i]} ");
                    }
                    Console.WriteLine("]");
                    int[] answer;
                    answer = metod.Concat(array, massive);
                    Console.WriteLine($"Ğåçóëüòàò:");
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
                    Console.WriteLine($"Ğåçóëüòàò:");
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
