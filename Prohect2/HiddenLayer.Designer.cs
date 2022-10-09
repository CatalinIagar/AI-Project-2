namespace Prohect2
{
    partial class HiddenLayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputLbl = new System.Windows.Forms.Label();
            this.btnInputSum = new System.Windows.Forms.RadioButton();
            this.btnInputProd = new System.Windows.Forms.RadioButton();
            this.btnInputMax = new System.Windows.Forms.RadioButton();
            this.btnInputMin = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActTanh = new System.Windows.Forms.RadioButton();
            this.btnActSigm = new System.Windows.Forms.RadioButton();
            this.btnActSemn = new System.Windows.Forms.RadioButton();
            this.btnActTreapta = new System.Windows.Forms.RadioButton();
            this.activationLbl = new System.Windows.Forms.Label();
            this.btnActLiniara = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBinaryFalse = new System.Windows.Forms.RadioButton();
            this.btnBinaryTrue = new System.Windows.Forms.RadioButton();
            this.binaryLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tetaLbl = new System.Windows.Forms.Label();
            this.tetaValue = new System.Windows.Forms.NumericUpDown();
            this.gValue = new System.Windows.Forms.NumericUpDown();
            this.gLbl = new System.Windows.Forms.Label();
            this.roundButton1 = new Prohect2.RoundButton();
            this.inputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tetaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gValue)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.btnInputMin);
            this.inputPanel.Controls.Add(this.btnInputMax);
            this.inputPanel.Controls.Add(this.btnInputProd);
            this.inputPanel.Controls.Add(this.btnInputSum);
            this.inputPanel.Controls.Add(this.inputLbl);
            this.inputPanel.Location = new System.Drawing.Point(20, 20);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(125, 150);
            this.inputPanel.TabIndex = 0;
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(5, 5);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(80, 13);
            this.inputLbl.TabIndex = 0;
            this.inputLbl.Text = "Input functions:";
            // 
            // btnInputSum
            // 
            this.btnInputSum.AutoSize = true;
            this.btnInputSum.Location = new System.Drawing.Point(5, 20);
            this.btnInputSum.Name = "btnInputSum";
            this.btnInputSum.Size = new System.Drawing.Size(46, 17);
            this.btnInputSum.TabIndex = 1;
            this.btnInputSum.TabStop = true;
            this.btnInputSum.Text = "Sum";
            this.btnInputSum.UseVisualStyleBackColor = true;
            // 
            // btnInputProd
            // 
            this.btnInputProd.AutoSize = true;
            this.btnInputProd.Location = new System.Drawing.Point(5, 45);
            this.btnInputProd.Name = "btnInputProd";
            this.btnInputProd.Size = new System.Drawing.Size(47, 17);
            this.btnInputProd.TabIndex = 2;
            this.btnInputProd.TabStop = true;
            this.btnInputProd.Text = "Prod";
            this.btnInputProd.UseVisualStyleBackColor = true;
            // 
            // btnInputMax
            // 
            this.btnInputMax.AutoSize = true;
            this.btnInputMax.Location = new System.Drawing.Point(5, 70);
            this.btnInputMax.Name = "btnInputMax";
            this.btnInputMax.Size = new System.Drawing.Size(55, 17);
            this.btnInputMax.TabIndex = 3;
            this.btnInputMax.TabStop = true;
            this.btnInputMax.Text = "Maxim";
            this.btnInputMax.UseVisualStyleBackColor = true;
            // 
            // btnInputMin
            // 
            this.btnInputMin.AutoSize = true;
            this.btnInputMin.Location = new System.Drawing.Point(5, 95);
            this.btnInputMin.Name = "btnInputMin";
            this.btnInputMin.Size = new System.Drawing.Size(52, 17);
            this.btnInputMin.TabIndex = 4;
            this.btnInputMin.TabStop = true;
            this.btnInputMin.Text = "Minim";
            this.btnInputMin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActLiniara);
            this.panel1.Controls.Add(this.btnActTanh);
            this.panel1.Controls.Add(this.btnActSigm);
            this.panel1.Controls.Add(this.btnActSemn);
            this.panel1.Controls.Add(this.btnActTreapta);
            this.panel1.Controls.Add(this.activationLbl);
            this.panel1.Location = new System.Drawing.Point(175, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 150);
            this.panel1.TabIndex = 1;
            // 
            // btnActTanh
            // 
            this.btnActTanh.AutoSize = true;
            this.btnActTanh.Location = new System.Drawing.Point(5, 95);
            this.btnActTanh.Name = "btnActTanh";
            this.btnActTanh.Size = new System.Drawing.Size(52, 17);
            this.btnActTanh.TabIndex = 4;
            this.btnActTanh.TabStop = true;
            this.btnActTanh.Text = "TanH";
            this.btnActTanh.UseVisualStyleBackColor = true;
            // 
            // btnActSigm
            // 
            this.btnActSigm.AutoSize = true;
            this.btnActSigm.Location = new System.Drawing.Point(5, 70);
            this.btnActSigm.Name = "btnActSigm";
            this.btnActSigm.Size = new System.Drawing.Size(76, 17);
            this.btnActSigm.TabIndex = 3;
            this.btnActSigm.TabStop = true;
            this.btnActSigm.Text = "Sigmoidala";
            this.btnActSigm.UseVisualStyleBackColor = true;
            // 
            // btnActSemn
            // 
            this.btnActSemn.AutoSize = true;
            this.btnActSemn.Location = new System.Drawing.Point(5, 45);
            this.btnActSemn.Name = "btnActSemn";
            this.btnActSemn.Size = new System.Drawing.Size(52, 17);
            this.btnActSemn.TabIndex = 2;
            this.btnActSemn.TabStop = true;
            this.btnActSemn.Text = "Semn";
            this.btnActSemn.UseVisualStyleBackColor = true;
            // 
            // btnActTreapta
            // 
            this.btnActTreapta.AutoSize = true;
            this.btnActTreapta.Location = new System.Drawing.Point(5, 20);
            this.btnActTreapta.Name = "btnActTreapta";
            this.btnActTreapta.Size = new System.Drawing.Size(62, 17);
            this.btnActTreapta.TabIndex = 1;
            this.btnActTreapta.TabStop = true;
            this.btnActTreapta.Text = "Treapta";
            this.btnActTreapta.UseVisualStyleBackColor = true;
            // 
            // activationLbl
            // 
            this.activationLbl.AutoSize = true;
            this.activationLbl.Location = new System.Drawing.Point(5, 5);
            this.activationLbl.Name = "activationLbl";
            this.activationLbl.Size = new System.Drawing.Size(103, 13);
            this.activationLbl.TabIndex = 0;
            this.activationLbl.Text = "Activation functions:";
            // 
            // btnActLiniara
            // 
            this.btnActLiniara.AutoSize = true;
            this.btnActLiniara.Location = new System.Drawing.Point(5, 120);
            this.btnActLiniara.Name = "btnActLiniara";
            this.btnActLiniara.Size = new System.Drawing.Size(56, 17);
            this.btnActLiniara.TabIndex = 5;
            this.btnActLiniara.TabStop = true;
            this.btnActLiniara.Text = "Liniara";
            this.btnActLiniara.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBinaryFalse);
            this.panel2.Controls.Add(this.btnBinaryTrue);
            this.panel2.Controls.Add(this.binaryLbl);
            this.panel2.Location = new System.Drawing.Point(330, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 150);
            this.panel2.TabIndex = 2;
            // 
            // btnBinaryFalse
            // 
            this.btnBinaryFalse.AutoSize = true;
            this.btnBinaryFalse.Location = new System.Drawing.Point(5, 45);
            this.btnBinaryFalse.Name = "btnBinaryFalse";
            this.btnBinaryFalse.Size = new System.Drawing.Size(50, 17);
            this.btnBinaryFalse.TabIndex = 2;
            this.btnBinaryFalse.TabStop = true;
            this.btnBinaryFalse.Text = "False";
            this.btnBinaryFalse.UseVisualStyleBackColor = true;
            // 
            // btnBinaryTrue
            // 
            this.btnBinaryTrue.AutoSize = true;
            this.btnBinaryTrue.Location = new System.Drawing.Point(5, 20);
            this.btnBinaryTrue.Name = "btnBinaryTrue";
            this.btnBinaryTrue.Size = new System.Drawing.Size(47, 17);
            this.btnBinaryTrue.TabIndex = 1;
            this.btnBinaryTrue.TabStop = true;
            this.btnBinaryTrue.Text = "True";
            this.btnBinaryTrue.UseVisualStyleBackColor = true;
            // 
            // binaryLbl
            // 
            this.binaryLbl.AutoSize = true;
            this.binaryLbl.Location = new System.Drawing.Point(5, 5);
            this.binaryLbl.Name = "binaryLbl";
            this.binaryLbl.Size = new System.Drawing.Size(72, 13);
            this.binaryLbl.TabIndex = 0;
            this.binaryLbl.Text = "Binary output:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gValue);
            this.panel3.Controls.Add(this.gLbl);
            this.panel3.Controls.Add(this.tetaValue);
            this.panel3.Controls.Add(this.tetaLbl);
            this.panel3.Location = new System.Drawing.Point(485, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 150);
            this.panel3.TabIndex = 3;
            // 
            // tetaLbl
            // 
            this.tetaLbl.AutoSize = true;
            this.tetaLbl.Location = new System.Drawing.Point(5, 5);
            this.tetaLbl.Name = "tetaLbl";
            this.tetaLbl.Size = new System.Drawing.Size(32, 13);
            this.tetaLbl.TabIndex = 0;
            this.tetaLbl.Text = "Teta:";
            // 
            // tetaValue
            // 
            this.tetaValue.DecimalPlaces = 2;
            this.tetaValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tetaValue.Location = new System.Drawing.Point(5, 20);
            this.tetaValue.Name = "tetaValue";
            this.tetaValue.Size = new System.Drawing.Size(75, 20);
            this.tetaValue.TabIndex = 1;
            // 
            // gValue
            // 
            this.gValue.DecimalPlaces = 2;
            this.gValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gValue.Location = new System.Drawing.Point(8, 67);
            this.gValue.Name = "gValue";
            this.gValue.Size = new System.Drawing.Size(75, 20);
            this.gValue.TabIndex = 3;
            this.gValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gLbl
            // 
            this.gLbl.AutoSize = true;
            this.gLbl.Location = new System.Drawing.Point(8, 52);
            this.gLbl.Name = "gLbl";
            this.gLbl.Size = new System.Drawing.Size(34, 13);
            this.gLbl.TabIndex = 2;
            this.gLbl.Text = "a (g) :";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(240, 185);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(150, 40);
            this.roundButton1.TabIndex = 4;
            this.roundButton1.Text = "OK";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // HiddenLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputPanel);
            this.Name = "HiddenLayer";
            this.Text = "HiddenLayer";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tetaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.RadioButton btnInputMin;
        private System.Windows.Forms.RadioButton btnInputMax;
        private System.Windows.Forms.RadioButton btnInputProd;
        private System.Windows.Forms.RadioButton btnInputSum;
        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnActLiniara;
        private System.Windows.Forms.RadioButton btnActTanh;
        private System.Windows.Forms.RadioButton btnActSigm;
        private System.Windows.Forms.RadioButton btnActSemn;
        private System.Windows.Forms.RadioButton btnActTreapta;
        private System.Windows.Forms.Label activationLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton btnBinaryFalse;
        private System.Windows.Forms.RadioButton btnBinaryTrue;
        private System.Windows.Forms.Label binaryLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown gValue;
        private System.Windows.Forms.Label gLbl;
        private System.Windows.Forms.NumericUpDown tetaValue;
        private System.Windows.Forms.Label tetaLbl;
        private RoundButton roundButton1;
    }
}