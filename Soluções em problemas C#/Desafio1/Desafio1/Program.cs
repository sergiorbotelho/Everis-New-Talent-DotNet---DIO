using System;

namespace Desafio1 {
    class Program {
        static void Main(string[] args) {
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            int cont = 0;
            int j = valorLido;
            for (int i = 0; i < 10; i++) {
                n[i] = j;
                j *= 2;
                
            }

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("N[{0}] = {1}", cont, n[i]);
                cont++;
            }
        }
    }
}
