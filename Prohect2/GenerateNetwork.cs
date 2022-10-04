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
    public partial class GenerateNetwork : Form
    {
        public int[] ReturnValue { get; set; }
        public GenerateNetwork()
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.ReturnValue = new int[1];
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void layersInput_ValueChanged(object sender, EventArgs e)
        {
            if(layersInput.Value == 3)
            {
                hidden1Lbl.Enabled = true;
                hidden2Lbl.Enabled = true;
                hidden3Lbl.Enabled = true;
                hidden1NeuronsInput.Enabled = true;
                hidden2NeuronsInput.Enabled = true;
                hidden3NeuronsInput.Enabled = true;
            }
            if(layersInput.Value == 2)
            {
                hidden1Lbl.Enabled = true;
                hidden2Lbl.Enabled = true;
                hidden3Lbl.Enabled = false;
                hidden1NeuronsInput.Enabled = true;
                hidden2NeuronsInput.Enabled = true;
                hidden3NeuronsInput.Enabled = false;
            }
            if (layersInput.Value == 1)
            {
                hidden1Lbl.Enabled = true;
                hidden2Lbl.Enabled = false;
                hidden3Lbl.Enabled = false;
                hidden1NeuronsInput.Enabled = true;
                hidden2NeuronsInput.Enabled = false;
                hidden3NeuronsInput.Enabled = false;
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            this.ReturnValue[0] = 5;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
