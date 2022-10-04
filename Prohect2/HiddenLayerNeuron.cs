using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prohect2
{
    public partial class HiddenLayerNeuron : Form
    {
        public string name;
        public Neuron neuron;
        public double[] returnValue;
        List<Label> inputValues = new List<Label>();
        List<Label> weightValues = new List<Label>();
        List<TextBox> inputValuesTxt = new List<TextBox>();
        List<NumericUpDown> weightsInputValues = new List<NumericUpDown>();
        public HiddenLayerNeuron(string name, Neuron neuron)
        {
            InitializeComponent();

            this.name = name;
            this.neuron = neuron;

            Array.Resize(ref returnValue, neuron.nOfInputs);

            for (int i = 0; i < neuron.nOfInputs; i++)
            {
                Label inputLabel = new Label();
                inputLabel.Text = "Input " + i;

                TextBox inputValueTxt = new TextBox();
                inputValueTxt.Text = Convert.ToString(neuron.x[i]);
                inputValueTxt.Size = new Size(55, 20);
                inputValueTxt.Enabled = false;

                Label weightValue = new Label();
                weightValue.Text = "Synaptic Weight " + i;

                NumericUpDown weightInputValue = new NumericUpDown();
                weightInputValue.Value = (decimal)neuron.w[i];
                weightInputValue.DecimalPlaces = 2;
                weightInputValue.Increment = 0.1M;
                weightInputValue.Size = new Size(55, 20);

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

        private void roundButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < weightsInputValues.Count; i++)
            {
                returnValue[i] = (double)weightsInputValues[i].Value;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}