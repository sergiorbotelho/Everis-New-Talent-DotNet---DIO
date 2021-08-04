using System;
using System.Globalization;
namespace Desafio3 {
    class Program {
        static void Main(string[] args) {
            double a, b = 0, avg;
            int positive = 0;

            for (int i = 0; i < 6; i++) {
                a = double.Parse(Console.ReadLine());
                if (a > 0) {
                    positive++;
                    b += a;
                }
            }
            avg = b / positive;
            Console.WriteLine("{0} valores positivos", positive);
            Console.WriteLine(Math.Round(avg, 1));

        }
    }
}
