﻿namespace Prohect2
{
    public class Neuron
    {
        public int nOfInputs;
        public double[] x;
        public double[] w;
        public double g;
        public double teta;
        public double ginput;
        public double activation;
        public double output;

        public int inputFunction;
        public int activationFunction;
        public int binaryState;

        public Neuron()
        {
            nOfInputs = 0;
            g = 1;
            teta = 0;
            ginput = 0;
            activation = 0;
            output = 0;

            inputFunction = NeuronState.SUM;
            activationFunction = NeuronState.TREAPTA;
            binaryState = NeuronState.BINARYFALSE;
        }

    }
}
