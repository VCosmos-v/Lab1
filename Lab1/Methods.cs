using System;
using System.Collections.Generic;
using System.Text;

internal class Methods
{
    public int SumLastNums(int x)
    {
        return (x % 10 + x / 10 % 10);
    }

    public bool IsPositive(int x)
    {
        return x > 0;
    }

    public bool IsUpperCase(char x)
    {
        string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNM";
        return alphabet.Contains(x);
    }

    public bool IsDivisor(int a, int b)
    {
        return (a % b == 0 || b % a == 0);
    }

    public int LastNumSum(int a, int b)
    {
        return (a % 10 + b % 10);
    }

    public double SafeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }
        else
        {
            return x / y;
        }
    }

    public String MakeDecision(int x, int y)
    {
        if (x > y)
        {
            return $"{x} > {y}";
        }
        else
        {
            if (x == y)
            {
                return $"{x} = {y}";
            }
            else
            {
                return $"{x} < {y}";
            }
        }
    }

    public bool Sum3(int x, int y, int z)
    {
        if (x + y == z || x + z == y || y + z == x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public String Age(int x)
    {
        if (x % 10 == 1 && x != 11)
        {
            return $"{x} год";
        }
        else
        {
            if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) &&
                (x != 12 || x != 13 || x != 14))
            {
                return $"{x} года";
            }
            else
            {
                return $"{x} лет";
            }
        }
    }

    public void PrintDays(String x)
    {
        switch (x)
        {
            case "понедельник":
                {
                    Console.WriteLine("понедельник");
                    Console.WriteLine("вторник");
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("п€тница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;
                }
            case "вторник":
                {
                    Console.WriteLine("вторник");
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("п€тница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;
                }
            case "среда":
                {
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("п€тница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;
                }
            case "четверг":
                {
                    Console.WriteLine("четверг");
                    Console.WriteLine("п€тница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;
                }
            case "п€тница":
                {
                    Console.WriteLine("п€тница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;
                }
            case "суббота":
                {
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;
                }
            case "воскресенье":
                {
                    Console.WriteLine("воскресенье");
                    break;
                }
            default:
                {
                    Console.WriteLine("Ёто не день недели");
                    break;
                }
        }
    }

    public String ReverseListNums(int x)
    {
        string answer = "";
        for (int i = x; i >= 0; i--)
        {
            answer += $"{i} ";
        }
        return answer;
    }

    public int Pow(int x, int y)
    {
        int a = 1;
        for (int i = 0; i < y; i++)
        {
            a *= x;
        }
        return a;
    }

    public bool EqualNum(int x)
    {
        int a = x % 10;
        while (x / 10 != 0)
        {
            if (x % 10 != a)
            {
                return false;
            }
            x /= 10;
        }
        return true;
    }

    public void LeftTriangle(int x)
    {
        string text = "";
        for (int i = 1; i <= x; i++)
        {
            text += "*";
            Console.WriteLine(text);
        }
    }

    public void GuessGame()
    {
        Random rand = new Random();
        int answer = rand.Next(10);
        int a, i = 0;
        do
        {
            i += 1;
            Console.WriteLine("¬ведите число от 0 до 9");
            a = Convert.ToInt32(Console.ReadLine());
            if (a != answer)
            {
                Console.WriteLine("¬ы не угадали");
            }
        }
        while (answer != a);
        Console.WriteLine("¬ы угадали!");
        Console.WriteLine($"¬ы отгадали число за {i} попытки");
    }

    public int FindLast(int[] arr, int x)
    {
        int answer = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                answer = i;
            }
        }
        return answer;
    }

    public int[] Add(int[] arr, int x, int pos)
    {
        int[] answer = new int[arr.Length + 1];
        int k = 0;
        for (int i = 0; i < answer.Length; i++)
        {
            if (i == pos)
            {
                answer[i] = x;
            }
            else
            {
                answer[i] = arr[k];
                k += 1;
            }
        }
        return answer;
    }

    public void Reverse(int[] arr)
    {
        int a;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            a = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = a;
        }
    }

    public int[] Concat(int[] arr1, int[] arr2)
    {
        int[] answer = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            answer[i] = arr1[i];
        }
        for (int i = arr1.Length; i < answer.Length; i++)
        {
            answer[i] = arr2[i - arr1.Length];
        }
        return answer;
    }

    public int[] DeleteNegative(int[] arr)
    {
        int x = arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                x -= 1;
            }
        }
        int[] answer = new int[x];
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                answer[k] = arr[i];
                k++;
            }
        }
        return answer;
    }

}
