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
    public partial class HiddenLayer : Form
    {
        public int[] returnStates = new int[3];
        public double[] returnValues = new double[2];
        public HiddenLayer(RoundButton roundButton)
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if(roundButton.neuron.inputFunction == NeuronState.SUM) btnInputSum.Checked = true;
            if(roundButton.neuron.inputFunction == NeuronState.PROD) btnInputProd.Checked = true;
            if(roundButton.neuron.inputFunction == NeuronState.MAX) btnInputMax.Checked = true;
            if(roundButton.neuron.inputFunction == NeuronState.MIN) btnInputMin.Checked = true;

            if(roundButton.neuron.activationFunction == NeuronState.TREAPTA) btnActTreapta.Checked = true;
            if(roundButton.neuron.activationFunction == NeuronState.SEMN) btnActSemn.Checked = true;
            if(roundButton.neuron.activationFunction == NeuronState.SIGM) btnActSigm.Checked = true;
            if(roundButton.neuron.activationFunction == NeuronState.TANH) btnActTanh.Checked = true;
            if(roundButton.neuron.activationFunction == NeuronState.LINIARA) btnActLiniara.Checked = true;

            if(roundButton.neuron.binaryState == NeuronState.BINARYTRUE) btnBinaryTrue.Checked = true;
            if(roundButton.neuron.binaryState == NeuronState.BINARYFALSE) btnBinaryFalse.Checked = true;

            tetaValue.Value = (decimal)roundButton.neuron.teta;
            gValue.Value = (decimal)roundButton.neuron.g;
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            if (btnInputSum.Checked) returnStates[0] = NeuronState.SUM;
            if (btnInputProd.Checked) returnStates[0] = NeuronState.PROD;
            if (btnInputMax.Checked) returnStates[0] = NeuronState.MAX;
            if (btnInputMin.Checked) returnStates[0] = NeuronState.MIN;

            if (btnActTreapta.Checked) returnStates[1] = NeuronState.TREAPTA;
            if (btnActSemn.Checked) returnStates[1] = NeuronState.SEMN;
            if (btnActSigm.Checked) returnStates[1] = NeuronState.SIGM;
            if (btnActTanh.Checked) returnStates[1] = NeuronState.TANH;
            if (btnActLiniara.Checked) returnStates[1] = NeuronState.LINIARA;

            if (btnBinaryTrue.Checked) returnStates[2] = NeuronState.BINARYTRUE;
            if (btnBinaryFalse.Checked) returnStates[2] = NeuronState.BINARYFALSE;

            returnValues[0] = (double)tetaValue.Value;
            returnValues[1] = (double)gValue.Value;

            this.DialogResult = DialogResult.OK;
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
    }
}
