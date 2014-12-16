using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SNN.LanguagePack;

namespace SNN.OtherForms.Tools
{
    public partial class StimuliCreator : Form
    {
        Messages appMessages = new Messages();
        
        PictureBox[,] codedCharacter;
        
        public StimuliCreator()
        {
            ControlsLanguage controlsLang = new ControlsLanguage();
            InitializeComponent();
            controlsLang.toogleLanguageStimuliCreator(this);
        }

        private void maskedBoxNumberOfEpochs_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.maskedBoxNumberOfEpochs.Text) < 1)
            {
                this.maskedBoxNumberOfEpochs.Text = "1";
                MessageBox.Show(this.appMessages.wrongEpochNumber[Properties.Settings.Default.applicationLanguage], this.appMessages.wringEpochNumberTitle[Properties.Settings.Default.applicationLanguage], MessageBoxButtons.OK);
            }
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
                this.lblX.Text = this.trackBarX.Value.ToString();
                this.panelArea.Controls.Clear();
                this.createSquares();
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
                this.lblY.Text = ((this.trackBarY.Maximum + 1) - this.trackBarY.Value).ToString();
                this.panelArea.Controls.Clear();
                this.createSquares();
        }

        private void StimuliCreator_Load(object sender, EventArgs e)
        {
            this.lblY.Text = "1";
            this.lblX.Text = "1";
            this.trackBarX.Value = 1;
            this.trackBarY.Value = 20;
            this.createSquares();

        }
        private void createSquares()
        {
            this.codedCharacter = new PictureBox[this.trackBarX.Value, (this.trackBarY.Maximum + 1) - this.trackBarY.Value];
            for (int i = 0; i < this.trackBarX.Value; i++)
            {
                for (int j = 0; j < (this.trackBarY.Maximum + 1) - this.trackBarY.Value; j++)
                {
                    this.codedCharacter[i, j] = new PictureBox();
                    this.codedCharacter[i, j].BackColor = Color.White;
                    this.codedCharacter[i, j].Click += new EventHandler(pictureSquare_Click);
                    this.codedCharacter[i, j].Tag = i.ToString() + (j * 3).ToString();
                    this.codedCharacter[i, j].Size = new Size(15, 15);
                    this.codedCharacter[i, j].Location = new Point(3 + (i * 17), 3 + (j * 17));
                    this.panelArea.Controls.Add(this.codedCharacter[i, j]);
                }
            }
        }

        private void pictureSquare_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.BackColor == Color.White)
            {
                pb.BackColor = Color.Black;
            }
            else if (pb.BackColor == Color.Black)
            {
                pb.BackColor = Color.White;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listBoxEpoch.Items.Clear();
            if (this.listBoxEpoch.Items.Count == 0)
            {
                this.trackBarX.Enabled = true;
                this.trackBarY.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(this.listBoxEpoch.SelectedIndex != -1)
                this.listBoxEpoch.Items.RemoveAt(this.listBoxEpoch.SelectedIndex);
            if (this.listBoxEpoch.Items.Count == 0)
            {
                this.trackBarX.Enabled = true;
                this.trackBarY.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string codedCharacter = "";
            for (int i = 0; i < this.trackBarX.Value; i++)
            {
                for (int j = 0; j < (this.trackBarY.Maximum + 1) - this.trackBarY.Value; j++)
                {
                    if (this.codedCharacter[i, j].BackColor == Color.Black)
                    {
                        codedCharacter = codedCharacter + "1";
                    }
                    else
                        codedCharacter = codedCharacter + "0";
                }
            }
            this.listBoxEpoch.Items.Add(codedCharacter);
            if (this.listBoxEpoch.Items.Count != 0)
            {
                this.trackBarX.Enabled = false;
                this.trackBarY.Enabled = false;
            }
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            saveStimulusFile.Filter = "TXT files (*.txt)|*.TXT|All files (*.*)|*.*";
            saveStimulusFile.FileName = "";
            saveStimulusFile.InitialDirectory = Properties.Settings.Default.pathStimuli;
            saveStimulusFile.Title = "Select TXT file:";

            saveStimulusFile.ShowDialog();
        }

        private void saveStimulusFile_FileOk(object sender, CancelEventArgs e)
        {
            TextWriter tw = new StreamWriter(this.saveStimulusFile.FileName);
          
            for (int i = 0; i < Convert.ToInt32(this.maskedBoxNumberOfEpochs.Text); i++)
            {
                for (int j = 0; j < this.listBoxEpoch.Items.Count; j++)
                {
                    if ((j == this.listBoxEpoch.Items.Count - 1) && ( i == Convert.ToInt32(this.maskedBoxNumberOfEpochs.Text) - 1))
                        tw.Write(this.listBoxEpoch.Items[j].ToString());
                    else
                        tw.WriteLine(this.listBoxEpoch.Items[j].ToString());
                }
            }

            tw.Close();
        }
    }
}
