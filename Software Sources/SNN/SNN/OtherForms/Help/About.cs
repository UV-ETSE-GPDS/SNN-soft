using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SNN.OtherForms.Help
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = "Spiking Neural Network Simulator - About";
            this.labelProductName.Text = "Spiking Neural Network Simulator";
            this.labelVersion.Text = "1.2.2 - released";
            this.labelCopyright.Text = "Valencia 2009/2010";
            this.labelCompanyName.Text = "Author: Adam Fijałkowski";
        }


        private void About_Load(object sender, EventArgs e)
        {
            this.textBoxDescription.Text = "Spiking Neural Network Simulator." + Environment.NewLine +
                                           "--------------------------------------------------------------------------------" + Environment.NewLine +
                                           "An application has been developed in cooperation between Universitat de Valencia(Spain) and University of Zielona Góra(Poland)." + Environment.NewLine +
                                           "It allows to design Spiking and Artificial(Traditional) Neural Networks in synthesizable VHDL. It also allows to simulate Spiking Neural Networks.";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
