using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNN.StructureElements
{
    public class ANNneuron
    {
        int number;
        public double bias;
        public int numberInputs;
        public double[] weights;
        string layer;

        public ANNneuron(int _number, double _bias, int _numberInputs, string _layerName)
        {
            this.number = _number;
            this.bias = _bias;
            this.numberInputs = _numberInputs;
            this.weights = new double[_numberInputs];
            this.layer = _layerName;
        }
        public void assignWeight(int weightIntex, double weight)
        {
            if ((this.weights != null) && (this.weights.Length < weightIntex))
                this.weights[weightIntex] = weight;
        }
        public double changeBias
        {
            get { return this.bias; }
            set { this.bias = value; }
        }
        public int gNumber
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public string gLayer
        {
            get { return this.layer; }
            set { this.layer = value; }
        }

    }
}
