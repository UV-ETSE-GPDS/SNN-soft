using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SNN.StructureElements
{
    public class Synapse
    {
        #region EventsDeclarations

        public delegate void FiringHandler(object sender, SynapseArgs sa);
        public event FiringHandler SendSpike;
        private delegate void BlinkDelegate(string secondsInterval);

        #endregion EventsDeclarations

        #region SynapseFields
        private System.Timers.Timer clock = new System.Timers.Timer();
        private List<long> arrivingTime = new List<long>();
        private long internalTime;

        public int from; //conection form which neuron
        public int to;   //conection to which neuron
        private SNNmain mainForm; //reference to main form
        int delay;      //delay
        public List<long> inHistory = new List<long>();
        #endregion SynapseFields

        //constructor:
        public Synapse(int from, int to, SNNmain mainForm)
        {
            this.from = from;
            this.to = to;
            this.mainForm = mainForm;
            this.clock.Interval = 1;
            this.clock.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            this.internalTime = 0;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.mainForm.globalVariablesOfMainForm.suspended == true)
            {

            }
            else
            {
                this.internalTime++;
                if (this.arrivingTime.Count != 0)
                {
                    if (this.arrivingTime[0] + this.delay == this.internalTime)
                    {
                        this.arrivingTime.RemoveAt(0);
                        this.Blink(this.delay.ToString());
                    }
                }
            }
        }

        #region SynapseMethods

        public void runSynapse()
        {
            this.clock.Start();
        }
        public void stopSynapse()
        {
            this.clock.Stop();
        }
        public void resetSynapse()
        {
            this.internalTime = 0;
            this.arrivingTime.Clear();
        }
        public void sendThroughSynapse()
        {
            this.inHistory.Add(this.internalTime);
            this.arrivingTime.Add(this.internalTime);
        }

        public void setDelay(int delay)
        {
            this.delay = delay;
        }

        private void Blink(string secondsInterval)
        {
            if (this.mainForm.InvokeRequired)
            {
                //Setup the cross-thread call
                BlinkDelegate del = new BlinkDelegate(this.Blink); //delegate
                object[] parameters = { secondsInterval }; //parameters
                this.mainForm.Invoke(del, parameters); //call
            }
            else
            {
                //Already cross-threading, do the actions
                SynapseArgs sa = new SynapseArgs(secondsInterval);
                SendSpike(this, sa);
            }
        }

        #endregion SynapseMethods
    }
}
