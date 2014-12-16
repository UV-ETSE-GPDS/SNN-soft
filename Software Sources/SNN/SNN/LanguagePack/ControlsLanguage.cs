using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SNN.OtherForms;


namespace SNN.LanguagePack
{
    public class ControlsLanguage
    {

        public ControlsLanguage()
        { 
        
        }
        public void toogleLanguageMainForm(SNNmain main)
        {
            if (Properties.Settings.Default.applicationLanguage == 0) //ENG
            {
                MenuStrip menu = (MenuStrip) main.Controls.Find("menuStrip", true)[0];

                ((ToolStripMenuItem)menu.Items.Find("menuStripFile",true)[0]).Text = "&File";
                ((ToolStripMenuItem)menu.Items.Find("menuStripNew",true)[0]).Text = "&New";  
                ((ToolStripMenuItem)menu.Items.Find("menuStripLoad",true)[0]).Text = "&Load Structure";
                ((ToolStripMenuItem)menu.Items.Find("menuStripSave",true)[0]).Text = "&Save Structure";
                ((ToolStripMenuItem)menu.Items.Find("menuStripExit",true)[0]).Text = "E&xit";
                ((ToolStripMenuItem)menu.Items.Find("menuStripView",true)[0]).Text = "&View";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindows",true)[0]).Text = "&Windows"; 
                ((ToolStripMenuItem)menu.Items.Find("menuStripStructureToolBox",true)[0]).Text = "Structure ToolBox";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowWorkspace",true)[0]).Text = "Workspace";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowDetails",true)[0]).Text = "Neuron Details";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowInitialization",true)[0]).Text = "Simulation Initialization";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowSimulation",true)[0]).Text = "Simulation";
                ((ToolStripMenuItem)menu.Items.Find("menuStripSimulation",true)[0]).Text = "Si&mulation";
                ((ToolStripMenuItem)menu.Items.Find("menuStripInitializeSimulation",true)[0]).Text = "Initialize Simulation";
                ((ToolStripMenuItem)menu.Items.Find("menuStripTools",true)[0]).Text = "&Tools";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlot",true)[0]).Text = "Plot";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotInput",true)[0]).Text = "Input Layer";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotLayer1",true)[0]).Text = "Layer 1"; 
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotOutput",true)[0]).Text = "Output Layer";
                ((ToolStripMenuItem)menu.Items.Find("menuStripGaussianRF",true)[0]).Text = "Gaussian Receptive Fields";
                ((ToolStripMenuItem)menu.Items.Find("menuStripOptions",true)[0]).Text = "Options...";
                ((ToolStripMenuItem)menu.Items.Find("menuStripHelp",true)[0]).Text = "&Help";
                ((ToolStripMenuItem)menu.Items.Find("menuStripAbout",true)[0]).Text = "About";
                ((ToolStripMenuItem)menu.Items.Find("menuStripApplicationMOde",true)[0]).Text = "Application Mode";
                ((ToolStripMenuItem)menu.Items.Find("menuStripModeSNN",true)[0]).Text = "Spiking Networks";
                ((ToolStripMenuItem)menu.Items.Find("menuStripModeANN",true)[0]).Text = "Artificial Networks";
                ((ToolStripMenuItem)menu.Items.Find("menuStripInputFileTool",true)[0]).Text = "Input File Generator";
                ((ToolStripMenuItem)menu.Items.Find("menuStripGenerateVHDL",true)[0]).Text = "Generate VHDL Code";

                ((ToolStripMenuItem)menu.Items.Find("contentToolStripMenuItem",true)[0]).Text = "Open Help";
                ((ToolStripMenuItem)menu.Items.Find("menuStripRecent", true)[0]).Text = "Recent Projects";

                ((Label)main.Controls.Find("designEditorHeaderTitle",true)[0]).Text = "Structure Editor";
                ((GroupBox)main.Controls.Find("groupBoxTools",true)[0]).Text = "Tools";
                ((GroupBox)main.Controls.Find("groupBoxLayers",true)[0]).Text = "Number of Layers";
                ((GroupBox)main.Controls.Find("groupBoxStructure",true)[0]).Text = "Structure";
                ((RadioButton)main.Controls.Find("radioButton1",true)[0]).Text = "1 Layer";
                ((RadioButton)main.Controls.Find("radioButton2",true)[0]).Text = "2 Layers";
                ((Label)main.Controls.Find("lblInputNr",true)[0]).Text = "Input Layer:";

                ((Label)main.Controls.Find("lblLayer1Nr",true)[0]).Text = "Layer 1:";
                ((Label)main.Controls.Find("lblLayer2Nr",true)[0]).Text = "Layer 2:";
                ((Label)main.Controls.Find("lblOutputNr",true)[0]).Text = "Output Layer:";
                ((Button)main.Controls.Find("btnUpdateStructure",true)[0]).Text = "Update";
                ((Label)main.Controls.Find("detailsWindowHeaderTitle",true)[0]).Text = "Neuron Details";
                ((Label)main.Controls.Find("simulationWindowHeaderTitle",true)[0]).Text = "Initialization";
                ((Label)main.Controls.Find("simInOutWindowTitle", true)[0]).Text = "Simulate";
                ((GroupBox)main.Controls.Find("groupPSPFunction",true)[0]).Text = "PSP Function";
                ((RadioButton)main.Controls.Find("radioIdealPSP",true)[0]).Text = "Ideal PSP";
                ((RadioButton)main.Controls.Find("radioRealPSP",true)[0]).Text = "Real PSP";
                ((GroupBox)main.Controls.Find("groupDataSrc",true)[0]).Text = "Data Source";
                ((RadioButton)main.Controls.Find("radioSrcManual",true)[0]).Text = "Manual Simulation";
                ((RadioButton)main.Controls.Find("radioSrcFile",true)[0]).Text = "From File";
                ((RadioButton)main.Controls.Find("radioSrcTest",true)[0]).Text = "Test Simulation";
                ((Button)main.Controls.Find("button1",true)[0]).Text = "Browse..";
                ((Label)main.Controls.Find("lblCodingMode",true)[0]).Text = "Input Coding Mode:";
                ((RadioButton)main.Controls.Find("radioCodingPopulationGauss",true)[0]).Text = "Gaussian Receptive Fields";
                ((RadioButton)main.Controls.Find("radioCodingPopulationSimple",true)[0]).Text = "Temporal Coding";
                ((RadioButton)main.Controls.Find("radioCodingImageRecognition",true)[0]).Text = "Image Recognition";
                ((Label)main.Controls.Find("lblNeuronThr",true)[0]).Text = "Neuron Threshold";
                ((GroupBox)main.Controls.Find("groupWeightInit",true)[0]).Text = "Weights Initialization Params:";
                ((Label)main.Controls.Find("lblWeightInitParams",true)[0]).Text = "Random Range:";
                ((GroupBox)main.Controls.Find("groupDealyInit",true)[0]).Text = "Delays Initialization Params:";
                ((Label)main.Controls.Find("lblLayerDelay",true)[0]).Text = "Layer delay to:";
                ((CheckBox)main.Controls.Find("checkBoxRandomParameters",true)[0]).Text = "Randomize New Parameters";
                ((Label)main.Controls.Find("lblLearningRules",true)[0]).Text = "Learning Rules";
                ((RadioButton)main.Controls.Find("radioLearningNone",true)[0]).Text = "Without Learning";
                ((RadioButton)main.Controls.Find("radioLearningSTDP",true)[0]).Text = "STDP Learning";
                ((Label)main.Controls.Find("lblMaxWeight",true)[0]).Text = "Max. Weight:";
                ((Label)main.Controls.Find("lblMinWeight",true)[0]).Text = "Min. Weight:";
                ((Label)main.Controls.Find("lblInputDelayInit",true)[0]).Text = "Input delay to:";
                ((Label)main.Controls.Find("lblOutputInterpretation",true)[0]).Text = "Output Interpretation:";
                ((Button)main.Controls.Find("button2",true)[0]).Text = "Begin Simulation";
                ((RadioButton)main.Controls.Find("radioOutFile",true)[0]).Text = "Write Output to File";
                ((RadioButton)main.Controls.Find("radioOutNothing",true)[0]).Text = "Do Nothing";
                ((Label)main.Controls.Find("lblStimuliPerEpoch",true)[0]).Text = "Stimuli per Epoch:";
                ((Label)main.Controls.Find("lblStimuliFileTime",true)[0]).Text = "Presentation period:";
                ((Label)main.Controls.Find("lblPotential",true)[0]).Text = "Current potential:";

                ((ToolStripLabel)((ToolStrip)main.Controls.Find("toolStripMenu", true)[0]).Items.Find("toolStripLabel1", true)[0]).Text = "Simulation Time:";
                
                TreeView tree = (TreeView)main.Controls.Find("treeView1", true)[0];
                tree.Nodes[0].Text = "Simulation Path";
                tree.Nodes[0].Nodes[0].Text = "Simulation Preferences";
                tree.Nodes[0].Nodes[1].Text = "Data Source";
                tree.Nodes[0].Nodes[2].Text = "Input Coding Mode";
                tree.Nodes[0].Nodes[3].Text = "Network Initialization";
                tree.Nodes[0].Nodes[4].Text = "Learning Rules";
                tree.Nodes[0].Nodes[5].Text = "Simulation";

            }
            if (Properties.Settings.Default.applicationLanguage == 1) //POL
            {
                MenuStrip menu = (MenuStrip) main.Controls.Find("menuStrip", true)[0];

                ((ToolStripMenuItem)menu.Items.Find("menuStripFile",true)[0]).Text = "&Plik";
                ((ToolStripMenuItem)menu.Items.Find("menuStripNew",true)[0]).Text = "&Nowy";  
                ((ToolStripMenuItem)menu.Items.Find("menuStripLoad",true)[0]).Text = "W&czytaj Strukture";
                ((ToolStripMenuItem)menu.Items.Find("menuStripSave",true)[0]).Text = "Zapi&sz Strukture";
                ((ToolStripMenuItem)menu.Items.Find("menuStripExit",true)[0]).Text = "Za&kończ";
                ((ToolStripMenuItem)menu.Items.Find("menuStripView",true)[0]).Text = "&Widok";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindows",true)[0]).Text = "&Okna"; 
                ((ToolStripMenuItem)menu.Items.Find("menuStripStructureToolBox",true)[0]).Text = "Struktura Sieci";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowWorkspace",true)[0]).Text = "Przestrzeń Robocza";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowDetails",true)[0]).Text = "Szczegóły Neuronu";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowInitialization",true)[0]).Text = "Inicjalizacja Symulacji";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowSimulation",true)[0]).Text = "Symulacja";
                ((ToolStripMenuItem)menu.Items.Find("menuStripSimulation",true)[0]).Text = "Sy&mulacja;";
                ((ToolStripMenuItem)menu.Items.Find("menuStripInitializeSimulation",true)[0]).Text = "Inicjuj Symulacje";
                ((ToolStripMenuItem)menu.Items.Find("menuStripTools",true)[0]).Text = "&Narzędzia";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlot",true)[0]).Text = "Ploter";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotInput",true)[0]).Text = "Warstwa Wejściowa";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotLayer1",true)[0]).Text = "Warstwa 1"; 
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotOutput",true)[0]).Text = "Warstwa Wyjściowa";
                ((ToolStripMenuItem)menu.Items.Find("menuStripGaussianRF",true)[0]).Text = "Pola Receptorowe Gaussa";
                ((ToolStripMenuItem)menu.Items.Find("menuStripOptions",true)[0]).Text = "Opcje...";
                ((ToolStripMenuItem)menu.Items.Find("menuStripHelp",true)[0]).Text = "&Pomoc";
                ((ToolStripMenuItem)menu.Items.Find("menuStripAbout",true)[0]).Text = "O Programie";
                ((ToolStripMenuItem)menu.Items.Find("menuStripApplicationMOde",true)[0]).Text = "Tryb Aplikacji";
                ((ToolStripMenuItem)menu.Items.Find("menuStripModeSNN",true)[0]).Text = "Sieci Impulsowe";
                ((ToolStripMenuItem)menu.Items.Find("menuStripModeANN",true)[0]).Text = "Sieci Tradycyjne";
                ((ToolStripMenuItem)menu.Items.Find("menuStripInputFileTool",true)[0]).Text = "Generator Plików Wejściowych";
                ((ToolStripMenuItem)menu.Items.Find("menuStripGenerateVHDL",true)[0]).Text = "Generator kodu VHDL";

                ((ToolStripMenuItem)menu.Items.Find("contentToolStripMenuItem",true)[0]).Text = "Otwórz Pomoc";
                ((ToolStripMenuItem)menu.Items.Find("menuStripRecent", true)[0]).Text = "Aktualne Projekty";

                ((Label)main.Controls.Find("designEditorHeaderTitle",true)[0]).Text = "Edytor Struktury";
                ((GroupBox)main.Controls.Find("groupBoxTools",true)[0]).Text = "Narzędzia";
                ((GroupBox)main.Controls.Find("groupBoxLayers",true)[0]).Text = "Liczba Warstw";
                ((GroupBox)main.Controls.Find("groupBoxStructure",true)[0]).Text = "Struktura";
                ((RadioButton)main.Controls.Find("radioButton1",true)[0]).Text = "1 Warstwa";
                ((RadioButton)main.Controls.Find("radioButton2",true)[0]).Text = "2 Warstwy";
                ((Label)main.Controls.Find("lblInputNr",true)[0]).Text = "Warstwa Wej.:";

                ((Label)main.Controls.Find("lblLayer1Nr",true)[0]).Text = "Warstwa 1:";
                ((Label)main.Controls.Find("lblLayer2Nr",true)[0]).Text = "Warstwa 2:";
                ((Label)main.Controls.Find("lblOutputNr",true)[0]).Text = "Warstwa Wyj.:";
                ((Button)main.Controls.Find("btnUpdateStructure",true)[0]).Text = "Uaktualnij";
                ((Label)main.Controls.Find("detailsWindowHeaderTitle",true)[0]).Text = "Szczegóły Neuronu";
                ((Label)main.Controls.Find("simulationWindowHeaderTitle",true)[0]).Text = "Inicjalizacja";
                ((Label)main.Controls.Find("simInOutWindowTitle", true)[0]).Text = "Symuluj";
                ((GroupBox)main.Controls.Find("groupPSPFunction",true)[0]).Text = "Funkcja PSP";
                ((RadioButton)main.Controls.Find("radioIdealPSP",true)[0]).Text = "Idealny PSP";
                ((RadioButton)main.Controls.Find("radioRealPSP",true)[0]).Text = "Rzeczywisty PSP";
                ((GroupBox)main.Controls.Find("groupDataSrc",true)[0]).Text = "Źródło Danych";
                ((RadioButton)main.Controls.Find("radioSrcManual",true)[0]).Text = "Symulacja Manualna";
                ((RadioButton)main.Controls.Find("radioSrcFile",true)[0]).Text = "Z Pliku";
                ((RadioButton)main.Controls.Find("radioSrcTest",true)[0]).Text = "Tryb Testowy";
                ((Button)main.Controls.Find("button1",true)[0]).Text = "Przeglądaj..";
                ((Label)main.Controls.Find("lblCodingMode",true)[0]).Text = "Tryb Kodowania Wejścia:";
                ((RadioButton)main.Controls.Find("radioCodingPopulationGauss",true)[0]).Text = "Pola Receptorowe Gaussa";
                ((RadioButton)main.Controls.Find("radioCodingPopulationSimple",true)[0]).Text = "Kodowanie Czasowe";
                ((RadioButton)main.Controls.Find("radioCodingImageRecognition",true)[0]).Text = "Rozpoznawanie Wzorów";
                ((Label)main.Controls.Find("lblNeuronThr",true)[0]).Text = "Próg Neuronu";
                ((GroupBox)main.Controls.Find("groupWeightInit",true)[0]).Text = "Parametry Inicjalizacji Wag:";
                ((Label)main.Controls.Find("lblWeightInitParams",true)[0]).Text = "Zakres:";
                ((GroupBox)main.Controls.Find("groupDealyInit",true)[0]).Text = "Parametry Inicjalizacji Opóźnień:";
                ((Label)main.Controls.Find("lblLayerDelay",true)[0]).Text = "Opóźnienia Warstw DO:";
                ((CheckBox)main.Controls.Find("checkBoxRandomParameters",true)[0]).Text = "Losuj Nowe Parametry";
                ((Label)main.Controls.Find("lblLearningRules",true)[0]).Text = "Reguły Uczenia";
                ((RadioButton)main.Controls.Find("radioLearningNone",true)[0]).Text = "Bez Uczenia";
                ((RadioButton)main.Controls.Find("radioLearningSTDP",true)[0]).Text = "Algorytm STDP";
                ((Label)main.Controls.Find("lblMaxWeight",true)[0]).Text = "Maks. Waga:";
                ((Label)main.Controls.Find("lblMinWeight",true)[0]).Text = "Min. Waga:";
                ((Label)main.Controls.Find("lblInputDelayInit",true)[0]).Text = "Opóźnienie Wej. Do:";
                ((Label)main.Controls.Find("lblOutputInterpretation",true)[0]).Text = "Interpretacja Wyj.:";
                ((Button)main.Controls.Find("button2",true)[0]).Text = "Rozpocznij Symulacje";
                ((RadioButton)main.Controls.Find("radioOutFile",true)[0]).Text = "Zapisz Wyjście Do Pliku";
                ((RadioButton)main.Controls.Find("radioOutNothing",true)[0]).Text = "Nie rób nic";
                ((Label)main.Controls.Find("lblStimuliPerEpoch",true)[0]).Text = "Bodźców na Epoch:";
                ((Label)main.Controls.Find("lblStimuliFileTime",true)[0]).Text = "Okres Prezentacji:";
                ((Label)main.Controls.Find("lblPotential",true)[0]).Text = "Aktualny Potencjał:";

                ((ToolStripLabel)((ToolStrip)main.Controls.Find("toolStripMenu", true)[0]).Items.Find("toolStripLabel1", true)[0]).Text = "Czas Symulacji:";
                

                TreeView tree = (TreeView)main.Controls.Find("treeView1", true)[0];
                tree.Nodes[0].Text = "Proces Symulacji";
                tree.Nodes[0].Nodes[0].Text = "Opcje Symulacji";
                tree.Nodes[0].Nodes[1].Text = "Źródło Danych";
                tree.Nodes[0].Nodes[2].Text = "Tryb Kodowania Wejścia";
                tree.Nodes[0].Nodes[3].Text = "Inicjalizacja Sieci";
                tree.Nodes[0].Nodes[4].Text = "Reguły Uczenia";
                tree.Nodes[0].Nodes[5].Text = "Symulacja";


                
            }
            if (Properties.Settings.Default.applicationLanguage == 2) //ESP
            {
                                MenuStrip menu = (MenuStrip) main.Controls.Find("menuStrip", true)[0];

                ((ToolStripMenuItem)menu.Items.Find("menuStripFile",true)[0]).Text = "&Archivo";
                ((ToolStripMenuItem)menu.Items.Find("menuStripNew",true)[0]).Text = "&Nuevo";  
                ((ToolStripMenuItem)menu.Items.Find("menuStripLoad",true)[0]).Text = "&Carga de estructura";
                ((ToolStripMenuItem)menu.Items.Find("menuStripSave",true)[0]).Text = "&Salvar Structure";
                ((ToolStripMenuItem)menu.Items.Find("menuStripExit",true)[0]).Text = "Sa&lir";
                ((ToolStripMenuItem)menu.Items.Find("menuStripView",true)[0]).Text = "&Ver";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindows",true)[0]).Text = "Ve&ntanas"; 
                ((ToolStripMenuItem)menu.Items.Find("menuStripStructureToolBox",true)[0]).Text = "ToolBox de Estructura";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowWorkspace",true)[0]).Text = "Espacio de Trabajo";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowDetails",true)[0]).Text = "Detalles de Neurona";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowInitialization",true)[0]).Text = "Initialización de Simulación";
                ((ToolStripMenuItem)menu.Items.Find("menuStripWindowSimulation",true)[0]).Text = "Simulación";
                ((ToolStripMenuItem)menu.Items.Find("menuStripSimulation",true)[0]).Text = "Si&mulación;";
                ((ToolStripMenuItem)menu.Items.Find("menuStripInitializeSimulation",true)[0]).Text = "Initializar de Simulación";
                ((ToolStripMenuItem)menu.Items.Find("menuStripTools",true)[0]).Text = "&Herramientas";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlot",true)[0]).Text = "Complot";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotInput",true)[0]).Text = "Capa de Entrada";
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotLayer1",true)[0]).Text = "Capa Oculta 1"; 
                ((ToolStripMenuItem)menu.Items.Find("menuStripPlotOutput",true)[0]).Text = "Capa de Salida";
                ((ToolStripMenuItem)menu.Items.Find("menuStripGaussianRF",true)[0]).Text = "Campo Receptivo Gaussiana";
                ((ToolStripMenuItem)menu.Items.Find("menuStripOptions",true)[0]).Text = "Opciónes...";
                ((ToolStripMenuItem)menu.Items.Find("menuStripHelp",true)[0]).Text = "A&yuda";
                ((ToolStripMenuItem)menu.Items.Find("menuStripAbout",true)[0]).Text = "Información";
                ((ToolStripMenuItem)menu.Items.Find("menuStripApplicationMOde",true)[0]).Text = "Modo de Aplicación";
                ((ToolStripMenuItem)menu.Items.Find("menuStripModeSNN", true)[0]).Text = "Redes de impulsos";
                ((ToolStripMenuItem)menu.Items.Find("menuStripModeANN",true)[0]).Text = "Redes Tradicionales";
                ((ToolStripMenuItem)menu.Items.Find("menuStripInputFileTool",true)[0]).Text = "Generador Archivos de Salida";
                ((ToolStripMenuItem)menu.Items.Find("menuStripGenerateVHDL",true)[0]).Text = "Generador de VHDL";

                ((ToolStripMenuItem)menu.Items.Find("contentToolStripMenuItem",true)[0]).Text = "Ayudar";
                ((ToolStripMenuItem)menu.Items.Find("menuStripRecent", true)[0]).Text = "Recientes Proyectos";

                ((Label)main.Controls.Find("designEditorHeaderTitle",true)[0]).Text = "Director de Estructura";
                ((GroupBox)main.Controls.Find("groupBoxTools",true)[0]).Text = "Harramientas";
                ((GroupBox)main.Controls.Find("groupBoxLayers", true)[0]).Text = "Número de Capa";
                ((GroupBox)main.Controls.Find("groupBoxStructure",true)[0]).Text = "Estructura";
                ((RadioButton)main.Controls.Find("radioButton1",true)[0]).Text = "1 Capa";
                ((RadioButton)main.Controls.Find("radioButton2",true)[0]).Text = "2 Capas";
                ((Label)main.Controls.Find("lblInputNr",true)[0]).Text = "Capa de Entrada:";

                ((Label)main.Controls.Find("lblLayer1Nr",true)[0]).Text = "Capa 1:";
                ((Label)main.Controls.Find("lblLayer2Nr",true)[0]).Text = "Capa 2:";
                ((Label)main.Controls.Find("lblOutputNr",true)[0]).Text = "Capa de Salida:";
                ((Button)main.Controls.Find("btnUpdateStructure",true)[0]).Text = "Actualizar";
                ((Label)main.Controls.Find("detailsWindowHeaderTitle",true)[0]).Text = "Detalles de Neurona";
                ((Label)main.Controls.Find("simulationWindowHeaderTitle",true)[0]).Text = "Initialización";
                ((Label)main.Controls.Find("simInOutWindowTitle", true)[0]).Text = "Simular";
                ((GroupBox)main.Controls.Find("groupPSPFunction",true)[0]).Text = "Función de PSP";
                ((RadioButton)main.Controls.Find("radioIdealPSP",true)[0]).Text = "PSP Ideal";
                ((RadioButton)main.Controls.Find("radioRealPSP",true)[0]).Text = "PSP Real";
                ((GroupBox)main.Controls.Find("groupDataSrc",true)[0]).Text = "Fuente de Datos";
                ((RadioButton)main.Controls.Find("radioSrcManual",true)[0]).Text = "Simulación Manual";
                ((RadioButton)main.Controls.Find("radioSrcFile",true)[0]).Text = "De Archivo";
                ((RadioButton)main.Controls.Find("radioSrcTest",true)[0]).Text = "Simulación Prueba";
                ((Button)main.Controls.Find("button1",true)[0]).Text = "Abrir..";
                ((Label)main.Controls.Find("lblCodingMode",true)[0]).Text = "Codigo de Entrada:";
                ((RadioButton)main.Controls.Find("radioCodingPopulationGauss",true)[0]).Text = "Campo Receptivo Gaussiana";
                ((RadioButton)main.Controls.Find("radioCodingPopulationSimple",true)[0]).Text = "Codigo Temporal";
                ((RadioButton)main.Controls.Find("radioCodingImageRecognition", true)[0]).Text = "Reconocimiento de Imágenes";
                ((Label)main.Controls.Find("lblNeuronThr",true)[0]).Text = "Umbral";
                ((GroupBox)main.Controls.Find("groupWeightInit", true)[0]).Text = "Parámetros de Inicialización";
                ((Label)main.Controls.Find("lblWeightInitParams",true)[0]).Text = "Aleatorio Limites";
                ((GroupBox)main.Controls.Find("groupDealyInit",true)[0]).Text = "Parametros de Demoras";
                ((Label)main.Controls.Find("lblLayerDelay",true)[0]).Text = "Demora de Capa Hasta:";
                ((CheckBox)main.Controls.Find("checkBoxRandomParameters", true)[0]).Text = "Aleatorizar Parametros";
                ((Label)main.Controls.Find("lblLearningRules",true)[0]).Text = "Norma de Saber";
                ((RadioButton)main.Controls.Find("radioLearningNone",true)[0]).Text = "No Saber";
                ((RadioButton)main.Controls.Find("radioLearningSTDP",true)[0]).Text = "STDP";
                ((Label)main.Controls.Find("lblMaxWeight",true)[0]).Text = "Peso Max.:";
                ((Label)main.Controls.Find("lblMinWeight",true)[0]).Text = "Peso Min.:";
                ((Label)main.Controls.Find("lblInputDelayInit",true)[0]).Text = "Demora de Entrada Hasta:";
                ((Label)main.Controls.Find("lblOutputInterpretation",true)[0]).Text = "Interpretación de Salida:";
                ((Button)main.Controls.Find("button2",true)[0]).Text = "Emprezar Simulacioń";
                ((RadioButton)main.Controls.Find("radioOutFile",true)[0]).Text = "Escribir Salida a Archivo";
                ((RadioButton)main.Controls.Find("radioOutNothing",true)[0]).Text = "Hace nada";
                ((Label)main.Controls.Find("lblStimuliPerEpoch",true)[0]).Text = "Estimulo por Epoch:";
                ((Label)main.Controls.Find("lblStimuliFileTime",true)[0]).Text = "Periodo de Presentación:";
                ((Label)main.Controls.Find("lblPotential",true)[0]).Text = "Potencial Actual:";

                ((ToolStripLabel)((ToolStrip)main.Controls.Find("toolStripMenu", true)[0]).Items.Find("toolStripLabel1", true)[0]).Text = "Tiempo de Simulación:";
                
                TreeView tree = (TreeView)main.Controls.Find("treeView1", true)[0];
                tree.Nodes[0].Text = "Proceso de Symulación";
                tree.Nodes[0].Nodes[0].Text = "Opciones de Symulacion";
                tree.Nodes[0].Nodes[1].Text = "Fuente de Datos";
                tree.Nodes[0].Nodes[2].Text = "Codigo de Entrada";
                tree.Nodes[0].Nodes[3].Text = "Inicialización de Red";
                tree.Nodes[0].Nodes[4].Text = "Norma de Saber";
                tree.Nodes[0].Nodes[5].Text = "Symulacion";
            }
        }
        public void toogleLanguageSplash(SNN.OtherForms.Splash splash)
        {
            if (Properties.Settings.Default.applicationLanguage == 0) //ENG
            {
                splash.Text = "Getting Started";
                ((GroupBox)splash.Controls.Find("lblSplashIntroduction", true)[0]).Text = "Select Application mode:";
                ((Button)splash.Controls.Find("btnSplashBrowse", true)[0]).Text = "Browse...";
                ((RadioButton)splash.Controls.Find("radioSplashOpen", true)[0]).Text = "Open Existing Network:";
                ((RadioButton)splash.Controls.Find("radioSplashNew", true)[0]).Text = "Design New Network:";

                ((RadioButton)splash.Controls.Find("radioSplashSpikingMode", true)[0]).Text = "Spiking Network Mode(default)";
                ((RadioButton)splash.Controls.Find("radioSplashArtificMode", true)[0]).Text = "Artificial Network Mode";
                
            }
            if (Properties.Settings.Default.applicationLanguage == 1) //POL
            {
                splash.Text = "Rozpocznij";

                ((GroupBox)splash.Controls.Find("lblSplashIntroduction", true)[0]).Text = "Wybierz tryb aplikacji:";
                ((Button)splash.Controls.Find("btnSplashBrowse", true)[0]).Text = "Przeglądaj...";
                ((RadioButton)splash.Controls.Find("radioSplashOpen", true)[0]).Text = "Otwórz Istniejący Projekt:";
                ((RadioButton)splash.Controls.Find("radioSplashNew", true)[0]).Text = "Stwórz Nową Sieć";

                ((RadioButton)splash.Controls.Find("radioSplashSpikingMode", true)[0]).Text = "Tryb Sieci Impulsowych(domyślnie)";
                ((RadioButton)splash.Controls.Find("radioSplashArtificMode", true)[0]).Text = "Tryb Sieci Szucznych";
            }
            if (Properties.Settings.Default.applicationLanguage == 2) //ESP
            {
                splash.Text = "Principio";
                ((GroupBox)splash.Controls.Find("lblSplashIntroduction", true)[0]).Text = "Escoge modo de Aplicación:";
                ((Button)splash.Controls.Find("btnSplashBrowse", true)[0]).Text = "Abrir...";
                ((RadioButton)splash.Controls.Find("radioSplashOpen", true)[0]).Text = "Abres el Proyecto Existente:";
                ((RadioButton)splash.Controls.Find("radioSplashNew", true)[0]).Text = "Creas Nuevo";

                ((RadioButton)splash.Controls.Find("radioSplashSpikingMode", true)[0]).Text = "Redes de Impulsos(Defecto)";
                ((RadioButton)splash.Controls.Find("radioSplashArtificMode", true)[0]).Text = "Redes Tradiciónal";
            }
        }
        public void toogleLanguageOptions(SNN.OtherForms.Tools.ApplicationOptions options)
        {
            if (Properties.Settings.Default.applicationLanguage == 0) //ENG
            {
                TreeView optionTree = ((TreeView)options.Controls.Find("optionTree", true)[0]);
                optionTree.Nodes[0].Text = "Environment";
                optionTree.Nodes[0].Nodes[0].Text = "General";
                optionTree.Nodes[0].Nodes[1].Text = "Coluors";
                optionTree.Nodes[0].Nodes[2].Text = "Paths";
                optionTree.Nodes[0].Nodes[3].Text = "Others";
                optionTree.Nodes[1].Text = "Simulation";
                optionTree.Nodes[1].Nodes[0].Text = "Neruon Behaviour";
                optionTree.Nodes[1].Nodes[1].Text = "Graphs & Plotting";
                optionTree.Nodes[2].Text = "VHDL Code Generator";

                ((Label)options.Controls.Find("lblGeneralTitle", true)[0]).Text = "General Environment Options:";
                ((Label)options.Controls.Find("lblClearRecent", true)[0]).Text = "Clear Recent Projects History";
                ((Button)options.Controls.Find("btnClearRecent", true)[0]).Text = "Clear";
                ((GroupBox)options.Controls.Find("groupOptionsRasterColors", true)[0]).Text = "Colours of Spike Raster Plots:";
                ((Label)options.Controls.Find("lblStandardPloterBar", true)[0]).Text = "Bars Colour for Input, Layer1, Output Plot Windows:";
                ((Label)options.Controls.Find("lblEntireActivityInputColor", true)[0]).Text = "Bars Colour for Input layer in Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Bars Colour fot Layer 1 in Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Bars Colour for Output layer in Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblOptionsPathStimuliSrc", true)[0]).Text = "Stimuli Source Directory:";
                ((Button)options.Controls.Find("btnStimuliSrcPath", true)[0]).Text = "Browse...";
                ((Label)options.Controls.Find("lblOptionSNNetworksPath", true)[0]).Text = "Structures Directory:";
                ((Button)options.Controls.Find("btnStimuliSNNPath", true)[0]).Text = "Browse...";
                ((Button)options.Controls.Find("btnStimuliOutputPath", true)[0]).Text = "Browse...";
                ((Label)options.Controls.Find("lblOptionOutputPath", true)[0]).Text = "Output Files Directory:";
                ((Label)options.Controls.Find("lblApplicationLanguage", true)[0]).Text = "Interface Language:";
                ((Label)options.Controls.Find("lblClearProperties", true)[0]).Text = "Restore Degault Properties";
                ((Button)options.Controls.Find("btnRestoreDefault", true)[0]).Text = "Restore";
                ((Label)options.Controls.Find("lblMaximumRecent", true)[0]).Text = "Maximum Number of Recent Files";
                ((Label)options.Controls.Find("lblOptionHardwarePath", true)[0]).Text = "VHDL Code Files Directory:";
                ((Button)options.Controls.Find("btnStimuliHardwarePath", true)[0]).Text = "Browse...";
                ((CheckBox)options.Controls.Find("checkBoxGenerateTestBench", true)[0]).Text = "Generate Sample Testbench";
                ((Label)options.Controls.Find("lblVHDLtitle", true)[0]).Text = "VHDL Code Generator Options";
                ((CheckBox)options.Controls.Find("checkBoxHeaderAdd", true)[0]).Text = "Add Header to Every VHDL file";


            }
            if (Properties.Settings.Default.applicationLanguage == 1) //POL
            {
                TreeView optionTree = ((TreeView)options.Controls.Find("optionTree", true)[0]);
                optionTree.Nodes[0].Text = "Środowisko";
                optionTree.Nodes[0].Nodes[0].Text = "Główne";
                optionTree.Nodes[0].Nodes[1].Text = "Kolory";
                optionTree.Nodes[0].Nodes[2].Text = "Foldery";
                optionTree.Nodes[0].Nodes[3].Text = "Pozostałe";
                optionTree.Nodes[1].Text = "Symulacja";
                optionTree.Nodes[1].Nodes[0].Text = "Zachowanie Neuronu";
                optionTree.Nodes[1].Nodes[1].Text = "Grafy i Plotery";
                optionTree.Nodes[2].Text = "Geberator kodu VHDL";

                ((Label)options.Controls.Find("lblGeneralTitle", true)[0]).Text = "Podstawowe Opcje Środowiska:";
                ((Label)options.Controls.Find("lblClearRecent", true)[0]).Text = "Wyczyść Liste Aktualnych Projektów";
                ((Button)options.Controls.Find("btnClearRecent", true)[0]).Text = "Wyczyść";
                ((GroupBox)options.Controls.Find("groupOptionsRasterColors", true)[0]).Text = "Kolory grafu Spike Raster:";
                ((Label)options.Controls.Find("lblStandardPloterBar", true)[0]).Text = "Kolory Dla Okien Warstw: Wejściowej, Layer1, Wyjściowej:";
                ((Label)options.Controls.Find("lblEntireActivityInputColor", true)[0]).Text = "Kolory dla Warstwy wejściowej w Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Kolory dla Warstwy 1 w Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Kolory dla Warstwy wyjściowej w Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblOptionsPathStimuliSrc", true)[0]).Text = "Folder plików z Bodźcami:";
                ((Button)options.Controls.Find("btnStimuliSrcPath", true)[0]).Text = "Przeglądaj...";
                ((Label)options.Controls.Find("lblOptionSNNetworksPath", true)[0]).Text = "Folder ze Strukturami:";
                ((Button)options.Controls.Find("btnStimuliSNNPath", true)[0]).Text = "Przeglądaj...";
                ((Button)options.Controls.Find("btnStimuliOutputPath", true)[0]).Text = "Przeglądaj...";
                ((Label)options.Controls.Find("lblOptionOutputPath", true)[0]).Text = "Folder z plikami Wyjściowymi:";
                ((Label)options.Controls.Find("lblApplicationLanguage", true)[0]).Text = "Język Interfejsu:";
                ((Label)options.Controls.Find("lblClearProperties", true)[0]).Text = "Przywróć Domyślne";
                ((Button)options.Controls.Find("btnRestoreDefault", true)[0]).Text = "Przywróć";
                ((Label)options.Controls.Find("lblMaximumRecent", true)[0]).Text = "Maksymalna liczba plikow historii";
                ((Label)options.Controls.Find("lblOptionHardwarePath", true)[0]).Text = "Folder plików VHDL:";
                ((Button)options.Controls.Find("btnStimuliHardwarePath", true)[0]).Text = "Przeglądaj...";
                ((CheckBox)options.Controls.Find("checkBoxGenerateTestBench", true)[0]).Text = "Generuj Przykładowy Testbench";
                ((Label)options.Controls.Find("lblVHDLtitle", true)[0]).Text = "Opcje generatora VHDL";
                ((CheckBox)options.Controls.Find("checkBoxHeaderAdd", true)[0]).Text = "Dodaj nagłówek do każdego pliku VHDL";
            }
            if (Properties.Settings.Default.applicationLanguage == 2) //ESP
            {
                TreeView optionTree = ((TreeView)options.Controls.Find("optionTree", true)[0]);
                optionTree.Nodes[0].Text = "Entorno";
                optionTree.Nodes[0].Nodes[0].Text = "General";
                optionTree.Nodes[0].Nodes[1].Text = "Colores";
                optionTree.Nodes[0].Nodes[2].Text = "Caminos";
                optionTree.Nodes[0].Nodes[3].Text = "Otros";
                optionTree.Nodes[1].Text = "Simulación";
                optionTree.Nodes[1].Nodes[0].Text = "Conducta de Neurona";
                optionTree.Nodes[1].Nodes[1].Text = "Grafica & Trazadores";
                optionTree.Nodes[2].Text = "Generator de VHDL";

                ((Label)options.Controls.Find("lblGeneralTitle", true)[0]).Text = "Geberal Opciones de Entorno:";
                ((Label)options.Controls.Find("lblClearRecent", true)[0]).Text = "Limpias Historia de Los Proyectos";
                ((Button)options.Controls.Find("btnClearRecent", true)[0]).Text = "Limpiar";
                ((GroupBox)options.Controls.Find("groupOptionsRasterColors", true)[0]).Text = "Colores de Spike Raster Plots:";
                ((Label)options.Controls.Find("lblStandardPloterBar", true)[0]).Text = "Colores de Lineas para Entrada, Capa 1, Salida Complotes:";
                ((Label)options.Controls.Find("lblEntireActivityInputColor", true)[0]).Text = "Colores de Lineas para Capa Entrada en Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Colores de Lineas para Capa 1 en Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Colores de Lineas para Capa Salida en Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblOptionsPathStimuliSrc", true)[0]).Text = "Directorio de fuente de los estímulos:";
                ((Button)options.Controls.Find("btnStimuliSrcPath", true)[0]).Text = "Abrir...";
                ((Label)options.Controls.Find("lblOptionSNNetworksPath", true)[0]).Text = "Estructura de Directorios:";
                ((Button)options.Controls.Find("btnStimuliSNNPath", true)[0]).Text = "Abrir...";
                ((Button)options.Controls.Find("btnStimuliOutputPath", true)[0]).Text = "Abrir...";
                ((Label)options.Controls.Find("lblOptionOutputPath", true)[0]).Text = "Directorias de Archivos de Salida:";
                ((Label)options.Controls.Find("lblApplicationLanguage", true)[0]).Text = "Idioma de Interface:";
                ((Label)options.Controls.Find("lblClearProperties", true)[0]).Text = "Restitur Opciones";
                ((Button)options.Controls.Find("btnRestoreDefault", true)[0]).Text = "Restitur";
                ((Label)options.Controls.Find("lblMaximumRecent", true)[0]).Text = "Maximum Numero de Archivos Recente";
                ((Label)options.Controls.Find("lblOptionHardwarePath", true)[0]).Text = "Directorio de VHDL Archivos:";
                ((Button)options.Controls.Find("btnStimuliHardwarePath", true)[0]).Text = "Abrir...";
                ((CheckBox)options.Controls.Find("checkBoxGenerateTestBench", true)[0]).Text = "Generes Muestra Testbench";
                ((Label)options.Controls.Find("lblVHDLtitle", true)[0]).Text = "Opciones de VHDL Generator";
                ((CheckBox)options.Controls.Find("checkBoxHeaderAdd", true)[0]).Text = "Añades Cabecera a VHDL Archivo";
            }
        }
        public void toogleLanguageOptions(SNN.OtherForms.Tools.ApplicationOptions options, int lang)
        {
            if (lang == 0) //ENG
            {
                TreeView optionTree = ((TreeView)options.Controls.Find("optionTree", true)[0]);
                optionTree.Nodes[0].Text = "Environment";
                optionTree.Nodes[0].Nodes[0].Text = "General";
                optionTree.Nodes[0].Nodes[1].Text = "Coluors";
                optionTree.Nodes[0].Nodes[2].Text = "Paths";
                optionTree.Nodes[0].Nodes[3].Text = "Others";
                optionTree.Nodes[1].Text = "Simulation";
                optionTree.Nodes[1].Nodes[0].Text = "Neruon Behaviour";
                optionTree.Nodes[1].Nodes[1].Text = "Graphs & Plotting";
                optionTree.Nodes[2].Text = "VHDL Code Generator";
                optionTree.Nodes[2].Nodes[0].Text = "Hardware Code Options";

                ((Label)options.Controls.Find("lblGeneralTitle", true)[0]).Text = "General Environment Options:";
                ((Label)options.Controls.Find("lblClearRecent", true)[0]).Text = "Clear Recent Projects History";
                ((Button)options.Controls.Find("btnClearRecent", true)[0]).Text = "Clear";
                ((GroupBox)options.Controls.Find("groupOptionsRasterColors", true)[0]).Text = "Colours of Spike Raster Plots:";
                ((Label)options.Controls.Find("lblStandardPloterBar", true)[0]).Text = "Bars Colour for Input, Layer1, Output Plot Windows:";
                ((Label)options.Controls.Find("lblEntireActivityInputColor", true)[0]).Text = "Bars Colour for Input layer in Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Bars Colour fot Layer 1 in Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Bars Colour for Output layer in Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblOptionsPathStimuliSrc", true)[0]).Text = "Stimuli Source Directory:";
                ((Button)options.Controls.Find("btnStimuliSrcPath", true)[0]).Text = "Browse...";
                ((Label)options.Controls.Find("lblOptionSNNetworksPath", true)[0]).Text = "Structures Directory:";
                ((Button)options.Controls.Find("btnStimuliSNNPath", true)[0]).Text = "Browse...";
                ((Button)options.Controls.Find("btnStimuliOutputPath", true)[0]).Text = "Browse...";
                ((Label)options.Controls.Find("lblOptionOutputPath", true)[0]).Text = "Output Files Directory:";
                ((Label)options.Controls.Find("lblApplicationLanguage", true)[0]).Text = "Interface Language:";
                ((Label)options.Controls.Find("lblClearProperties", true)[0]).Text = "Restore Degault Properties";
                ((Button)options.Controls.Find("btnRestoreDefault", true)[0]).Text = "Restore";
                ((Label)options.Controls.Find("lblMaximumRecent", true)[0]).Text = "Maximum Number of Recent Files";
                ((Label)options.Controls.Find("lblOptionHardwarePath", true)[0]).Text = "VHDL Code Files Directory:";
                ((Button)options.Controls.Find("btnStimuliHardwarePath", true)[0]).Text = "Browse...";
                ((CheckBox)options.Controls.Find("checkBoxGenerateTestBench", true)[0]).Text = "Generate Sample Testbench";
                ((Label)options.Controls.Find("lblVHDLtitle", true)[0]).Text = "VHDL Code Generator Options";
                ((CheckBox)options.Controls.Find("checkBoxHeaderAdd", true)[0]).Text = "Add Header to Every VHDL file";


            }
            if (lang == 1) //POL
            {
                TreeView optionTree = ((TreeView)options.Controls.Find("optionTree", true)[0]);
                optionTree.Nodes[0].Text = "Środowisko";
                optionTree.Nodes[0].Nodes[0].Text = "Główne";
                optionTree.Nodes[0].Nodes[1].Text = "Kolory";
                optionTree.Nodes[0].Nodes[2].Text = "Foldery";
                optionTree.Nodes[0].Nodes[3].Text = "Pozostałe";
                optionTree.Nodes[1].Text = "Symulacja";
                optionTree.Nodes[1].Nodes[0].Text = "Zachowanie Neuronu";
                optionTree.Nodes[1].Nodes[1].Text = "Grafy i Plotery";
                optionTree.Nodes[2].Text = "Generator kodu VHDL";
                optionTree.Nodes[2].Nodes[0].Text = "Opcje kodowania";


                ((Label)options.Controls.Find("lblGeneralTitle", true)[0]).Text = "Podstawowe Opcje Środowiska:";
                ((Label)options.Controls.Find("lblClearRecent", true)[0]).Text = "Wyczyść Liste Aktualnych Projektów";
                ((Button)options.Controls.Find("btnClearRecent", true)[0]).Text = "Wyczyść";
                ((GroupBox)options.Controls.Find("groupOptionsRasterColors", true)[0]).Text = "Kolory grafu Spike Raster:";
                ((Label)options.Controls.Find("lblStandardPloterBar", true)[0]).Text = "Kolory Dla Okien Warstw: Wejściowej, Layer1, Wyjściowej:";
                ((Label)options.Controls.Find("lblEntireActivityInputColor", true)[0]).Text = "Kolory dla Warstwy wejściowej w Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Kolory dla Warstwy 1 w Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Kolory dla Warstwy wyjściowej w Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblOptionsPathStimuliSrc", true)[0]).Text = "Folder plików z Bodźcami:";
                ((Button)options.Controls.Find("btnStimuliSrcPath", true)[0]).Text = "Przeglądaj...";
                ((Label)options.Controls.Find("lblOptionSNNetworksPath", true)[0]).Text = "Folder ze Strukturami:";
                ((Button)options.Controls.Find("btnStimuliSNNPath", true)[0]).Text = "Przeglądaj...";
                ((Button)options.Controls.Find("btnStimuliOutputPath", true)[0]).Text = "Przeglądaj...";
                ((Label)options.Controls.Find("lblOptionOutputPath", true)[0]).Text = "Folder z plikami Wyjściowymi:";
                ((Label)options.Controls.Find("lblApplicationLanguage", true)[0]).Text = "Język Interfejsu:";
                ((Label)options.Controls.Find("lblClearProperties", true)[0]).Text = "Przywróć Domyślne";
                ((Button)options.Controls.Find("btnRestoreDefault", true)[0]).Text = "Przywróć";
                ((Label)options.Controls.Find("lblMaximumRecent", true)[0]).Text = "Maksymalna liczba plikow historii";
                ((Label)options.Controls.Find("lblOptionHardwarePath", true)[0]).Text = "Folder plików VHDL:";
                ((Button)options.Controls.Find("btnStimuliHardwarePath", true)[0]).Text = "Przeglądaj...";
                ((CheckBox)options.Controls.Find("checkBoxGenerateTestBench", true)[0]).Text = "Generuj Przykładowy Testbench";
                ((Label)options.Controls.Find("lblVHDLtitle", true)[0]).Text = "Opcje generatora VHDL";
                ((CheckBox)options.Controls.Find("checkBoxHeaderAdd", true)[0]).Text = "Dodaj nagłówek do każdego pliku VHDL";
            }
            if (lang == 2) //ESP
            {
                TreeView optionTree = ((TreeView)options.Controls.Find("optionTree", true)[0]);
                optionTree.Nodes[0].Text = "Entorno";
                optionTree.Nodes[0].Nodes[0].Text = "General";
                optionTree.Nodes[0].Nodes[1].Text = "Colores";
                optionTree.Nodes[0].Nodes[2].Text = "Caminos";
                optionTree.Nodes[0].Nodes[3].Text = "Otros";
                optionTree.Nodes[1].Text = "Simulación";
                optionTree.Nodes[1].Nodes[0].Text = "Conducta de Neurona";
                optionTree.Nodes[1].Nodes[1].Text = "Grafica & Trazadores";
                optionTree.Nodes[2].Text = "Generator de VHDL";
                optionTree.Nodes[2].Nodes[0].Text = "Opciones de Codigó de Hardware";

                ((Label)options.Controls.Find("lblGeneralTitle", true)[0]).Text = "Geberal Opciones de Entorno:";
                ((Label)options.Controls.Find("lblClearRecent", true)[0]).Text = "Limpias Historia de Los Proyectos";
                ((Button)options.Controls.Find("btnClearRecent", true)[0]).Text = "Limpiar";
                ((GroupBox)options.Controls.Find("groupOptionsRasterColors", true)[0]).Text = "Colores de Spike Raster Plots:";
                ((Label)options.Controls.Find("lblStandardPloterBar", true)[0]).Text = "Colores de Lineas para Entrada, Capa 1, Salida Complotes:";
                ((Label)options.Controls.Find("lblEntireActivityInputColor", true)[0]).Text = "Colores de Lineas para Capa Entrada en Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Colores de Lineas para Capa 1 en Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblEntireActivityLayer1Color", true)[0]).Text = "Colores de Lineas para Capa Salida en Entire Activity Raster Plot:";
                ((Label)options.Controls.Find("lblOptionsPathStimuliSrc", true)[0]).Text = "Directorio de fuente de los estímulos:";
                ((Button)options.Controls.Find("btnStimuliSrcPath", true)[0]).Text = "Abrir...";
                ((Label)options.Controls.Find("lblOptionSNNetworksPath", true)[0]).Text = "Estructura de Directorios:";
                ((Button)options.Controls.Find("btnStimuliSNNPath", true)[0]).Text = "Abrir...";
                ((Button)options.Controls.Find("btnStimuliOutputPath", true)[0]).Text = "Abrir...";
                ((Label)options.Controls.Find("lblOptionOutputPath", true)[0]).Text = "Directorias de Archivos de Salida:";
                ((Label)options.Controls.Find("lblApplicationLanguage", true)[0]).Text = "Idioma de Interface:";
                ((Label)options.Controls.Find("lblClearProperties", true)[0]).Text = "Restitur Opciones";
                ((Button)options.Controls.Find("btnRestoreDefault", true)[0]).Text = "Restitur";
                ((Label)options.Controls.Find("lblMaximumRecent", true)[0]).Text = "Maximum Numero de Archivos Recente";
                ((Label)options.Controls.Find("lblOptionHardwarePath", true)[0]).Text = "Directorio de VHDL Archivos:";
                ((Button)options.Controls.Find("btnStimuliHardwarePath", true)[0]).Text = "Abrir...";
                ((CheckBox)options.Controls.Find("checkBoxGenerateTestBench", true)[0]).Text = "Generes Muestra Testbench";
                ((Label)options.Controls.Find("lblVHDLtitle", true)[0]).Text = "Opciones de VHDL Generator";
                ((CheckBox)options.Controls.Find("checkBoxHeaderAdd", true)[0]).Text = "Añades Cabecera a VHDL Archivo";
            }
        }
        public void toogleLanguageGaussian(SNN.OtherForms.Tools.Gaussian gauss)
        {
            if (Properties.Settings.Default.applicationLanguage == 0) //ENG
            {
                ((GroupBox)gauss.Controls.Find("groupBoxParameters", true)[0]).Text = "Parameters";
                ((Label)gauss.Controls.Find("lblValueRange", true)[0]).Text = "Value Range:";
                ((Label)gauss.Controls.Find("lblRangeFrom", true)[0]).Text = "From(minumum):";                                        
                ((Label)gauss.Controls.Find("lblRangeTo", true)[0]).Text = "To(maximum):";                                    
                ((Label)gauss.Controls.Find("lblGammaParameter", true)[0]).Text = "Gamma parameter";
                ((Label)gauss.Controls.Find("lblMaximumTime", true)[0]).Text = "Maximum time:";
                ((Label)gauss.Controls.Find("lblFieldsNumber", true)[0]).Text = "Number of receptive fields:";
                ((Button)gauss.Controls.Find("button2", true)[0]).Text = "Draw";
                ((GroupBox)gauss.Controls.Find("groupBoxEncoding", true)[0]).Text = "Encoding";
                ((Button)gauss.Controls.Find("button1", true)[0]).Text = "Calculate";
                ((Label)gauss.Controls.Find("lblValue", true)[0]).Text = "Value";
                ((Label)gauss.Controls.Find("lblResult", true)[0]).Text = "Result";

            }
            if (Properties.Settings.Default.applicationLanguage == 1) //POL
            {
                ((GroupBox)gauss.Controls.Find("groupBoxParameters", true)[0]).Text = "Parametry";
                ((Label)gauss.Controls.Find("lblValueRange", true)[0]).Text = "Zakres Wartości:";
                ((Label)gauss.Controls.Find("lblRangeFrom", true)[0]).Text = "Od(minumum):";
                ((Label)gauss.Controls.Find("lblRangeTo", true)[0]).Text = "Do(maksimum):";
                ((Label)gauss.Controls.Find("lblGammaParameter", true)[0]).Text = "Parametr Gamma";
                ((Label)gauss.Controls.Find("lblMaximumTime", true)[0]).Text = "Czas maks:";
                ((Label)gauss.Controls.Find("lblFieldsNumber", true)[0]).Text = "Liczba Pól:";
                ((Button)gauss.Controls.Find("button2", true)[0]).Text = "Rysuj";
                ((GroupBox)gauss.Controls.Find("groupBoxEncoding", true)[0]).Text = "Kodowanie";
                ((Button)gauss.Controls.Find("button1", true)[0]).Text = "Oblicz";
                ((Label)gauss.Controls.Find("lblValue", true)[0]).Text = "Wartość";
                ((Label)gauss.Controls.Find("lblResult", true)[0]).Text = "Wynik";
            }
            if (Properties.Settings.Default.applicationLanguage == 2) //ESP
            {
                ((GroupBox)gauss.Controls.Find("groupBoxParameters", true)[0]).Text = "Parametros";
                ((Label)gauss.Controls.Find("lblValueRange", true)[0]).Text = "Valor Limite:";
                ((Label)gauss.Controls.Find("lblRangeFrom", true)[0]).Text = "Desde(minumum):";
                ((Label)gauss.Controls.Find("lblRangeTo", true)[0]).Text = "Hasta(maximum):";
                ((Label)gauss.Controls.Find("lblGammaParameter", true)[0]).Text = "Gamma parametro";
                ((Label)gauss.Controls.Find("lblMaximumTime", true)[0]).Text = "Maximum tiempo:";
                ((Label)gauss.Controls.Find("lblFieldsNumber", true)[0]).Text = "Numero de Campo Receptivo:";
                ((Button)gauss.Controls.Find("button2", true)[0]).Text = "Dibujar";
                ((GroupBox)gauss.Controls.Find("groupBoxEncoding", true)[0]).Text = "Codificación";
                ((Button)gauss.Controls.Find("button1", true)[0]).Text = "Calculas";
                ((Label)gauss.Controls.Find("lblValue", true)[0]).Text = "Valor";
                ((Label)gauss.Controls.Find("lblResult", true)[0]).Text = "Resultado";
            }
        }
        public void toogleLanguageStimuliCreator(SNN.OtherForms.Tools.StimuliCreator creator)
        {
            if (Properties.Settings.Default.applicationLanguage == 0) //ENG
            {
                ((Label)creator.Controls.Find("lblOneEopchTitle",true)[0]).Text = "Structure of Single Epoch:";
                ((Label)creator.Controls.Find("lblNumberOfEpochs", true)[0]).Text = "Number of Epochs:";

                ((Button)creator.Controls.Find("btnGenerateFile", true)[0]).Text = "Generate";
                ((Button)creator.Controls.Find("btnAdd", true)[0]).Text = "Add";
                ((Button)creator.Controls.Find("btnClear", true)[0]).Text = "Clear";
                ((Button)creator.Controls.Find("btnRemove", true)[0]).Text = "Remove";

                ((Label)creator.Controls.Find("lblInputDimensionTitle", true)[0]).Text = "Character Dimensions:";

            }
            if (Properties.Settings.Default.applicationLanguage == 1) //POL
            {
                ((Label)creator.Controls.Find("lblOneEopchTitle", true)[0]).Text = "Struktura Pojedynczego Epoch'a:";
                ((Label)creator.Controls.Find("lblNumberOfEpochs", true)[0]).Text = "Liczba Epoch'ów:";

                ((Button)creator.Controls.Find("btnGenerateFile", true)[0]).Text = "Generuj";
                ((Button)creator.Controls.Find("btnAdd", true)[0]).Text = "Dodaj";
                ((Button)creator.Controls.Find("btnClear", true)[0]).Text = "Wyczyść";
                ((Button)creator.Controls.Find("btnRemove", true)[0]).Text = "Usuń";

                ((Label)creator.Controls.Find("lblInputDimensionTitle", true)[0]).Text = "Wymiary Znaku:";
            }
            if (Properties.Settings.Default.applicationLanguage == 2) //ESP
            {
                ((Label)creator.Controls.Find("lblOneEopchTitle", true)[0]).Text = "Etructura de Individual Epoch:";
                ((Label)creator.Controls.Find("lblNumberOfEpochs", true)[0]).Text = "Numero de Epochs:";

                ((Button)creator.Controls.Find("btnGenerateFile", true)[0]).Text = "Generar";
                ((Button)creator.Controls.Find("btnAdd", true)[0]).Text = "Ańadir";
                ((Button)creator.Controls.Find("btnClear", true)[0]).Text = "Clear";
                ((Button)creator.Controls.Find("btnRemove", true)[0]).Text = "Tachar";

                ((Label)creator.Controls.Find("lblInputDimensionTitle", true)[0]).Text = "Dimensión de Carácter:";
            }
        }
        public void togleLanguageGenerator(SNN.OtherForms.Tools.Generator generator)
        {
            if (Properties.Settings.Default.applicationLanguage == 0) //ENG
            {
                ((Label)generator.Controls.Find("lblGeneratorTitle", true)[0]).Text = "Generate to location:";
                ((Button)generator.Controls.Find("btnGenerateBrowse", true)[0]).Text = "Browse...";
                ((Label)generator.Controls.Find("lblGenerateProgress", true)[0]).Text = "Progress:";
                ((Button)generator.Controls.Find("btnGenerateGo", true)[0]).Text = "Generate Files";
                ((Button)generator.Controls.Find("btnGenerateExplore", true)[0]).Text = "Explore Location";
                ((Button)generator.Controls.Find("btnGeberateClose", true)[0]).Text = "Close";
                
            }
            if (Properties.Settings.Default.applicationLanguage == 1) //POL
            {
                ((Label)generator.Controls.Find("lblGeneratorTitle", true)[0]).Text = "Wygeneruj do folderu:";
                ((Button)generator.Controls.Find("btnGenerateBrowse", true)[0]).Text = "Przeglądaj...";
                ((Label)generator.Controls.Find("lblGenerateProgress", true)[0]).Text = "Postęp:";
                ((Button)generator.Controls.Find("btnGenerateGo", true)[0]).Text = "Generuj Pliki";
                ((Button)generator.Controls.Find("btnGenerateExplore", true)[0]).Text = "Przeglądaj Folder";
                ((Button)generator.Controls.Find("btnGeberateClose", true)[0]).Text = "Zamknij";
            }
            if (Properties.Settings.Default.applicationLanguage == 2) //ESP
            {
                ((Label)generator.Controls.Find("lblGeneratorTitle", true)[0]).Text = "Generas a locación:";
                ((Button)generator.Controls.Find("btnGenerateBrowse", true)[0]).Text = "Abrir...";
                ((Label)generator.Controls.Find("lblGenerateProgress", true)[0]).Text = "Progreso:";
                ((Button)generator.Controls.Find("btnGenerateGo", true)[0]).Text = "Generas los Archivos";
                ((Button)generator.Controls.Find("btnGenerateExplore", true)[0]).Text = "Exploras Situación";
                ((Button)generator.Controls.Find("btnGeberateClose", true)[0]).Text = "Generas";
            }
        }
    }
}
