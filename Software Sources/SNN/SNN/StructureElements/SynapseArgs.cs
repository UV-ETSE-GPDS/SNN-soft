using System;
using System.Collections.Generic;
using System.Text;

namespace SNN.StructureElements
{
    public class SynapseArgs : System.EventArgs
    {
        private string message;

        public SynapseArgs(string m)
        {
            this.message = m;
        }

        public string Message()
        {
            return message;
        }
    }
}
