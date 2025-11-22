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

        // BEE 1043 ==============================================================================================
        string[] lados = Console.ReadLine().Split(' ');
        double A = double.Parse(lados[0]);
        double B = double.Parse(lados[1]);
        double C = double.Parse(lados[2]);

        if (A + B > C && A + C > B && B + C > A)
        {
            Console.WriteLine($"Perimetro = {A + B + C:F1}");
        }
        else
        {
            Console.WriteLine($"Area = {((A + B) * C) / 2:F1}");
        }

        // BEE 1044 ==============================================================================================
        string[] numeros = Console.ReadLine().Split(' ');
        int A = int.Parse(numeros[0]);
        int B = int.Parse(numeros[1]);

        if (A % B == 0 || B % A == 0)
            Console.WriteLine("Sao Multiplos");
        else
            Console.WriteLine("Nao sao Multiplos");

        // BEE 1045 ==============================================================================================
        string[] leitura = Console.ReadLine().Split(' ');
        double[] lados = new double[] { double.Parse(leitura[0]), double.Parse(leitura[1]), double.Parse(leitura[2]) };

        // Ordenando os lados
        for (int i = 0; i < 3; i++)
            for (int j = i + 1; j < 3; j++)
                if (lados[j] > lados[i])
                {
                    double temporario = lados[j];
                    lados[j] = lados[i];
                    lados[i] = temporario;
                }

        if (lados[0] >= lados[1] + lados[2])
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            double ladoA2 = lados[0] * lados[0];
            double ladoBplusC2 = lados[1] * lados[1] + lados[2] * lados[2];

            if (ladoA2 == ladoBplusC2)
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (ladoA2 > ladoBplusC2)
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (ladoA2 < ladoBplusC2)
                Console.WriteLine("TRIANGULO ACUTANGULO");


            if (lados[0] == lados[1] && lados[0] == lados[2])
                Console.WriteLine("TRIANGULO EQUILATERO");
            else if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2])
                Console.WriteLine("TRIANGULO ISOSCELES");
        }

        // BEE 1046 ==============================================================================================
        string[] entrada = Console.ReadLine().Split(' ');
        int ini = int.Parse(entrada[0]);
        int fim = int.Parse(entrada[1]);

        if (fim == ini)
            Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
        else
            Console.WriteLine($"O JOGO DUROU {(fim < ini ? 24 : 0) + fim - ini} HORA(S)");

        // BEE 1047 ERRO==============================================================================================
        //************************************************************************************************************
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        string[] entrada = Console.ReadLine().Split(' ');
        int horaIni = int.Parse(entrada[0]);
        int minIni = int.Parse(entrada[1]);

        int horaFim = int.Parse(entrada[2]);
        int minFim = int.Parse(entrada[3]);


        // h_ini < h_fim => fim - ini
        // h_ini > h_fim => 24 - ini + fim
        // h_ini = h_fim && m_ini = m_fim => 24
        // m_ini < m_fim => fim - ini
        // m_ini > m_fim => 60 - ini + fim
        // m_ini = m_fim => 0

        int horas = 0;
        int minutos = 0;

        if (horaIni < horaFim)
            horas = horaFim - horaIni;
        else if (horaIni > horaFim)
            horas = 24 - horaIni + horaFim;
        else if (horaFim == horaIni && minFim == minIni)
            horas = 24;

        if (minIni < minFim)
            minutos = minFim - minIni;
        else if (minIni > minFim)
        {
            minutos = 60 - minIni + minFim;
            horas--;
        }
        else
            minutos = 0; 


        if (horaIni < horaFim)
        {
            horas = horaFim - horaIni;
            if (minIni < minFim)
            {
                minutos = minFim - minIni;
            }
            else if (minIni > minFim)
            {
                horas--;
                minutos = 60 - minFim + minIni;
            }
            else
            {

            }
        }
        else if (horaIni > horaFim)
        {
            if (minIni < minFim)
            {

            }
            else if (minIni > minFim)
            {

            }
            else
            {

            }
        }
        else
        {
            if (minIni < minFim)
            {

            }
            else if (minIni > minFim)
            {

            }
            else
            {

            }
        }


        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");

        // BEE 1048 ==============================================================================================
        double salario = double.Parse(Console.ReadLine());
        double reajuste;

        if (salario <= 400.00)
            reajuste = 0.15;
        else if (salario <= 800.00)
            reajuste = 0.12;
        else if (salario <= 1200.00)
            reajuste = 0.10;
        else if (salario <= 2000.00)
            reajuste = 0.07;
        else
            reajuste = 0.04;

        Console.WriteLine($"Novo salario: {salario * (1 + reajuste):F2}");
        Console.WriteLine($"Reajuste ganho: {salario * reajuste:F2}");
        Console.WriteLine($"Em percentual: {reajuste * 100:F0} %");

        // BEE 1049 ==============================================================================================
        string palavra1 = Console.ReadLine();
        string palavra2 = Console.ReadLine();
        string palavra3 = Console.ReadLine();

        if (palavra1 == "vertebrado")
        {
            if (palavra2 == "ave")
            {
                if (palavra3 == "carnivoro")
                    Console.WriteLine("aguia");
                else if (palavra3 == "onivoro")
                    Console.WriteLine("pomba");
            }
            else if (palavra2 == "mamifero")
            {
                if (palavra3 == "onivoro")
                    Console.WriteLine("homem");
                else if (palavra3 == "herbivoro")
                    Console.WriteLine("vaca");
            }
        }
        else if (palavra1 == "invertebrado")
        {
            if (palavra2 == "inseto")
            {
                if (palavra3 == "hematofago")
                    Console.WriteLine("pulga");
                else if (palavra3 == "herbivoro")
                    Console.WriteLine("lagarta");
            }
            else if (palavra2 == "anelideo")
            {
                if (palavra3 == "hematofago")
                    Console.WriteLine("sanguessuga");
                else if (palavra3 == "onivoro")
                    Console.WriteLine("minhoca");
            }
        }
        */

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