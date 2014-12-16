using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNN.StructureElements
{
    public class ANNinput
    {
        int number;
        double value;
        string layer;

        public ANNinput(int _number, double _value)
        {
            this.number = _number;
            this.value = _value;
            this.layer = "input";
        }

        public int nNumber
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public double nValue
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public string gLayer
        {
            get { return this.layer; }
            set { this.layer = value; }
        }
    }
}
