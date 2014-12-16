namespace SNN
{
    partial class SNNmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNNmain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Simulation Preferences");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Data Source");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Input Coding Mode");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Network Initialization");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Learning Rules");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Simulation");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Simulation Path:", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripApplicationMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripModeSNN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripModeANN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripStructureToolBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripWindowWorkspace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripWindowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripWindowInitialization = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripWindowSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInitializeSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPlot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPlotInput = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPlotLayer1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPlotOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripPlotEntireNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripGaussianRF = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInputFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripGenerateVHDL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolNew = new System.Windows.Forms.ToolStripButton();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBoxTime = new System.Windows.Forms.ToolStripTextBox();
            this.designEditor = new System.Windows.Forms.Panel();
            this.groupBoxStructure = new System.Windows.Forms.GroupBox();
            this.btnUpdateStructure = new System.Windows.Forms.Button();
            this.boxOutput = new System.Windows.Forms.MaskedTextBox();
            this.lblOutputNr = new System.Windows.Forms.Label();
            this.boxLayer2 = new System.Windows.Forms.MaskedTextBox();
            this.lblLayer2Nr = new System.Windows.Forms.Label();
            this.boxLayer1 = new System.Windows.Forms.MaskedTextBox();
            this.lblLayer1Nr = new System.Windows.Forms.Label();
            this.boxInput = new System.Windows.Forms.MaskedTextBox();
            this.lblInputNr = new System.Windows.Forms.Label();
            this.groupBoxLayers = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolMousePointer = new System.Windows.Forms.PictureBox();
            this.toolNeuronEraser = new System.Windows.Forms.PictureBox();
            this.designEditorHeader = new System.Windows.Forms.Panel();
            this.designEditorClose = new System.Windows.Forms.PictureBox();
            this.designEditorHeaderTitle = new System.Windows.Forms.Label();
            this.detailsWindow = new System.Windows.Forms.Panel();
            this.tabDetailsWindow = new System.Windows.Forms.TabControl();
            this.tabDetailsWindowTab0 = new System.Windows.Forms.TabPage();
            this.boxThreshold = new System.Windows.Forms.TextBox();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.lblPotential = new System.Windows.Forms.Label();
            this.inputsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxWeight = new System.Windows.Forms.TextBox();
            this.boxDelay = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.detailShape = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabDetailsWindowTab1 = new System.Windows.Forms.TabPage();
            this.tabDetailsWindowTab2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.detailsWindowHeader = new System.Windows.Forms.Panel();
            this.lblWhichLayer = new System.Windows.Forms.Label();
            this.detailsWindowClose = new System.Windows.Forms.PictureBox();
            this.detailsWindowHeaderTitle = new System.Windows.Forms.Label();
            this.simulationWindow = new System.Windows.Forms.Panel();
            this.tabSim = new System.Windows.Forms.TabControl();
            this.tabSimPref = new System.Windows.Forms.TabPage();
            this.groupPSPFunction = new System.Windows.Forms.GroupBox();
            this.radioRealPSP = new System.Windows.Forms.RadioButton();
            this.radioIdealPSP = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabSimSource = new System.Windows.Forms.TabPage();
            this.groupDataSrc = new System.Windows.Forms.GroupBox();
            this.maskedBoxStimuliFileTime = new System.Windows.Forms.MaskedTextBox();
            this.lblStimuliFileTime = new System.Windows.Forms.Label();
            this.BoxStimuliPerEpoch = new System.Windows.Forms.MaskedTextBox();
            this.lblStimuliPerEpoch = new System.Windows.Forms.Label();
            this.radioSrcTest = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.boxSourceFile = new System.Windows.Forms.TextBox();
            this.radioSrcFile = new System.Windows.Forms.RadioButton();
            this.radioSrcManual = new System.Windows.Forms.RadioButton();
            this.tabSimCoding = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRangeSim = new System.Windows.Forms.Label();
            this.lblMaxTSim = new System.Windows.Forms.Label();
            this.lblGammaSim = new System.Windows.Forms.Label();
            this.maskedBoxImageRecTO = new System.Windows.Forms.MaskedTextBox();
            this.lblImageRecX = new System.Windows.Forms.Label();
            this.maskedBoxMaxTSim = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxImageRecFROM = new System.Windows.Forms.MaskedTextBox();
            this.lblImageRecLabel = new System.Windows.Forms.Label();
            this.radioCodingImageRecognition = new System.Windows.Forms.RadioButton();
            this.radioCodingPopulationGauss = new System.Windows.Forms.RadioButton();
            this.maskedBoxRangeSimTo = new System.Windows.Forms.MaskedTextBox();
            this.radioCodingPopulationSimple = new System.Windows.Forms.RadioButton();
            this.lblCodingMode = new System.Windows.Forms.Label();
            this.maskedBoxGammaSim = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxRangeSimFrom = new System.Windows.Forms.MaskedTextBox();
            this.tabSimInit = new System.Windows.Forms.TabPage();
            this.checkBoxRandomParameters = new System.Windows.Forms.CheckBox();
            this.groupDealyInit = new System.Windows.Forms.GroupBox();
            this.maskedBoxDelayInputTo = new System.Windows.Forms.MaskedTextBox();
            this.lblInputDelayInit = new System.Windows.Forms.Label();
            this.maskedBoxLayerDelayTo = new System.Windows.Forms.MaskedTextBox();
            this.lblLayerDelay = new System.Windows.Forms.Label();
            this.groupWeightInit = new System.Windows.Forms.GroupBox();
            this.maskedBoxRandomTo = new System.Windows.Forms.MaskedTextBox();
            this.lblWeightRandomSeparator = new System.Windows.Forms.Label();
            this.maskedBoxRandomFrom = new System.Windows.Forms.MaskedTextBox();
            this.lblWeightInitParams = new System.Windows.Forms.Label();
            this.maskedBoxThreshold = new System.Windows.Forms.MaskedTextBox();
            this.lblNeuronThr = new System.Windows.Forms.Label();
            this.tabSimLearning = new System.Windows.Forms.TabPage();
            this.tabLearning = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.maskedBoxMinW = new System.Windows.Forms.MaskedTextBox();
            this.lblMinWeight = new System.Windows.Forms.Label();
            this.maskedBoxMaxW = new System.Windows.Forms.MaskedTextBox();
            this.lblMaxWeight = new System.Windows.Forms.Label();
            this.maskedBoxA = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.maskedBoxTauP = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxTauD = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioLearningNone = new System.Windows.Forms.RadioButton();
            this.radioLearningSTDP = new System.Windows.Forms.RadioButton();
            this.lblLearningRules = new System.Windows.Forms.Label();
            this.tabSimStart = new System.Windows.Forms.TabPage();
            this.btnSimStop = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.boxSelectWeights = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioOutNothing = new System.Windows.Forms.RadioButton();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.radioOutFile = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOutputInterpretation = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.simulationWindowHeader = new System.Windows.Forms.Panel();
            this.simulationWindowHeaderTitle = new System.Windows.Forms.Label();
            this.simulationWindowClose = new System.Windows.Forms.PictureBox();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.richInputsDetail = new System.Windows.Forms.RichTextBox();
            this.simInOutWindow = new System.Windows.Forms.Panel();
            this.tabSimulateInOut = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnTemporalEnd = new System.Windows.Forms.Button();
            this.lblTemporalMaxValue = new System.Windows.Forms.Label();
            this.maskedBoxMaxValueTemporalCoding = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panelTemporalCodingOutput = new System.Windows.Forms.Panel();
            this.panelTemporalCodingInputs = new System.Windows.Forms.Panel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnGaussianEnd = new System.Windows.Forms.Button();
            this.maskedBoxFieldsNo = new System.Windows.Forms.MaskedTextBox();
            this.lblGaussianSimFields = new System.Windows.Forms.Label();
            this.maskedBoxTmax = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.maskedBoxRangeTo = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.maskedBoxRangeFrom = new System.Windows.Forms.MaskedTextBox();
            this.lblGaussianSimRange = new System.Windows.Forms.Label();
            this.lblGaussianSimGamma = new System.Windows.Forms.Label();
            this.maskedBoxGamma = new System.Windows.Forms.MaskedTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panelGaussianCodingOutputs = new System.Windows.Forms.Panel();
            this.panelGaussianCodingInput = new System.Windows.Forms.Panel();
            this.maskedBoxValue = new System.Windows.Forms.MaskedTextBox();
            this.lblGaussianInputValue = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnImageEnd = new System.Windows.Forms.Button();
            this.buttonStimulateImageRec = new System.Windows.Forms.Button();
            this.maskedBoxInputDelayImageRec = new System.Windows.Forms.MaskedTextBox();
            this.lblInputNeuronDelaySim = new System.Windows.Forms.Label();
            this.lblCharacterRepresentation = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.simInOutWindowHeader = new System.Windows.Forms.Panel();
            this.simInOutWindowTitle = new System.Windows.Forms.Label();
            this.simInOutWindowClose = new System.Windows.Forms.PictureBox();
            this.openStructDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveStructDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDataSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.timerSimulation = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.designEditor.SuspendLayout();
            this.groupBoxStructure.SuspendLayout();
            this.groupBoxLayers.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolMousePointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolNeuronEraser)).BeginInit();
            this.designEditorHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designEditorClose)).BeginInit();
            this.detailsWindow.SuspendLayout();
            this.tabDetailsWindow.SuspendLayout();
            this.tabDetailsWindowTab0.SuspendLayout();
            this.inputsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.detailsWindowHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsWindowClose)).BeginInit();
            this.simulationWindow.SuspendLayout();
            this.tabSim.SuspendLayout();
            this.tabSimPref.SuspendLayout();
            this.groupPSPFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabSimSource.SuspendLayout();
            this.groupDataSrc.SuspendLayout();
            this.tabSimCoding.SuspendLayout();
            this.tabSimInit.SuspendLayout();
            this.groupDealyInit.SuspendLayout();
            this.groupWeightInit.SuspendLayout();
            this.tabSimLearning.SuspendLayout();
            this.tabLearning.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabSimStart.SuspendLayout();
            this.simulationWindowHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationWindowClose)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.simInOutWindow.SuspendLayout();
            this.tabSimulateInOut.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panelGaussianCodingInput.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.simInOutWindowHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simInOutWindowClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripView,
            this.menuStripSimulation,
            this.menuStripTools,
            this.menuStripHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNew,
            this.menuStripLoad,
            this.menuStripSave,
            this.toolStripSeparator1,
            this.menuStripApplicationMode,
            this.toolStripSeparator7,
            this.menuStripRecent,
            this.toolStripSeparator4,
            this.menuStripExit});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "&File";
            this.menuStripFile.Click += new System.EventHandler(this.menuStripFile_Click);
            // 
            // menuStripNew
            // 
            this.menuStripNew.Image = ((System.Drawing.Image)(resources.GetObject("menuStripNew.Image")));
            this.menuStripNew.Name = "menuStripNew";
            this.menuStripNew.Size = new System.Drawing.Size(194, 22);
            this.menuStripNew.Text = "&New";
            this.menuStripNew.Click += new System.EventHandler(this.menuStripNew_Click);
            // 
            // menuStripLoad
            // 
            this.menuStripLoad.Image = ((System.Drawing.Image)(resources.GetObject("menuStripLoad.Image")));
            this.menuStripLoad.Name = "menuStripLoad";
            this.menuStripLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuStripLoad.Size = new System.Drawing.Size(194, 22);
            this.menuStripLoad.Text = "&Load Structure";
            this.menuStripLoad.Click += new System.EventHandler(this.menuStripLoad_Click);
            // 
            // menuStripSave
            // 
            this.menuStripSave.Image = ((System.Drawing.Image)(resources.GetObject("menuStripSave.Image")));
            this.menuStripSave.Name = "menuStripSave";
            this.menuStripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuStripSave.Size = new System.Drawing.Size(194, 22);
            this.menuStripSave.Text = "&Save Structure";
            this.menuStripSave.Click += new System.EventHandler(this.menuStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // menuStripApplicationMode
            // 
            this.menuStripApplicationMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripModeSNN,
            this.menuStripModeANN});
            this.menuStripApplicationMode.Name = "menuStripApplicationMode";
            this.menuStripApplicationMode.Size = new System.Drawing.Size(194, 22);
            this.menuStripApplicationMode.Text = "Application Mode";
            // 
            // menuStripModeSNN
            // 
            this.menuStripModeSNN.Name = "menuStripModeSNN";
            this.menuStripModeSNN.Size = new System.Drawing.Size(171, 22);
            this.menuStripModeSNN.Text = "Spiking Networks";
            this.menuStripModeSNN.CheckedChanged += new System.EventHandler(this.menuStripModeSNN_CheckedChanged);
            this.menuStripModeSNN.Click += new System.EventHandler(this.menuStripModeSNN_Click);
            // 
            // menuStripModeANN
            // 
            this.menuStripModeANN.Name = "menuStripModeANN";
            this.menuStripModeANN.Size = new System.Drawing.Size(171, 22);
            this.menuStripModeANN.Text = "Artificial Networks";
            this.menuStripModeANN.CheckedChanged += new System.EventHandler(this.menuStripModeANN_CheckedChanged);
            this.menuStripModeANN.Click += new System.EventHandler(this.menuStripModeANN_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(191, 6);
            // 
            // menuStripRecent
            // 
            this.menuStripRecent.Name = "menuStripRecent";
            this.menuStripRecent.Size = new System.Drawing.Size(194, 22);
            this.menuStripRecent.Text = "Recent Projects";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // menuStripExit
            // 
            this.menuStripExit.Image = ((System.Drawing.Image)(resources.GetObject("menuStripExit.Image")));
            this.menuStripExit.Name = "menuStripExit";
            this.menuStripExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuStripExit.Size = new System.Drawing.Size(194, 22);
            this.menuStripExit.Text = "E&xit";
            this.menuStripExit.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // menuStripView
            // 
            this.menuStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripStructureToolBox,
            this.toolStripSeparator3,
            this.menuStripWindows});
            this.menuStripView.Name = "menuStripView";
            this.menuStripView.Size = new System.Drawing.Size(44, 20);
            this.menuStripView.Text = "&View";
            // 
            // menuStripStructureToolBox
            // 
            this.menuStripStructureToolBox.Enabled = false;
            this.menuStripStructureToolBox.Name = "menuStripStructureToolBox";
            this.menuStripStructureToolBox.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuStripStructureToolBox.Size = new System.Drawing.Size(208, 22);
            this.menuStripStructureToolBox.Text = "Structure ToolBox";
            this.menuStripStructureToolBox.Click += new System.EventHandler(this.menuStripStructureToolBox_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // menuStripWindows
            // 
            this.menuStripWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripWindowWorkspace,
            this.menuStripWindowDetails,
            this.menuStripWindowInitialization,
            this.menuStripWindowSimulation});
            this.menuStripWindows.Image = ((System.Drawing.Image)(resources.GetObject("menuStripWindows.Image")));
            this.menuStripWindows.Name = "menuStripWindows";
            this.menuStripWindows.Size = new System.Drawing.Size(208, 22);
            this.menuStripWindows.Text = "&Windows";
            // 
            // menuStripWindowWorkspace
            // 
            this.menuStripWindowWorkspace.Enabled = false;
            this.menuStripWindowWorkspace.Name = "menuStripWindowWorkspace";
            this.menuStripWindowWorkspace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.menuStripWindowWorkspace.Size = new System.Drawing.Size(238, 22);
            this.menuStripWindowWorkspace.Text = "Workspace";
            this.menuStripWindowWorkspace.Click += new System.EventHandler(this.menuStripWindowWorkspace_Click);
            // 
            // menuStripWindowDetails
            // 
            this.menuStripWindowDetails.Enabled = false;
            this.menuStripWindowDetails.Name = "menuStripWindowDetails";
            this.menuStripWindowDetails.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.menuStripWindowDetails.Size = new System.Drawing.Size(238, 22);
            this.menuStripWindowDetails.Text = "Neuron Details";
            this.menuStripWindowDetails.Click += new System.EventHandler(this.menuStripWindowDetails_Click);
            // 
            // menuStripWindowInitialization
            // 
            this.menuStripWindowInitialization.Enabled = false;
            this.menuStripWindowInitialization.Name = "menuStripWindowInitialization";
            this.menuStripWindowInitialization.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.menuStripWindowInitialization.Size = new System.Drawing.Size(238, 22);
            this.menuStripWindowInitialization.Text = "Simulation Initialization";
            this.menuStripWindowInitialization.Click += new System.EventHandler(this.menuStripWindowInitialization_Click);
            // 
            // menuStripWindowSimulation
            // 
            this.menuStripWindowSimulation.Enabled = false;
            this.menuStripWindowSimulation.Name = "menuStripWindowSimulation";
            this.menuStripWindowSimulation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.menuStripWindowSimulation.Size = new System.Drawing.Size(238, 22);
            this.menuStripWindowSimulation.Text = "Simulation";
            this.menuStripWindowSimulation.Click += new System.EventHandler(this.menuStripWindowSimulation_Click);
            // 
            // menuStripSimulation
            // 
            this.menuStripSimulation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripInitializeSimulation});
            this.menuStripSimulation.Name = "menuStripSimulation";
            this.menuStripSimulation.Size = new System.Drawing.Size(76, 20);
            this.menuStripSimulation.Text = "Si&mulation";
            // 
            // menuStripInitializeSimulation
            // 
            this.menuStripInitializeSimulation.Image = ((System.Drawing.Image)(resources.GetObject("menuStripInitializeSimulation.Image")));
            this.menuStripInitializeSimulation.Name = "menuStripInitializeSimulation";
            this.menuStripInitializeSimulation.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.menuStripInitializeSimulation.Size = new System.Drawing.Size(196, 22);
            this.menuStripInitializeSimulation.Text = "&Initialize Simulation";
            this.menuStripInitializeSimulation.CheckedChanged += new System.EventHandler(this.menuStripInitializeSimulation_CheckedChanged);
            this.menuStripInitializeSimulation.Click += new System.EventHandler(this.menuStripInitializeSimulation_Click);
            // 
            // menuStripTools
            // 
            this.menuStripTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripPlot,
            this.menuStripGaussianRF,
            this.menuStripInputFileTool,
            this.toolStripSeparator2,
            this.menuStripGenerateVHDL,
            this.toolStripSeparator8,
            this.menuStripOptions});
            this.menuStripTools.Name = "menuStripTools";
            this.menuStripTools.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuStripTools.Size = new System.Drawing.Size(48, 20);
            this.menuStripTools.Text = "&Tools";
            // 
            // menuStripPlot
            // 
            this.menuStripPlot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripPlotInput,
            this.menuStripPlotLayer1,
            this.menuStripPlotOutput,
            this.toolStripSeparator5,
            this.menuStripPlotEntireNetwork});
            this.menuStripPlot.Image = ((System.Drawing.Image)(resources.GetObject("menuStripPlot.Image")));
            this.menuStripPlot.Name = "menuStripPlot";
            this.menuStripPlot.Size = new System.Drawing.Size(208, 22);
            this.menuStripPlot.Text = "Polot Spikes";
            // 
            // menuStripPlotInput
            // 
            this.menuStripPlotInput.Name = "menuStripPlotInput";
            this.menuStripPlotInput.Size = new System.Drawing.Size(195, 22);
            this.menuStripPlotInput.Text = "Input Layer";
            this.menuStripPlotInput.Click += new System.EventHandler(this.menuStripPlotInput_Click);
            // 
            // menuStripPlotLayer1
            // 
            this.menuStripPlotLayer1.Name = "menuStripPlotLayer1";
            this.menuStripPlotLayer1.Size = new System.Drawing.Size(195, 22);
            this.menuStripPlotLayer1.Text = "Layer 1";
            this.menuStripPlotLayer1.Click += new System.EventHandler(this.menuStripPlotLayer1_Click);
            // 
            // menuStripPlotOutput
            // 
            this.menuStripPlotOutput.Name = "menuStripPlotOutput";
            this.menuStripPlotOutput.Size = new System.Drawing.Size(195, 22);
            this.menuStripPlotOutput.Text = "Output Layer";
            this.menuStripPlotOutput.Click += new System.EventHandler(this.menuStripPlotOutput_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(192, 6);
            // 
            // menuStripPlotEntireNetwork
            // 
            this.menuStripPlotEntireNetwork.Name = "menuStripPlotEntireNetwork";
            this.menuStripPlotEntireNetwork.Size = new System.Drawing.Size(195, 22);
            this.menuStripPlotEntireNetwork.Text = "Entire Network Activity";
            this.menuStripPlotEntireNetwork.Click += new System.EventHandler(this.menuStripPlotEntireNetwork_Click);
            // 
            // menuStripGaussianRF
            // 
            this.menuStripGaussianRF.Image = ((System.Drawing.Image)(resources.GetObject("menuStripGaussianRF.Image")));
            this.menuStripGaussianRF.Name = "menuStripGaussianRF";
            this.menuStripGaussianRF.Size = new System.Drawing.Size(208, 22);
            this.menuStripGaussianRF.Text = "Gaussian Receptive Fields";
            this.menuStripGaussianRF.Click += new System.EventHandler(this.menuStripGaussianRF_Click);
            // 
            // menuStripInputFileTool
            // 
            this.menuStripInputFileTool.Image = ((System.Drawing.Image)(resources.GetObject("menuStripInputFileTool.Image")));
            this.menuStripInputFileTool.Name = "menuStripInputFileTool";
            this.menuStripInputFileTool.Size = new System.Drawing.Size(208, 22);
            this.menuStripInputFileTool.Text = "Input File Generator";
            this.menuStripInputFileTool.Click += new System.EventHandler(this.menuStripInputFileTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // menuStripGenerateVHDL
            // 
            this.menuStripGenerateVHDL.Enabled = false;
            this.menuStripGenerateVHDL.Name = "menuStripGenerateVHDL";
            this.menuStripGenerateVHDL.Size = new System.Drawing.Size(208, 22);
            this.menuStripGenerateVHDL.Text = "Generate VHDL Code";
            this.menuStripGenerateVHDL.Click += new System.EventHandler(this.menuStripGenerateVHDL_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(205, 6);
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuStripOptions.Image")));
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuStripOptions.Size = new System.Drawing.Size(208, 22);
            this.menuStripOptions.Text = "Options...";
            this.menuStripOptions.Click += new System.EventHandler(this.menuStripOptions_Click);
            // 
            // menuStripHelp
            // 
            this.menuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentToolStripMenuItem,
            this.menuStripAbout});
            this.menuStripHelp.Name = "menuStripHelp";
            this.menuStripHelp.Size = new System.Drawing.Size(44, 20);
            this.menuStripHelp.Text = "&Help";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contentToolStripMenuItem.Image")));
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.contentToolStripMenuItem.Text = "Open Help";
            this.contentToolStripMenuItem.Click += new System.EventHandler(this.contentToolStripMenuItem_Click);
            // 
            // menuStripAbout
            // 
            this.menuStripAbout.Image = ((System.Drawing.Image)(resources.GetObject("menuStripAbout.Image")));
            this.menuStripAbout.Name = "menuStripAbout";
            this.menuStripAbout.Size = new System.Drawing.Size(150, 22);
            this.menuStripAbout.Text = "&About";
            this.menuStripAbout.Click += new System.EventHandler(this.menuStripAbout_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolOpen,
            this.toolSave,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.toolStripBoxTime});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1091, 27);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolNew
            // 
            this.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNew.Image = ((System.Drawing.Image)(resources.GetObject("toolNew.Image")));
            this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(23, 24);
            this.toolNew.Text = "New structure";
            this.toolNew.ToolTipText = "New structure";
            this.toolNew.Click += new System.EventHandler(this.toolNew_Click);
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolOpen.Image")));
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(23, 24);
            this.toolOpen.Text = "Open structure";
            this.toolOpen.Click += new System.EventHandler(this.toolOpen_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 24);
            this.toolSave.Text = "Save structure";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 24);
            this.toolStripLabel1.Text = "Simulation Time:";
            // 
            // toolStripBoxTime
            // 
            this.toolStripBoxTime.Enabled = false;
            this.toolStripBoxTime.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.toolStripBoxTime.Name = "toolStripBoxTime";
            this.toolStripBoxTime.Size = new System.Drawing.Size(60, 23);
            this.toolStripBoxTime.Text = "0 ms";
            this.toolStripBoxTime.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // designEditor
            // 
            this.designEditor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.designEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designEditor.Controls.Add(this.groupBoxStructure);
            this.designEditor.Controls.Add(this.groupBoxLayers);
            this.designEditor.Controls.Add(this.groupBoxTools);
            this.designEditor.Controls.Add(this.designEditorHeader);
            this.designEditor.Location = new System.Drawing.Point(2, 52);
            this.designEditor.Name = "designEditor";
            this.designEditor.Size = new System.Drawing.Size(159, 279);
            this.designEditor.TabIndex = 4;
            this.designEditor.Visible = false;
            // 
            // groupBoxStructure
            // 
            this.groupBoxStructure.Controls.Add(this.btnUpdateStructure);
            this.groupBoxStructure.Controls.Add(this.boxOutput);
            this.groupBoxStructure.Controls.Add(this.lblOutputNr);
            this.groupBoxStructure.Controls.Add(this.boxLayer2);
            this.groupBoxStructure.Controls.Add(this.lblLayer2Nr);
            this.groupBoxStructure.Controls.Add(this.boxLayer1);
            this.groupBoxStructure.Controls.Add(this.lblLayer1Nr);
            this.groupBoxStructure.Controls.Add(this.boxInput);
            this.groupBoxStructure.Controls.Add(this.lblInputNr);
            this.groupBoxStructure.Location = new System.Drawing.Point(3, 117);
            this.groupBoxStructure.Name = "groupBoxStructure";
            this.groupBoxStructure.Size = new System.Drawing.Size(151, 154);
            this.groupBoxStructure.TabIndex = 6;
            this.groupBoxStructure.TabStop = false;
            this.groupBoxStructure.Text = "Structure";
            // 
            // btnUpdateStructure
            // 
            this.btnUpdateStructure.Location = new System.Drawing.Point(66, 125);
            this.btnUpdateStructure.Name = "btnUpdateStructure";
            this.btnUpdateStructure.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStructure.TabIndex = 19;
            this.btnUpdateStructure.Text = "Update";
            this.btnUpdateStructure.UseVisualStyleBackColor = true;
            this.btnUpdateStructure.Click += new System.EventHandler(this.btnUpdateStructure_Click);
            // 
            // boxOutput
            // 
            this.boxOutput.Location = new System.Drawing.Point(89, 97);
            this.boxOutput.Mask = "000";
            this.boxOutput.Name = "boxOutput";
            this.boxOutput.PromptChar = ' ';
            this.boxOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxOutput.Size = new System.Drawing.Size(52, 20);
            this.boxOutput.TabIndex = 18;
            this.boxOutput.Text = "0";
            this.boxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutputNr
            // 
            this.lblOutputNr.AutoSize = true;
            this.lblOutputNr.Location = new System.Drawing.Point(10, 100);
            this.lblOutputNr.Name = "lblOutputNr";
            this.lblOutputNr.Size = new System.Drawing.Size(71, 13);
            this.lblOutputNr.TabIndex = 17;
            this.lblOutputNr.Text = "Output Layer:";
            // 
            // boxLayer2
            // 
            this.boxLayer2.Location = new System.Drawing.Point(89, 72);
            this.boxLayer2.Mask = "000";
            this.boxLayer2.Name = "boxLayer2";
            this.boxLayer2.PromptChar = ' ';
            this.boxLayer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxLayer2.Size = new System.Drawing.Size(52, 20);
            this.boxLayer2.TabIndex = 16;
            this.boxLayer2.Text = "0";
            this.boxLayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxLayer2.Visible = false;
            // 
            // lblLayer2Nr
            // 
            this.lblLayer2Nr.AutoSize = true;
            this.lblLayer2Nr.Location = new System.Drawing.Point(10, 75);
            this.lblLayer2Nr.Name = "lblLayer2Nr";
            this.lblLayer2Nr.Size = new System.Drawing.Size(45, 13);
            this.lblLayer2Nr.TabIndex = 15;
            this.lblLayer2Nr.Text = "Layer 2:";
            this.lblLayer2Nr.Visible = false;
            // 
            // boxLayer1
            // 
            this.boxLayer1.Location = new System.Drawing.Point(89, 47);
            this.boxLayer1.Mask = "000";
            this.boxLayer1.Name = "boxLayer1";
            this.boxLayer1.PromptChar = ' ';
            this.boxLayer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxLayer1.Size = new System.Drawing.Size(52, 20);
            this.boxLayer1.TabIndex = 14;
            this.boxLayer1.Text = "0";
            this.boxLayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLayer1Nr
            // 
            this.lblLayer1Nr.AutoSize = true;
            this.lblLayer1Nr.Location = new System.Drawing.Point(10, 50);
            this.lblLayer1Nr.Name = "lblLayer1Nr";
            this.lblLayer1Nr.Size = new System.Drawing.Size(45, 13);
            this.lblLayer1Nr.TabIndex = 13;
            this.lblLayer1Nr.Text = "Layer 1:";
            // 
            // boxInput
            // 
            this.boxInput.Location = new System.Drawing.Point(89, 21);
            this.boxInput.Mask = "000";
            this.boxInput.Name = "boxInput";
            this.boxInput.PromptChar = ' ';
            this.boxInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxInput.Size = new System.Drawing.Size(52, 20);
            this.boxInput.TabIndex = 11;
            this.boxInput.Text = "0";
            this.boxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInputNr
            // 
            this.lblInputNr.AutoSize = true;
            this.lblInputNr.Location = new System.Drawing.Point(10, 24);
            this.lblInputNr.Name = "lblInputNr";
            this.lblInputNr.Size = new System.Drawing.Size(63, 13);
            this.lblInputNr.TabIndex = 12;
            this.lblInputNr.Text = "Input Layer:";
            // 
            // groupBoxLayers
            // 
            this.groupBoxLayers.Controls.Add(this.radioButton2);
            this.groupBoxLayers.Controls.Add(this.radioButton1);
            this.groupBoxLayers.Location = new System.Drawing.Point(3, 70);
            this.groupBoxLayers.Name = "groupBoxLayers";
            this.groupBoxLayers.Size = new System.Drawing.Size(151, 44);
            this.groupBoxLayers.TabIndex = 6;
            this.groupBoxLayers.TabStop = false;
            this.groupBoxLayers.Text = "Number of Layers:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(73, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "2 Layers";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(2, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 Layer";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.pictureBox1);
            this.groupBoxTools.Controls.Add(this.toolMousePointer);
            this.groupBoxTools.Controls.Add(this.toolNeuronEraser);
            this.groupBoxTools.Location = new System.Drawing.Point(3, 20);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(151, 44);
            this.groupBoxTools.TabIndex = 5;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tools:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolMousePointer
            // 
            this.toolMousePointer.Image = ((System.Drawing.Image)(resources.GetObject("toolMousePointer.Image")));
            this.toolMousePointer.Location = new System.Drawing.Point(25, 19);
            this.toolMousePointer.Name = "toolMousePointer";
            this.toolMousePointer.Size = new System.Drawing.Size(19, 19);
            this.toolMousePointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolMousePointer.TabIndex = 8;
            this.toolMousePointer.TabStop = false;
            this.toolMousePointer.Click += new System.EventHandler(this.toolMousePointer_Click);
            // 
            // toolNeuronEraser
            // 
            this.toolNeuronEraser.Image = ((System.Drawing.Image)(resources.GetObject("toolNeuronEraser.Image")));
            this.toolNeuronEraser.Location = new System.Drawing.Point(53, 19);
            this.toolNeuronEraser.Name = "toolNeuronEraser";
            this.toolNeuronEraser.Size = new System.Drawing.Size(19, 19);
            this.toolNeuronEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.toolNeuronEraser.TabIndex = 7;
            this.toolNeuronEraser.TabStop = false;
            this.toolNeuronEraser.Click += new System.EventHandler(this.toolNeuronEraser_Click);
            // 
            // designEditorHeader
            // 
            this.designEditorHeader.BackColor = System.Drawing.SystemColors.Control;
            this.designEditorHeader.Controls.Add(this.designEditorClose);
            this.designEditorHeader.Controls.Add(this.designEditorHeaderTitle);
            this.designEditorHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.designEditorHeader.Location = new System.Drawing.Point(0, 0);
            this.designEditorHeader.Name = "designEditorHeader";
            this.designEditorHeader.Size = new System.Drawing.Size(157, 20);
            this.designEditorHeader.TabIndex = 5;
            this.designEditorHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.designEditorHeader_MouseMove);
            this.designEditorHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.designEditorHeader_MouseDown);
            this.designEditorHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.designEditorHeader_MouseUp);
            // 
            // designEditorClose
            // 
            this.designEditorClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.designEditorClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("designEditorClose.ErrorImage")));
            this.designEditorClose.Image = ((System.Drawing.Image)(resources.GetObject("designEditorClose.Image")));
            this.designEditorClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("designEditorClose.InitialImage")));
            this.designEditorClose.Location = new System.Drawing.Point(136, 0);
            this.designEditorClose.Name = "designEditorClose";
            this.designEditorClose.Size = new System.Drawing.Size(21, 20);
            this.designEditorClose.TabIndex = 5;
            this.designEditorClose.TabStop = false;
            this.designEditorClose.MouseLeave += new System.EventHandler(this.designEditorClose_MouseLeave);
            this.designEditorClose.Click += new System.EventHandler(this.designEditorClose_Click);
            this.designEditorClose.MouseHover += new System.EventHandler(this.designEditorClose_MouseHover);
            // 
            // designEditorHeaderTitle
            // 
            this.designEditorHeaderTitle.AutoSize = true;
            this.designEditorHeaderTitle.Location = new System.Drawing.Point(3, 5);
            this.designEditorHeaderTitle.Name = "designEditorHeaderTitle";
            this.designEditorHeaderTitle.Size = new System.Drawing.Size(80, 13);
            this.designEditorHeaderTitle.TabIndex = 5;
            this.designEditorHeaderTitle.Text = "Structure Editor";
            this.designEditorHeaderTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.designEditorHeaderTitle_MouseMove);
            this.designEditorHeaderTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.designEditorHeaderTitle_MouseDown);
            this.designEditorHeaderTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.designEditorHeaderTitle_MouseUp);
            // 
            // detailsWindow
            // 
            this.detailsWindow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.detailsWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsWindow.Controls.Add(this.tabDetailsWindow);
            this.detailsWindow.Controls.Add(this.detailsWindowHeader);
            this.detailsWindow.Location = new System.Drawing.Point(162, 52);
            this.detailsWindow.Name = "detailsWindow";
            this.detailsWindow.Size = new System.Drawing.Size(505, 342);
            this.detailsWindow.TabIndex = 5;
            this.detailsWindow.Visible = false;
            this.detailsWindow.VisibleChanged += new System.EventHandler(this.detailsWindow_VisibleChanged);
            // 
            // tabDetailsWindow
            // 
            this.tabDetailsWindow.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabDetailsWindow.Controls.Add(this.tabDetailsWindowTab0);
            this.tabDetailsWindow.Controls.Add(this.tabDetailsWindowTab1);
            this.tabDetailsWindow.Controls.Add(this.tabDetailsWindowTab2);
            this.tabDetailsWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetailsWindow.ImageList = this.imageList1;
            this.tabDetailsWindow.Location = new System.Drawing.Point(0, 22);
            this.tabDetailsWindow.Name = "tabDetailsWindow";
            this.tabDetailsWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabDetailsWindow.RightToLeftLayout = true;
            this.tabDetailsWindow.SelectedIndex = 0;
            this.tabDetailsWindow.ShowToolTips = true;
            this.tabDetailsWindow.Size = new System.Drawing.Size(503, 318);
            this.tabDetailsWindow.TabIndex = 2;
            this.tabDetailsWindow.SelectedIndexChanged += new System.EventHandler(this.tabDetailsWindow_SelectedIndexChanged);
            // 
            // tabDetailsWindowTab0
            // 
            this.tabDetailsWindowTab0.Controls.Add(this.boxThreshold);
            this.tabDetailsWindowTab0.Controls.Add(this.lblThreshold);
            this.tabDetailsWindowTab0.Controls.Add(this.btnUpdateData);
            this.tabDetailsWindowTab0.Controls.Add(this.lblPotential);
            this.tabDetailsWindowTab0.Controls.Add(this.inputsPanel);
            this.tabDetailsWindowTab0.Controls.Add(this.shapeContainer1);
            this.tabDetailsWindowTab0.ImageIndex = 3;
            this.tabDetailsWindowTab0.Location = new System.Drawing.Point(4, 4);
            this.tabDetailsWindowTab0.Name = "tabDetailsWindowTab0";
            this.tabDetailsWindowTab0.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetailsWindowTab0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabDetailsWindowTab0.Size = new System.Drawing.Size(495, 291);
            this.tabDetailsWindowTab0.TabIndex = 0;
            this.tabDetailsWindowTab0.Text = "  Details";
            this.tabDetailsWindowTab0.UseVisualStyleBackColor = true;
            // 
            // boxThreshold
            // 
            this.boxThreshold.Location = new System.Drawing.Point(316, 20);
            this.boxThreshold.Name = "boxThreshold";
            this.boxThreshold.Size = new System.Drawing.Size(70, 20);
            this.boxThreshold.TabIndex = 7;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(253, 22);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(57, 13);
            this.lblThreshold.TabIndex = 4;
            this.lblThreshold.Text = "Threshold:";
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(421, 18);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateData.TabIndex = 11;
            this.btnUpdateData.Text = "Update";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // lblPotential
            // 
            this.lblPotential.AutoSize = true;
            this.lblPotential.Location = new System.Drawing.Point(249, 3);
            this.lblPotential.Name = "lblPotential";
            this.lblPotential.Size = new System.Drawing.Size(90, 13);
            this.lblPotential.TabIndex = 1;
            this.lblPotential.Text = "Current potential: ";
            // 
            // inputsPanel
            // 
            this.inputsPanel.AutoScroll = true;
            this.inputsPanel.Controls.Add(this.groupBox1);
            this.inputsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputsPanel.Location = new System.Drawing.Point(3, 3);
            this.inputsPanel.Name = "inputsPanel";
            this.inputsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputsPanel.Size = new System.Drawing.Size(244, 285);
            this.inputsPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxWeight);
            this.groupBox1.Controls.Add(this.boxDelay);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblDelay);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(218, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input 1:";
            // 
            // boxWeight
            // 
            this.boxWeight.Location = new System.Drawing.Point(71, 45);
            this.boxWeight.Name = "boxWeight";
            this.boxWeight.Size = new System.Drawing.Size(70, 20);
            this.boxWeight.TabIndex = 6;
            // 
            // boxDelay
            // 
            this.boxDelay.Location = new System.Drawing.Point(71, 18);
            this.boxDelay.Name = "boxDelay";
            this.boxDelay.Size = new System.Drawing.Size(70, 20);
            this.boxDelay.TabIndex = 5;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(8, 48);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight:";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(8, 21);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(40, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay: ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.detailShape,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(489, 285);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // detailShape
            // 
            this.detailShape.Location = new System.Drawing.Point(367, 112);
            this.detailShape.Name = "detailShape";
            this.detailShape.Size = new System.Drawing.Size(47, 47);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 259;
            this.lineShape1.X2 = 357;
            this.lineShape1.Y1 = 138;
            this.lineShape1.Y2 = 138;
            // 
            // tabDetailsWindowTab1
            // 
            this.tabDetailsWindowTab1.ImageIndex = 3;
            this.tabDetailsWindowTab1.Location = new System.Drawing.Point(4, 4);
            this.tabDetailsWindowTab1.Name = "tabDetailsWindowTab1";
            this.tabDetailsWindowTab1.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetailsWindowTab1.Size = new System.Drawing.Size(495, 291);
            this.tabDetailsWindowTab1.TabIndex = 1;
            this.tabDetailsWindowTab1.Text = "Membrane Potential";
            this.tabDetailsWindowTab1.UseVisualStyleBackColor = true;
            // 
            // tabDetailsWindowTab2
            // 
            this.tabDetailsWindowTab2.Location = new System.Drawing.Point(4, 4);
            this.tabDetailsWindowTab2.Name = "tabDetailsWindowTab2";
            this.tabDetailsWindowTab2.Size = new System.Drawing.Size(495, 291);
            this.tabDetailsWindowTab2.TabIndex = 2;
            this.tabDetailsWindowTab2.Text = "Spikes-Inputs Association";
            this.tabDetailsWindowTab2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Danger.ico");
            this.imageList1.Images.SetKeyName(1, "Problem.ico");
            this.imageList1.Images.SetKeyName(2, "Apply.ico");
            this.imageList1.Images.SetKeyName(3, "plus.jpg");
            this.imageList1.Images.SetKeyName(4, "Question.ico");
            this.imageList1.Images.SetKeyName(5, "Lightning.bmp");
            this.imageList1.Images.SetKeyName(6, "Next.ico");
            this.imageList1.Images.SetKeyName(7, "Stock graph.ico");
            // 
            // detailsWindowHeader
            // 
            this.detailsWindowHeader.BackColor = System.Drawing.SystemColors.Control;
            this.detailsWindowHeader.Controls.Add(this.lblWhichLayer);
            this.detailsWindowHeader.Controls.Add(this.detailsWindowClose);
            this.detailsWindowHeader.Controls.Add(this.detailsWindowHeaderTitle);
            this.detailsWindowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsWindowHeader.Location = new System.Drawing.Point(0, 0);
            this.detailsWindowHeader.Name = "detailsWindowHeader";
            this.detailsWindowHeader.Size = new System.Drawing.Size(503, 22);
            this.detailsWindowHeader.TabIndex = 0;
            this.detailsWindowHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.detailsWindowHeader_MouseMove);
            this.detailsWindowHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detailsWindowHeader_MouseDown);
            this.detailsWindowHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.detailsWindowHeader_MouseUp);
            // 
            // lblWhichLayer
            // 
            this.lblWhichLayer.AutoSize = true;
            this.lblWhichLayer.Location = new System.Drawing.Point(447, 5);
            this.lblWhichLayer.Name = "lblWhichLayer";
            this.lblWhichLayer.Size = new System.Drawing.Size(29, 13);
            this.lblWhichLayer.TabIndex = 5;
            this.lblWhichLayer.Text = "layer";
            this.lblWhichLayer.Visible = false;
            // 
            // detailsWindowClose
            // 
            this.detailsWindowClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailsWindowClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("detailsWindowClose.ErrorImage")));
            this.detailsWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("detailsWindowClose.Image")));
            this.detailsWindowClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("detailsWindowClose.InitialImage")));
            this.detailsWindowClose.Location = new System.Drawing.Point(482, 0);
            this.detailsWindowClose.Name = "detailsWindowClose";
            this.detailsWindowClose.Size = new System.Drawing.Size(21, 22);
            this.detailsWindowClose.TabIndex = 4;
            this.detailsWindowClose.TabStop = false;
            this.detailsWindowClose.MouseLeave += new System.EventHandler(this.detailsWindowClose_MouseLeave);
            this.detailsWindowClose.Click += new System.EventHandler(this.detailsWindowClose_Click);
            this.detailsWindowClose.MouseHover += new System.EventHandler(this.detailsWindowClose_MouseHover);
            // 
            // detailsWindowHeaderTitle
            // 
            this.detailsWindowHeaderTitle.AutoSize = true;
            this.detailsWindowHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detailsWindowHeaderTitle.Location = new System.Drawing.Point(3, 3);
            this.detailsWindowHeaderTitle.Name = "detailsWindowHeaderTitle";
            this.detailsWindowHeaderTitle.Size = new System.Drawing.Size(89, 15);
            this.detailsWindowHeaderTitle.TabIndex = 3;
            this.detailsWindowHeaderTitle.Text = "Neuron Details";
            this.detailsWindowHeaderTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.detailsWindowHeaderTitle_MouseMove);
            this.detailsWindowHeaderTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detailsWindowHeaderTitle_MouseDown);
            this.detailsWindowHeaderTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.detailsWindowHeaderTitle_MouseUp);
            // 
            // simulationWindow
            // 
            this.simulationWindow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.simulationWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simulationWindow.Controls.Add(this.tabSim);
            this.simulationWindow.Controls.Add(this.treeView1);
            this.simulationWindow.Controls.Add(this.simulationWindowHeader);
            this.simulationWindow.Location = new System.Drawing.Point(671, 358);
            this.simulationWindow.Name = "simulationWindow";
            this.simulationWindow.Size = new System.Drawing.Size(180, 382);
            this.simulationWindow.TabIndex = 6;
            this.simulationWindow.Visible = false;
            // 
            // tabSim
            // 
            this.tabSim.Controls.Add(this.tabSimPref);
            this.tabSim.Controls.Add(this.tabSimSource);
            this.tabSim.Controls.Add(this.tabSimCoding);
            this.tabSim.Controls.Add(this.tabSimInit);
            this.tabSim.Controls.Add(this.tabSimLearning);
            this.tabSim.Controls.Add(this.tabSimStart);
            this.tabSim.Location = new System.Drawing.Point(0, 140);
            this.tabSim.Name = "tabSim";
            this.tabSim.SelectedIndex = 0;
            this.tabSim.Size = new System.Drawing.Size(179, 240);
            this.tabSim.TabIndex = 3;
            this.tabSim.SelectedIndexChanged += new System.EventHandler(this.tabSim_SelectedIndexChanged);
            // 
            // tabSimPref
            // 
            this.tabSimPref.BackColor = System.Drawing.Color.White;
            this.tabSimPref.Controls.Add(this.groupPSPFunction);
            this.tabSimPref.Location = new System.Drawing.Point(4, 22);
            this.tabSimPref.Name = "tabSimPref";
            this.tabSimPref.Size = new System.Drawing.Size(171, 214);
            this.tabSimPref.TabIndex = 0;
            this.tabSimPref.Text = "tabPage3";
            this.tabSimPref.UseVisualStyleBackColor = true;
            // 
            // groupPSPFunction
            // 
            this.groupPSPFunction.Controls.Add(this.radioRealPSP);
            this.groupPSPFunction.Controls.Add(this.radioIdealPSP);
            this.groupPSPFunction.Controls.Add(this.pictureBox3);
            this.groupPSPFunction.Controls.Add(this.pictureBox2);
            this.groupPSPFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPSPFunction.Location = new System.Drawing.Point(0, 0);
            this.groupPSPFunction.Name = "groupPSPFunction";
            this.groupPSPFunction.Size = new System.Drawing.Size(171, 100);
            this.groupPSPFunction.TabIndex = 1;
            this.groupPSPFunction.TabStop = false;
            this.groupPSPFunction.Text = "PSP Function:";
            this.groupPSPFunction.Enter += new System.EventHandler(this.groupPSPFunction_Enter);
            // 
            // radioRealPSP
            // 
            this.radioRealPSP.AutoSize = true;
            this.radioRealPSP.Location = new System.Drawing.Point(84, 80);
            this.radioRealPSP.Name = "radioRealPSP";
            this.radioRealPSP.Size = new System.Drawing.Size(71, 17);
            this.radioRealPSP.TabIndex = 3;
            this.radioRealPSP.Text = "Real PSP";
            this.radioRealPSP.UseVisualStyleBackColor = true;
            // 
            // radioIdealPSP
            // 
            this.radioIdealPSP.AutoSize = true;
            this.radioIdealPSP.Checked = true;
            this.radioIdealPSP.Location = new System.Drawing.Point(1, 81);
            this.radioIdealPSP.Name = "radioIdealPSP";
            this.radioIdealPSP.Size = new System.Drawing.Size(72, 17);
            this.radioIdealPSP.TabIndex = 2;
            this.radioIdealPSP.TabStop = true;
            this.radioIdealPSP.Text = "Ideal PSP";
            this.radioIdealPSP.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(86, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 65);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 65);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabSimSource
            // 
            this.tabSimSource.BackColor = System.Drawing.Color.White;
            this.tabSimSource.Controls.Add(this.groupDataSrc);
            this.tabSimSource.Location = new System.Drawing.Point(4, 22);
            this.tabSimSource.Name = "tabSimSource";
            this.tabSimSource.Size = new System.Drawing.Size(171, 214);
            this.tabSimSource.TabIndex = 1;
            this.tabSimSource.Text = "tabPage3";
            this.tabSimSource.UseVisualStyleBackColor = true;
            // 
            // groupDataSrc
            // 
            this.groupDataSrc.Controls.Add(this.maskedBoxStimuliFileTime);
            this.groupDataSrc.Controls.Add(this.lblStimuliFileTime);
            this.groupDataSrc.Controls.Add(this.BoxStimuliPerEpoch);
            this.groupDataSrc.Controls.Add(this.lblStimuliPerEpoch);
            this.groupDataSrc.Controls.Add(this.radioSrcTest);
            this.groupDataSrc.Controls.Add(this.button1);
            this.groupDataSrc.Controls.Add(this.boxSourceFile);
            this.groupDataSrc.Controls.Add(this.radioSrcFile);
            this.groupDataSrc.Controls.Add(this.radioSrcManual);
            this.groupDataSrc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDataSrc.Location = new System.Drawing.Point(0, 0);
            this.groupDataSrc.Name = "groupDataSrc";
            this.groupDataSrc.Size = new System.Drawing.Size(171, 182);
            this.groupDataSrc.TabIndex = 1;
            this.groupDataSrc.TabStop = false;
            this.groupDataSrc.Text = "Data Source:";
            // 
            // maskedBoxStimuliFileTime
            // 
            this.maskedBoxStimuliFileTime.Location = new System.Drawing.Point(111, 143);
            this.maskedBoxStimuliFileTime.Mask = "0000";
            this.maskedBoxStimuliFileTime.Name = "maskedBoxStimuliFileTime";
            this.maskedBoxStimuliFileTime.Size = new System.Drawing.Size(54, 20);
            this.maskedBoxStimuliFileTime.TabIndex = 8;
            this.maskedBoxStimuliFileTime.Text = "100";
            this.maskedBoxStimuliFileTime.Visible = false;
            // 
            // lblStimuliFileTime
            // 
            this.lblStimuliFileTime.AutoSize = true;
            this.lblStimuliFileTime.Location = new System.Drawing.Point(5, 146);
            this.lblStimuliFileTime.Name = "lblStimuliFileTime";
            this.lblStimuliFileTime.Size = new System.Drawing.Size(102, 13);
            this.lblStimuliFileTime.TabIndex = 7;
            this.lblStimuliFileTime.Text = "Presentation Period:";
            this.lblStimuliFileTime.Visible = false;
            // 
            // BoxStimuliPerEpoch
            // 
            this.BoxStimuliPerEpoch.Location = new System.Drawing.Point(111, 117);
            this.BoxStimuliPerEpoch.Mask = "000";
            this.BoxStimuliPerEpoch.Name = "BoxStimuliPerEpoch";
            this.BoxStimuliPerEpoch.Size = new System.Drawing.Size(54, 20);
            this.BoxStimuliPerEpoch.TabIndex = 6;
            this.BoxStimuliPerEpoch.Text = "1";
            this.BoxStimuliPerEpoch.Visible = false;
            // 
            // lblStimuliPerEpoch
            // 
            this.lblStimuliPerEpoch.AutoSize = true;
            this.lblStimuliPerEpoch.Location = new System.Drawing.Point(5, 121);
            this.lblStimuliPerEpoch.Name = "lblStimuliPerEpoch";
            this.lblStimuliPerEpoch.Size = new System.Drawing.Size(92, 13);
            this.lblStimuliPerEpoch.TabIndex = 5;
            this.lblStimuliPerEpoch.Text = "Stimuli per Epoch:";
            this.lblStimuliPerEpoch.Visible = false;
            // 
            // radioSrcTest
            // 
            this.radioSrcTest.AutoSize = true;
            this.radioSrcTest.Location = new System.Drawing.Point(7, 44);
            this.radioSrcTest.Name = "radioSrcTest";
            this.radioSrcTest.Size = new System.Drawing.Size(97, 17);
            this.radioSrcTest.TabIndex = 4;
            this.radioSrcTest.Text = "Test Simulation";
            this.radioSrcTest.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(109, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxSourceFile
            // 
            this.boxSourceFile.Enabled = false;
            this.boxSourceFile.Location = new System.Drawing.Point(6, 90);
            this.boxSourceFile.Name = "boxSourceFile";
            this.boxSourceFile.Size = new System.Drawing.Size(98, 20);
            this.boxSourceFile.TabIndex = 3;
            // 
            // radioSrcFile
            // 
            this.radioSrcFile.AutoSize = true;
            this.radioSrcFile.Location = new System.Drawing.Point(6, 67);
            this.radioSrcFile.Name = "radioSrcFile";
            this.radioSrcFile.Size = new System.Drawing.Size(67, 17);
            this.radioSrcFile.TabIndex = 2;
            this.radioSrcFile.Text = "From File";
            this.radioSrcFile.UseVisualStyleBackColor = true;
            this.radioSrcFile.CheckedChanged += new System.EventHandler(this.radioSrcFile_CheckedChanged);
            // 
            // radioSrcManual
            // 
            this.radioSrcManual.AutoSize = true;
            this.radioSrcManual.Checked = true;
            this.radioSrcManual.Location = new System.Drawing.Point(6, 21);
            this.radioSrcManual.Name = "radioSrcManual";
            this.radioSrcManual.Size = new System.Drawing.Size(111, 17);
            this.radioSrcManual.TabIndex = 0;
            this.radioSrcManual.TabStop = true;
            this.radioSrcManual.Text = "Manual Simulation";
            this.radioSrcManual.UseVisualStyleBackColor = true;
            // 
            // tabSimCoding
            // 
            this.tabSimCoding.BackColor = System.Drawing.Color.White;
            this.tabSimCoding.Controls.Add(this.label3);
            this.tabSimCoding.Controls.Add(this.lblRangeSim);
            this.tabSimCoding.Controls.Add(this.lblMaxTSim);
            this.tabSimCoding.Controls.Add(this.lblGammaSim);
            this.tabSimCoding.Controls.Add(this.maskedBoxImageRecTO);
            this.tabSimCoding.Controls.Add(this.lblImageRecX);
            this.tabSimCoding.Controls.Add(this.maskedBoxMaxTSim);
            this.tabSimCoding.Controls.Add(this.maskedBoxImageRecFROM);
            this.tabSimCoding.Controls.Add(this.lblImageRecLabel);
            this.tabSimCoding.Controls.Add(this.radioCodingImageRecognition);
            this.tabSimCoding.Controls.Add(this.radioCodingPopulationGauss);
            this.tabSimCoding.Controls.Add(this.maskedBoxRangeSimTo);
            this.tabSimCoding.Controls.Add(this.radioCodingPopulationSimple);
            this.tabSimCoding.Controls.Add(this.lblCodingMode);
            this.tabSimCoding.Controls.Add(this.maskedBoxGammaSim);
            this.tabSimCoding.Controls.Add(this.maskedBoxRangeSimFrom);
            this.tabSimCoding.Location = new System.Drawing.Point(4, 22);
            this.tabSimCoding.Name = "tabSimCoding";
            this.tabSimCoding.Size = new System.Drawing.Size(171, 214);
            this.tabSimCoding.TabIndex = 4;
            this.tabSimCoding.Text = "tabPage3";
            this.tabSimCoding.UseVisualStyleBackColor = true;
            this.tabSimCoding.Click += new System.EventHandler(this.tabSimCoding_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "-";
            // 
            // lblRangeSim
            // 
            this.lblRangeSim.AutoSize = true;
            this.lblRangeSim.Location = new System.Drawing.Point(27, 195);
            this.lblRangeSim.Name = "lblRangeSim";
            this.lblRangeSim.Size = new System.Drawing.Size(42, 13);
            this.lblRangeSim.TabIndex = 33;
            this.lblRangeSim.Text = "Range:";
            // 
            // lblMaxTSim
            // 
            this.lblMaxTSim.AutoSize = true;
            this.lblMaxTSim.Location = new System.Drawing.Point(27, 167);
            this.lblMaxTSim.Name = "lblMaxTSim";
            this.lblMaxTSim.Size = new System.Drawing.Size(40, 13);
            this.lblMaxTSim.TabIndex = 32;
            this.lblMaxTSim.Text = "T Max:";
            // 
            // lblGammaSim
            // 
            this.lblGammaSim.AutoSize = true;
            this.lblGammaSim.Location = new System.Drawing.Point(25, 142);
            this.lblGammaSim.Name = "lblGammaSim";
            this.lblGammaSim.Size = new System.Drawing.Size(43, 13);
            this.lblGammaSim.TabIndex = 31;
            this.lblGammaSim.Text = "Gamma";
            // 
            // maskedBoxImageRecTO
            // 
            this.maskedBoxImageRecTO.Location = new System.Drawing.Point(86, 119);
            this.maskedBoxImageRecTO.Mask = "00";
            this.maskedBoxImageRecTO.Name = "maskedBoxImageRecTO";
            this.maskedBoxImageRecTO.Size = new System.Drawing.Size(33, 20);
            this.maskedBoxImageRecTO.TabIndex = 22;
            this.maskedBoxImageRecTO.Visible = false;
            // 
            // lblImageRecX
            // 
            this.lblImageRecX.AutoSize = true;
            this.lblImageRecX.Location = new System.Drawing.Point(70, 123);
            this.lblImageRecX.Name = "lblImageRecX";
            this.lblImageRecX.Size = new System.Drawing.Size(14, 13);
            this.lblImageRecX.TabIndex = 21;
            this.lblImageRecX.Text = "X";
            this.lblImageRecX.Visible = false;
            // 
            // maskedBoxMaxTSim
            // 
            this.maskedBoxMaxTSim.Location = new System.Drawing.Point(68, 164);
            this.maskedBoxMaxTSim.Mask = "000.0";
            this.maskedBoxMaxTSim.Name = "maskedBoxMaxTSim";
            this.maskedBoxMaxTSim.Size = new System.Drawing.Size(35, 20);
            this.maskedBoxMaxTSim.TabIndex = 30;
            this.maskedBoxMaxTSim.Visible = false;
            // 
            // maskedBoxImageRecFROM
            // 
            this.maskedBoxImageRecFROM.Location = new System.Drawing.Point(35, 119);
            this.maskedBoxImageRecFROM.Mask = "00";
            this.maskedBoxImageRecFROM.Name = "maskedBoxImageRecFROM";
            this.maskedBoxImageRecFROM.Size = new System.Drawing.Size(33, 20);
            this.maskedBoxImageRecFROM.TabIndex = 20;
            this.maskedBoxImageRecFROM.Visible = false;
            // 
            // lblImageRecLabel
            // 
            this.lblImageRecLabel.AutoSize = true;
            this.lblImageRecLabel.Location = new System.Drawing.Point(31, 99);
            this.lblImageRecLabel.Name = "lblImageRecLabel";
            this.lblImageRecLabel.Size = new System.Drawing.Size(91, 13);
            this.lblImageRecLabel.TabIndex = 19;
            this.lblImageRecLabel.Text = "Image Dimension:";
            this.lblImageRecLabel.Visible = false;
            // 
            // radioCodingImageRecognition
            // 
            this.radioCodingImageRecognition.AutoSize = true;
            this.radioCodingImageRecognition.Location = new System.Drawing.Point(15, 79);
            this.radioCodingImageRecognition.Name = "radioCodingImageRecognition";
            this.radioCodingImageRecognition.Size = new System.Drawing.Size(114, 17);
            this.radioCodingImageRecognition.TabIndex = 18;
            this.radioCodingImageRecognition.Text = "Image Recognition";
            this.radioCodingImageRecognition.UseVisualStyleBackColor = true;
            this.radioCodingImageRecognition.CheckedChanged += new System.EventHandler(this.radioCodingImageRecognition_CheckedChanged);
            // 
            // radioCodingPopulationGauss
            // 
            this.radioCodingPopulationGauss.AutoSize = true;
            this.radioCodingPopulationGauss.Location = new System.Drawing.Point(14, 56);
            this.radioCodingPopulationGauss.Name = "radioCodingPopulationGauss";
            this.radioCodingPopulationGauss.Size = new System.Drawing.Size(151, 17);
            this.radioCodingPopulationGauss.TabIndex = 17;
            this.radioCodingPopulationGauss.Text = "Gaussian Receptive Fields";
            this.radioCodingPopulationGauss.UseVisualStyleBackColor = true;
            this.radioCodingPopulationGauss.CheckedChanged += new System.EventHandler(this.radioCodingPopulationGauss_CheckedChanged);
            // 
            // maskedBoxRangeSimTo
            // 
            this.maskedBoxRangeSimTo.Location = new System.Drawing.Point(113, 188);
            this.maskedBoxRangeSimTo.Mask = "000.0";
            this.maskedBoxRangeSimTo.Name = "maskedBoxRangeSimTo";
            this.maskedBoxRangeSimTo.Size = new System.Drawing.Size(35, 20);
            this.maskedBoxRangeSimTo.TabIndex = 28;
            this.maskedBoxRangeSimTo.Visible = false;
            // 
            // radioCodingPopulationSimple
            // 
            this.radioCodingPopulationSimple.AutoSize = true;
            this.radioCodingPopulationSimple.Location = new System.Drawing.Point(14, 33);
            this.radioCodingPopulationSimple.Name = "radioCodingPopulationSimple";
            this.radioCodingPopulationSimple.Size = new System.Drawing.Size(105, 17);
            this.radioCodingPopulationSimple.TabIndex = 16;
            this.radioCodingPopulationSimple.Text = "Temporal Coding";
            this.radioCodingPopulationSimple.UseVisualStyleBackColor = true;
            this.radioCodingPopulationSimple.CheckedChanged += new System.EventHandler(this.radioCodingPopulationSimple_CheckedChanged);
            // 
            // lblCodingMode
            // 
            this.lblCodingMode.AutoSize = true;
            this.lblCodingMode.Location = new System.Drawing.Point(12, 12);
            this.lblCodingMode.Name = "lblCodingMode";
            this.lblCodingMode.Size = new System.Drawing.Size(100, 13);
            this.lblCodingMode.TabIndex = 14;
            this.lblCodingMode.Text = "Input Coding Mode:";
            // 
            // maskedBoxGammaSim
            // 
            this.maskedBoxGammaSim.Location = new System.Drawing.Point(67, 139);
            this.maskedBoxGammaSim.Mask = "0.0";
            this.maskedBoxGammaSim.Name = "maskedBoxGammaSim";
            this.maskedBoxGammaSim.Size = new System.Drawing.Size(23, 20);
            this.maskedBoxGammaSim.TabIndex = 23;
            this.maskedBoxGammaSim.Text = "15";
            this.maskedBoxGammaSim.Visible = false;
            // 
            // maskedBoxRangeSimFrom
            // 
            this.maskedBoxRangeSimFrom.Location = new System.Drawing.Point(67, 188);
            this.maskedBoxRangeSimFrom.Mask = "#000.0";
            this.maskedBoxRangeSimFrom.Name = "maskedBoxRangeSimFrom";
            this.maskedBoxRangeSimFrom.Size = new System.Drawing.Size(39, 20);
            this.maskedBoxRangeSimFrom.TabIndex = 26;
            this.maskedBoxRangeSimFrom.Visible = false;
            // 
            // tabSimInit
            // 
            this.tabSimInit.BackColor = System.Drawing.Color.White;
            this.tabSimInit.Controls.Add(this.checkBoxRandomParameters);
            this.tabSimInit.Controls.Add(this.groupDealyInit);
            this.tabSimInit.Controls.Add(this.groupWeightInit);
            this.tabSimInit.Controls.Add(this.maskedBoxThreshold);
            this.tabSimInit.Controls.Add(this.lblNeuronThr);
            this.tabSimInit.Location = new System.Drawing.Point(4, 22);
            this.tabSimInit.Name = "tabSimInit";
            this.tabSimInit.Size = new System.Drawing.Size(171, 214);
            this.tabSimInit.TabIndex = 3;
            this.tabSimInit.Text = "tabPage3";
            this.tabSimInit.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandomParameters
            // 
            this.checkBoxRandomParameters.AutoSize = true;
            this.checkBoxRandomParameters.Location = new System.Drawing.Point(6, 8);
            this.checkBoxRandomParameters.Name = "checkBoxRandomParameters";
            this.checkBoxRandomParameters.Size = new System.Drawing.Size(160, 17);
            this.checkBoxRandomParameters.TabIndex = 8;
            this.checkBoxRandomParameters.Text = "Randomize New Parameters";
            this.checkBoxRandomParameters.UseVisualStyleBackColor = true;
            this.checkBoxRandomParameters.CheckedChanged += new System.EventHandler(this.checkBoxRandomParameters_CheckedChanged);
            // 
            // groupDealyInit
            // 
            this.groupDealyInit.Controls.Add(this.maskedBoxDelayInputTo);
            this.groupDealyInit.Controls.Add(this.lblInputDelayInit);
            this.groupDealyInit.Controls.Add(this.maskedBoxLayerDelayTo);
            this.groupDealyInit.Controls.Add(this.lblLayerDelay);
            this.groupDealyInit.Location = new System.Drawing.Point(2, 130);
            this.groupDealyInit.Name = "groupDealyInit";
            this.groupDealyInit.Size = new System.Drawing.Size(165, 81);
            this.groupDealyInit.TabIndex = 7;
            this.groupDealyInit.TabStop = false;
            this.groupDealyInit.Text = "Delays Initialization Params: ";
            this.groupDealyInit.Visible = false;
            // 
            // maskedBoxDelayInputTo
            // 
            this.maskedBoxDelayInputTo.Location = new System.Drawing.Point(86, 48);
            this.maskedBoxDelayInputTo.Mask = "0000";
            this.maskedBoxDelayInputTo.Name = "maskedBoxDelayInputTo";
            this.maskedBoxDelayInputTo.PromptChar = ' ';
            this.maskedBoxDelayInputTo.Size = new System.Drawing.Size(75, 20);
            this.maskedBoxDelayInputTo.TabIndex = 5;
            this.maskedBoxDelayInputTo.Text = "0";
            // 
            // lblInputDelayInit
            // 
            this.lblInputDelayInit.AutoSize = true;
            this.lblInputDelayInit.Location = new System.Drawing.Point(6, 51);
            this.lblInputDelayInit.Name = "lblInputDelayInit";
            this.lblInputDelayInit.Size = new System.Drawing.Size(74, 13);
            this.lblInputDelayInit.TabIndex = 4;
            this.lblInputDelayInit.Text = "Input delay to:";
            // 
            // maskedBoxLayerDelayTo
            // 
            this.maskedBoxLayerDelayTo.Location = new System.Drawing.Point(86, 23);
            this.maskedBoxLayerDelayTo.Mask = "0000";
            this.maskedBoxLayerDelayTo.Name = "maskedBoxLayerDelayTo";
            this.maskedBoxLayerDelayTo.PromptChar = ' ';
            this.maskedBoxLayerDelayTo.Size = new System.Drawing.Size(75, 20);
            this.maskedBoxLayerDelayTo.TabIndex = 3;
            this.maskedBoxLayerDelayTo.Text = "0";
            // 
            // lblLayerDelay
            // 
            this.lblLayerDelay.AutoSize = true;
            this.lblLayerDelay.Location = new System.Drawing.Point(6, 26);
            this.lblLayerDelay.Name = "lblLayerDelay";
            this.lblLayerDelay.Size = new System.Drawing.Size(76, 13);
            this.lblLayerDelay.TabIndex = 2;
            this.lblLayerDelay.Text = "Layer delay to:";
            // 
            // groupWeightInit
            // 
            this.groupWeightInit.Controls.Add(this.maskedBoxRandomTo);
            this.groupWeightInit.Controls.Add(this.lblWeightRandomSeparator);
            this.groupWeightInit.Controls.Add(this.maskedBoxRandomFrom);
            this.groupWeightInit.Controls.Add(this.lblWeightInitParams);
            this.groupWeightInit.Location = new System.Drawing.Point(4, 55);
            this.groupWeightInit.Name = "groupWeightInit";
            this.groupWeightInit.Size = new System.Drawing.Size(165, 69);
            this.groupWeightInit.TabIndex = 6;
            this.groupWeightInit.TabStop = false;
            this.groupWeightInit.Text = "Weights Initialization Params:";
            this.groupWeightInit.Visible = false;
            // 
            // maskedBoxRandomTo
            // 
            this.maskedBoxRandomTo.Location = new System.Drawing.Point(90, 33);
            this.maskedBoxRandomTo.Mask = "0.00";
            this.maskedBoxRandomTo.Name = "maskedBoxRandomTo";
            this.maskedBoxRandomTo.PromptChar = ' ';
            this.maskedBoxRandomTo.Size = new System.Drawing.Size(49, 20);
            this.maskedBoxRandomTo.TabIndex = 3;
            this.maskedBoxRandomTo.Text = "000";
            // 
            // lblWeightRandomSeparator
            // 
            this.lblWeightRandomSeparator.AutoSize = true;
            this.lblWeightRandomSeparator.Location = new System.Drawing.Point(76, 36);
            this.lblWeightRandomSeparator.Name = "lblWeightRandomSeparator";
            this.lblWeightRandomSeparator.Size = new System.Drawing.Size(13, 13);
            this.lblWeightRandomSeparator.TabIndex = 2;
            this.lblWeightRandomSeparator.Text = "--";
            // 
            // maskedBoxRandomFrom
            // 
            this.maskedBoxRandomFrom.Location = new System.Drawing.Point(27, 33);
            this.maskedBoxRandomFrom.Mask = "#0.00";
            this.maskedBoxRandomFrom.Name = "maskedBoxRandomFrom";
            this.maskedBoxRandomFrom.PromptChar = ' ';
            this.maskedBoxRandomFrom.Size = new System.Drawing.Size(49, 20);
            this.maskedBoxRandomFrom.TabIndex = 1;
            this.maskedBoxRandomFrom.Text = "000";
            // 
            // lblWeightInitParams
            // 
            this.lblWeightInitParams.AutoSize = true;
            this.lblWeightInitParams.Location = new System.Drawing.Point(2, 17);
            this.lblWeightInitParams.Name = "lblWeightInitParams";
            this.lblWeightInitParams.Size = new System.Drawing.Size(85, 13);
            this.lblWeightInitParams.TabIndex = 0;
            this.lblWeightInitParams.Text = "Random Range:";
            // 
            // maskedBoxThreshold
            // 
            this.maskedBoxThreshold.Location = new System.Drawing.Point(105, 31);
            this.maskedBoxThreshold.Mask = "0.00";
            this.maskedBoxThreshold.Name = "maskedBoxThreshold";
            this.maskedBoxThreshold.PromptChar = ' ';
            this.maskedBoxThreshold.Size = new System.Drawing.Size(55, 20);
            this.maskedBoxThreshold.TabIndex = 5;
            this.maskedBoxThreshold.Text = "10";
            this.maskedBoxThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBoxThreshold.Visible = false;
            // 
            // lblNeuronThr
            // 
            this.lblNeuronThr.AutoSize = true;
            this.lblNeuronThr.Location = new System.Drawing.Point(3, 34);
            this.lblNeuronThr.Name = "lblNeuronThr";
            this.lblNeuronThr.Size = new System.Drawing.Size(96, 13);
            this.lblNeuronThr.TabIndex = 4;
            this.lblNeuronThr.Text = "Neurons threshold:";
            this.lblNeuronThr.Visible = false;
            // 
            // tabSimLearning
            // 
            this.tabSimLearning.BackColor = System.Drawing.Color.White;
            this.tabSimLearning.Controls.Add(this.tabLearning);
            this.tabSimLearning.Controls.Add(this.radioLearningNone);
            this.tabSimLearning.Controls.Add(this.radioLearningSTDP);
            this.tabSimLearning.Controls.Add(this.lblLearningRules);
            this.tabSimLearning.Location = new System.Drawing.Point(4, 22);
            this.tabSimLearning.Name = "tabSimLearning";
            this.tabSimLearning.Size = new System.Drawing.Size(171, 214);
            this.tabSimLearning.TabIndex = 2;
            this.tabSimLearning.Text = "tabPage3";
            this.tabSimLearning.UseVisualStyleBackColor = true;
            // 
            // tabLearning
            // 
            this.tabLearning.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabLearning.Controls.Add(this.tabPage1);
            this.tabLearning.Controls.Add(this.tabPage4);
            this.tabLearning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabLearning.Location = new System.Drawing.Point(0, 67);
            this.tabLearning.Name = "tabLearning";
            this.tabLearning.SelectedIndex = 0;
            this.tabLearning.Size = new System.Drawing.Size(171, 147);
            this.tabLearning.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(163, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "blank";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.maskedBoxMinW);
            this.tabPage4.Controls.Add(this.lblMinWeight);
            this.tabPage4.Controls.Add(this.maskedBoxMaxW);
            this.tabPage4.Controls.Add(this.lblMaxWeight);
            this.tabPage4.Controls.Add(this.maskedBoxA);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.maskedBoxTauP);
            this.tabPage4.Controls.Add(this.maskedBoxTauD);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(163, 121);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "STDP";
            // 
            // maskedBoxMinW
            // 
            this.maskedBoxMinW.Location = new System.Drawing.Point(77, 103);
            this.maskedBoxMinW.Mask = "0.0";
            this.maskedBoxMinW.Name = "maskedBoxMinW";
            this.maskedBoxMinW.Size = new System.Drawing.Size(43, 20);
            this.maskedBoxMinW.TabIndex = 12;
            // 
            // lblMinWeight
            // 
            this.lblMinWeight.AutoSize = true;
            this.lblMinWeight.Location = new System.Drawing.Point(8, 108);
            this.lblMinWeight.Name = "lblMinWeight";
            this.lblMinWeight.Size = new System.Drawing.Size(64, 13);
            this.lblMinWeight.TabIndex = 11;
            this.lblMinWeight.Text = "Min Weight:";
            // 
            // maskedBoxMaxW
            // 
            this.maskedBoxMaxW.Location = new System.Drawing.Point(77, 81);
            this.maskedBoxMaxW.Mask = "0.0";
            this.maskedBoxMaxW.Name = "maskedBoxMaxW";
            this.maskedBoxMaxW.Size = new System.Drawing.Size(43, 20);
            this.maskedBoxMaxW.TabIndex = 10;
            // 
            // lblMaxWeight
            // 
            this.lblMaxWeight.AutoSize = true;
            this.lblMaxWeight.Location = new System.Drawing.Point(8, 86);
            this.lblMaxWeight.Name = "lblMaxWeight";
            this.lblMaxWeight.Size = new System.Drawing.Size(67, 13);
            this.lblMaxWeight.TabIndex = 9;
            this.lblMaxWeight.Text = "Max Weight:";
            // 
            // maskedBoxA
            // 
            this.maskedBoxA.Location = new System.Drawing.Point(28, 55);
            this.maskedBoxA.Mask = "0.000";
            this.maskedBoxA.Name = "maskedBoxA";
            this.maskedBoxA.Size = new System.Drawing.Size(43, 20);
            this.maskedBoxA.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "A";
            // 
            // maskedBoxTauP
            // 
            this.maskedBoxTauP.Location = new System.Drawing.Point(28, 29);
            this.maskedBoxTauP.Mask = "00";
            this.maskedBoxTauP.Name = "maskedBoxTauP";
            this.maskedBoxTauP.Size = new System.Drawing.Size(43, 20);
            this.maskedBoxTauP.TabIndex = 5;
            // 
            // maskedBoxTauD
            // 
            this.maskedBoxTauD.Location = new System.Drawing.Point(28, 6);
            this.maskedBoxTauD.Mask = "00";
            this.maskedBoxTauD.Name = "maskedBoxTauD";
            this.maskedBoxTauD.Size = new System.Drawing.Size(43, 20);
            this.maskedBoxTauD.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "p";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "τ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "τ";
            // 
            // radioLearningNone
            // 
            this.radioLearningNone.AutoSize = true;
            this.radioLearningNone.Checked = true;
            this.radioLearningNone.Location = new System.Drawing.Point(6, 23);
            this.radioLearningNone.Name = "radioLearningNone";
            this.radioLearningNone.Size = new System.Drawing.Size(106, 17);
            this.radioLearningNone.TabIndex = 13;
            this.radioLearningNone.TabStop = true;
            this.radioLearningNone.Text = "Without Learning";
            this.radioLearningNone.UseVisualStyleBackColor = true;
            this.radioLearningNone.CheckedChanged += new System.EventHandler(this.radioLearningNone_CheckedChanged);
            // 
            // radioLearningSTDP
            // 
            this.radioLearningSTDP.AutoSize = true;
            this.radioLearningSTDP.Location = new System.Drawing.Point(6, 48);
            this.radioLearningSTDP.Name = "radioLearningSTDP";
            this.radioLearningSTDP.Size = new System.Drawing.Size(100, 17);
            this.radioLearningSTDP.TabIndex = 12;
            this.radioLearningSTDP.Text = "STDP Algorithm";
            this.radioLearningSTDP.UseVisualStyleBackColor = true;
            this.radioLearningSTDP.CheckedChanged += new System.EventHandler(this.radioLearningSTDP_CheckedChanged);
            // 
            // lblLearningRules
            // 
            this.lblLearningRules.AutoSize = true;
            this.lblLearningRules.Location = new System.Drawing.Point(3, 2);
            this.lblLearningRules.Name = "lblLearningRules";
            this.lblLearningRules.Size = new System.Drawing.Size(81, 13);
            this.lblLearningRules.TabIndex = 11;
            this.lblLearningRules.Text = "Learning Rules:";
            // 
            // tabSimStart
            // 
            this.tabSimStart.BackColor = System.Drawing.Color.White;
            this.tabSimStart.Controls.Add(this.btnSimStop);
            this.tabSimStart.Controls.Add(this.button4);
            this.tabSimStart.Controls.Add(this.boxSelectWeights);
            this.tabSimStart.Controls.Add(this.button3);
            this.tabSimStart.Controls.Add(this.radioOutNothing);
            this.tabSimStart.Controls.Add(this.textBoxOutputFile);
            this.tabSimStart.Controls.Add(this.radioOutFile);
            this.tabSimStart.Controls.Add(this.button2);
            this.tabSimStart.Controls.Add(this.lblOutputInterpretation);
            this.tabSimStart.Location = new System.Drawing.Point(4, 22);
            this.tabSimStart.Name = "tabSimStart";
            this.tabSimStart.Size = new System.Drawing.Size(171, 214);
            this.tabSimStart.TabIndex = 5;
            this.tabSimStart.Text = "tabPage3";
            this.tabSimStart.UseVisualStyleBackColor = true;
            // 
            // btnSimStop
            // 
            this.btnSimStop.Enabled = false;
            this.btnSimStop.Location = new System.Drawing.Point(50, 177);
            this.btnSimStop.Name = "btnSimStop";
            this.btnSimStop.Size = new System.Drawing.Size(75, 23);
            this.btnSimStop.TabIndex = 19;
            this.btnSimStop.Text = "Stop";
            this.btnSimStop.UseVisualStyleBackColor = true;
            this.btnSimStop.Click += new System.EventHandler(this.btnSimStop_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // boxSelectWeights
            // 
            this.boxSelectWeights.Location = new System.Drawing.Point(77, 119);
            this.boxSelectWeights.Mask = "00000";
            this.boxSelectWeights.Name = "boxSelectWeights";
            this.boxSelectWeights.Size = new System.Drawing.Size(36, 20);
            this.boxSelectWeights.TabIndex = 17;
            this.boxSelectWeights.ValidatingType = typeof(int);
            this.boxSelectWeights.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioOutNothing
            // 
            this.radioOutNothing.AutoSize = true;
            this.radioOutNothing.Checked = true;
            this.radioOutNothing.Location = new System.Drawing.Point(23, 29);
            this.radioOutNothing.Name = "radioOutNothing";
            this.radioOutNothing.Size = new System.Drawing.Size(79, 17);
            this.radioOutNothing.TabIndex = 15;
            this.radioOutNothing.TabStop = true;
            this.radioOutNothing.Text = "Do Nothing";
            this.radioOutNothing.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Location = new System.Drawing.Point(23, 75);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(127, 20);
            this.textBoxOutputFile.TabIndex = 14;
            // 
            // radioOutFile
            // 
            this.radioOutFile.AutoSize = true;
            this.radioOutFile.Location = new System.Drawing.Point(23, 52);
            this.radioOutFile.Name = "radioOutFile";
            this.radioOutFile.Size = new System.Drawing.Size(116, 17);
            this.radioOutFile.TabIndex = 13;
            this.radioOutFile.Text = "Write Output to File";
            this.radioOutFile.UseVisualStyleBackColor = true;
            this.radioOutFile.Click += new System.EventHandler(this.radioOutFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Begin Simulation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOutputInterpretation
            // 
            this.lblOutputInterpretation.AutoSize = true;
            this.lblOutputInterpretation.Location = new System.Drawing.Point(6, 10);
            this.lblOutputInterpretation.Name = "lblOutputInterpretation";
            this.lblOutputInterpretation.Size = new System.Drawing.Size(107, 13);
            this.lblOutputInterpretation.TabIndex = 0;
            this.lblOutputInterpretation.Text = "Output Interpretation:";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 8;
            this.treeView1.Location = new System.Drawing.Point(0, 20);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 6;
            treeNode1.Text = "Simulation Preferences";
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageIndex = 6;
            treeNode2.Text = "Data Source";
            treeNode3.Name = "Node1";
            treeNode3.SelectedImageIndex = 6;
            treeNode3.Text = "Input Coding Mode";
            treeNode4.Name = "Node2";
            treeNode4.SelectedImageIndex = 6;
            treeNode4.Text = "Network Initialization";
            treeNode5.Name = "Node2";
            treeNode5.SelectedImageIndex = 6;
            treeNode5.Text = "Learning Rules";
            treeNode6.Name = "Node0";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Simulation";
            treeNode7.Checked = true;
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "Node0";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Text = "Simulation Path:";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(178, 123);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // simulationWindowHeader
            // 
            this.simulationWindowHeader.BackColor = System.Drawing.SystemColors.Control;
            this.simulationWindowHeader.Controls.Add(this.simulationWindowHeaderTitle);
            this.simulationWindowHeader.Controls.Add(this.simulationWindowClose);
            this.simulationWindowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.simulationWindowHeader.Location = new System.Drawing.Point(0, 0);
            this.simulationWindowHeader.Name = "simulationWindowHeader";
            this.simulationWindowHeader.Size = new System.Drawing.Size(178, 20);
            this.simulationWindowHeader.TabIndex = 1;
            this.simulationWindowHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simulationWindowHeader_MouseMove);
            this.simulationWindowHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simulationWindowHeader_MouseDown);
            this.simulationWindowHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.simulationWindowHeader_MouseUp);
            // 
            // simulationWindowHeaderTitle
            // 
            this.simulationWindowHeaderTitle.AutoSize = true;
            this.simulationWindowHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simulationWindowHeaderTitle.Location = new System.Drawing.Point(3, 1);
            this.simulationWindowHeaderTitle.Name = "simulationWindowHeaderTitle";
            this.simulationWindowHeaderTitle.Size = new System.Drawing.Size(72, 15);
            this.simulationWindowHeaderTitle.TabIndex = 1;
            this.simulationWindowHeaderTitle.Text = "Initialization";
            this.simulationWindowHeaderTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simulationWindowHeaderTitle_MouseMove);
            this.simulationWindowHeaderTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simulationWindowHeaderTitle_MouseDown);
            this.simulationWindowHeaderTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.simulationWindowHeaderTitle_MouseUp);
            // 
            // simulationWindowClose
            // 
            this.simulationWindowClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.simulationWindowClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("simulationWindowClose.ErrorImage")));
            this.simulationWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("simulationWindowClose.Image")));
            this.simulationWindowClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("simulationWindowClose.InitialImage")));
            this.simulationWindowClose.Location = new System.Drawing.Point(157, 0);
            this.simulationWindowClose.Name = "simulationWindowClose";
            this.simulationWindowClose.Size = new System.Drawing.Size(21, 20);
            this.simulationWindowClose.TabIndex = 0;
            this.simulationWindowClose.TabStop = false;
            this.simulationWindowClose.MouseLeave += new System.EventHandler(this.simulationWindowClose_MouseLeave);
            this.simulationWindowClose.Click += new System.EventHandler(this.simulationWindowClose_Click);
            this.simulationWindowClose.MouseHover += new System.EventHandler(this.simulationWindowClose_MouseHover);
            // 
            // panelInputs
            // 
            this.panelInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputs.Controls.Add(this.richInputsDetail);
            this.panelInputs.Location = new System.Drawing.Point(162, 393);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(505, 153);
            this.panelInputs.TabIndex = 8;
            this.panelInputs.Visible = false;
            // 
            // richInputsDetail
            // 
            this.richInputsDetail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richInputsDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richInputsDetail.Location = new System.Drawing.Point(19, 17);
            this.richInputsDetail.Name = "richInputsDetail";
            this.richInputsDetail.ReadOnly = true;
            this.richInputsDetail.Size = new System.Drawing.Size(467, 121);
            this.richInputsDetail.TabIndex = 0;
            this.richInputsDetail.Text = "edd";
            // 
            // simInOutWindow
            // 
            this.simInOutWindow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.simInOutWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simInOutWindow.Controls.Add(this.tabSimulateInOut);
            this.simInOutWindow.Controls.Add(this.simInOutWindowHeader);
            this.simInOutWindow.Location = new System.Drawing.Point(670, 52);
            this.simInOutWindow.Name = "simInOutWindow";
            this.simInOutWindow.Size = new System.Drawing.Size(416, 304);
            this.simInOutWindow.TabIndex = 9;
            this.simInOutWindow.Visible = false;
            this.simInOutWindow.VisibleChanged += new System.EventHandler(this.simInOutWindow_VisibleChanged);
            this.simInOutWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.simInOutWindow_Paint);
            // 
            // tabSimulateInOut
            // 
            this.tabSimulateInOut.Controls.Add(this.tabPage5);
            this.tabSimulateInOut.Controls.Add(this.tabPage6);
            this.tabSimulateInOut.Controls.Add(this.tabPage7);
            this.tabSimulateInOut.Controls.Add(this.tabPage8);
            this.tabSimulateInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSimulateInOut.Location = new System.Drawing.Point(0, 20);
            this.tabSimulateInOut.Name = "tabSimulateInOut";
            this.tabSimulateInOut.SelectedIndex = 0;
            this.tabSimulateInOut.Size = new System.Drawing.Size(414, 282);
            this.tabSimulateInOut.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(406, 256);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPageTimeToFirst";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnTemporalEnd);
            this.tabPage6.Controls.Add(this.lblTemporalMaxValue);
            this.tabPage6.Controls.Add(this.maskedBoxMaxValueTemporalCoding);
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Controls.Add(this.panelTemporalCodingOutput);
            this.tabPage6.Controls.Add(this.panelTemporalCodingInputs);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(406, 256);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPageTemporalCoding";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnTemporalEnd
            // 
            this.btnTemporalEnd.Location = new System.Drawing.Point(211, 228);
            this.btnTemporalEnd.Name = "btnTemporalEnd";
            this.btnTemporalEnd.Size = new System.Drawing.Size(68, 23);
            this.btnTemporalEnd.TabIndex = 21;
            this.btnTemporalEnd.Text = "Finish";
            this.btnTemporalEnd.UseVisualStyleBackColor = true;
            this.btnTemporalEnd.Click += new System.EventHandler(this.btnTemporalEnd_Click);
            // 
            // lblTemporalMaxValue
            // 
            this.lblTemporalMaxValue.AutoSize = true;
            this.lblTemporalMaxValue.Location = new System.Drawing.Point(3, 232);
            this.lblTemporalMaxValue.Name = "lblTemporalMaxValue";
            this.lblTemporalMaxValue.Size = new System.Drawing.Size(58, 13);
            this.lblTemporalMaxValue.TabIndex = 4;
            this.lblTemporalMaxValue.Text = "max value:";
            // 
            // maskedBoxMaxValueTemporalCoding
            // 
            this.maskedBoxMaxValueTemporalCoding.Location = new System.Drawing.Point(66, 229);
            this.maskedBoxMaxValueTemporalCoding.Name = "maskedBoxMaxValueTemporalCoding";
            this.maskedBoxMaxValueTemporalCoding.Size = new System.Drawing.Size(58, 20);
            this.maskedBoxMaxValueTemporalCoding.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Feed";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelTemporalCodingOutput
            // 
            this.panelTemporalCodingOutput.AutoScroll = true;
            this.panelTemporalCodingOutput.Location = new System.Drawing.Point(204, 0);
            this.panelTemporalCodingOutput.Name = "panelTemporalCodingOutput";
            this.panelTemporalCodingOutput.Size = new System.Drawing.Size(203, 225);
            this.panelTemporalCodingOutput.TabIndex = 1;
            // 
            // panelTemporalCodingInputs
            // 
            this.panelTemporalCodingInputs.AutoScroll = true;
            this.panelTemporalCodingInputs.Location = new System.Drawing.Point(0, 0);
            this.panelTemporalCodingInputs.Name = "panelTemporalCodingInputs";
            this.panelTemporalCodingInputs.Size = new System.Drawing.Size(205, 225);
            this.panelTemporalCodingInputs.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnGaussianEnd);
            this.tabPage7.Controls.Add(this.maskedBoxFieldsNo);
            this.tabPage7.Controls.Add(this.lblGaussianSimFields);
            this.tabPage7.Controls.Add(this.maskedBoxTmax);
            this.tabPage7.Controls.Add(this.label20);
            this.tabPage7.Controls.Add(this.maskedBoxRangeTo);
            this.tabPage7.Controls.Add(this.label19);
            this.tabPage7.Controls.Add(this.maskedBoxRangeFrom);
            this.tabPage7.Controls.Add(this.lblGaussianSimRange);
            this.tabPage7.Controls.Add(this.lblGaussianSimGamma);
            this.tabPage7.Controls.Add(this.maskedBoxGamma);
            this.tabPage7.Controls.Add(this.button8);
            this.tabPage7.Controls.Add(this.panelGaussianCodingOutputs);
            this.tabPage7.Controls.Add(this.panelGaussianCodingInput);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(406, 256);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "tabPageGaussian";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnGaussianEnd
            // 
            this.btnGaussianEnd.Location = new System.Drawing.Point(357, 229);
            this.btnGaussianEnd.Name = "btnGaussianEnd";
            this.btnGaussianEnd.Size = new System.Drawing.Size(46, 23);
            this.btnGaussianEnd.TabIndex = 20;
            this.btnGaussianEnd.Text = "Finish";
            this.btnGaussianEnd.UseVisualStyleBackColor = true;
            this.btnGaussianEnd.Click += new System.EventHandler(this.btnGaussianEnd_Click);
            // 
            // maskedBoxFieldsNo
            // 
            this.maskedBoxFieldsNo.Location = new System.Drawing.Point(288, 231);
            this.maskedBoxFieldsNo.Mask = "00";
            this.maskedBoxFieldsNo.Name = "maskedBoxFieldsNo";
            this.maskedBoxFieldsNo.Size = new System.Drawing.Size(22, 20);
            this.maskedBoxFieldsNo.TabIndex = 19;
            // 
            // lblGaussianSimFields
            // 
            this.lblGaussianSimFields.AutoSize = true;
            this.lblGaussianSimFields.Location = new System.Drawing.Point(254, 235);
            this.lblGaussianSimFields.Name = "lblGaussianSimFields";
            this.lblGaussianSimFields.Size = new System.Drawing.Size(37, 13);
            this.lblGaussianSimFields.TabIndex = 18;
            this.lblGaussianSimFields.Text = "Fields:";
            // 
            // maskedBoxTmax
            // 
            this.maskedBoxTmax.Location = new System.Drawing.Point(218, 231);
            this.maskedBoxTmax.Mask = "000.0";
            this.maskedBoxTmax.Name = "maskedBoxTmax";
            this.maskedBoxTmax.Size = new System.Drawing.Size(35, 20);
            this.maskedBoxTmax.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(185, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Tmax:";
            // 
            // maskedBoxRangeTo
            // 
            this.maskedBoxRangeTo.Location = new System.Drawing.Point(151, 231);
            this.maskedBoxRangeTo.Mask = "000.0";
            this.maskedBoxRangeTo.Name = "maskedBoxRangeTo";
            this.maskedBoxRangeTo.Size = new System.Drawing.Size(35, 20);
            this.maskedBoxRangeTo.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(144, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "-";
            // 
            // maskedBoxRangeFrom
            // 
            this.maskedBoxRangeFrom.Location = new System.Drawing.Point(105, 231);
            this.maskedBoxRangeFrom.Mask = "#000.0";
            this.maskedBoxRangeFrom.Name = "maskedBoxRangeFrom";
            this.maskedBoxRangeFrom.Size = new System.Drawing.Size(39, 20);
            this.maskedBoxRangeFrom.TabIndex = 13;
            // 
            // lblGaussianSimRange
            // 
            this.lblGaussianSimRange.AutoSize = true;
            this.lblGaussianSimRange.Location = new System.Drawing.Point(66, 235);
            this.lblGaussianSimRange.Name = "lblGaussianSimRange";
            this.lblGaussianSimRange.Size = new System.Drawing.Size(42, 13);
            this.lblGaussianSimRange.TabIndex = 12;
            this.lblGaussianSimRange.Text = "Range:";
            // 
            // lblGaussianSimGamma
            // 
            this.lblGaussianSimGamma.AutoSize = true;
            this.lblGaussianSimGamma.Location = new System.Drawing.Point(-2, 234);
            this.lblGaussianSimGamma.Name = "lblGaussianSimGamma";
            this.lblGaussianSimGamma.Size = new System.Drawing.Size(46, 13);
            this.lblGaussianSimGamma.TabIndex = 10;
            this.lblGaussianSimGamma.Text = "Gamma:";
            // 
            // maskedBoxGamma
            // 
            this.maskedBoxGamma.Location = new System.Drawing.Point(43, 231);
            this.maskedBoxGamma.Mask = "0.0";
            this.maskedBoxGamma.Name = "maskedBoxGamma";
            this.maskedBoxGamma.Size = new System.Drawing.Size(23, 20);
            this.maskedBoxGamma.TabIndex = 9;
            this.maskedBoxGamma.Text = "15";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(314, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Feed";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelGaussianCodingOutputs
            // 
            this.panelGaussianCodingOutputs.AutoScroll = true;
            this.panelGaussianCodingOutputs.Location = new System.Drawing.Point(204, 2);
            this.panelGaussianCodingOutputs.Name = "panelGaussianCodingOutputs";
            this.panelGaussianCodingOutputs.Size = new System.Drawing.Size(203, 225);
            this.panelGaussianCodingOutputs.TabIndex = 7;
            // 
            // panelGaussianCodingInput
            // 
            this.panelGaussianCodingInput.AutoScroll = true;
            this.panelGaussianCodingInput.Controls.Add(this.maskedBoxValue);
            this.panelGaussianCodingInput.Controls.Add(this.lblGaussianInputValue);
            this.panelGaussianCodingInput.Location = new System.Drawing.Point(0, 2);
            this.panelGaussianCodingInput.Name = "panelGaussianCodingInput";
            this.panelGaussianCodingInput.Size = new System.Drawing.Size(205, 225);
            this.panelGaussianCodingInput.TabIndex = 6;
            // 
            // maskedBoxValue
            // 
            this.maskedBoxValue.Location = new System.Drawing.Point(69, 8);
            this.maskedBoxValue.Mask = "#000.0";
            this.maskedBoxValue.Name = "maskedBoxValue";
            this.maskedBoxValue.Size = new System.Drawing.Size(39, 20);
            this.maskedBoxValue.TabIndex = 21;
            // 
            // lblGaussianInputValue
            // 
            this.lblGaussianInputValue.AutoSize = true;
            this.lblGaussianInputValue.Location = new System.Drawing.Point(8, 11);
            this.lblGaussianInputValue.Name = "lblGaussianInputValue";
            this.lblGaussianInputValue.Size = new System.Drawing.Size(63, 13);
            this.lblGaussianInputValue.TabIndex = 20;
            this.lblGaussianInputValue.Text = "Input value:";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btnImageEnd);
            this.tabPage8.Controls.Add(this.buttonStimulateImageRec);
            this.tabPage8.Controls.Add(this.maskedBoxInputDelayImageRec);
            this.tabPage8.Controls.Add(this.lblInputNeuronDelaySim);
            this.tabPage8.Controls.Add(this.lblCharacterRepresentation);
            this.tabPage8.Controls.Add(this.pictureBox4);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(406, 256);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "tabPageImageRec";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btnImageEnd
            // 
            this.btnImageEnd.Location = new System.Drawing.Point(320, 230);
            this.btnImageEnd.Name = "btnImageEnd";
            this.btnImageEnd.Size = new System.Drawing.Size(68, 23);
            this.btnImageEnd.TabIndex = 22;
            this.btnImageEnd.Text = "Finish";
            this.btnImageEnd.UseVisualStyleBackColor = true;
            this.btnImageEnd.Click += new System.EventHandler(this.btnImageEnd_Click);
            // 
            // buttonStimulateImageRec
            // 
            this.buttonStimulateImageRec.Location = new System.Drawing.Point(239, 230);
            this.buttonStimulateImageRec.Name = "buttonStimulateImageRec";
            this.buttonStimulateImageRec.Size = new System.Drawing.Size(75, 23);
            this.buttonStimulateImageRec.TabIndex = 4;
            this.buttonStimulateImageRec.Text = "Stimulate";
            this.buttonStimulateImageRec.UseVisualStyleBackColor = true;
            this.buttonStimulateImageRec.Click += new System.EventHandler(this.buttonStimulateImageRec_Click);
            // 
            // maskedBoxInputDelayImageRec
            // 
            this.maskedBoxInputDelayImageRec.Location = new System.Drawing.Point(114, 228);
            this.maskedBoxInputDelayImageRec.Mask = "000";
            this.maskedBoxInputDelayImageRec.Name = "maskedBoxInputDelayImageRec";
            this.maskedBoxInputDelayImageRec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskedBoxInputDelayImageRec.Size = new System.Drawing.Size(56, 20);
            this.maskedBoxInputDelayImageRec.TabIndex = 3;
            // 
            // lblInputNeuronDelaySim
            // 
            this.lblInputNeuronDelaySim.AutoSize = true;
            this.lblInputNeuronDelaySim.Location = new System.Drawing.Point(6, 231);
            this.lblInputNeuronDelaySim.Name = "lblInputNeuronDelaySim";
            this.lblInputNeuronDelaySim.Size = new System.Drawing.Size(102, 13);
            this.lblInputNeuronDelaySim.TabIndex = 2;
            this.lblInputNeuronDelaySim.Text = "Input Neuron Delay:";
            // 
            // lblCharacterRepresentation
            // 
            this.lblCharacterRepresentation.AutoSize = true;
            this.lblCharacterRepresentation.Location = new System.Drawing.Point(6, 8);
            this.lblCharacterRepresentation.Name = "lblCharacterRepresentation";
            this.lblCharacterRepresentation.Size = new System.Drawing.Size(128, 13);
            this.lblCharacterRepresentation.TabIndex = 1;
            this.lblCharacterRepresentation.Text = "Character Representation";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(379, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // simInOutWindowHeader
            // 
            this.simInOutWindowHeader.BackColor = System.Drawing.SystemColors.Control;
            this.simInOutWindowHeader.Controls.Add(this.simInOutWindowTitle);
            this.simInOutWindowHeader.Controls.Add(this.simInOutWindowClose);
            this.simInOutWindowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.simInOutWindowHeader.Location = new System.Drawing.Point(0, 0);
            this.simInOutWindowHeader.Name = "simInOutWindowHeader";
            this.simInOutWindowHeader.Size = new System.Drawing.Size(414, 20);
            this.simInOutWindowHeader.TabIndex = 1;
            this.simInOutWindowHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simInOutWindowHeader_MouseMove);
            this.simInOutWindowHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simInOutWindowHeader_MouseDown);
            this.simInOutWindowHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.simInOutWindowHeader_MouseUp);
            // 
            // simInOutWindowTitle
            // 
            this.simInOutWindowTitle.AutoSize = true;
            this.simInOutWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simInOutWindowTitle.Location = new System.Drawing.Point(3, 1);
            this.simInOutWindowTitle.Name = "simInOutWindowTitle";
            this.simInOutWindowTitle.Size = new System.Drawing.Size(56, 15);
            this.simInOutWindowTitle.TabIndex = 1;
            this.simInOutWindowTitle.Text = "Simulate";
            this.simInOutWindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simInOutWindowTitle_MouseMove);
            this.simInOutWindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simInOutWindowTitle_MouseDown);
            this.simInOutWindowTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.simInOutWindowTitle_MouseUp);
            // 
            // simInOutWindowClose
            // 
            this.simInOutWindowClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.simInOutWindowClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("simInOutWindowClose.ErrorImage")));
            this.simInOutWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("simInOutWindowClose.Image")));
            this.simInOutWindowClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("simInOutWindowClose.InitialImage")));
            this.simInOutWindowClose.Location = new System.Drawing.Point(393, 0);
            this.simInOutWindowClose.Name = "simInOutWindowClose";
            this.simInOutWindowClose.Size = new System.Drawing.Size(21, 20);
            this.simInOutWindowClose.TabIndex = 0;
            this.simInOutWindowClose.TabStop = false;
            this.simInOutWindowClose.MouseLeave += new System.EventHandler(this.simInOutWindowClose_MouseLeave);
            this.simInOutWindowClose.Click += new System.EventHandler(this.simInOutWindowClose_Click);
            this.simInOutWindowClose.MouseHover += new System.EventHandler(this.simInOutWindowClose_MouseHover);
            // 
            // openStructDialog
            // 
            this.openStructDialog.FileName = "openFileDialog1";
            this.openStructDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openStructDialog_FileOk);
            // 
            // saveStructDialog
            // 
            this.saveStructDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveStructDialog_FileOk);
            // 
            // openDataSourceDialog
            // 
            this.openDataSourceDialog.FileName = "openFileDialog1";
            this.openDataSourceDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDataSourceDialog_FileOk);
            // 
            // saveOutputFile
            // 
            this.saveOutputFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveOutputFile_FileOk);
            // 
            // timerSimulation
            // 
            this.timerSimulation.Interval = 50;
            this.timerSimulation.Tick += new System.EventHandler(this.timerSimulation_Tick);
            // 
            // SNNmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 752);
            this.Controls.Add(this.simInOutWindow);
            this.Controls.Add(this.simulationWindow);
            this.Controls.Add(this.detailsWindow);
            this.Controls.Add(this.designEditor);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelInputs);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(144, 100);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SNNmain";
            this.Text = "Neural Networks";
            this.Load += new System.EventHandler(this.SNNmain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SNNmain_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SNNmain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.designEditor.ResumeLayout(false);
            this.groupBoxStructure.ResumeLayout(false);
            this.groupBoxStructure.PerformLayout();
            this.groupBoxLayers.ResumeLayout(false);
            this.groupBoxLayers.PerformLayout();
            this.groupBoxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolMousePointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolNeuronEraser)).EndInit();
            this.designEditorHeader.ResumeLayout(false);
            this.designEditorHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designEditorClose)).EndInit();
            this.detailsWindow.ResumeLayout(false);
            this.tabDetailsWindow.ResumeLayout(false);
            this.tabDetailsWindowTab0.ResumeLayout(false);
            this.tabDetailsWindowTab0.PerformLayout();
            this.inputsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.detailsWindowHeader.ResumeLayout(false);
            this.detailsWindowHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsWindowClose)).EndInit();
            this.simulationWindow.ResumeLayout(false);
            this.tabSim.ResumeLayout(false);
            this.tabSimPref.ResumeLayout(false);
            this.groupPSPFunction.ResumeLayout(false);
            this.groupPSPFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabSimSource.ResumeLayout(false);
            this.groupDataSrc.ResumeLayout(false);
            this.groupDataSrc.PerformLayout();
            this.tabSimCoding.ResumeLayout(false);
            this.tabSimCoding.PerformLayout();
            this.tabSimInit.ResumeLayout(false);
            this.tabSimInit.PerformLayout();
            this.groupDealyInit.ResumeLayout(false);
            this.groupDealyInit.PerformLayout();
            this.groupWeightInit.ResumeLayout(false);
            this.groupWeightInit.PerformLayout();
            this.tabSimLearning.ResumeLayout(false);
            this.tabSimLearning.PerformLayout();
            this.tabLearning.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabSimStart.ResumeLayout(false);
            this.tabSimStart.PerformLayout();
            this.simulationWindowHeader.ResumeLayout(false);
            this.simulationWindowHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationWindowClose)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.simInOutWindow.ResumeLayout(false);
            this.tabSimulateInOut.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panelGaussianCodingInput.ResumeLayout(false);
            this.panelGaussianCodingInput.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.simInOutWindowHeader.ResumeLayout(false);
            this.simInOutWindowHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simInOutWindowClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripNew;
        private System.Windows.Forms.ToolStripMenuItem menuStripLoad;
        private System.Windows.Forms.ToolStripMenuItem menuStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStripExit;
        private System.Windows.Forms.ToolStripMenuItem menuStripView;
        private System.Windows.Forms.ToolStripMenuItem menuStripWindows;
        private System.Windows.Forms.ToolStripMenuItem menuStripSimulation;
        private System.Windows.Forms.ToolStripMenuItem menuStripInitializeSimulation;
        private System.Windows.Forms.ToolStripMenuItem menuStripTools;
        private System.Windows.Forms.ToolStripMenuItem menuStripPlot;
        private System.Windows.Forms.ToolStripMenuItem menuStripPlotInput;
        private System.Windows.Forms.ToolStripMenuItem menuStripPlotLayer1;
        private System.Windows.Forms.ToolStripMenuItem menuStripPlotOutput;
        private System.Windows.Forms.ToolStripMenuItem menuStripGaussianRF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelp;
        private System.Windows.Forms.ToolStripMenuItem menuStripAbout;
        private System.Windows.Forms.Panel designEditor;
        private System.Windows.Forms.Panel designEditorHeader;
        private System.Windows.Forms.Label designEditorHeaderTitle;
        private System.Windows.Forms.PictureBox designEditorClose;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxStructure;
        private System.Windows.Forms.GroupBox groupBoxLayers;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox boxOutput;
        private System.Windows.Forms.Label lblOutputNr;
        private System.Windows.Forms.MaskedTextBox boxLayer2;
        private System.Windows.Forms.Label lblLayer2Nr;
        private System.Windows.Forms.MaskedTextBox boxLayer1;
        private System.Windows.Forms.Label lblLayer1Nr;
        private System.Windows.Forms.MaskedTextBox boxInput;
        private System.Windows.Forms.Label lblInputNr;
        private System.Windows.Forms.Button btnUpdateStructure;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox toolMousePointer;
        private System.Windows.Forms.PictureBox toolNeuronEraser;
        private System.Windows.Forms.Panel detailsWindow;
        private System.Windows.Forms.Panel detailsWindowHeader;
        private System.Windows.Forms.PictureBox detailsWindowClose;
        private System.Windows.Forms.Label detailsWindowHeaderTitle;
        private System.Windows.Forms.Panel simulationWindow;
        private System.Windows.Forms.Panel simulationWindowHeader;
        private System.Windows.Forms.Label simulationWindowHeaderTitle;
        private System.Windows.Forms.PictureBox simulationWindowClose;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.RichTextBox richInputsDetail;
        private System.Windows.Forms.Panel simInOutWindow;
        private System.Windows.Forms.Panel simInOutWindowHeader;
        private System.Windows.Forms.Label simInOutWindowTitle;
        private System.Windows.Forms.PictureBox simInOutWindowClose;
        private System.Windows.Forms.ToolStripMenuItem menuStripStructureToolBox;
        private System.Windows.Forms.ToolStripMenuItem menuStripWindowWorkspace;
        private System.Windows.Forms.ToolStripMenuItem menuStripWindowDetails;
        private System.Windows.Forms.ToolStripMenuItem menuStripWindowInitialization;
        private System.Windows.Forms.ToolStripMenuItem menuStripWindowSimulation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuStripApplicationMode;
        private System.Windows.Forms.ToolStripMenuItem menuStripModeSNN;
        private System.Windows.Forms.ToolStripMenuItem menuStripModeANN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuStripPlotEntireNetwork;
        private System.Windows.Forms.OpenFileDialog openStructDialog;
        private System.Windows.Forms.SaveFileDialog saveStructDialog;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabSim;
        private System.Windows.Forms.TabPage tabSimPref;
        private System.Windows.Forms.GroupBox groupPSPFunction;
        private System.Windows.Forms.RadioButton radioRealPSP;
        private System.Windows.Forms.RadioButton radioIdealPSP;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabSimSource;
        private System.Windows.Forms.TabPage tabSimCoding;
        private System.Windows.Forms.TabPage tabSimInit;
        private System.Windows.Forms.TabPage tabSimLearning;
        private System.Windows.Forms.TabPage tabSimStart;
        private System.Windows.Forms.GroupBox groupDataSrc;
        private System.Windows.Forms.RadioButton radioSrcTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxSourceFile;
        private System.Windows.Forms.RadioButton radioSrcFile;
        private System.Windows.Forms.RadioButton radioSrcManual;
        private System.Windows.Forms.MaskedTextBox maskedBoxImageRecTO;
        private System.Windows.Forms.Label lblImageRecX;
        private System.Windows.Forms.MaskedTextBox maskedBoxImageRecFROM;
        private System.Windows.Forms.Label lblImageRecLabel;
        private System.Windows.Forms.RadioButton radioCodingImageRecognition;
        private System.Windows.Forms.RadioButton radioCodingPopulationGauss;
        private System.Windows.Forms.RadioButton radioCodingPopulationSimple;
        private System.Windows.Forms.Label lblCodingMode;
        private System.Windows.Forms.GroupBox groupDealyInit;
        private System.Windows.Forms.MaskedTextBox maskedBoxLayerDelayTo;
        private System.Windows.Forms.Label lblLayerDelay;
        private System.Windows.Forms.GroupBox groupWeightInit;
        private System.Windows.Forms.MaskedTextBox maskedBoxRandomTo;
        private System.Windows.Forms.Label lblWeightRandomSeparator;
        private System.Windows.Forms.MaskedTextBox maskedBoxRandomFrom;
        private System.Windows.Forms.Label lblWeightInitParams;
        private System.Windows.Forms.MaskedTextBox maskedBoxThreshold;
        private System.Windows.Forms.Label lblNeuronThr;
        private System.Windows.Forms.CheckBox checkBoxRandomParameters;
        private System.Windows.Forms.TabControl tabLearning;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MaskedTextBox maskedBoxMaxW;
        private System.Windows.Forms.Label lblMaxWeight;
        private System.Windows.Forms.MaskedTextBox maskedBoxA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox maskedBoxTauP;
        private System.Windows.Forms.MaskedTextBox maskedBoxTauD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioLearningNone;
        private System.Windows.Forms.RadioButton radioLearningSTDP;
        private System.Windows.Forms.Label lblLearningRules;
        private System.Windows.Forms.MaskedTextBox maskedBoxMinW;
        private System.Windows.Forms.Label lblMinWeight;
        private System.Windows.Forms.MaskedTextBox maskedBoxDelayInputTo;
        private System.Windows.Forms.Label lblInputDelayInit;
        private System.Windows.Forms.Label lblOutputInterpretation;
        private System.Windows.Forms.RadioButton radioOutFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioOutNothing;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.MaskedTextBox BoxStimuliPerEpoch;
        private System.Windows.Forms.Label lblStimuliPerEpoch;
        private System.Windows.Forms.OpenFileDialog openDataSourceDialog;
        private System.Windows.Forms.MaskedTextBox maskedBoxStimuliFileTime;
        private System.Windows.Forms.Label lblStimuliFileTime;
        private System.Windows.Forms.SaveFileDialog saveOutputFile;
        private System.Windows.Forms.TabControl tabDetailsWindow;
        private System.Windows.Forms.TabPage tabDetailsWindowTab0;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Label lblPotential;
        private System.Windows.Forms.Panel inputsPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox boxThreshold;
        private System.Windows.Forms.TextBox boxWeight;
        private System.Windows.Forms.TextBox boxDelay;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDelay;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape detailShape;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TabPage tabDetailsWindowTab1;
        private System.Windows.Forms.TabPage tabDetailsWindowTab2;
        private System.Windows.Forms.Label lblWhichLayer;
        private System.Windows.Forms.Timer timerSimulation;
        private System.Windows.Forms.ToolStripButton toolNew;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripBoxTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox boxSelectWeights;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSimStop;
        private System.Windows.Forms.ToolStripMenuItem menuStripRecent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuStripInputFileTool;
        private System.Windows.Forms.ToolStripMenuItem menuStripGenerateVHDL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.TabControl tabSimulateInOut;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lblTemporalMaxValue;
        private System.Windows.Forms.MaskedTextBox maskedBoxMaxValueTemporalCoding;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panelTemporalCodingOutput;
        private System.Windows.Forms.Panel panelTemporalCodingInputs;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.MaskedTextBox maskedBoxFieldsNo;
        private System.Windows.Forms.Label lblGaussianSimFields;
        private System.Windows.Forms.MaskedTextBox maskedBoxTmax;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox maskedBoxRangeTo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox maskedBoxRangeFrom;
        private System.Windows.Forms.Label lblGaussianSimRange;
        private System.Windows.Forms.Label lblGaussianSimGamma;
        private System.Windows.Forms.MaskedTextBox maskedBoxGamma;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panelGaussianCodingOutputs;
        private System.Windows.Forms.Panel panelGaussianCodingInput;
        private System.Windows.Forms.MaskedTextBox maskedBoxValue;
        private System.Windows.Forms.Label lblGaussianInputValue;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button buttonStimulateImageRec;
        private System.Windows.Forms.MaskedTextBox maskedBoxInputDelayImageRec;
        private System.Windows.Forms.Label lblInputNeuronDelaySim;
        private System.Windows.Forms.Label lblCharacterRepresentation;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnGaussianEnd;
        private System.Windows.Forms.Button btnTemporalEnd;
        private System.Windows.Forms.Button btnImageEnd;
        private System.Windows.Forms.MaskedTextBox maskedBoxMaxTSim;
        private System.Windows.Forms.MaskedTextBox maskedBoxRangeSimTo;
        private System.Windows.Forms.MaskedTextBox maskedBoxGammaSim;
        private System.Windows.Forms.MaskedTextBox maskedBoxRangeSimFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRangeSim;
        private System.Windows.Forms.Label lblMaxTSim;
        private System.Windows.Forms.Label lblGammaSim;
    }
}