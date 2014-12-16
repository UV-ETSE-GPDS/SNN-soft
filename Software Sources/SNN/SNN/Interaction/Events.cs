using System;
using System.Collections.Generic;
using System.Text;
using SNN.Globals;
using SNN.Logic;
using SNN.StructureElements;

namespace SNN.Interaction
{
    public class Events
    {
        Variables _globalVariables;
        Flags _flags;
        SNNmain _mainForm;
        Methods _methods;

        public Events(Variables globalVariables, Flags globalFlags, SNNmain mainForm, Methods methods)
        {
            this._globalVariables = globalVariables;
            this._flags = globalFlags;
            this._mainForm = mainForm;
            this._methods = methods;
        }

        #region NeuronEvents

        public void fireInput(object sender, InputNeuronArgs ina)
        {
            InputNeuron neuron = (InputNeuron)sender;
            for (int i = 0; i < this._globalVariables.numberLayer1; i++)
                this._globalVariables.synapsesInLay1[neuron.number, i].sendThroughSynapse();
        }
        public void fireLayer1(object sender, NeuronArgs na)
        {
            Neuron neuron = (Neuron)sender;
            if (_globalVariables.isLearning == true)
            {
                _mainForm.StopTimer();
                _globalVariables.suspended = true;
                _methods.newSTDP(_globalVariables.Aparameter, _globalVariables.tauD, _globalVariables.tauP, neuron, "Layer 1");
                _globalVariables.suspended = false;
                _mainForm.StartTimer();
              
            }
            for (int i = 0; i < this._globalVariables.numberOutput; i++)
                this._globalVariables.synapsesLay1Out[neuron.number, i].sendThroughSynapse();
        }
        public void fireOutput(object sender, NeuronArgs na)
        {
            Neuron neuron = (Neuron)sender;

            if (_globalVariables.isLearning == true)
            {
                _mainForm.StopTimer();
                _globalVariables.suspended = true;
                _methods.newSTDP(_globalVariables.Aparameter, _globalVariables.tauD, _globalVariables.tauP, neuron, "output");
                _globalVariables.suspended = false;
                _mainForm.StartTimer();
            }

            //if (_flags.simulationModeFlag == 2)
            {
                this._globalVariables.lineOutput = this._globalVariables.lineOutput +" -> " + (neuron.number + 1).ToString() + ": "  +this._globalVariables.time.ToString() + "ms";
            }

        }

        #endregion NeuronEvents
    }
}
