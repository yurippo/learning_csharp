using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto P11 - Calcula Poupança2");

        double valorInvestido = 1000;

        double fatorDeRendimento = 1.0036;

        for (int contadorAno = 1;contadorAno <= 5; contadorAno++)
        {
            for (int contadorMes = 1; contadorMes <=12; contadorMes++)
            {
                valorInvestido = valorInvestido * fatorDeRendimento;
            }

            fatorDeRendimento += 0.0010;
        }

        Console.WriteLine("Ao término do investimento você terá R$ " + valorInvestido );

        Console.WriteLine("A execução acabou. Tecle enter para sair...");

        Console.ReadLine();

    }

}

