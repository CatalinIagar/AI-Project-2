using System;
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

            this.ReturnValue = new int[6];

            this.KeyPress += new KeyPressEventHandler(CheckReturnKeyPress);
        }

        private void CheckReturnKeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == (char)Keys.Enter) GenerateNetowrkClick();
        }

        private void LayersInput_ValueChanged(object sender, EventArgs e)
        {
            if(layersInput.Value == 3)
            {
                hidden1Lbl.Visible = true;
                hidden2Lbl.Visible = true;
                hidden3Lbl.Visible = true;
                hidden1NeuronsInput.Visible = true;
                hidden2NeuronsInput.Visible = true;
                hidden3NeuronsInput.Visible = true;
            }
            if(layersInput.Value == 2)
            {
                hidden1Lbl.Visible = true;
                hidden2Lbl.Visible = true;
                hidden3Lbl.Visible = false;
                hidden1NeuronsInput.Visible = true;
                hidden2NeuronsInput.Visible = true;
                hidden3NeuronsInput.Visible = false;
            }
            if (layersInput.Value == 1)
            {
                hidden1Lbl.Visible = true;
                hidden2Lbl.Visible = false;
                hidden3Lbl.Visible = false;
                hidden1NeuronsInput.Visible = true;
                hidden2NeuronsInput.Visible = false;
                hidden3NeuronsInput.Visible = false;
            }
        }
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            GenerateNetowrkClick();
        }

        private void GenerateNetowrkClick()
        {
            this.ReturnValue[0] = (int)layersInput.Value;
            this.ReturnValue[1] = (int)inputNeuronsInput.Value;
            this.ReturnValue[5] = (int)outputNeuronsInput.Value;
            if (ReturnValue[0] == 1)
            {
                this.ReturnValue[2] = (int)hidden1NeuronsInput.Value;
                this.ReturnValue[3] = 0;
                this.ReturnValue[4] = 0;
            }
            if (ReturnValue[0] == 2)
            {
                this.ReturnValue[2] = (int)hidden1NeuronsInput.Value;
                this.ReturnValue[3] = (int)hidden2NeuronsInput.Value;
                this.ReturnValue[4] = 0;
            }
            if (ReturnValue[0] == 3)
            {
                this.ReturnValue[2] = (int)hidden1NeuronsInput.Value;
                this.ReturnValue[3] = (int)hidden2NeuronsInput.Value;
                this.ReturnValue[4] = (int)hidden3NeuronsInput.Value;
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
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
