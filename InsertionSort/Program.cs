using System;

namespace InsertionSort
{
    class Program
    {
        static void Main()
        {
            var dimensao = ProgramBase.GetDimension();
            var opcao = ProgramBase.GetSentido();

            Console.Clear();

            var sortArray = ProgramBase.GetArray(dimensao);

            Console.Clear();
            Console.WriteLine("** Início do processamento - Aguarde **");

            var resultado = new ArrayOrdenadocomTempo();

            if (opcao == "1")
                resultado = Classifica.Ascende(dimensao, sortArray);
            else
                resultado = Classifica.Descende(dimensao, sortArray);

            ProgramBase.PrintArray(resultado);
        }
    }
}
