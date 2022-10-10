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
    public partial class OutputForm : Form
    {
        readonly List<RoundButton> buttons;
        public OutputForm(List<RoundButton> rb)
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            buttons = rb;
        }
        private void OutputForm_Load(object sender, EventArgs e)
        {
            foreach (RoundButton button in buttons)
            {
                Label label = new Label
                {
                    Text = "Output - " + button.Name,
                    Size = new System.Drawing.Size(80, 20),
                    Margin = new System.Windows.Forms.Padding(0, 5, 0, 0)
                };

                TextBox value = new TextBox
                {
                    Enabled = false,
                    Text = button.neuron.x[0].ToString(),
                    Size = new Size(60, 20)
                };

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(value);
            }
        }
        private void RoundButton1_Click(object sender, EventArgs e)
        {
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