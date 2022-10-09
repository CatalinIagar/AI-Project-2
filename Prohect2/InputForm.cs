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
    public partial class InputForm : Form
    {
        List<RoundButton> buttons;
        List<NumericUpDown> values = new List<NumericUpDown>();

        public double[] returnValues;
        public InputForm(List<RoundButton> rb)
        {
            InitializeComponent();

            this.buttons = rb;
            this.flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            returnValues = new double[rb.Count];
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            foreach (RoundButton button in buttons)
            {
                Label label = new Label
                {
                    Text = "Input - " + button.Name,
                    Size = new System.Drawing.Size(80, 20),
                    Margin = new System.Windows.Forms.Padding(0, 5, 0, 0)
                };

                NumericUpDown value = new NumericUpDown();
                value.Increment = 0.01M;
                value.Minimum = -100;
                value.Maximum = 100;
                value.DecimalPlaces = 2;
                value.Value = (decimal)button.neuron.x[0];
                value.Size = new Size(60, 20);

                values.Add(value);

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(value);
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < values.Count; i++)
            {
                returnValues[i] = (double)values[i].Value;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
