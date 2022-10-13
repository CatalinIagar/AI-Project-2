using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Prohect2
{
    public partial class HiddenLayerNeuron : Form
    {
        public string name;
        public Neuron neuron;
        public double[] returnValue;
        readonly List<Label> inputValues = new List<Label>();
        readonly List<Label> weightValues = new List<Label>();
        readonly List<TextBox> inputValuesTxt = new List<TextBox>();
        readonly List<NumericUpDown> weightsInputValues = new List<NumericUpDown>();
        public HiddenLayerNeuron(string name, Neuron neuron)
        {
            InitializeComponent();

            this.name = name;
            this.neuron = neuron;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Array.Resize(ref returnValue, neuron.nOfInputs);

            for (int i = 0; i < neuron.nOfInputs; i++)
            {
                Label inputLabel = new Label
                {
                    Text = "Input " + i
                };

                TextBox inputValueTxt = new TextBox
                {
                    Text = Convert.ToString(neuron.x[i]),
                    Size = new Size(55, 20),
                    Enabled = false
                };

                Label weightValue = new Label
                {
                    Text = "Synaptic Weight " + i
                };

                NumericUpDown weightInputValue = new NumericUpDown
                {
                    Value = (decimal)neuron.w[i],
                    DecimalPlaces = 2,
                    Increment = 0.01M,
                    Minimum = 0,
                    Maximum = 1,
                    Size = new Size(55, 20)
                };

                inputValues.Add(inputLabel);
                weightValues.Add(weightValue);
                inputValuesTxt.Add(inputValueTxt);
                weightsInputValues.Add(weightInputValue);

                flowLayoutPanel1.Controls.Add(inputLabel);
                flowLayoutPanel1.Controls.Add(inputValueTxt);
                flowLayoutPanel1.Controls.Add(weightValue);
                flowLayoutPanel1.Controls.Add(weightInputValue);
            }
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void RoundButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < weightsInputValues.Count; i++)
            {
                returnValue[i] = (double)weightsInputValues[i].Value;
            }
            this.DialogResult = DialogResult.OK;
        }
        private void HiddenLayerNeuron_Load(object sender, EventArgs e)
        {
            if (neuron.inputFunction == NeuronState.SUM) inputLbl.Text = "Suma";
            if (neuron.inputFunction == NeuronState.PROD) inputLbl.Text = "Produs";
            if (neuron.inputFunction == NeuronState.MAX) inputLbl.Text = "Maxim";
            if (neuron.inputFunction == NeuronState.MIN) inputLbl.Text = "Minim";

            if (neuron.activationFunction == NeuronState.TREAPTA) activationLbl.Text = "Treapta";
            if (neuron.activationFunction == NeuronState.SEMN) activationLbl.Text = "Semn";
            if (neuron.activationFunction == NeuronState.SIGM) activationLbl.Text = "Sigmoidala";
            if (neuron.activationFunction == NeuronState.TANH) activationLbl.Text = "TanH";
            if (neuron.activationFunction == NeuronState.LINIARA) activationLbl.Text = "Liniara";

            if (neuron.binaryState == NeuronState.BINARYFALSE) binaryLbl.Text = "False";
            if (neuron.binaryState == NeuronState.BINARYTRUE) binaryLbl.Text = "True";

            inputValue.Text = neuron.ginput.ToString();
            activationValue.Text = neuron.activation.ToString();
            outputValue.Text = neuron.output.ToString();
        }
    }
}