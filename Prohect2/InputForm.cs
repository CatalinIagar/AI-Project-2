using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prohect2
{
    public partial class InputForm : Form
    {
        readonly List<RoundButton> buttons;
        readonly List<NumericUpDown> values = new List<NumericUpDown>();

        public double[] returnValues;
        public InputForm(List<RoundButton> rb)
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;

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

                NumericUpDown value = new NumericUpDown
                {
                    Increment = 0.01M,
                    Minimum = -100,
                    Maximum = 100,
                    DecimalPlaces = 2,
                    Value = (decimal)button.neuron.x[0],
                    Size = new Size(60, 20)
                };

                values.Add(value);

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(value);
            }
        }
        private void RoundButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < values.Count; i++)
            {
                returnValues[i] = (double)values[i].Value;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
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