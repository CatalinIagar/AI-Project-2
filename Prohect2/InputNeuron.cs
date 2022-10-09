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
    public partial class InputNeuron : Form
    {
        public double returnValue;
        public InputNeuron(string name, Neuron neuron)
        {
            InitializeComponent();

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.inputNr.Value = (decimal)neuron.x[0];
            this.Text = "Input Neuron - " + name;
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
            
            returnValue = (double)inputNr.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
