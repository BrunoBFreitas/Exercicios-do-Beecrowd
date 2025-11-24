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

        Console.WriteLine($"O JOGO DUROU {(ini < fim ? fim - ini : 24 + fim - ini)} HORA(S)");

        // BEE 1047 ==============================================================================================
        string[] entrada = Console.ReadLine().Split(' ');
        int horIni = int.Parse(entrada[0]);
        int minIni = int.Parse(entrada[1]);

        int horFim = int.Parse(entrada[2]);
        int minFim = int.Parse(entrada[3]);

        // Calcula as "posições" temporais em minutos
        int tempoInicial = horIni * 60 + minIni;
        int tempoFinal = horFim * 60 + minFim;

        // Calcula a distância temporal em minutos
        int tempo = tempoInicial < tempoFinal ? tempoFinal - tempoInicial : 24 * 60 + tempoFinal - tempoInicial;

        Console.Write($"O JOGO DUROU {tempo / 60} HORA(S) E ");
        tempo %= 60;
        Console.WriteLine($"{tempo} MINUTO(S)");
        
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

        // BEE 1050 ==============================================================================================
        int DDD = int.Parse(Console.ReadLine());

        switch (DDD)
        {
            case 61: Console.WriteLine("Brasilia"); break;
            case 71: Console.WriteLine("Salvador"); break;
            case 11: Console.WriteLine("Sao Paulo"); break;
            case 21: Console.WriteLine("Rio de Janeiro"); break;
            case 32: Console.WriteLine("Juiz de Fora"); break;
            case 19: Console.WriteLine("Campinas"); break;
            case 27: Console.WriteLine("Vitoria"); break;
            case 31: Console.WriteLine("Belo Horizonte"); break;
            default: Console.WriteLine("DDD nao cadastrado"); break;
        }

        // BEE 1051 ==============================================================================================
        double salario = double.Parse(Console.ReadLine());

        if (salario <= 2000.00)
            Console.WriteLine("Isento");
        else if (salario <= 3000.00)
            Console.WriteLine($"R$ {(salario - 2000) * 0.08:F2}");
        else if (salario <= 4500.00)
            Console.WriteLine($"R$ {(salario - 3000) * 0.18 + 1000 * 0.08:f2}");
        else
            Console.WriteLine($"R$ {(salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08:F2}");

        // BEE 1052 ==============================================================================================
        int mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1: Console.WriteLine("January"); break;
            case 2: Console.WriteLine("February"); break;
            case 3: Console.WriteLine("March"); break;
            case 4: Console.WriteLine("April"); break;
            case 5: Console.WriteLine("May"); break;
            case 6: Console.WriteLine("June"); break;
            case 7: Console.WriteLine("July"); break;
            case 8: Console.WriteLine("August"); break;
            case 9: Console.WriteLine("September"); break;
            case 10: Console.WriteLine("October"); break;
            case 11: Console.WriteLine("November"); break;
            case 12: Console.WriteLine("December"); break;
        }

        // BEE 1059 ==============================================================================================
        for(int i = 2; i <= 100; i+=2)
            Console.WriteLine(i);

        // BEE 1060 ==============================================================================================
        double[] numeros = new double[6];
        for(int i = 0; i < 6; i++)
            numeros[i] = double.Parse(Console.ReadLine());
        
        int contador = 0;
        for(int i = 0; i < 6; i++)
            if(numeros[i] > 0)
                contador++;
        
        Console.WriteLine(contador + " valores positivos");

        // BEE 1061 ==============================================================================================
        string[] entrada;
        int tempoIni;
        int tempoFim;

        int segNoDia = 24 * 60 * 60;   // Segundos em um único dia

        // Calcula as "posições" temporais em segundos
        entrada = Console.ReadLine().Split(' ');
        tempoIni = int.Parse(entrada[1]) * segNoDia;
        entrada = Console.ReadLine().Split(' ');
        tempoIni += int.Parse(entrada[0]) * 60 * 60 + int.Parse(entrada[2]) * 60 + int.Parse(entrada[4]);

        entrada = Console.ReadLine().Split(' ');
        tempoFim = int.Parse(entrada[1]) * segNoDia;
        entrada = Console.ReadLine().Split(' ');
        tempoFim += int.Parse(entrada[0]) * 60 * 60 + int.Parse(entrada[2]) * 60 + int.Parse(entrada[4]);

        // Calcula a distância temporal em segundos
        int tempo = tempoIni < tempoFim ? tempoFim - tempoIni : 30 * segNoDia + tempoFim - tempoIni;

        Console.WriteLine($"{tempo / segNoDia} dia(s)"); tempo %= segNoDia;
        Console.WriteLine($"{tempo / (60 * 60)} hora(s)"); tempo %= 60 * 60;
        Console.WriteLine($"{tempo / 60} minuto(s)"); tempo %= 60;
        Console.WriteLine($"{tempo} segundo(s)");

        // BEE 1064 ==============================================================================================
        double[] numeros = new double[6];
        for(int i = 0; i < 6; i++)
            numeros[i] = double.Parse(Console.ReadLine());
        
        int contador = 0;
        double soma = 0;
        foreach(double numero in numeros)
        {
            if (numero > 0)
            {
                contador++;
                soma += numero;
            }
        }

        Console.WriteLine($"{contador} valores positivos\n{soma/contador :F1}");

        // BEE 1065 ==============================================================================================
        int[] numeros = new int[5];
        for(int i = 0; i < 5; i++)
            numeros[i] = int.Parse(Console.ReadLine());
        
        int contador = 0;
        foreach(int numero in numeros)
        {
            if(numero % 2 == 0)
                contador++;
        }

        Console.WriteLine($"{contador} valores pares");

        // BEE 1066 ==============================================================================================
        int[] numeros = new int[5];
        for (int i = 0; i < 5; i++)
            numeros[i] = int.Parse(Console.ReadLine());

        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
                pares++;
            else
                impares++;

            if (numero > 0)
                positivos++;
            else if (numero < 0)
                negativos++;
        }

        Console.WriteLine($"{pares} valor(es) par(es)");
        Console.WriteLine($"{impares} valor(es) impar(es)");
        Console.WriteLine($"{positivos} valor(es) positivo(s)");
        Console.WriteLine($"{negativos} valor(es) negativo(s)");

        // BEE 1067 ==============================================================================================
        int valor = int.Parse(Console.ReadLine());
        for (int i = 1; i <= valor; i += 2)
            Console.WriteLine(i);

        // BEE 1070 ==============================================================================================
        int valor = int.Parse(Console.ReadLine());
        if (valor % 2 == 0) valor++;

        for (int i = 6; i > 0; i--)
        {
            Console.WriteLine(valor);
            valor += 2;
        }

        // BEE 1071 ==============================================================================================
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int soma = 0;
        for (int i = Math.Min(x, y) + 1; i < Math.Max(x, y); i++)
            if (i % 2 != 0)
                soma += i;

        Console.WriteLine(soma);

        // BEE 1072 ==============================================================================================
        int N = int.Parse(Console.ReadLine());
        int contador = 0;
        int valor;

        for (int i = 0; i < N; i++)
        {
            valor = int.Parse(Console.ReadLine());
            if (valor >= 10 && valor <= 20)
                contador++;
        }

        Console.WriteLine($"{contador} in");
        Console.WriteLine($"{N - contador} out");

        // BEE 1073 ==============================================================================================
        int valor = int.Parse(Console.ReadLine());

        for (int i = 2; i <= valor; i += 2)
            Console.WriteLine($"{i}^2 = {i * i}");
        */

















        Console.WriteLine("\nPress ENTER to exit:"); Console.ReadLine(); Console.Clear();
    }

}