using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Threading;
using System.IO;
using Microsoft.VisualBasic.PowerPacks;
using SNN.Globals;
using SNN.StructureElements;
using SNN.Interaction;
using MethodsLibrary.IniFiles;

namespace SNN.Logic
{
    public class Methods
    {
        Flags flags = new Flags();
        Variables variables = new Variables();
        SNN.LanguagePack.Messages _appMessages = new SNN.LanguagePack.Messages();
        Interaction.Events neuronInteraction;
        SNNmain mainForm;
        //contructor
        public Methods(Variables globalVars, Flags globalFlags, SNNmain mainForm)
        {
            this.variables = globalVars;
            this.flags = globalFlags;
            this.mainForm = mainForm;
            this.neuronInteraction = new Events(this.variables, this.flags, mainForm, this);
        }

        public void createInputNeuron(int X, int Y)
        {
            
            PictureBox newNeuron = new PictureBox();
            System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();

            newNeuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
            newNeuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
            newNeuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
            newNeuron.MouseHover += new EventHandler(neuronMouseOver);
            newNeuron.MouseLeave += new EventHandler(neuronMouseOut);

            newNeuron.Cursor = Cursors.NoMove2D;
            newNeuron.Width = 22;
            newNeuron.Height = 22;
            newNeuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
            newNeuron.BackgroundImageLayout = ImageLayout.Stretch;
            //uwaga sprawdzam potem Location.X zeby okreslic co za neuron jest kliknięty
            if(X == 0 && Y == 0)
                newNeuron.Location = new Point(200, 40 + (this.variables.numberInput * 40) + 8);
            else
                newNeuron.Location = new Point(X, Y);
            if (this.flags.applicationModeFlag == 0)
            {
                InputNeuron neuro = new InputNeuron(this.variables.numberInput, 100, this.mainForm); //number, delay, main form
                neuro.Fire += new InputNeuron.FiringHandler(this.neuronInteraction.fireInput);

                newNeuron.Tag = neuro;

                newLabel.Cursor = Cursors.NoMove2D;
                if (X == 0 && Y == 0)
                    newLabel.Location = new Point(200 + (newNeuron.Width / 2) - 8, 40 + (this.variables.numberInput * 40) + 12);
                else
                    newLabel.Location = new Point(X + (newNeuron.Width / 2) - 9, Y + 5);
                newLabel.Tag = "input";
                newLabel.Text = (this.variables.numberInput + 1).ToString();
                newLabel.BackColor = Color.CornflowerBlue;
                newLabel.Size = new Size(17, 15);
                newLabel.Font = new Font("Microsoft Sans Serif", 6.5f);

                newLabel.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                newLabel.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                newLabel.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                newLabel.MouseHover += new EventHandler(neuronMouseOver);
                newLabel.MouseLeave += new EventHandler(neuronMouseOut);

                this.variables.inputNeurons.Add(newNeuron);
                this.variables.inputLbl.Add(newLabel);

                for (int i = 0; i < this.variables.numberLayer1; i++)
                {
                    double[] weightsTmp = new double[this.variables.numberInput + 1];
                    int[] delayTmp = new int[this.variables.numberInput + 1];
                    Neuron neuronn = ((Neuron)this.variables.layer1[i].Tag);
                    for (int j = 0; j < this.variables.numberInput; j++)
                    {
                        delayTmp[j] = neuronn.delays[j];
                        weightsTmp[j] = neuronn.weights[j];
                    }
                    delayTmp[this.variables.numberInput] = 0;
                    weightsTmp[this.variables.numberInput] = 0;

                    neuronn.weights = weightsTmp;
                    neuronn.delays = delayTmp;
                }
            }
            else
            {
                ANNinput neuro = new ANNinput(this.variables.numberInput, 0);
                newNeuron.Tag = neuro;

                newLabel.Cursor = Cursors.NoMove2D;
                if (X == 0 && Y == 0)
                    newLabel.Location = new Point(200 + (newNeuron.Width / 2) - 8, 40 + (this.variables.numberInput * 40) + 12);
                else
                    newLabel.Location = new Point(X + (newNeuron.Width / 2) - 9, Y + 5);
                newLabel.Tag = "input";
                newLabel.Text = (this.variables.numberInput + 1).ToString();
                newLabel.BackColor = Color.CornflowerBlue;
                newLabel.Size = new Size(17, 15);
                newLabel.Font = new Font("Microsoft Sans Serif", 6.5f);

                newLabel.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                newLabel.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                newLabel.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                newLabel.MouseHover += new EventHandler(neuronMouseOver);
                newLabel.MouseLeave += new EventHandler(neuronMouseOut);

                this.variables.inputNeurons.Add(newNeuron);
                this.variables.inputLbl.Add(newLabel);

                for (int i = 0; i < this.variables.numberLayer1; i++)
                {
                    double[] weightsTmp = new double[this.variables.numberInput + 1];
                    int[] delayTmp = new int[this.variables.numberInput + 1];
                    ANNneuron neuronn = ((ANNneuron)this.variables.layer1[i].Tag);
                    for (int j = 0; j < this.variables.numberInput; j++)
                    {
                        weightsTmp[j] = neuronn.weights[j];
                    }
                    weightsTmp[this.variables.numberInput] = 0;

                    neuronn.weights = weightsTmp;
                }

            }

            variables.workSpaceMDIchild.Controls.Add(newLabel);
            variables.workSpaceMDIchild.Controls.Add(newNeuron);

            this.variables.numberInput++;
            this.mainForm.boxInputText = this.variables.numberInput.ToString();
            this.flags.projectNotSavedFlag = false;
        }
        public void createLayer1Neuron(int X, int Y)
        {
            PictureBox newNeuron = new PictureBox();
            System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();

            newNeuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
            newNeuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
            newNeuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
            newNeuron.MouseHover += new EventHandler(neuronMouseOver);
            newNeuron.MouseLeave += new EventHandler(neuronMouseOut);

            newNeuron.Cursor = Cursors.NoMove2D;
            newNeuron.Width = 40;
            newNeuron.Height = 40;
            newNeuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
            newNeuron.BackgroundImageLayout = ImageLayout.Stretch;
            if (X == 0 && Y == 0)
                newNeuron.Location = new Point(350, 40 + (this.variables.numberLayer1 * 55) + 9);
            else
                newNeuron.Location = new Point(X, Y);
            if (this.flags.applicationModeFlag == 0)
            {
                Neuron neuro = new Neuron(this.variables.numberLayer1, variables.numberInput, "Layer 1", this.mainForm); //number, number of inputs, layer name, main form
                neuro.Fire += new Neuron.FiringHandler(this.neuronInteraction.fireLayer1);
                newNeuron.Tag = neuro;

                newLabel.Cursor = Cursors.NoMove2D;
                if (X == 0 && Y == 0)
                    newLabel.Location = new Point(350 + (newNeuron.Width / 2) - 8, 40 + (this.variables.numberLayer1 * 55) + 22);
                else
                    newLabel.Location = new Point(X + (newNeuron.Width / 2) - 10, Y + 13);
                newLabel.Tag = "Layer 1";
                newLabel.Text = (this.variables.numberLayer1 + 1).ToString();
                newLabel.BackColor = Color.CornflowerBlue;
                newLabel.Size = new Size(17, 15);
                newLabel.Font = new Font("Microsoft Sans Serif", 6.5f);
                newLabel.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                newLabel.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                newLabel.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                newLabel.MouseHover += new EventHandler(neuronMouseOver);
                newLabel.MouseLeave += new EventHandler(neuronMouseOut);

                for (int i = 0; i < this.variables.numberOutput; i++)
                {
                    double[] weightsTmp = new double[this.variables.numberLayer1 + 1];
                    int[] delayTmp = new int[this.variables.numberLayer1 + 1];
                    Neuron neuronn = ((Neuron)this.variables.output[i].Tag);
                    for (int j = 0; j < this.variables.numberLayer1; j++)
                    {
                        delayTmp[j] = neuronn.delays[j];
                        weightsTmp[j] = neuronn.weights[j];
                    }
                    delayTmp[this.variables.numberLayer1] = 0;
                    weightsTmp[this.variables.numberLayer1] = 0;

                    neuronn.weights = weightsTmp;
                    neuronn.delays = delayTmp;
                }
            }
            else
            {
                ANNneuron neuro = new ANNneuron(this.variables.numberLayer1, 0, this.variables.numberInput, "Layer 1");
                newNeuron.Tag = neuro;

                newLabel.Cursor = Cursors.NoMove2D;
                if (X == 0 && Y == 0)
                    newLabel.Location = new Point(350 + (newNeuron.Width / 2) - 8, 40 + (this.variables.numberLayer1 * 55) + 22);
                else
                    newLabel.Location = new Point(X + (newNeuron.Width / 2) - 10, Y + 13);
                newLabel.Tag = "Layer 1";
                newLabel.Text = (this.variables.numberLayer1 + 1).ToString();
                newLabel.BackColor = Color.CornflowerBlue;
                newLabel.Size = new Size(17, 15);
                newLabel.Font = new Font("Microsoft Sans Serif", 6.5f);
                newLabel.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                newLabel.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                newLabel.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                newLabel.MouseHover += new EventHandler(neuronMouseOver);
                newLabel.MouseLeave += new EventHandler(neuronMouseOut);
                if (this.variables.numberLayer2 != 0)
                {
                    for (int i = 0; i < this.variables.numberLayer2; i++)
                    {
                        double[] weightsTmp = new double[this.variables.numberLayer1 + 1];
                        int[] delayTmp = new int[this.variables.numberLayer1 + 1];
                        ANNneuron neuronn = ((ANNneuron)this.variables.layer2[i].Tag);
                        for (int j = 0; j < this.variables.numberLayer1; j++)
                        {
                            weightsTmp[j] = neuronn.weights[j];
                        }
                        weightsTmp[this.variables.numberLayer2] = 0;

                        neuronn.weights = weightsTmp;
                    }
                }
                else
                {
                    for (int i = 0; i < this.variables.numberOutput; i++)
                    {
                        double[] weightsTmp = new double[this.variables.numberLayer1 + 1];
                        int[] delayTmp = new int[this.variables.numberLayer1 + 1];
                        ANNneuron neuronn = ((ANNneuron)this.variables.output[i].Tag);
                        for (int j = 0; j < this.variables.numberLayer1; j++)
                        {
                            weightsTmp[j] = neuronn.weights[j];
                        }
                        weightsTmp[this.variables.numberLayer1] = 0;

                        neuronn.weights = weightsTmp;
                    }
                }
            }
            this.variables.layer1.Add(newNeuron);
            this.variables.layer1Lbl.Add(newLabel);

            variables.workSpaceMDIchild.Controls.Add(newLabel);
            variables.workSpaceMDIchild.Controls.Add(newNeuron);
            
            this.variables.numberLayer1++;
            this.mainForm.boxLayer1Text = this.variables.numberLayer1.ToString();
            this.flags.projectNotSavedFlag = false;
        }
        public void createLayer2ANN(int X, int Y)
        {
            PictureBox newNeuron = new PictureBox();
            System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();

            newNeuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
            newNeuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
            newNeuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
            newNeuron.MouseHover += new EventHandler(neuronMouseOver);
            newNeuron.MouseLeave += new EventHandler(neuronMouseOut);

            newNeuron.Cursor = Cursors.NoMove2D;
            newNeuron.Width = 40;
            newNeuron.Height = 40;
            newNeuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
            newNeuron.BackgroundImageLayout = ImageLayout.Stretch;
            if (X == 0 && Y == 0)
                newNeuron.Location = new Point(350, 40 + (this.variables.numberLayer1 * 55) + 9);
            else
                newNeuron.Location = new Point(X, Y);

                ANNneuron neuro = new ANNneuron(this.variables.numberLayer2, 0, this.variables.numberLayer1, "Layer 2");
                newNeuron.Tag = neuro;

                newLabel.Cursor = Cursors.NoMove2D;
                if (X == 0 && Y == 0)
                    newLabel.Location = new Point(350 + (newNeuron.Width / 2) - 8, 40 + (this.variables.numberLayer2 * 55) + 22);
                else
                    newLabel.Location = new Point(X + (newNeuron.Width / 2) - 10, Y + 13);
                newLabel.Tag = "Layer 1";
                newLabel.Text = (this.variables.numberLayer2 + 1).ToString();
                newLabel.BackColor = Color.CornflowerBlue;
                newLabel.Size = new Size(17, 15);
                newLabel.Font = new Font("Microsoft Sans Serif", 6.5f);
                newLabel.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                newLabel.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                newLabel.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                newLabel.MouseHover += new EventHandler(neuronMouseOver);
                newLabel.MouseLeave += new EventHandler(neuronMouseOut);

                    for (int i = 0; i < this.variables.numberOutput; i++)
                    {
                        double[] weightsTmp = new double[this.variables.numberLayer2 + 1];
                        int[] delayTmp = new int[this.variables.numberLayer2 + 1];
                        ANNneuron neuronn = ((ANNneuron)this.variables.output[i].Tag);
                        for (int j = 0; j < this.variables.numberLayer2; j++)
                        {
                            weightsTmp[j] = neuronn.weights[j];
                        }
                        weightsTmp[this.variables.numberLayer2] = 0;

                        neuronn.weights = weightsTmp;
                    }

            this.variables.layer2.Add(newNeuron);
            this.variables.layer2Lbl.Add(newLabel);

            variables.workSpaceMDIchild.Controls.Add(newLabel);
            variables.workSpaceMDIchild.Controls.Add(newNeuron);

            this.variables.numberLayer1++;
            this.mainForm.boxLayer1Text = this.variables.numberLayer2.ToString();
            this.flags.projectNotSavedFlag = false;
        }
        public void createOutputNeuron(int X, int Y)
        {
            PictureBox newNeuron = new PictureBox();
            System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();

            newNeuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
            newNeuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
            newNeuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
            newNeuron.MouseHover += new EventHandler(neuronMouseOver);
            newNeuron.MouseLeave += new EventHandler(neuronMouseOut);

            newNeuron.Cursor = Cursors.NoMove2D;
            newNeuron.Width = 21;
            newNeuron.Height = 21;
            newNeuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(false);
            newNeuron.BackgroundImageLayout = ImageLayout.Stretch;
            if (X == 0 && Y == 0)
                newNeuron.Location = new Point(600, 40 + (this.variables.numberOutput * 40) + 8);
            else
                newNeuron.Location = new Point(X, Y);
            if (this.flags.applicationModeFlag == 0)
            {
                Neuron neuro = new Neuron(this.variables.numberOutput, variables.numberLayer1, "output", this.mainForm);
                neuro.Fire += new Neuron.FiringHandler(this.neuronInteraction.fireOutput);
                newNeuron.Tag = neuro;
                newLabel = new System.Windows.Forms.Label();

                newLabel.Cursor = Cursors.NoMove2D;
                if (X == 0 && Y == 0)
                    newLabel.Location = new Point(600 + (newNeuron.Width / 2) - 7, 40 + (this.variables.numberOutput * 40) + 12);
                else
                    newLabel.Location = new Point(X + (newNeuron.Width / 2) - 9, Y + 5);
                newLabel.Tag = "output";
                newLabel.Text = (this.variables.numberOutput + 1).ToString();
                newLabel.BackColor = Color.CornflowerBlue;
                newLabel.Size = new Size(17, 15);
                newLabel.Font = new Font("Microsoft Sans Serif", 6.5f);
                newLabel.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                newLabel.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                newLabel.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                newLabel.MouseHover += new EventHandler(neuronMouseOver);
                newLabel.MouseLeave += new EventHandler(neuronMouseOut);
            }
            else
            {
                ANNneuron neuro = new ANNneuron(this.variables.numberOutput, 0, this.variables.numberLayer1, "output");
                newNeuron.Tag = neuro;
                newLabel = new System.Windows.Forms.Label();

                newLabel.Cursor = Cursors.NoMove2D;
                if (X == 0 && Y == 0)
                    newLabel.Location = new Point(600 + (newNeuron.Width / 2) - 7, 40 + (this.variables.numberOutput * 40) + 12);
                else
                    newLabel.Location = new Point(X + (newNeuron.Width / 2) - 9, Y + 5);
                newLabel.Tag = "output";
                newLabel.Text = (this.variables.numberOutput + 1).ToString();
                newLabel.BackColor = Color.CornflowerBlue;
                newLabel.Size = new Size(17, 15);
                newLabel.Font = new Font("Microsoft Sans Serif", 6.5f);
                newLabel.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                newLabel.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                newLabel.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                newLabel.MouseHover += new EventHandler(neuronMouseOver);
                newLabel.MouseLeave += new EventHandler(neuronMouseOut);
            }
            this.variables.output.Add(newNeuron);
            this.variables.outputLbl.Add(newLabel);

            variables.workSpaceMDIchild.Controls.Add(newLabel);
            variables.workSpaceMDIchild.Controls.Add(newNeuron);

            this.variables.numberOutput++;
            this.mainForm.boxOutputText = this.variables.numberOutput.ToString();
            this.flags.projectNotSavedFlag = false;
        }

        private void Neuron_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((PictureBox)sender).Height == 22)//input
                {
                    this.variables.clickedNeuron = (PictureBox)sender;
                    this.flags.whichLayerNeuronFlag = 0;
                }
                if (((PictureBox)sender).Height == 40) // layer 1 and 2
                {
                    this.variables.clickedNeuron = (PictureBox)sender;
                    this.flags.whichLayerNeuronFlag = 1;
                }
                if (((PictureBox)sender).Height == 21)//output
                {
                    this.variables.clickedNeuron = (PictureBox)sender;
                    this.flags.whichLayerNeuronFlag = 2;
                }
                if (flags.neuronMoveFlag == 3) //if multiple neurons has been catched
                {
                    flags.neuronMoveFlag = 4;
                    flags.memXFlag = e.X;
                    flags.memYFlag = e.Y;
                }
                if (this.flags.erasingNeuronsFlag == false && this.flags.neuronMoveFlag != 4)
                {
                    this.flags.neuronMoveFlag = 1;
                    this.variables.neuronsToMove.Clear();
                    this.variables.neuronsToMove.Add(((PictureBox)sender));
                    this.flags.memXFlag = e.X;
                    this.flags.memYFlag = e.Y;

                        GroupBox groupBox1copy = mainForm.groupBox1Passer();
                        LineShape lineLong = mainForm.lineShape1Passer();
                        OvalShape detailShape = mainForm.detailShapePasser();
                        Panel inputsPanel = mainForm.inputsDetailsPanelPasser();
                        this.dockDetailsWindow();
                        for (int i = 0; i < variables.howManyDetailBoxes; i++)
                        {
                            variables.detailBox[i].Dispose();
                        }

                        for (int i = 0; i < variables.howManyGroupBoxes; i++)
                        {
                            variables.groupBoxes[i].Dispose();
                            variables.longLines[i].Dispose();
                        }
                        PictureBox shape = ((PictureBox)sender);

                        if (shape.Height == 22)//input
                        {
                            mainForm.setDetailsWindowHeaderText(" neuron no. " + (((InputNeuron)shape.Tag).number + 1).ToString() + " ( input )");

                            mainForm.boxDelayText = ((InputNeuron)shape.Tag).delayCopy.ToString();
                            mainForm.btnUpdateDataTag = 0;
                            mainForm.lblThresholdVisibility = false;
                            mainForm.lblWeightVisibility = false;
                            mainForm.boxThresholdVisibility = false;
                            mainForm.boxWeightVisibility = false;
                            mainForm.lblWhichLayerText = "input";
                            mainForm.lblWhichLayerTag = ((InputNeuron)shape.Tag).number;
                        }
                        if (shape.Height == 40) // layer 1 and 2
                        {
                            mainForm.lblThresholdVisibility = true;
                            mainForm.lblWeightVisibility = true;
                            mainForm.boxDelayVisibility = true;
                            mainForm.boxThresholdVisibility = true;
                            mainForm.boxWeightVisibility = true;
                            mainForm.setDetailsWindowHeaderText(" neuron no. " + (((Neuron)shape.Tag).number + 1).ToString() + " ( " + ((Neuron)shape.Tag).layerName + " )");

                            mainForm.lblPotentialText = this._appMessages.potentialLabel[this.flags.languageIndexVar] + ((Neuron)shape.Tag).potential.ToString();
                            mainForm.lblDelayVisibility = true;
                            mainForm.lblWhichLayerText = ((Neuron)shape.Tag).layerName;
                            mainForm.lblWhichLayerTag = ((Neuron)shape.Tag).number;
                            //minus jeden wsio:
                            variables.howManyDetailBoxes = 2 * (((Neuron)shape.Tag).inputCount - 1);

                            variables.detailBox = new TextBox[variables.howManyDetailBoxes];
                            variables.howManyGroupBoxes = ((Neuron)shape.Tag).inputCount - 1;
                            variables.groupBoxes = new GroupBox[variables.howManyGroupBoxes];

                            variables.longLines = new LineShape[variables.howManyGroupBoxes];

                            ShapeContainer sc2 = new ShapeContainer();

                            //utworzenie groupboxów:
                            int insideOfset = 0;
                            for (int k = 0; k < ((Neuron)shape.Tag).inputCount - 1; k++)
                            {
                                GroupBox gb = new GroupBox();
                                gb.Top = groupBox1copy.Top + (k + 1) * groupBox1copy.Height;

                                gb.Left = groupBox1copy.Left;
                                gb.Width = groupBox1copy.Width;
                                gb.Height = groupBox1copy.Height;
                                gb.Text = "input " + (k + 2).ToString();
                                gb.RightToLeft = RightToLeft.No;

                                lineLong.X1 = gb.Right;
                                lineLong.X2 = detailShape.Left;
                                lineLong.Y1 = gb.Top + (gb.Height / 2);
                                lineLong.Y2 = detailShape.Top + (detailShape.Height / 2);
                                lineLong.BorderWidth = 1;
                                variables.longLines[k] = lineLong;
                                sc2.Shapes.Add(lineLong);

                                int offset = gb.Top - groupBox1copy.Top;
                                //detail o wejsciach:

                                for (int i = 0; i < 2; i++)
                                {//0.,1,2.,3,4,5.,6,

                                    variables.detailBox[i + insideOfset] = new TextBox();
                                    if (i % 2 == 0) //delay
                                    {
                                        System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                                        lbl.Text = "Delay:";
                                        lbl.Location = mainForm.lblDelayLocation;
                                        lbl.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxDelayLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxDelayLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxDelayDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)shape.Tag).delays[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl);
                                    }
                                    if (i % 2 == 1) //wieght
                                    {
                                        System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                                        lbl.Text = "Weight:";
                                        lbl.Location = mainForm.lblWeightLocation;
                                        lbl.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxWeightLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxWeightLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxWeightDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)shape.Tag).weights[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl);
                                    }

                                }
                                insideOfset = insideOfset + 2;
                                
                                variables.groupBoxes[k] = gb;

                                inputsPanel.Controls.Add(gb);
                            }
                            mainForm.boxDelayText = ((Neuron)shape.Tag).delays[0].ToString();
                            mainForm.boxWeightText = ((Neuron)shape.Tag).weights[0].ToString();
                            mainForm.boxThresholdText = ((Neuron)shape.Tag).threshold.ToString();
                            mainForm.btnUpdateDataTag = 0;
                            mainForm.tabPage1ControlsAdd(sc2);
                        }
                        if (shape.Height == 21)//output
                        {
                            mainForm.lblThresholdVisibility = true;
                            mainForm.lblWeightVisibility = true;
                            mainForm.boxThresholdVisibility = true;
                            mainForm.boxWeightVisibility = true;
                            mainForm.boxDelayVisibility = true;
                            mainForm.lblDelayVisibility = true;

                            variables.howManyDetailBoxes = 2 * (((Neuron)shape.Tag).inputCount - 1);

                            variables.detailBox = new TextBox[variables.howManyDetailBoxes];
                            variables.howManyGroupBoxes = ((Neuron)shape.Tag).inputCount - 1;
                            variables.groupBoxes = new GroupBox[variables.howManyGroupBoxes];

                            mainForm.setDetailsWindowHeaderText(" neuron no. " + (((Neuron)shape.Tag).number + 1).ToString() + " ( " + ((Neuron)shape.Tag).layerName + " )");
                            mainForm.lblPotentialText = this._appMessages.potentialLabel[this.flags.languageIndexVar] + ((Neuron)shape.Tag).potential.ToString();
                            mainForm.lblWhichLayerText = ((Neuron)shape.Tag).layerName;
                            mainForm.lblWhichLayerTag = ((Neuron)shape.Tag).number;
                            variables.longLines = new LineShape[variables.howManyGroupBoxes];
                            ShapeContainer sc2 = new ShapeContainer();
                            //utworzenie groupboxów:
                            int insideOfset = 0;
                            for (int k = 0; k < ((Neuron)shape.Tag).inputCount - 1; k++)
                            {
                                GroupBox gb = new GroupBox();
                                gb.Top = groupBox1copy.Top + (k + 1) * groupBox1copy.Height;

                                gb.Left = groupBox1copy.Left;
                                gb.Width = groupBox1copy.Width;
                                gb.Height = groupBox1copy.Height;
                                gb.Text = "input " + (k + 2).ToString();
                                gb.RightToLeft = RightToLeft.No;

                                int offset = gb.Top - groupBox1copy.Top;
                                //detail o wejsciach:

                                lineLong.X1 = gb.Right;
                                lineLong.X2 = detailShape.Left;
                                lineLong.Y1 = gb.Top + (gb.Height / 2);
                                lineLong.Y2 = detailShape.Top + (detailShape.Height / 2);
                                lineLong.BorderWidth = 1;
                                variables.longLines[k] = lineLong;
                                sc2.Shapes.Add(lineLong);
                                for (int i = 0; i < 2; i++)
                                {//0.,1,2.,3,4,5.,6,

                                    variables.detailBox[i + insideOfset] = new TextBox();
                                    if (i % 2 == 0) //delay
                                    {
                                        System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                                        lbl.Text = "Delay:";
                                        lbl.Location = mainForm.lblDelayLocation;
                                        lbl.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxDelayLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxDelayLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxDelayDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)shape.Tag).delays[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl);
                                    }
                                    if (i % 2 == 1) //wieght
                                    {
                                        System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                                        lbl.Text = "Weight:";
                                        lbl.Location = mainForm.lblWeightLocation;
                                        lbl.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxWeightLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxWeightLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxWeightDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)shape.Tag).weights[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl);
                                    }

                                }
                                insideOfset = insideOfset + 2;

                                variables.groupBoxes[k] = gb;
                                inputsPanel.Controls.Add(gb);

                            }
                            mainForm.tabPage1ControlsAdd(sc2);
                            mainForm.boxDelayText = ((Neuron)shape.Tag).delays[0].ToString();
                            mainForm.boxWeightText = ((Neuron)shape.Tag).weights[0].ToString();
                            mainForm.boxThresholdText = ((Neuron)shape.Tag).threshold.ToString();
                            mainForm.btnUpdateDataTag = 0;
                        }
                }
                else if (this.flags.erasingNeuronsFlag == true && this.flags.neuronMoveFlag != 4)
                {
                    this.flags.projectNotSavedFlag = true;
                    if (this.flags.applicationModeFlag == 0)
                    {
                        if (((PictureBox)sender).Height == 22)//input
                        {
                            InputNeuron iNeuron = (InputNeuron)((PictureBox)sender).Tag;

                            variables.workSpaceMDIchild.Controls.Remove((Control)sender);
                            int neuronIndex = iNeuron.number;
                            variables.workSpaceMDIchild.Controls.Remove(variables.inputLbl[neuronIndex]);
                            if (neuronIndex != this.variables.numberInput - 1)
                            {
                                for (int i = 0; i < neuronIndex; i++)
                                {
                                    ((InputNeuron)variables.inputNeurons[i].Tag).number = i;
                                    variables.inputLbl[i].Text = (i + 1).ToString();
                                }
                                for (int i = neuronIndex + 1; i < variables.numberInput; i++)
                                {
                                    ((InputNeuron)variables.inputNeurons[i].Tag).number = i - 1;
                                    variables.inputLbl[i].Text = (i).ToString();
                                }
                            }
                            variables.numberInput--;
                            mainForm.boxInputText = variables.numberInput.ToString();
                            variables.inputNeurons.RemoveAt(neuronIndex);
                            variables.inputLbl.RemoveAt(neuronIndex);
                        }
                        if (((PictureBox)sender).Height == 40) // layer 1 and 2
                        {
                            Neuron iNeuron = (Neuron)((PictureBox)sender).Tag;
                            variables.workSpaceMDIchild.Controls.Remove((Control)sender);

                            int neuronIndex = iNeuron.number;
                            variables.workSpaceMDIchild.Controls.Remove(variables.layer1Lbl[neuronIndex]);
                            //Layer 1 only:
                            if (neuronIndex != this.variables.numberLayer1 - 1)
                            {
                                for (int i = 0; i < neuronIndex; i++)
                                {
                                    ((Neuron)variables.layer1[i].Tag).number = i;
                                    variables.layer1Lbl[i].Text = (i + 1).ToString();
                                }
                                for (int i = neuronIndex + 1; i < variables.numberLayer1; i++)
                                {
                                    ((Neuron)variables.layer1[i].Tag).number = i - 1;
                                    variables.layer1Lbl[i].Text = (i).ToString();
                                }
                            }
                            variables.numberLayer1--;
                            mainForm.boxLayer1Text = variables.numberLayer1.ToString();
                            variables.layer1.RemoveAt(neuronIndex);
                            variables.layer1Lbl.RemoveAt(neuronIndex);
                        }
                        if (((PictureBox)sender).Height == 21)//output
                        {
                            Neuron iNeuron = (Neuron)((PictureBox)sender).Tag;

                            variables.workSpaceMDIchild.Controls.Remove((Control)sender);

                            int neuronIndex = iNeuron.number;
                            if (neuronIndex != this.variables.numberOutput - 1)
                            {
                                for (int i = 0; i < neuronIndex; i++)
                                {
                                    ((Neuron)variables.output[i].Tag).number = i;
                                    variables.outputLbl[i].Text = (i + 1).ToString();
                                }
                                for (int i = neuronIndex + 1; i < variables.numberOutput; i++)
                                {
                                    ((Neuron)variables.output[i].Tag).number = i - 1;
                                    variables.outputLbl[i].Text = (i).ToString();
                                }
                            }
                            variables.numberOutput--;
                            mainForm.boxOutputText = variables.numberOutput.ToString();
                            variables.output.RemoveAt(neuronIndex);
                            variables.outputLbl.RemoveAt(neuronIndex);
                        }
                    }
                        this.drawSynapses();
               }
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                //this.mainForm.detailsWindowVisibility = false;

                if (this.flags.applicationModeFlag == 1)
                {
                    if (((PictureBox)(sender)).Tag is ANNinput)
                    {
                        this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingInputANN((ANNinput)((PictureBox)(sender)).Tag);
                        this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                    }
                    if (((PictureBox)(sender)).Tag is ANNneuron)
                    {
                        ANNneuron neuron = (ANNneuron)((PictureBox)(sender)).Tag;
                        if ((neuron.gLayer.CompareTo("Layer 1") == 0) || (neuron.gLayer.CompareTo("Layer 2") == 0) || (neuron.gLayer.CompareTo("output") == 0))
                        {
                            this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingANNneuron(neuron);
                            this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                        }
                    }
                }
                else
                {
                    if (((PictureBox)(sender)).Tag is InputNeuron)
                    {
                        this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingInput((InputNeuron)((PictureBox)(sender)).Tag);
                        this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                    }
                    if (((PictureBox)(sender)).Tag is Neuron)
                    {
                        Neuron neuron = (Neuron)((PictureBox)(sender)).Tag;
                        if (neuron.layerName.CompareTo("Layer 1") == 0)
                        {
                            this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingLayer1(neuron);
                            this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                        }
                        if (neuron.layerName.CompareTo("output") == 0)
                        {
                            this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingLayer1(neuron);
                            this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                        }
                    }
                }
            }
        }
        private void Neuron_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.neuronMoveFlag == 1 || this.flags.neuronMoveFlag == 2)
            {
                variables.workSpaceMDIchild.Refresh();
                MouseEventArgs events = (MouseEventArgs)e;
                PictureBox shape = ((PictureBox)sender);
                shape.Left = shape.Left + events.X - flags.memXFlag;
                shape.Top = shape.Top + events.Y - flags.memYFlag;

                if (shape.Height == 22)//input
                {
                    variables.inputLbl[((InputNeuron)shape.Tag).number].Left = variables.inputLbl[((InputNeuron)shape.Tag).number].Left + events.X - flags.memXFlag;
                    variables.inputLbl[((InputNeuron)shape.Tag).number].Top = variables.inputLbl[((InputNeuron)shape.Tag).number].Top + events.Y - flags.memYFlag;
                }
                if (shape.Height == 40) // layer 1 and 2
                {
                    if (((Neuron)shape.Tag).layerName.Equals("Layer 1"))
                    {
                        variables.layer1Lbl[((Neuron)shape.Tag).number].Left = variables.layer1Lbl[((Neuron)shape.Tag).number].Left + events.X - flags.memXFlag;
                        variables.layer1Lbl[((Neuron)shape.Tag).number].Top = variables.layer1Lbl[((Neuron)shape.Tag).number].Top + events.Y - flags.memYFlag;
                    }
                    if (((Neuron)shape.Tag).layerName.Equals("Layer 2"))
                    {
                        variables.layer2Lbl[((Neuron)shape.Tag).number].Left = variables.layer2Lbl[((Neuron)shape.Tag).number].Left + events.X - flags.memXFlag;
                        variables.layer2Lbl[((Neuron)shape.Tag).number].Top = variables.layer2Lbl[((Neuron)shape.Tag).number].Top + events.Y - flags.memYFlag;
                    }
                }
                if (shape.Height == 21)//output
                {
                    variables.outputLbl[((Neuron)shape.Tag).number].Left = variables.outputLbl[((Neuron)shape.Tag).number].Left + events.X - flags.memXFlag;
                    variables.outputLbl[((Neuron)shape.Tag).number].Top = variables.outputLbl[((Neuron)shape.Tag).number].Top + events.Y - flags.memYFlag;
                }
                this.drawSynapses();
            }
            if (flags.neuronMoveFlag == 4) //move more than one neurons
            {
                variables.workSpaceMDIchild.Refresh();
                MouseEventArgs events = (MouseEventArgs)e;
                foreach (PictureBox pb in variables.neuronsToMove)
                {
                    pb.Left = pb.Left + events.X - flags.memXFlag;
                    pb.Top = pb.Top + events.Y - flags.memYFlag;
                }
                foreach (System.Windows.Forms.Label lbl in variables.labelsToMove)
                {
                    lbl.Left = lbl.Left + events.X - flags.memXFlag;
                    lbl.Top = lbl.Top + events.Y - flags.memYFlag;
                }
                this.drawSynapses();
            }
        }
        private void Neuron_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.flags.neuronMoveFlag == 4)
                this.uncheckNeurons();
            
            this.flags.neuronMoveFlag = 0;
            this.drawSynapses();
        }
        private void neuronLBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Windows.Forms.Label lbl = ((System.Windows.Forms.Label)sender);
                if (((string)lbl.Tag).CompareTo("input") == 0)//input
                {
                    this.variables.clickedNeuron = this.variables.inputNeurons[(Convert.ToInt32(lbl.Text) - 1)];
                    this.flags.whichLayerNeuronFlag = 0;
                }
                if (((string)lbl.Tag).CompareTo("Layer 1") == 0) // layer 1 
                {
                    this.variables.clickedNeuron = this.variables.layer1[(Convert.ToInt32(lbl.Text) - 1)];
                    this.flags.whichLayerNeuronFlag = 1;
                }
                if (((string)lbl.Tag).CompareTo("output") == 0)//output
                {
                    this.variables.clickedNeuron = this.variables.output[(Convert.ToInt32(lbl.Text) - 1)];
                    this.flags.whichLayerNeuronFlag = 2;
                }
                if (flags.neuronMoveFlag == 3) //if multiple neurons has been catched
                {
                    flags.neuronMoveFlag = 4;
                    flags.memXFlag = e.X;
                    flags.memYFlag = e.Y;
                }
                if (this.flags.erasingNeuronsFlag == false && this.flags.neuronMoveFlag != 4)
                {
                    this.flags.neuronMoveFlag = 1;
                    this.variables.neuronsToMove.Clear();
                    this.variables.labelsToMove.Clear();
                    this.variables.neuronsToMove.Add(this.variables.clickedNeuron);
                    this.variables.labelsToMove.Add(((Label)sender));
                    this.flags.memXFlag = e.X;
                    this.flags.memYFlag = e.Y;

                        mainForm.setDetailsWindowHeaderText(" neuron no. " + ((System.Windows.Forms.Label)sender).Text + " ( " + ((System.Windows.Forms.Label)sender).Tag.ToString() + " )");

                        GroupBox groupBox1copy = mainForm.groupBox1Passer();
                        LineShape lineLong = mainForm.lineShape1Passer();
                        OvalShape detailShape = mainForm.detailShapePasser();
                        Panel inputsPanel = mainForm.inputsDetailsPanelPasser();
                    
                        this.dockDetailsWindow();

                        mainForm.lblWhichLayerText = ((System.Windows.Forms.Label)sender).Tag.ToString();
                        mainForm.lblWhichLayerTag = Convert.ToInt32(((System.Windows.Forms.Label)sender).Text) - 1;
                        if (((System.Windows.Forms.Label)sender).Tag.ToString().Equals("input")) //input
                        {
                            for (int i = 0; i < variables.howManyDetailBoxes; i++)
                            {
                                variables.detailBox[i].Dispose();
                            }

                            for (int i = 0; i < variables.howManyGroupBoxes; i++)
                            {
                                variables.groupBoxes[i].Dispose();
                            }
                            System.GC.Collect();

                            mainForm.boxDelayText = ((InputNeuron)variables.inputNeurons[Convert.ToInt32(((System.Windows.Forms.Label)sender).Text) - 1].Tag).delayCopy.ToString();
                            mainForm.btnUpdateDataTag = 0;
                            mainForm.lblThresholdVisibility = false;
                            mainForm.lblWeightVisibility = false;
                            mainForm.boxThresholdVisibility = false;
                            mainForm.boxWeightVisibility = false;
                        }
                        if (((System.Windows.Forms.Label)sender).Tag.ToString().Equals("Layer 1")) //layer 1
                        {
                            mainForm.lblThresholdVisibility = true;
                            mainForm.lblWeightVisibility = true;
                            mainForm.boxThresholdVisibility = true;
                            mainForm.boxWeightVisibility = true;
                            mainForm.boxDelayVisibility = true;
                            mainForm.lblDelayVisibility = true;
                            PictureBox neuro = (PictureBox)variables.layer1[Convert.ToInt32(((System.Windows.Forms.Label)sender).Text) - 1];

                            mainForm.lblPotentialText = this._appMessages.potentialLabel[this.flags.languageIndexVar] + ((Neuron)neuro.Tag).potential.ToString();
                            for (int i = 0; i < variables.howManyDetailBoxes; i++)
                            {
                                variables.detailBox[i].Dispose();
                            }

                            for (int i = 0; i < variables.howManyGroupBoxes; i++)
                            {
                                variables.groupBoxes[i].Dispose();
                                variables.longLines[i].Dispose();
                            }
                            variables.howManyDetailBoxes = 2 * (((Neuron)neuro.Tag).inputCount - 1);

                            variables.detailBox = new TextBox[variables.howManyDetailBoxes];
                            variables.howManyGroupBoxes = ((Neuron)neuro.Tag).inputCount - 1;
                            variables.groupBoxes = new GroupBox[variables.howManyGroupBoxes];

                            variables.longLines = new LineShape[variables.howManyGroupBoxes];

                            ShapeContainer sc2 = new ShapeContainer();

                            //utworzenie groupboxów:
                            int insideOfset = 0;
                            for (int k = 0; k < ((Neuron)neuro.Tag).inputCount - 1; k++)
                            {
                                GroupBox gb = new GroupBox();
                                gb.Top = groupBox1copy.Top + (k + 1) * groupBox1copy.Height;

                                gb.Left = groupBox1copy.Left;
                                gb.Width = groupBox1copy.Width;
                                gb.Height = groupBox1copy.Height;
                                gb.Text = "input " + (k + 2).ToString();
                                gb.RightToLeft = RightToLeft.No;

                                lineLong.X1 = gb.Right;
                                lineLong.X2 = detailShape.Left;
                                lineLong.Y1 = gb.Top + (gb.Height / 2);
                                lineLong.Y2 = detailShape.Top + (detailShape.Height / 2);
                                lineLong.BorderWidth = 1;
                                variables.longLines[k] = lineLong;
                                sc2.Shapes.Add(lineLong);
                                int offset = gb.Top - groupBox1copy.Top;
                                //detail o wejsciach:

                                for (int i = 0; i < 2; i++)
                                {//0.,1,2.,3,4,5.,6,

                                    variables.detailBox[i + insideOfset] = new TextBox();
                                    if (i % 2 == 0) //delay
                                    {
                                        System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
                                        lbl2.Text = "Delay:";
                                        lbl2.Location = mainForm.lblDelayLocation;
                                        lbl2.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxDelayLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxDelayLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxDelayDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)neuro.Tag).delays[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl2);
                                    }
                                    if (i % 2 == 1) //wieght
                                    {
                                        System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
                                        lbl2.Text = "Weight:";
                                        lbl2.Location = mainForm.lblWeightLocation;
                                        lbl2.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxWeightLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxWeightLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxWeightDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)neuro.Tag).weights[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl2);
                                    }

                                }
                                insideOfset = insideOfset + 2;

                                variables.groupBoxes[k] = gb;
                                inputsPanel.Controls.Add(gb);
                            }
                            mainForm.boxDelayText = ((Neuron)neuro.Tag).delays[0].ToString();
                            mainForm.boxWeightText = ((Neuron)neuro.Tag).weights[0].ToString();
                            mainForm.boxThresholdText = ((Neuron)neuro.Tag).threshold.ToString();
                            mainForm.btnUpdateDataTag = 0;

                            mainForm.tabPage1ControlsAdd(sc2);
                        }
                        if (((System.Windows.Forms.Label)sender).Tag.ToString().Equals("output")) //output
                        {
                            mainForm.lblThresholdVisibility = true;
                            mainForm.lblWeightVisibility = true;
                            mainForm.lblThresholdVisibility = true;
                            mainForm.boxWeightVisibility = true;
                            mainForm.boxDelayVisibility = true;
                            mainForm.lblDelayVisibility = true;
                            PictureBox neuro = (PictureBox)variables.output[Convert.ToInt32(((System.Windows.Forms.Label)sender).Text) - 1];
                            for (int i = 0; i < variables.howManyDetailBoxes; i++)
                            {
                                variables.detailBox[i].Dispose();
                            }

                            for (int i = 0; i < variables.howManyGroupBoxes; i++)
                            {
                                variables.groupBoxes[i].Dispose();
                                variables.longLines[i].Dispose();
                            }
                            variables.howManyDetailBoxes = 2 * (((Neuron)neuro.Tag).inputCount - 1);
                            mainForm.lblPotentialText = this._appMessages.potentialLabel[this.flags.languageIndexVar] + ((Neuron)neuro.Tag).potential.ToString();

                            variables.detailBox = new TextBox[variables.howManyDetailBoxes];
                            variables.howManyGroupBoxes = ((Neuron)neuro.Tag).inputCount - 1;
                            variables.groupBoxes = new GroupBox[variables.howManyGroupBoxes];
                            variables.longLines = new LineShape[variables.howManyGroupBoxes];
                            ShapeContainer sc2 = new ShapeContainer();
                            //utworzenie groupboxów:
                            int insideOfset = 0;
                            for (int k = 0; k < ((Neuron)neuro.Tag).inputCount - 1; k++)
                            {
                                GroupBox gb = new GroupBox();
                                gb.Top = groupBox1copy.Top + (k + 1) * groupBox1copy.Height;

                                gb.Left = groupBox1copy.Left;
                                gb.Width = groupBox1copy.Width;
                                gb.Height = groupBox1copy.Height;
                                gb.Text = this._appMessages.inputName[this.flags.languageIndexVar] + (k + 2).ToString();
                                gb.RightToLeft = RightToLeft.No;

                                lineLong.X1 = gb.Right;
                                lineLong.X2 = detailShape.Left;
                                lineLong.Y1 = gb.Top + (gb.Height / 2);
                                lineLong.Y2 = detailShape.Top + (detailShape.Height / 2);
                                lineLong.BorderWidth = 1;
                                variables.longLines[k] = lineLong;
                                sc2.Shapes.Add(lineLong);

                                int offset = gb.Top - groupBox1copy.Top;
                                //detail o wejsciach:

                                for (int i = 0; i < 2; i++)
                                {//0.,1,2.,3,4,5.,6,

                                    variables.detailBox[i + insideOfset] = new TextBox();
                                    if (i % 2 == 0) //delay
                                    {
                                        System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
                                        lbl2.Text = this._appMessages.delayName[this.flags.languageIndexVar];
                                        lbl2.Location = mainForm.lblDelayLocation;
                                        lbl2.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxDelayLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxDelayLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxDelayDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)neuro.Tag).delays[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl2);
                                    }
                                    if (i % 2 == 1) //wieght
                                    {
                                        System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
                                        lbl2.Text = this._appMessages.weightName[this.flags.languageIndexVar];
                                        lbl2.Location = mainForm.lblWeightLocation;
                                        lbl2.RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Top = mainForm.boxWeightLeftTop.Y;
                                        variables.detailBox[i + insideOfset].Left = mainForm.boxWeightLeftTop.X;
                                        variables.detailBox[i + insideOfset].Width = mainForm.boxWeightDimensions.X;
                                        variables.detailBox[i + insideOfset].RightToLeft = RightToLeft.No;
                                        variables.detailBox[i + insideOfset].Text = ((Neuron)neuro.Tag).weights[k + 1].ToString();
                                        gb.Controls.Add(variables.detailBox[i + insideOfset]);
                                        gb.Controls.Add(lbl2);
                                    }

                                }
                                insideOfset = insideOfset + 2;

                                variables.groupBoxes[k] = gb;
                                inputsPanel.Controls.Add(gb);
                            }
                            mainForm.tabPage1ControlsAdd(sc2);
                            mainForm.boxDelayText = ((Neuron)neuro.Tag).delays[0].ToString();
                            mainForm.boxWeightText = ((Neuron)neuro.Tag).weights[0].ToString();
                            mainForm.boxThresholdText = ((Neuron)neuro.Tag).threshold.ToString();
                            mainForm.btnUpdateDataTag = 0;
                        }
                    

                }
                else if (this.flags.erasingNeuronsFlag == true && this.flags.neuronMoveFlag != 4)
                {
                    this.flags.projectNotSavedFlag = true;
                    if (((string)lbl.Tag).CompareTo("input") == 0)//input
                    {
                        int neuronIndex = Convert.ToInt32(lbl.Text) - 1;
                        variables.workSpaceMDIchild.Controls.Remove((Control)sender);
                        variables.workSpaceMDIchild.Controls.Remove(variables.inputNeurons[neuronIndex]);
                        if (neuronIndex != this.variables.numberInput - 1)
                        {
                            for (int i = 0; i < neuronIndex; i++)
                            {
                                ((InputNeuron)variables.inputNeurons[i].Tag).number = i;
                                variables.inputLbl[i].Text = (i + 1).ToString();
                            }
                            for (int i = neuronIndex + 1; i < variables.numberInput; i++)
                            {
                                ((InputNeuron)variables.inputNeurons[i].Tag).number = i - 1;
                                variables.inputLbl[i].Text = (i).ToString();
                            }
                        }
                        variables.numberInput--;
                        mainForm.boxInputText = variables.numberInput.ToString();
                        variables.inputNeurons.RemoveAt(neuronIndex);
                        variables.inputLbl.RemoveAt(neuronIndex);
                    }
                    if (((string)lbl.Tag).CompareTo("Layer 1") == 0) // layer 1 
                    {
                        int neuronIndex = Convert.ToInt32(lbl.Text) - 1;
                        variables.workSpaceMDIchild.Controls.Remove((Control)sender);
                        variables.workSpaceMDIchild.Controls.Remove(variables.layer1[neuronIndex]);
                        //Layer 1 only:
                        if (neuronIndex != this.variables.numberLayer1)
                        {
                            for (int i = 0; i < neuronIndex; i++)
                            {
                                ((Neuron)variables.layer1[i].Tag).number = i;
                                variables.layer1Lbl[i].Text = (i + 1).ToString();
                            }
                            for (int i = neuronIndex + 1; i < variables.numberLayer1; i++)
                            {
                                ((Neuron)variables.layer1[i].Tag).number = i - 1;
                                variables.layer1Lbl[i].Text = (i).ToString();
                            }
                        }
                        variables.numberLayer1--;
                        mainForm.boxLayer1Text = variables.numberLayer1.ToString();
                        variables.layer1.RemoveAt(neuronIndex);
                        variables.layer1Lbl.RemoveAt(neuronIndex);
                    }
                    if (((string)lbl.Tag).CompareTo("output") == 0)//output
                    {
                        int neuronIndex = Convert.ToInt32(lbl.Text) - 1;
                        variables.workSpaceMDIchild.Controls.Remove((Control)sender);
                        variables.workSpaceMDIchild.Controls.Remove(variables.output[neuronIndex]);
                        if (neuronIndex != this.variables.numberOutput)
                        {
                            for (int i = 0; i < neuronIndex; i++)
                            {
                                ((Neuron)variables.output[i].Tag).number = i;
                                variables.outputLbl[i].Text = (i + 1).ToString();
                            }
                            for (int i = neuronIndex + 1; i < variables.numberOutput; i++)
                            {
                                ((Neuron)variables.output[i].Tag).number = i - 1;
                                variables.outputLbl[i].Text = (i).ToString();
                            }
                        }
                        variables.numberOutput--;
                        mainForm.boxOutputText = variables.numberOutput.ToString();
                        variables.output.RemoveAt(neuronIndex);
                        variables.outputLbl.RemoveAt(neuronIndex);
                        
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {

                //this.mainForm.detailsWindowVisibility = false;
                string layerName = (string)((System.Windows.Forms.Label)(sender)).Tag;
                if (this.flags.applicationModeFlag == 1)
                {
                    if (((PictureBox)(sender)).Tag is ANNinput)
                    {
                        this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingInputANN((ANNinput)variables.inputNeurons[Convert.ToInt32(((System.Windows.Forms.Label)(sender)).Text) - 1].Tag);
                        this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                    }
                    if (((PictureBox)(sender)).Tag is ANNneuron)
                    {
                        if (layerName.CompareTo("Layer 1") == 0)
                        {
                            this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingANNneuron((ANNneuron)variables.layer1[Convert.ToInt32(((System.Windows.Forms.Label)(sender)).Text) - 1].Tag);
                            this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                        }
                        if (layerName.CompareTo("Layer 2") == 0)
                        {
                            this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingANNneuron((ANNneuron)variables.layer1[Convert.ToInt32(((System.Windows.Forms.Label)(sender)).Text) - 1].Tag);
                            this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                        }
                        if (layerName.CompareTo("output") == 0)
                        {
                            this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingANNneuron((ANNneuron)variables.output[Convert.ToInt32(((System.Windows.Forms.Label)(sender)).Text) - 1].Tag);
                            this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                        }
                    }
                }
                else
                {
                    if (layerName.CompareTo("input") == 0)
                    {
                        this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingInput((InputNeuron)variables.inputNeurons[Convert.ToInt32(((System.Windows.Forms.Label)(sender)).Text) - 1].Tag);
                        this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                    }
                    if (layerName.CompareTo("Layer 1") == 0)
                    {
                        this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingLayer1((Neuron)variables.layer1[Convert.ToInt32(((System.Windows.Forms.Label)(sender)).Text) - 1].Tag);
                        this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                    }
                    if (layerName.CompareTo("output") == 0)
                    {
                        this.variables.workSpaceMDIchild.contextNeuronDetailsBlindingLayer1((Neuron)variables.output[Convert.ToInt32(((System.Windows.Forms.Label)(sender)).Text) - 1].Tag);
                        this.variables.workSpaceMDIchild.contextNeuronDetailsShow = new Point(this.flags.memWorkSpaceMouseXFlag, this.flags.memWorkSpaceMouseYFlag);
                    }
                }
            }
        }
        private void neuronLBL_MouseMove(object sender, MouseEventArgs e)
        {
            if (flags.neuronMoveFlag == 1 || this.flags.neuronMoveFlag == 2)
            {
                variables.workSpaceMDIchild.Refresh();
                MouseEventArgs events = (MouseEventArgs)e;
                System.Windows.Forms.Label lbl = ((System.Windows.Forms.Label)sender);
                lbl.Left = lbl.Left + events.X - flags.memXFlag;
                lbl.Top = lbl.Top + events.Y - flags.memYFlag;

                if (((string)lbl.Tag).Equals("input"))//input
                {
                    variables.inputNeurons[Convert.ToInt32(lbl.Text) - 1].Left = variables.inputNeurons[Convert.ToInt32(lbl.Text) - 1].Left + events.X - flags.memXFlag;
                    variables.inputNeurons[Convert.ToInt32(lbl.Text) - 1].Top = variables.inputNeurons[Convert.ToInt32(lbl.Text) - 1].Top + events.Y - flags.memYFlag;
                }
                if (((string)lbl.Tag).Equals("Layer 1")) // layer 1 and 2
                {
                    variables.layer1[Convert.ToInt32(lbl.Text) - 1].Left = variables.layer1[Convert.ToInt32(lbl.Text) - 1].Left + events.X - flags.memXFlag;
                    variables.layer1[Convert.ToInt32(lbl.Text) - 1].Top = variables.layer1[Convert.ToInt32(lbl.Text) - 1].Top + events.Y - flags.memYFlag;
                }
                if (((string)lbl.Tag).Equals("Layer 2"))
                {
                    variables.layer2[Convert.ToInt32(lbl.Text) - 1].Left = variables.layer2[Convert.ToInt32(lbl.Text) - 1].Left + events.X - flags.memXFlag;
                    variables.layer2[Convert.ToInt32(lbl.Text) - 1].Top = variables.layer2[Convert.ToInt32(lbl.Text) - 1].Top + events.Y - flags.memYFlag;
                }
                if (((string)lbl.Tag).Equals("output"))//output
                {
                    variables.output[Convert.ToInt32(lbl.Text) - 1].Left = variables.output[Convert.ToInt32(lbl.Text) - 1].Left + events.X - flags.memXFlag;
                    variables.output[Convert.ToInt32(lbl.Text) - 1].Top = variables.output[Convert.ToInt32(lbl.Text) - 1].Top + events.Y - flags.memYFlag;
                }
                this.drawSynapses();
            }
            if (flags.neuronMoveFlag == 4) //move more than one neurons
            {
                variables.workSpaceMDIchild.Refresh();
                MouseEventArgs events = (MouseEventArgs)e;
                foreach (PictureBox pb in variables.neuronsToMove)
                {
                    pb.Left = pb.Left + events.X - flags.memXFlag;
                    pb.Top = pb.Top + events.Y - flags.memYFlag;
                }
                foreach (System.Windows.Forms.Label lbl in variables.labelsToMove)
                {
                    lbl.Left = lbl.Left + events.X - flags.memXFlag;
                    lbl.Top = lbl.Top + events.Y - flags.memYFlag;
                }
                this.drawSynapses();
            }
        }
        private void neuronLBL_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.flags.neuronMoveFlag == 4)
                this.uncheckNeurons();
            this.flags.neuronMoveFlag = 0;
            this.drawSynapses();
        }
        private void neuronMouseOver(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                if (flags.erasingNeuronsFlag == true)
                {
                    pb.Cursor = Cursors.No;
                }
                else
                {
                    pb.Cursor = Cursors.NoMove2D;
                }
            }
            if (sender is System.Windows.Forms.Label)
            {
                System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;
                if (flags.erasingNeuronsFlag == true)
                {
                    lbl.Cursor = Cursors.No;
                }
                else
                {
                    lbl.Cursor = Cursors.NoMove2D;
                }
            }

        }
        private void neuronMouseOut(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                if (flags.erasingNeuronsFlag == true)
                    pb.Cursor = Cursors.NoMove2D;
            }
            if (sender is System.Windows.Forms.Label)
            {
                System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;
                if (flags.erasingNeuronsFlag == true)
                    lbl.Cursor = Cursors.NoMove2D;
            }

        }

        public void catchNeurons()
        {//method to mark few neurons so they can be moved all together  

            for (int i = 0; i < variables.numberInput; i++)
            {
                if ((variables.inputNeurons[i].Left >= flags.memXFlag) && (variables.inputNeurons[i].Right <= flags.memXRectangleFlag) && (variables.inputNeurons[i].Top >= flags.memYFlag) && (variables.inputNeurons[i].Bottom <= flags.memYRectangleFlag))
                {
                    variables.inputNeurons[i].Image = variables.workSpaceMDIchild.getCheckedNeuronImage(false);
                    variables.inputLbl[i].BackColor = Color.Yellow;
                    variables.neuronsToMove.Add(variables.inputNeurons[i]);
                    variables.labelsToMove.Add(variables.inputLbl[i]);
                }
            }
            for (int i = 0; i < variables.numberLayer1; i++)
            {
                if ((variables.layer1[i].Left >= flags.memXFlag) && (variables.layer1[i].Right <= flags.memXRectangleFlag) && (variables.layer1[i].Top >= flags.memYFlag) && (variables.layer1[i].Bottom <= flags.memYRectangleFlag))
                {
                    variables.layer1[i].Image = variables.workSpaceMDIchild.getCheckedNeuronImage(true);
                    variables.layer1Lbl[i].BackColor = Color.Yellow;
                    variables.neuronsToMove.Add(variables.layer1[i]);
                    variables.labelsToMove.Add(variables.layer1Lbl[i]);
                }
            }
            for (int i = 0; i < variables.numberLayer2; i++)
            {

            }
            for (int i = 0; i < variables.numberOutput; i++)
            {
                if ((variables.output[i].Left >= flags.memXFlag) && (variables.output[i].Right <= flags.memXRectangleFlag) && (variables.output[i].Top >= flags.memYFlag) && (variables.output[i].Bottom <= flags.memYRectangleFlag))
                {
                    variables.output[i].Image = variables.workSpaceMDIchild.getCheckedNeuronImage(false);
                    variables.outputLbl[i].BackColor = Color.Yellow;
                    variables.neuronsToMove.Add(variables.output[i]);
                    variables.labelsToMove.Add(variables.outputLbl[i]);
                }
            }
        }
        public void uncheckNeurons()
        {
            foreach (PictureBox pb in variables.neuronsToMove)
            {
                if (pb.Width == 40) //bigNeuron
                {
                    pb.Image = variables.workSpaceMDIchild.getNeuronImage(true);
                }
                else //smallNeuron
                {
                    pb.Image = variables.workSpaceMDIchild.getNeuronImage(false);
                }
            }
            foreach (System.Windows.Forms.Label lbl in variables.labelsToMove)
            {
                lbl.BackColor = Color.CornflowerBlue;
            }
            variables.neuronsToMove.Clear();
            variables.labelsToMove.Clear();
        }

        public void drawSynapses()
        {
            //drawing synapses

            Bitmap BackBuffer = new Bitmap(variables.workSpaceMDIchild.ClientSize.Width, variables.workSpaceMDIchild.ClientSize.Height);
            Graphics DrawingArea = Graphics.FromImage(BackBuffer);

            System.Drawing.Graphics graphicsObj;
            graphicsObj = variables.workSpaceMDIchild.CreateGraphics();
            graphicsObj.SmoothingMode = SmoothingMode.HighSpeed;
            Pen myPen = new Pen(System.Drawing.Color.Black, 1);
            //input layer to first layer
            for (int i = 0; i < variables.numberInput; i++)
            {
                graphicsObj.DrawLine(myPen, variables.inputNeurons[i].Left + 10, variables.inputNeurons[i].Top + 10, variables.inputNeurons[i].Left + 40, variables.inputNeurons[i].Top + 10);
                for (int j = 0; j < variables.numberLayer1; j++)
                {
                    graphicsObj.DrawLine(myPen, variables.inputNeurons[i].Left + 40, variables.inputNeurons[i].Top + 10, variables.layer1[j].Left, variables.layer1[j].Top + 20);
                }
            }
            //first layer to output layer
            if (this.variables.numberLayer2 != 0)
            {

                for (int i = 0; i < variables.numberLayer1; i++)
                {
                    graphicsObj.DrawLine(myPen, variables.layer1[i].Left + 20, variables.layer1[i].Top + 20, variables.layer1[i].Left + 60, variables.layer1[i].Top + 20);
                    for (int j = 0; j < variables.numberLayer2; j++)
                    {
                        graphicsObj.DrawLine(myPen, variables.layer1[i].Left + 60, variables.layer1[i].Top + 20, variables.layer2[j].Left, variables.layer2[j].Top + 20);
                    }
                }

                for (int i = 0; i < variables.numberLayer2; i++)
                {
                    graphicsObj.DrawLine(myPen, variables.layer2[i].Left + 20, variables.layer2[i].Top + 20, variables.layer2[i].Left + 60, variables.layer2[i].Top + 20);
                    for (int j = 0; j < variables.numberOutput; j++)
                    {
                        graphicsObj.DrawLine(myPen, variables.layer2[i].Left + 60, variables.layer2[i].Top + 20, variables.output[j].Left, variables.output[j].Top + 10);
                    }
                }
            }
            else
            {
                for (int i = 0; i < variables.numberLayer1; i++)
                {
                    graphicsObj.DrawLine(myPen, variables.layer1[i].Left + 20, variables.layer1[i].Top + 20, variables.layer1[i].Left + 60, variables.layer1[i].Top + 20);
                    for (int j = 0; j < variables.numberOutput; j++)
                    {
                        graphicsObj.DrawLine(myPen, variables.layer1[i].Left + 60, variables.layer1[i].Top + 20, variables.output[j].Left, variables.output[j].Top + 10);
                    }
                }
            }
            DrawingArea.DrawImage(BackBuffer, 0, 0);
        }
        

        public IniFileLight saveStructure()
        {
            IniFileLight saveIni = new IniFileLight();

            saveIni.Sections.Add("mode", new Dictionary<string, string>());

            if (this.flags.applicationModeFlag == 0)
            {
                saveIni.Sections["mode"].Add("name", "SNN");
            }
            else
            {
                saveIni.Sections["mode"].Add("name", "ANN");
            }

            saveIni.Sections.Add("input", new Dictionary<string, string>());
            saveIni.Sections.Add("layer1", new Dictionary<string, string>());

            saveIni.Sections.Add("layer2", new Dictionary<string, string>());
            saveIni.Sections["layer2"].Add("n", this.variables.numberLayer2.ToString());
            if (this.flags.layer2netFlag == true)
            {//add 2nd layer structure
                for (int i = 0; i < this.variables.numberLayer2; i++)
                {
                    Neuron neuro = (Neuron)this.variables.layer2[i].Tag;
                    saveIni.Sections["layer2"].Add("t" + i.ToString(), neuro.threshold.ToString());
                    for (int j = 0; j < this.variables.numberLayer2; j++)
                    {
                        saveIni.Sections["layer2"].Add("d" + i.ToString(), neuro.delays[j].ToString());
                        saveIni.Sections["layer2"].Add("w" + i.ToString(), neuro.weights[j].ToString());
                    }
                }
            }
            saveIni.Sections.Add("output", new Dictionary<string, string>());

            saveIni.Sections["input"].Add("n", this.variables.numberInput.ToString());
            saveIni.Sections["layer1"].Add("n", this.variables.numberLayer1.ToString());
            saveIni.Sections["output"].Add("n", this.variables.numberOutput.ToString());

            for (int i = 0; i < this.variables.numberInput; i++)
            {
                saveIni.Sections["input"].Add("d" + i.ToString(), ((InputNeuron)this.variables.inputNeurons[i].Tag).delayCopy.ToString());
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                Neuron neuro = (Neuron)this.variables.layer1[i].Tag;
                saveIni.Sections["layer1"].Add("t" + i.ToString(), neuro.threshold.ToString());
                for (int j = 0; j < this.variables.numberInput; j++)
                {
                    saveIni.Sections["layer1"].Add("n" + i.ToString() + "d" + j.ToString(), neuro.delays[j].ToString());
                    saveIni.Sections["layer1"].Add("n" + i.ToString() + "w" + j.ToString(), neuro.weights[j].ToString());
                }
            }

            for (int i = 0; i < this.variables.numberOutput; i++) //only if one layer
            {
                Neuron neuro = (Neuron)this.variables.output[i].Tag;
                saveIni.Sections["output"].Add("t" + i.ToString(), neuro.threshold.ToString());
                for (int j = 0; j < this.variables.numberLayer1; j++)
                {
                    saveIni.Sections["output"].Add("n" + i.ToString() + "d" + j.ToString(), neuro.delays[j].ToString());
                    saveIni.Sections["output"].Add("n" + i.ToString() + "w" + j.ToString(), neuro.weights[j].ToString());
                }
            }
            return saveIni;
        }
        public void loadStructure(IniFileLight ini)
        {
            IniFileLight loadIni = ini;
            
            string appMode = ini.Sections["mode"]["name"];

            if (appMode.CompareTo("SNN") == 0)
            {
                this.flags.applicationModeFlag = 0;
                this.mainForm.menuStripModeSNNchange = true;
                this.mainForm.menuStripModeANNchange = false;
                mainForm.Text = this._appMessages.networkName[this.flags.applicationModeFlag] + " - " + this._appMessages.spikingModeName[this.flags.applicationModeFlag];
            }
            else
            {
                this.flags.applicationModeFlag = 1;
                this.mainForm.menuStripModeSNNchange = false;
                this.mainForm.menuStripModeANNchange = true;
                mainForm.Text = this._appMessages.networkName[this.flags.applicationModeFlag] + " - " + this._appMessages.artificialModeName[this.flags.applicationModeFlag];
            }

            this.variables.numberInput = Convert.ToInt32(ini.Sections["input"]["n"]);
            this.variables.numberLayer1 = Convert.ToInt32(ini.Sections["layer1"]["n"]);
            this.variables.numberLayer2 = Convert.ToInt32(ini.Sections["layer2"]["n"]);
            this.variables.numberOutput = Convert.ToInt32(ini.Sections["output"]["n"]);

            this.mainForm.boxInputText = this.variables.numberInput.ToString();
            this.mainForm.boxLayer1Text = this.variables.numberLayer1.ToString();
            this.mainForm.boxLayer2Text = this.variables.numberLayer2.ToString();
            this.mainForm.boxOutputText = this.variables.numberOutput.ToString();

            this.createStructure();

            if (this.variables.numberLayer2 != 0)
            {
                this.flags.layer2netFlag = true;//here goes implementation for layer 2
            }

            for (int i = 0; i < this.variables.numberInput; i++)
            {
                ((InputNeuron)this.variables.inputNeurons[i].Tag).initialize(Convert.ToInt32(ini.Sections["input"]["d" + i.ToString()]));
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                Neuron neuro = (Neuron)this.variables.layer1[i].Tag;
                neuro.threshold = Convert.ToDouble(ini.Sections["layer1"]["t" + i.ToString()]);
                for (int j = 0; j < this.variables.numberInput; j++)
                {
                    neuro.delays[j] = Convert.ToInt32(ini.Sections["layer1"]["n" + i.ToString() + "d" + j.ToString()]);
                    neuro.weights[j] = Convert.ToDouble(ini.Sections["layer1"]["n" + i.ToString() + "w" + j.ToString()]);
                }
                this.variables.layer1[i].Tag = neuro;
            }
            for (int i = 0; i < this.variables.numberOutput; i++)
            {

                Neuron neuro = (Neuron)this.variables.output[i].Tag;
                neuro.threshold = Convert.ToDouble(ini.Sections["output"]["t" + i.ToString()]);
                for (int j = 0; j < this.variables.numberLayer1; j++)
                {
                    neuro.delays[j] = Convert.ToInt32(ini.Sections["output"]["n" + i.ToString() + "d" + j.ToString()]);
                    neuro.weights[j] = Convert.ToDouble(ini.Sections["output"]["n" + i.ToString() + "w" + j.ToString()]);
                }
                this.variables.output[i].Tag = neuro;
            }
            //this.createSynapses();
        }

        public void createStructure()
        {
            this.flags.detailWindowFlag = false;

            if (this.flags.applicationModeFlag == 1)
            {
                for (int i = 0; i < variables.numberInput; i++)
                {
                    PictureBox neuron = new PictureBox();
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                    neuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
                    neuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
                    neuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
                    neuron.MouseHover += new EventHandler(neuronMouseOver);
                    neuron.MouseLeave += new EventHandler(neuronMouseOut);

                    neuron.Cursor = Cursors.NoMove2D;
                    neuron.Width = 22;
                    neuron.Height = 22;
                    neuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
                    neuron.BackgroundImageLayout = ImageLayout.Stretch;
                    //uwaga sprawdzam potem Location.X zeby okreslic co za neuron jest kliknięty
                    neuron.Location = new Point(200, 40 + (i * 40) + 8);
                    ANNinput neuro = new ANNinput(i, 0);
                    neuron.Tag = neuro;

                    label.Cursor = Cursors.NoMove2D;
                    label.Location = new Point(200 + (neuron.Width / 2) - 8, 40 + (i * 40) + 12);
                    label.Tag = "input";
                    label.Text = (i + 1).ToString();
                    label.BackColor = Color.CornflowerBlue;
                    label.Size = new Size(17, 15);
                    label.Font = new Font("Microsoft Sans Serif", 6.5f);
                    label.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                    label.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                    label.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                    label.MouseHover += new EventHandler(neuronMouseOver);
                    label.MouseLeave += new EventHandler(neuronMouseOut);

                    this.variables.inputLbl.Add(label);
                    this.variables.inputNeurons.Add(neuron);

                    variables.workSpaceMDIchild.Controls.Add(label);
                    variables.workSpaceMDIchild.Controls.Add(neuron);

                }
                for (int i = 0; i < variables.numberLayer1; i++)
                {
                    PictureBox neuron = new PictureBox();

                    neuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
                    neuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
                    neuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
                    neuron.MouseHover += new EventHandler(neuronMouseOver);
                    neuron.MouseLeave += new EventHandler(neuronMouseOut);

                    neuron.Cursor = Cursors.NoMove2D;
                    neuron.Width = 40;
                    neuron.Height = 40;
                    neuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
                    neuron.BackgroundImageLayout = ImageLayout.Stretch;
                    neuron.Location = new Point(350, 40 + (i * 55) + 9);
                    ANNneuron neuro = new ANNneuron(i, 0, variables.numberInput, "Layer 1");
                    neuron.Tag = neuro;
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                    label.Cursor = Cursors.NoMove2D;
                    label.Location = new Point(350 + (neuron.Width / 2) - 8, 40 + (i * 55) + 22);
                    label.Tag = "Layer 1";
                    label.Text = (i + 1).ToString();
                    label.BackColor = Color.CornflowerBlue;
                    label.Size = new Size(17, 15);
                    label.Font = new Font("Microsoft Sans Serif", 6.5f);
                    label.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                    label.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                    label.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                    label.MouseHover += new EventHandler(neuronMouseOver);
                    label.MouseLeave += new EventHandler(neuronMouseOut);

                    this.variables.layer1.Add(neuron);
                    this.variables.layer1Lbl.Add(label);

                    variables.workSpaceMDIchild.Controls.Add(label);
                    variables.workSpaceMDIchild.Controls.Add(neuron);
                }
                if (this.variables.numberLayer2 != 0)
                {
                    for (int i = 0; i < variables.numberLayer2; i++)
                    {
                        PictureBox neuron = new PictureBox();

                        neuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
                        neuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
                        neuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
                        neuron.MouseHover += new EventHandler(neuronMouseOver);
                        neuron.MouseLeave += new EventHandler(neuronMouseOut);

                        neuron.Cursor = Cursors.NoMove2D;
                        neuron.Width = 40;
                        neuron.Height = 40;
                        neuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
                        neuron.BackgroundImageLayout = ImageLayout.Stretch;
                        neuron.Location = new Point(600, 40 + (i * 55) + 9);
                        ANNneuron neuro = new ANNneuron(i, 0, variables.numberInput, "Layer 2");
                        neuron.Tag = neuro;
                        System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                        label.Cursor = Cursors.NoMove2D;
                        label.Location = new Point(600 + (neuron.Width / 2) - 8, 40 + (i * 55) + 22);
                        label.Tag = "Layer 2";
                        label.Text = (i + 1).ToString();
                        label.BackColor = Color.CornflowerBlue;
                        label.Size = new Size(17, 15);
                        label.Font = new Font("Microsoft Sans Serif", 6.5f);
                        label.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                        label.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                        label.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                        label.MouseHover += new EventHandler(neuronMouseOver);
                        label.MouseLeave += new EventHandler(neuronMouseOut);

                        this.variables.layer2.Add(neuron);
                        this.variables.layer2Lbl.Add(label);

                        variables.workSpaceMDIchild.Controls.Add(label);
                        variables.workSpaceMDIchild.Controls.Add(neuron);
                    }
                }
                for (int i = 0; i < variables.numberOutput; i++)
                {
                    PictureBox neuron = new PictureBox();

                    neuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
                    neuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
                    neuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
                    neuron.MouseHover += new EventHandler(neuronMouseOver);
                    neuron.MouseLeave += new EventHandler(neuronMouseOut);

                    neuron.Cursor = Cursors.NoMove2D;
                    neuron.Width = 21;
                    neuron.Height = 21;
                    neuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(false);
                    neuron.BackgroundImageLayout = ImageLayout.Stretch;
                    if (this.variables.numberLayer2 != 0)
                    {
                        neuron.Location = new Point(850, 40 + (i * 40) + 8);
                    }
                    else
                        neuron.Location = new Point(600, 40 + (i * 40) + 8);


                    ANNneuron neuro = new ANNneuron(i, 0, variables.numberInput, "output"); 
                    neuron.Tag = neuro;
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                    label.Cursor = Cursors.NoMove2D;
                    if (this.variables.numberLayer2 != 0)
                    {
                        label.Location = new Point(850 + (neuron.Width / 2) - 7, 40 + (i * 40) + 12);
                    }
                    else
                        label.Location = new Point(600 + (neuron.Width / 2) - 7, 40 + (i * 40) + 12);
                    
                    label.Tag = "output";
                    label.Text = (i + 1).ToString();
                    label.BackColor = Color.CornflowerBlue;
                    label.Size = new Size(17, 15);
                    label.Font = new Font("Microsoft Sans Serif", 6.5f);
                    label.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                    label.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                    label.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                    label.MouseHover += new EventHandler(neuronMouseOver);
                    label.MouseLeave += new EventHandler(neuronMouseOut);

                    this.variables.outputLbl.Add(label);
                    this.variables.output.Add(neuron);

                    variables.workSpaceMDIchild.Controls.Add(label);
                    variables.workSpaceMDIchild.Controls.Add(neuron);

                }
            }
            else
            {
                for (int i = 0; i < variables.numberInput; i++)
                {
                    PictureBox neuron = new PictureBox();
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                    neuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
                    neuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
                    neuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
                    neuron.MouseHover += new EventHandler(neuronMouseOver);
                    neuron.MouseLeave += new EventHandler(neuronMouseOut);

                    neuron.Cursor = Cursors.NoMove2D;
                    neuron.Width = 22;
                    neuron.Height = 22;
                    neuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
                    neuron.BackgroundImageLayout = ImageLayout.Stretch;
                    //uwaga sprawdzam potem Location.X zeby okreslic co za neuron jest kliknięty
                    neuron.Location = new Point(200, 40 + (i * 40) + 8);
                    InputNeuron neuro = new InputNeuron(i, 100, this.mainForm); //number, delay, main form
                    neuro.Fire += new InputNeuron.FiringHandler(this.neuronInteraction.fireInput);
                    neuron.Tag = neuro;

                    label.Cursor = Cursors.NoMove2D;
                    label.Location = new Point(200 + (neuron.Width / 2) - 8, 40 + (i * 40) + 12);
                    label.Tag = "input";
                    label.Text = (i + 1).ToString();
                    label.BackColor = Color.CornflowerBlue;
                    label.Size = new Size(17, 15);
                    label.Font = new Font("Microsoft Sans Serif", 6.5f);
                    label.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                    label.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                    label.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                    label.MouseHover += new EventHandler(neuronMouseOver);
                    label.MouseLeave += new EventHandler(neuronMouseOut);

                    this.variables.inputLbl.Add(label);
                    this.variables.inputNeurons.Add(neuron);

                    variables.workSpaceMDIchild.Controls.Add(label);
                    variables.workSpaceMDIchild.Controls.Add(neuron);

                }
                for (int i = 0; i < variables.numberLayer1; i++)
                {
                    PictureBox neuron = new PictureBox();

                    neuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
                    neuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
                    neuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
                    neuron.MouseHover += new EventHandler(neuronMouseOver);
                    neuron.MouseLeave += new EventHandler(neuronMouseOut);

                    neuron.Cursor = Cursors.NoMove2D;
                    neuron.Width = 40;
                    neuron.Height = 40;
                    neuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(true);
                    neuron.BackgroundImageLayout = ImageLayout.Stretch;
                    neuron.Location = new Point(350, 40 + (i * 55) + 9);
                    Neuron neuro = new Neuron(i, variables.numberInput, "Layer 1", this.mainForm); //number, number of inputs, layer name, main form
                    neuro.Fire += new Neuron.FiringHandler(this.neuronInteraction.fireLayer1);
                    neuron.Tag = neuro;
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                    label.Cursor = Cursors.NoMove2D;
                    label.Location = new Point(350 + (neuron.Width / 2) - 8, 40 + (i * 55) + 22);
                    label.Tag = "Layer 1";
                    label.Text = (i + 1).ToString();
                    label.BackColor = Color.CornflowerBlue;
                    label.Size = new Size(17, 15);
                    label.Font = new Font("Microsoft Sans Serif", 6.5f);
                    label.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                    label.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                    label.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                    label.MouseHover += new EventHandler(neuronMouseOver);
                    label.MouseLeave += new EventHandler(neuronMouseOut);

                    this.variables.layer1.Add(neuron);
                    this.variables.layer1Lbl.Add(label);

                    variables.workSpaceMDIchild.Controls.Add(label);
                    variables.workSpaceMDIchild.Controls.Add(neuron);
                }

                for (int i = 0; i < variables.numberOutput; i++)
                {
                    PictureBox neuron = new PictureBox();

                    neuron.MouseDown += new MouseEventHandler(Neuron_MouseDown);
                    neuron.MouseMove += new MouseEventHandler(Neuron_MouseMove);
                    neuron.MouseUp += new MouseEventHandler(Neuron_MouseUp);
                    neuron.MouseHover += new EventHandler(neuronMouseOver);
                    neuron.MouseLeave += new EventHandler(neuronMouseOut);

                    neuron.Cursor = Cursors.NoMove2D;
                    neuron.Width = 21;
                    neuron.Height = 21;
                    neuron.BackgroundImage = variables.workSpaceMDIchild.getNeuronImage(false);
                    neuron.BackgroundImageLayout = ImageLayout.Stretch;
                    neuron.Location = new Point(600, 40 + (i * 40) + 8);

                    Neuron neuro = new Neuron(i, variables.numberLayer1, "output", this.mainForm);
                    neuro.Fire += new Neuron.FiringHandler(this.neuronInteraction.fireOutput);
                    neuron.Tag = neuro;
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                    label.Cursor = Cursors.NoMove2D;
                    label.Location = new Point(600 + (neuron.Width / 2) - 7, 40 + (i * 40) + 12);
                    label.Tag = "output";
                    label.Text = (i + 1).ToString();
                    label.BackColor = Color.CornflowerBlue;
                    label.Size = new Size(17, 15);
                    label.Font = new Font("Microsoft Sans Serif", 6.5f);
                    label.MouseDown += new MouseEventHandler(neuronLBL_MouseDown);
                    label.MouseMove += new MouseEventHandler(neuronLBL_MouseMove);
                    label.MouseUp += new MouseEventHandler(neuronLBL_MouseUp);
                    label.MouseHover += new EventHandler(neuronMouseOver);
                    label.MouseLeave += new EventHandler(neuronMouseOut);

                    this.variables.outputLbl.Add(label);
                    this.variables.output.Add(neuron);

                    variables.workSpaceMDIchild.Controls.Add(label);
                    variables.workSpaceMDIchild.Controls.Add(neuron);

                }
            }

        }
        public void disposeNeurons()
        {
            this.variables.inputNeurons.Clear();
            this.variables.inputLbl.Clear();
            this.variables.layer1.Clear();
            this.variables.layer1Lbl.Clear();
            this.variables.layer2.Clear();
            this.variables.layer2Lbl.Clear();
            this.variables.output.Clear();
            this.variables.outputLbl.Clear();

            this.variables.numberInput = 0;
            this.variables.numberLayer1 = 0;
            this.variables.numberLayer2 = 0;
            this.variables.numberOutput = 0;
            this.mainForm.boxInputText = (0).ToString();
            this.mainForm.boxLayer1Text = (0).ToString();
            this.mainForm.boxLayer2Text = (0).ToString();
            this.mainForm.boxOutputText = (0).ToString();
        }

        public void changePSPcurve(Boolean PSPmode)
        {
            for (int i = 0; i < variables.numberLayer1; i++)
            {
                ((Neuron)variables.layer1[i].Tag).PSPmode = PSPmode;
            }
            for (int i = 0; i < variables.numberOutput; i++)
            {
                ((Neuron)variables.output[i].Tag).PSPmode = PSPmode;
            }
        }
        public void delayInitialization(Point inputRange, Point layerRange, double threshold)
        {
            Random rnd = new Random();
            if (inputRange.Y != 0)
            {
                for (int k = 0; k < variables.numberInput; k++)
                {
                    ((InputNeuron)variables.inputNeurons[k].Tag).initialize(rnd.Next(inputRange.Y - 1) + 1);
                }
            }
            for (int i = 0; i < variables.numberLayer1; i++)
            {
                ((Neuron)variables.layer1[i].Tag).threshold = threshold;
                for (int k = 0; k < variables.numberInput; k++)
                {
                    ((Neuron)variables.layer1[i].Tag).delays[k] = rnd.Next(layerRange.Y - 1) + 1; //  - 1 + 1 prevents from 0
                }

            }
            for (int i = 0; i < variables.numberOutput; i++)
            {
                ((Neuron)variables.output[i].Tag).threshold = threshold;
                for (int k = 0; k < variables.numberLayer1; k++)
                {
                    ((Neuron)variables.output[i].Tag).delays[k] = rnd.Next(layerRange.Y - 1) + 1;
                }
            }
        }
        public void weightInitialization(double weightRangeFrom, double weightRangeTo, bool allowNegative)
        {
            Random rnd = new Random();
            if (allowNegative == false)//without negative weights
            {
                for (int i = 0; i < variables.numberLayer1; i++)
                {
                    for (int k = 0; k < variables.numberInput; k++)
                    {
                        ((Neuron)variables.layer1[i].Tag).weights[k] = rnd.NextDouble() * weightRangeTo; // weights between 0 and 2
                    }
                }
                for (int i = 0; i < variables.numberOutput; i++)
                {
                    for (int k = 0; k < variables.numberLayer1; k++)
                    {
                        ((Neuron)variables.output[i].Tag).weights[k] = rnd.NextDouble() * weightRangeTo; // weights between 0 and 2
                    }
                }
            }
            else
            {
                for (int i = 0; i < variables.numberLayer1; i++)
                {
                    for (int k = 0; k < variables.numberInput; k++)
                    {
                        ((Neuron)variables.layer1[i].Tag).weights[k] = (rnd.NextDouble() * (2 * weightRangeTo)) + weightRangeFrom; // weights between 0 and 2
                    }
                }
                for (int i = 0; i < variables.numberOutput; i++)
                {
                    for (int k = 0; k < variables.numberLayer1; k++)
                    {
                        ((Neuron)variables.output[i].Tag).weights[k] = (rnd.NextDouble() * (2 * weightRangeTo)) + weightRangeFrom; // weights between 0 and 2
                    }
                }
                // (x * 4) - 2     -> <-2,2>
            }
        }

        public void createSynapses()
        {
            //synapses class:

            for (int i = 0; i < variables.numberInput; i++)
            {
                for (int j = 0; j < variables.numberLayer1; j++)
                {
                    this.variables.synapsesInLay1[i, j] = new Synapse(i, j, this.mainForm);
                    this.variables.synapsesInLay1[i, j].setDelay(((Neuron)variables.layer1[j].Tag).delays[i]);
                    this.variables.synapsesInLay1[i, j].SendSpike += new Synapse.FiringHandler(((Neuron)this.variables.layer1[j].Tag).identifySpike);
                }
            }
            //first layer to output layer
            for (int i = 0; i < variables.numberLayer1; i++)
            {
                for (int j = 0; j < variables.numberOutput; j++)
                {
                    this.variables.synapsesLay1Out[i, j] = new Synapse(i, j, this.mainForm);
                    this.variables.synapsesLay1Out[i, j].setDelay(((Neuron)variables.output[j].Tag).delays[i]);
                    this.variables.synapsesLay1Out[i, j].SendSpike += new Synapse.FiringHandler(((Neuron)this.variables.output[j].Tag).identifySpike);
                }
            }
        }
        public void dockDetailsWindow()
        {
            switch (flags.detailsWindowDockFlag)
            {
                case 0:
                    mainForm.detailsWindowVisibilityFirst = true;
                    break;
                default:
                    mainForm.detailsWindowVisibilityFirst = true;
                    break;
            }

        }
        public void createThreads()
        {
            this.variables.inputThreads = new Thread[this.variables.numberInput];
            this.variables.layer1Threads = new Thread[this.variables.numberLayer1];
            this.variables.outputThreads = new Thread[this.variables.numberOutput];
            this.variables.threadsInLay1Synapses = new Thread[this.variables.numberInput, this.variables.numberLayer1];
            this.variables.threadsLay1OutSynapses = new Thread[this.variables.numberLayer1, this.variables.numberOutput];
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                ThreadStart ts = new ThreadStart(((InputNeuron)this.variables.inputNeurons[i].Tag).LaunchInput);
                this.variables.inputThreads[i] = new Thread(ts);
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                ThreadStart ts = new ThreadStart(((Neuron)this.variables.layer1[i].Tag).LaunchNeuron);
                this.variables.layer1Threads[i] = new Thread(ts);
            }
            for (int i = 0; i < this.variables.numberOutput; i++)
            {
                ThreadStart ts = new ThreadStart(((Neuron)this.variables.output[i].Tag).LaunchNeuron);
                this.variables.outputThreads[i] = new Thread(ts);
            }
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                for (int j = 0; j < this.variables.numberLayer1; j++)
                {
                    ThreadStart ts = new ThreadStart(this.variables.synapsesInLay1[i, j].runSynapse);
                    this.variables.threadsInLay1Synapses[i, j] = new Thread(ts);
                }
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                for (int j = 0; j < this.variables.numberOutput; j++)
                {
                    ThreadStart ts = new ThreadStart(this.variables.synapsesLay1Out[i, j].runSynapse);
                    this.variables.threadsLay1OutSynapses[i, j] = new Thread(ts);
                }
            }
        }
        public void startNetworkForFileSimulation(int inputFiringTime)
        {
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                ((InputNeuron)this.variables.inputNeurons[i].Tag).initialize(inputFiringTime);
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
                this.variables.layer1Threads[i].Start();
            for (int i = 0; i < this.variables.numberOutput; i++)
                this.variables.outputThreads[i].Start();

            for (int i = 0; i < this.variables.numberInput; i++)
            {
                for (int j = 0; j < this.variables.numberLayer1; j++)
                {
                    this.variables.threadsInLay1Synapses[i, j].Start();
                }
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                for (int j = 0; j < this.variables.numberOutput; j++)
                {
                    this.variables.threadsLay1OutSynapses[i, j].Start();
                }
            }
        }
        public void stopNetoworkThreads()
        {
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                this.variables.inputThreads[i].Abort();
                ((InputNeuron)this.variables.inputNeurons[i].Tag).stopNeuron();
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                this.variables.layer1Threads[i].Abort();
                ((Neuron)this.variables.layer1[i].Tag).stopNeuron();
            }
            for (int i = 0; i < this.variables.numberOutput; i++)
            {
                this.variables.outputThreads[i].Abort();
                ((Neuron)this.variables.output[i].Tag).stopNeuron();
            }
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                for (int j = 0; j < this.variables.numberLayer1; j++)
                {
                    this.variables.threadsInLay1Synapses[i, j].Abort();
                    this.variables.synapsesInLay1[i, j].stopSynapse();
                }
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                for (int j = 0; j < this.variables.numberOutput; j++)
                {
                    this.variables.threadsLay1OutSynapses[i, j].Abort();
                    this.variables.synapsesLay1Out[i, j].stopSynapse();
                }
            }

        }
        public void resetClock()
        {
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                ((Neuron)this.variables.layer1[i].Tag).resetPotential();
            }
            for (int i = 0; i < this.variables.numberOutput; i++)
            {
                ((Neuron)this.variables.output[i].Tag).resetPotential();
            }
        }
        public void resetGraphs()
        {
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                ((InputNeuron)this.variables.inputNeurons[i].Tag).resetHistory();
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                ((Neuron)this.variables.layer1[i].Tag).resetPotential();
            }
            for (int i = 0; i < this.variables.numberOutput; i++)
            {
                ((Neuron)this.variables.output[i].Tag).resetPotential();
            }
        }

        public void changeIntervals(int intervalT)
        {
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                ((InputNeuron)this.variables.inputNeurons[i].Tag).changeInterval(intervalT);
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                ((Neuron)this.variables.layer1[i].Tag).changeInterval(intervalT);
            }
            for (int i = 0; i < this.variables.numberOutput; i++)
            {
                ((Neuron)this.variables.output[i].Tag).changeInterval(intervalT);
            }
        }

        public void newSTDP(double nParameter, double dauD, double tauP, Neuron postNeuron, string layer)
        {
            double newWeight = 0;

            if (layer.CompareTo("Layer 1") == 0)
            {
                double range = postNeuron.history[postNeuron.history.Count - 1] - tauP;
                for (int i = 0; i < this.variables.numberInput; i++)
                {
                    InputNeuron preNeuron = (InputNeuron)this.variables.inputNeurons[i].Tag;
                    for (int k = 0; k < preNeuron.history.Count; k++)
                    {
                        if ((preNeuron.history[k] >= range) && (preNeuron.history[k] <= postNeuron.history[postNeuron.history.Count - 1]))
                        {
                            newWeight = postNeuron.weights[i] + this.newSTDPFunction(nParameter, preNeuron.history[k], postNeuron.history[postNeuron.history.Count - 1], dauD, tauP);
                            if (newWeight > this.variables.maxWeightL)
                                postNeuron.weights[i] = this.variables.maxWeightL;
                            else if (newWeight < -this.variables.minWeightL)
                                postNeuron.weights[i] = this.variables.minWeightL;
                            else
                                postNeuron.weights[i] = newWeight;
                        }
                    }
                }

                range = postNeuron.history[postNeuron.history.Count - 1] + dauD;
                for (int i = 0; i < this.variables.numberInput; i++)
                {
                    InputNeuron preNeuron = (InputNeuron)this.variables.inputNeurons[i].Tag;
                    for (int k = 0; k < preNeuron.history.Count; k++)
                    {
                        if ((preNeuron.history[k] <= range) && (preNeuron.history[k] >= postNeuron.history[postNeuron.history.Count - 1]))
                        {
                            newWeight = postNeuron.weights[i] + this.newSTDPFunction(nParameter, preNeuron.history[k], postNeuron.history[postNeuron.history.Count - 1], dauD, tauP);
                            if (newWeight > this.variables.maxWeightL)
                                postNeuron.weights[i] = this.variables.maxWeightL;
                            else if (newWeight < -this.variables.minWeightL)
                                postNeuron.weights[i] = this.variables.minWeightL;
                            else
                                postNeuron.weights[i] = newWeight;
                        }
                    }
                }

            }

            else if (layer.CompareTo("output") == 0)
            {

                double range = postNeuron.history[postNeuron.history.Count - 1] - tauP;
                for (int i = 0; i < this.variables.numberLayer1; i++)
                {
                    Neuron preNeuron = (Neuron)this.variables.layer1[i].Tag;
                    for (int k = 0; k < preNeuron.history.Count; k++)
                    {
                        if ((preNeuron.history[k] >= range) && (preNeuron.history[k] <= postNeuron.history[postNeuron.history.Count - 1]))
                        {
                            newWeight = postNeuron.weights[i] + this.newSTDPFunction(nParameter, preNeuron.history[k], postNeuron.history[postNeuron.history.Count - 1], dauD, tauP);
                            if (newWeight > this.variables.maxWeightL)
                                postNeuron.weights[i] = this.variables.maxWeightL;
                            else if (newWeight < -this.variables.minWeightL)
                                postNeuron.weights[i] = this.variables.minWeightL;
                            else
                                postNeuron.weights[i] = newWeight;
                        }
                    }
                }

                range = postNeuron.history[postNeuron.history.Count - 1] + dauD;
                for (int i = 0; i < this.variables.numberLayer1; i++)
                {
                    Neuron preNeuron = (Neuron)this.variables.layer1[i].Tag;
                    for (int k = 0; k < preNeuron.history.Count; k++)
                    {
                        if ((preNeuron.history[k] <= range) && (preNeuron.history[k] >= postNeuron.history[postNeuron.history.Count - 1]))
                        {
                            newWeight = postNeuron.weights[i] + this.newSTDPFunction(nParameter, preNeuron.history[k], postNeuron.history[postNeuron.history.Count - 1], dauD, tauP);
                            if (newWeight > this.variables.maxWeightL)
                                postNeuron.weights[i] = this.variables.maxWeightL;
                            else if (newWeight < -this.variables.minWeightL)
                                postNeuron.weights[i] = this.variables.minWeightL;
                            else
                                postNeuron.weights[i] = newWeight;
                        }
                    }
                }
            }

        }
        public double newSTDPFunction(double nParameter, double timePre, double timePost, double dauD, double tauP)
        {
            double deltaT = timePre - timePost;
            double newWeight = 0;

            if ((0 <= deltaT) && (deltaT <= dauD))
            {
                newWeight = -nParameter * (dauD - deltaT);
            }
            else if ((-tauP <= deltaT) && (deltaT <= 0))
            {
                newWeight = nParameter * (tauP + deltaT);
            }
            else
            {
                newWeight = 0;
            }
            this.variables.sum = this.variables.sum + Math.Pow(newWeight,2);
            return newWeight;
        }
        public void learnWeights(int switcher)
        {
            if (switcher == 0)//memorize weigthts
            {
                for (int i = 0; i < this.variables.numberLayer1; i++)
                {
                    ((Neuron)this.variables.layer1[i].Tag).learnedWeights = ((Neuron)this.variables.layer1[i].Tag).weights;
                }
                for (int i = 0; i < this.variables.numberOutput; i++)
                {
                    ((Neuron)this.variables.output[i].Tag).learnedWeights = ((Neuron)this.variables.output[i].Tag).weights;
                }
            }
            else if (switcher == 1)//replace weights
            {
                for (int i = 0; i < this.variables.numberLayer1; i++)
                {
                    ((Neuron)this.variables.layer1[i].Tag).weights = ((Neuron)this.variables.layer1[i].Tag).learnedWeights;
                }
                for (int i = 0; i < this.variables.numberOutput; i++)
                {
                     ((Neuron)this.variables.output[i].Tag).weights = ((Neuron)this.variables.output[i].Tag).learnedWeights;
                }
            }
            else if (switcher == 2)//add weights to list
            {
                for (int i = 0; i < this.variables.numberLayer1; i++)
                {
                    ((Neuron)this.variables.layer1[i].Tag).weightHistory.Add( ((Neuron)this.variables.layer1[i].Tag).weights);
                }
                for (int i = 0; i < this.variables.numberOutput; i++)
                {
                    ((Neuron)this.variables.output[i].Tag).weightHistory.Add(((Neuron)this.variables.output[i].Tag).weights);
                }
            }
        }
        public void startNetworkWithTestMode()
        {
            for (int i = 0; i < this.variables.numberInput; i++)
                this.variables.inputThreads[i].Start();
            for (int i = 0; i < this.variables.numberLayer1; i++)
                this.variables.layer1Threads[i].Start();
            for (int i = 0; i < this.variables.numberOutput; i++)
                this.variables.outputThreads[i].Start();
            for (int i = 0; i < this.variables.numberInput; i++)
            {
                for (int j = 0; j < this.variables.numberLayer1; j++)
                {
                    this.variables.threadsInLay1Synapses[i, j].Start();
                }
            }
            for (int i = 0; i < this.variables.numberLayer1; i++)
            {
                for (int j = 0; j < this.variables.numberOutput; j++)
                {
                    this.variables.threadsLay1OutSynapses[i, j].Start();
                }
            }
        }

        public void updateSynapseDelay(string layer, int neuronNumber)
        {
            if (layer.CompareTo("Layer 1") == 0)
            {
                for (int i = 0; i < this.variables.numberInput; i++)
                    this.variables.synapsesInLay1[i, neuronNumber].setDelay(((Neuron)variables.layer1[neuronNumber].Tag).delays[i]);
            }
            if (layer.CompareTo("output") == 0)
            {
                for (int i = 0; i < this.variables.numberLayer1; i++)
                    this.variables.synapsesLay1Out[i, neuronNumber].setDelay(((Neuron)variables.output[neuronNumber].Tag).delays[i]);
            }
        }


        public int convertValueIntoTime(int maxTime, int value)
        {//maxTime wiekszy o 1;
            maxTime = maxTime + 1; //because when value is equal to maxTime given by user neuron has to fire with delay = 1
            int delay = 0;
            if (value < 0)
                delay = 0;
            else
                delay = maxTime - value;

            return delay;
        }

        public int[] gaussianReceptiveFields(int numberOfFields, double gamma, double max, double min, double valueToEncode, double maxTime)
        {
            int[] encodedTable = new int[numberOfFields];
            double y;
            double width;
            double center;
            double delay;

            for (int i = 0; i < numberOfFields; i++)
            {
                center = min + (((2 * i) - 3) / 2 * (max - min) / (numberOfFields - 2));
                width = (1 / gamma) * ((max - min) / (numberOfFields / 2));

                y = Math.Exp(-(Math.Pow(valueToEncode - center, 2) / Math.Pow(width, 2)) / 2);
                delay = (maxTime - (Math.Round(y, 4) * maxTime));
                if (delay <= (0 + (maxTime / 100)))
                    delay = 1;
                if (delay == maxTime)
                    delay = 0;   //neuron will not fire
                if (delay >= (maxTime - (maxTime / 100)))
                    delay = maxTime;
                encodedTable[i] = Convert.ToInt32(delay);
            }
            return encodedTable;
        }
    }
}
