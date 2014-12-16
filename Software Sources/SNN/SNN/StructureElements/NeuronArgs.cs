using System;
using System.Collections.Generic;
using System.Text;

namespace SNN
{
    public class NeuronArgs : System.EventArgs
    {
        private string message;

        public NeuronArgs(string m)
        {
            this.message = m;
        }

        public string Message()
        {
            return message;
        }
    }
}
