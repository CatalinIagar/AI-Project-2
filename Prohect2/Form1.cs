using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public int nOfHiddenLayers;
        public bool toPaint = false;

        List<List<RoundButton>> LayersButtons = new List<List<RoundButton>>();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            heightBetweenNeurons = radius * 3 / 2;
            topMargin = radius;

            this.MinimizeBox = true;
            this.MaximizeBox = false;
            this.AutoSize = true;

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null,
                mainPanel, new object[] { true });
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
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
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Red, 1.75f);

            if (toPaint == false) return;

            for (int i = 0; i < nOfHiddenLayers + 1; i++)
            {
                List<RoundButton> left = LayersButtons[i];
                List<RoundButton> right = LayersButtons[i + 1];
                foreach(RoundButton button in left)
                {
                    foreach(RoundButton button2 in right)
                    {
                        g.DrawLine(pen, button.right, button2.left);
                    }
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
                    LayersButtons.Clear();
                    mainPanel.Controls.Clear();
                    int[] val = form.ReturnValue;
                    int[] nOfNeurons = {val[1], val[5], val[2], val[3], val[4] };

                    nOfHiddenLayers = val[0];

                    if (nOfHiddenLayers == 1) spaceBetweenNeurons = 1120 / 2;
                    if (nOfHiddenLayers == 2) spaceBetweenNeurons = 1120 / 3;
                    if (nOfHiddenLayers == 3) spaceBetweenNeurons = 1120 / 4;

                    int maxNumber = nOfNeurons.Max();
                    int maxSize = topMargin + (maxNumber - 1) * heightBetweenNeurons + radius;

                    //addInputs
                    List<RoundButton> radioButtons = new List<RoundButton>();
                    addButtons(maxSize, margin + 2 * radius + 0 * spaceBetweenNeurons, nOfNeurons[0], radioButtons);
                    LayersButtons.Add(radioButtons);

                    //addHiddenLayers
                    for (int i = 1; i < nOfHiddenLayers + 1; i++)
                    {
                        List<RoundButton> radioButtonsH = new List<RoundButton>();
                        addButtons(maxSize, margin + 2 * radius + i * spaceBetweenNeurons, nOfNeurons[i + 1], radioButtonsH);
                        LayersButtons.Add(radioButtonsH);
                    }

                    //addOutputs
                    List<RoundButton> radioButtonsO = new List<RoundButton>();
                    addButtons(maxSize, margin + 2 * radius + (nOfHiddenLayers + 1) * spaceBetweenNeurons, nOfNeurons[1], radioButtonsO);
                    LayersButtons.Add(radioButtonsO);
                    toPaint = true;
                    mainPanel.Invalidate();
                }
            }
        }
    }
}
