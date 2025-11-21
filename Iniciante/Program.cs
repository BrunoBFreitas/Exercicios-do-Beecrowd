using System;
using System.Globalization;

class Iniciante
{
    static void Main(string[] args)
    {
        Console.Clear();
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        /* 
        // BEE 1000 ==============================================================================================
        Console.WriteLine("Hello World!");

        // BEE 1001 ==============================================================================================
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"X = {a + b}");

        // BEE 1002 ==============================================================================================
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A={(3.14159 * (raio * raio)):F4}");

        // BEE 1003 ==============================================================================================
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"SOMA = {a + b}");

        // BEE 1004 ==============================================================================================
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"PROD = {a * b}");
        
        // BEE 1005 ==============================================================================================
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double media = (a*3.5 + b*7.5) / 11;

        Console.WriteLine($"MEDIA = {media:F5}");

        // BEE 1006 ==============================================================================================
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double media = (a*2 + b*3 + c*5) / 10;

        Console.WriteLine($"MEDIA = {media:F1}");

        // BEE 1007 ==============================================================================================
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"DIFERENCA = {(a*b) - (c*d)}");

        // BEE 1008 ==============================================================================================
        int number = Convert.ToInt32(Console.ReadLine());
        int workTime = Convert.ToInt32(Console.ReadLine());
        double pay = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"NUMBER = {number}\nSALARY = U$ {(workTime * pay):F2}");

        // BEE 1009 ==============================================================================================
        Console.ReadLine();     // leitura do nome
        double salary = Convert.ToDouble(Console.ReadLine());
        double sales = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"TOTAL = R$ {(salary + (0.15*sales)):F2}");

        // BEE 1010 ==============================================================================================
        string[] leitura = (Console.ReadLine()!).Split(' ');

        //int codigoPeca1 = Convert.ToInt32(leitura[0]);
        int numeroPecas1 = Convert.ToInt32(leitura[1]);
        double valorPeca1 = Convert.ToDouble(leitura[2]);

        leitura = (Console.ReadLine()!).Split(' ');

        //int codigoPeca2 = Convert.ToInt32(leitura[0]);
        int numeroPecas2 = Convert.ToInt32(leitura[1]);
        double valorPeca2 = Convert.ToDouble(leitura[2]);

        Console.WriteLine($"VALOR A PAGAR: R$ {(numeroPecas1*valorPeca1 + numeroPecas2*valorPeca2):F2}");

        // BEE 1011 ==============================================================================================
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"VOLUME = {((4.0/3.0) * 3.14159 * raio*raio*raio):F3}");

        // BEE 1012 ==============================================================================================
        string[] numeros = Console.ReadLine().Split(' ');
        double a = Convert.ToDouble(numeros[0]);
        double b = Convert.ToDouble(numeros[1]);
        double c = Convert.ToDouble(numeros[2]);

        Console.WriteLine($"TRIANGULO: {(a*c)/2 :F3}");
        Console.WriteLine($"CIRCULO: {3.14159 * c*c :F3}");
        Console.WriteLine($"TRAPEZIO: {(a+b)*c/2 :F3}");
        Console.WriteLine($"QUADRADO: {b*b :F3}");
        Console.WriteLine($"RETANGULO: {a*b :F3}");

        // BEE 1013 ==============================================================================================
        string[] valores = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(valores[0]);
        int b = Convert.ToInt32(valores[1]);
        int c = Convert.ToInt32(valores[2]);

        int maior = (a+b + Math.Abs(a-b))/2;
        maior = (maior+c + Math.Abs(maior-c))/2;

        Console.WriteLine($"{maior} eh o maior");

        // BEE 1014 ==============================================================================================
        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());

        Console.WriteLine($"{distancia/combustivel :F3} km/l");

        // BEE 1015 ==============================================================================================
        string[] ponto = Console.ReadLine().Split(' ');
        double x1 = double.Parse(ponto[0]);
        double y1 = double.Parse(ponto[1]);

        ponto = Console.ReadLine().Split(' ');
        double x2 = double.Parse(ponto[0]);
        double y2 = double.Parse(ponto[1]);

        Console.WriteLine($"{Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)) :F4}");

        // BEE 1016 ==============================================================================================
        int distancia = int.Parse(Console.ReadLine());

        Console.WriteLine($"{distancia * 2} minutos");

        // BEE 1017 ==============================================================================================
        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{velocidade*tempo / 12.00 :F3}");

        // BEE 1018 ==============================================================================================
        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine(valor);
        Console.WriteLine($"{valor/100} nota(s) de R$ 100,00"); valor %= 100;
        Console.WriteLine($"{valor/50} nota(s) de R$ 50,00"); valor %= 50;
        Console.WriteLine($"{valor/20} nota(s) de R$ 20,00"); valor %= 20;
        Console.WriteLine($"{valor/10} nota(s) de R$ 10,00"); valor %= 10;
        Console.WriteLine($"{valor/5} nota(s) de R$ 5,00"); valor %= 5;
        Console.WriteLine($"{valor/2} nota(s) de R$ 2,00"); valor %= 2;
        Console.WriteLine($"{valor} nota(s) de R$ 1,00");

        // BEE 1019 ==============================================================================================
        int tempo = int.Parse(Console.ReadLine());

        Console.Write($"{tempo/(60*60)}:"); tempo %= 60*60;
        Console.Write($"{tempo/60}:"); tempo %= 60;
        Console.Write($"{tempo}\n");

        // BEE 1020 ==============================================================================================
        int dias = int.Parse(Console.ReadLine());

        Console.WriteLine($"{dias/365} ano(s)"); dias %= 365;
        Console.WriteLine($"{dias/30} mes(es)"); dias %= 30;
        Console.WriteLine($"{dias} dia(s)");
        
        // BEE 1021 ==============================================================================================
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{(int)valor/100} nota(s) de R$ 100.00"); valor %= 100;
        Console.WriteLine($"{(int)valor/50} nota(s) de R$ 50.00"); valor %= 50;
        Console.WriteLine($"{(int)valor/20} nota(s) de R$ 20.00"); valor %= 20;
        Console.WriteLine($"{(int)valor/10} nota(s) de R$ 10.00"); valor %= 10;
        Console.WriteLine($"{(int)valor/5} nota(s) de R$ 5.00"); valor %= 5;
        Console.WriteLine($"{(int)valor/2} nota(s) de R$ 2.00"); valor = valor%2 * 100; //Converte para unidades de centavos

        Console.WriteLine("MOEDAS:"); // em centavos
        Console.WriteLine($"{(int)valor/100} moeda(s) de R$ 1.00"); valor %= 100;
        Console.WriteLine($"{(int)valor/50} moeda(s) de R$ 0.50"); valor %= 50;
        Console.WriteLine($"{(int)valor/25} moeda(s) de R$ 0.25"); valor %= 25;
        Console.WriteLine($"{(int)valor/10} moeda(s) de R$ 0.10"); valor %= 10;
        Console.WriteLine($"{(int)valor/5} moeda(s) de R$ 0.05"); valor %= 5;
        Console.WriteLine($"{(int)valor} moeda(s) de R$ 0.01");
        
        // BEE 1035 ==============================================================================================
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);
        int d = int.Parse(valores[3]);

        if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }

        // BEE 1036 ==============================================================================================
        string[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);

        double delta = (b*b) - 4 * a * c;
        if(a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine($"R1 = {(-b + Math.Sqrt(delta))/(2*a) :F5}");
            Console.WriteLine($"R2 = {(-b - Math.Sqrt(delta))/(2*a) :F5}");
        }

        // BEE 1037 ==============================================================================================
        double valor = double.Parse(Console.ReadLine());

        if (valor < 0 || valor > 100)
            Console.WriteLine("Fora de intervalo");
        else if (valor <= 25)
            Console.WriteLine("Intervalo [0,25]");
        else if (valor <= 50)
            Console.WriteLine("Intervalo (25,50]");
        else if (valor <= 75)
            Console.WriteLine("Intervalo (50,75]");
        else
            Console.WriteLine("Intervalo (75,100]");
        */


















        Console.WriteLine("\nPress ENTER to exit:"); Console.ReadLine(); Console.Clear();
    }
}





