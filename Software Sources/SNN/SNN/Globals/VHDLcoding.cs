using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNN.Globals
{
    public class VHDLcoding
    {
        int wordLength;
        int bitsCoding;
        int rangeFrom;
        int rangeTo;
        int frequencyDiv;
        bool pspReal;
        int pspDuration;
        double pspStep;
        string zeroWord;
        string pspFunctionValues;
        int refractoryDuration;
        Boolean addHeader;
        String header;

        public VHDLcoding()
        {
            this.header = "";
            this.addHeader = false;
            this.wordLength = 44;
            this.bitsCoding = 20;
            this.rangeFrom = -3;
            this.rangeTo = 3;
            this.frequencyDiv = 100000;
            this.pspReal = false;
            this.pspDuration = 25;
            this.pspStep = Convert.ToDouble("1,0");
            this.zeroWord = "";
            this.pspFunctionValues = "";
            this.refractoryDuration = 60;
        }
        public string headerValue
        {
            get { return this.header; }
            set { this.header = value; }
        }
        public int wordLenghtValue
        {
            get { return this.wordLength; }
            set { this.wordLength = value; }
        }
        public int bitsCodingValue
        {
            get { return this.bitsCoding; }
            set { this.bitsCoding = value; }
        }
        public int rangeFromValue
        {
            get { return this.rangeFrom; }
            set { this.rangeFrom = value; }
        }
        public int rangeToValue
        {
            get { return this.rangeTo; }
            set { this.rangeTo = value; }
        }
        public int freqDivValue
        {
            get { return this.frequencyDiv; }
            set { this.frequencyDiv = value; }
        }
        public bool pspRealValue
        {
            get { return this.pspReal; }
            set { this.pspReal = value; }
        }
        public Boolean addHeaderValue
        {
            get { return this.addHeader; }
            set { this.addHeader = value; }
        }
        public int pspDurationValue
        {
            get { return this.pspDuration; }
            set { this.pspDuration = value; }
        }
        public double pspStepValue
        {
            get { return this.pspStep; }
            set { this.pspStep = value; }
        }
        public string zeroValue
        {
            get { return this.zeroWord; }
            set { this.zeroWord = value; }
        }
        public string pspFunctionValuesValue
        {
            get { return this.pspFunctionValues; }
            set { this.pspFunctionValues = value; }
        }
        public int refractoryDurationValue
        {
            get { return this.refractoryDuration; }
            set { this.refractoryDuration = value; }
        }
    }
}
