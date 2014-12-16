using System;
using System.Collections.Generic;
using System.Text;

namespace SNN.Globals
{
    public class Flags
    {

        private int applicationMode; // Application mode flag, 0 = Spiking NN, 1 = Artificial NN
        private int languageIndex; //for easy language change; 0 equals to English, 1 Equals to Polish, 2 equals to Spanish

        private bool erasingNeurons;   //flag to inform if designer is in erasing mode
        private bool addingNewNeuron;  //flag to inform environment if "add new neuron" tool has been chosen
        private bool arrowTool;
        private int whichLayerNeuron;   //flag to inform neuron of which layer has been clicked 0 = input, 1 = lay1, 2 = output

        private int neuronMove;        //if neuron has been clicked
        private int memX;              //mouse pointer X coordinate while clicking on neuron
        private int memY;              //mouse pointer Y coordinate while clicking on neuron

        private int memXrectangle;     //mouse pointer X coordinate to make a rectangle while "catching" few neurons
        private int memYrectangle;     //mouse pointer Y coordinate to make a rectangle while "catching" few neurons
        private bool neuronRightClick; //if neuron is clicked by mouse right button
        private int memWorkSpaceMouseX; //used to remember mouse position on WorkSpace
        private int memWorkSpaceMouseY; //used to remember mouse position on WorkSpace
        #region projectManagementFlags
            private bool projectNotSaved; //flag to notify if project has changed but changes has not been saved
            private bool oneWorkSpaceOnly; //flag to prevent application from creating more than 1 workspace MDIchild form | if == true workSpace has already been created
            private bool layer2net;         //for loading structure
        #endregion projectManagementFlags

        #region DesignFlags

        private int panelWindowMove;  //used when user moves toolboxes
            private int memXwindow;       //used to remember X coordinate of mouse pointer while clicking on panel header
            private int memYwindow;       //used to remember Y coordinate of mouse pointer while clicking on panel header

            private int memXEditor;       //memorizing Structure Editor X coordinate
            private int memYEditor;       //memorizing Structure Editor Y coordinate

            private int memXDetail;       //memorizing Detail Window X coordinate
            private int memYDetail;       //memorizing Detail Window Y coordinate

            private int memXSimulation;       //memorizing Simulation Widnow X coordinate
            private int memYSimulation;       //memorizing Simulation Window Y coordinate

            private int memXInitialization;       //memorizing Sim Initialization X coordinate
            private int memYInitialization;       //memorizing Sim Initialization Y coordinate
            private int simulationPathStep; //describes on which step Simulation process currently stays
            private Boolean detailWindow;
            private int detailsWindowDock;//used to specify if detailsWindow is docked or not(or where) 0 when docked to right top

        #endregion DesignFlags

        #region SimulationFlags
            private bool isSimulated;      //true means that simulation is in progress
            private Boolean initializedSim;//notify if simulation has been initialized or not
            private int simulationMode;    //holds information about chosen simulation mode; 0 = manual, 1 = test, 2 = file
            private int outputInRun;       //how many ouput neurons are still running (used for step by step simulation)
        #endregion SimulationFlags

        

        public Flags()
        {
            this.applicationModeFlag = 0;
            this.panelWindowMoveFlag = 0;
            this.languageIndexVar = 0;
            this.oneWorkSpaceOnly = false;
            
            this.memXEditorFlag = 0;
            this.memYEditorFlag = 52;

            this.erasingNeuronsFlag = false;
            this.addingNewNeuronFlag = false;

            this.initializedSimFlag = false;
            this.neuronMoveFlag = 0;
            this.detailWindowFlag = false;
            this.layer2netFlag = false;
            this.projectNotSavedFlag = true;
            this.arrowToolFlag = true;
            this.detailsWindowDock = 0;
        }

        public Boolean initializedSimFlag
        {
            get { return this.initializedSim; }
            set { this.initializedSim = value; }
        }

        public int languageIndexVar
        {
            get { return this.languageIndex; }
            set { this.languageIndex = value; }
        }

        public int applicationModeFlag
        {
            get { return this.applicationMode; }
            set { this.applicationMode = value; }
        }
        //project management flags:
        public Boolean OneWorkSpaceOnlyFlag
        {
            get { return this.oneWorkSpaceOnly; }
            set { this.oneWorkSpaceOnly = value; }
        }

        public Boolean projectNotSavedFlag
        {
            get { return this.projectNotSaved; }
            set { this.projectNotSaved = value; }
        }

        #region DesignFlagsSetters

        public int panelWindowMoveFlag
        {
            get { return this.panelWindowMove; }
            set { this.panelWindowMove = value; }
        }


        public int memXwindowFlag
        {
            get { return this.memXwindow; }
            set { this.memXwindow = value; }
        }
        public int memYwindowFlag
        {
            get { return this.memYwindow; }
            set { this.memYwindow = value; }
        }

        public int memXEditorFlag
        {
            get { return this.memXEditor; }
            set { this.memXEditor = value; }
        }
        public int memYEditorFlag
        {
            get { return this.memYEditor; }
            set { this.memYEditor = value; }
        }

        public int memXDetailFlag
        {
            get { return this.memXDetail; }
            set { this.memXDetail = value; }
        }
        public int memYDetailFlag
        {
            get { return this.memYDetail; }
            set { this.memYDetail = value; }
        }

        public int memXSimulationFlag
        {
            get { return this.memXSimulation; }
            set { this.memXSimulation = value; }
        }
        public int memYSimulationFlag
        {
            get { return this.memYSimulation; }
            set { this.memYSimulation = value; }
        }

        public int memXInitializationFlag
        {
            get { return this.memXInitialization; }
            set { this.memXInitialization = value; }
        }
        public int memYInitializationFlag
        {
            get { return this.memYInitialization; }
            set { this.memYInitialization = value; }
        }

        #endregion DesignFlagsSetters

        public Boolean arrowToolFlag
        {
            get { return this.arrowTool; }
            set { this.arrowTool = value; }
        }

        public Boolean erasingNeuronsFlag
        {
            get { return this.erasingNeurons; }
            set { this.erasingNeurons = value; }
        }
        public Boolean addingNewNeuronFlag
        {
            get { return this.addingNewNeuron; }
            set { this.addingNewNeuron = value; }
        }

        public Boolean neuronRightClickFlag
        {
            get { return this.neuronRightClick; }
            set { this.neuronRightClick = value; }
        }
        public int neuronMoveFlag
        {
            get { return this.neuronMove; }
            set { this.neuronMove = value; }
        }
        public int memXFlag
        {
            get { return this.memX; }
            set { this.memX = value; }
        }
        public int memYFlag
        {
            get { return this.memY; }
            set { this.memY = value; }
        }
        public int memXRectangleFlag
        {
            get { return this.memXrectangle; }
            set { this.memXrectangle = value; }
        }
        public int whichLayerNeuronFlag
        {
            get { return this.whichLayerNeuron; }
            set { this.whichLayerNeuron = value; }
        }
        public int memYRectangleFlag
        {
            get { return this.memYrectangle; }
            set { this.memYrectangle = value; }
        }
        public int memWorkSpaceMouseXFlag
        {
            get { return this.memWorkSpaceMouseX; }
            set { this.memWorkSpaceMouseX = value; }
        }
        public int memWorkSpaceMouseYFlag
        {
            get { return this.memWorkSpaceMouseY; }
            set { this.memWorkSpaceMouseY = value; }
        }
        public Boolean layer2netFlag
        {
            get { return this.layer2net; }
            set { this.layer2net = value; }
        }
        public int simulationPathStepFlag
        {
            get { return this.simulationPathStep; }
            set { this.simulationPathStep = value; }
        }
        public Boolean detailWindowFlag
        {
            get { return this.detailWindow; }
            set { this.detailWindow = value; }
        }
        public int detailsWindowDockFlag
        {
            get { return this.detailsWindowDock; }
            set { this.detailsWindowDock = value; }
        }
        public Boolean isSimulatedFlag
        {
            get { return this.isSimulated; }
            set { this.isSimulated = value; }
        }
        public int simulationModeFlag
        {
            get { return this.simulationMode; }
            set { this.simulationMode = value; }
        }
        public int outputIsRunFlag
        {
            get { return this.outputInRun; }
            set { this.outputInRun = value; }
        }
    }
}
