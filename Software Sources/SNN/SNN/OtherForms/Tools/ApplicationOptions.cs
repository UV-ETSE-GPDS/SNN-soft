using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SNN.Globals;


namespace SNN.OtherForms.Tools
{
    public partial class ApplicationOptions : Form
    {
        Variables variables;
        Flags flags;
        SNNmain _mainForm;
        VHDLcoding vhdlVariables;
        SNN.LanguagePack.ControlsLanguage controlsLang = new SNN.LanguagePack.ControlsLanguage();
        SNN.LanguagePack.Messages _messages = new SNN.LanguagePack.Messages();

        public ApplicationOptions()
        {
            InitializeComponent();
        }
        public ApplicationOptions(Variables globalVariables, Flags globalFlags, SNNmain _mainForm, VHDLcoding _vhdlVariables)
        {
            SNN.LanguagePack.ControlsLanguage controlsLang = new SNN.LanguagePack.ControlsLanguage();

            this.variables = globalVariables;
            this.flags = globalFlags;
            this._mainForm = _mainForm;
            this.vhdlVariables = _vhdlVariables;
            InitializeComponent();

            this.tabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabMenu.ItemSize = new System.Drawing.Size(0, 1);

            MethodsLibrary.CustomControls.NiceLine line = new MethodsLibrary.CustomControls.NiceLine();
            line.Left = this.optionTree.Right + 5;
            line.Width = (this.Width - this.optionTree.Width) - 30;
            line.Top = this.optionTree.Bottom - 9;
            this.Controls.Add(line);

            controlsLang.toogleLanguageOptions(this);

        }
        private void btnClearRecent_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.listRecentProjects = null;
            Properties.Settings.Default.Save();
        }

        private void optionTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (optionTree.SelectedNode.Name)
            {
                case "NodeEnvirontmentGeneral":
                    tabMenu.SelectedIndex = 0;
                    break;
                case "NodeEnvironmentColors":
                    tabMenu.SelectedIndex = 1;
                    break;
                case "NodeEnvironmentPaths":
                    tabMenu.SelectedIndex = 2;
                    break;
                case "NodeEnvironmentOthers":
                    tabMenu.SelectedIndex = 3;
                    break;
                case "NodeSimulation":
                    tabMenu.SelectedIndex = 4;
                    break;
                case "NodeSimulationNeuronBehave":
                    tabMenu.SelectedIndex = 5;
                    break;
                case "NodeSimulationGraphsPlotting":
                    tabMenu.SelectedIndex = 6;
                    break;
                case "NodeVHDL":
                    tabMenu.SelectedIndex = 7;
                    break;
                case "NodeVHDLcoding":
                    tabMenu.SelectedIndex = 8;
                    break;
                default:
                    tabMenu.SelectedIndex = 0;
                    break;
            }

        }

        private void initializeGeneralOptions()
        {
            this.graphPlottingTabOptionsInit();
            this.comboBoxColorPickerStdBars.BackColor = Properties.Settings.Default.spikeBarColor;
            this.comboBoxColorPickerStdBars.DroppedDown = false;
            this.comboBoxColorPickerEntireInput.BackColor = Properties.Settings.Default.spikeBarColorInput;
            this.comboBoxColorPickerEntireInput.DroppedDown = false;
            this.comboBoxColorPickerEntireLayer1.BackColor = Properties.Settings.Default.spikeBarColorLay1;
            this.comboBoxColorPickerEntireLayer1.DroppedDown = false;
            this.comboBoxColorPickerEntireOutput.BackColor = Properties.Settings.Default.spikeBarColorOutput;
            this.comboBoxColorPickerEntireOutput.DroppedDown = false;


            this.textBoxOptionStimuliSNNPath.Text = Properties.Settings.Default.pathStructures;
            this.textBoxOptionStimuliSrcPath.Text = Properties.Settings.Default.pathStimuli;
            this.textBoxOptionStimuliOutputPath.Text = Properties.Settings.Default.pathOutput;
            this.textBoxOptionStimuliHardwarePath.Text = Properties.Settings.Default.pathHardware;
            this.textBoxOptionAnnHardwareSrcPath.Text = Properties.Settings.Default.pathAnnSrc;
            this.textBoxOptionSnnHardwareSrcPath.Text = Properties.Settings.Default.pathSnnSrc;

            this.folderBrowserStructures.ShowNewFolderButton = true;
            this.folderBrowserStructures.SelectedPath = this.textBoxOptionStimuliSNNPath.Text;

            this.folderBrowserStimuli.ShowNewFolderButton = true;
            this.folderBrowserStimuli.SelectedPath = this.textBoxOptionStimuliSrcPath.Text;

            this.folderBrowserOutput.ShowNewFolderButton = true;
            this.folderBrowserOutput.SelectedPath = this.textBoxOptionStimuliOutputPath.Text;

            this.comboBoxLanguage.SelectedIndex = this.flags.languageIndexVar;
            this.maskedBoxMaxRecent.Text = Properties.Settings.Default.howManyRecent.ToString();

            this.checkBoxHeaderAdd.Checked = false;
            this.richTextHeader.Enabled = false;
            this.richTextHeader.ForeColor = Color.Green;
            this.richTextHeader.Text = "";
            this.richTextHeader.Text = this.richTextHeader.Text + "-------------------------------------------------------------\n";
            this.richTextHeader.Text = this.richTextHeader.Text + "--\n";
            this.richTextHeader.Text = this.richTextHeader.Text + "--\n";
            this.richTextHeader.Text = this.richTextHeader.Text + "--\n";
            this.richTextHeader.Text = this.richTextHeader.Text + "--\n";
            this.richTextHeader.Text = this.richTextHeader.Text + "--\n";
            this.richTextHeader.Text = this.richTextHeader.Text + "-------------------------------------------------------------\n";

            this.maskedBoxCodeBits.Text = this.vhdlVariables.bitsCodingValue.ToString();
            this.maskedBoxCodeRangeFrom.Text = this.vhdlVariables.rangeFromValue.ToString();
            this.maskedBoxCodeRangeTo.Text = this.vhdlVariables.rangeToValue.ToString();
            this.maskedBoxWordLength.Text = this.vhdlVariables.wordLenghtValue.ToString();
            this.maskedTextFreqDiv.Text = this.vhdlVariables.freqDivValue.ToString();
            this.maskedTextPSPduration.Text = this.vhdlVariables.pspDurationValue.ToString();
            this.maskedTextPSPstep.Text = this.vhdlVariables.pspStepValue.ToString();
            this.maskedTextRefractoryDuration.Text = this.vhdlVariables.refractoryDurationValue.ToString();
            if (this.vhdlVariables.pspRealValue == false)
                this.radioIdealPSPcode.Checked = true;
            else
                this.radioRealPSPcode.Checked = true;
        }
       
        private void ApplicationOptions_Load(object sender, EventArgs e)
        {
            this.initializeGeneralOptions();
        }

        private void comboBoxColorPickerStdBars_MouseDown(object sender, MouseEventArgs e)
        {
            if( this.colorDialogStdBar.ShowDialog() != DialogResult.Cancel)
            {
                this.comboBoxColorPickerStdBars.BackColor = this.colorDialogStdBar.Color;
            }
        }

        private void comboBoxColorPickerEntireInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.colorDialogEntireActiv.ShowDialog() != DialogResult.Cancel)
            {
                this.comboBoxColorPickerEntireInput.BackColor = this.colorDialogEntireActiv.Color;
            }
        }

        private void comboBoxColorPickerEntireLayer1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.colorDialogEntireActiv.ShowDialog() != DialogResult.Cancel)
            {
                this.comboBoxColorPickerEntireLayer1.BackColor = this.colorDialogEntireActiv.Color;
            }
        }

        private void comboBoxColorPickerEntireOutput_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.colorDialogEntireActiv.ShowDialog() != DialogResult.Cancel)
            {
                this.comboBoxColorPickerEntireOutput.BackColor = this.colorDialogEntireActiv.Color;
            }
        }

        private void btnOptionsOK_Click(object sender, EventArgs e)
        {
            if (this.checkBoxHeaderAdd.Checked == true)
                this.vhdlVariables.addHeaderValue = true;
            else
                this.vhdlVariables.addHeaderValue = false;
            this.vhdlVariables.headerValue = this.richTextHeader.Text;
            this.vhdlVariables.bitsCodingValue = Convert.ToInt32(this.maskedBoxCodeBits.Text);
            this.vhdlVariables.rangeFromValue = Convert.ToInt32(this.maskedBoxCodeRangeFrom.Text);
            this.vhdlVariables.rangeToValue = Convert.ToInt32(this.maskedBoxCodeRangeTo.Text);
            this.vhdlVariables.wordLenghtValue = Convert.ToInt32(this.maskedBoxWordLength.Text);
            this.vhdlVariables.freqDivValue = Convert.ToInt32(this.maskedTextFreqDiv.Text);
            this.vhdlVariables.pspDurationValue = Convert.ToInt32(this.maskedTextPSPduration.Text);
            this.vhdlVariables.pspStepValue = Convert.ToDouble(this.maskedTextPSPstep.Text);
            this.vhdlVariables.refractoryDurationValue = Convert.ToInt32(this.maskedTextRefractoryDuration.Text);
            if (this.radioIdealPSPcode.Checked == true)
                this.vhdlVariables.pspRealValue = true;
            
            
            Properties.Settings.Default.applicationLanguage = this.comboBoxLanguage.SelectedIndex;
            this.flags.languageIndexVar = this.comboBoxLanguage.SelectedIndex;

            if (this.variables.languageChange == true)
            {
                SNN.LanguagePack.ControlsLanguage changeMainLang = new SNN.LanguagePack.ControlsLanguage();
                changeMainLang.toogleLanguageMainForm(_mainForm);
                Properties.Settings.Default.languageChange = true;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnOptionsCancel_Click(object sender, EventArgs e)
        {
            this.variables.languageChange = false;
            this.Close();
        }

        private void btnStimuliSNNPath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserStructures.ShowDialog() != DialogResult.Cancel)
            {
                this.textBoxOptionStimuliSNNPath.Text = this.folderBrowserStructures.SelectedPath + "\\";
            }
        }

        private void btnStimuliSrcPath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserStimuli.ShowDialog() != DialogResult.Cancel)
            {
                this.textBoxOptionStimuliSrcPath.Text = this.folderBrowserStimuli.SelectedPath + "\\";
            }
        }

        private void btnStimuliOutputPath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserOutput.ShowDialog() != DialogResult.Cancel)
            {
                this.textBoxOptionStimuliOutputPath.Text = this.folderBrowserOutput.SelectedPath + "\\";
            }
        }

        private void btnRestoreDefault_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(_messages.restoreDefaultWarning[Properties.Settings.Default.applicationLanguage], _messages.restoreDefaultWarningTitle[Properties.Settings.Default.applicationLanguage], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (dr)
            { 
                case DialogResult.Yes:
                    this.restoreDefault();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void restoreDefault()
        {

            Properties.Settings.Default.firstLaunch = true;
            this.initializeGeneralOptions();
        }

        private void btnStimuliHardwarePath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserOutput.ShowDialog() != DialogResult.Cancel)
            {
                this.textBoxOptionStimuliHardwarePath.Text = this.folderBrowserOutput.SelectedPath + "\\";
            }
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.variables.languageChange = true;
            this.flags.languageIndexVar = comboBoxLanguage.SelectedIndex;
            this.controlsLang.toogleLanguageOptions(this, comboBoxLanguage.SelectedIndex);
        }

        private void checkBoxHeaderAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHeaderAdd.Checked == true)
            {
                this.richTextHeader.Enabled = true;
            }
            else
            {
                this.richTextHeader.Enabled = false;
            }
        }

        private void btnHardwareAnn_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserOutput.ShowDialog() != DialogResult.Cancel)
            {
                this.textBoxOptionAnnHardwareSrcPath.Text = this.folderBrowserOutput.SelectedPath + "\\";
            }
        }

        private void btnHardwareSnn_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserOutput.ShowDialog() != DialogResult.Cancel)
            {
                this.textBoxOptionSnnHardwareSrcPath.Text = this.folderBrowserOutput.SelectedPath + "\\";
            }
        }

        private void radioIdealPSPcode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIdealPSPcode.Checked == true)
            {
                this.vhdlVariables.pspRealValue = false;
            }
        }

        private void radioRealPSPcode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRealPSPcode.Checked == true)
            {
                this.vhdlVariables.pspRealValue = true;
            }
        }

        private void checkBoxMoveMembranePotential_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMoveMembranePotential.Checked == true)
            {
                this.lblMoveGraph.Enabled = true;
                this.maskedBoxMoveMembranePotential.Enabled = true;
            }
            else
            {
                this.lblMoveGraph.Enabled = false;
                this.maskedBoxMoveMembranePotential.Enabled = false;
                this.maskedBoxMoveMembranePotential.Text = "0";
            }
        }

        private void graphPlottingTabOptions()
        {
            this.variables.graphScale = Convert.ToInt32(this.maskedBoxMoveMembranePotential.Text);
        }
        private void graphPlottingTabOptionsInit()
        {
            if (this.variables.graphScale == 0)
            {
                this.lblMoveGraph.Enabled = false;
                this.maskedBoxMoveMembranePotential.Enabled = false;
                this.maskedBoxMoveMembranePotential.Text = "0";
            }
        }

    }
}
