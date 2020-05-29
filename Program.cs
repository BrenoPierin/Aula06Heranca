using System;

namespace Aula6Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa breno = new Pessoa();
            breno.nome = "Breno";
            System.Console.WriteLine(breno.saudacao());
            
            Cpf gpf = new Cpf();
            gpf.cpf = "000.000.000-00";
            gpf.valido = true;
            System.Console.WriteLine(gpf.validado());

        }
    }
}
