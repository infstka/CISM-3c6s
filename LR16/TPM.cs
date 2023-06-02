using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR16
{
    class TPM
    {
        public Perceptron[] perceptrons;
        int Output;
        int K = 5;
        int N = 8;
        
        public TPM(int[] first, int[] second, int[] third, int[] fourth, int[] fifth)
        {
            perceptrons = new Perceptron[5] { new Perceptron(first), new Perceptron(second), new Perceptron(third), new Perceptron(fourth), new Perceptron(fifth) };
        }

        public TPM() { }

        public int GetOutput(int[,] Ainputs)
        {
            Output = 1;
            for (int i = 0; i < K; i++)
            {
                int[] buffer = new int[8];
                for (int j = 0; j < N; j++)
                {
                    buffer[j] = Ainputs[i, j];
                }
                Output *= perceptrons[i].GetOutput(buffer);
            }
            return Output;
        }
        public void Synchronize()
        {
            for (int i = 0; i < K; i++)
            {
                perceptrons[i].ActualizeWeights(Output);
            }
        }

        public List<int> getWeights()
        {
            List<int> buffer = new List<int>();
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    buffer.Add(perceptrons[j].Weights[i]);
                }
            }
            return buffer;
        }
    }
}
