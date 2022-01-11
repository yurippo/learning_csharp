using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 10 - Calcula Poupança");

        int contadorMes = 1; 
        double valorInvestido = 1000;

        while(contadorMes <= 12)
        {

            //0.36% = 0.0036
            valorInvestido = valorInvestido + valorInvestido * 0.0036;

            Console.WriteLine("Mês "+ contadorMes + " Após um mês você terá R$" + valorInvestido);

            contadorMes ++;
        }        


            Console.WriteLine("A execução acabou. Tecle enter para sair...");

            Console.ReadLine();

        }

    }

