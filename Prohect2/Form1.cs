using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prohect2
{
    public partial class Form1 : Form
    {
        public int height = 768;
        public int width = 1280;
        public int margin = 20;
        public int topMargin;
        public int radius = 70;
        public int spaceBetweenNeurons = 280;
        public int heightBetweenNeurons;

        List<RoundButton> inputButtons = new List<RoundButton>();
        List<RoundButton> hiddenL1Buttons = new List<RoundButton>();
        List<RoundButton> hiddenL2Buttons = new List<RoundButton>();
        List<RoundButton> HiddenL3Buttons = new List<RoundButton>();
        List<RoundButton> OutputButtons = new List<RoundButton>();

        List<List<RoundButton>> hiddenLayersButtons = new List<List<RoundButton>>();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            heightBetweenNeurons = radius * 3 / 2;
            topMargin = radius;

            this.MinimizeBox = true;
            this.MaximizeBox = false;
            this.AutoSize = true;

            doStuffButton.Click += (sender, e) => testButton(sender, e);

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null,
                mainPanel, new object[] { true });
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            mainPanel.Invalidate();
        }

        private void testButton(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            inputButtons.Clear();
            OutputButtons.Clear();
            hiddenL1Buttons.Clear();
            HiddenL3Buttons.Clear();
            hiddenL2Buttons.Clear();

            int[] nOfNeuronsPerLayer = new int[5];

            nOfNeuronsPerLayer[0] = (int)inputLayer.Value;
            nOfNeuronsPerLayer[1] = (int)Hiden1Layer.Value;
            nOfNeuronsPerLayer[2] = (int)Hiden2Layer.Value;
            nOfNeuronsPerLayer[3] = (int)Hiden3Layer.Value;
            nOfNeuronsPerLayer[4] = (int)OutputLayer.Value;

            int maxNumber = nOfNeuronsPerLayer.Max();

            int maxSize = topMargin + (maxNumber - 1) * heightBetweenNeurons + radius;

            addButtons(maxSize, margin + spaceBetweenNeurons / 2  + 0 * spaceBetweenNeurons, nOfNeuronsPerLayer[0], inputButtons);
            addButtons(maxSize, margin + spaceBetweenNeurons / 2  + 1 * spaceBetweenNeurons, nOfNeuronsPerLayer[1], hiddenL1Buttons);
            addButtons(maxSize, margin + spaceBetweenNeurons / 2  + 2 * spaceBetweenNeurons, nOfNeuronsPerLayer[2], hiddenL2Buttons);
            addButtons(maxSize, margin + spaceBetweenNeurons / 2  + 3 * spaceBetweenNeurons, nOfNeuronsPerLayer[3], HiddenL3Buttons);
            addButtons(maxSize, margin + spaceBetweenNeurons / 2  + 4 * spaceBetweenNeurons, nOfNeuronsPerLayer[4], OutputButtons);

            //drawLine(inputButtons, hiddenL1Buttons);
            mainPanel.Invalidate();
        }

        private void drawLine(List<RoundButton> fromButtons, List<RoundButton> toButtons)
        {
            Graphics g = mainPanel.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1.5f);
            for(int i = 0; i < fromButtons.Count; i++)
            {
                for(int j = 0; j < toButtons.Count; j++)
                {
                    g.DrawLine(pen, fromButtons[i].right, toButtons[j].left);
                }
            }
        }

        private void addButtons(int size, int xPos, int nOfButtons, List<RoundButton> buttons)
        {
            int half = (size - topMargin) / 2;
            int halfCurrentSize = (nOfButtons * (heightBetweenNeurons - 1)) / 2 + radius / 2;
            int firstPos = half - halfCurrentSize + topMargin + radius / 2;
            

            for(int i = 0; i < nOfButtons; i++)
            {
                RoundButton rb = new RoundButton();
                rb.Name = i.ToString();
                rb.Width = radius;
                rb.Height = radius;
                rb.BorderRadius = radius / 2;
                Point point = new Point(xPos, firstPos + heightBetweenNeurons * i);
                Point right = new Point(xPos + radius, firstPos + heightBetweenNeurons * i + radius / 2);
                Point left = new Point(xPos, firstPos + heightBetweenNeurons * i + radius / 2);
                rb.Location = point;
                rb.right = right;
                rb.left = left;
                buttons.Add(rb);
                mainPanel.Controls.Add(rb);
            }
        }

        private void mainPanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(mainPanel.AutoScrollPosition.X, mainPanel.AutoScrollPosition.Y);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 1.75f);
            for (int i = 0; i < inputButtons.Count; i++)
            {
                for (int j = 0; j < hiddenL1Buttons.Count; j++)
                {
                    g.DrawLine(pen, inputButtons[i].right, hiddenL1Buttons[j].left);
                }
            }
            for (int i = 0; i < hiddenL1Buttons.Count; i++)
            {
                for (int j = 0; j < hiddenL2Buttons.Count; j++)
                {
                    g.DrawLine(pen, hiddenL1Buttons[i].right, hiddenL2Buttons[j].left);
                }
            }
            for (int i = 0; i < hiddenL2Buttons.Count; i++)
            {
                for (int j = 0; j < HiddenL3Buttons.Count; j++)
                {
                    g.DrawLine(pen, hiddenL2Buttons[i].right, HiddenL3Buttons[j].left);
                }
            }
            for (int i = 0; i < HiddenL3Buttons.Count; i++)
            {
                for (int j = 0; j < OutputButtons.Count; j++)
                {
                    g.DrawLine(pen, HiddenL3Buttons[i].right, OutputButtons[j].left);
                }
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            using(var form = new GenerateNetwork())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int[] val = form.ReturnValue;

                    int maxSize = topMargin + (val[0] - 1) * heightBetweenNeurons + radius;

                    addButtons(maxSize, margin + spaceBetweenNeurons / 2 + 0 * spaceBetweenNeurons, val[0], inputButtons);
                }
            }
        }
        
    }
}
