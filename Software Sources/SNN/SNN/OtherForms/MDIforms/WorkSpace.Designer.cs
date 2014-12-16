namespace SNN.OtherForms.MDIforms
{
    partial class WorkSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSpace));
            this.neuronChecked = new System.Windows.Forms.PictureBox();
            this.BigNeuronShape = new System.Windows.Forms.PictureBox();
            this.contextAddNeuron = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextNeuronDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.neuronChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigNeuronShape)).BeginInit();
            this.SuspendLayout();
            // 
            // neuronChecked
            // 
            this.neuronChecked.ErrorImage = ((System.Drawing.Image)(resources.GetObject("neuronChecked.ErrorImage")));
            this.neuronChecked.Image = ((System.Drawing.Image)(resources.GetObject("neuronChecked.Image")));
            this.neuronChecked.Location = new System.Drawing.Point(12, 58);
            this.neuronChecked.Name = "neuronChecked";
            this.neuronChecked.Size = new System.Drawing.Size(40, 40);
            this.neuronChecked.TabIndex = 3;
            this.neuronChecked.TabStop = false;
            this.neuronChecked.Visible = false;
            // 
            // BigNeuronShape
            // 
            this.BigNeuronShape.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BigNeuronShape.ErrorImage")));
            this.BigNeuronShape.Image = ((System.Drawing.Image)(resources.GetObject("BigNeuronShape.Image")));
            this.BigNeuronShape.Location = new System.Drawing.Point(12, 12);
            this.BigNeuronShape.Name = "BigNeuronShape";
            this.BigNeuronShape.Size = new System.Drawing.Size(40, 40);
            this.BigNeuronShape.TabIndex = 2;
            this.BigNeuronShape.TabStop = false;
            this.BigNeuronShape.Visible = false;
            // 
            // contextAddNeuron
            // 
            this.contextAddNeuron.Name = "contextAddNeuron";
            this.contextAddNeuron.ShowImageMargin = false;
            this.contextAddNeuron.Size = new System.Drawing.Size(36, 4);
            this.contextAddNeuron.Text = "Add New Neuron";
            // 
            // contextNeuronDetails
            // 
            this.contextNeuronDetails.Name = "contextNeuronDetails";
            this.contextNeuronDetails.Size = new System.Drawing.Size(61, 4);
            // 
            // WorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 360);
            this.Controls.Add(this.neuronChecked);
            this.Controls.Add(this.BigNeuronShape);
            this.DoubleBuffered = true;
            this.Name = "WorkSpace";
            this.Text = "WorkSpace";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseUp);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkSpace_FormClosed);
            this.Leave += new System.EventHandler(this.WorkSpace_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkSpace_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.neuronChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigNeuronShape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox neuronChecked;
        private System.Windows.Forms.PictureBox BigNeuronShape;
        private System.Windows.Forms.ContextMenuStrip contextAddNeuron;
        private System.Windows.Forms.ContextMenuStrip contextNeuronDetails;
    }
}