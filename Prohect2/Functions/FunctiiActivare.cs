﻿using System;

namespace Prohect2
{
    public class FunctiiActivare
    {
        static public double CalculActivareTreapta(Neuron neuron)
        {
            if (neuron.ginput >= neuron.teta) return 1;
            return 0;
        }

        static public double CalculActivareSemn(Neuron neuron)
        {
            if (neuron.ginput >= neuron.teta) return 1;
            return -1;
        }

        static public double CalculActivareSigmoidala(Neuron neuron)
        {
            double numarator = 1f;
            double numitor = 1 + Math.Pow(Math.E, -1 * neuron.g * (neuron.ginput - neuron.teta));
            return numarator / numitor;
        }

        static public double CalculActivareTanh(Neuron neuron)
        {
            double numarator = Math.Pow(Math.E, neuron.g * (neuron.ginput - neuron.teta)) - Math.Pow(Math.E, -1 * neuron.g * (neuron.ginput - neuron.teta));
            double numitor = Math.Pow(Math.E, neuron.g * (neuron.ginput - neuron.teta)) + Math.Pow(Math.E, -1 * neuron.g * (neuron.ginput - neuron.teta));
            return numarator / numitor ;
        }

        static public double CalculActivareLiniara(Neuron neuron)
        {
            if (neuron.ginput - neuron.teta < -1/neuron.g) return -1;
            if (neuron.ginput - neuron.teta > 1/neuron.g) return 1;
            return (neuron.ginput - neuron.teta) * neuron.g;
        }
    }
}
