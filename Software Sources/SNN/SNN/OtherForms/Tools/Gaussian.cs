using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace SNN.OtherForms.Tools
{
    public partial class Gaussian : Form
    {
            double gamma;
            double max, min;
            double value;
            double maxTime;
            int fields;
            List<Color> colors;
            Boolean calculated; //helps to remove previous 'vertical' curve
            SNN.LanguagePack.Messages appMessages = new SNN.LanguagePack.Messages();
            public Gaussian()
            {
                InitializeComponent();
                SNN.LanguagePack.ControlsLanguage changeLanguage = new SNN.LanguagePack.ControlsLanguage();
                changeLanguage.toogleLanguageGaussian(this);
                this.colors = this.chartsColors();
                this.calculated = false;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = "";
                this.value = Convert.ToDouble(this.maskedBoxValue.Text);
                this.drawGaussianFields(this.gaussianGraph);
                this.drawVertical(this.gaussianGraph);
                this.gaussianGraph.Refresh();
                double y;

                double width;
                double center;
                double delay;

                if ((value > this.max) || (value < this.min))
                {
                    DialogResult dresult = MessageBox.Show(this.appMessages.gaussianOutOfRange[Properties.Settings.Default.applicationLanguage], this.appMessages.gaussianOutOfRangeTitle[Properties.Settings.Default.applicationLanguage], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dresult == DialogResult.OK)
                    {

                    }
                    else
                    {
                    }
                }
                else
                {
                    for (int i = 0; i < this.fields; i++)
                    {

                        center = this.min + ((2 * i) - 3) / 2 * ((this.max - this.min) / (this.fields - 2));
                        width = (1 / this.gamma) * ((this.max - this.min) / (this.fields - 2));

                        y = Math.Exp(-(Math.Pow(this.value - center, 2) / Math.Pow(width, 2)) / 2);
                        delay = (this.maxTime - (Math.Round(y, 4) * this.maxTime));
                        if (delay <= (0 + (this.maxTime / 100)))
                            delay = 1;
                        if (delay == maxTime)
                            delay = 0;   //neuron will not fire
                        if (delay >= (this.maxTime - (this.maxTime / 100)))
                            delay = this.maxTime;
                        richTextBox1.Text = richTextBox1.Text + "Field " + (i).ToString() + ": " + (Math.Round(y, 4)).ToString() + " = delay: " + (delay).ToString() + Environment.NewLine;
                    }
                }

            }

            private List<Color> chartsColors()
            {
                List<Color> list = new List<Color>();
                list.Add(Color.Red);
                list.Add(Color.Blue);
                list.Add(Color.Black);
                list.Add(Color.Green);
                list.Add(Color.Navy);
                list.Add(Color.Orange);
                list.Add(Color.Violet);
                list.Add(Color.Yellow);
                list.Add(Color.Pink);
                list.Add(Color.Lime); //10
                list.Add(Color.Indigo);
                list.Add(Color.GreenYellow);
                list.Add(Color.DarkViolet);
                list.Add(Color.Aqua);
                list.Add(Color.DarkRed);
                list.Add(Color.Chocolate);
                list.Add(Color.Coral);
                list.Add(Color.DeepSkyBlue);
                list.Add(Color.DimGray);
                list.Add(Color.LightGoldenrodYellow);//20

                return list;
            }
            public void drawGaussianFields(ZedGraphControl zgc)
            {
                GraphPane myPane = zgc.GraphPane;
                myPane.CurveList.Clear();
                myPane.Title.Text = "Gaussian RF";

                PointPairList[] fieldsPoints = new PointPairList[this.fields];
                LineItem[] fieldCurves = new LineItem[this.fields];
                double width;
                double center;
                double y;
                for (int i = 0; i < this.fields; i++)
                {

                    center = this.min + ((2 * i) - 3) / 2 * ((this.max - this.min) / (this.fields - 2));
                    width = (1 / this.gamma) * ((this.max - this.min) / (this.fields / 2));
                    fieldsPoints[i] = new PointPairList();
                    for (double k = this.min; k <= this.max; k = k + 0.1)
                    {
                        y = Math.Exp(-(Math.Pow(k - center, 2) / Math.Pow(width, 2)) / 2);
                        fieldsPoints[i].Add(k, y);
                    }
                }
                for (int i = 0; i < this.fields; i++)
                {
                    fieldCurves[i] = new LineItem((i).ToString());
                    if (i < this.colors.Count)
                    {
                        fieldCurves[i] = myPane.AddCurve((i).ToString(), fieldsPoints[i], this.colors[i], SymbolType.None);
                    }
                    else
                    {
                        fieldCurves[i] = myPane.AddCurve((i).ToString(), fieldsPoints[i], Color.Black, SymbolType.None);
                    }
                    fieldCurves[i].Line.Width = 1.0F;
                    fieldCurves[i].Line.IsAntiAlias = true;
                    fieldCurves[i].Symbol.Fill = new Fill(Color.White);
                    fieldCurves[i].Symbol.Size = 4;
                    fieldCurves[i].Line.IsSmooth = true;
                    fieldCurves[i].Line.SmoothTension = 0.5F;
                }


                myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);

                // Show the X and Y grids
                myPane.XAxis.MajorGrid.IsVisible = true;
                myPane.YAxis.MajorGrid.IsVisible = false;
                myPane.XAxis.Scale.Min = this.min;
                myPane.XAxis.Scale.Max = this.max;

                myPane.YAxis.Scale.Min = 0;
                myPane.YAxis.Scale.Max = 1.1;
                // Set the x and y scale and title font sizes to 14
                myPane.XAxis.Scale.FontSpec.Size = 14;
                myPane.XAxis.Title.FontSpec.Size = 14;
                myPane.YAxis.Scale.FontSpec.Size = 14;
                myPane.YAxis.Title.FontSpec.Size = 14;
                // Set the GraphPane title font size to 16
                myPane.Title.FontSpec.Size = 16;
                // Turn off the legend
                myPane.Legend.IsVisible = true;

                // Fill the axis background with a color gradient
                myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);

                // Calculate the Axis Scale Ranges
                zgc.AxisChange();
            }

            private void drawVertical(ZedGraphControl zgc)
            {
                GraphPane myPane = zgc.GraphPane;

                PointPairList pointPairList = new PointPairList();

                pointPairList.Add(this.value, 0);
                pointPairList.Add(this.value, 2);

                LineItem myCurve = myPane.AddCurve(this.value.ToString(), pointPairList, Color.Black, SymbolType.None);
                myCurve.Line.Width = 2.0F;
                zgc.AxisChange();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (Convert.ToInt32(this.maskedBoxFieldsNumber.Text) <= 2)
                {
                    MessageBox.Show(this.appMessages.wrongReceptiveFields[Properties.Settings.Default.applicationLanguage], this.appMessages.wrongReceptiveFieldsTitle[Properties.Settings.Default.applicationLanguage], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dres = DialogResult.Yes;
                    try
                    {
                        this.gamma = Convert.ToDouble(this.maskedBoxGamma.Text);
                        this.min = Convert.ToDouble(this.maskedBoxMinimum.Text);
                        this.max = Convert.ToDouble(this.maskedBoxMaximum.Text);
                        this.maxTime = Convert.ToDouble(this.maskedBoxMaxTime.Text);
                        this.fields = Convert.ToInt32(this.maskedBoxFieldsNumber.Text);
                    }
                    catch (Exception excc)
                    {
                        dres = MessageBox.Show(this.appMessages.missingValue[Properties.Settings.Default.applicationLanguage], this.appMessages.missingValueTitle[Properties.Settings.Default.applicationLanguage], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    this.drawGaussianFields(this.gaussianGraph);
                    this.gaussianGraph.Refresh();
                }


            }
        
    }
}
