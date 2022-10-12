using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Prohect2
{
    public partial class Form1 : Form
    {
        public int margin = 20;
        public int topMargin;
        public int radius = 90;
        public int spaceBetweenNeurons;
        public int heightBetweenNeurons;
        public int nOfHiddenLayers;
        public bool toPaint = false;
        readonly List<List<RoundButton>> LayersButtons = new List<List<RoundButton>>();
        public Form1()
        {
            InitializeComponent();

            heightBetweenNeurons = radius * 4 / 3;
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
        private void AddButtons(int size, int xPos, int nOfButtons, List<RoundButton> buttons, string name, int layer)
        {
            int half = (size - topMargin) / 2;
            int halfCurrentSize = (nOfButtons * (heightBetweenNeurons - 1)) / 2 + radius / 2;
            int firstPos = half - halfCurrentSize + topMargin + radius / 2;
            

            for(int i = 0; i < nOfButtons; i++)
            {
                RoundButton rb = new RoundButton
                {
                    Name = i.ToString(),
                    Width = radius,
                    Height = radius,
                    BorderRadius = radius / 2,
                    Text = name + i.ToString(),
                    layer = layer,
                };
                Point point = new Point(xPos, firstPos + heightBetweenNeurons * i);
                Point right = new Point(xPos + radius, firstPos + heightBetweenNeurons * i + radius / 2);
                Point left = new Point(xPos, firstPos + heightBetweenNeurons * i + radius / 2);
                rb.Location = point;
                rb.right = right;
                rb.left = left;
                if (name == "Input - ") 
                {
                    Array.Resize(ref rb.neuron.x, 1);
                    Array.Resize(ref rb.neuron.w, 1);
                    rb.neuron.nOfInputs = 1;
                    rb.Click += (sender, e) => InputNeuronButton(sender, e);
                }
                else if (name.Contains("HLayer"))
                {
                    Array.Resize(ref rb.neuron.x, LayersButtons[layer - 1].Count);
                    Array.Resize(ref rb.neuron.w, LayersButtons[layer - 1].Count);
                    rb.neuron.nOfInputs = LayersButtons[layer - 1].Count;
                    rb.Click += (sender, e) => HiddenNeuronButton(sender, e);
                }
                else
                {
                    Array.Resize(ref rb.neuron.x, LayersButtons[layer - 1].Count);
                    Array.Resize(ref rb.neuron.w, LayersButtons[layer - 1].Count);
                    rb.neuron.nOfInputs = LayersButtons[layer - 1].Count;
                    rb.Click += (sender, e) => HiddenNeuronButton(sender, e);
                }
                buttons.Add(rb);
                mainPanel.Controls.Add(rb);
            }
        }
        private void HiddenNeuronButton(object sender, EventArgs e)
        {
            RoundButton roundButton = (RoundButton)sender;
            this.Enabled = false;
            using (var form = new HiddenLayerNeuron(roundButton.Text, roundButton.neuron))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Enabled = true;
                    double[] val = form.returnValue;
                    for(int i = 0; i < roundButton.neuron.nOfInputs; i++)
                    {
                        roundButton.neuron.w[i] = val[i];
                    }

                    UpdateData();
                }
            }
        }
        private void InputNeuronButton(object sender, EventArgs e)
        {
            RoundButton roundButton = (RoundButton)sender;
            this.Enabled = false;
            using (var form = new InputNeuron(roundButton.Name, roundButton.neuron))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Enabled = true;
                    double val = form.returnValue;
                    roundButton.neuron.x[0] = val;
                    roundButton.neuron.output = val;
                    UpdateData();
                }
            }
        }
        private void AddHiddenLayerButtons()
        {
            topPanel.Controls.Clear();
            Point point;
            RoundButton rb;
            for (int i = 1; i <= nOfHiddenLayers; i++)
            {
                point = new Point(margin + radius * 3 / 2 + i * spaceBetweenNeurons, 12);
                rb = new RoundButton
                {
                    Name = i.ToString(),
                    Height = 60,
                    Width = radius * 2,
                    BorderRadius = 20,
                    Text = "Hidden Layer - " + i.ToString(),
                    layer = i,
                    Location = point,
                };
                rb.Click += (sender, e) => HiddenLayerButton_Click(sender, e);
                topPanel.Controls.Add(rb);
            }
            point = new Point(margin + radius * 3 / 2 + (nOfHiddenLayers + 1) * spaceBetweenNeurons, 12);
            rb = new RoundButton
            {
                Name = (nOfHiddenLayers + 1).ToString(),
                Height = 60,
                Width = radius * 2,
                BorderRadius = 20,
                Text = "Output Layer",
                layer = (nOfHiddenLayers + 1),
                Location = point,
            };
            rb.Click += (sender, e) => HiddenLayerButton_Click(sender, e);
            topPanel.Controls.Add(rb);
        }
        private void HiddenLayerButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            RoundButton roundButton = (RoundButton)sender;
            List<RoundButton> rbs = LayersButtons[roundButton.layer];
            using (var form = new HiddenLayer(rbs[0]))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    this.Enabled = true;
                    int[] returnStates = form.returnStates;
                    double[] returnValues = form.returnValues;

                    foreach(RoundButton rb in rbs)
                    {
                        rb.neuron.inputFunction = returnStates[0];
                        rb.neuron.activationFunction = returnStates[1];
                        rb.neuron.binaryState = returnStates[2];

                        rb.neuron.teta = returnValues[0];
                        rb.neuron.g = returnValues[1];
                    }
                    UpdateData();
                }
            }
        }
        private void MainPanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate();
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
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
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            using(var form = new GenerateNetwork())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Enabled = true;
                    LayersButtons.Clear();
                    mainPanel.Controls.Clear();
                    int[] val = form.ReturnValue;
                    int[] nOfNeurons = {val[1], val[5], val[2], val[3], val[4] };

                    nOfHiddenLayers = val[0];
                    spaceBetweenNeurons = 1120 / (nOfHiddenLayers + 1);

                    int maxNumber = nOfNeurons.Max();
                    int maxSize = topMargin + (maxNumber - 1) * heightBetweenNeurons + radius;
                    int layer = 0;

                    //addInputs
                    List<RoundButton> radioButtons = new List<RoundButton>();
                    AddButtons(maxSize, margin + 2 * radius + 0 * spaceBetweenNeurons, nOfNeurons[0], radioButtons, "Input - ", layer);
                    LayersButtons.Add(radioButtons);
                    layer++;

                    //addHiddenLayers
                    for (int i = 1; i < nOfHiddenLayers + 1; i++)
                    {
                        List<RoundButton> radioButtonsH = new List<RoundButton>();
                        AddButtons(maxSize, margin + 2 * radius + i * spaceBetweenNeurons, nOfNeurons[i + 1], radioButtonsH, "HLayer" + i.ToString() + " - ", layer);
                        LayersButtons.Add(radioButtonsH);
                        layer++;
                    }

                    //addOutputs
                    List<RoundButton> radioButtonsO = new List<RoundButton>();
                    AddButtons(maxSize, margin + 2 * radius + (nOfHiddenLayers + 1) * spaceBetweenNeurons, nOfNeurons[1], radioButtonsO, "Output - ", layer);
                    LayersButtons.Add(radioButtonsO);
                    toPaint = true;
                    mainPanel.Invalidate();

                    this.inputButton.Enabled = true;
                    this.outputButton.Enabled = true;
                    AddHiddenLayerButtons();
                    UpdateData();
                }
                if(result == DialogResult.Cancel)
                {
                    this.Enabled = true;
                }
            }
        }
        private void UpdateData()
        {
            TransferData(LayersButtons[0], LayersButtons[1]);
            for (int i = 1; i <= nOfHiddenLayers; i++)
            {
                CalculateOutput(LayersButtons[i]);
                TransferData(LayersButtons[i], LayersButtons[i + 1]);
            }
            CalculateOutput(LayersButtons[nOfHiddenLayers + 1]);
        }
        private void CalculateOutput(List<RoundButton> roundButtons)
        {
            foreach (RoundButton rb in roundButtons)
            {
                rb.neuron.ginput = CalculateInput(rb.neuron);
                rb.neuron.activation = CalculateActivation(rb.neuron);
                rb.neuron.output = CalculateOutputValue(rb.neuron);
            }
        }
        private double CalculateOutputValue(Neuron neuron)
        {
            if (neuron.binaryState == NeuronState.BINARYFALSE) return neuron.activation;

            if (neuron.activationFunction == NeuronState.TREAPTA || neuron.activationFunction == NeuronState.SEMN) return neuron.activation;
            if (neuron.activationFunction == NeuronState.SIGM)
            {
                if (neuron.activation >= 0.5) return 1;
                return 0;
            }
            if (neuron.activationFunction == NeuronState.TANH || neuron.activationFunction == NeuronState.LINIARA)
            {
                if (neuron.activation >= 0) return 1;
                return -1;
            }
            return 0;
        }
        private double CalculateActivation(Neuron neuron)
        {
            if (neuron.activationFunction == NeuronState.TREAPTA) return FunctiiActivare.CalculActivareTreapta(neuron);
            if (neuron.activationFunction == NeuronState.SEMN) return FunctiiActivare.CalculActivareSemn(neuron);
            if (neuron.activationFunction == NeuronState.SIGM) return FunctiiActivare.CalculActivareSigmoidala(neuron);
            if (neuron.activationFunction == NeuronState.TANH) return FunctiiActivare.CalculActivareTanh(neuron);
            if (neuron.activationFunction == NeuronState.LINIARA) return FunctiiActivare.CalculActivareLiniara(neuron);

            return 0f;
        }
        private double CalculateInput(Neuron neuron)
        {
            if (neuron.inputFunction == NeuronState.SUM) return FunctiiInput.CalculInputSuma(neuron);
            if (neuron.inputFunction == NeuronState.PROD) return FunctiiInput.CalculInputProd(neuron);
            if (neuron.inputFunction == NeuronState.MAX) return FunctiiInput.CalculInputMax(neuron);
            if (neuron.inputFunction == NeuronState.MIN) return FunctiiInput.CalculInputMin(neuron);

            return 0f;
        }
        private void TransferData(List<RoundButton> left, List<RoundButton> right)
        {
            for (int i = 0; i < right.Count; i++)
            {
                for (int j = 0; j < right[i].neuron.x.Length; j++)
                {
                    right[i].neuron.x[j] = left[j].neuron.output;
                }
            }
        }
        private void InputButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            using (var form = new InputForm(LayersButtons[0]))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    this.Enabled = true;
                    double[] values = form.returnValues;

                    List<RoundButton> buttons = LayersButtons[0];
                    for(int i = 0; i < buttons.Count; i++)
                    {
                        buttons[i].neuron.x[0] = values[i];
                    }
                    UpdateData();
                }
            }
        }
        private void OutputButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            using(var form = new OutputForm(LayersButtons[nOfHiddenLayers + 1]))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    this.Enabled = true;
                }
            }
        }
    }
}