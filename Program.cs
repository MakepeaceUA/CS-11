using System;


class Program
{
    static void Main(string[] args)
    {

        //Задание 1
        //Text mess;
        //Mathe math = null;
        //mess = ShowMessage;
        //mess("Hello, this is message.");

        //mess = ShowLowerMessage;
        //mess("Hello, this is message.");

        //mess = ShowUpperCaseMessage;
        //mess("Hello, this is message.");


        //void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
        //void ShowLowerMessage(string message)
        //{
        //    Console.WriteLine(message.ToLower());
        //}
        //void ShowUpperCaseMessage(string message)
        //{
        //    Console.WriteLine(message.ToUpper());
        //}

        //Задание 2
        //Console.WriteLine("Enter operation:");
        //string op = Console.ReadLine();
        //double num1 = 4;
        //double num2 = 5;
        //switch (op)
        //{
        //    case "+":
        //        math = Addition;
        //        break;
        //    case "-":
        //        math = Subtraction;
        //        break;
        //    case "*":
        //        math = Multiplication;
        //        break;
        //    default:
        //        Console.WriteLine("Invalid operation");
        //        break;
        //}
        //Console.WriteLine(math?.Invoke(num1, num2));

        //double Addition(double num1, double num2)
        //{
        //    return num1 + num2;
        //}
        //double Subtraction(double num1, double num2)
        //{
        //    return num1 - num2;
        //}
        //double Multiplication(double num1, double num2)
        //{
        //    return num1 * num2;
        //}



        //Задание 3
        //Predicate<int> isEven = number => number % 2 == 0;
        //Predicate<int> isOdd = number => number % 2 != 0;
        //Predicate<int> isPrime = IsPrime;
        //Predicate<int> isFibonacci = IsFibonacci;

        //Console.WriteLine("Enter number:");
        //int number = int.Parse(Console.ReadLine());

        //// Перевірки
        //Console.WriteLine(isEven(number));
        //Console.WriteLine(isOdd(number));
        //Console.WriteLine(isPrime(number));
        //Console.WriteLine(isFibonacci(number));

        //bool IsPrime(int number)
        //{
        //    if (number <= 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        //bool IsFibonacci(int number)
        //{
        //    if (number < 0)
        //        return false;

        //    bool isPerfectSquare(int x)
        //    {
        //        int s = (int)Math.Sqrt(x);
        //        return s * s == x;
        //    }
        //    return isPerfectSquare(5 * number * number + 4) || isPerfectSquare(5 * number * number - 4);
        //}




        //Задание 4
        //CheckEven isEven = delegate (int number)
        //{
        //    return number % 2 == 0;
        //};

        //Console.WriteLine("Enter number:");
        //int input = Convert.ToInt32(Console.ReadLine());

        //if (isEven(input))
        //{
        //    Console.WriteLine("Paired.");
        //}
        //else
        //{
        //    Console.WriteLine($"Unpaired.");
        //}


        //Задание 5
        //CubeDelegate cube = x => x * x * x;
        //int num = 2;

        //Console.WriteLine(cube(num));



        //Задание 6
        //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //CheckNumber isOdd = n => n % 2 != 0;

        //Console.WriteLine("Unpaired numbers:");
        //for (int i = 0; i < num.Length; i++)
        //{
        //    if (isOdd(num[i]))
        //    {
        //        Console.Write($"{num[i]}, ");
        //    }
        //}



        Console.ReadKey();
    }

    //delegate bool CheckNumber(int n);
    //delegate int CubeDelegate(int x);
    //delegate bool CheckEven(int number);
    //delegate void Text(string message);
    //delegate double Mathe(double num1, double num2);
}



