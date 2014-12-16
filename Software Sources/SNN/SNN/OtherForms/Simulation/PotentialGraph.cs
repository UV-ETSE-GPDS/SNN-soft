using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SNN.Globals;
using SNN.StructureElements;

namespace SNN.OtherForms.Simulation
{
    public partial class PotentialGraph : Form
    {
        Variables glob = new Variables();
        Flags flags = new Flags();
        SNNmain mainForm;

        public PotentialGraph()
        {
            InitializeComponent();
        }
        public PotentialGraph(Variables _globals, Flags _flags, SNNmain _mainForm)
        {
            InitializeComponent();
            this.glob = _globals;
            this.flags = _flags;
            this.mainForm = _mainForm;
        }
        private void drawPotentialGraph()
        {
            int var1 = (int)this.mainForm.lblWhichLayerTag;

            this.zedGraphControl1.GraphPane.CurveList.Clear();

            if (this.mainForm.lblWhichLayerText.CompareTo("Layer 1") == 0)
            {
                for (int k = 0; k < ((Neuron)glob.layer1[var1].Tag).chartsList.Count; k++)
                {
                    MethodsLibrary.Methods.DrawGraph(zedGraphControl1, k, ((Neuron)glob.layer1[var1].Tag).chartsList[k], ((Neuron)glob.layer1[var1].Tag).spikeToInputs, ColoredGraph.Checked, this.glob.colorsList, this.glob.graphScale);
                }
            }
            if (this.mainForm.lblWhichLayerText.CompareTo("Layer 2") == 0)
            {

            }
            if (this.mainForm.lblWhichLayerText.CompareTo("output") == 0)
            {
                for (int k = 0; k < ((Neuron)glob.output[var1].Tag).chartsList.Count; k++)
                {
                    MethodsLibrary.Methods.DrawGraph(zedGraphControl1, k, ((Neuron)glob.output[var1].Tag).chartsList[k], ((Neuron)glob.output[var1].Tag).spikeToInputs, ColoredGraph.Checked, this.glob.colorsList, this.glob.graphScale);
                }
            }
            //this.zedGraphControl1.Refresh();
        }
        private void ColoredGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (this.flags.isSimulatedFlag == false)
            {
                this.drawPotentialGraph();
                //this.bgPotentialGraph.RunWorkerAsync();
                this.zedGraphControl1.Refresh();
            }
        }

        public void startGraph(int timeInterval)
        {
            this.timerChart.Interval = timeInterval;
            this.timerChart.Start();
        }
        public void stopGraph()
        {
            this.timerChart.Stop();
        }

        private void timerChart_Tick(object sender, EventArgs e)
        {
            this.drawPotentialGraph();
            this.zedGraphControl1.Refresh();
        }


    }
}
