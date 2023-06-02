using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR16
{
    class Perceptron
    {
        int L = 3;
        int N = 8;
        public int[] Inputs;
        public int[] Weights;
        public int Output;

       public Perceptron(int[] _weights)
        {
            Weights = new int[N];
            for (int i = 0; i < _weights.Length; i++){
                Weights[i] = _weights[i];
            }
           
        }

        public int GetOutput(int[] AInputs)
        {
            Inputs = AInputs;
            Output = 0;
            for(int i = 0; i < N; i++)
            {
                Output += Inputs[i] * Weights[i];
            }
            if (Output > 0)
            {
                Output = 1;
            }
            else
            {
                Output = -1;
            }
            return Output;
        }

        public void ActualizeWeights(int OutputTPM)
        {
            if (OutputTPM == Output)
            {
                for (int i = 0; i < N; i++)
                {
                    Weights[i] = Weights[i] + (Output * Inputs[i]);
                    if (Weights[i] >= L)
                    {
                        Weights[i] = L;
                    }
                    else if (Weights[i] < -L)
                    {
                        Weights[i] = -L;
                    }
                }
            }
        }
    }
}
