namespace SNN.OtherForms
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.btnSplashOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioSplashOpen = new System.Windows.Forms.RadioButton();
            this.radioSplashNew = new System.Windows.Forms.RadioButton();
            this.listBoxSplashLastProjects = new System.Windows.Forms.ListBox();
            this.btnSplashBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSplashIntroduction = new System.Windows.Forms.GroupBox();
            this.radioSplashArtificMode = new System.Windows.Forms.RadioButton();
            this.radioSplashSpikingMode = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.lblSplashIntroduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSplashOK
            // 
            this.btnSplashOK.Location = new System.Drawing.Point(257, 281);
            this.btnSplashOK.Name = "btnSplashOK";
            this.btnSplashOK.Size = new System.Drawing.Size(75, 23);
            this.btnSplashOK.TabIndex = 0;
            this.btnSplashOK.Text = "OK";
            this.btnSplashOK.UseVisualStyleBackColor = true;
            this.btnSplashOK.Click += new System.EventHandler(this.btnSplashOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioSplashOpen
            // 
            this.radioSplashOpen.AutoSize = true;
            this.radioSplashOpen.Location = new System.Drawing.Point(78, 36);
            this.radioSplashOpen.Name = "radioSplashOpen";
            this.radioSplashOpen.Size = new System.Drawing.Size(133, 17);
            this.radioSplashOpen.TabIndex = 6;
            this.radioSplashOpen.Text = "Open Existing Network";
            this.radioSplashOpen.UseVisualStyleBackColor = true;
            this.radioSplashOpen.CheckedChanged += new System.EventHandler(this.radioSplashOpen_CheckedChanged);
            // 
            // radioSplashNew
            // 
            this.radioSplashNew.AutoSize = true;
            this.radioSplashNew.Checked = true;
            this.radioSplashNew.Location = new System.Drawing.Point(78, 159);
            this.radioSplashNew.Name = "radioSplashNew";
            this.radioSplashNew.Size = new System.Drawing.Size(129, 17);
            this.radioSplashNew.TabIndex = 7;
            this.radioSplashNew.TabStop = true;
            this.radioSplashNew.Text = "Design New Network:";
            this.radioSplashNew.UseVisualStyleBackColor = true;
            // 
            // listBoxSplashLastProjects
            // 
            this.listBoxSplashLastProjects.FormattingEnabled = true;
            this.listBoxSplashLastProjects.Location = new System.Drawing.Point(101, 59);
            this.listBoxSplashLastProjects.Name = "listBoxSplashLastProjects";
            this.listBoxSplashLastProjects.Size = new System.Drawing.Size(235, 82);
            this.listBoxSplashLastProjects.TabIndex = 8;
            this.listBoxSplashLastProjects.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBoxSplashLastProjects.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnSplashBrowse
            // 
            this.btnSplashBrowse.Enabled = false;
            this.btnSplashBrowse.Location = new System.Drawing.Point(342, 59);
            this.btnSplashBrowse.Name = "btnSplashBrowse";
            this.btnSplashBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSplashBrowse.TabIndex = 9;
            this.btnSplashBrowse.Text = "Browse...";
            this.btnSplashBrowse.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblSplashIntroduction
            // 
            this.lblSplashIntroduction.Controls.Add(this.radioSplashArtificMode);
            this.lblSplashIntroduction.Controls.Add(this.radioSplashSpikingMode);
            this.lblSplashIntroduction.Location = new System.Drawing.Point(101, 182);
            this.lblSplashIntroduction.Name = "lblSplashIntroduction";
            this.lblSplashIntroduction.Size = new System.Drawing.Size(328, 81);
            this.lblSplashIntroduction.TabIndex = 12;
            this.lblSplashIntroduction.TabStop = false;
            this.lblSplashIntroduction.Text = "Select Application mode:";
            // 
            // radioSplashArtificMode
            // 
            this.radioSplashArtificMode.AutoSize = true;
            this.radioSplashArtificMode.Location = new System.Drawing.Point(191, 36);
            this.radioSplashArtificMode.Name = "radioSplashArtificMode";
            this.radioSplashArtificMode.Size = new System.Drawing.Size(134, 17);
            this.radioSplashArtificMode.TabIndex = 4;
            this.radioSplashArtificMode.Text = "Artificial Network Mode";
            this.radioSplashArtificMode.UseVisualStyleBackColor = true;
            // 
            // radioSplashSpikingMode
            // 
            this.radioSplashSpikingMode.AutoSize = true;
            this.radioSplashSpikingMode.Checked = true;
            this.radioSplashSpikingMode.Location = new System.Drawing.Point(6, 36);
            this.radioSplashSpikingMode.Name = "radioSplashSpikingMode";
            this.radioSplashSpikingMode.Size = new System.Drawing.Size(171, 17);
            this.radioSplashSpikingMode.TabIndex = 3;
            this.radioSplashSpikingMode.TabStop = true;
            this.radioSplashSpikingMode.Text = "Spiking Network Mode(default)";
            this.radioSplashSpikingMode.UseVisualStyleBackColor = true;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 316);
            this.Controls.Add(this.lblSplashIntroduction);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSplashBrowse);
            this.Controls.Add(this.listBoxSplashLastProjects);
            this.Controls.Add(this.radioSplashNew);
            this.Controls.Add(this.radioSplashOpen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSplashOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.lblSplashIntroduction.ResumeLayout(false);
            this.lblSplashIntroduction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplashOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioSplashOpen;
        private System.Windows.Forms.RadioButton radioSplashNew;
        private System.Windows.Forms.ListBox listBoxSplashLastProjects;
        private System.Windows.Forms.Button btnSplashBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox lblSplashIntroduction;
        private System.Windows.Forms.RadioButton radioSplashSpikingMode;
        private System.Windows.Forms.RadioButton radioSplashArtificMode;
    }
}