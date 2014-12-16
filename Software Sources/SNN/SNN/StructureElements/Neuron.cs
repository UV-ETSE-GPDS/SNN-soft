using System;
using System.Collections.Generic;
using System.Text;
using ZedGraph;

namespace SNN.StructureElements
{
    public class Neuron
    {

        #region EventsDeclaration

        public delegate void FiringHandler(object sender, NeuronArgs na);
        public event FiringHandler Fire;
        private delegate void BlinkDelegate(string secondsInterval);

        #endregion EventsDeclaration

        #region NeuronFields

        System.Timers.Timer clock;          //clk ticking

        public int number;                 //neuron number
        public List<long> history = new List<long>(); //history of spikes (in milliseconds)

        public string layerName;           //name identifying neuron layer( "layer1", "output" future work: "layer2" )     

        SNNmain mainForm;                     //reference to form where structure is created

        public int[] inputs; // count how many spikes has been delivered to particular input
        public double[] weights; // weights for neuron's inputs
        public double[] learnedWeights; //best wegiths values memorized durring learning process
        public List<double[]> weightHistory = new List<double[]>();
        public int[] delays;     // ######################################## UNUSED?
        public double threshold; // neuron threshold

        private double innerWeight;  //internal weight currently processed spike
        private int memWhich; // memorize last input that came
        public int inputCount;     //how many input neuron has

        private int clearHistoryEvery;                  // for better efficiency history is being clear, if == 0 history is not clear
        private double delta;
        #endregion NeuronFields

        #region PotentialVariables

        private int internalDelay;  //##################### UNUSED?
        private double x;           // x coordinate
        private double y;           // y coordinate
        private double offsetOX;    // offset along OX axis 
        private double offsetOY;    // offset to remember potential position while new spike arrives

        public bool refractor;      // flag to notify when neuron enter into refractory period
        public bool PSPmode;        // if PSPs are real or ideal
        public double potential;    // neuron potential

        public ZedGraph.PointPairList potentialList;  // list used for ploting potential
        bool first;                                   // flag to notify when neuron fires a first spike ## consider removing
        public List<ZedGraph.PointPairList> chartsList;  // list of potentialLists used for ploting potential
        public List<List<int>> spikeToInputs = new List<List<int>>(); //dictionary to describe relation between spikes and inputs(which spike comes from which input)

        #endregion PotentialVariables

        public List<long> Inputhistory = new List<long>(); //history of spikes (in milliseconds)

        //contructor:
        public Neuron(int number, int howMany, string layerName, SNNmain mainForm)
        {
            this.number = number;
            this.layerName = layerName;

            this.mainForm = mainForm;

            this.clock = new System.Timers.Timer();
            this.clock.Interval = 2;
            this.clock.Elapsed += new System.Timers.ElapsedEventHandler(clock_Elapsed);

            this.delays = new int[howMany];
            this.weights = new double[howMany];
            this.learnedWeights = new double[howMany];
            this.inputs = new int[howMany];
            this.inputCount = howMany;

            this.x = 0;
            this.y = 0;
            this.refractor = false;

            this.potentialList = new PointPairList();
            this.chartsList = new List<PointPairList>();
            this.clearHistoryEvery = 0;
            for (int i = 0; i < howMany; i++)
                spikeToInputs.Add(new List<int>());
            this.offsetOX = 0;
            this.offsetOY = 0;
            this.potential = 0;

        }

        #region timersElapsed

        void clock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (mainForm.globalVariablesOfMainForm.suspended == true)
            {

            }
            else
            {
                this.calculatePotential();
            }
        }

        #endregion timersElapsed

        #region EventMethods

        public void LaunchNeuron()
        {
            this.x = 0;
            this.y = 0;
            this.innerWeight = 0;
            this.first = true;
            this.clock.Start();
        }
        public void identifySpike(object sender, SynapseArgs sa)
        {
            //lock (this)
            {
                if (this.refractor == false)
                {
                    Synapse synapse = (Synapse)sender;
                    this.Inputhistory.Add(this.mainForm.globalVariablesOfMainForm.time);
                    this.innerWeight = this.weights[synapse.from];

                    this.inputs[synapse.from]++;
                    this.offsetOY = this.potential;
                    this.offsetOX = this.offsetOX + this.x;
                    this.offsetOY = this.potential;

                    this.x = 0;
                    this.first = false;
                    this.memWhich = synapse.from;
                }
                if (this.first == false)
                {
                    if (this.potentialList.Count != 0)
                    {
                        this.chartsList.Add(this.potentialList);
                        this.spikeToInputs[this.memWhich].Add(this.chartsList.Count - 1);
                    }
                    try
                    {
                        //  this.offsetOX = this.chartsList[this.chartsList.Count - 1][this.potentialList.Count - 1].X;
                    }
                    catch (Exception e)
                    {
                        // this.output = 0; 
                    }
                }
                this.potentialList = new ZedGraph.PointPairList();

            }
        }
        private void calculatePotential()
        {
            if (this.refractor == false) //normalne rysowanie
            {
                if (this.x >= 15) //sciąga wykres do zera
                {
                    y = 0;// this.threshold * (Math.Exp(-this.x / 3)); //?=0
                    this.offsetOY = 0;
                }
                else
                {
                    if (this.PSPmode == false) //okragly PSP
                    {
                        this.y = this.innerWeight * (Math.Exp(-this.x / 4) - Math.Exp(-this.x / 2));
                        if (this.y < (-1 * this.threshold))
                        {
                            this.y = this.threshold;
                        }
                    }
                    else  //prosty PSP
                    {
                        if ((this.x <= 0.4))
                            this.y = this.innerWeight * (this.x / 6);
                        else
                            this.y = this.innerWeight * ((-x + 23) / 80);
                        if (this.y < (-1 * this.threshold))
                        {
                            this.y = this.threshold;
                        }
                    }
                }
            }
            else
            {
                this.y = -this.threshold * (Math.Exp(-this.x / 3));
                if (this.y >= -0.001)
                {
                    this.refractor = false;
                }
            }

            this.potential = this.y + this.offsetOY;
            this.offsetOX = this.x + this.offsetOX;

            this.potentialList.Add(this.mainForm.globalVariablesOfMainForm.time/* + this.x*/, this.potential);

            if (this.potential >= this.threshold)
            {
                this.offsetOY = 0;
                this.potentialList.Add(this.mainForm.globalVariablesOfMainForm.time/* + this.x*/, 4);

                this.x = this.x + 0.1;
                this.offsetOX = this.x + this.offsetOX;
                this.potentialList.Add(this.mainForm.globalVariablesOfMainForm.time/* + this.x*/, this.potential);


                this.refractor = true;

                this.y = -this.threshold * (Math.Exp(-this.x / 3));
                this.Blink(this.y.ToString());
                this.potential = 0;
            }
            this.x = this.x + 0.1;
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
                NeuronArgs na = new NeuronArgs(secondsInterval);
                this.history.Add(this.mainForm.globalVariablesOfMainForm.time);
                Fire(this, na);
            }
        }
        public void setClearHistoryEvery(int value)
        {
            this.clearHistoryEvery = value;
        }
        public void stopNeuron()
        {
            this.clock.Stop();
        }
        public void resumeNeuron()
        {
            this.clock.Start();
        }
        public void changeInterval(int timeI)
        {
            this.clock.Interval = timeI;
        }
        public void resetPotential()
        {
            this.chartsList.Clear();
            this.potentialList.Clear();
            this.potential = 0;
            this.offsetOX = 0;
            this.offsetOY = 0;
            this.refractor = false;
            this.history.Clear();
            this.x = 0;
            this.y = 0;
        }
        #endregion EventMethods
        
    }
}
