﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 9 Escopo");

        int idadeJoao = 18;

        bool acompanhado = true;

        string mensagemAdicional;

        if (acompanhado == true)
        {
            mensagemAdicional = "João está acompanhado!";
        }
        else
        {
            mensagemAdicional = "João NÃO está acompanhado";
        }


        if (idadeJoao >= 18 || acompanhado == true)
        {

            Console.WriteLine("João pode entrar");
            Console.WriteLine(mensagemAdicional);
        }
        else
        {
            Console.WriteLine("João não pode entrar");
        }




        Console.WriteLine("A execução acabou. Tecle enter para sair...");

        Console.ReadLine();






    }
}