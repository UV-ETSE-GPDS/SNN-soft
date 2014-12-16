namespace SNN.OtherForms.Simulation
{
    partial class PotentialGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.ColoredGraph = new System.Windows.Forms.CheckBox();
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.zedGraphControl1.Size = new System.Drawing.Size(489, 287);
            this.zedGraphControl1.TabIndex = 2;
            // 
            // ColoredGraph
            // 
            this.ColoredGraph.AutoSize = true;
            this.ColoredGraph.BackColor = System.Drawing.Color.White;
            this.ColoredGraph.Location = new System.Drawing.Point(2, 2);
            this.ColoredGraph.Name = "ColoredGraph";
            this.ColoredGraph.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColoredGraph.Size = new System.Drawing.Size(50, 17);
            this.ColoredGraph.TabIndex = 3;
            this.ColoredGraph.Text = "Color";
            this.ColoredGraph.UseVisualStyleBackColor = false;
            this.ColoredGraph.CheckedChanged += new System.EventHandler(this.ColoredGraph_CheckedChanged);
            // 
            // timerChart
            // 
            this.timerChart.Interval = 1;
            this.timerChart.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // PotentialGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 287);
            this.Controls.Add(this.ColoredGraph);
            this.Controls.Add(this.zedGraphControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PotentialGraph";
            this.Text = "PotentialGraph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.CheckBox ColoredGraph;
        private System.Windows.Forms.Timer timerChart;
    }
}