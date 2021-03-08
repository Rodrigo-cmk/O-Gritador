using System;

namespace O_Gritador
{
    class Program
    {
        static void Main(string[] args)
        {



           string QualquerCoisaSerDigitada;

           Console.WriteLine();
           Console.WriteLine();
           Console.ForegroundColor=ConsoleColor.Cyan;
           Console.WriteLine("|---GRITADOR---");
           Console.WriteLine("|Digite algo a ser repetido, gritando (em CAIXA ALTA).");
           Console.ForegroundColor=ConsoleColor.White;
           Console.WriteLine();
           Console.WriteLine();


            
            Console.WriteLine("- Por favor digite algo para prosseguir...");
            Console.WriteLine();

            QualquerCoisaSerDigitada = Console.ReadLine();
            Console.WriteLine();

            
            Console.WriteLine($"{QualquerCoisaSerDigitada.ToUpper()}");
            
            
            
            












        }
    }
}
