using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SNN.Globals;

namespace SNN.OtherForms
{
    public partial class Splash : Form
    {
        Flags flags = new Flags();
        SNN.SNNmain _mainForm = new SNNmain();
        SNN.Logic.Methods _methods;

        public Splash()
        {
            InitializeComponent();
        }
        public Splash(Flags _flags,SNNmain _mainForm)
        {
            InitializeComponent();
            if (Properties.Settings.Default.languageChange == true)
            {
                SNN.LanguagePack.ControlsLanguage changeFormlanguage = new SNN.LanguagePack.ControlsLanguage();
                changeFormlanguage.toogleLanguageSplash(this);
            }

            this.flags = _flags;
            this._mainForm = _mainForm;
            _methods = new SNN.Logic.Methods(this._mainForm.globalVariablesOfMainForm, this.flags, this._mainForm);

            this.flags.languageIndexVar = Properties.Settings.Default.applicationLanguage;

            if (Properties.Settings.Default.firstLaunch == true)
            {
                Properties.Settings.Default.pathStructures = Application.StartupPath + "\\Networks\\";
                Properties.Settings.Default.pathStimuli = Application.StartupPath + "\\Stimulus\\";
                Properties.Settings.Default.pathOutput = Application.StartupPath + "\\Output\\";
                Properties.Settings.Default.pathHardware = Application.StartupPath + "\\Hardware\\";
                Properties.Settings.Default.pathAnnSrc = Application.StartupPath + "\\Hardware\\ANN\\src\\";
                Properties.Settings.Default.pathSnnSrc = Application.StartupPath + "\\Hardware\\SNN\\src\\";

                Properties.Settings.Default.firstLaunch = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnSplashOK_Click(object sender, EventArgs e)
        {
            if (radioSplashOpen.Checked == true)
            {
                _mainForm.newProject();
                MethodsLibrary.IniFiles.IniFileLight loadedIni = new MethodsLibrary.IniFiles.IniFileLight(this.listBoxSplashLastProjects.SelectedItem.ToString());
                _methods.loadStructure(loadedIni);
            }
            else
            {
                if (this.radioSplashSpikingMode.Checked == true)
                {
                    this.flags.applicationModeFlag = 0;
                }
                if (this.radioSplashArtificMode.Checked == true)
                {
                    this.flags.applicationModeFlag = 1;
                }
            }
            this.flags.languageIndexVar = Properties.Settings.Default.applicationLanguage;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioSplashOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSplashOpen.Checked == true)
            {
                lblSplashIntroduction.Enabled = false;
                radioSplashSpikingMode.Enabled = false;
                radioSplashArtificMode.Enabled = false;
                btnSplashBrowse.Enabled = true;
            }
            else
            {
                lblSplashIntroduction.Enabled = true;
                radioSplashSpikingMode.Enabled = true;
                radioSplashArtificMode.Enabled = true;
                btnSplashBrowse.Enabled = false;

            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioSplashOpen.Checked = true;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            radioSplashOpen.Checked = true;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.listBoxSplashLastProjects.Items.Clear();
            if (Properties.Settings.Default.listRecentProjects != null)
            {
                this.listBoxSplashLastProjects.BeginUpdate();

                for (int i = 0; i < Properties.Settings.Default.listRecentProjects.Count; i++)
                {
                    this.listBoxSplashLastProjects.Items.Add(Properties.Settings.Default.listRecentProjects[i]);
                }
                this.listBoxSplashLastProjects.EndUpdate();
            }
        }

    }
}
