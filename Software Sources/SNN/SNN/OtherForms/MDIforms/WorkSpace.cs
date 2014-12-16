using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SNN.StructureElements;
using SNN.Globals;
using SNN.LanguagePack;
using SNN.Logic;

namespace SNN.OtherForms.MDIforms
{
    public partial class WorkSpace : Form
    {
        Variables glob = new Variables();
        Flags flags = new Flags();
        Messages appMessages = new Messages();
        Methods methods;
        
        SNNmain mainForm = new SNNmain();

        public WorkSpace()
        {
            InitializeComponent();
        }
        public WorkSpace(Flags _flags, Variables _globalVariables, SNNmain _snnMainForm)
        {
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            InitializeComponent();
            this.flags = _flags;
            this.glob = _globalVariables;
            this.mainForm = _snnMainForm;

            this.methods = new Methods(this.glob, this.flags, this.mainForm);

        }

        private void WorkSpace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.flags.projectNotSavedFlag == false) //if not saved
            {//show box if save project
                DialogResult dialogResult = MessageBox.Show(this.appMessages.projectNotSavedNotification[this.flags.languageIndexVar], this.appMessages.projectNotSavedNotificationTitle[this.flags.languageIndexVar], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    this.mainForm.saveStruct();
                    this.flags.projectNotSavedFlag = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.flags.projectNotSavedFlag = true;
                }
            }
            else //if project is saved just close the workspace
            {

            }
            this.methods.disposeNeurons();
            this.mainForm.menuStripGenerateVHDLEnable = false;
        }

        private void WorkSpace_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.methods.disposeNeurons();
            this.flags.OneWorkSpaceOnlyFlag = false;
            this.mainForm.designEditorVisibility = false;
            this.mainForm.detailsWindowVisibility = false;
            this.mainForm.simInOutWindowVisibility = false;
            this.mainForm.simulationWindowVisibility = false;

            this.mainForm.menuStripDesignEditorToolBoxChecked = false;
            this.mainForm.menuStripInitializationChecked = false;
            this.mainForm.menuStripWindowWorkspaceChecked = false;
            this.mainForm.menuStripWindowSimulationChecked = false;
            this.mainForm.menuStripWindowDetailsChecked = false;
            this.mainForm.closingWorkspaceMenuEnabling();

            this.glob.workSpaceMDIchild.Dispose();
        }

        private void WorkSpace_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                MouseEventArgs events = (MouseEventArgs)e;
                flags.memXFlag = events.X;
                flags.memYFlag = events.Y;
                if (this.flags.addingNewNeuronFlag == true)
                {

                    this.contextAddNeuron.Items.Clear();
                    if (this.flags.applicationModeFlag == 0)
                    {//add spiking neuron 
                        this.populateContextAddNeuron(0);
                        this.contextAddNeuron.Tag = e.X.ToString() + "." + e.Y.ToString();
                        this.contextAddNeuron.Show(e.X, e.Y);
                    }
                    else if (this.flags.applicationModeFlag == 1)
                    {//add normal neuron
                        this.populateContextAddNeuron(1);
                        this.contextAddNeuron.Tag = e.X.ToString() + "." + (e.Y + 50).ToString();
                        this.contextAddNeuron.Show(e.X, e.Y + 50);
                    }
                }
                else if (flags.erasingNeuronsFlag == false)
                    {
                        methods.uncheckNeurons();
                        flags.neuronMoveFlag = 2;
                    }
                
            }
            if (e.Button == MouseButtons.Right)
            {
                if (this.flags.addingNewNeuronFlag == true)
                {
                    this.contextAddNeuron.Hide();
                }
            }
            this.methods.drawSynapses();
        }
        
        private void populateContextAddNeuron(int flag)
        { //if flag == 0 spiking, if flag == 1 artificial
            if (flag == 0)
            {
                ToolStripMenuItem addInputBtn = new ToolStripMenuItem();
                ToolStripMenuItem addLayer1Btn = new ToolStripMenuItem();
                ToolStripMenuItem addOutputBtn = new ToolStripMenuItem();   
                switch (Properties.Settings.Default.applicationLanguage)
                { 
                    case 0:
                        addInputBtn.Text = "Add Input Neuron";
                        addLayer1Btn.Text = "Add Layer 1 Neuron";
                        addOutputBtn.Text = "Add Output Neuron";
                        break;
                    case 1:
                        addInputBtn.Text = "Dodaj Neuron Wejściowy";
                        addLayer1Btn.Text = "Dodaj Neuron Warstwy 1";
                        addOutputBtn.Text = "Dodaj Neuron Wyjściowy";
                        break;
                    case 2:
                        addInputBtn.Text = "Ańadir Entrada Neuron";
                        addLayer1Btn.Text = "Ańadir Capa 1 Neuron";
                        addOutputBtn.Text = "Ańadir Salida Neuron";
                        break;
                }
                
                addInputBtn.RightToLeft = RightToLeft.Yes;
                addInputBtn.Click += new EventHandler(addInputBtn_Click);
                this.contextAddNeuron.Items.Add(addInputBtn);

                             
                addLayer1Btn.RightToLeft = RightToLeft.Yes;
                addLayer1Btn.Click += new EventHandler(addLayer1Btn_Click);
                this.contextAddNeuron.Items.Add(addLayer1Btn);

             
                addOutputBtn.RightToLeft = RightToLeft.Yes;
                addOutputBtn.Click += new EventHandler(addOutputBtn_Click);
                this.contextAddNeuron.Items.Add(addOutputBtn);

            }
            else if (flag == 1)
            {
                ToolStripMenuItem addInputBtn = new ToolStripMenuItem();
                ToolStripMenuItem addLayer1Btn = new ToolStripMenuItem();
                ToolStripMenuItem addLayer2Btn = new ToolStripMenuItem();
                ToolStripMenuItem addOutputBtn = new ToolStripMenuItem();
                switch (Properties.Settings.Default.applicationLanguage)
                {
                    case 0:
                        addInputBtn.Text = "Add Input Neuron";
                        addLayer1Btn.Text = "Add Layer 1 Neuron";
                        addLayer2Btn.Text = "Add Layer 2 Neuron";
                        addOutputBtn.Text = "Add Output Neuron";
                        break;
                    case 1:
                        addInputBtn.Text = "Dodaj Neuron Wejściowy";
                        addLayer1Btn.Text = "Dodaj Neuron Warstwy 1";
                        addLayer1Btn.Text = "Dodaj Neuron Warstwy 2";
                        addOutputBtn.Text = "Dodaj Neuron Wyjściowy";
                        break;
                    case 2:
                        addInputBtn.Text = "Ańadir Entrada Neuron";
                        addLayer1Btn.Text = "Ańadir Capa 1 Neuron";
                        addLayer1Btn.Text = "Ańadir Capa 2 Neuron";
                        addOutputBtn.Text = "Ańadir Salida Neuron";
                        break;
                }
                addInputBtn.RightToLeft = RightToLeft.Yes;
                addInputBtn.Click += new EventHandler(addInputBtn_Click);
                this.contextAddNeuron.Items.Add(addInputBtn);


                addLayer1Btn.RightToLeft = RightToLeft.Yes;
                addLayer1Btn.Click += new EventHandler(addLayer1Btn_Click);
                this.contextAddNeuron.Items.Add(addLayer1Btn);
                if (this.mainForm.radioLayer2checked == true)
                {
                    addLayer2Btn.RightToLeft = RightToLeft.Yes;
                    addLayer2Btn.Click += new EventHandler(addLayer2Btn_Click);
                    this.contextAddNeuron.Items.Add(addLayer2Btn);
                }
                addOutputBtn.RightToLeft = RightToLeft.Yes;
                addOutputBtn.Click += new EventHandler(addOutputBtn_Click);
                this.contextAddNeuron.Items.Add(addOutputBtn);
            }
        }
        void addInputBtn_Click(object sender, EventArgs e)
        {
            int X, Y;
            string[] coords = ((string)this.contextAddNeuron.Tag).Split('.');
            X = Convert.ToInt32(coords[0]);
            Y = Convert.ToInt32(coords[1]);
            this.methods.createInputNeuron(X, Y);
            this.methods.drawSynapses();
        }
        void addLayer1Btn_Click(object sender, EventArgs e)
        {
            int X, Y;
            string[] coords = ((string)this.contextAddNeuron.Tag).Split('.');
            X = Convert.ToInt32(coords[0]);
            Y = Convert.ToInt32(coords[1]);
            this.methods.createLayer1Neuron(X, Y);
            this.methods.drawSynapses();
        }
        void addLayer2Btn_Click(object sender, EventArgs e)
        {
            int X, Y;
            string[] coords = ((string)this.contextAddNeuron.Tag).Split('.');
            X = Convert.ToInt32(coords[0]);
            Y = Convert.ToInt32(coords[1]);
            this.methods.createLayer2ANN(X, Y);
            this.methods.drawSynapses();
        }
        void addOutputBtn_Click(object sender, EventArgs e)
        {
            int X, Y;
            string[] coords = ((string)this.contextAddNeuron.Tag).Split('.');
            X = Convert.ToInt32(coords[0]);
            Y = Convert.ToInt32(coords[1]);
            this.methods.createOutputNeuron(X, Y);
            this.methods.drawSynapses();
        }
        void addANNBtn_Click(object sender, EventArgs e)
        {
            this.methods.drawSynapses();
        }

        private void WorkSpace_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs events = (MouseEventArgs)e;
            if (flags.neuronMoveFlag == 2)
            {
                this.Refresh();
                System.Drawing.Graphics graphicsObj;
                graphicsObj = this.CreateGraphics();
                Pen myPen = new Pen(System.Drawing.Color.Black, 2);
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

                graphicsObj.DrawLine(myPen, flags.memXFlag, flags.memYFlag, flags.memXFlag, events.Y);
                graphicsObj.DrawLine(myPen, flags.memXFlag, flags.memYFlag, events.X, flags.memYFlag);
                graphicsObj.DrawLine(myPen, flags.memXFlag, events.Y, events.X, events.Y);
                graphicsObj.DrawLine(myPen, events.X, flags.memYFlag, events.X, events.Y);
                this.methods.drawSynapses();
            }
            else
            { //used to remember mouse position for context menu while clicking on neuron
                this.flags.memWorkSpaceMouseXFlag = events.X;
                this.flags.memWorkSpaceMouseYFlag = events.Y;
            }
        }

        private void WorkSpace_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs events = (MouseEventArgs)e;
            this.Refresh();
            if (flags.addingNewNeuronFlag == true)
            {
               // flags.addingNewNeuronFlag = false;
               // this.contextAddNeuron.Show();
               // this.methods.drawSynapses();
            }
            else
            {
                if ((flags.neuronMoveFlag == 2))
                {
                    flags.memXRectangleFlag = events.X;
                    flags.memYRectangleFlag = events.Y;
                    flags.neuronMoveFlag = 3;
                    this.methods.catchNeurons();
                }
            }
            this.methods.drawSynapses();
        }
        public Image getNeuronImage(bool whichImage)
        {
            if (whichImage == true)
                return this.BigNeuronShape.Image;
            else
                return this.BigNeuronShape.ErrorImage;
        }
        public Image getCheckedNeuronImage(bool whichImage)
        {
            if (whichImage == true)
                return this.neuronChecked.Image;
            else
                return this.neuronChecked.ErrorImage;
        }

        private void WorkSpace_Leave(object sender, EventArgs e)
        {
            this.methods.drawSynapses();
        }

        public void contextNeuronDetailsBlindingInput(InputNeuron inNeuron)
        {
            this.contextNeuronDetails.Items.Clear();
            ToolStripMenuItem title = new ToolStripMenuItem();
            title.Text = (inNeuron.number + 1).ToString() + " ( " + inNeuron.layerName + " ) Neuron details:";
            title.Enabled = false;
            title.RightToLeft = RightToLeft.No;
            this.contextNeuronDetails.Items.Add(title);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());
            ToolStripTextBox tb = new ToolStripTextBox();
            tb.Text = inNeuron.delayCopy.ToString();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    tb.ToolTipText = "Neuron Delay";
                    break;
                case 1:
                    tb.ToolTipText = "Opóźnienia";
                    break;
                case 2:
                    tb.ToolTipText = "Demoras de Neurona";
                    break;
            }

            this.contextNeuronDetails.Items.Add(tb);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem addBtn = new ToolStripMenuItem();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    addBtn.Text = "Update";
                    break;
                case 1:
                    addBtn.Text = "Zapisz";
                    break;
                case 2:
                    addBtn.Text = "Actualizar";
                    break;
            }

            addBtn.Tag = inNeuron;
            addBtn.RightToLeft = RightToLeft.Yes;
            addBtn.Click += new EventHandler(addBtnInput_Click);
            this.contextNeuronDetails.Items.Add(addBtn);

        }
        public void contextNeuronDetailsBlindingInputANN(ANNinput inNeuron)
        {
            this.contextNeuronDetails.Items.Clear();
            ToolStripMenuItem title = new ToolStripMenuItem();
            title.Text = (inNeuron.nNumber + 1).ToString() + " ( " + inNeuron.gLayer + " ) Neuron details:";
            title.Enabled = false;
            title.RightToLeft = RightToLeft.No;
            this.contextNeuronDetails.Items.Add(title);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());
            ToolStripTextBox tb = new ToolStripTextBox();
            tb.Text = inNeuron.nValue.ToString();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    tb.ToolTipText = "Neuron Delay";
                    break;
                case 1:
                    tb.ToolTipText = "Opóźnienia";
                    break;
                case 2:
                    tb.ToolTipText = "Demoras de Neurona";
                    break;
            }

            this.contextNeuronDetails.Items.Add(tb);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem addBtn = new ToolStripMenuItem();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    addBtn.Text = "Update";
                    break;
                case 1:
                    addBtn.Text = "Zapisz";
                    break;
                case 2:
                    addBtn.Text = "Actualizar";
                    break;
            }

            addBtn.Tag = inNeuron;
            addBtn.RightToLeft = RightToLeft.Yes;
            addBtn.Click += new EventHandler(addBtnAnnInput_Click);
            this.contextNeuronDetails.Items.Add(addBtn);
        }
        void addBtnAnnInput_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem addBtn = (ToolStripMenuItem)sender;
            ANNinput inNeuron = (ANNinput)addBtn.Tag;
            inNeuron.nValue = Convert.ToInt32(this.contextNeuronDetails.Items[2].Text);
            this.contextNeuronDetails.Hide();
            this.methods.drawSynapses();
        }
        void addBtnInput_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem addBtn = (ToolStripMenuItem)sender;
            InputNeuron inNeuron = (InputNeuron)addBtn.Tag;
            inNeuron.initialize(Convert.ToInt32(this.contextNeuronDetails.Items[2].Text));
            this.contextNeuronDetails.Hide();
            this.methods.drawSynapses();
        }
        //
        public void contextNeuronDetailsBlindingLayer1(Neuron inNeuron)
        {
            this.contextNeuronDetails.Items.Clear();
            ToolStripMenuItem title = new ToolStripMenuItem();
            title.Text = (inNeuron.number + 1).ToString() + " ( " + inNeuron.layerName + " ) Neuron details:";
            title.Enabled = false;
            title.RightToLeft = RightToLeft.No;
            this.contextNeuronDetails.Items.Add(title);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem delays = new ToolStripMenuItem();

            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    delays.ToolTipText = "Neuron Delay";
                    break;
                case 1:
                    delays.ToolTipText = "Opóźnienia";
                    break;
                case 2:
                    delays.ToolTipText = "Demoras de Neurona";
                    break;
            }
            delays.RightToLeft = RightToLeft.No;

            for (int i = 0; i < inNeuron.inputCount; i++)
            {
                ToolStripTextBox tbDelay = new ToolStripTextBox();
                tbDelay.Text = inNeuron.delays[i].ToString();
                switch (Properties.Settings.Default.applicationLanguage)
                {
                    case 0:
                        tbDelay.ToolTipText = "Input " + (i + 1).ToString() + " delay";
                        break;
                    case 1:
                        tbDelay.ToolTipText = "Opóźnienie wejsćia " + (i + 1).ToString();
                        break;
                    case 2:
                        tbDelay.ToolTipText = "Demora de entrada " + (i + 1).ToString();
                        break;
                }

                delays.DropDownItems.Add(tbDelay);
            }
            this.contextNeuronDetails.Items.Add(delays);

            ToolStripMenuItem weights = new ToolStripMenuItem();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    weights.Text = "Weights";
                    break;
                case 1:
                    weights.Text = "Wagi";
                    break;
                case 2:
                    weights.Text = "Pesos";
                    break;
            }

            weights.RightToLeft = RightToLeft.No;

            for (int i = 0; i < inNeuron.inputCount; i++)
            {
                ToolStripTextBox tbWeight = new ToolStripTextBox();
                tbWeight.Text = inNeuron.weights[i].ToString();
                switch (Properties.Settings.Default.applicationLanguage)
                {
                    case 0:
                        tbWeight.ToolTipText = "Input " + (i + 1).ToString() + " weight";
                        break;
                    case 1:
                        tbWeight.ToolTipText = "Waga wejścia " + (i + 1).ToString();
                        break;
                    case 2:
                        tbWeight.ToolTipText = "Peso de entrada " + (i + 1).ToString();
                        break;
                }

                weights.DropDownItems.Add(tbWeight);
            }
            this.contextNeuronDetails.Items.Add(weights);
            ToolStripTextBox tb = new ToolStripTextBox();
            tb.Text = inNeuron.threshold.ToString();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    tb.ToolTipText = "Neuron Threshold";
                    break;
                case 1:
                    tb.ToolTipText = "Próg";
                    break;
                case 2:
                    tb.ToolTipText = "Umbral";
                    break;
            }

            this.contextNeuronDetails.Items.Add(tb);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem addBtn = new ToolStripMenuItem();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    addBtn.Text = "Update";
                    break;
                case 1:
                    addBtn.Text = "Zapisz";
                    break;
                case 2:
                    addBtn.Text = "Update";
                    break;
            }
            addBtn.Tag = inNeuron;
            addBtn.RightToLeft = RightToLeft.Yes;
            addBtn.Click += new EventHandler(addBtnLayer1_Click);
            this.contextNeuronDetails.Items.Add(addBtn);

        }
        public void contextNeuronDetailsBlindingANNneuron(ANNneuron inNeuron)
        {
            this.contextNeuronDetails.Items.Clear();
            ToolStripMenuItem title = new ToolStripMenuItem();
            title.Text = (inNeuron.gNumber + 1).ToString() + " ( " + inNeuron.gLayer + " ) Neuron details:";
            title.Enabled = false;
            title.RightToLeft = RightToLeft.No;
            this.contextNeuronDetails.Items.Add(title);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem weights = new ToolStripMenuItem();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    weights.Text = "Weights";
                    break;
                case 1:
                    weights.Text = "Wagi";
                    break;
                case 2:
                    weights.Text = "Pesos";
                    break;
            }

            weights.RightToLeft = RightToLeft.No;

            for (int i = 0; i < inNeuron.numberInputs; i++)
            {
                ToolStripTextBox tbWeight = new ToolStripTextBox();
                tbWeight.Text = inNeuron.weights[i].ToString();
                switch (Properties.Settings.Default.applicationLanguage)
                {
                    case 0:
                        tbWeight.ToolTipText = "Input " + (i + 1).ToString() + " weight";
                        break;
                    case 1:
                        tbWeight.ToolTipText = "Waga wejścia " + (i + 1).ToString();
                        break;
                    case 2:
                        tbWeight.ToolTipText = "Peso de entrada " + (i + 1).ToString();
                        break;
                }

                weights.DropDownItems.Add(tbWeight);
            }
            this.contextNeuronDetails.Items.Add(weights);
            ToolStripTextBox tb = new ToolStripTextBox();
            tb.Text = inNeuron.changeBias.ToString();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    tb.ToolTipText = "Bias";
                    break;
                case 1:
                    tb.ToolTipText = "Bias";
                    break;
                case 2:
                    tb.ToolTipText = "Bias";
                    break;
            }

            this.contextNeuronDetails.Items.Add(tb);
            this.contextNeuronDetails.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem addBtn = new ToolStripMenuItem();
            switch (Properties.Settings.Default.applicationLanguage)
            {
                case 0:
                    addBtn.Text = "Update";
                    break;
                case 1:
                    addBtn.Text = "Zapisz";
                    break;
                case 2:
                    addBtn.Text = "Update";
                    break;
            }
            addBtn.Tag = inNeuron;
            addBtn.RightToLeft = RightToLeft.Yes;
            addBtn.Click += new EventHandler(addBtnANNneuron_Click);
            this.contextNeuronDetails.Items.Add(addBtn);

        }
        void addBtnLayer1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem addBtn = (ToolStripMenuItem)sender;
            Neuron inNeuron = (Neuron)addBtn.Tag;

            ToolStripMenuItem delays = (ToolStripMenuItem)this.contextNeuronDetails.Items[2];
            ToolStripMenuItem weights = (ToolStripMenuItem)this.contextNeuronDetails.Items[3];

            for (int i = 0; i < inNeuron.inputCount; i++) //save delays
            {
                inNeuron.delays[i] = Convert.ToInt32(delays.DropDownItems[i].Text);
                inNeuron.weights[i] = Convert.ToDouble(weights.DropDownItems[i].Text);
            }
            inNeuron.threshold = Convert.ToDouble(this.contextNeuronDetails.Items[4].Text);
            //this.methods.updateSynapseDelay(inNeuron.layerName, inNeuron.number);
            this.contextNeuronDetails.Hide();
            this.methods.drawSynapses();
        }
        void addBtnANNneuron_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem addBtn = (ToolStripMenuItem)sender;
            ANNneuron inNeuron = (ANNneuron)addBtn.Tag;

            ToolStripMenuItem weights = (ToolStripMenuItem)this.contextNeuronDetails.Items[2];

            for (int i = 0; i < inNeuron.numberInputs; i++) //save delays
            {
                inNeuron.weights[i] = Convert.ToDouble(weights.DropDownItems[i].Text);
            }
            inNeuron.changeBias = Convert.ToDouble(this.contextNeuronDetails.Items[3].Text);
            //this.methods.updateSynapseDelay(inNeuron.layerName, inNeuron.number);
            this.contextNeuronDetails.Hide();
            this.methods.drawSynapses();
        }
        public Point contextNeuronDetailsShow
        {
            set { this.contextNeuronDetails.Show(value.X, value.Y); }
        }
    }
}
