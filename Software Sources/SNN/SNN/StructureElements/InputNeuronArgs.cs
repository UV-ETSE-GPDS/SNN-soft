using System;
using System.Collections.Generic;
using System.Text;

namespace SNN.StructureElements
{
    public class InputNeuronArgs : System.EventArgs
    {
        private string message;

        public InputNeuronArgs(string m)
        {
            this.message = m;
        }
        public string Message()
        {
            return message;
        }
    }

}
