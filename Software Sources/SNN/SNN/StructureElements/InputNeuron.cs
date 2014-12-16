using System;
using System.Collections.Generic;
using System.Text;

namespace SNN.StructureElements
{
    public class InputNeuron
    {
        #region EventsDeclarations

            public delegate void FiringHandler(object sender, InputNeuronArgs ina);
            public event FiringHandler Fire;
            private delegate void BlinkDelegate(string secondsInterval);

        #endregion EventsDeclarations

        #region InputNeuronFields

            System.Timers.Timer clock;          // clk ticking

        public long internalTime;           // in fact time of simulation

        public int number;                  // number
        public List<long> history = new List<long>();   //history of spikes' times
        private int delay;                              //input neuron delay
        public int delayCopy;                           //copy of the delay        
        public string layerName;                        // "input"
        private int clearHistoryEvery;                  // for better efficiency history is being clear, if == 0 history is not clear

        SNNmain mainForm;                               //reference to main form

        #endregion InputNeuronFields

        //constructor:
        public InputNeuron(int number, int delay, SNNmain form)
        {
            this.mainForm = form;
            this.number = number;
            this.delay = delay;
            this.delayCopy = delay;
            this.layerName = "input";

            this.clock = new System.Timers.Timer();
            this.clock.Interval = 2;
            this.clock.Elapsed += new System.Timers.ElapsedEventHandler(clock_Elapsed);
            this.clearHistoryEvery = 0;
        }

        // timers' events
        #region timersElapsed

        void clock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // this.internalTime++;
            if (mainForm.globalVariablesOfMainForm.suspended == true)
            {

            }
            else
            {
                this.delay--;
                if (this.clearHistoryEvery != 0)
                {
                    if (this.internalTime % this.clearHistoryEvery == 0)
                    {
                        this.history.Clear();
                        this.history = new List<long>();
                    }
                }
                if (this.delay == 0)
                {
                    this.delay = this.delayCopy;
                    this.Blink(this.internalTime.ToString());
                }
            }
        }

        #endregion timersElapsed

        //InputNeuron's events & methods:
        #region EventsMethods

        public void LaunchInput()
        {
            this.clock.Start();
        }

        public void initialize(int delay)
        {
            this.delay = delay;
            this.delayCopy = delay;
        }
        public void setNextDelay(int nextDelay)
        {
            this.delayCopy = nextDelay;
        }
        public void resetInternalTime()
        {
            this.internalTime = 0;
        }
        private void Blink(string secondsInterval)
        {
            if (this.mainForm.InvokeRequired)
            {
                //Setup the cross-thread call
                BlinkDelegate del = new BlinkDelegate(Blink); //delegate
                object[] parameters = { secondsInterval }; //parameters
                this.mainForm.Invoke(del, parameters); //call
            }
            else
            {
                //Already cross-threading, do the actions
                InputNeuronArgs inNargs = new InputNeuronArgs(secondsInterval);
                this.history.Add(this.mainForm.globalVariablesOfMainForm.time);
                Fire(this, inNargs);
            }
        }
        public void stopNeuron()
        {
            this.clock.Stop();
        }

        #endregion EventsMethods

        public void setClearHistoryEvery(int value)
        {
            this.clearHistoryEvery = value;
        }
        public void resetHistory()
        {
            this.history.Clear();
        }
        public void changeInterval(int timeI)
        {
            this.clock.Interval = timeI;
        }
    }
}
