using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SNN.Globals;
using SNN.Logic;

namespace SNN.OtherForms.Tools
{
    public partial class NetworkPlot : Form
    {
        Variables _variables;
        Flags _flags;
        Graphs gMethods;
        public NetworkPlot()
        {
            InitializeComponent();
        }

        public NetworkPlot(Variables globalVariables, Flags globalFlags)
        {
            InitializeComponent();
            this._variables = globalVariables;
            this._flags = globalFlags;
            this.gMethods = new Graphs(_variables, _flags);
        }

        private void NetworkPlot_Load(object sender, EventArgs e)
        {
            this._variables.maxHist = 0;
            this._variables.rateList.Clear();
            gMethods.CreateChart(this.zedGraphControl1, this._variables.inputNeurons, 0,Properties.Settings.Default.spikeBarColorInput);
            gMethods.CreateChart(this.zedGraphControl1, this._variables.layer1, 1, Properties.Settings.Default.spikeBarColorLay1);
            gMethods.CreateChart(this.zedGraphControl1, this._variables.output, 2, Properties.Settings.Default.spikeBarColorOutput);
            this.zedGraphControl1.GraphPane.Legend.IsVisible = true;
        }
    }
}
