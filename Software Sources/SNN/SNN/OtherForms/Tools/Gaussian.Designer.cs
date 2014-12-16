namespace SNN.OtherForms.Tools
{
    partial class Gaussian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gaussian));
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMaximumTime = new System.Windows.Forms.Label();
            this.maskedBoxMaxTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRangeTo = new System.Windows.Forms.Label();
            this.lblGammaParameter = new System.Windows.Forms.Label();
            this.maskedBoxGamma = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxMaximum = new System.Windows.Forms.MaskedTextBox();
            this.lblFieldsNumber = new System.Windows.Forms.Label();
            this.maskedBoxFieldsNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblRangeFrom = new System.Windows.Forms.Label();
            this.maskedBoxMinimum = new System.Windows.Forms.MaskedTextBox();
            this.lblValueRange = new System.Windows.Forms.Label();
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.maskedBoxValue = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gaussianGraph = new ZedGraph.ZedGraphControl();
            this.groupBoxParameters.SuspendLayout();
            this.groupBoxEncoding.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.button2);
            this.groupBoxParameters.Controls.Add(this.lblMaximumTime);
            this.groupBoxParameters.Controls.Add(this.maskedBoxMaxTime);
            this.groupBoxParameters.Controls.Add(this.label5);
            this.groupBoxParameters.Controls.Add(this.lblRangeTo);
            this.groupBoxParameters.Controls.Add(this.lblGammaParameter);
            this.groupBoxParameters.Controls.Add(this.maskedBoxGamma);
            this.groupBoxParameters.Controls.Add(this.maskedBoxMaximum);
            this.groupBoxParameters.Controls.Add(this.lblFieldsNumber);
            this.groupBoxParameters.Controls.Add(this.maskedBoxFieldsNumber);
            this.groupBoxParameters.Controls.Add(this.lblRangeFrom);
            this.groupBoxParameters.Controls.Add(this.maskedBoxMinimum);
            this.groupBoxParameters.Controls.Add(this.lblValueRange);
            this.groupBoxParameters.Location = new System.Drawing.Point(1, 336);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(354, 100);
            this.groupBoxParameters.TabIndex = 12;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parameters";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMaximumTime
            // 
            this.lblMaximumTime.AutoSize = true;
            this.lblMaximumTime.Location = new System.Drawing.Point(208, 44);
            this.lblMaximumTime.Name = "lblMaximumTime";
            this.lblMaximumTime.Size = new System.Drawing.Size(76, 13);
            this.lblMaximumTime.TabIndex = 15;
            this.lblMaximumTime.Text = "Maximum time:";
            // 
            // maskedBoxMaxTime
            // 
            this.maskedBoxMaxTime.Location = new System.Drawing.Point(293, 41);
            this.maskedBoxMaxTime.Mask = "000.0";
            this.maskedBoxMaxTime.Name = "maskedBoxMaxTime";
            this.maskedBoxMaxTime.PromptChar = ' ';
            this.maskedBoxMaxTime.Size = new System.Drawing.Size(48, 20);
            this.maskedBoxMaxTime.TabIndex = 4;
            this.maskedBoxMaxTime.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "> 2";
            // 
            // lblRangeTo
            // 
            this.lblRangeTo.AutoSize = true;
            this.lblRangeTo.Location = new System.Drawing.Point(220, 16);
            this.lblRangeTo.Name = "lblRangeTo";
            this.lblRangeTo.Size = new System.Drawing.Size(72, 13);
            this.lblRangeTo.TabIndex = 10;
            this.lblRangeTo.Text = "To(maximum):";
            // 
            // lblGammaParameter
            // 
            this.lblGammaParameter.AutoSize = true;
            this.lblGammaParameter.Location = new System.Drawing.Point(6, 41);
            this.lblGammaParameter.Name = "lblGammaParameter";
            this.lblGammaParameter.Size = new System.Drawing.Size(96, 13);
            this.lblGammaParameter.TabIndex = 13;
            this.lblGammaParameter.Text = "Gamma parameter:";
            // 
            // maskedBoxGamma
            // 
            this.maskedBoxGamma.Location = new System.Drawing.Point(108, 38);
            this.maskedBoxGamma.Mask = "0.00";
            this.maskedBoxGamma.Name = "maskedBoxGamma";
            this.maskedBoxGamma.PromptChar = ' ';
            this.maskedBoxGamma.Size = new System.Drawing.Size(31, 20);
            this.maskedBoxGamma.TabIndex = 3;
            this.maskedBoxGamma.Text = "15";
            // 
            // maskedBoxMaximum
            // 
            this.maskedBoxMaximum.Location = new System.Drawing.Point(293, 14);
            this.maskedBoxMaximum.Mask = "#000.0";
            this.maskedBoxMaximum.Name = "maskedBoxMaximum";
            this.maskedBoxMaximum.PromptChar = ' ';
            this.maskedBoxMaximum.Size = new System.Drawing.Size(52, 20);
            this.maskedBoxMaximum.TabIndex = 2;
            // 
            // lblFieldsNumber
            // 
            this.lblFieldsNumber.AutoSize = true;
            this.lblFieldsNumber.Location = new System.Drawing.Point(6, 74);
            this.lblFieldsNumber.Name = "lblFieldsNumber";
            this.lblFieldsNumber.Size = new System.Drawing.Size(133, 13);
            this.lblFieldsNumber.TabIndex = 4;
            this.lblFieldsNumber.Text = "Number of receptive fields:";
            // 
            // maskedBoxFieldsNumber
            // 
            this.maskedBoxFieldsNumber.Location = new System.Drawing.Point(145, 71);
            this.maskedBoxFieldsNumber.Mask = "000";
            this.maskedBoxFieldsNumber.Name = "maskedBoxFieldsNumber";
            this.maskedBoxFieldsNumber.PromptChar = ' ';
            this.maskedBoxFieldsNumber.Size = new System.Drawing.Size(61, 20);
            this.maskedBoxFieldsNumber.TabIndex = 5;
            // 
            // lblRangeFrom
            // 
            this.lblRangeFrom.AutoSize = true;
            this.lblRangeFrom.Location = new System.Drawing.Point(84, 16);
            this.lblRangeFrom.Name = "lblRangeFrom";
            this.lblRangeFrom.Size = new System.Drawing.Size(79, 13);
            this.lblRangeFrom.TabIndex = 8;
            this.lblRangeFrom.Text = "From(minimum):";
            // 
            // maskedBoxMinimum
            // 
            this.maskedBoxMinimum.Location = new System.Drawing.Point(165, 13);
            this.maskedBoxMinimum.Mask = "#000.0";
            this.maskedBoxMinimum.Name = "maskedBoxMinimum";
            this.maskedBoxMinimum.PromptChar = ' ';
            this.maskedBoxMinimum.Size = new System.Drawing.Size(52, 20);
            this.maskedBoxMinimum.TabIndex = 1;
            // 
            // lblValueRange
            // 
            this.lblValueRange.AutoSize = true;
            this.lblValueRange.Location = new System.Drawing.Point(6, 16);
            this.lblValueRange.Name = "lblValueRange";
            this.lblValueRange.Size = new System.Drawing.Size(67, 13);
            this.lblValueRange.TabIndex = 6;
            this.lblValueRange.Text = "Value range:";
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Controls.Add(this.lblResult);
            this.groupBoxEncoding.Controls.Add(this.richTextBox1);
            this.groupBoxEncoding.Controls.Add(this.lblValue);
            this.groupBoxEncoding.Controls.Add(this.maskedBoxValue);
            this.groupBoxEncoding.Controls.Add(this.button1);
            this.groupBoxEncoding.Location = new System.Drawing.Point(360, 336);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(375, 100);
            this.groupBoxEncoding.TabIndex = 13;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Encoding";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(94, 11);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Result:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(97, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 72);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(3, 20);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 13);
            this.lblValue.TabIndex = 14;
            this.lblValue.Text = "Value:";
            // 
            // maskedBoxValue
            // 
            this.maskedBoxValue.Location = new System.Drawing.Point(6, 41);
            this.maskedBoxValue.Mask = "#000.00";
            this.maskedBoxValue.Name = "maskedBoxValue";
            this.maskedBoxValue.PromptChar = ' ';
            this.maskedBoxValue.Size = new System.Drawing.Size(61, 20);
            this.maskedBoxValue.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gaussianGraph
            // 
            this.gaussianGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.gaussianGraph.Location = new System.Drawing.Point(0, 0);
            this.gaussianGraph.Name = "gaussianGraph";
            this.gaussianGraph.ScrollGrace = 0;
            this.gaussianGraph.ScrollMaxX = 0;
            this.gaussianGraph.ScrollMaxY = 0;
            this.gaussianGraph.ScrollMaxY2 = 0;
            this.gaussianGraph.ScrollMinX = 0;
            this.gaussianGraph.ScrollMinY = 0;
            this.gaussianGraph.ScrollMinY2 = 0;
            this.gaussianGraph.Size = new System.Drawing.Size(737, 330);
            this.gaussianGraph.TabIndex = 14;
            // 
            // Gaussian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 436);
            this.Controls.Add(this.gaussianGraph);
            this.Controls.Add(this.groupBoxEncoding);
            this.Controls.Add(this.groupBoxParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gaussian";
            this.Text = "Gaussian Receptive Fields";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMaximumTime;
        private System.Windows.Forms.MaskedTextBox maskedBoxMaxTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRangeTo;
        private System.Windows.Forms.Label lblGammaParameter;
        private System.Windows.Forms.MaskedTextBox maskedBoxGamma;
        private System.Windows.Forms.MaskedTextBox maskedBoxMaximum;
        private System.Windows.Forms.Label lblFieldsNumber;
        private System.Windows.Forms.MaskedTextBox maskedBoxFieldsNumber;
        private System.Windows.Forms.Label lblRangeFrom;
        private System.Windows.Forms.MaskedTextBox maskedBoxMinimum;
        private System.Windows.Forms.Label lblValueRange;
        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.MaskedTextBox maskedBoxValue;
        private System.Windows.Forms.Button button1;
        private ZedGraph.ZedGraphControl gaussianGraph;
    }
}