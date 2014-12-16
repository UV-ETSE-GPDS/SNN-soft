using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ZedGraph;
using SNN.Globals;
using SNN.StructureElements;

namespace SNN.Logic
{
    class Graphs
    {
        Variables variables;
        Flags flags;

        public Graphs(Variables globalVariables, Flags globalFlags)
        {
            this.variables = globalVariables;
            this.flags = globalFlags;
        }
        #region HistoryMethods

        public void CreateChart(ZedGraphControl zgc, List<PictureBox> layerToPlot, int whichLayer, Color graphColor) //whichLayer: 0 = input, 1 = layer1, 2 - output
        {
            GraphPane myPane = zgc.GraphPane;
            String layerName = "";
            // Set the title and axis labels
            myPane.Title.Text = "InputSpikes";
            myPane.XAxis.Title.Text = "Time[ms]";
            myPane.YAxis.Title.Text = "Neurons";
            myPane.YAxis.Scale.BaseTic = 1;

            myPane.YAxis.Scale.MajorStep = 1.0;
            myPane.XAxis.Scale.MajorStep = 10.0;

            myPane.XAxis.Scale.BaseTic = 0;
            // Enter some calculated data constants
            PointPairList list1 = new PointPairList();

            if (whichLayer == 0)
            {
                layerName = "Input Layer";
                for (int i = 0; i < this.variables.numberInput; i++)
                {
                    InputNeuron iN = ((InputNeuron)this.variables.inputNeurons[i].Tag);
                    for (int k = 0; k < iN.history.Count; k++)
                    {
                        list1.Add(iN.history[k], i + 1, 0);
                        if (this.variables.maxHist < iN.history[k])
                            this.variables.maxHist = iN.history[k];
                    }
                }
            }
            else
            {//distinguish if it's layer1, ouput or so
                if (whichLayer == 1)
                {
                    layerName = "First Layer";
                    for (int i = 0; i < this.variables.numberLayer1; i++)
                    {
                        Neuron iN = ((Neuron)this.variables.layer1[i].Tag);
                        for (int k = 0; k < iN.history.Count; k++)
                        {
                            list1.Add(iN.history[k], i + 1, 0);
                            if (this.variables.maxHist < iN.history[k])
                                this.variables.maxHist = iN.history[k];
                        }
                    }
                }
                if (whichLayer == 2)
                {
                    layerName = "Output Layer";
                    for (int i = 0; i < this.variables.numberOutput; i++)
                    {
                        Neuron iN = ((Neuron)this.variables.output[i].Tag);
                        for (int k = 0; k < iN.history.Count; k++)
                        {
                            list1.Add(iN.history[k], i + 1, 0);
                            if (this.variables.maxHist < iN.history[k])
                                this.variables.maxHist = iN.history[k];
                        }
                    }
                }
            }

            for (int i = 0; i <= this.variables.maxHist; i++)
            {
                var count = list1.Where(item => item.X == i).Count();
                this.variables.rateList.Add(i, count);
            }


            LineItem myCurve = myPane.AddCurve(layerName, list1, graphColor,
                                 SymbolType.VDash);
            //myCurve.Symbol.Size = 5;

            myCurve.Symbol.Fill = new Fill(Color.Black, Color.Red);
            // Turn off the symbol borders
            myCurve.Symbol.Border.IsVisible = true;
            myCurve.Symbol.Border.Width = 2;
            myCurve.Symbol.Fill.Type = FillType.GradientByZ;
            myCurve.Symbol.Fill.RangeMin = 0;
            myCurve.Symbol.Fill.RangeMax = 1;

            // Turn off the line, so the curve will by symbols only
            myCurve.Line.IsVisible = false;

            // Show the X and Y grids
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = false;

            // Set the x and y scale and title font sizes to 14
            myPane.XAxis.Scale.FontSpec.Size = 14;
            myPane.XAxis.Title.FontSpec.Size = 14;
            myPane.YAxis.Scale.FontSpec.Size = 14;
            myPane.YAxis.Title.FontSpec.Size = 14;


            myPane.XAxis.Scale.MaxAuto = true;
            myPane.XAxis.Scale.IsUseTenPower = true;
            myPane.XAxis.Scale.IsPreventLabelOverlap = true;
            myPane.XAxis.Scale.FormatAuto = true;
            myPane.XAxis.Scale.Min = 0;
            // Set the GraphPane title font size to 16
            myPane.Title.FontSpec.Size = 16;
            // Turn off the legend
            myPane.Legend.IsVisible = false;

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);

            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
            this.variables.maxHist = zgc.GraphPane.XAxis.Scale.Max;
        }
        public void CreateChartBottom(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "InputSpikes";
            myPane.XAxis.Title.Text = "Time[ms]";
            myPane.YAxis.Title.Text = "Spikes Number";
            myPane.YAxis.Scale.BaseTic = 1;

            myPane.YAxis.Scale.MajorStep = 1.0;
            myPane.XAxis.Scale.MajorStep = 10.0;

            myPane.XAxis.Scale.BaseTic = 0;
            // Enter some calculated data constants
            LineItem curve = myPane.AddCurve("label", this.variables.rateList, Color.Red, SymbolType.Circle);
            curve.Line.Width = 1.5F;
            curve.Line.IsAntiAlias = true;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.Size = 4;
            curve.Line.IsSmooth = true;
            curve.Line.SmoothTension = 0.5F;

            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);

            // Show the X and Y grids
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = false;

            // Set the x and y scale and title font sizes to 14
            myPane.XAxis.Scale.FontSpec.Size = 14;
            myPane.XAxis.Title.FontSpec.Size = 14;
            myPane.YAxis.Scale.FontSpec.Size = 14;
            myPane.YAxis.Title.FontSpec.Size = 14;
            // Set the GraphPane title font size to 16
            myPane.Title.FontSpec.Size = 16;
            // Turn off the legend
            myPane.Legend.IsVisible = false;

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            myPane.XAxis.Scale.Max = this.variables.maxHist;
            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
        }

        #endregion HistoryMethods
    }

}
