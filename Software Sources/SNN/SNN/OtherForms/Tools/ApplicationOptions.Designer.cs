namespace SNN.OtherForms.Tools
{
    partial class ApplicationOptions
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Colors");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Paths");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Others");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Environment", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Neuron Behaviour");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Graphs & Plotting");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Simulation", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Hardware Code Options");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("VHDL Code Generator", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationOptions));
            this.optionTree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabEnvironmentGeneral = new System.Windows.Forms.TabPage();
            this.maskedBoxMaxRecent = new System.Windows.Forms.MaskedTextBox();
            this.lblMaximumRecent = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.lblApplicationLanguage = new System.Windows.Forms.Label();
            this.lblGeneralTitle = new System.Windows.Forms.Label();
            this.tabEnvironmentColors = new System.Windows.Forms.TabPage();
            this.groupOptionsRasterColors = new System.Windows.Forms.GroupBox();
            this.comboBoxColorPickerEntireOutput = new System.Windows.Forms.ComboBox();
            this.lblEntireActivityOutputColor = new System.Windows.Forms.Label();
            this.comboBoxColorPickerEntireLayer1 = new System.Windows.Forms.ComboBox();
            this.lblEntireActivityLayer1Color = new System.Windows.Forms.Label();
            this.comboBoxColorPickerEntireInput = new System.Windows.Forms.ComboBox();
            this.lblEntireActivityInputColor = new System.Windows.Forms.Label();
            this.comboBoxColorPickerStdBars = new System.Windows.Forms.ComboBox();
            this.lblStandardPloterBar = new System.Windows.Forms.Label();
            this.tabEnvironmentPaths = new System.Windows.Forms.TabPage();
            this.btnHardwareSnn = new System.Windows.Forms.Button();
            this.textBoxOptionSnnHardwareSrcPath = new System.Windows.Forms.TextBox();
            this.lblHardwareSnnPath = new System.Windows.Forms.Label();
            this.btnHardwareAnn = new System.Windows.Forms.Button();
            this.textBoxOptionAnnHardwareSrcPath = new System.Windows.Forms.TextBox();
            this.lblHardwareAnnPath = new System.Windows.Forms.Label();
            this.btnStimuliHardwarePath = new System.Windows.Forms.Button();
            this.textBoxOptionStimuliHardwarePath = new System.Windows.Forms.TextBox();
            this.lblOptionHardwarePath = new System.Windows.Forms.Label();
            this.btnStimuliOutputPath = new System.Windows.Forms.Button();
            this.textBoxOptionStimuliOutputPath = new System.Windows.Forms.TextBox();
            this.lblOptionOutputPath = new System.Windows.Forms.Label();
            this.btnStimuliSNNPath = new System.Windows.Forms.Button();
            this.textBoxOptionStimuliSNNPath = new System.Windows.Forms.TextBox();
            this.lblOptionSNNetworksPath = new System.Windows.Forms.Label();
            this.btnStimuliSrcPath = new System.Windows.Forms.Button();
            this.textBoxOptionStimuliSrcPath = new System.Windows.Forms.TextBox();
            this.lblOptionsPathStimuliSrc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabEnvironmentOthers = new System.Windows.Forms.TabPage();
            this.btnRestoreDefault = new System.Windows.Forms.Button();
            this.lblClearProperties = new System.Windows.Forms.Label();
            this.btnClearRecent = new System.Windows.Forms.Button();
            this.lblClearRecent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabSimulation = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabSimulationBehaviour = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedBoxClearHistoryTime = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabSimulationGraphs = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMoveGraph = new System.Windows.Forms.Label();
            this.maskedBoxMoveMembranePotential = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxMoveMembranePotential = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabVHDL = new System.Windows.Forms.TabPage();
            this.richTextHeader = new System.Windows.Forms.RichTextBox();
            this.lblVHDLtitle = new System.Windows.Forms.Label();
            this.checkBoxHeaderAdd = new System.Windows.Forms.CheckBox();
            this.checkBoxGenerateTestBench = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBoxOtherHDLoptions = new System.Windows.Forms.GroupBox();
            this.maskedTextRefractoryDuration = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextPSPstep = new System.Windows.Forms.MaskedTextBox();
            this.lblPSPstep = new System.Windows.Forms.Label();
            this.maskedTextPSPduration = new System.Windows.Forms.MaskedTextBox();
            this.lblPSPduration = new System.Windows.Forms.Label();
            this.lblFunctionCoding = new System.Windows.Forms.Label();
            this.radioRealPSPcode = new System.Windows.Forms.RadioButton();
            this.radioIdealPSPcode = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.maskedTextFreqDiv = new System.Windows.Forms.MaskedTextBox();
            this.lblFreqDivider = new System.Windows.Forms.Label();
            this.groupBoxCodingOptions = new System.Windows.Forms.GroupBox();
            this.lblHDLCodingRange = new System.Windows.Forms.Label();
            this.maskedBoxWordLength = new System.Windows.Forms.MaskedTextBox();
            this.lblHDLcodingBitsNumber = new System.Windows.Forms.Label();
            this.lblCodingWordLength = new System.Windows.Forms.Label();
            this.maskedBoxCodeBits = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxCodeRangeTo = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxCodeRangeFrom = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOptionsOK = new System.Windows.Forms.Button();
            this.btnOptionsCancel = new System.Windows.Forms.Button();
            this.colorDialogStdBar = new System.Windows.Forms.ColorDialog();
            this.colorDialogEntireActiv = new System.Windows.Forms.ColorDialog();
            this.folderBrowserStimuli = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserStructures = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.tabMenu.SuspendLayout();
            this.tabEnvironmentGeneral.SuspendLayout();
            this.tabEnvironmentColors.SuspendLayout();
            this.groupOptionsRasterColors.SuspendLayout();
            this.tabEnvironmentPaths.SuspendLayout();
            this.tabEnvironmentOthers.SuspendLayout();
            this.tabSimulation.SuspendLayout();
            this.tabSimulationBehaviour.SuspendLayout();
            this.tabSimulationGraphs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabVHDL.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBoxOtherHDLoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxCodingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionTree
            // 
            this.optionTree.Location = new System.Drawing.Point(0, 0);
            this.optionTree.Name = "optionTree";
            treeNode1.Name = "NodeEnvirontmentGeneral";
            treeNode1.Text = "General";
            treeNode2.Name = "NodeEnvironmentColors";
            treeNode2.Text = "Colors";
            treeNode3.Name = "NodeEnvironmentPaths";
            treeNode3.Text = "Paths";
            treeNode4.Name = "NodeEnvironmentOthers";
            treeNode4.Text = "Others";
            treeNode5.Name = "NodeEnvironment";
            treeNode5.Text = "Environment";
            treeNode6.Name = "NodeSimulationNeuronBehave";
            treeNode6.Text = "Neuron Behaviour";
            treeNode7.Name = "NodeSimulationGraphsPlotting";
            treeNode7.Text = "Graphs & Plotting";
            treeNode8.Name = "NodeSimulation";
            treeNode8.Text = "Simulation";
            treeNode9.Name = "NodeVHDLcoding";
            treeNode9.Text = "Hardware Code Options";
            treeNode10.Name = "NodeVHDL";
            treeNode10.Text = "VHDL Code Generator";
            this.optionTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode10});
            this.optionTree.Size = new System.Drawing.Size(200, 342);
            this.optionTree.TabIndex = 1;
            this.optionTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.optionTree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Environment Options:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "General Environment Options:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "General Environment Options:";
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabEnvironmentGeneral);
            this.tabMenu.Controls.Add(this.tabEnvironmentColors);
            this.tabMenu.Controls.Add(this.tabEnvironmentPaths);
            this.tabMenu.Controls.Add(this.tabEnvironmentOthers);
            this.tabMenu.Controls.Add(this.tabSimulation);
            this.tabMenu.Controls.Add(this.tabSimulationBehaviour);
            this.tabMenu.Controls.Add(this.tabSimulationGraphs);
            this.tabMenu.Controls.Add(this.tabVHDL);
            this.tabMenu.Controls.Add(this.tabPage9);
            this.tabMenu.Location = new System.Drawing.Point(202, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(535, 332);
            this.tabMenu.TabIndex = 4;
            // 
            // tabEnvironmentGeneral
            // 
            this.tabEnvironmentGeneral.Controls.Add(this.maskedBoxMaxRecent);
            this.tabEnvironmentGeneral.Controls.Add(this.lblMaximumRecent);
            this.tabEnvironmentGeneral.Controls.Add(this.comboBoxLanguage);
            this.tabEnvironmentGeneral.Controls.Add(this.lblApplicationLanguage);
            this.tabEnvironmentGeneral.Controls.Add(this.lblGeneralTitle);
            this.tabEnvironmentGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabEnvironmentGeneral.Name = "tabEnvironmentGeneral";
            this.tabEnvironmentGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnvironmentGeneral.Size = new System.Drawing.Size(527, 306);
            this.tabEnvironmentGeneral.TabIndex = 0;
            this.tabEnvironmentGeneral.Text = "tabPage1";
            this.tabEnvironmentGeneral.UseVisualStyleBackColor = true;
            // 
            // maskedBoxMaxRecent
            // 
            this.maskedBoxMaxRecent.Location = new System.Drawing.Point(211, 62);
            this.maskedBoxMaxRecent.Mask = "00";
            this.maskedBoxMaxRecent.Name = "maskedBoxMaxRecent";
            this.maskedBoxMaxRecent.Size = new System.Drawing.Size(41, 20);
            this.maskedBoxMaxRecent.TabIndex = 6;
            this.maskedBoxMaxRecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaximumRecent
            // 
            this.lblMaximumRecent.AutoSize = true;
            this.lblMaximumRecent.Location = new System.Drawing.Point(23, 65);
            this.lblMaximumRecent.Name = "lblMaximumRecent";
            this.lblMaximumRecent.Size = new System.Drawing.Size(165, 13);
            this.lblMaximumRecent.TabIndex = 5;
            this.lblMaximumRecent.Text = "Maximum Number of Recent Files";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Polski",
            "Español"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(149, 30);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(103, 21);
            this.comboBoxLanguage.TabIndex = 4;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // lblApplicationLanguage
            // 
            this.lblApplicationLanguage.AutoSize = true;
            this.lblApplicationLanguage.Location = new System.Drawing.Point(23, 33);
            this.lblApplicationLanguage.Name = "lblApplicationLanguage";
            this.lblApplicationLanguage.Size = new System.Drawing.Size(103, 13);
            this.lblApplicationLanguage.TabIndex = 3;
            this.lblApplicationLanguage.Text = "Interface Language:";
            // 
            // lblGeneralTitle
            // 
            this.lblGeneralTitle.AutoSize = true;
            this.lblGeneralTitle.Location = new System.Drawing.Point(6, 3);
            this.lblGeneralTitle.Name = "lblGeneralTitle";
            this.lblGeneralTitle.Size = new System.Drawing.Size(148, 13);
            this.lblGeneralTitle.TabIndex = 0;
            this.lblGeneralTitle.Text = "General Environment Options:";
            // 
            // tabEnvironmentColors
            // 
            this.tabEnvironmentColors.Controls.Add(this.groupOptionsRasterColors);
            this.tabEnvironmentColors.Location = new System.Drawing.Point(4, 22);
            this.tabEnvironmentColors.Name = "tabEnvironmentColors";
            this.tabEnvironmentColors.Size = new System.Drawing.Size(527, 306);
            this.tabEnvironmentColors.TabIndex = 6;
            this.tabEnvironmentColors.Text = "tabPage7";
            this.tabEnvironmentColors.UseVisualStyleBackColor = true;
            // 
            // groupOptionsRasterColors
            // 
            this.groupOptionsRasterColors.Controls.Add(this.comboBoxColorPickerEntireOutput);
            this.groupOptionsRasterColors.Controls.Add(this.lblEntireActivityOutputColor);
            this.groupOptionsRasterColors.Controls.Add(this.comboBoxColorPickerEntireLayer1);
            this.groupOptionsRasterColors.Controls.Add(this.lblEntireActivityLayer1Color);
            this.groupOptionsRasterColors.Controls.Add(this.comboBoxColorPickerEntireInput);
            this.groupOptionsRasterColors.Controls.Add(this.lblEntireActivityInputColor);
            this.groupOptionsRasterColors.Controls.Add(this.comboBoxColorPickerStdBars);
            this.groupOptionsRasterColors.Controls.Add(this.lblStandardPloterBar);
            this.groupOptionsRasterColors.Location = new System.Drawing.Point(9, 15);
            this.groupOptionsRasterColors.Name = "groupOptionsRasterColors";
            this.groupOptionsRasterColors.Size = new System.Drawing.Size(503, 146);
            this.groupOptionsRasterColors.TabIndex = 4;
            this.groupOptionsRasterColors.TabStop = false;
            this.groupOptionsRasterColors.Text = "Colours of Spike Raster Plots:";
            // 
            // comboBoxColorPickerEntireOutput
            // 
            this.comboBoxColorPickerEntireOutput.FormattingEnabled = true;
            this.comboBoxColorPickerEntireOutput.Location = new System.Drawing.Point(396, 115);
            this.comboBoxColorPickerEntireOutput.Name = "comboBoxColorPickerEntireOutput";
            this.comboBoxColorPickerEntireOutput.Size = new System.Drawing.Size(92, 21);
            this.comboBoxColorPickerEntireOutput.TabIndex = 7;
            this.comboBoxColorPickerEntireOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxColorPickerEntireOutput_MouseDown);
            // 
            // lblEntireActivityOutputColor
            // 
            this.lblEntireActivityOutputColor.AutoSize = true;
            this.lblEntireActivityOutputColor.Location = new System.Drawing.Point(108, 118);
            this.lblEntireActivityOutputColor.Name = "lblEntireActivityOutputColor";
            this.lblEntireActivityOutputColor.Size = new System.Drawing.Size(272, 13);
            this.lblEntireActivityOutputColor.TabIndex = 6;
            this.lblEntireActivityOutputColor.Text = "Bars Colour for Output layer in Entire Activity Raster Plot:";
            // 
            // comboBoxColorPickerEntireLayer1
            // 
            this.comboBoxColorPickerEntireLayer1.FormattingEnabled = true;
            this.comboBoxColorPickerEntireLayer1.Location = new System.Drawing.Point(396, 88);
            this.comboBoxColorPickerEntireLayer1.Name = "comboBoxColorPickerEntireLayer1";
            this.comboBoxColorPickerEntireLayer1.Size = new System.Drawing.Size(92, 21);
            this.comboBoxColorPickerEntireLayer1.TabIndex = 5;
            this.comboBoxColorPickerEntireLayer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxColorPickerEntireLayer1_MouseDown);
            // 
            // lblEntireActivityLayer1Color
            // 
            this.lblEntireActivityLayer1Color.AutoSize = true;
            this.lblEntireActivityLayer1Color.Location = new System.Drawing.Point(108, 91);
            this.lblEntireActivityLayer1Color.Name = "lblEntireActivityLayer1Color";
            this.lblEntireActivityLayer1Color.Size = new System.Drawing.Size(250, 13);
            this.lblEntireActivityLayer1Color.TabIndex = 4;
            this.lblEntireActivityLayer1Color.Text = "Bars Colour for Layer 1 in Entire Activity Raster Plot:";
            // 
            // comboBoxColorPickerEntireInput
            // 
            this.comboBoxColorPickerEntireInput.FormattingEnabled = true;
            this.comboBoxColorPickerEntireInput.Location = new System.Drawing.Point(396, 61);
            this.comboBoxColorPickerEntireInput.Name = "comboBoxColorPickerEntireInput";
            this.comboBoxColorPickerEntireInput.Size = new System.Drawing.Size(92, 21);
            this.comboBoxColorPickerEntireInput.TabIndex = 3;
            this.comboBoxColorPickerEntireInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxColorPickerEntireInput_MouseDown);
            // 
            // lblEntireActivityInputColor
            // 
            this.lblEntireActivityInputColor.AutoSize = true;
            this.lblEntireActivityInputColor.Location = new System.Drawing.Point(108, 64);
            this.lblEntireActivityInputColor.Name = "lblEntireActivityInputColor";
            this.lblEntireActivityInputColor.Size = new System.Drawing.Size(264, 13);
            this.lblEntireActivityInputColor.TabIndex = 2;
            this.lblEntireActivityInputColor.Text = "Bars Colour for Input layer in Entire Activity Raster Plot:";
            // 
            // comboBoxColorPickerStdBars
            // 
            this.comboBoxColorPickerStdBars.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxColorPickerStdBars.FormattingEnabled = true;
            this.comboBoxColorPickerStdBars.Location = new System.Drawing.Point(396, 22);
            this.comboBoxColorPickerStdBars.Name = "comboBoxColorPickerStdBars";
            this.comboBoxColorPickerStdBars.Size = new System.Drawing.Size(92, 21);
            this.comboBoxColorPickerStdBars.TabIndex = 1;
            this.comboBoxColorPickerStdBars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxColorPickerStdBars_MouseDown);
            // 
            // lblStandardPloterBar
            // 
            this.lblStandardPloterBar.AutoSize = true;
            this.lblStandardPloterBar.Location = new System.Drawing.Point(108, 26);
            this.lblStandardPloterBar.Name = "lblStandardPloterBar";
            this.lblStandardPloterBar.Size = new System.Drawing.Size(250, 13);
            this.lblStandardPloterBar.TabIndex = 0;
            this.lblStandardPloterBar.Text = "Bars Colour for Input, Layer1, Output Plot Windows:";
            // 
            // tabEnvironmentPaths
            // 
            this.tabEnvironmentPaths.Controls.Add(this.btnHardwareSnn);
            this.tabEnvironmentPaths.Controls.Add(this.textBoxOptionSnnHardwareSrcPath);
            this.tabEnvironmentPaths.Controls.Add(this.lblHardwareSnnPath);
            this.tabEnvironmentPaths.Controls.Add(this.btnHardwareAnn);
            this.tabEnvironmentPaths.Controls.Add(this.textBoxOptionAnnHardwareSrcPath);
            this.tabEnvironmentPaths.Controls.Add(this.lblHardwareAnnPath);
            this.tabEnvironmentPaths.Controls.Add(this.btnStimuliHardwarePath);
            this.tabEnvironmentPaths.Controls.Add(this.textBoxOptionStimuliHardwarePath);
            this.tabEnvironmentPaths.Controls.Add(this.lblOptionHardwarePath);
            this.tabEnvironmentPaths.Controls.Add(this.btnStimuliOutputPath);
            this.tabEnvironmentPaths.Controls.Add(this.textBoxOptionStimuliOutputPath);
            this.tabEnvironmentPaths.Controls.Add(this.lblOptionOutputPath);
            this.tabEnvironmentPaths.Controls.Add(this.btnStimuliSNNPath);
            this.tabEnvironmentPaths.Controls.Add(this.textBoxOptionStimuliSNNPath);
            this.tabEnvironmentPaths.Controls.Add(this.lblOptionSNNetworksPath);
            this.tabEnvironmentPaths.Controls.Add(this.btnStimuliSrcPath);
            this.tabEnvironmentPaths.Controls.Add(this.textBoxOptionStimuliSrcPath);
            this.tabEnvironmentPaths.Controls.Add(this.lblOptionsPathStimuliSrc);
            this.tabEnvironmentPaths.Controls.Add(this.label5);
            this.tabEnvironmentPaths.Location = new System.Drawing.Point(4, 22);
            this.tabEnvironmentPaths.Name = "tabEnvironmentPaths";
            this.tabEnvironmentPaths.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnvironmentPaths.Size = new System.Drawing.Size(527, 306);
            this.tabEnvironmentPaths.TabIndex = 1;
            this.tabEnvironmentPaths.Text = "tabPage2";
            this.tabEnvironmentPaths.UseVisualStyleBackColor = true;
            // 
            // btnHardwareSnn
            // 
            this.btnHardwareSnn.Location = new System.Drawing.Point(437, 199);
            this.btnHardwareSnn.Name = "btnHardwareSnn";
            this.btnHardwareSnn.Size = new System.Drawing.Size(75, 23);
            this.btnHardwareSnn.TabIndex = 22;
            this.btnHardwareSnn.Text = "Browse...";
            this.btnHardwareSnn.UseVisualStyleBackColor = true;
            this.btnHardwareSnn.Click += new System.EventHandler(this.btnHardwareSnn_Click);
            // 
            // textBoxOptionSnnHardwareSrcPath
            // 
            this.textBoxOptionSnnHardwareSrcPath.Location = new System.Drawing.Point(148, 202);
            this.textBoxOptionSnnHardwareSrcPath.Name = "textBoxOptionSnnHardwareSrcPath";
            this.textBoxOptionSnnHardwareSrcPath.Size = new System.Drawing.Size(271, 20);
            this.textBoxOptionSnnHardwareSrcPath.TabIndex = 21;
            // 
            // lblHardwareSnnPath
            // 
            this.lblHardwareSnnPath.AutoSize = true;
            this.lblHardwareSnnPath.Location = new System.Drawing.Point(10, 205);
            this.lblHardwareSnnPath.Name = "lblHardwareSnnPath";
            this.lblHardwareSnnPath.Size = new System.Drawing.Size(136, 13);
            this.lblHardwareSnnPath.TabIndex = 20;
            this.lblHardwareSnnPath.Text = "VHDL source files for SNN:";
            // 
            // btnHardwareAnn
            // 
            this.btnHardwareAnn.Location = new System.Drawing.Point(437, 163);
            this.btnHardwareAnn.Name = "btnHardwareAnn";
            this.btnHardwareAnn.Size = new System.Drawing.Size(75, 23);
            this.btnHardwareAnn.TabIndex = 19;
            this.btnHardwareAnn.Text = "Browse...";
            this.btnHardwareAnn.UseVisualStyleBackColor = true;
            this.btnHardwareAnn.Click += new System.EventHandler(this.btnHardwareAnn_Click);
            // 
            // textBoxOptionAnnHardwareSrcPath
            // 
            this.textBoxOptionAnnHardwareSrcPath.Location = new System.Drawing.Point(148, 166);
            this.textBoxOptionAnnHardwareSrcPath.Name = "textBoxOptionAnnHardwareSrcPath";
            this.textBoxOptionAnnHardwareSrcPath.Size = new System.Drawing.Size(271, 20);
            this.textBoxOptionAnnHardwareSrcPath.TabIndex = 18;
            // 
            // lblHardwareAnnPath
            // 
            this.lblHardwareAnnPath.AutoSize = true;
            this.lblHardwareAnnPath.Location = new System.Drawing.Point(10, 169);
            this.lblHardwareAnnPath.Name = "lblHardwareAnnPath";
            this.lblHardwareAnnPath.Size = new System.Drawing.Size(136, 13);
            this.lblHardwareAnnPath.TabIndex = 17;
            this.lblHardwareAnnPath.Text = "VHDL source files for ANN:";
            // 
            // btnStimuliHardwarePath
            // 
            this.btnStimuliHardwarePath.Location = new System.Drawing.Point(437, 128);
            this.btnStimuliHardwarePath.Name = "btnStimuliHardwarePath";
            this.btnStimuliHardwarePath.Size = new System.Drawing.Size(75, 23);
            this.btnStimuliHardwarePath.TabIndex = 16;
            this.btnStimuliHardwarePath.Text = "Browse...";
            this.btnStimuliHardwarePath.UseVisualStyleBackColor = true;
            this.btnStimuliHardwarePath.Click += new System.EventHandler(this.btnStimuliHardwarePath_Click);
            // 
            // textBoxOptionStimuliHardwarePath
            // 
            this.textBoxOptionStimuliHardwarePath.Location = new System.Drawing.Point(148, 131);
            this.textBoxOptionStimuliHardwarePath.Name = "textBoxOptionStimuliHardwarePath";
            this.textBoxOptionStimuliHardwarePath.Size = new System.Drawing.Size(271, 20);
            this.textBoxOptionStimuliHardwarePath.TabIndex = 15;
            // 
            // lblOptionHardwarePath
            // 
            this.lblOptionHardwarePath.AutoSize = true;
            this.lblOptionHardwarePath.Location = new System.Drawing.Point(10, 134);
            this.lblOptionHardwarePath.Name = "lblOptionHardwarePath";
            this.lblOptionHardwarePath.Size = new System.Drawing.Size(136, 13);
            this.lblOptionHardwarePath.TabIndex = 14;
            this.lblOptionHardwarePath.Text = "VHDL Code Files Directory:";
            // 
            // btnStimuliOutputPath
            // 
            this.btnStimuliOutputPath.Location = new System.Drawing.Point(437, 95);
            this.btnStimuliOutputPath.Name = "btnStimuliOutputPath";
            this.btnStimuliOutputPath.Size = new System.Drawing.Size(75, 23);
            this.btnStimuliOutputPath.TabIndex = 13;
            this.btnStimuliOutputPath.Text = "Browse...";
            this.btnStimuliOutputPath.UseVisualStyleBackColor = true;
            this.btnStimuliOutputPath.Click += new System.EventHandler(this.btnStimuliOutputPath_Click);
            // 
            // textBoxOptionStimuliOutputPath
            // 
            this.textBoxOptionStimuliOutputPath.Location = new System.Drawing.Point(148, 98);
            this.textBoxOptionStimuliOutputPath.Name = "textBoxOptionStimuliOutputPath";
            this.textBoxOptionStimuliOutputPath.Size = new System.Drawing.Size(271, 20);
            this.textBoxOptionStimuliOutputPath.TabIndex = 12;
            // 
            // lblOptionOutputPath
            // 
            this.lblOptionOutputPath.AutoSize = true;
            this.lblOptionOutputPath.Location = new System.Drawing.Point(10, 101);
            this.lblOptionOutputPath.Name = "lblOptionOutputPath";
            this.lblOptionOutputPath.Size = new System.Drawing.Size(111, 13);
            this.lblOptionOutputPath.TabIndex = 11;
            this.lblOptionOutputPath.Text = "Output Files Directory:";
            // 
            // btnStimuliSNNPath
            // 
            this.btnStimuliSNNPath.Location = new System.Drawing.Point(437, 35);
            this.btnStimuliSNNPath.Name = "btnStimuliSNNPath";
            this.btnStimuliSNNPath.Size = new System.Drawing.Size(75, 23);
            this.btnStimuliSNNPath.TabIndex = 7;
            this.btnStimuliSNNPath.Text = "Browse...";
            this.btnStimuliSNNPath.UseVisualStyleBackColor = true;
            this.btnStimuliSNNPath.Click += new System.EventHandler(this.btnStimuliSNNPath_Click);
            // 
            // textBoxOptionStimuliSNNPath
            // 
            this.textBoxOptionStimuliSNNPath.Location = new System.Drawing.Point(148, 38);
            this.textBoxOptionStimuliSNNPath.Name = "textBoxOptionStimuliSNNPath";
            this.textBoxOptionStimuliSNNPath.Size = new System.Drawing.Size(271, 20);
            this.textBoxOptionStimuliSNNPath.TabIndex = 6;
            // 
            // lblOptionSNNetworksPath
            // 
            this.lblOptionSNNetworksPath.AutoSize = true;
            this.lblOptionSNNetworksPath.Location = new System.Drawing.Point(10, 41);
            this.lblOptionSNNetworksPath.Name = "lblOptionSNNetworksPath";
            this.lblOptionSNNetworksPath.Size = new System.Drawing.Size(103, 13);
            this.lblOptionSNNetworksPath.TabIndex = 5;
            this.lblOptionSNNetworksPath.Text = "Structures Directory:";
            // 
            // btnStimuliSrcPath
            // 
            this.btnStimuliSrcPath.Location = new System.Drawing.Point(437, 64);
            this.btnStimuliSrcPath.Name = "btnStimuliSrcPath";
            this.btnStimuliSrcPath.Size = new System.Drawing.Size(75, 23);
            this.btnStimuliSrcPath.TabIndex = 4;
            this.btnStimuliSrcPath.Text = "Browse...";
            this.btnStimuliSrcPath.UseVisualStyleBackColor = true;
            this.btnStimuliSrcPath.Click += new System.EventHandler(this.btnStimuliSrcPath_Click);
            // 
            // textBoxOptionStimuliSrcPath
            // 
            this.textBoxOptionStimuliSrcPath.Location = new System.Drawing.Point(148, 67);
            this.textBoxOptionStimuliSrcPath.Name = "textBoxOptionStimuliSrcPath";
            this.textBoxOptionStimuliSrcPath.Size = new System.Drawing.Size(271, 20);
            this.textBoxOptionStimuliSrcPath.TabIndex = 3;
            // 
            // lblOptionsPathStimuliSrc
            // 
            this.lblOptionsPathStimuliSrc.AutoSize = true;
            this.lblOptionsPathStimuliSrc.Location = new System.Drawing.Point(10, 70);
            this.lblOptionsPathStimuliSrc.Name = "lblOptionsPathStimuliSrc";
            this.lblOptionsPathStimuliSrc.Size = new System.Drawing.Size(122, 13);
            this.lblOptionsPathStimuliSrc.TabIndex = 2;
            this.lblOptionsPathStimuliSrc.Text = "Stimuli Source Directory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Application\'s Paths:";
            // 
            // tabEnvironmentOthers
            // 
            this.tabEnvironmentOthers.Controls.Add(this.btnRestoreDefault);
            this.tabEnvironmentOthers.Controls.Add(this.lblClearProperties);
            this.tabEnvironmentOthers.Controls.Add(this.btnClearRecent);
            this.tabEnvironmentOthers.Controls.Add(this.lblClearRecent);
            this.tabEnvironmentOthers.Controls.Add(this.label6);
            this.tabEnvironmentOthers.Location = new System.Drawing.Point(4, 22);
            this.tabEnvironmentOthers.Name = "tabEnvironmentOthers";
            this.tabEnvironmentOthers.Size = new System.Drawing.Size(527, 306);
            this.tabEnvironmentOthers.TabIndex = 2;
            this.tabEnvironmentOthers.Text = "tabPage3";
            this.tabEnvironmentOthers.UseVisualStyleBackColor = true;
            // 
            // btnRestoreDefault
            // 
            this.btnRestoreDefault.Location = new System.Drawing.Point(161, 72);
            this.btnRestoreDefault.Name = "btnRestoreDefault";
            this.btnRestoreDefault.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreDefault.TabIndex = 6;
            this.btnRestoreDefault.Text = "Restore";
            this.btnRestoreDefault.UseVisualStyleBackColor = true;
            this.btnRestoreDefault.Click += new System.EventHandler(this.btnRestoreDefault_Click);
            // 
            // lblClearProperties
            // 
            this.lblClearProperties.AutoSize = true;
            this.lblClearProperties.Location = new System.Drawing.Point(10, 72);
            this.lblClearProperties.Name = "lblClearProperties";
            this.lblClearProperties.Size = new System.Drawing.Size(131, 13);
            this.lblClearProperties.TabIndex = 5;
            this.lblClearProperties.Text = "Restore Default Properties";
            // 
            // btnClearRecent
            // 
            this.btnClearRecent.Location = new System.Drawing.Point(161, 29);
            this.btnClearRecent.Name = "btnClearRecent";
            this.btnClearRecent.Size = new System.Drawing.Size(75, 23);
            this.btnClearRecent.TabIndex = 4;
            this.btnClearRecent.Text = "Clear";
            this.btnClearRecent.UseVisualStyleBackColor = true;
            this.btnClearRecent.Click += new System.EventHandler(this.btnClearRecent_Click);
            // 
            // lblClearRecent
            // 
            this.lblClearRecent.AutoSize = true;
            this.lblClearRecent.Location = new System.Drawing.Point(10, 34);
            this.lblClearRecent.Name = "lblClearRecent";
            this.lblClearRecent.Size = new System.Drawing.Size(145, 13);
            this.lblClearRecent.TabIndex = 3;
            this.lblClearRecent.Text = "Clear Recent Projects History";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Other Environment Options:";
            // 
            // tabSimulation
            // 
            this.tabSimulation.Controls.Add(this.label7);
            this.tabSimulation.Location = new System.Drawing.Point(4, 22);
            this.tabSimulation.Name = "tabSimulation";
            this.tabSimulation.Size = new System.Drawing.Size(527, 306);
            this.tabSimulation.TabIndex = 3;
            this.tabSimulation.Text = "tabPage4";
            this.tabSimulation.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Simulation Options:";
            // 
            // tabSimulationBehaviour
            // 
            this.tabSimulationBehaviour.Controls.Add(this.label8);
            this.tabSimulationBehaviour.Controls.Add(this.maskedBoxClearHistoryTime);
            this.tabSimulationBehaviour.Controls.Add(this.label9);
            this.tabSimulationBehaviour.Controls.Add(this.label10);
            this.tabSimulationBehaviour.Location = new System.Drawing.Point(4, 22);
            this.tabSimulationBehaviour.Name = "tabSimulationBehaviour";
            this.tabSimulationBehaviour.Size = new System.Drawing.Size(527, 306);
            this.tabSimulationBehaviour.TabIndex = 4;
            this.tabSimulationBehaviour.Text = "tabPage5";
            this.tabSimulationBehaviour.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "milliseconds";
            // 
            // maskedBoxClearHistoryTime
            // 
            this.maskedBoxClearHistoryTime.Location = new System.Drawing.Point(127, 23);
            this.maskedBoxClearHistoryTime.Mask = "0000";
            this.maskedBoxClearHistoryTime.Name = "maskedBoxClearHistoryTime";
            this.maskedBoxClearHistoryTime.PromptChar = ' ';
            this.maskedBoxClearHistoryTime.Size = new System.Drawing.Size(63, 20);
            this.maskedBoxClearHistoryTime.TabIndex = 3;
            this.maskedBoxClearHistoryTime.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Clear History Every:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Neuron Behaviour:";
            // 
            // tabSimulationGraphs
            // 
            this.tabSimulationGraphs.Controls.Add(this.groupBox1);
            this.tabSimulationGraphs.Controls.Add(this.label11);
            this.tabSimulationGraphs.Location = new System.Drawing.Point(4, 22);
            this.tabSimulationGraphs.Name = "tabSimulationGraphs";
            this.tabSimulationGraphs.Size = new System.Drawing.Size(527, 306);
            this.tabSimulationGraphs.TabIndex = 5;
            this.tabSimulationGraphs.Text = "tabPage6";
            this.tabSimulationGraphs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMoveGraph);
            this.groupBox1.Controls.Add(this.maskedBoxMoveMembranePotential);
            this.groupBox1.Controls.Add(this.checkBoxMoveMembranePotential);
            this.groupBox1.Location = new System.Drawing.Point(5, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membrane Potential Graph";
            // 
            // lblMoveGraph
            // 
            this.lblMoveGraph.AutoSize = true;
            this.lblMoveGraph.Location = new System.Drawing.Point(85, 45);
            this.lblMoveGraph.Name = "lblMoveGraph";
            this.lblMoveGraph.Size = new System.Drawing.Size(138, 13);
            this.lblMoveGraph.TabIndex = 4;
            this.lblMoveGraph.Text = "milliseconds of X axis length";
            // 
            // maskedBoxMoveMembranePotential
            // 
            this.maskedBoxMoveMembranePotential.Location = new System.Drawing.Point(26, 42);
            this.maskedBoxMoveMembranePotential.Mask = "00000";
            this.maskedBoxMoveMembranePotential.Name = "maskedBoxMoveMembranePotential";
            this.maskedBoxMoveMembranePotential.PromptChar = ' ';
            this.maskedBoxMoveMembranePotential.Size = new System.Drawing.Size(53, 20);
            this.maskedBoxMoveMembranePotential.TabIndex = 1;
            this.maskedBoxMoveMembranePotential.Text = "0";
            this.maskedBoxMoveMembranePotential.ValidatingType = typeof(int);
            // 
            // checkBoxMoveMembranePotential
            // 
            this.checkBoxMoveMembranePotential.AutoSize = true;
            this.checkBoxMoveMembranePotential.Location = new System.Drawing.Point(6, 19);
            this.checkBoxMoveMembranePotential.Name = "checkBoxMoveMembranePotential";
            this.checkBoxMoveMembranePotential.Size = new System.Drawing.Size(178, 17);
            this.checkBoxMoveMembranePotential.TabIndex = 0;
            this.checkBoxMoveMembranePotential.Text = "Move membrane potential graph";
            this.checkBoxMoveMembranePotential.UseVisualStyleBackColor = true;
            this.checkBoxMoveMembranePotential.CheckedChanged += new System.EventHandler(this.checkBoxMoveMembranePotential_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Graphs and Plotting Options:";
            // 
            // tabVHDL
            // 
            this.tabVHDL.Controls.Add(this.richTextHeader);
            this.tabVHDL.Controls.Add(this.lblVHDLtitle);
            this.tabVHDL.Controls.Add(this.checkBoxHeaderAdd);
            this.tabVHDL.Controls.Add(this.checkBoxGenerateTestBench);
            this.tabVHDL.Location = new System.Drawing.Point(4, 22);
            this.tabVHDL.Name = "tabVHDL";
            this.tabVHDL.Size = new System.Drawing.Size(527, 306);
            this.tabVHDL.TabIndex = 7;
            this.tabVHDL.Text = "tabPage8";
            this.tabVHDL.UseVisualStyleBackColor = true;
            // 
            // richTextHeader
            // 
            this.richTextHeader.Location = new System.Drawing.Point(50, 107);
            this.richTextHeader.Name = "richTextHeader";
            this.richTextHeader.Size = new System.Drawing.Size(468, 196);
            this.richTextHeader.TabIndex = 3;
            this.richTextHeader.Text = "";
            // 
            // lblVHDLtitle
            // 
            this.lblVHDLtitle.AutoSize = true;
            this.lblVHDLtitle.Location = new System.Drawing.Point(10, 15);
            this.lblVHDLtitle.Name = "lblVHDLtitle";
            this.lblVHDLtitle.Size = new System.Drawing.Size(156, 13);
            this.lblVHDLtitle.TabIndex = 2;
            this.lblVHDLtitle.Text = "VHDL Code Generator Options:";
            // 
            // checkBoxHeaderAdd
            // 
            this.checkBoxHeaderAdd.AutoSize = true;
            this.checkBoxHeaderAdd.Location = new System.Drawing.Point(31, 84);
            this.checkBoxHeaderAdd.Name = "checkBoxHeaderAdd";
            this.checkBoxHeaderAdd.Size = new System.Drawing.Size(173, 17);
            this.checkBoxHeaderAdd.TabIndex = 1;
            this.checkBoxHeaderAdd.Text = "Add Header to Every VHDL file";
            this.checkBoxHeaderAdd.UseVisualStyleBackColor = true;
            this.checkBoxHeaderAdd.CheckedChanged += new System.EventHandler(this.checkBoxHeaderAdd_CheckedChanged);
            // 
            // checkBoxGenerateTestBench
            // 
            this.checkBoxGenerateTestBench.AutoSize = true;
            this.checkBoxGenerateTestBench.Location = new System.Drawing.Point(31, 42);
            this.checkBoxGenerateTestBench.Name = "checkBoxGenerateTestBench";
            this.checkBoxGenerateTestBench.Size = new System.Drawing.Size(162, 17);
            this.checkBoxGenerateTestBench.TabIndex = 0;
            this.checkBoxGenerateTestBench.Text = "Generate Sample Testbench";
            this.checkBoxGenerateTestBench.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBoxOtherHDLoptions);
            this.tabPage9.Controls.Add(this.groupBoxCodingOptions);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(527, 306);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBoxOtherHDLoptions
            // 
            this.groupBoxOtherHDLoptions.Controls.Add(this.maskedTextRefractoryDuration);
            this.groupBoxOtherHDLoptions.Controls.Add(this.label12);
            this.groupBoxOtherHDLoptions.Controls.Add(this.maskedTextPSPstep);
            this.groupBoxOtherHDLoptions.Controls.Add(this.lblPSPstep);
            this.groupBoxOtherHDLoptions.Controls.Add(this.maskedTextPSPduration);
            this.groupBoxOtherHDLoptions.Controls.Add(this.lblPSPduration);
            this.groupBoxOtherHDLoptions.Controls.Add(this.lblFunctionCoding);
            this.groupBoxOtherHDLoptions.Controls.Add(this.radioRealPSPcode);
            this.groupBoxOtherHDLoptions.Controls.Add(this.radioIdealPSPcode);
            this.groupBoxOtherHDLoptions.Controls.Add(this.pictureBox3);
            this.groupBoxOtherHDLoptions.Controls.Add(this.pictureBox2);
            this.groupBoxOtherHDLoptions.Controls.Add(this.maskedTextFreqDiv);
            this.groupBoxOtherHDLoptions.Controls.Add(this.lblFreqDivider);
            this.groupBoxOtherHDLoptions.Location = new System.Drawing.Point(13, 163);
            this.groupBoxOtherHDLoptions.Name = "groupBoxOtherHDLoptions";
            this.groupBoxOtherHDLoptions.Size = new System.Drawing.Size(499, 131);
            this.groupBoxOtherHDLoptions.TabIndex = 9;
            this.groupBoxOtherHDLoptions.TabStop = false;
            this.groupBoxOtherHDLoptions.Text = "Other Generator Options";
            // 
            // maskedTextRefractoryDuration
            // 
            this.maskedTextRefractoryDuration.Location = new System.Drawing.Point(301, 27);
            this.maskedTextRefractoryDuration.Mask = "00";
            this.maskedTextRefractoryDuration.Name = "maskedTextRefractoryDuration";
            this.maskedTextRefractoryDuration.PromptChar = ' ';
            this.maskedTextRefractoryDuration.Size = new System.Drawing.Size(47, 20);
            this.maskedTextRefractoryDuration.TabIndex = 20;
            this.maskedTextRefractoryDuration.Text = "60";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Refractory(ms)";
            // 
            // maskedTextPSPstep
            // 
            this.maskedTextPSPstep.Location = new System.Drawing.Point(123, 104);
            this.maskedTextPSPstep.Mask = "0.0";
            this.maskedTextPSPstep.Name = "maskedTextPSPstep";
            this.maskedTextPSPstep.PromptChar = ' ';
            this.maskedTextPSPstep.Size = new System.Drawing.Size(47, 20);
            this.maskedTextPSPstep.TabIndex = 18;
            this.maskedTextPSPstep.Text = "10";
            // 
            // lblPSPstep
            // 
            this.lblPSPstep.AutoSize = true;
            this.lblPSPstep.Location = new System.Drawing.Point(18, 107);
            this.lblPSPstep.Name = "lblPSPstep";
            this.lblPSPstep.Size = new System.Drawing.Size(54, 13);
            this.lblPSPstep.TabIndex = 17;
            this.lblPSPstep.Text = "PSP step:";
            // 
            // maskedTextPSPduration
            // 
            this.maskedTextPSPduration.Location = new System.Drawing.Point(123, 76);
            this.maskedTextPSPduration.Mask = "00";
            this.maskedTextPSPduration.Name = "maskedTextPSPduration";
            this.maskedTextPSPduration.PromptChar = ' ';
            this.maskedTextPSPduration.Size = new System.Drawing.Size(47, 20);
            this.maskedTextPSPduration.TabIndex = 16;
            this.maskedTextPSPduration.Text = "25";
            // 
            // lblPSPduration
            // 
            this.lblPSPduration.AutoSize = true;
            this.lblPSPduration.Location = new System.Drawing.Point(18, 79);
            this.lblPSPduration.Name = "lblPSPduration";
            this.lblPSPduration.Size = new System.Drawing.Size(88, 13);
            this.lblPSPduration.TabIndex = 15;
            this.lblPSPduration.Text = "PSP duration(ms)";
            // 
            // lblFunctionCoding
            // 
            this.lblFunctionCoding.AutoSize = true;
            this.lblFunctionCoding.Location = new System.Drawing.Point(10, 58);
            this.lblFunctionCoding.Name = "lblFunctionCoding";
            this.lblFunctionCoding.Size = new System.Drawing.Size(111, 13);
            this.lblFunctionCoding.TabIndex = 14;
            this.lblFunctionCoding.Text = "PSP Function Coding:";
            // 
            // radioRealPSPcode
            // 
            this.radioRealPSPcode.AutoSize = true;
            this.radioRealPSPcode.Location = new System.Drawing.Point(258, 88);
            this.radioRealPSPcode.Name = "radioRealPSPcode";
            this.radioRealPSPcode.Size = new System.Drawing.Size(14, 13);
            this.radioRealPSPcode.TabIndex = 13;
            this.radioRealPSPcode.UseVisualStyleBackColor = true;
            this.radioRealPSPcode.CheckedChanged += new System.EventHandler(this.radioRealPSPcode_CheckedChanged);
            // 
            // radioIdealPSPcode
            // 
            this.radioIdealPSPcode.AutoSize = true;
            this.radioIdealPSPcode.Checked = true;
            this.radioIdealPSPcode.Location = new System.Drawing.Point(186, 88);
            this.radioIdealPSPcode.Name = "radioIdealPSPcode";
            this.radioIdealPSPcode.Size = new System.Drawing.Size(14, 13);
            this.radioIdealPSPcode.TabIndex = 12;
            this.radioIdealPSPcode.TabStop = true;
            this.radioIdealPSPcode.UseVisualStyleBackColor = true;
            this.radioIdealPSPcode.CheckedChanged += new System.EventHandler(this.radioIdealPSPcode_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(278, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(206, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // maskedTextFreqDiv
            // 
            this.maskedTextFreqDiv.Location = new System.Drawing.Point(112, 23);
            this.maskedTextFreqDiv.Mask = "0000000";
            this.maskedTextFreqDiv.Name = "maskedTextFreqDiv";
            this.maskedTextFreqDiv.PromptChar = ' ';
            this.maskedTextFreqDiv.Size = new System.Drawing.Size(53, 20);
            this.maskedTextFreqDiv.TabIndex = 9;
            this.maskedTextFreqDiv.Text = "100000";
            // 
            // lblFreqDivider
            // 
            this.lblFreqDivider.AutoSize = true;
            this.lblFreqDivider.Location = new System.Drawing.Point(10, 26);
            this.lblFreqDivider.Name = "lblFreqDivider";
            this.lblFreqDivider.Size = new System.Drawing.Size(96, 13);
            this.lblFreqDivider.TabIndex = 8;
            this.lblFreqDivider.Text = "Frequency Divider:";
            // 
            // groupBoxCodingOptions
            // 
            this.groupBoxCodingOptions.Controls.Add(this.lblHDLCodingRange);
            this.groupBoxCodingOptions.Controls.Add(this.maskedBoxWordLength);
            this.groupBoxCodingOptions.Controls.Add(this.lblHDLcodingBitsNumber);
            this.groupBoxCodingOptions.Controls.Add(this.lblCodingWordLength);
            this.groupBoxCodingOptions.Controls.Add(this.maskedBoxCodeBits);
            this.groupBoxCodingOptions.Controls.Add(this.maskedBoxCodeRangeTo);
            this.groupBoxCodingOptions.Controls.Add(this.maskedBoxCodeRangeFrom);
            this.groupBoxCodingOptions.Controls.Add(this.label4);
            this.groupBoxCodingOptions.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCodingOptions.Name = "groupBoxCodingOptions";
            this.groupBoxCodingOptions.Size = new System.Drawing.Size(499, 144);
            this.groupBoxCodingOptions.TabIndex = 8;
            this.groupBoxCodingOptions.TabStop = false;
            this.groupBoxCodingOptions.Text = "Encoding Options:";
            // 
            // lblHDLCodingRange
            // 
            this.lblHDLCodingRange.AutoSize = true;
            this.lblHDLCodingRange.Location = new System.Drawing.Point(6, 60);
            this.lblHDLCodingRange.Name = "lblHDLCodingRange";
            this.lblHDLCodingRange.Size = new System.Drawing.Size(90, 13);
            this.lblHDLCodingRange.TabIndex = 2;
            this.lblHDLCodingRange.Text = "Encoding Range:";
            // 
            // maskedBoxWordLength
            // 
            this.maskedBoxWordLength.Location = new System.Drawing.Point(90, 96);
            this.maskedBoxWordLength.Mask = "00";
            this.maskedBoxWordLength.Name = "maskedBoxWordLength";
            this.maskedBoxWordLength.PromptChar = ' ';
            this.maskedBoxWordLength.Size = new System.Drawing.Size(53, 20);
            this.maskedBoxWordLength.TabIndex = 7;
            this.maskedBoxWordLength.Text = "44";
            // 
            // lblHDLcodingBitsNumber
            // 
            this.lblHDLcodingBitsNumber.AutoSize = true;
            this.lblHDLcodingBitsNumber.Location = new System.Drawing.Point(6, 26);
            this.lblHDLcodingBitsNumber.Name = "lblHDLcodingBitsNumber";
            this.lblHDLcodingBitsNumber.Size = new System.Drawing.Size(76, 13);
            this.lblHDLcodingBitsNumber.TabIndex = 0;
            this.lblHDLcodingBitsNumber.Text = "Coding Power:";
            // 
            // lblCodingWordLength
            // 
            this.lblCodingWordLength.AutoSize = true;
            this.lblCodingWordLength.Location = new System.Drawing.Point(6, 99);
            this.lblCodingWordLength.Name = "lblCodingWordLength";
            this.lblCodingWordLength.Size = new System.Drawing.Size(72, 13);
            this.lblCodingWordLength.TabIndex = 6;
            this.lblCodingWordLength.Text = "Word Length:";
            // 
            // maskedBoxCodeBits
            // 
            this.maskedBoxCodeBits.Location = new System.Drawing.Point(90, 26);
            this.maskedBoxCodeBits.Mask = "00";
            this.maskedBoxCodeBits.Name = "maskedBoxCodeBits";
            this.maskedBoxCodeBits.PromptChar = ' ';
            this.maskedBoxCodeBits.Size = new System.Drawing.Size(53, 20);
            this.maskedBoxCodeBits.TabIndex = 1;
            this.maskedBoxCodeBits.Text = "20";
            // 
            // maskedBoxCodeRangeTo
            // 
            this.maskedBoxCodeRangeTo.Location = new System.Drawing.Point(145, 57);
            this.maskedBoxCodeRangeTo.Mask = "00";
            this.maskedBoxCodeRangeTo.Name = "maskedBoxCodeRangeTo";
            this.maskedBoxCodeRangeTo.PromptChar = ' ';
            this.maskedBoxCodeRangeTo.Size = new System.Drawing.Size(30, 20);
            this.maskedBoxCodeRangeTo.TabIndex = 5;
            this.maskedBoxCodeRangeTo.Text = "3";
            // 
            // maskedBoxCodeRangeFrom
            // 
            this.maskedBoxCodeRangeFrom.Location = new System.Drawing.Point(103, 57);
            this.maskedBoxCodeRangeFrom.Mask = "#00";
            this.maskedBoxCodeRangeFrom.Name = "maskedBoxCodeRangeFrom";
            this.maskedBoxCodeRangeFrom.PromptChar = ' ';
            this.maskedBoxCodeRangeFrom.Size = new System.Drawing.Size(30, 20);
            this.maskedBoxCodeRangeFrom.TabIndex = 3;
            this.maskedBoxCodeRangeFrom.Text = "-3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "-";
            // 
            // btnOptionsOK
            // 
            this.btnOptionsOK.Location = new System.Drawing.Point(562, 356);
            this.btnOptionsOK.Name = "btnOptionsOK";
            this.btnOptionsOK.Size = new System.Drawing.Size(75, 23);
            this.btnOptionsOK.TabIndex = 6;
            this.btnOptionsOK.Text = "OK";
            this.btnOptionsOK.UseVisualStyleBackColor = true;
            this.btnOptionsOK.Click += new System.EventHandler(this.btnOptionsOK_Click);
            // 
            // btnOptionsCancel
            // 
            this.btnOptionsCancel.Location = new System.Drawing.Point(643, 356);
            this.btnOptionsCancel.Name = "btnOptionsCancel";
            this.btnOptionsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnOptionsCancel.TabIndex = 5;
            this.btnOptionsCancel.Text = "Cancel";
            this.btnOptionsCancel.UseVisualStyleBackColor = true;
            this.btnOptionsCancel.Click += new System.EventHandler(this.btnOptionsCancel_Click);
            // 
            // ApplicationOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 391);
            this.Controls.Add(this.btnOptionsOK);
            this.Controls.Add(this.btnOptionsCancel);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.optionTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.ApplicationOptions_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabEnvironmentGeneral.ResumeLayout(false);
            this.tabEnvironmentGeneral.PerformLayout();
            this.tabEnvironmentColors.ResumeLayout(false);
            this.groupOptionsRasterColors.ResumeLayout(false);
            this.groupOptionsRasterColors.PerformLayout();
            this.tabEnvironmentPaths.ResumeLayout(false);
            this.tabEnvironmentPaths.PerformLayout();
            this.tabEnvironmentOthers.ResumeLayout(false);
            this.tabEnvironmentOthers.PerformLayout();
            this.tabSimulation.ResumeLayout(false);
            this.tabSimulation.PerformLayout();
            this.tabSimulationBehaviour.ResumeLayout(false);
            this.tabSimulationBehaviour.PerformLayout();
            this.tabSimulationGraphs.ResumeLayout(false);
            this.tabSimulationGraphs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabVHDL.ResumeLayout(false);
            this.tabVHDL.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.groupBoxOtherHDLoptions.ResumeLayout(false);
            this.groupBoxOtherHDLoptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxCodingOptions.ResumeLayout(false);
            this.groupBoxCodingOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView optionTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabEnvironmentGeneral;
        private System.Windows.Forms.Label lblGeneralTitle;
        private System.Windows.Forms.TabPage tabEnvironmentPaths;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabEnvironmentOthers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabSimulation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabSimulationBehaviour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedBoxClearHistoryTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabSimulationGraphs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMoveGraph;
        private System.Windows.Forms.MaskedTextBox maskedBoxMoveMembranePotential;
        private System.Windows.Forms.CheckBox checkBoxMoveMembranePotential;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabEnvironmentColors;
        private System.Windows.Forms.TabPage tabVHDL;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button btnOptionsOK;
        private System.Windows.Forms.Button btnOptionsCancel;
        private System.Windows.Forms.ColorDialog colorDialogStdBar;
        private System.Windows.Forms.GroupBox groupOptionsRasterColors;
        private System.Windows.Forms.ComboBox comboBoxColorPickerEntireOutput;
        private System.Windows.Forms.Label lblEntireActivityOutputColor;
        private System.Windows.Forms.ComboBox comboBoxColorPickerEntireLayer1;
        private System.Windows.Forms.Label lblEntireActivityLayer1Color;
        private System.Windows.Forms.ComboBox comboBoxColorPickerEntireInput;
        private System.Windows.Forms.Label lblEntireActivityInputColor;
        private System.Windows.Forms.ComboBox comboBoxColorPickerStdBars;
        private System.Windows.Forms.Label lblStandardPloterBar;
        private System.Windows.Forms.ColorDialog colorDialogEntireActiv;
        private System.Windows.Forms.TextBox textBoxOptionStimuliSrcPath;
        private System.Windows.Forms.Label lblOptionsPathStimuliSrc;
        private System.Windows.Forms.Button btnStimuliOutputPath;
        private System.Windows.Forms.TextBox textBoxOptionStimuliOutputPath;
        private System.Windows.Forms.Label lblOptionOutputPath;
        private System.Windows.Forms.Button btnStimuliSNNPath;
        private System.Windows.Forms.TextBox textBoxOptionStimuliSNNPath;
        private System.Windows.Forms.Label lblOptionSNNetworksPath;
        private System.Windows.Forms.Button btnStimuliSrcPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserStimuli;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserStructures;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserOutput;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label lblApplicationLanguage;
        private System.Windows.Forms.Label lblClearProperties;
        private System.Windows.Forms.Button btnClearRecent;
        private System.Windows.Forms.Label lblClearRecent;
        private System.Windows.Forms.Button btnRestoreDefault;
        private System.Windows.Forms.MaskedTextBox maskedBoxMaxRecent;
        private System.Windows.Forms.Label lblMaximumRecent;
        private System.Windows.Forms.Label lblOptionHardwarePath;
        private System.Windows.Forms.Button btnStimuliHardwarePath;
        private System.Windows.Forms.TextBox textBoxOptionStimuliHardwarePath;
        private System.Windows.Forms.CheckBox checkBoxGenerateTestBench;
        private System.Windows.Forms.Label lblVHDLtitle;
        private System.Windows.Forms.CheckBox checkBoxHeaderAdd;
        private System.Windows.Forms.RichTextBox richTextHeader;
        private System.Windows.Forms.Button btnHardwareSnn;
        private System.Windows.Forms.TextBox textBoxOptionSnnHardwareSrcPath;
        private System.Windows.Forms.Label lblHardwareSnnPath;
        private System.Windows.Forms.Button btnHardwareAnn;
        private System.Windows.Forms.TextBox textBoxOptionAnnHardwareSrcPath;
        private System.Windows.Forms.Label lblHardwareAnnPath;
        private System.Windows.Forms.Label lblHDLcodingBitsNumber;
        private System.Windows.Forms.Label lblHDLCodingRange;
        private System.Windows.Forms.MaskedTextBox maskedBoxCodeBits;
        private System.Windows.Forms.MaskedTextBox maskedBoxCodeRangeTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedBoxCodeRangeFrom;
        private System.Windows.Forms.MaskedTextBox maskedBoxWordLength;
        private System.Windows.Forms.Label lblCodingWordLength;
        private System.Windows.Forms.GroupBox groupBoxCodingOptions;
        private System.Windows.Forms.GroupBox groupBoxOtherHDLoptions;
        private System.Windows.Forms.MaskedTextBox maskedTextFreqDiv;
        private System.Windows.Forms.Label lblFreqDivider;
        private System.Windows.Forms.RadioButton radioRealPSPcode;
        private System.Windows.Forms.RadioButton radioIdealPSPcode;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFunctionCoding;
        private System.Windows.Forms.Label lblPSPduration;
        private System.Windows.Forms.MaskedTextBox maskedTextPSPstep;
        private System.Windows.Forms.Label lblPSPstep;
        private System.Windows.Forms.MaskedTextBox maskedTextPSPduration;
        private System.Windows.Forms.MaskedTextBox maskedTextRefractoryDuration;
        private System.Windows.Forms.Label label12;
    }
}