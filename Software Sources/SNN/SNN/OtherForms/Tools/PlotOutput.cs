﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SNN.Globals;
using SNN.Logic;

namespace SNN.OtherForms.Tools
{
    public partial class PlotOutput : Form
    {
        Variables _variables;
        Flags _flags;
        Graphs gMethods;
     
        public PlotOutput()
        {
            InitializeComponent();
        }
        public PlotOutput(Variables globalVariables, Flags globalFlags)
        {
            InitializeComponent();
            this._variables = globalVariables;
            this._flags = globalFlags;
            this.gMethods = new Graphs(_variables, _flags);
        }

        private void PlotOutput_Load(object sender, EventArgs e)
        {
            this._variables.maxHist = 0;
            this._variables.rateList.Clear();
            gMethods.CreateChart(this.zedGraphControl1, this._variables.output, 2, Properties.Settings.Default.spikeBarColor);
            gMethods.CreateChartBottom(this.zedGraphControl2);
        }
    }
}
