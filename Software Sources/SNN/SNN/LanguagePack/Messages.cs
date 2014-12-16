using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNN.LanguagePack
{
    public class Messages
    {
        //!!    Language Order: ENGLSIH, POLISH, SPANISH        !!

        public string[] projectNotSavedNotification = { "Do you want to save changes in current project? Unsaved data will be lost.", "Czy chcesz zapisać zmiany? Niezapisane informacje zostaną utracone.", "¿Usted desea ahorrar cambios en proyecto actual? Los datos Unsaved serán perdidos." };
        public string[] projectNotSavedNotificationTitle = { "Save Project", "Zapisz Projekt", "Salvar de Proyecto" };

        public string[] emptyDimensionBox = { "At least one of dimensions is not given. Please enter correct value for stimulus' dimensions", "Nie podano prawidłowych wymiarów. Popraw wymiary.", "Por lo menos una de dimensiones no se da. Incorpore por favor el valor correcto para las dimensiones de los estímulos " };
        public string[] emptyDimensionBoxTitle = { "Wrong Dimension Vlaue", "Błędna wartość", "Enquivocado Valor de Dimensión" };

        public string[] emptyLearningBox = { "At least one of Learning parameters is not given. Please enter correct value for all parameters", "Przynajmniej jeden z parametrów STDP jest niepoprawny. Wprowadz odpowiednie wartości.", "Por lo menos uno de parámetros que aprenden no se da. Incorpore por favor el valor correcto para todos los parámetros. " };
        public string[] emptyLearningBoxTitle = { "Wrong Learning Parameters", "Błędne Parametry", "Enquivocado Saber Parametros" };

        public string[] dimensionDontMatch = { "Given dimensions mismath number of input neurons. Insert Correct Values.", "Podane wymiary nie pokrywaja sie z liczba neuronów wejściowych. Popraw wymiary", "Número dado del mismath de las dimensiones de las neuronas de la entrada. Inserte los valores correctos. " };
        public string[] dimensionDomtMatchTitle = { "Wrong Dimensions Value", "Błędna Wartość", "Enquivocado Valor" };

        public string[] outputFileNotFound = { "Output file has not been selected, please indicate file to save network output.", "Plik wyjsciowy nie został wskazany. Wskaż plik, w którym zostaną zapisane dane wyjściowe.", "El archivo de salida no se ha seleccionado, indica por favor el archivo a la salida de ahorro de la red." };
        public string[] outputFileNotFoundTitle = { "No output file", "Brak Pliku Wyjściowego", "No Archivo de Entrada" };

        public string[] wrongFileFormat = { "Simulation Stoped. One of line inside Stimulation file has wrong format. Line lenght mismatch number of input neurons", "Symulacja zatrzymana. Jedna z lini pliku wejściowego ma nieprawidłowy format. Dlugosc lini nie odpowiada liczbie neuronów wejściowych.", "Simulación Stoped. Uno de la línea dentro del archivo del estímulo tiene formato incorrecto. Línea número de la unión mal hecha de la longitud de las neuronas de la entrada" };
        public string[] wrongFileFormatTitle = { "Wrong File Format", "Błędny Format Pliku", "Enquivocado Formato de Archivo" };

        public string[] simulationEnd = { "Simulation has been finished!", "Symulacja została zakończona.", "¡Se ha acabado la simulación!" };
        public string[] simulationEndTitle = { "End of Simulation", "Symulacja zakończona", "Fin de Simulación" };

        public string[] wrongEpochNumber = { "Minumum epoch number is 1. Please Enter a correct value.", "Plik musi zawierać conajmniej jeden Epoch. Wprowadz poprawna wartość", "El número de la época de Minumum es 1. Incorpore por favor un valor correcto." };
        public string[] wringEpochNumberTitle = { "Wrong Value", "Nieprawidłowa wartość.", "Enquivocado Valor" };

        public string[] wrongReceptiveFields = { "A number of receptive fields have to be greater than 2!", "Błędna wartość. Liczba pól receptorowych musi być wieksza niż 2", "Un número de campos receptivos tienen que ser 2 mayor que " };
        public string[] wrongReceptiveFieldsTitle = { "Wrong Value", "Nieprawidłowa wartość.", "Enquivocado Valor" };

        public string[] restoreDefaultWarning = { "You are about to resetore default application options. This action will reset every option, do you wish to continue?", "Czy na pewno chcesz wyzerować wszystkie opcje aplikacji?", "Usted está alrededor a las opciones del uso del defecto del resetore. ¿Esta acción reajustará cada opción, usted desea continuar?" };
        public string[] restoreDefaultWarningTitle = { "Restore Default", "Przywracanie Opcji Domyślnych", "Restore Valoras Defecto" };

        public string[] simulationInProgress = { "Simulation is running! Do you wish to stop simulation?", "Symulacja w toku! Czy chcesz zakończyć symulację?", "¡La simulación está funcionando! ¿Usted desea parar la simulación?" };
        public string[] simulationInProgressTitle = { "Simulation is running", "Symulacja w toku", "Simulación" };

        public string[] missingValue = { "At least one Parameter is missing. Please enter every parameter correctly ", "Brak przynajmniej jednego z parametrów. Wprowadź właściwe wartości", "Por lo menos un parámetro falta. Incorpore por favor cada parámetro correctamente" };
        public string[] missingValueTitle = { "Missing Parameter", "Brak Parametru", "No Parametro" };

        public string[] noHelpFile = { "Help File not found! Please reinstall application", "Nie znaleziono pliku pomocy! Przeinstaluj Aplikacje.", "¡Archivo de la ayuda no encontrado! Reinstale por favor el uso" };
        public string[] noHelpFileTitle = { "Help File Not Found", "Brak Pliku Pomocy", "No Archivos de la Ayuda" };

        public string[] noSrcFiles = { "VHDL source files have not been found. Please reinstall application.", "Nie znaleziono plików żródłowych VHDL! Przeinstaluj Aplikacje.", "Los archivos de fuente de VHDL no se han encontrado. Reinstale por favor el uso. " };
        public string[] noSrcFilesTitle = { "Files Not Found", "Brak Plików", "No Archivos" };

        public string[] noStructure = { "First Create or Load network Structure!", "Najpierw Utwórz lub wczytaj strukture sieci", "Los archivos de fuente de VHDL no se han encontrado. Reinstale por favor el uso." };
        public string[] noStructureTitle = { "No network structure", "Brak Struktury sieci", "" };

        public string[] codeGenerated = { "VHDL Code Has been generated successfully", "Pliki VHDL zostaly pomyślnie wygenerowane", "El código de VHDL se ha generado con éxito " };
        public string[] codeGeneratedTitle = { "Network Generated", "Siec Wygenerowana", "" };

        public string[] gaussianOutOfRange = { "Given value is out of range! Please Enter correct value", "Podana wartość jest z poza zakresu! Wprowadz poprawną wartość.", "¡El valor dado está fuera de gama! Incorpore por favor el valor correcto" };
        public string[] gaussianOutOfRangeTitle = { "Wrong Value", "Błędna Wartość", "Enquivocado Valor" };

        public string[] wrongNeuronNumber = { "At least one value is equal to 0. Enter correct value", "Przynajmniej jedna z wartości jest rowna 0. Wprowadz poprawną wartość", "Por lo menos un valor es igual a 0. Incorpore el valor correcto" };
        public string[] wrongNeuronNumberTitle = { "Wrong Value", "Błędna Wartość", "Enquivocado Valor" };


        public string[] potentialLabel = { "Current Potential: ", "Aktualny Potencjał: ", "Potencial Actual: " };
        public string[] inputName = { "input ", "wejście ", "entrada " };
        public string[] outputName = { "output ", "wyjście ", "salida " };
        public string[] layerName = { "layer ", "warstwa ", "capta " };
        public string[] delayName = { "Delay: ", "Opóźnienie: ", "Demorar: " };
        public string[] weightName = { "Weight: ", "Waga: ", "Peso: " };
        public string[] thresholdName = { "Threshold: ", "Próg: ", "Umbral: " };

        public string[] spikingModeName = { "Spiking mode(SNN)", "Tryb Impulsowy(SNN)", "Modo de Impulsos(SNN)" };
        public string[] artificialModeName = { "Artificial mode(ANN)", "Tryb Tradycyjny(ANN)", "Modo de Artificial(ANN)" };
        public string[] networkName = { "Neural Networks", "Sieci Neuronowe", "Redes Neuronales" };


        public string[] newProjectNotification = { "", "", "" };



        public Messages()
        {

        }


    }
}
