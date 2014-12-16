using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Threading;
using System.IO;
using ZedGraph;
using SNN.OtherForms.MDIforms;
using SNN.StructureElements;
using SNN.OtherForms.Simulation;
//using ZedGraph;
//using MethodsLibrary;

namespace SNN.Globals
{
    public class Variables
    {
        public WorkSpace workSpaceMDIchild; //variable to refer to workspace MDI child window
        public PotentialGraph potentialGraphMDIchild; //variable to refer to membrane potential MDI child form
        /* Network structure and neuron variables */
        #region NeuronStructure
            //number of neurons in particular Layers
            public int numberInput;
            public int numberLayer1;
            public int numberLayer2;// UNUSED
            public int numberOutput;
            //graphical representation

            public List<PictureBox> inputNeurons;
            public List<PictureBox> layer1;
            public List<PictureBox> layer2; //UNUSED
            public List<PictureBox> output;
            //number labels over neurons
            public List<System.Windows.Forms.Label> inputLbl;
            public List<System.Windows.Forms.Label> layer1Lbl;
            public List<System.Windows.Forms.Label> layer2Lbl; //UNUSED
            public List<System.Windows.Forms.Label> outputLbl;
            //synapses
            public Synapse[,] synapsesInLay1;
            public Synapse[,] synapsesLay1Out;
            public Synapse[,] synapsesLayToLay;// if 2 layer(UNUSED)

            public List<PictureBox> neuronsToMove = new List<PictureBox>();
            public List<System.Windows.Forms.Label> labelsToMove = new List<System.Windows.Forms.Label>();
        #endregion NeuronStructure

        #region NeuronThreads

            public Thread[] inputThreads;
            public Thread[] layer1Threads;
            public Thread[] layer2Threads; //UNUSED
            public Thread[] outputThreads;

            public Thread[,] threadsInLay1Synapses;
            public Thread[,] threadsLay1OutSynapses;
            public Thread[,] threadsLay1Lay2Synapses; //UNUSED
        #endregion NeuronThreads

            public int timeScale; //time to scale simulation timers and entire simulation process
            public Boolean suspended;
            public long time;

            public PictureBox clickedNeuron = new PictureBox();
            public bool PSPmode;
       #region LearningParameters

            public bool isLearning;
            public double tauD, tauP, Aparameter;
            public double maxWeightL, minWeightL;
            public string outputFileName;
       #endregion LearningParameters


            public int fileStimuliPresentation; // a variable indicating time period for presentation of new stimulus durring simulation from file
            public StreamReader stimuliFileReader; // file reader
            public int stimuliPerEpoch;             //numer of stimulus per singe Epoch
            public string lineBuf;                  //line read from file
            public bool languageChange;             //to toogle control if user has change application language

            /* Detail window variables */
            #region DetailWindow

                public TextBox[] detailBox;
                public int howManyDetailBoxes;
                public GroupBox[] groupBoxes;
                public int howManyGroupBoxes;

                public Microsoft.VisualBasic.PowerPacks.LineShape[] shortlines;
                public Microsoft.VisualBasic.PowerPacks.LineShape[] longLines;
                public List<System.Drawing.Color> colorsList = new List<System.Drawing.Color>();

            #endregion DetailWindow
                /* variables for simulationInOut window */
                #region simulationInOutControls
                public TextBox[] simInputBoxes;
                public TextBox[] simOutputBoxes;
                public System.Windows.Forms.Label[] simInputLabels;
                public System.Windows.Forms.Label[] sinOutputLabels;

                public PictureBox[,] codedCharacter;
                #endregion simulationInOutControls
                /*  end of variables for simulationInOut window */  
                public string lineOutput;
                public List<string> outputLines = new List<string>();
                public int epochCounter;

                public PointPairList rateList = new PointPairList(); //list for spikes fire rating
                public double maxHist;          //maximum value on X axis while plotting spikes
                public double sum;
                public double lowestSum;
                public List<double> changeSum = new List<double>();
                public int graphScale;

        public Variables()
        {
            this.languageChange = false;
            this.numberInput = 0;
            this.numberLayer1 = 0;
            this.numberLayer2 = 0;
            this.numberOutput = 0;
            this.sum = 0;
            this.inputLbl = new List<System.Windows.Forms.Label>();
            this.layer1Lbl = new List<System.Windows.Forms.Label>();
            this.layer2Lbl = new List<System.Windows.Forms.Label>();            
            this.outputLbl = new List<System.Windows.Forms.Label>();
            this.graphScale = 0;
            this.inputNeurons = new List<PictureBox>();
            this.layer1 = new List<PictureBox>();
            this.layer2 = new List<PictureBox>();
            this.output = new List<PictureBox>();
            this.timeScale = 2;
            this.howManyDetailBoxes = 0;
            this.howManyGroupBoxes = 0;
            this.epochCounter = 0;
            this.colorsList = MethodsLibrary.Methods.GetColors();
        }


    }
}
