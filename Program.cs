using System;

namespace gbhw9
{
    class Program
    {
        // 1, 2... 
        // static int ReadInt(string prompt){
        //     Console.WriteLine(prompt);
        //     return Convert.ToInt32(Console.ReadLine());
        // }

        // 1...
        // static int SumNumbers(int m, int n){
        //     if (m == n+1) return 0;
        //     return m + SumNumbers(m+1, n);
        // }

        // 2...
        // static int Akkerman(int m, int n){
        //     if (m == 0) return n+1;
        //     if (m > 0 && n == 0) return Akkerman(m-1, 1);
        //     if (m > 0 && n > 0) return Akkerman(m-1, Akkerman(m, n-1));
        //     return 0;
        // }

        static void Main(string[] args)
        {
            // 1...
            // Console.WriteLine(SumNumbers(ReadInt("Введите число m: "), ReadInt("Введите число n: ")));

            // 2...
            // Console.WriteLine(Akkerman(ReadInt("Введите число m: "), ReadInt("Введите число n: ")));
        }
    }
}
