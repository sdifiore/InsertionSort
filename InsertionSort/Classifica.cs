using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    public static class Classifica
    {
        public static ArrayOrdenadocomTempo Ascende(int dimensao, double[] sortArray)
        {
            var startTime = DateTime.Now;

            for (int i = 1; i < dimensao; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sortArray[j] > sortArray[i])
                    {
                        var calice = sortArray[j];
                        sortArray[j] = sortArray[i];
                        sortArray[i] = calice;
                    }
                }
            }

            var retorno = new ArrayOrdenadocomTempo { arrayValues = sortArray, Duracao = DateTime.Now - startTime };

            return retorno;
        }

        public static ArrayOrdenadocomTempo Descende(int dimensao, double[] sortArray)
        {
            var startTime = DateTime.Now;

            for (int i = 1; i < dimensao; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sortArray[j] < sortArray[i])
                    {
                        var calice = sortArray[j];
                        sortArray[j] = sortArray[i];
                        sortArray[i] = calice;
                    }
                }
            }

            var retorno = new ArrayOrdenadocomTempo { arrayValues = sortArray, Duracao = DateTime.Now - startTime };

            return retorno;
        }

        
    }
}
