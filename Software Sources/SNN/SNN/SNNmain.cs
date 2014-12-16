using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SNN.Globals;
using SNN.OtherForms;
using SNN.OtherForms.MDIforms;
using SNN.OtherForms.Simulation;
using SNN.LanguagePack;
using SNN.StructureElements;

namespace SNN
{
    public partial class SNNmain : Form
    {
        #region ClassGlobals

        Variables glob = new Variables();
        Flags flags = new Flags();
        Messages appMessages = new Messages();
        Logic.Methods methods;
        VHDLcoding vdhlVariables = new VHDLcoding();
        int memTab;          //for memorizing 

        #endregion ClassGlobals

        public SNNmain()
        {
            InitializeComponent();
            this.methods = new SNN.Logic.Methods(glob, flags, this);
        }
        
        private void SNNmain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.languageChange == true)
            {
                SNN.LanguagePack.ControlsLanguage controlsLang = new ControlsLanguage();
                controlsLang.toogleLanguageMainForm(this);
            }
            this.mainFormInit();
        }

        private void mainFormInit()
        {
            this.WindowState = FormWindowState.Maximized;
            Splash splashForm = new Splash(this.flags,this);
            splashForm.ShowDialog();
            if (this.flags.applicationModeFlag == 0) //SNN Mode
            {
                this.menuStripModeSNN.Checked = true;
                this.menuStripModeANN.Checked = false;
                this.Text = this.appMessages.networkName[this.flags.languageIndexVar] + " - " + this.appMessages.spikingModeName[this.flags.languageIndexVar];
                this.radioButton2.Enabled = false;
            }
            if (this.flags.applicationModeFlag == 1) //ANN Mode
            {
                this.menuStripModeSNN.Checked = false;
                this.menuStripModeANN.Checked = true;
                this.Text = this.appMessages.networkName[this.flags.languageIndexVar] + " - " + this.appMessages.artificialModeName[this.flags.languageIndexVar];
                this.radioButton2.Enabled = true;
            }

            {//initialize toolboxes' position
                this.flags.memXDetailFlag = (this.Width - this.detailsWindow.Width) - 20;
                this.flags.memYDetailFlag = 52;
                this.flags.memXSimulationFlag = this.flags.memXDetailFlag;
                this.flags.memYSimulationFlag = this.flags.memYDetailFlag + this.detailsWindow.Height;

                this.flags.memXInitializationFlag = this.flags.memXEditorFlag;
                this.flags.memYInitializationFlag = this.flags.memYEditorFlag + this.designEditor.Height;

                this.detailsWindow.Top = this.flags.memYDetailFlag;
                this.detailsWindow.Left = this.flags.memXDetailFlag;

                this.simulationWindow.Top = this.flags.memYInitializationFlag;
                this.simulationWindow.Left = this.flags.memXInitializationFlag;

                this.simInOutWindow.Top = this.flags.memYSimulationFlag;
                this.simInOutWindow.Left = this.flags.memXSimulationFlag;

                this.designEditor.Location = new Point(this.flags.memXEditorFlag, this.flags.memYEditorFlag);
            }
            this.tabSim.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSim.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSim.ItemSize = new System.Drawing.Size(0, 1);
            this.tabLearning.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabLearning.ItemSize = new System.Drawing.Size(0, 1);
            this.tabSimulateInOut.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSimulateInOut.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSimulateInOut.ItemSize = new System.Drawing.Size(0, 1);

            this.glob.potentialGraphMDIchild = new PotentialGraph(glob, flags, this);
            this.glob.potentialGraphMDIchild.MdiParent = this;
            this.glob.potentialGraphMDIchild.WindowState = FormWindowState.Maximized;

            this.menuStripRecent.DropDownItems.Clear();
            if(Properties.Settings.Default.listRecentProjects == null)
            {
                this.menuStripRecent.Enabled = false;
            }
            else
            {
                foreach (string str in Properties.Settings.Default.listRecentProjects)
                {
                    
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = str;
                    item.Click += new EventHandler(item_Click);
                    this.menuStripRecent.DropDownItems.Add(item);
                }
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            ToolStripItem clickedItem = (ToolStripItem)sender;
            System.Collections.Specialized.StringCollection lista = new System.Collections.Specialized.StringCollection();

            lista = Properties.Settings.Default.listRecentProjects;
            lista.Remove(clickedItem.Text);
            lista.Insert(0,clickedItem.Text);

            Properties.Settings.Default.listRecentProjects = lista;
            Properties.Settings.Default.Save();
            this.newProject();
            MethodsLibrary.IniFiles.IniFileLight loadedIni = new MethodsLibrary.IniFiles.IniFileLight(clickedItem.Text);
            this.methods.loadStructure(loadedIni);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblLayer2Nr.Visible = false;
                boxLayer2.Visible = false;
            }
            else
            {
                lblLayer2Nr.Visible = true;
                boxLayer2.Visible = true;
            }
        }

        #region toolBoxesDesign

        private void designEditorClose_Click(object sender, EventArgs e)
        {
            this.designEditor.Visible = false;
            menuStripStructureToolBox.Checked = false;
        }

        private void detailsWindowClose_Click(object sender, EventArgs e)
        {
            this.detailsWindow.Visible = false;
            this.panelInputs.Visible = false;
            menuStripWindowDetails.Checked = false;
        }

        private void simulationWindowClose_Click(object sender, EventArgs e)
        {
            this.simulationWindow.Visible = false;
            menuStripWindowInitialization.Checked = false;
        }

        private void simInOutWindowClose_Click(object sender, EventArgs e)
        {
            this.finishSimulation();
        }

        private void designEditorClose_MouseHover(object sender, EventArgs e)
        {
            this.designEditorClose.Image = this.designEditorClose.InitialImage;
        }

        private void designEditorClose_MouseLeave(object sender, EventArgs e)
        {
            this.designEditorClose.Image = this.designEditorClose.ErrorImage;
        }

        private void detailsWindowClose_MouseHover(object sender, EventArgs e)
        {
            this.detailsWindowClose.Image = this.detailsWindowClose.InitialImage;
        }

        private void detailsWindowClose_MouseLeave(object sender, EventArgs e)
        {
            this.detailsWindowClose.Image = this.detailsWindowClose.ErrorImage;
        }

        private void simInOutWindowClose_MouseLeave(object sender, EventArgs e)
        {
            this.simInOutWindowClose.Image = this.simInOutWindowClose.ErrorImage;
        }

        private void simInOutWindowClose_MouseHover(object sender, EventArgs e)
        {
            this.simInOutWindowClose.Image = this.simInOutWindowClose.InitialImage;
        }

        private void simulationWindowClose_MouseHover(object sender, EventArgs e)
        {
            this.simulationWindowClose.Image = this.simulationWindowClose.InitialImage;
        }

        private void simulationWindowClose_MouseLeave(object sender, EventArgs e)
        {
            this.simulationWindowClose.Image = this.simulationWindowClose.ErrorImage;
        }

        private void detailsWindowHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 1;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void detailsWindowHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 1)
            {
                detailsWindow.Left = detailsWindow.Left + e.X - flags.memXwindowFlag;
                detailsWindow.Top = detailsWindow.Top + e.Y - flags.memYwindowFlag;

                panelInputs.Left = panelInputs.Left + e.X - flags.memXwindowFlag;
                panelInputs.Top = panelInputs.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void detailsWindowHeader_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXDetailFlag = this.detailsWindow.Left;
            this.flags.memYDetailFlag = this.detailsWindow.Top;
        }

        private void detailsWindowHeaderTitle_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 1;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void detailsWindowHeaderTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 1)
            {
                detailsWindow.Left = detailsWindow.Left + e.X - flags.memXwindowFlag;
                detailsWindow.Top = detailsWindow.Top + e.Y - flags.memYwindowFlag;

                panelInputs.Left = panelInputs.Left + e.X - flags.memXwindowFlag;
                panelInputs.Top = panelInputs.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void detailsWindowHeaderTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXDetailFlag = this.detailsWindow.Left;
            this.flags.memYDetailFlag = this.detailsWindow.Top;
        }

        private void designEditorHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 2;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void designEditorHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 2)
            {
                designEditor.Left = designEditor.Left + e.X - flags.memXwindowFlag;
                designEditor.Top = designEditor.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void designEditorHeader_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXEditorFlag = this.designEditor.Left;
            this.flags.memYEditorFlag = this.designEditor.Top;
        }

        private void designEditorHeaderTitle_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 3;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void designEditorHeaderTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 3)
            {
                designEditor.Left = designEditor.Left + e.X - flags.memXwindowFlag;
                designEditor.Top = designEditor.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void designEditorHeaderTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXEditorFlag = this.designEditor.Left;
            this.flags.memYEditorFlag = this.designEditor.Top;
        }

        private void simInOutWindowHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 4;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void simInOutWindowHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 4)
            {
                simInOutWindow.Left = simInOutWindow.Left + e.X - flags.memXwindowFlag;
                simInOutWindow.Top = simInOutWindow.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void simInOutWindowHeader_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXSimulationFlag = this.simInOutWindow.Left;
            this.flags.memYSimulationFlag = this.simInOutWindow.Top;
        }

        private void simInOutWindowTitle_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 4;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void simInOutWindowTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 4)
            {
                simInOutWindow.Left = simInOutWindow.Left + e.X - flags.memXwindowFlag;
                simInOutWindow.Top = simInOutWindow.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void simInOutWindowTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXSimulationFlag = this.simInOutWindow.Left;
            this.flags.memYSimulationFlag = this.simInOutWindow.Top;
        }

        private void simulationWindowHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 5;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void simulationWindowHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 5)
            {
                simulationWindow.Left = simulationWindow.Left + e.X - flags.memXwindowFlag;
                simulationWindow.Top = simulationWindow.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void simulationWindowHeader_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXInitializationFlag = this.simulationWindow.Left;
            this.flags.memYInitializationFlag = this.simulationWindow.Top;
        }        

        private void simulationWindowHeaderTitle_MouseDown(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 5;
            this.flags.memXwindowFlag = e.X;
            this.flags.memYwindowFlag = e.Y;
        }

        private void simulationWindowHeaderTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.flags.panelWindowMoveFlag == 5)
            {
                simulationWindow.Left = simulationWindow.Left + e.X - flags.memXwindowFlag;
                simulationWindow.Top = simulationWindow.Top + e.Y - flags.memYwindowFlag;
            }
        }

        private void simulationWindowHeaderTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.flags.panelWindowMoveFlag = 0;
            this.flags.memXInitializationFlag = this.simulationWindow.Left;
            this.flags.memYInitializationFlag = this.simulationWindow.Top;
        }

        #endregion toolBoxesDesign

        #region menuStripLogic

        private void menuStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStripStructureToolBox_Click(object sender, EventArgs e)
        {
            if (menuStripStructureToolBox.Checked == true)
            {
                menuStripStructureToolBox.Checked = false;
                this.designEditor.Visible = false;
            }
            else
            {
                menuStripStructureToolBox.Checked = true;
                this.designEditor.Visible = true;
            }
        }

        private void menuStripWindowWorkspace_Click(object sender, EventArgs e)
        {
            menuStripWindowWorkspace.Checked = true;
            
        }

        private void menuStripWindowDetails_Click(object sender, EventArgs e)
        {
            if (menuStripWindowDetails.Checked == true)
            {
                menuStripWindowDetails.Checked = false;
                this.detailsWindow.Visible = false;
            }
            else
            {
                menuStripWindowDetails.Checked = true;
                this.detailsWindow.Visible = true;
            }
        }

        private void menuStripWindowInitialization_Click(object sender, EventArgs e)
        {
            if (menuStripWindowInitialization.Checked == true)
            {
                menuStripWindowInitialization.Checked = false;
                this.simulationWindow.Visible = false;
            }
            else
            {
                menuStripWindowInitialization.Checked = true;
                this.simulationWindow.Visible = true;
            }
        }

        private void menuStripWindowSimulation_Click(object sender, EventArgs e)
        {
            if (menuStripWindowSimulation.Checked == true)
            {
                menuStripWindowSimulation.Checked = false;
                this.simInOutWindow.Visible = false;
            }
            else
            {
                menuStripWindowSimulation.Checked = true;
                this.simInOutWindow.Visible = true;
            }
        }

        #endregion menuStripLogic

        #region mainFormGettersSetters

        public Boolean designEditorVisibility
        {
            get { return this.designEditor.Visible; }
            set { this.designEditor.Visible = value; }
        }
        
        public Boolean detailsWindowVisibility
        {
            get { return this.detailsWindow.Visible; }
            set { this.detailsWindow.Visible = value; }
        }

        public Boolean simulationWindowVisibility
        {
            get { return this.simulationWindow.Visible; }
            set { this.simulationWindow.Visible = value; }
        }

        public Boolean simInOutWindowVisibility
        {
            get { return this.simInOutWindow.Visible; }
            set { this.simInOutWindow.Visible = value; }
        }

        public Boolean menuStripDesignEditorToolBoxChecked
        {
            get { return this.menuStripStructureToolBox.Checked; }
            set { this.menuStripStructureToolBox.Checked = value; }
        }

        public Boolean menuStripWindowDetailsChecked
        {
            get { return this.menuStripWindowDetails.Checked; }
            set { this.menuStripWindowDetails.Checked = value; }
        }

        public Boolean menuStripWindowWorkspaceChecked
        {
            get { return this.menuStripWindowWorkspace.Checked; }
            set { this.menuStripWindowWorkspace.Checked = value; }
        }

        public Boolean menuStripWindowInitializationChecked
        {
            get { return this.menuStripWindowInitialization.Checked; }
            set { this.menuStripWindowInitialization.Checked = value; }
        }

        public Boolean menuStripWindowSimulationChecked
        {
            get { return this.menuStripWindowSimulation.Checked; }
            set { this.menuStripWindowSimulation.Checked = value; }
        }

        public Boolean menuStripInitializationChecked
        {
            get { return this.menuStripInitializeSimulation.Checked; }
            set { this.menuStripInitializeSimulation.Checked = value; }
        }

        public void closingWorkspaceMenuEnabling()
        {
            this.menuStripWindowWorkspace.Enabled = false;
            this.menuStripWindowSimulation.Enabled = false;
            this.menuStripWindowDetails.Enabled = false;
            this.menuStripStructureToolBox.Enabled = false;
        }

        public Variables globalVariablesOfMainForm
        {
            get { return this.glob; }
            set { this.glob = value; }
        }
        public string boxInputText
        {
            set { this.boxInput.Text = value; }
            get { return this.boxInput.Text; }
        }
        public string boxLayer1Text
        {
            set { this.boxLayer1.Text = value; }
            get { return this.boxLayer1.Text; }
        }
        public string boxLayer2Text
        {
            set { this.boxLayer2.Text = value; }
            get { return this.boxLayer2.Text; }
        }
        public string boxOutputText
        {
            set { this.boxOutput.Text = value; }
            get { return this.boxOutput.Text; }
        }

        #endregion mainFormGettersSetters

        private void menuStripInitializeSimulation_Click(object sender, EventArgs e)
        {
            this.flags.initializedSimFlag = true;
            this.timerSimulation.Interval = this.glob.timeScale;
            this.methods.changeIntervals(this.glob.timeScale);
            this.button2.Enabled = true;
            this.menuStripInitializeSimulation.Checked = true;
            this.menuStripWindowInitialization.Enabled = true;
            this.clearSimulationWindow();
            this.treeView1.Nodes[0].Expand();
            this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[0];
            this.glob.synapsesInLay1 = new Synapse[this.glob.numberInput, this.glob.numberLayer1];
            this.glob.synapsesLay1Out = new Synapse[this.glob.numberLayer1, this.glob.numberOutput];
            this.simulationWindow.Visible = true;
        }


        public void newProject()
        {
            if (this.flags.OneWorkSpaceOnlyFlag == true)
            {
                //close workspace
                this.glob.workSpaceMDIchild.Close();                
            }
                if(this.glob.potentialGraphMDIchild != null)
                    this.glob.potentialGraphMDIchild.stopGraph();

                this.togleSimulationPathIcons(0);

                this.glob.workSpaceMDIchild = new WorkSpace(this.flags, this.glob, this);
                this.glob.workSpaceMDIchild.MdiParent = this;
                this.glob.workSpaceMDIchild.WindowState = FormWindowState.Maximized;
                this.glob.workSpaceMDIchild.Show();
                

                this.radioButton1.Checked = true;
                this.designEditor.Visible = true;
                this.menuStripStructureToolBox.Enabled = true;
                this.menuStripStructureToolBox.Checked = true;
                this.menuStripWindowWorkspace.Enabled = true;
                this.menuStripWindowWorkspace.Checked = true;
                this.menuStripWindowDetails.Enabled = true;
                this.menuStripGenerateVHDL.Enabled = true;
                this.flags.OneWorkSpaceOnlyFlag = true;
        }

        private void menuStripNew_Click(object sender, EventArgs e)
        {
            this.newProject();
        }

        private void detailsWindow_VisibleChanged(object sender, EventArgs e)
        {
            if (this.detailsWindow.Visible == false)
            {
                this.panelInputs.Visible = false;
                this.menuStripWindowDetails.Checked = false;
            }
            else
                this.menuStripWindowDetails.Checked = true;
        }

        private void menuStripInitializeSimulation_CheckedChanged(object sender, EventArgs e)
        {
            if (menuStripInitializeSimulation.Checked == false)
            {
                this.menuStripWindowInitialization.Enabled = false;
                this.menuStripWindowInitialization.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.flags.addingNewNeuronFlag = true;
            flags.erasingNeuronsFlag = false;
            flags.arrowToolFlag = false;
            this.Cursor = Cursors.Cross;
        }

        private void toolNeuronEraser_Click(object sender, EventArgs e)
        {
            flags.erasingNeuronsFlag = true;
            flags.addingNewNeuronFlag = false;
            flags.arrowToolFlag = false;
            this.Cursor = Cursors.No;
        }

        private void toolMousePointer_Click(object sender, EventArgs e)
        {
            flags.erasingNeuronsFlag = false;
            flags.addingNewNeuronFlag = false;
            flags.arrowToolFlag = true;
            this.Cursor = Cursors.Default;
        }

        private void menuStripModeSNN_Click(object sender, EventArgs e)
        {
            this.menuStripModeSNN.Checked = true;
            this.menuStripModeANN.Checked = false;
            if(this.flags.OneWorkSpaceOnlyFlag != false)
                this.glob.workSpaceMDIchild.Close();
            this.Text = this.appMessages.networkName[this.flags.languageIndexVar] + " - " + this.appMessages.spikingModeName[this.flags.languageIndexVar];
        }

        private void menuStripModeANN_Click(object sender, EventArgs e)
        {
            this.menuStripModeSNN.Checked = false;
            this.menuStripModeANN.Checked = true;
            this.Text = this.appMessages.networkName[this.flags.languageIndexVar] + " - " + this.appMessages.artificialModeName[this.flags.languageIndexVar];
            if (this.flags.OneWorkSpaceOnlyFlag != false) 
                this.glob.workSpaceMDIchild.Close();
        }

        private void menuStripModeSNN_CheckedChanged(object sender, EventArgs e)
        {
            if (menuStripModeSNN.Checked == true)
            {
                this.menuStripWindowSimulation.Visible = true;
                this.menuStripWindowInitialization.Visible = true;
                this.menuStripPlot.Visible = true;
                //moze ale nie koniecznie:
                this.menuStripSimulation.Visible = true;
                this.flags.applicationModeFlag = 0;
            }
            else
            {
                this.menuStripWindowSimulation.Visible = false;
                this.menuStripWindowInitialization.Visible = false;
                this.menuStripPlot.Visible = false;
                //moze ale nie koniecznie:
                this.menuStripSimulation.Visible = false;
            }
            
        }

        private void menuStripModeANN_CheckedChanged(object sender, EventArgs e)
        {
            if (menuStripModeANN.Checked == false)
            {
                this.menuStripWindowSimulation.Visible = true;
                this.menuStripWindowInitialization.Visible = true;
                this.menuStripPlot.Visible = true;
                //moze ale nie koniecznie:
                this.menuStripSimulation.Visible = true;
                
            }
            else
            {
                this.menuStripWindowSimulation.Visible = false;
                this.menuStripWindowInitialization.Visible = false;
                this.menuStripPlot.Visible = false;
                this.flags.applicationModeFlag = 1;
                //moze ale nie koniecznie:
                this.menuStripSimulation.Visible = false;
            }
        }

        public Boolean menuStripModeSNNchange
        {
            get { return this.menuStripModeSNN.Checked; }
            set { this.menuStripModeSNN.Checked = value; }
        }

        public Boolean menuStripModeANNchange
        {
            get { return this.menuStripModeANN.Checked; }
            set { this.menuStripModeANN.Checked = value; }
        }

        public void loadStruct()
        {
            string folder = "";
            if (this.flags.applicationModeFlag == 0)
            {
                folder = "SNN\\";
            }
            else
            {
                folder = "ANN\\";
            }
            openStructDialog.Filter = "INI files (*.ini)|*.INI|All files (*.*)|*.*";
            openStructDialog.FileName = ""; 
            openStructDialog.InitialDirectory = Properties.Settings.Default.pathStructures + folder;
            openStructDialog.Title = "Select INI file:";
            openStructDialog.ShowDialog();
        }
        public void saveStruct()
        {
            string folder = "";
            if (this.flags.applicationModeFlag == 0)
            {
                folder = "SNN\\";
            }
            else
            {
                folder = "ANN\\";
            }
            saveStructDialog.Filter = "INI files (*.ini)|*.INI|All files (*.*)|*.*";
            saveStructDialog.FileName = "";
            saveStructDialog.InitialDirectory = Properties.Settings.Default.pathStructures + folder;
            saveStructDialog.Title = "Select INI file:";

            saveStructDialog.ShowDialog();
        }

        private void menuStripLoad_Click(object sender, EventArgs e)
        {
            this.loadStruct();
        }

        private void menuStripSave_Click(object sender, EventArgs e)
        {
            this.saveStruct();
        }
        #region Dialogs

        private void openStructDialog_FileOk(object sender, CancelEventArgs e)
        {
            System.Collections.Specialized.StringCollection lista = new System.Collections.Specialized.StringCollection();
            if (Properties.Settings.Default.listRecentProjects != null)
            {
                int index = 0;
                lista = Properties.Settings.Default.listRecentProjects;
                if (lista.Count >= Properties.Settings.Default.howManyRecent)
                {
                    lista.Insert(0, openStructDialog.FileName.ToString());
                }
                else
                {
                    foreach (string str in lista)
                    {
                        if (openStructDialog.FileName.CompareTo(str) == 0)
                        {
                            lista.RemoveAt(index);
                            lista.Insert(0, str);
                        }
                        index++;
                    }
                    lista.Add(openStructDialog.FileName);
                }
                
            }
            else
            {
                lista.Insert(0,openStructDialog.FileName);
            }
            Properties.Settings.Default.listRecentProjects = lista;
            Properties.Settings.Default.Save();
            this.newProject();
            MethodsLibrary.IniFiles.IniFileLight loadedIni = new MethodsLibrary.IniFiles.IniFileLight(openStructDialog.FileName);

            this.methods.loadStructure(loadedIni);
            this.menuStripGenerateVHDL.Enabled = true;
        }

        private void saveStructDialog_FileOk(object sender, CancelEventArgs e)
        {
            MethodsLibrary.IniFiles.IniFileLight saveIni = new MethodsLibrary.IniFiles.IniFileLight();

            System.Collections.Specialized.StringCollection lista = new System.Collections.Specialized.StringCollection();
            if (Properties.Settings.Default.listRecentProjects != null)
            {
                int index = 0;
                lista = Properties.Settings.Default.listRecentProjects;
                if (lista.Count >= Properties.Settings.Default.howManyRecent)
                {
                    lista.Insert(0, saveStructDialog.FileName.ToString());
                }
                else
                {
                    foreach (string str in lista)
                    {
                        if (saveStructDialog.FileName.CompareTo(str) == 0)
                        {
                            lista.RemoveAt(index);
                            lista.Insert(0, str);
                        }
                        index++;
                    }
                    lista.Insert(0, saveStructDialog.FileName);
                }
            }
            else
            {
                lista.Add(saveStructDialog.FileName);
            }
            Properties.Settings.Default.listRecentProjects = lista;
            Properties.Settings.Default.Save();
            saveIni = this.methods.saveStructure();

            saveIni.Save(saveStructDialog.FileName);
            this.flags.projectNotSavedFlag = true;
        }

        #endregion Dialogs        

        private void btnUpdateStructure_Click(object sender, EventArgs e)
        {
            int outp, l1,l2, inp;

            //if ((this.radioButton2.Checked) && ((this.boxLayer2.Text.CompareTo("") == 0) || (Convert.ToInt32(this.boxLayer2.Text))))
            { 
            
            }
            if ((Convert.ToInt32(this.boxLayer1.Text) == 0) || (Convert.ToInt32(this.boxInput.Text) == 0) || (Convert.ToInt32(this.boxOutput.Text) == 0))
            {
                MessageBox.Show(this.appMessages.wrongNeuronNumber[this.flags.languageIndexVar], this.appMessages.wrongNeuronNumberTitle[this.flags.languageIndexVar], MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inp = Convert.ToInt32(boxInput.Text.ToString());
                l1 = Convert.ToInt32(boxLayer1.Text.ToString());
                l2 = Convert.ToInt32(boxLayer2.Text.ToString());
                outp = Convert.ToInt32(boxOutput.Text.ToString());

                this.methods.disposeNeurons();
                this.glob.workSpaceMDIchild.Controls.Clear();
                this.glob.workSpaceMDIchild.Refresh();

                glob.numberInput = inp;
                glob.numberLayer1 = l1;
                glob.numberLayer2 = l2;
                glob.numberOutput = outp;

                this.methods.createStructure();
                this.methods.drawSynapses();

                boxInput.Text = inp.ToString();
                boxLayer1.Text = l1.ToString();
                boxLayer2.Text = l2.ToString();
                boxOutput.Text = outp.ToString();
                }
        }

        private void checkBoxRandomParameters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandomParameters.Checked == false)
            {                
                lblNeuronThr.Visible = false;
                maskedBoxThreshold.Visible = false;
                groupWeightInit.Visible = false;
                lblWeightInitParams.Visible = false;
                maskedBoxRandomFrom.Visible = false;
                maskedBoxRandomTo.Visible = false;
                groupDealyInit.Visible = false;
                lblLayerDelay.Visible = false;
                maskedBoxLayerDelayTo.Visible = false;

            }
            else
            {
                lblNeuronThr.Visible = true;
                maskedBoxThreshold.Visible = true;
                groupWeightInit.Visible = true;
                lblWeightInitParams.Visible = true;
                maskedBoxRandomFrom.Visible = true;
                maskedBoxRandomTo.Visible = true;
                groupDealyInit.Visible = true;
                lblLayerDelay.Visible = true;
                maskedBoxLayerDelayTo.Visible = true;
            }
        }

        private void radioLearningNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLearningNone.Checked == true)
            {
                tabLearning.SelectedIndex = 0;
            }
        }

        private void radioLearningSTDP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLearningSTDP.Checked == true)
            {
                tabLearning.SelectedIndex = 1;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView1.SelectedNode.Index)
            {
                case 0: //Preferences
                    if (this.flags.simulationPathStepFlag == 0)
                        this.flags.simulationPathStepFlag = 0;
                    this.togleSimulationPathIcons(0);
                    tabSim.SelectedIndex = 0;
                    break;
                case 1: //Data source
                    if (this.flags.simulationPathStepFlag + 1 == 1)
                        this.flags.simulationPathStepFlag = 1;
                    this.togleSimulationPathIcons(1);
                    tabSim.SelectedIndex = 1;
                    break;
                case 2: //Input Coding
                    if (this.radioSrcFile.Checked == true)
                    {
                        this.radioCodingPopulationSimple.Visible = false;
                    }
                    else
                        this.radioCodingPopulationSimple.Visible = true;
                    if (this.radioSrcTest.Checked == true)
                    {
                        this.radioCodingImageRecognition.Enabled = false;
                        this.radioCodingPopulationGauss.Enabled = false;
                        this.radioCodingPopulationSimple.Enabled = false;
                    }
                    else
                    {
                        this.radioCodingImageRecognition.Enabled = true;
                        this.radioCodingPopulationGauss.Enabled = true;
                        this.radioCodingPopulationSimple.Enabled = true;
                    }
                    tabSim.SelectedIndex = 2;
                    break;
                case 3: //Initialization
                    DialogResult dr2 = DialogResult.Yes;
                    if ((this.radioCodingImageRecognition.Checked == true) && (this.maskedBoxImageRecFROM.Text.CompareTo("") == 0 || this.maskedBoxImageRecTO.Text.CompareTo("") == 0))
                    {
                        this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[2];
                        DialogResult dr = MessageBox.Show(this.appMessages.emptyDimensionBox[this.flags.languageIndexVar], this.appMessages.emptyDimensionBoxTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);
                    }
                    else if ((this.radioCodingPopulationGauss.Checked == true))
                    {

                        try
                        {
                             Convert.ToDouble(maskedBoxGammaSim.Text);
                             Convert.ToDouble(maskedBoxRangeSimFrom.Text);
                             Convert.ToDouble(maskedBoxRangeSimTo.Text);
                             Convert.ToDouble(maskedBoxMaxTSim.Text);
                        }
                        catch (Exception exc)
                        { 
                            this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[2];
                            dr2 = MessageBox.Show(this.appMessages.missingValue[this.flags.languageIndexVar], this.appMessages.missingValueTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);
                        
                        }
                        if (dr2 == DialogResult.OK)
                        {

                        }
                        else
                            tabSim.SelectedIndex = 3;
                    }
                    else if(this.radioCodingPopulationSimple.Checked == true)
                    {

                        try
                        {
                            Convert.ToDouble(maskedBoxMaxTSim.Text);
                        }
                        catch (Exception exc)
                        {
                            this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[2];
                            dr2 = MessageBox.Show(this.appMessages.missingValue[this.flags.languageIndexVar], this.appMessages.missingValueTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);

                        }
                        if (dr2 == DialogResult.OK)
                        { 
                        
                        }
                        else
                            tabSim.SelectedIndex = 3;
                    }
                    else
                    {
                        if (this.radioCodingImageRecognition.Checked == true)
                        {
                            if (Convert.ToInt32(this.maskedBoxImageRecFROM.Text) * Convert.ToInt32(this.maskedBoxImageRecTO.Text) != this.glob.numberInput)
                            {
                                this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[2];
                                MessageBox.Show(this.appMessages.dimensionDontMatch[this.flags.languageIndexVar], this.appMessages.dimensionDomtMatchTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);
                            }
                            else
                                tabSim.SelectedIndex = 3;
                        }
                        else
                        {
                            tabSim.SelectedIndex = 3;
                        }
                    }
                    break;
                case 4: //learning
                    if ((this.checkBoxRandomParameters.Checked == true))
                    {
                        DialogResult dres = DialogResult.Yes;
                        try
                        {
                            Convert.ToDouble(this.maskedBoxThreshold.Text);
                            Convert.ToDouble(this.maskedBoxRandomFrom.Text);
                            Convert.ToDouble(this.maskedBoxRandomTo.Text);
                            Convert.ToInt32(this.maskedBoxLayerDelayTo.Text);
                            if (this.maskedBoxDelayInputTo.Visible == true)
                                Convert.ToInt32(this.maskedBoxDelayInputTo.Text);
                        }
                        catch (Exception exc)
                        {
                            this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[3];
                            dres = MessageBox.Show(this.appMessages.missingValue[this.flags.languageIndexVar], this.appMessages.missingValueTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);

                        }
                        if (dres == DialogResult.OK)
                        {

                        }
                        else
                            tabSim.SelectedIndex = 4;
                    }
                    else
                        tabSim.SelectedIndex = 4;

                    break;
                case 5: //simulation
                    if ((this.radioLearningSTDP.Checked == true))
                    {
                        if (((this.maskedBoxA.Text.CompareTo("") == 0) || (this.maskedBoxTauD.Text.CompareTo("") == 0) || (this.maskedBoxTauP.Text.CompareTo("") == 0) || (this.maskedBoxMaxW.Text.CompareTo("") == 0) || (this.maskedBoxMinW.Text.CompareTo("") == 0)))
                        {
                            this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[4];
                            MessageBox.Show(this.appMessages.emptyLearningBox[this.flags.languageIndexVar], this.appMessages.emptyLearningBoxTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);
                        }
                        else
                            tabSim.SelectedIndex = 5;
                    }
                    else
                        tabSim.SelectedIndex = 5;
                    break;
                default:
                    tabSim.SelectedIndex = 0;
                    break;
            }
        }
        private void togleSimulationPathIcons(int clicked)
        {
            switch (clicked)
            {
                case 0:
                    for (int i = 0; i < this.flags.simulationPathStepFlag; i++)
                        treeView1.Nodes[0].Nodes[i].ImageIndex = 2;

                    break;
                case 1:
                    for (int i = 0; i < this.flags.simulationPathStepFlag; i++)
                        treeView1.Nodes[0].Nodes[i].ImageIndex = 2;
                    break;
                case 2:
                    for (int i = 0; i < this.flags.simulationPathStepFlag; i++)
                        treeView1.Nodes[0].Nodes[i].ImageIndex = 2;
                    break;
                case 3:
                    for (int i = 0; i < this.flags.simulationPathStepFlag; i++)
                        treeView1.Nodes[0].Nodes[i].ImageIndex = 2;
                    break;
                case 4:
                    for (int i = 0; i < this.flags.simulationPathStepFlag; i++)
                        treeView1.Nodes[0].Nodes[i].ImageIndex = 2;
                    break;
                case 5:
                    for (int i = 0; i < this.flags.simulationPathStepFlag; i++)
                        treeView1.Nodes[0].Nodes[i].ImageIndex = 2;
                    break;

                default:
                    break;
            }
        }

        private void tabSim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean simulateYesNo = false;
            switch (tabSim.SelectedIndex)
            {
                case 0://Sim prefferences
                    break;
                case 1://Data source
                    if (radioRealPSP.Checked == true)
                        this.glob.PSPmode = true;
                    else
                        this.glob.PSPmode = false;
                    this.methods.changePSPcurve(this.glob.PSPmode);
                    break;
                case 2://Input coding
                    
                    if (this.radioSrcFile.Checked == true)
                    {
                        if ((this.boxSourceFile.Text != ""))
                        {
                            if (this.flags.simulationPathStepFlag + 1 == 2)
                                this.flags.simulationPathStepFlag = 2;
                            this.togleSimulationPathIcons(this.flags.simulationPathStepFlag);
                            this.glob.stimuliPerEpoch = Convert.ToInt32(this.BoxStimuliPerEpoch.Text);
                            this.glob.fileStimuliPresentation = Convert.ToInt32(this.maskedBoxStimuliFileTime.Text);
                        }
                        this.flags.simulationModeFlag = 2;
                    }
                    if (this.radioSrcTest.Checked != true)//hide delay random
                    {
                        this.lblInputDelayInit.Visible = false;
                        this.maskedBoxDelayInputTo.Visible = false;
                        if (this.flags.simulationPathStepFlag + 1 == 2)
                            this.flags.simulationPathStepFlag = 2;
                        this.togleSimulationPathIcons(this.flags.simulationPathStepFlag);
                    }
                    else
                    {
                        this.lblInputDelayInit.Visible = true;
                        this.maskedBoxDelayInputTo.Visible = true;
                        if (this.flags.simulationPathStepFlag + 1 == 2)
                            this.flags.simulationPathStepFlag = 2;
                        this.togleSimulationPathIcons(this.flags.simulationPathStepFlag);   
                        this.flags.simulationModeFlag = 0;
                    }
                    
                    break;
                case 3://Initialization

                        if (this.flags.simulationPathStepFlag + 1 == 3)
                            this.flags.simulationPathStepFlag = 3;
                        this.togleSimulationPathIcons(3);
                    

                    break;
                case 4://learning rules
                    if (this.checkBoxRandomParameters.Checked == false) //don't randomize new values only use these already ascribed 
                    {
                        if (this.flags.simulationPathStepFlag + 1 == 4)
                            this.flags.simulationPathStepFlag = 4;
                        this.togleSimulationPathIcons(4);
                    }
                    else//validate Network Initialization
                    {
                            simulateYesNo = this.validateNetworkInit();
                    }
                    break;
                case 5://simulation
                    if (this.radioLearningSTDP.Checked == true)
                    {
                        this.glob.isLearning = true;
                        this.glob.tauD = Convert.ToDouble(this.maskedBoxTauD.Text);
                        this.glob.tauP = Convert.ToDouble(this.maskedBoxTauP.Text);
                        this.glob.Aparameter = Convert.ToDouble(this.maskedBoxA.Text);
                        this.glob.maxWeightL = Convert.ToDouble(this.maskedBoxMaxW.Text);
                        this.glob.minWeightL = Convert.ToDouble(this.maskedBoxMinW.Text);
                    }
                    else if(this.radioLearningNone.Checked == true)
                        this.glob.isLearning = false;                    

                    if (this.flags.simulationPathStepFlag + 1 == 5)
                        this.flags.simulationPathStepFlag = 5;
                    this.togleSimulationPathIcons(5);
                    if (simulateYesNo == true)
                    {
                        //this.methods.createSynapses(); //create new synapses delay after randomizing new delays
                    }
                    break;
                default:
                    break;

            }
        }
        private void clearSimulationWindow()
        {
            this.radioSrcManual.Checked = true;
            this.boxSourceFile.Text = "";
            this.maskedBoxImageRecFROM.Text = "";
            this.maskedBoxImageRecTO.Text = "";
            this.radioCodingImageRecognition.Checked = false;
            this.radioCodingPopulationGauss.Checked = false;
            this.radioCodingPopulationSimple.Checked = false;
            this.checkBoxRandomParameters.Checked = false;
            this.maskedBoxRandomFrom.Text = "";
            this.maskedBoxRandomTo.Text = "";
            this.maskedBoxThreshold.Text = "10";
            this.maskedBoxLayerDelayTo.Text = "";
            this.radioLearningNone.Checked = true;
            this.maskedBoxTauD.Text = "";
            this.maskedBoxTauP.Text = "";
            this.maskedBoxA.Text = "";
            this.maskedBoxMaxW.Text = "";
            this.maskedBoxMinW.Text = "";
            this.radioOutNothing.Checked = true;
            this.maskedBoxGammaSim.Text = "";
            this.maskedBoxRangeSimFrom.Text = "";
            this.maskedBoxRangeSimTo.Text = "";
            this.lblGammaSim.Visible = false;
            this.lblMaxTSim.Visible = false;
            this.label3.Visible = false;
            this.lblRangeSim.Visible = false;
            this.maskedBoxMaxTSim.Text = "";
        }

        private void radioSrcFile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSrcFile.Checked == true)
            {
                this.boxSourceFile.Enabled = true;
                this.button1.Enabled = true;
                this.lblStimuliPerEpoch.Visible = true;
                this.BoxStimuliPerEpoch.Visible = true;
                this.maskedBoxStimuliFileTime.Visible = true;
                this.lblStimuliFileTime.Visible = true;
            }
            else
            {
                this.boxSourceFile.Enabled = false;
                this.button1.Enabled = false;
                this.lblStimuliPerEpoch.Visible = false;
                this.BoxStimuliPerEpoch.Visible = false;
                this.maskedBoxStimuliFileTime.Visible = false;
                this.lblStimuliFileTime.Visible = false;
            }
        }
        private Boolean validateNetworkInit()
        {

            Boolean initializationPassed = false;
            //same delay
            if (radioSrcTest.Checked == true)
            {
                if (((Convert.ToInt32(this.maskedBoxDelayInputTo.Text) > 0) && (Convert.ToInt32(this.maskedBoxLayerDelayTo.Text) > 0))) //minimum delay = 1
                {
                    Point inputDelay = new Point(0, Convert.ToInt32(this.maskedBoxDelayInputTo.Text));
                    Point layerDelay = new Point(0, Convert.ToInt32(this.maskedBoxLayerDelayTo.Text));

                    if (Convert.ToDouble(this.maskedBoxThreshold.Text) > 0)
                    {
                        this.methods.delayInitialization(inputDelay, layerDelay, Convert.ToDouble(this.maskedBoxThreshold.Text));
                        initializationPassed = true;
                    }
                    else
                        initializationPassed = false;
                }
                else
                    initializationPassed = false;
            }
            else
            {
                if ((Convert.ToInt32(this.maskedBoxLayerDelayTo.Text) > 0)) //minimum delay = 1
                {
                    Point inputDelay = new Point(0, 0); //0 for Y value prevents from input initialization
                    Point layerDelay = new Point(0, Convert.ToInt32(this.maskedBoxLayerDelayTo.Text));

                    if (Convert.ToDouble(this.maskedBoxThreshold.Text) > 0)
                    {
                        this.methods.delayInitialization(inputDelay, layerDelay, Convert.ToDouble(this.maskedBoxThreshold.Text));
                        initializationPassed = true;
                    }
                    else
                        initializationPassed = false;
                }
                else
                    initializationPassed = false;
            }
            if ((Convert.ToDouble(this.maskedBoxRandomTo.Text) > 0))
            {
                if (this.maskedBoxRandomFrom.Text[0].CompareTo('-') == 0)// checkAllowNegativeWeights.Checked == true) //with negative wieghts
                {
                    this.methods.weightInitialization(Convert.ToDouble(this.maskedBoxRandomFrom.Text), Convert.ToDouble(this.maskedBoxRandomTo.Text), true);
                }
                else
                {
                    this.methods.weightInitialization(Convert.ToDouble(this.maskedBoxRandomFrom.Text), Convert.ToDouble(this.maskedBoxRandomTo.Text), false);
                }
            }
            else
                initializationPassed = false;

            if (initializationPassed == true)
            {
                if (this.flags.simulationPathStepFlag + 1 == 4)
                    this.flags.simulationPathStepFlag = 4;
                this.togleSimulationPathIcons(4);
            }
            return initializationPassed;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.openDataSourceDialog.Filter = "TXT files (*.txt)|*.TXT|All files (*.*)|*.*";
            this.openDataSourceDialog.FileName = "";
            this.openDataSourceDialog.InitialDirectory = Properties.Settings.Default.pathStimuli;
            this.openDataSourceDialog.Title = "Select TXT file:";
            this.openDataSourceDialog.ShowDialog();
        }

        private void saveOutputFile_FileOk(object sender, CancelEventArgs e)
        {
            
                this.textBoxOutputFile.Text = this.saveOutputFile.FileName.ToString();
                this.glob.outputFileName = this.textBoxOutputFile.Text;
        }


        private void radioOutFile_Click(object sender, EventArgs e)
        {
            this.saveOutputFile.Filter = "TXT files (*.txt)|*.TXT|All files (*.*)|*.*";
            this.saveOutputFile.FileName = "";
            this.saveOutputFile.InitialDirectory = Properties.Settings.Default.pathOutput;
            this.saveOutputFile.Title = "Select TXT file:";
            this.saveOutputFile.ShowDialog();
           /* if (this.saveOutputFile.ShowDialog() == DialogResult.Cancel)
            {
                this.textBoxOutputFile.Text = "";
                this.radioOutNothing.Checked = true;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.methods.createSynapses();
            this.treeView1.Enabled = false;
            this.btnSimStop.Enabled = true;
            this.button2.Enabled = false;
            this.groupBoxTools.Enabled = false;
            this.glob.changeSum.Clear();
            this.glob.sum = 0;
            this.glob.lowestSum = 10000;
            this.glob.time = -1;
            #region simulationFromFile
            if (this.radioSrcFile.Checked == true)
            {
                if (this.radioOutNothing.Checked == true)
                {

                }
                else
                {
                    this.glob.lineOutput = "";
                    if (this.glob.outputFileName.CompareTo("") == 0)
                    {
                        MessageBox.Show(this.appMessages.outputFileNotFound[this.flags.languageIndexVar], this.appMessages.outputFileNotFoundTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);
                    }
                    else
                    {
                        //simulation from file
                        this.glob.stimuliFileReader = new StreamReader(this.boxSourceFile.Text);
                        this.glob.lineBuf = this.glob.stimuliFileReader.ReadLine();
                        if (this.glob.lineBuf == null)
                        {
                            MessageBox.Show(this.appMessages.simulationEnd[this.flags.languageIndexVar], this.appMessages.simulationEndTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);
                        }
                        else
                        {
                            this.methods.createThreads();
                            if(this.radioCodingImageRecognition.Checked == true)
                                this.methods.startNetworkForFileSimulation(50);
                            if (this.radioCodingPopulationGauss.Checked == true)
                            {
                                this.gaussianFile(Convert.ToDouble(this.glob.lineBuf));
                                this.methods.startNetworkWithTestMode();
                            }
                            if (this.radioCodingPopulationSimple.Checked == true)
                            {
                                this.temporalFile(Convert.ToInt32(this.glob.lineBuf));
                                this.methods.startNetworkWithTestMode();
                            }
                            this.flags.isSimulatedFlag = true;
                            this.timerSimulation.Start();
                        }
                    }
                }
            }
            #endregion simulationFromFile


            #region ManualStimulation

            if (this.radioSrcManual.Checked == true)
            {
                this.menuStripWindowSimulation.Enabled = true;
                this.menuStripWindowSimulation.Checked = true;
                this.button2.Enabled = false;
                this.simInOutWindow.Visible = true;
                btnSimStop.Enabled = false;

            }

            #endregion ManualStimulation

            if (this.radioSrcTest.Checked == true)
            {
                this.methods.createThreads();
                this.methods.startNetworkWithTestMode();
                this.timerSimulation.Start();
            }
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            int var1 = (int)this.lblWhichLayer.Tag;
            if (this.lblWhichLayer.Text.CompareTo("input") == 0)
            {
                ((InputNeuron)this.glob.inputNeurons[var1].Tag).initialize(Convert.ToInt32(this.boxDelayText));
            }
            if (this.lblWhichLayer.Text.CompareTo("Layer 1") == 0)
            {
                ((Neuron)this.glob.layer1[var1].Tag).delays[0] = Convert.ToInt32(this.boxDelay.Text);
                ((Neuron)this.glob.layer1[var1].Tag).weights[0] = Convert.ToDouble(this.boxWeight.Text);
                
                for (int i = 1; i < this.glob.numberInput - 2; i++)
                {
                    ((Neuron)this.glob.layer1[var1].Tag).delays[i] = Convert.ToInt32(this.glob.detailBox[(i) * 2].Text);
                    ((Neuron)this.glob.layer1[var1].Tag).weights[i] = Convert.ToDouble(this.glob.detailBox[(i) * 2 + 1].Text);
                }
                ((Neuron)this.glob.layer1[var1].Tag).threshold = Convert.ToDouble(this.boxThreshold.Text);
                //this.updateSynapseDelay("Layer 1", var1);
            }
            if (this.lblWhichLayer.Text.CompareTo("output") == 0)
            {
                ((Neuron)this.glob.output[var1].Tag).delays[0] = Convert.ToInt32(this.boxDelay.Text);
                ((Neuron)this.glob.output[var1].Tag).weights[0] = Convert.ToDouble(this.boxWeight.Text);
                
                for (int i = 1; i < this.glob.numberLayer1 - 2; i++)
                {
                    ((Neuron)this.glob.output[var1].Tag).delays[i] = Convert.ToInt32(this.glob.detailBox[(i) * 2].Text);
                    ((Neuron)this.glob.output[var1].Tag).weights[i] = Convert.ToDouble(this.glob.detailBox[(i) * 2 + 1].Text);
                }
                ((Neuron)this.glob.output[var1].Tag).threshold = Convert.ToDouble(this.boxThreshold.Text);
                //this.updateSynapseDelay("output", var1);
            }
        }
        public void updateSynapseDelay(string layer, int neuronNumber)
        {
            if (layer.CompareTo("Layer 1") == 0)
            {
                for (int i = 0; i < this.glob.numberInput; i++)
                    this.glob.synapsesInLay1[i, neuronNumber].setDelay(((Neuron)this.glob.layer1[neuronNumber].Tag).delays[i]);
            }
            if (layer.CompareTo("output") == 0)
            {
                for (int i = 0; i < this.glob.numberLayer1; i++)
                    this.glob.synapsesLay1Out[i, neuronNumber].setDelay(((Neuron)this.glob.output[neuronNumber].Tag).delays[i]);
            }
        }
        public GroupBox groupBox1Passer()
        {
            return this.groupBox1;
        }
        public Panel inputsDetailsPanelPasser()
        {
            return this.inputsPanel;
        }
        public Microsoft.VisualBasic.PowerPacks.LineShape lineShape1Passer()
        {
            return this.lineShape1;
        }
        public Microsoft.VisualBasic.PowerPacks.OvalShape detailShapePasser()
        {
            return this.detailShape;
        }
        public void tabPage1ControlsAdd(Control controlToAdd)
        {
            this.tabDetailsWindowTab0.Controls.Add(controlToAdd);
        }
        public void setDetailsWindowHeaderText(string title)
        {
            this.detailsWindowHeaderTitle.Text = "Neuron Details - " + title;
        }
        public string lblPotentialText
        {
            get { return this.lblPotential.Text; }
            set { this.lblPotential.Text = value; }
        }
        public string boxDelayText
        {
            get { return this.boxDelay.Text; }
            set { this.boxDelay.Text = value; }
        }
        public string boxWeightText
        {
            get { return this.boxWeight.Text; }
            set { this.boxWeight.Text = value; }
        }
        public string boxThresholdText
        {
            get { return this.boxThreshold.Text; }
            set { this.boxThreshold.Text = value; }
        }
        public string lblWhichLayerText
        {
            get { return this.lblWhichLayer.Text; }
            set { this.lblWhichLayer.Text = value; }
        }
        public object lblWhichLayerTag
        {
            get { return this.lblWhichLayer.Tag; }
            set { this.lblWhichLayer.Tag = value; }
        }
        public Point boxDelayLeftTop
        {
            get { return new Point(this.boxDelay.Left, this.boxDelay.Top); }
            set { this.boxDelay.Left = value.X; this.boxDelay.Top = value.Y; }
        }
        public Point boxWeightLeftTop
        {
            get { return new Point(this.boxWeight.Left, this.boxWeight.Top); }
            set { this.boxWeight.Left = value.X; this.boxWeight.Top = value.Y; }
        }
        public Point boxThresholdLeftTop
        {
            get { return new Point(this.boxThreshold.Left, this.boxThreshold.Top); }
            set { this.boxThreshold.Left = value.X; this.boxThreshold.Top = value.Y; }
        }
        public Point lblDelayLocation
        {
            get { return this.lblDelay.Location; }
            set { this.lblDelay.Location = new Point(value.X, value.Y); }
        }
        public Point lblWeightLocation
        {
            get { return this.lblWeight.Location; }
            set { this.lblWeight.Location = new Point(value.X, value.Y); }
        }
        public Point lblThresholdLocation
        {
            get { return this.lblThreshold.Location; }
            set { this.lblThreshold.Location = new Point(value.X, value.Y); }
        }
        public Point btnUpdateDataWidthHeight
        {
            get { return new Point(this.btnUpdateData.Width, this.btnUpdateData.Height); }
            set { this.btnUpdateData.Width = value.X; this.btnUpdateData.Height = value.Y; }
        }
        public Point btnUpdateDataLocation
        {
            get { return this.btnUpdateData.Location; }
            set { this.btnUpdateData.Location = new Point(value.X, value.Y); }
        }
        public Boolean boxDelayVisibility
        {
            get { return this.boxDelay.Visible; }
            set { this.boxDelay.Visible = value; }
        }
        public Boolean menuStripGenerateVHDLEnable
        {
            get { return this.menuStripGenerateVHDL.Enabled; }
            set { this.menuStripGenerateVHDL.Enabled = value; }
        }
        public Boolean boxWeightVisibility
        {
            get { return this.boxWeight.Visible; }
            set { this.boxWeight.Visible = value; }
        }
        public Boolean boxThresholdVisibility
        {
            get { return this.boxThreshold.Visible; }
            set { this.boxThreshold.Visible = value; }
        }
        public Boolean lblDelayVisibility
        {
            get { return this.lblDelay.Visible; }
            set { this.lblDelay.Visible = value; }
        }
        public Boolean lblWeightVisibility
        {
            get { return this.lblWeight.Visible; }
            set { this.lblWeight.Visible = value; }
        }
        public Boolean lblThresholdVisibility
        {
            get { return this.lblThreshold.Visible; }
            set { this.lblThreshold.Visible = value; }
        }
        public object btnUpdateDataTag
        {
            get { return this.btnUpdateData.Tag; }
            set { this.btnUpdateData.Tag = value; }
        }
        public Point boxDelayDimensions
        {
            get { return new Point(this.boxDelay.Width, this.boxDelay.Height); }
            set { this.boxDelay.Width = value.X; this.boxDelay.Height = value.Y; }
        }
        public Point boxWeightDimensions
        {
            get { return new Point(this.boxWeight.Width, this.boxWeight.Height); }
            set { this.boxDelay.Width = value.X; this.boxWeight.Height = value.Y; }
        }
        public Point boxThresholdDimensions
        {
            get { return new Point(this.boxThreshold.Width, this.boxThreshold.Height); }
            set { this.boxThreshold.Width = value.X; this.boxThreshold.Height = value.Y; }
        }
        public Boolean detailsWindowVisibilityFirst
        {
            get { return this.detailsWindow.Visible; }
            set
            {
                this.detailsWindow.Top = toolStripMenu.Bottom + 2;
                this.detailsWindow.Left = (this.Right - this.detailsWindow.Width) - 10;
                this.detailsWindow.Visible = value;
            }
        }
        public void StopTimer()
        {
            if (this.flags.isSimulatedFlag == false)
                this.methods.stopNetoworkThreads();
            this.timerSimulation.Stop();
        }
        public void StartTimer()
        {
            this.timerSimulation.Start();
        }
        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            #region fromFile
            if ((this.radioSrcFile.Checked == true) && this.flags.isSimulatedFlag == true)
            {

                if (this.radioCodingImageRecognition.Checked == true)
                {

                    if ((this.glob.time % this.glob.fileStimuliPresentation) == 0)
                    {
                        this.methods.resetClock();
                        this.methods.resetGraphs();
                        this.glob.time = 0;
                        this.glob.outputLines.Add(this.glob.lineOutput);
                        this.glob.lineOutput = "";
                        //if(this.flags.isSimulatedFlag != false)

                        this.glob.lineBuf = this.glob.stimuliFileReader.ReadLine();

                        if ((this.glob.lineBuf == null))
                        {
                            this.StopTimer();
                            //stop networkd threads
                            this.glob.stimuliFileReader.Close();
                            this.glob.stimuliFileReader.Dispose();
                            this.flags.isSimulatedFlag = false;
                            this.treeView1.Enabled = true;
                            if (this.radioOutFile.Checked == true)
                            {
                                TextWriter tw = new StreamWriter(this.textBoxOutputFile.Text);
                                foreach (string str in this.glob.outputLines)
                                    tw.WriteLine(str);
                                tw.Close();
                            }
                            this.methods.stopNetoworkThreads();
                            this.btnSimStop.Enabled = false;
                            this.button2.Enabled = true;
                            MessageBox.Show(this.appMessages.simulationEnd[this.flags.languageIndexVar], this.appMessages.simulationEndTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);

                        }
                        else
                        {

                            if (this.glob.lineBuf.Length == this.glob.numberInput) //check if line from source file has correct format
                            {
                                this.glob.epochCounter++;
                                this.glob.lineOutput = this.glob.lineBuf;
                                if ((this.glob.epochCounter) % (this.glob.stimuliPerEpoch) == 0)
                                {
                                    //this.zedGraphControl1.GraphPane.CurveList.Clear();
                                    this.glob.outputLines.Add(this.glob.epochCounter.ToString() + ":---------------------------------------------------------------------" + this.glob.sum.ToString());
                                    this.methods.learnWeights(2);
                                    if ((this.glob.lowestSum > this.glob.sum))
                                    {
                                        this.glob.lowestSum = this.glob.sum;
                                        this.methods.learnWeights(0);
                                    }
                                    this.glob.changeSum.Add(this.glob.sum);
                                    this.glob.sum = 0;
                                }
                                for (int i = 0; i < this.glob.lineBuf.Length; i++)
                                {
                                    if (this.glob.lineBuf[i].CompareTo('0') == 0) //stop input thread
                                    {
                                        this.glob.inputThreads[i].Abort();
                                        ((InputNeuron)this.glob.inputNeurons[i].Tag).stopNeuron();
                                    }
                                    if (this.glob.lineBuf[i].CompareTo('1') == 0) //start input thread
                                    {
                                        System.Threading.ThreadStart ts = new System.Threading.ThreadStart(((InputNeuron)this.glob.inputNeurons[i].Tag).LaunchInput);
                                        this.glob.inputThreads[i] = new System.Threading.Thread(ts);
                                        this.glob.inputThreads[i].Start();
                                    }
                                }
                            }
                            else //otherwise stop simulation and notify user
                            {
                                this.timerSimulation.Stop();
                                MessageBox.Show(this.appMessages.wrongFileFormat[this.flags.languageIndexVar], this.appMessages.wrongFileFormatTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);
                            }
                        }
                    }

                    this.glob.time++;
                    this.toolStripBoxTime.Text = this.glob.time.ToString() + " ms";
                }
                else
                {
                    this.glob.suspended = true;
                    if ((this.glob.time % this.glob.fileStimuliPresentation) == 0)
                    {
                        this.methods.resetClock();
                        this.methods.resetGraphs();
                        this.glob.time = 0;
                        this.glob.outputLines.Add(this.glob.lineOutput);
                        this.glob.lineOutput = "";
                        //if(this.flags.isSimulatedFlag != false)

                        this.glob.lineBuf = this.glob.stimuliFileReader.ReadLine();

                        if ((this.glob.lineBuf == null))
                        {
                            this.StopTimer();
                            //stop networkd threads
                            this.glob.stimuliFileReader.Close();
                            this.glob.stimuliFileReader.Dispose();
                            this.flags.isSimulatedFlag = false;
                            this.treeView1.Enabled = true;
                            if (this.radioOutFile.Checked == true)
                            {
                                TextWriter tw = new StreamWriter(this.textBoxOutputFile.Text);
                                foreach (string str in this.glob.outputLines)
                                    tw.WriteLine(str);
                                tw.Close();
                            }
                            this.methods.stopNetoworkThreads();
                            this.btnSimStop.Enabled = false;
                            this.button2.Enabled = true;
                            MessageBox.Show(this.appMessages.simulationEnd[this.flags.languageIndexVar], this.appMessages.simulationEndTitle[this.flags.languageIndexVar], MessageBoxButtons.OK);

                        }
                        else
                        {
                            if (this.radioCodingPopulationGauss.Checked == true)
                                this.gaussianFile(Convert.ToDouble(this.glob.lineBuf));
                            if (this.radioCodingPopulationSimple.Checked == true)
                                this.temporalFile(Convert.ToInt32 (this.glob.lineBuf));
                            this.glob.epochCounter++;
                            this.glob.lineOutput = this.glob.lineBuf;
                            if ((this.glob.epochCounter) % (this.glob.stimuliPerEpoch) == 0)
                            {
                                //this.zedGraphControl1.GraphPane.CurveList.Clear();
                                this.glob.outputLines.Add(this.glob.epochCounter.ToString() + ":---------------------------------------------------------------------" + this.glob.sum.ToString());
                                this.methods.learnWeights(2);
                                if ((this.glob.lowestSum > this.glob.sum))
                                {
                                    this.glob.lowestSum = this.glob.sum;
                                    this.methods.learnWeights(0);
                                }
                                this.glob.changeSum.Add(this.glob.sum);
                                this.glob.sum = 0;
                            }

                        }
                    }

                    this.glob.suspended = false;
                }
            }
            #endregion fromFile
            #region testSimulation
            //if (radioSrcTest.Checked == true) -- others simulation
            {
                this.glob.time++;
                this.toolStripBoxTime.Text = this.glob.time.ToString() + " ms";
            }
            #endregion testSimulation

        }

        private void openDataSourceDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.boxSourceFile.Text = openDataSourceDialog.FileName;
        }

        private void menuStripPlotEntireNetwork_Click(object sender, EventArgs e)
        {
            try
            {
                OtherForms.Tools.NetworkPlot networkActivForm = new SNN.OtherForms.Tools.NetworkPlot(this.glob, this.flags);
                networkActivForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Entire network activity window exception", MessageBoxButtons.OK);
            }
        }


        private void menuStripPlotInput_Click(object sender, EventArgs e)
        {
            try
            {
                OtherForms.Tools.PlotInput inputForm = new SNN.OtherForms.Tools.PlotInput(this.glob, this.flags);
                inputForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Open Plot Input window exception", MessageBoxButtons.OK);
            }
        }

        private void menuStripPlotLayer1_Click(object sender, EventArgs e)
        {
            try
            {
                OtherForms.Tools.PlotLayer1 layer1Form = new SNN.OtherForms.Tools.PlotLayer1(this.glob, this.flags);
                layer1Form.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Open Plot Layer 1 window exception", MessageBoxButtons.OK);
            }
        }

        private void menuStripPlotOutput_Click(object sender, EventArgs e)
        {
            try
            {
                OtherForms.Tools.PlotOutput outputHistory = new SNN.OtherForms.Tools.PlotOutput(this.glob, this.flags);
                outputHistory.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Open Plot Output window exception", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(Application.StartupPath.ToString() + "\\Output\\!WszystkieWagi.txt");
                
            
            this.methods.learnWeights(1);
            for (int j = 0; j < this.glob.changeSum.Count; j++)
            {
                tw.WriteLine("---> EPOCH: " + j.ToString());    
                tw.WriteLine("--------LAYER1-----------");
                foreach (PictureBox pb in this.glob.layer1)
                {
                    foreach (double amount in ((Neuron)pb.Tag).weightHistory[j])
                        tw.WriteLine(amount.ToString());
                }
                tw.WriteLine("--------OUTPUT-----------EPOCH: " + j.ToString());
                foreach (PictureBox pb in this.glob.output)
                {
                    foreach(double amount in ((Neuron)pb.Tag).weightHistory[j])
                        tw.WriteLine(amount.ToString());
                }
                tw.WriteLine("END OF ---> EPOCH: " + j.ToString() + " weight change sum: " + this.glob.changeSum[j].ToString());
            }

            tw.Close();

        }

        private void simInOutWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int weightIndex = Convert.ToInt32(boxSelectWeights.Text);
            {
                for (int i = 0; i < this.glob.numberLayer1; i++)
                {
                    ((Neuron)this.glob.layer1[i].Tag).weights = ((Neuron)this.glob.layer1[i].Tag).weightHistory[weightIndex];
                }
                for (int i = 0; i < this.glob.numberOutput; i++)
                {
                    ((Neuron)this.glob.output[i].Tag).weights = ((Neuron)this.glob.output[i].Tag).weightHistory[weightIndex];
                }
            }
        }
        private void tabDetailsWindow_SelectedIndexChanged(object sender, EventArgs e)
        {


            if ((this.tabDetailsWindow.SelectedIndex == 0) /* Detail Window */)
            {
                this.memTab = 0;
                this.panelInputs.Visible = false;
            }
            if ((this.tabDetailsWindow.SelectedIndex == 1) /* Chart Window */)
            {
                //if (this.flags.isSimulatedFlag == true)
                {

                    if (this.lblWhichLayer.Text.CompareTo("input") == 0)
                    {
                        this.tabDetailsWindow.SelectedIndex = this.memTab;
                    }
                    else
                    {
                        this.memTab = 1;

                        this.tabDetailsWindow.TabPages[1].Controls.Add(this.glob.potentialGraphMDIchild);
                        this.glob.potentialGraphMDIchild.Show();
                        this.glob.potentialGraphMDIchild.startGraph(this.glob.timeScale);

                    }
                }
            }
            if ((this.tabDetailsWindow.SelectedIndex == 2) /* Association */)
            {
                if (memTab == 1)
                {
                    tabDetailsWindow.SelectedIndex = memTab;
                    if (panelInputs.Visible == false)
                    {
                        panelInputs.Visible = true;
                        panelInputs.Left = detailsWindow.Left;
                        panelInputs.Top = detailsWindow.Bottom + 10;
                        panelInputs.Height = 200;
                        richInputsDetail.Width = panelInputs.Width - 90;
                        richInputsDetail.Height = 170;
                        richInputsDetail.Top = 30;
                        richInputsDetail.Text = "";
                    }
                    else
                        panelInputs.Visible = false;

                    int var1 = (int)this.lblWhichLayerTag;

                    //this.zedGraphControl1.GraphPane.CurveList.Clear();

                    if (this.lblWhichLayerText.CompareTo("Layer 1") == 0)
                    {
                        Neuron neuro = (Neuron)glob.layer1[var1].Tag;
                        richInputsDetail.Text = "";
                        for (int i = 0; i < neuro.inputs.Length; i++)
                        {
                            richInputsDetail.SelectionColor = Color.Black;
                            richInputsDetail.SelectedText = (i + 1).ToString() + ":(";

                            richInputsDetail.SelectionColor = this.glob.colorsList[i];

                            richInputsDetail.SelectedText = glob.colorsList[i].Name.ToString();
                            richInputsDetail.SelectionColor = Color.Black;

                            richInputsDetail.SelectedText = "): ";
                            richInputsDetail.SelectedText = neuro.inputs[i].ToString() + " - ";
                            for (int k = 0; k < neuro.spikeToInputs[i].Count; k++)
                            {
                                richInputsDetail.SelectedText = neuro.spikeToInputs[i][k].ToString() + ", ";
                            }
                            richInputsDetail.SelectedText = Environment.NewLine;
                        }
                    }
                    if (this.lblWhichLayerText.CompareTo("Layer 2") == 0)
                    {

                    }
                    if (this.lblWhichLayerText.CompareTo("output") == 0)
                    {
                        Neuron neuro = (Neuron)glob.output[var1].Tag;
                        richInputsDetail.Text = "";
                        for (int i = 0; i < neuro.inputs.Length; i++)
                        {
                            richInputsDetail.SelectionColor = Color.Black;
                            richInputsDetail.SelectedText = (i + 1).ToString() + ":(";

                            richInputsDetail.SelectionColor = this.glob.colorsList[i];

                            richInputsDetail.SelectedText = glob.colorsList[i].Name.ToString();
                            richInputsDetail.SelectionColor = Color.Black;

                            richInputsDetail.SelectedText = "): ";
                            richInputsDetail.SelectedText = neuro.inputs[i].ToString() + " - ";
                            for (int k = 0; k < neuro.spikeToInputs[i].Count; k++)
                            {
                                richInputsDetail.SelectedText = neuro.spikeToInputs[i][k].ToString() + ", ";
                            }
                            richInputsDetail.SelectedText = Environment.NewLine;
                        }
                    }
                }
                else
                    tabDetailsWindow.SelectedIndex = memTab;
            }
        }

        private void btnSimStop_Click(object sender, EventArgs e)
        {
            this.flags.isSimulatedFlag = false;
            this.treeView1.Enabled = true;
            this.methods.stopNetoworkThreads();
            //this.glob.potentialGraphMDIchild.stopGraph();
            this.groupBoxTools.Enabled = true;
            this.button2.Enabled = true;
            this.timerSimulation.Stop();
        }

        private void menuStripOptions_Click(object sender, EventArgs e)
        {
            OtherForms.Tools.ApplicationOptions appOptionsForm = new SNN.OtherForms.Tools.ApplicationOptions(this.glob, this.flags,this,this.vdhlVariables);
            appOptionsForm.ShowDialog();
        }

        private void menuStripInputFileTool_Click(object sender, EventArgs e)
        {
            try
            {
                OtherForms.Tools.StimuliCreator stimuliCreator = new SNN.OtherForms.Tools.StimuliCreator();
                stimuliCreator.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Stimuli Creator Window Open Exception", MessageBoxButtons.OK);
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStripGaussianRF_Click(object sender, EventArgs e)
        {
            try
            {
                OtherForms.Tools.Gaussian gaussian = new SNN.OtherForms.Tools.Gaussian();
                gaussian.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Gaussian Receptive fields Window Open Exception", MessageBoxButtons.OK);
            }
        }

        private void contentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String helpPath = Application.StartupPath.ToString() + "\\Help\\SNNHELP.CHM";
            try
            {
                Help.ShowHelp(this, @helpPath, HelpNavigator.TableOfContents);
            }
            catch (Exception exc)
            {
                MessageBox.Show(this.appMessages.noHelpFile[this.flags.languageIndexVar],this.appMessages.noHelpFileTitle[this.flags.languageIndexVar], MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void simInOutWindow_VisibleChanged(object sender, EventArgs e)
        {
            if (simInOutWindow.Visible == true)
            {
                this.menuStripWindowSimulation.Enabled = true;
                if (this.radioCodingPopulationSimple.Checked == true)
                {
                    tabSimulateInOut.SelectedIndex = 1;
                    this.flags.simulationModeFlag = 1;
                    this.glob.simInputBoxes = new TextBox[this.glob.numberInput];
                    this.glob.simInputLabels = new Label[this.glob.numberInput];

                    this.glob.sinOutputLabels = new Label[this.glob.numberOutput];
                    this.glob.simOutputBoxes = new TextBox[this.glob.numberOutput];

                    for (int i = 0; i < this.glob.simInputBoxes.Length; i++)
                    {
                        TextBox box = new TextBox();
                        box.Size = new Size(67, 20);
                        box.Location = new Point(68, 10 + i * 21);

                        this.glob.simInputBoxes[i] = box;

                        Label lbl = new Label();
                        lbl.Size = new Size(55, 20);
                        lbl.Location = new Point(8, 13 + i * 21);
                        lbl.Text = "Input " + (i + 1).ToString();

                        this.glob.simInputLabels[i] = lbl;

                        this.panelTemporalCodingInputs.Controls.Add(box);
                        this.panelTemporalCodingInputs.Controls.Add(lbl);
                    }
                    /*
                    for (int i = 0; i < this.glob.simOutputBoxes.Length; i++)
                    {
                        TextBox box = new TextBox();
                        box.Size = new Size(67, 20);
                        box.Location = new Point(68, 10 + i * 21);

                        this.glob.simOutputBoxes[i] = box;

                        Label lbl = new Label();
                        lbl.Size = new Size(55, 20);
                        lbl.Location = new Point(8, 13 + i * 21);
                        lbl.Text = "Output " + (i + 1).ToString();

                        this.glob.sinOutputLabels[i] = lbl;

                        this.panelTemporalCodingOutput.Controls.Add(box);
                        this.panelTemporalCodingOutput.Controls.Add(lbl);
                    }
                     */
                }
                if (this.radioCodingPopulationGauss.Checked == true)
                {
                    tabSimulateInOut.SelectedIndex = 2;
                    this.flags.simulationModeFlag = 2;
                    this.glob.simInputBoxes = new TextBox[this.glob.numberInput];
                    this.glob.simInputLabels = new Label[this.glob.numberInput];

                    this.glob.sinOutputLabels = new Label[this.glob.numberOutput];
                    this.glob.simOutputBoxes = new TextBox[this.glob.numberOutput];

                    /*
                    for (int i = 0; i < this.glob.simOutputBoxes.Length; i++)
                    {
                        TextBox box = new TextBox();
                        box.Size = new Size(67, 20);
                        box.Location = new Point(68, 10 + i * 21);

                        this.glob.simOutputBoxes[i] = box;

                        Label lbl = new Label();
                        lbl.Size = new Size(55, 20);
                        lbl.Location = new Point(8, 13 + i * 21);
                        lbl.Text = "Output " + (i + 1).ToString();

                        this.glob.sinOutputLabels[i] = lbl;

                        this.panelGaussianCodingOutputs.Controls.Add(box);
                        this.panelGaussianCodingOutputs.Controls.Add(lbl);
                    }
                     */
                }
                if (radioCodingImageRecognition.Checked == true)
                {
                    tabSimulateInOut.SelectedIndex = 3;
                    this.flags.simulationModeFlag = 3;
                    this.glob.simInputBoxes = new TextBox[0];
                    this.glob.simInputLabels = new Label[0];

                    this.glob.sinOutputLabels = new Label[this.glob.numberOutput];
                    this.glob.simOutputBoxes = new TextBox[this.glob.numberOutput];
                    /*
                    for (int i = 0; i < this.glob.simOutputBoxes.Length; i++)
                    {
                        TextBox box = new TextBox();
                        box.Size = new Size(67, 20);
                        box.Location = new Point(288, 10 + i * 21);

                        this.glob.simOutputBoxes[i] = box;

                        Label lbl = new Label();
                        lbl.Size = new Size(55, 20);
                        lbl.Location = new Point(228, 13 + i * 21);
                        lbl.Text = "Output " + (i + 1).ToString();

                        this.glob.sinOutputLabels[i] = lbl;

                        this.tabPage8.Controls.Add(box);
                        this.tabPage8.Controls.Add(lbl);
                    }
                    */
                    this.glob.codedCharacter = new PictureBox[Convert.ToInt32(this.maskedBoxImageRecFROM.Text), Convert.ToInt32(this.maskedBoxImageRecTO.Text)];
                    int offset = 0;
                    for (int i = 0; i < Convert.ToInt32(this.maskedBoxImageRecFROM.Text); i++)
                    {
                        for (int j = 0; j < Convert.ToInt32(this.maskedBoxImageRecTO.Text); j++)
                        {
                            this.glob.codedCharacter[i, j] = new PictureBox();
                            this.glob.codedCharacter[i, j].BackColor = Color.White;
                            this.glob.codedCharacter[i, j].Click += new EventHandler(pictureBox4_Click);
                            this.glob.codedCharacter[i, j].Tag = (i + (offset + j)).ToString();
                            this.glob.codedCharacter[i, j].Size = new Size(15, 15);
                            this.glob.codedCharacter[i, j].Location = new Point(20 + (i * 17), 25 + (j * 17));
                            this.tabPage8.Controls.Add(this.glob.codedCharacter[i, j]);
                        }

                        offset = offset + 1;
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.BackColor == Color.White)
            {
                pb.BackColor = Color.Black;
                int neuronNo = Convert.ToInt32((string)pb.Tag);
                if (this.flags.isSimulatedFlag == true)
                {
                    this.buttonStimulateImageRec.Text = pb.Tag.ToString();
                    int periodTime = Convert.ToInt32(this.maskedBoxInputDelayImageRec.Text);
                    ((InputNeuron)this.glob.inputNeurons[neuronNo].Tag).initialize((periodTime - (Convert.ToInt32(this.glob.time) % periodTime)) + 20);
                    ((InputNeuron)this.glob.inputNeurons[neuronNo].Tag).setNextDelay(periodTime);
                    System.Threading.ThreadStart ts = new System.Threading.ThreadStart(((InputNeuron)this.glob.inputNeurons[neuronNo].Tag).LaunchInput);
                    this.glob.inputThreads[neuronNo] = new System.Threading.Thread(ts);
                    this.glob.inputThreads[neuronNo].Start();

                }
            }
            else if (pb.BackColor == Color.Black)
            {
                pb.BackColor = Color.White;
                string codedNo = pb.Tag.ToString();
                int neuronNo = Convert.ToInt32(codedNo[0].ToString()) + Convert.ToInt32(codedNo[1].ToString());
                if (this.flags.isSimulatedFlag == true)
                {
                    this.glob.inputThreads[neuronNo].Abort();
                    ((InputNeuron)this.glob.inputNeurons[neuronNo].Tag).stopNeuron();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabSimulateInOut.SelectedIndex == 1)
            {
              DialogResult dr = DialogResult.Yes;

              try
              {
                  Convert.ToInt32(maskedBoxMaxValueTemporalCoding.Text);
                  for (int i = 0; i < this.glob.simInputBoxes.Length; i++ )
                  {
                      Convert.ToInt32(this.glob.simInputBoxes[i].Text);
                  }
              }
              catch 
              {
                  dr = MessageBox.Show(this.appMessages.missingValue[this.flags.languageIndexVar],this.appMessages.missingValueTitle[this.flags.languageIndexVar], MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
              if (dr == DialogResult.OK)
              {

              }
              else
              {
                  this.flags.outputIsRunFlag = this.glob.numberOutput;
                  for (int i = 0; i < this.glob.numberInput; i++)
                  {
                      ((InputNeuron)this.glob.inputNeurons[i].Tag).initialize(this.methods.convertValueIntoTime(Convert.ToInt32(maskedBoxMaxValueTemporalCoding.Text) + 1, Convert.ToInt32(this.glob.simInputBoxes[i].Text)));
                  }
                  this.methods.startNetworkWithTestMode();
              }
            }
            if (tabSimulateInOut.SelectedIndex == 2)
            {
                this.flags.outputIsRunFlag = this.glob.numberOutput;
            }
            this.btnSimStop.Enabled = true;
        }


        private void button8_Click(object sender, EventArgs e)
        {
              DialogResult dr = DialogResult.Yes;

              try
              {
                  Convert.ToInt32(this.maskedBoxValue.Text);
                  Convert.ToInt32(this.maskedBoxGamma.Text);
                  Convert.ToInt32(this.maskedBoxRangeFrom.Text);
                  Convert.ToInt32(this.maskedBoxRangeTo.Text);
                  Convert.ToInt32(this.maskedBoxTmax.Text);
                  Convert.ToInt32(this.maskedBoxFieldsNo.Text);
              }
              catch 
              {
                  dr = MessageBox.Show(this.appMessages.missingValue[this.flags.languageIndexVar],this.appMessages.missingValueTitle[this.flags.languageIndexVar], MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
              if (dr == DialogResult.OK)
              {

              }
              else
              {

                  int numberOfFields = Convert.ToInt32(this.maskedBoxFieldsNo.Text);
                  this.btnSimStop.Enabled = true;
                  double gamma = Convert.ToDouble(this.maskedBoxGamma.Text);
                  double max = Convert.ToDouble(this.maskedBoxRangeFrom.Text);
                  double min = Convert.ToDouble(this.maskedBoxRangeTo.Text);
                  double valueToEncode = Convert.ToDouble(this.maskedBoxValue.Text);
                  if((valueToEncode > max) || (valueToEncode < min))
                  {
                     DialogResult dresult = MessageBox.Show(this.appMessages.gaussianOutOfRange[this.flags.applicationModeFlag], this.appMessages.gaussianOutOfRangeTitle[this.flags.applicationModeFlag], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     if (dresult == DialogResult.OK)
                     {

                     }
                     else
                     {
                         double maxTime = Convert.ToDouble(this.maskedBoxTmax.Text);
                         int[] gaussianEncoded = new int[numberOfFields];
                         gaussianEncoded = this.methods.gaussianReceptiveFields(numberOfFields, gamma, max, min, valueToEncode, maxTime);
                         for (int i = 0; i < this.glob.numberInput; i++)
                         {
                             ((InputNeuron)this.glob.inputNeurons[i].Tag).initialize(gaussianEncoded[i]);
                         }
                         this.methods.startNetworkWithTestMode();
                     }
                  }
                  
              }
        }

        private void gaussianFile(double value)
        {
            int numberOfFields = this.glob.numberInput;
            double gamma = Convert.ToDouble(this.maskedBoxGammaSim.Text);
            double max = Convert.ToDouble(this.maskedBoxRangeSimFrom.Text);
            double min = Convert.ToDouble(this.maskedBoxRangeSimTo.Text);
            double valueToEncode = value;
            double maxTime = Convert.ToDouble(this.maskedBoxMaxTSim.Text);
            if ((valueToEncode > max) || (valueToEncode < min))
            {
            }
            else
            {
                    int[] gaussianEncoded = new int[numberOfFields];
                    gaussianEncoded = this.methods.gaussianReceptiveFields(numberOfFields, gamma, max, min, valueToEncode, maxTime);
                    for (int i = 0; i < this.glob.numberInput; i++)
                    {
                        ((InputNeuron)this.glob.inputNeurons[i].Tag).initialize(gaussianEncoded[i]);
                    }

            }
            
        }

        private void temporalFile(int value)
        {
            for (int i = 0; i < this.glob.numberInput; i++)
            {
                ((InputNeuron)this.glob.inputNeurons[i].Tag).initialize(this.methods.convertValueIntoTime(value + 1, Convert.ToInt32(this.glob.simInputBoxes[i].Text)));
            }
        }

        private void buttonStimulateImageRec_Click(object sender, EventArgs e)
        {
            int neuronNo = 0;
            this.flags.isSimulatedFlag = true;
            this.btnSimStop.Enabled = true;

            DialogResult dr = DialogResult.Yes;

              try
              {
                  Convert.ToInt32(this.maskedBoxInputDelayImageRec.Text);
              }
              catch 
              {
                  dr = MessageBox.Show(this.appMessages.missingValue[this.flags.languageIndexVar],this.appMessages.missingValueTitle[this.flags.languageIndexVar], MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
              if (dr == DialogResult.OK)
              {

              }
              else
              {
                  for (int i = 0; i < this.glob.numberInput; i++)
                  {
                      ((InputNeuron)this.glob.inputNeurons[i].Tag).initialize(Convert.ToInt32(this.maskedBoxInputDelayImageRec.Text));
                  }
                  this.methods.createThreads();
                  for (int i = 0; i < Convert.ToInt32(this.maskedBoxImageRecFROM.Text); i++)
                  {
                      for (int j = 0; j < Convert.ToInt32(this.maskedBoxImageRecTO.Text); j++)
                      {
                          if (this.glob.codedCharacter[j, i].BackColor == Color.Black)
                              this.glob.inputThreads[neuronNo].Start();
                          neuronNo++;
                      }

                  }
                  for (int i = 0; i < this.glob.numberLayer1; i++)
                      this.glob.layer1Threads[i].Start();
                  for (int i = 0; i < this.glob.numberOutput; i++)
                      this.glob.outputThreads[i].Start();

                  for (int i = 0; i < this.glob.numberInput; i++)
                  {
                      for (int j = 0; j < this.glob.numberLayer1; j++)
                      {
                          this.glob.threadsInLay1Synapses[i, j].Start();
                      }
                  }
                  for (int i = 0; i < this.glob.numberLayer1; i++)
                  {
                      for (int j = 0; j < this.glob.numberOutput; j++)
                      {
                          this.glob.threadsLay1OutSynapses[i, j].Start();
                      }
                  }
                  this.flags.outputIsRunFlag = this.glob.numberOutput;
                  this.flags.simulationModeFlag = 4;
                  this.timerSimulation.Start();
              }
        }

        private void SNNmain_FormClosed(object sender, FormClosedEventArgs e)
        {

            Properties.Settings.Default.languageChange = true;
            Properties.Settings.Default.Save();
        }

        private void SNNmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.flags.isSimulatedFlag == true)
            {
                DialogResult dr = MessageBox.Show(this.appMessages.simulationInProgress[this.flags.languageIndexVar],this.appMessages.simulationInProgressTitle[this.flags.languageIndexVar],MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    this.methods.stopNetoworkThreads();
                }
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnImageEnd_Click(object sender, EventArgs e)
        {
            this.finishSimulation();
        }

        private void menuStripAbout_Click(object sender, EventArgs e)
        {
            SNN.OtherForms.Help.About aboutForm = new SNN.OtherForms.Help.About();
            aboutForm.ShowDialog();
        }

        private void menuStripGenerateVHDL_Click(object sender, EventArgs e)
        {
            SNN.OtherForms.Tools.Generator generatorForm = new SNN.OtherForms.Tools.Generator(this.glob, this.flags,this.vdhlVariables);
            generatorForm.Show();
        }
        public Boolean radioLayer2checked
        {
            get { return this.radioButton2.Checked; }
            set { this.radioButton2.Checked = value; }
        }

        private void groupPSPFunction_Enter(object sender, EventArgs e)
        {

        }

        private void btnGaussianEnd_Click(object sender, EventArgs e)
        {
            this.finishSimulation();
        }

        private void btnTemporalEnd_Click(object sender, EventArgs e)
        {
            this.finishSimulation();
        }
        private void finishSimulation()
        {

            if (this.flags.isSimulatedFlag == true)
            {
                DialogResult resultD = MessageBox.Show(this.appMessages.simulationInProgress[this.flags.languageIndexVar], this.appMessages.simulationInProgressTitle[this.flags.languageIndexVar], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultD == DialogResult.Yes)
                {
                    this.methods.stopNetoworkThreads();
                    if (this.radioOutFile.Checked == true)
                    {
                        TextWriter tw = new StreamWriter(this.textBoxOutputFile.Text);
                        foreach (string str in this.glob.outputLines)
                            tw.WriteLine(str);
                        tw.Close();
                    }
                    this.simInOutWindow.Visible = false;
                    this.menuStripWindowSimulation.Checked = false;
                    this.menuStripWindowSimulation.Enabled = false;
                    this.simulationWindow.Visible = false;
                    this.menuStripWindowInitialization.Enabled = false;
                    this.menuStripWindowInitialization.Checked = false;
                    this.menuStripInitializeSimulation.Checked = false;
                    this.togleSimulationPathIcons(0);
                    this.clearSimulationWindow();
                    this.tabSim.SelectedIndex = 0;
                    this.toolStripBoxTime.Text = "0 ms";
                }
                else if (resultD == DialogResult.No)
                {

                }
            }

        }

        private void toolNew_Click(object sender, EventArgs e)
        {
            this.newProject();
        }

        private void toolOpen_Click(object sender, EventArgs e)
        {
            this.loadStruct();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            this.saveStruct();
        }

        private void radioCodingPopulationGauss_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioCodingPopulationGauss.Checked == true)
            {
                this.lblGammaSim.Visible = true;
                this.maskedBoxGammaSim.Visible = true;
                this.lblMaxTSim.Visible = true;
                this.maskedBoxRangeSimFrom.Visible = true;
                this.maskedBoxRangeSimTo.Visible = true;
                this.label3.Visible = true;
                this.lblRangeSim.Visible = true;
                this.maskedBoxMaxTSim.Visible = true;
            }
        }

        private void radioCodingPopulationSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioCodingPopulationSimple.Checked == true)
            {
                this.lblGammaSim.Visible = false;
                this.maskedBoxGammaSim.Visible = false;
                this.lblMaxTSim.Visible = true;
                this.maskedBoxRangeSimFrom.Visible = false;
                this.maskedBoxRangeSimTo.Visible = false;
                this.label3.Visible = false;
                this.lblRangeSim.Visible = false;
                this.maskedBoxMaxTSim.Visible = true;
            }
        }

        private void radioCodingImageRecognition_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCodingImageRecognition.Checked == true)
            {
                this.lblImageRecLabel.Visible = true;
                this.lblImageRecX.Visible = true;
                this.maskedBoxImageRecFROM.Visible = true;
                this.maskedBoxImageRecTO.Visible = true;
                this.lblGammaSim.Visible = false;
                this.maskedBoxGammaSim.Visible = false;
                this.lblMaxTSim.Visible = false;
                this.maskedBoxRangeSimFrom.Visible = false;
                this.maskedBoxRangeSimTo.Visible = false;
                this.label3.Visible = false;
                this.lblRangeSim.Visible = false;
                this.maskedBoxMaxTSim.Visible = false;
            }
            else
            {
                this.lblImageRecLabel.Visible = false;
                this.lblImageRecX.Visible = false;
                this.maskedBoxImageRecFROM.Visible = false;
                this.maskedBoxImageRecTO.Visible = false;
            }
        }

        private void tabSimCoding_Click(object sender, EventArgs e)
        {

        }

        private void menuStripFile_Click(object sender, EventArgs e)
        {

        }


    }
}
