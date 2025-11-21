using System;
using System.Globalization;
public class Iniciante_2
{
    static void Main(string[] args)
    {
        Console.Clear();
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        /*
        // BEE 1038 ==============================================================================================
        string[] entrada = Console.ReadLine().Split(' ');
        double valor = 0.0;

        switch (int.Parse(entrada[0]))
        {
            case 1: valor = 4.00;
            break;

            case 2: valor = 4.50;
            break;

            case 3: valor = 5.00;
            break;

            case 4: valor = 2.00;
            break;

            case 5: valor = 1.50;
            break;
        }

        Console.WriteLine($"Total: R$ {valor*double.Parse(entrada[1]) :F2}");
        
        // BEE 1040 ==============================================================================================
        string[] notas = Console.ReadLine().Split(' ');
        double media = (double.Parse(notas[0]) * 2 + double.Parse(notas[1]) * 3 + double.Parse(notas[2]) * 4 + double.Parse(notas[3])) / 10;

        Console.WriteLine($"Media: {media-0.0001:F1}");

        if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");

            double notaExame = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {notaExame:F1}");

            media = (media + notaExame) / 2;
            if (media >= 5.0)
                Console.WriteLine("Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");

            Console.WriteLine($"Media final: {media:F1}");
        }

        // BEE 1041 ==============================================================================================
        string[] pontos = Console.ReadLine().Split(' ');
        double X = double.Parse(pontos[0]);
        double Y = double.Parse(pontos[1]);

        if (X == Y && X == 0)
            Console.WriteLine("Origem");
        else if (X == 0)
            Console.WriteLine("Eixo Y");
        else if (Y == 0)
            Console.WriteLine("Eixo X");
        else if (X > 0)
            Console.WriteLine(Y > 0 ? "Q1" : "Q4");
        else if (X < 0)
            Console.WriteLine(Y > 0 ? "Q2" : "Q3");

        // BEE 1042 ==============================================================================================
        string[] valores = Console.ReadLine().Split(' ');
        int[] numeros = new int[] { int.Parse(valores[0]), int.Parse(valores[1]), int.Parse(valores[2]) };
        int[] ordenados = new int[] { int.Parse(valores[0]), int.Parse(valores[1]), int.Parse(valores[2]) };
        int temp;

        for (int i = 0; i < 3; i++)
            for (int j = i + 1; j < 3; j++)
                if (ordenados[j] < ordenados[i])
                {
                    temp = ordenados[i];
                    ordenados[i] = ordenados[j];
                    ordenados[j] = temp;
                }

        foreach (int numero in ordenados)
            Console.WriteLine(numero);

        Console.WriteLine();

        foreach (int numero in numeros)
            Console.WriteLine(numero);
        */

        // BEE 1043 ==============================================================================================

        // BEE 1044 ==============================================================================================

        // BEE 1045 ==============================================================================================

        // BEE 1046 ==============================================================================================

        // BEE 1047 ==============================================================================================

        // BEE 1048 ==============================================================================================

        // BEE 1049 ==============================================================================================

        // BEE 1050 ==============================================================================================

        // BEE 1051 ==============================================================================================

        // BEE 1052 ==============================================================================================

        // BEE 1059 ==============================================================================================

        // BEE 1060 ==============================================================================================

        // BEE 1061 ==============================================================================================

        // BEE 1064 ==============================================================================================

        // BEE 1065 ==============================================================================================

        // BEE 1066 ==============================================================================================

        // BEE 1067 ==============================================================================================

        // BEE 1070 ==============================================================================================

        // BEE 1071 ==============================================================================================

        // BEE 1072 ==============================================================================================

        // BEE 1073 ==============================================================================================


















        Console.WriteLine("\nPress ENTER to exit:"); Console.ReadLine(); Console.Clear();
    }

}