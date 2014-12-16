namespace SNN.OtherForms.Tools
{
    partial class Generator
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
            this.lblGeneratorTitle = new System.Windows.Forms.Label();
            this.textBoxGeneratePat = new System.Windows.Forms.TextBox();
            this.btnGenerateBrowse = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblGenerateProgress = new System.Windows.Forms.Label();
            this.btnGenerateExplore = new System.Windows.Forms.Button();
            this.btnGeberateClose = new System.Windows.Forms.Button();
            this.btnGenerateGo = new System.Windows.Forms.Button();
            this.folderBrowserLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblGeneratorTitle
            // 
            this.lblGeneratorTitle.AutoSize = true;
            this.lblGeneratorTitle.Location = new System.Drawing.Point(12, 9);
            this.lblGeneratorTitle.Name = "lblGeneratorTitle";
            this.lblGeneratorTitle.Size = new System.Drawing.Size(106, 13);
            this.lblGeneratorTitle.TabIndex = 0;
            this.lblGeneratorTitle.Text = "Generate to location:";
            // 
            // textBoxGeneratePat
            // 
            this.textBoxGeneratePat.Location = new System.Drawing.Point(38, 34);
            this.textBoxGeneratePat.Name = "textBoxGeneratePat";
            this.textBoxGeneratePat.Size = new System.Drawing.Size(442, 20);
            this.textBoxGeneratePat.TabIndex = 1;
            // 
            // btnGenerateBrowse
            // 
            this.btnGenerateBrowse.Location = new System.Drawing.Point(487, 33);
            this.btnGenerateBrowse.Name = "btnGenerateBrowse";
            this.btnGenerateBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateBrowse.TabIndex = 2;
            this.btnGenerateBrowse.Text = "Browse...";
            this.btnGenerateBrowse.UseVisualStyleBackColor = true;
            this.btnGenerateBrowse.Click += new System.EventHandler(this.btnGenerateBrowse_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 298);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(579, 19);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            // 
            // lblGenerateProgress
            // 
            this.lblGenerateProgress.AutoSize = true;
            this.lblGenerateProgress.Location = new System.Drawing.Point(14, 281);
            this.lblGenerateProgress.Name = "lblGenerateProgress";
            this.lblGenerateProgress.Size = new System.Drawing.Size(51, 13);
            this.lblGenerateProgress.TabIndex = 4;
            this.lblGenerateProgress.Text = "Progress:";
            // 
            // btnGenerateExplore
            // 
            this.btnGenerateExplore.Location = new System.Drawing.Point(365, 332);
            this.btnGenerateExplore.Name = "btnGenerateExplore";
            this.btnGenerateExplore.Size = new System.Drawing.Size(148, 23);
            this.btnGenerateExplore.TabIndex = 5;
            this.btnGenerateExplore.Text = "Explore Location";
            this.btnGenerateExplore.UseVisualStyleBackColor = true;
            this.btnGenerateExplore.Click += new System.EventHandler(this.btnGenerateExplore_Click);
            // 
            // btnGeberateClose
            // 
            this.btnGeberateClose.Location = new System.Drawing.Point(519, 332);
            this.btnGeberateClose.Name = "btnGeberateClose";
            this.btnGeberateClose.Size = new System.Drawing.Size(75, 23);
            this.btnGeberateClose.TabIndex = 6;
            this.btnGeberateClose.Text = "Close";
            this.btnGeberateClose.UseVisualStyleBackColor = true;
            this.btnGeberateClose.Click += new System.EventHandler(this.btnGeberateClose_Click);
            // 
            // btnGenerateGo
            // 
            this.btnGenerateGo.Location = new System.Drawing.Point(199, 332);
            this.btnGenerateGo.Name = "btnGenerateGo";
            this.btnGenerateGo.Size = new System.Drawing.Size(160, 23);
            this.btnGenerateGo.TabIndex = 7;
            this.btnGenerateGo.Text = "Generate Files";
            this.btnGenerateGo.UseVisualStyleBackColor = true;
            this.btnGenerateGo.Click += new System.EventHandler(this.btnGenerateGo_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 376);
            this.Controls.Add(this.btnGenerateGo);
            this.Controls.Add(this.btnGeberateClose);
            this.Controls.Add(this.btnGenerateExplore);
            this.Controls.Add(this.lblGenerateProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGenerateBrowse);
            this.Controls.Add(this.textBoxGeneratePat);
            this.Controls.Add(this.lblGeneratorTitle);
            this.Name = "Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneratorTitle;
        private System.Windows.Forms.TextBox textBoxGeneratePat;
        private System.Windows.Forms.Button btnGenerateBrowse;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblGenerateProgress;
        private System.Windows.Forms.Button btnGenerateExplore;
        private System.Windows.Forms.Button btnGeberateClose;
        private System.Windows.Forms.Button btnGenerateGo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserLocation;
    }
}