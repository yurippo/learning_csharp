using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        bool foiPromovido = true;

        double salario = 2000;

        if (foiPromovido)
        {
            salario = 4200.0;
        }
        else
        {
            salario = 3800.0;
        }

        Console.WriteLine(salario);
    }
}