using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Iniciante_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        /*
        // BEE 1074 ==============================================================================================
        int N = int.Parse(Console.ReadLine());
        int[] valores = new int[N];

        for (int i = 0; i < N; i++)
            valores[i] = int.Parse(Console.ReadLine());

        foreach (int valor in valores)
            Console.WriteLine(valor == 0 ? "NULL" : (valor % 2 == 0 ? "EVEN" : "ODD") + (valor > 0 ? " POSITIVE" : " NEGATIVE"));

        // BEE 1075 ==============================================================================================
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10000; i++)
            if (i % N == 2)
                Console.WriteLine(i);

        // BEE 1078 ==============================================================================================
        int N = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
            Console.WriteLine($"{i} x {N} = {i*N}");

        // BEE 1079 ==============================================================================================
        int N = int.Parse(Console.ReadLine());
        string[] valores = new string[N];

        for (int i = 0; i < valores.Length; i++)
            valores[i] = Console.ReadLine();

        for (int i = 0; i < valores.Length; i++)
        {
            string[] numeros = valores[i].Split(' ');
            double N1 = double.Parse(numeros[0]);
            double N2 = double.Parse(numeros[1]);
            double N3 = double.Parse(numeros[2]);

            Console.WriteLine($"{(N1 * 2 + N2 * 3 + N3 * 5) / 10:F1}");
        }

        // BEE 1080 ==============================================================================================
        int maior = int.Parse(Console.ReadLine());
        int posMaior = 0;

        for (int i = 1; i < 100; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            if (valor > maior)
            {
                maior = valor;
                posMaior = i + 1;
            }
        }

        Console.WriteLine($"{maior}\n{posMaior}");

        // BEE 1094 ==============================================================================================
        int N = int.Parse(Console.ReadLine());
        int C = 0;
        int R = 0;
        int S = 0;

        for (int i = 0; i < N; i++)
        {
            string[] experimento = Console.ReadLine().Split(' ');

            if (experimento[1] == "C")
                C += int.Parse(experimento[0]);
            else if (experimento[1] == "R")
                R += int.Parse(experimento[0]);
            else if (experimento[1] == "S")
                S += int.Parse(experimento[0]);
        }

        int total = C + R + S;

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {C}");
        Console.WriteLine($"Total de ratos: {R}");
        Console.WriteLine($"Total de sapos: {S}");
        Console.WriteLine($"Percentual de coelhos: {(double)C / total * 100:F2} %");
        Console.WriteLine($"Percentual de ratos: {(double)R / total * 100:F2} %");
        Console.WriteLine($"Percentual de sapos: {(double)S / total * 100:F2} %");

        // BEE 1095 ==============================================================================================
        int i = 1;
        int j = 60;
        while (j >= 0)
        {
            Console.WriteLine($"I={i} J={j}");
            i += 3;
            j -= 5;
        }

        // BEE 1096 ==============================================================================================
        for (int i = 1; i <= 9; i += 2)
            for (int j = 7; j >= 5; j--)
                Console.WriteLine($"I={i} J={j}");

        // BEE 1097 ==============================================================================================
        for (int i = 1; i <= 9; i += 2)
            for (int j = 7 + i - 1; j >= i + 4; j--)
                Console.WriteLine($"I={i} J={j}");

        // BEE 1098 ERRO ==============================================================================================
        //*************************************************************************************************************
        for (double i = 0.0; i <= 2; i += 0.2)
            for (int j = 1; j <= 3; j++)
                Console.WriteLine(i == 0 || i == 1 || i == 2 ? $"I={i} J={j}" : $"I={i:F1} J={j + i:F1}");

        // BEE 1099 ==============================================================================================
        int N = int.Parse(Console.ReadLine());
        int[] somas = new int[N];

        // Faz leitura dos valores e calcula os ímpares entre eles
        for (int i = 0; i < N; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);
            somas[i] = 0;

            for (int j = Math.Min(X, Y) + 1; j < Math.Max(X, Y); j++)
                if (j % 2 != 0) somas[i] += j;
        }

        foreach(int soma in somas)
            Console.WriteLine(soma);

        // BEE 1101 ==============================================================================================
        while (true)
        {
            string[] leitura = Console.ReadLine().Split(' ');
            int M = int.Parse(leitura[0]);
            int N = int.Parse(leitura[1]);

            if (Math.Min(M, N) <= 0) break;

            int soma = 0;
            for (int i = Math.Min(M, N); i <= Math.Max(M, N); i++)
            {
                Console.Write($"{i} ");
                soma += i;
            }
            Console.WriteLine($"Sum={soma}");
        }

        // BEE 1113 ==============================================================================================
        while (true)
        {
            string[] leitura = Console.ReadLine().Split(' ');
            int X = int.Parse(leitura[0]);
            int Y = int.Parse(leitura[1]);

            if (X == Y) break;

            Console.WriteLine(X > Y ? "Decrescente" : "Crescente");
        }
        */

        // BEE 1114 ==============================================================================================

        // BEE 1115 ==============================================================================================

        // BEE 1116 ==============================================================================================

        // BEE 1117 ==============================================================================================

        // BEE 1118 ==============================================================================================

        // BEE 1131 ==============================================================================================

        // BEE 1132 ==============================================================================================

        // BEE 1133 ==============================================================================================

        // BEE 1134 ==============================================================================================

        // BEE 1142 ==============================================================================================

        // BEE 1143 ==============================================================================================

        // BEE 1044 ==============================================================================================


        Console.WriteLine("\nPress ENTER to exit:"); Console.ReadLine(); Console.Clear();
    }
}