using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using ZedGraph;


namespace MethodsLibrary
{
    public class Methods
    {
        #region MethodClassVariables

           // private List<System.Drawing.Color> colorsList = new List<System.Drawing.Color>();
           

        #endregion MethodClassVariables

        public Methods()
        {
           // this.colorsList = this.GetColors();
        }

        #region MethodsDefinition

        static public int getInputNumberFromSpikeList(List<List<int>> list, int toSearch)
        {//method to obtain input from which given spike is
            int found = 0;
            bool flag = false;
            int i = 0;
            while ((flag == false) && (i < list.Count))
            {
                int k = 0;
                while ((flag == false) && (k < list[i].Count))
                {
                    if (toSearch == list[i][k])
                    {
                        found = i;
                        flag = true;
                    }
                    k++;
                }
                i++;
            }
            return found;
        }
        static public void DrawGraph(ZedGraph.ZedGraphControl zgc, int whichNo, ZedGraph.PointPairList pointsList, List<List<int>> SpikesDictionary, bool ColorBlack, List<System.Drawing.Color> colors, int scale)
        {//method to plot neuron potential; it can plot it in both color and black
            GraphPane grafPanel = zgc.GraphPane;

            grafPanel.Title.Text = "Membrane potential";
            grafPanel.XAxis.Title.Text = "t[ms]";
            grafPanel.YAxis.Title.Text = "u(t)";
            grafPanel.YAxis.Scale.Min = -0.3;
            grafPanel.Y2Axis.Scale.MajorStep = 0.01;

            grafPanel.YAxis.Scale.Max = 2;
           
            grafPanel.Legend.IsVisible = false;
            grafPanel.XAxis.Scale.IsVisible = false;

            List<System.Drawing.Color> colorsList = colors;
            
            Color color = Color.Black;
            if (ColorBlack == true)
            {
                int inputNo;
                {//method to obtain input from which given spike is
                    int found = 0;
                    bool flag = false;
                    int i = 0;
                    while ((flag == false) && (i < SpikesDictionary.Count))
                    {
                        int k = 0;
                        while ((flag == false) && (k < SpikesDictionary[i].Count))
                        {
                            if (whichNo == SpikesDictionary[i][k])
                            {
                                found = i;
                                flag = true;
                            }
                            k++;
                        }
                        i++;
                    }
                    inputNo = found;
                }          
                if (inputNo >= 71)
                    inputNo = 2;//black
                color = colorsList[inputNo];
            }
            if (pointsList.Count > 0)
            {
                grafPanel.XAxis.Scale.Max = pointsList[pointsList.Count - 1].X + 20;
                if (grafPanel.XAxis.Scale.Max < scale)
                    grafPanel.XAxis.Scale.Max = scale;
                LineItem myCurve = grafPanel.AddCurve("EPSP " + whichNo.ToString(), pointsList, color, SymbolType.None);
            }
            if(scale == 0)
                grafPanel.XAxis.Scale.Min = 0;
            else
                if(grafPanel.XAxis.Scale.Max > scale)
                    grafPanel.XAxis.Scale.Min = grafPanel.XAxis.Scale.Max - scale;
            zgc.AxisChange();
        }
        static public List<System.Drawing.Color> GetColors()
        {//method to obtain list of colors(list is limited to color with brightness higher than 0.6 for better recognition 
            List<System.Drawing.Color> colors = new List<System.Drawing.Color>();
            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            foreach (string colorName in colorNames)
            {
                KnownColor knownColor = (KnownColor)Enum.Parse(typeof(KnownColor), colorName);
                if (knownColor > KnownColor.Transparent)
                {
                    if ((knownColor != KnownColor.White) && (knownColor != KnownColor.AntiqueWhite))
                    {
                        System.Drawing.Color col = Color.FromName(colorName);
                        if (col.GetBrightness() < 0.6)
                            colors.Add(col);
                    }
                }
            }
            return colors;
        }        
        static public BitArray bitsConverter(int value)
        {//method to convert integer value into BitAttay
            byte[] byteTab = System.BitConverter.GetBytes(value);
            BitArray array = new BitArray(byteTab);
            return array;
        }
        
        #endregion MethodsDefinition

    }
}
