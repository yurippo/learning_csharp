﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 Condicionais2");

        int idadeJoao = 18;

        //int quantidadePessoas = 2;

        //bool acompanhado = quantidadePessoas >= 2;

        bool acompanhado = false;


        if (idadeJoao >= 18 && acompanhado == true)
        {

            Console.WriteLine("João pode entrar");
        }
        else
        {
            Console.WriteLine("João não pode entrar");
        }


        Console.WriteLine("A execução acabou. Tecle enter para sair...");

        Console.ReadLine();






    }
}