﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Executando projeto Aliquotas com if");

        double salario = 3800;

        if (salario >= 1900 && salario <= 2800)
        {
            Console.WriteLine("O IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");


        }
        else if (salario >= 28001 && salario <= 3751.0)
        {
            Console.WriteLine("O IR é de 15% e pode deduzir R$ 350");


        }
        else if (salario >= 3751.01 && salario <= 4664.00)
        {

            Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636");
        }

           Console.WriteLine("A execução acabou. Tecle enter para sair...");

           Console.ReadLine();


    }
}






