namespace SNN.OtherForms.Tools
{
    partial class StimuliCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StimuliCreator));
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.panelArea = new System.Windows.Forms.Panel();
            this.pictureSquare = new System.Windows.Forms.PictureBox();
            this.lblOneEopchTitle = new System.Windows.Forms.Label();
            this.lblNumberOfEpochs = new System.Windows.Forms.Label();
            this.maskedBoxNumberOfEpochs = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBoxEpoch = new System.Windows.Forms.ListBox();
            this.saveStimulusFile = new System.Windows.Forms.SaveFileDialog();
            this.lblInputDimensionTitle = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(24, 1);
            this.trackBarX.Maximum = 20;
            this.trackBarX.Minimum = 1;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(347, 45);
            this.trackBarX.TabIndex = 0;
            this.trackBarX.Value = 1;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(2, 25);
            this.trackBarY.Maximum = 20;
            this.trackBarY.Minimum = 1;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarY.Size = new System.Drawing.Size(45, 347);
            this.trackBarY.TabIndex = 1;
            this.trackBarY.Value = 20;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // panelArea
            // 
            this.panelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArea.Location = new System.Drawing.Point(24, 25);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(347, 347);
            this.panelArea.TabIndex = 2;
            // 
            // pictureSquare
            // 
            this.pictureSquare.BackColor = System.Drawing.Color.Black;
            this.pictureSquare.Location = new System.Drawing.Point(753, 4);
            this.pictureSquare.Name = "pictureSquare";
            this.pictureSquare.Size = new System.Drawing.Size(15, 15);
            this.pictureSquare.TabIndex = 4;
            this.pictureSquare.TabStop = false;
            this.pictureSquare.Visible = false;
            this.pictureSquare.Click += new System.EventHandler(this.pictureSquare_Click);
            // 
            // lblOneEopchTitle
            // 
            this.lblOneEopchTitle.AutoSize = true;
            this.lblOneEopchTitle.Location = new System.Drawing.Point(442, 9);
            this.lblOneEopchTitle.Name = "lblOneEopchTitle";
            this.lblOneEopchTitle.Size = new System.Drawing.Size(131, 13);
            this.lblOneEopchTitle.TabIndex = 4;
            this.lblOneEopchTitle.Text = "Structure of Single Epoch:";
            // 
            // lblNumberOfEpochs
            // 
            this.lblNumberOfEpochs.AutoSize = true;
            this.lblNumberOfEpochs.Location = new System.Drawing.Point(442, 359);
            this.lblNumberOfEpochs.Name = "lblNumberOfEpochs";
            this.lblNumberOfEpochs.Size = new System.Drawing.Size(92, 13);
            this.lblNumberOfEpochs.TabIndex = 5;
            this.lblNumberOfEpochs.Text = "Numer of Epochs:";
            // 
            // maskedBoxNumberOfEpochs
            // 
            this.maskedBoxNumberOfEpochs.Location = new System.Drawing.Point(540, 356);
            this.maskedBoxNumberOfEpochs.Mask = "00000";
            this.maskedBoxNumberOfEpochs.Name = "maskedBoxNumberOfEpochs";
            this.maskedBoxNumberOfEpochs.Size = new System.Drawing.Size(77, 20);
            this.maskedBoxNumberOfEpochs.TabIndex = 6;
            this.maskedBoxNumberOfEpochs.Text = "1";
            this.maskedBoxNumberOfEpochs.ValidatingType = typeof(int);
            this.maskedBoxNumberOfEpochs.Leave += new System.EventHandler(this.maskedBoxNumberOfEpochs_Leave);
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.Location = new System.Drawing.Point(693, 356);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateFile.TabIndex = 7;
            this.btnGenerateFile.Text = "Generate";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(378, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(378, 59);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(378, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBoxEpoch
            // 
            this.listBoxEpoch.FormattingEnabled = true;
            this.listBoxEpoch.Location = new System.Drawing.Point(445, 25);
            this.listBoxEpoch.Name = "listBoxEpoch";
            this.listBoxEpoch.Size = new System.Drawing.Size(323, 316);
            this.listBoxEpoch.TabIndex = 11;
            // 
            // saveStimulusFile
            // 
            this.saveStimulusFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveStimulusFile_FileOk);
            // 
            // lblInputDimensionTitle
            // 
            this.lblInputDimensionTitle.AutoSize = true;
            this.lblInputDimensionTitle.Location = new System.Drawing.Point(21, 375);
            this.lblInputDimensionTitle.Name = "lblInputDimensionTitle";
            this.lblInputDimensionTitle.Size = new System.Drawing.Size(113, 13);
            this.lblInputDimensionTitle.TabIndex = 12;
            this.lblInputDimensionTitle.Text = "Character Dimensions:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(132, 376);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 13);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "XX";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(150, 376);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(12, 13);
            this.lblBy.TabIndex = 14;
            this.lblBy.Text = "x";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(157, 376);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 13);
            this.lblY.TabIndex = 15;
            this.lblY.Text = "YY";
            // 
            // StimuliCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 401);
            this.Controls.Add(this.pictureSquare);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblInputDimensionTitle);
            this.Controls.Add(this.listBoxEpoch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGenerateFile);
            this.Controls.Add(this.maskedBoxNumberOfEpochs);
            this.Controls.Add(this.lblNumberOfEpochs);
            this.Controls.Add(this.lblOneEopchTitle);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StimuliCreator";
            this.Text = "Input File Generator";
            this.Load += new System.EventHandler(this.StimuliCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSquare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.Panel panelArea;
        private System.Windows.Forms.PictureBox pictureSquare;
        private System.Windows.Forms.Label lblOneEopchTitle;
        private System.Windows.Forms.Label lblNumberOfEpochs;
        private System.Windows.Forms.MaskedTextBox maskedBoxNumberOfEpochs;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBoxEpoch;
        private System.Windows.Forms.SaveFileDialog saveStimulusFile;
        private System.Windows.Forms.Label lblInputDimensionTitle;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblY;
    }
}