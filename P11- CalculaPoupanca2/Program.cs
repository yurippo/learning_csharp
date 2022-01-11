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

      for( int contadorMes = 1; contadorMes <= 12; contadorMes ++)
        {
            valorInvestido = valorInvestido + valorInvestido * 0.0036;

            Console.WriteLine("Mes " + contadorMes + " você terá R$" + valorInvestido);

        }
        

        Console.WriteLine("A execução acabou. Tecle enter para sair...");

        Console.ReadLine();

    }

}

