using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 5 caracteres e textos");

        //character 
        char primeiraLetra = ' ';

        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char)61;

        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char) (primeiraLetra + 1);

        Console.WriteLine(primeiraLetra);

        string titulo = "Alura cursos de tecnologia primeira vez "+ 2020;

        string cursosProgramacao = 
@"- .NET 
- Java
- Javascript";

        Console.WriteLine(titulo);

        Console.WriteLine(cursosProgramacao);


        string palavra = "Alura cursos online de segunda vez ;0";
        //Console.WriteLine(palavra);

        palavra = palavra + 2020;
        Console.WriteLine(palavra);



        Console.WriteLine("A execução acabou. Tecle enter para sair...");

        Console.ReadLine();






    }
}