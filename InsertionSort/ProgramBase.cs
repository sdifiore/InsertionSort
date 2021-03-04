using System;

namespace InsertionSort
{
    public static class ProgramBase
    {
        public static void PrintArray(ArrayOrdenadocomTempo array)
        {
            foreach (var item in array.arrayValues)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine($"Tempo de processamento: {array.Duracao}");
        }

        public static int GetDimension()
        {
            Console.WriteLine("Quantos dados deseja classificar?");
            Console.WriteLine("ENTER para 100");
            var ehNumero = int.TryParse(Console.ReadLine(), out int dimensao);

            if (!ehNumero)
                dimensao = 100;

            return dimensao;
        }

        public static string GetSentido()
        {
            var opcao = "0";

            while (opcao != "1" && opcao != "2")
            {
                Console.WriteLine();
                Console.WriteLine("Escolha a opção de classificação:");
                Console.WriteLine("[1] Ascendente    [2] Descendente");
                opcao = Console.ReadKey().KeyChar.ToString();
            }

            return opcao;
        }

        public static double[] GetArray(int dimensao)
        {
            double[] sortArray = new double[dimensao];

            for (int i = 0; i < dimensao; i++)
            {
                var ehNumero = false;

                while (!ehNumero)
                {
                    Console.WriteLine($"Digite o valor do {i + 1}º elemento:");
                    ehNumero = double.TryParse(Console.ReadLine(), out sortArray[i]);
                }
            }

            return sortArray;
        }
    }
}