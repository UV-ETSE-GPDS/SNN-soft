using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using SNN.Globals;
using SNN.StructureElements;

namespace SNN.OtherForms.Tools
{
    public partial class Generator : Form
    {
        Variables _variables = new Variables();
        Flags _flags = new Flags();
        VHDLcoding _vhdlVariables;
        SNN.LanguagePack.Messages _appMessages = new SNN.LanguagePack.Messages();

        public Generator()
        {
            InitializeComponent();
        }
        public Generator(Variables globals, Flags flags,VHDLcoding vhdlVariables)
        {
            InitializeComponent();
            this._variables = globals;
            this._flags = flags;
            this._vhdlVariables = vhdlVariables;
        }
        private void Generator_Load(object sender, EventArgs e)
        {
            SNN.LanguagePack.ControlsLanguage controlsLang = new SNN.LanguagePack.ControlsLanguage();
            controlsLang.togleLanguageGenerator(this);
            if (this._flags.applicationModeFlag == 1)
            {
                this.Text = "ANN Generator";
                this.textBoxGeneratePat.Text = Properties.Settings.Default.pathHardware + "ANN\\";
            }
            else
            {
                this.Text = "SNN Generator";
                this.textBoxGeneratePat.Text = Properties.Settings.Default.pathHardware + "SNN\\";
            }

        }

        private void btnGeberateClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerateExplore_Click(object sender, EventArgs e)
        {
            String folder = this.textBoxGeneratePat.Text;
            Process.Start(@folder);
        }
        private void generateANN()
        { 
            
        }
        private void generateSNN()
        {
            this._vhdlVariables.pspFunctionValuesValue = encodeFunctionIdeal();
            addValuesToTagFile();
            this.writeFiles();
            MessageBox.Show(this._appMessages.codeGenerated[this._flags.languageIndexVar], this._appMessages.codeGeneratedTitle[this._flags.languageIndexVar], MessageBoxButtons.OK);
        }
        private string encodeFunctionIdeal()
        {             
            int howManySteps = 0;

            double helpVar = 0;
            double temp = 0;
            string binary="";
            string encodedFunction = "";

            howManySteps = Convert.ToInt32(Math.Truncate((this._vhdlVariables.pspDurationValue - 0) / this._vhdlVariables.pspStepValue));

            for (int i = 0; i < howManySteps; i++)
            {
                temp = (Math.Exp(-helpVar / 4) - Math.Exp(-helpVar / 2));
                //this.encodeOneValue(temp);

                temp = (temp) * Math.Pow(2, this._vhdlVariables.bitsCodingValue);
                temp = Math.Truncate(temp);
                binary = Convert.ToString(Convert.ToInt32(temp), 2);
                if (binary.Length < this._vhdlVariables.wordLenghtValue)
                {
                    string pom = "";
                    for (int k = 0; k < (this._vhdlVariables.wordLenghtValue - binary.Length); k++)
                    {
                        pom = pom + "0";
                    }
                    binary = pom + binary;
                }

                if (i == 0)
                    this._vhdlVariables.zeroValue = "\"" + binary + "\"";
                if(i == howManySteps - 1)
                    encodedFunction = encodedFunction + "\"" + binary + "\"";
                else
                    encodedFunction = encodedFunction + "\"" + binary + "\"" + ",";

                helpVar = helpVar + this._vhdlVariables.pspStepValue;
            }
            return encodedFunction;
        }
        private string encodeOneValue(double valueToEncode)
        {
            double temp = valueToEncode;
            string binary = "";

            if (temp >= 0)
            {
                temp = (temp) * Math.Pow(2, this._vhdlVariables.bitsCodingValue);
                temp = Math.Truncate(temp);
                binary = Convert.ToString(Convert.ToInt32(temp), 2);
                if (binary.Length < this._vhdlVariables.wordLenghtValue)
                {
                    string pom = "";
                    for (int k = 0; k < (this._vhdlVariables.wordLenghtValue - binary.Length); k++)
                    {
                        pom = pom + "0";
                    }
                    binary = pom + binary;
                }
            }
            else
            {
                temp = (temp) * Math.Pow(2, this._vhdlVariables.bitsCodingValue);
                temp = Math.Truncate(temp);
                binary = Convert.ToString(Convert.ToInt32(temp), 2);
                if (binary.Length < this._vhdlVariables.wordLenghtValue)
                {
                    string pom = "";
                    for (int k = 0; k < (this._vhdlVariables.wordLenghtValue - binary.Length); k++)
                    {
                        pom = pom + "0";
                    }
                    binary = pom + binary;
                }
                StringBuilder toReturn = new StringBuilder();
                for (int i = 0; i < binary.Length; i++)
                {
                    toReturn.Append(binary[(binary.Length - 1) - i]);
                }
                binary = this.twosComplement(toReturn.ToString());
            }           

            return binary;

        }
        private string twosComplement(string toEncode)
        {
            string binary = toEncode;
            StringBuilder toReturn = new StringBuilder();
            char carry = '1';
            char oneBit = '-';

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i].CompareTo('0') == 0)
                {
                    oneBit = '1';
                }
                else
                {
                    oneBit = '0';
                }
                if ((carry.CompareTo('0') == 0) && (oneBit.CompareTo('0') == 0))
                {
                    oneBit = '0';
                    carry = '0';
                }
                else if (((carry.CompareTo('0') == 0) && (oneBit.CompareTo('1') == 0)))
                {
                    oneBit = '1';
                    carry = '0';
                }
                else if (((oneBit.CompareTo('0') == 0) && (carry.CompareTo('1') == 0)))
                {
                    oneBit = '1';
                    carry = '0';
                }
                else if ((oneBit.CompareTo('1') == 0) && (carry.CompareTo('1') == 0))
                {
                    oneBit = '0';
                    carry = '1';
                }
                toReturn.Append(oneBit);
            }
            binary = toReturn.ToString();
            toReturn = new StringBuilder();
            for (int i = 0; i < binary.Length; i++)
            {
                toReturn.Append(binary[(binary.Length - 1) - i]);
            }


            return toReturn.ToString();
        }
        private void writeFiles()
        {
            if (this._flags.applicationModeFlag == 0) // if SNN
            {
                
                string[] srcFiles = Directory.GetFiles(Properties.Settings.Default.pathSnnSrc);
                this.progressBar1.Maximum = Convert.ToInt32(this.countStepsForProgress(Application.StartupPath + "\\snnTags.dat") * srcFiles.Length);

                if (srcFiles == null || srcFiles.Length == 0)
                {
                    MessageBox.Show(this._appMessages.noSrcFiles[this._flags.languageIndexVar], this._appMessages.noSrcFilesTitle[this._flags.languageIndexVar], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    StreamReader srTagsFile = new StreamReader(Application.StartupPath + "\\snnTags.dat");
                    List<string> tagList = new List<string>();
                    string tagLine = srTagsFile.ReadLine();
                    while (tagLine != null)
                    {
                        tagList.Add(tagLine);
                        tagLine = srTagsFile.ReadLine();
                    }

                    foreach (string oneFile in srcFiles)
                    {
                        string newFileName = Path.GetFileName(oneFile);
                        StreamReader srSourceFile = new StreamReader(oneFile);
                        TextWriter newFile = new StreamWriter(this.textBoxGeneratePat.Text + newFileName);
                        if (this._vhdlVariables.addHeaderValue == true)
                        {
                            newFile.WriteLine(this._vhdlVariables.headerValue);
                        }
                        string srcLine = srSourceFile.ReadLine();
                        while (srcLine != null)
                        {
                            string lineToWrite = srcLine;
                            foreach(string oneTag in tagList)
                            {
                                string[] tagParser = oneTag.Split('=');
                                
                                if (srcLine.IndexOf(tagParser[0]) != -1)
                                {
                                    lineToWrite = srcLine.Replace(tagParser[0], tagParser[1]);
                                }
                            }
                            this.progressBar1.PerformStep();
                            newFile.WriteLine(lineToWrite);
                            srcLine = srSourceFile.ReadLine();
                        }
                        srSourceFile.Close();
                        newFile.Close();
                    }
                    srTagsFile.Close();
                }
            }
            else                                     // if ANN
            { 
            
            }
        }
        private void addValuesToTagFile()
        {
            if (this._flags.applicationModeFlag == 0)
            {
                StreamReader srGlobFile = new StreamReader(Application.StartupPath + "\\snnTags.dat");
                TextWriter tw = new StreamWriter(Application.StartupPath + "\\_snnTags.dat");
                string delaysString;
                string lineToRead = srGlobFile.ReadLine();
                string lineToWrite = "";
                while (lineToRead != null)
                {

                    if (lineToRead.IndexOf("<PSP_FUNCTION_VALUES>") != -1)
                    {
                        lineToWrite = "<PSP_FUNCTION_VALUES>=" + this._vhdlVariables.pspFunctionValuesValue;
                    }
                    else if (lineToRead.IndexOf("<ZERO_VALUE>") != -1)
                    {
                        lineToWrite = "<ZERO_VALUE>=" + this._vhdlVariables.zeroValue;
                    }
                    else if (lineToRead.IndexOf("<FREQUENCY_DIV>") != -1)
                    {
                        lineToWrite = "<FREQUENCY_DIV>=" + this._vhdlVariables.freqDivValue.ToString();
                    }
                    else if (lineToRead.IndexOf("<CODING_POWER>") != -1)
                    {
                        lineToWrite = "<CODING_POWER>=" + this._vhdlVariables.bitsCodingValue.ToString();
                    }
                    else if (lineToRead.IndexOf("<NUMBER_OF_BITS>") != -1)
                    {
                        lineToWrite = "<NUMBER_OF_BITS>=" + this._vhdlVariables.wordLenghtValue.ToString();
                    }
                    else if (lineToRead.IndexOf("<INPUT_NUMBER>") != -1)
                    {
                        lineToWrite = "<INPUT_NUMBER>=" + this._variables.numberInput.ToString();
                    }
                    else if (lineToRead.IndexOf("<LAYER1_NUMBER>") != -1)
                    {
                        lineToWrite = "<LAYER1_NUMBER>=" + this._variables.numberLayer1.ToString();
                    }
                    else if (lineToRead.IndexOf("<OUTPUT_NUMBER>") != -1)
                    {
                        lineToWrite = "<OUTPUT_NUMBER>=" + this._variables.numberOutput.ToString();
                    }
                    else if (lineToRead.IndexOf("<PSP_LENGTH>") != -1)
                    {
                        lineToWrite = "<PSP_LENGTH>=" + this._vhdlVariables.pspDurationValue.ToString();
                    }

                    else if (lineToRead.IndexOf("<INPUT_DELAYS>") != -1)
                    {
                        delaysString = "";

                        for (int i = 0; i < this._variables.numberInput - 1; i++)
                        {
                            delaysString = delaysString + ((InputNeuron)this._variables.inputNeurons[i].Tag).delayCopy.ToString() + ",";
                        }
                        delaysString = delaysString + ((InputNeuron)this._variables.inputNeurons[this._variables.numberInput - 1].Tag).delayCopy.ToString();

                        lineToWrite = "<INPUT_DELAYS>=" + delaysString;
                    }
                    else if (lineToRead.IndexOf("<INPUT_TO_LAYER1_DELAYS>") != -1)
                    {
                        delaysString = "";
                        for (int j = 0; j < this._variables.numberInput; j++)
                        {
                            for (int i = 0; i < this._variables.numberLayer1; i++)
                            {

                                delaysString = delaysString + ((Neuron)this._variables.layer1[i].Tag).delays[j].ToString() + ",";
                            }
                        }
                        lineToWrite = delaysString.Remove(delaysString.Length - 1);
                        lineToWrite = "<INPUT_TO_LAYER1_DELAYS>=" + lineToWrite;
                    }
                    else if (lineToRead.IndexOf("<LAYER1_TO_OUTPUT_DELAYS>") != -1)
                    {
                        delaysString = "";
                        for (int j = 0; j < this._variables.numberLayer1; j++)
                        {
                            for (int i = 0; i < this._variables.numberOutput; i++)
                            {

                                delaysString = delaysString + ((Neuron)this._variables.output[i].Tag).delays[j].ToString() + ",";
                            }
                        }
                        lineToWrite = delaysString.Remove(delaysString.Length - 1);
                        lineToWrite = "<LAYER1_TO_OUTPUT_DELAYS>=" + lineToWrite;
                    }
                    else if (lineToRead.IndexOf("<LAYER1_WEIGHTS>") != -1)
                    {
                        delaysString = "";
                        for (int i = 0; i < this._variables.numberLayer1; i++)
                        {
                            for (int j = 0; j < this._variables.numberInput; j++)
                            {
                                delaysString = delaysString + "\"" + this.encodeOneValue(((Neuron)this._variables.layer1[i].Tag).weights[j]).ToString() + "\"" + ",";
                            }
                        }
                        lineToWrite = delaysString.Remove(delaysString.Length - 1);
                        lineToWrite = "<LAYER1_WEIGHTS>=" + lineToWrite;
                    }
                    else if (lineToRead.IndexOf("<OUTPUT_WEIGHTS>") != -1)
                    {
                        delaysString = "";
                        for (int i = 0; i < this._variables.numberOutput; i++)
                        {
                            for (int j = 0; j < this._variables.numberLayer1; j++)
                            {
                                delaysString = delaysString + "\"" + this.encodeOneValue(((Neuron)this._variables.output[i].Tag).weights[j]).ToString() + "\"" + ",";
                            }
                        }
                        lineToWrite = delaysString.Remove(delaysString.Length - 1);
                        lineToWrite = "<OUTPUT_WEIGHTS>=" + lineToWrite;
                    }
                    else if (lineToRead.IndexOf("<REFRACTORY_DURATION>") != -1)
                    {
                        lineToWrite = "<REFRACTORY_DURATION>=" + this._vhdlVariables.refractoryDurationValue.ToString();
                    }
                    else if (lineToRead.IndexOf("<THRESHOLD>") != -1)
                    {
                        lineToWrite = "<THRESHOLD>=" + "\"" + this.encodeOneValue(((Neuron)this._variables.layer1[0].Tag).threshold) + "\"";
                    }
                    else
                        lineToWrite = lineToRead;
                    tw.WriteLine(lineToWrite);
                    lineToRead = srGlobFile.ReadLine();
                }

                srGlobFile.Close();
                tw.Close();
                File.Replace(Application.StartupPath + "\\_snnTags.dat", Application.StartupPath + "\\snnTags.dat", Application.StartupPath + "\\temp.file", false);
                //File.Delete(Application.StartupPath + "\\temp.file");
                //File.Delete(Application.StartupPath + "\\_snnTags.dat");

            }
            else
            { 
            
            }
        }
        private long countStepsForProgress(string tagsFile)
        {
            long count = 0;
            using (StreamReader sr = new StreamReader(tagsFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnGenerateGo_Click(object sender, EventArgs e)
        {
            if (this._flags.applicationModeFlag == 0)
            {
                if ((this._variables.numberInput == 0) || (this._variables.numberLayer1 == 0) || (this._variables.numberOutput == 0))
                {
                    MessageBox.Show(this._appMessages.noStructure[this._flags.languageIndexVar], this._appMessages.noStructureTitle[this._flags.languageIndexVar], MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                    this.generateSNN();
            }
        }

        private void btnGenerateBrowse_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserLocation.ShowDialog() != DialogResult.Cancel)
            {
                this.textBoxGeneratePat.Text = this.folderBrowserLocation.SelectedPath + "\\";
            }
        }
        
    }
}
