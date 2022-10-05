namespace Prohect2
{
    partial class HiddenLayerNeuron
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roundButton1 = new Prohect2.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputLbl = new System.Windows.Forms.Label();
            this.activationLbl = new System.Windows.Forms.Label();
            this.binaryLbl = new System.Windows.Forms.Label();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.activationValue = new System.Windows.Forms.TextBox();
            this.outputValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 163);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.roundButton1.Location = new System.Drawing.Point(240, 200);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(150, 40);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "OK";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Function: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activation function;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Binary State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Activation Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Output Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Input Value:";
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(530, 10);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(30, 13);
            this.inputLbl.TabIndex = 8;
            this.inputLbl.Text = "input";
            // 
            // activationLbl
            // 
            this.activationLbl.AutoSize = true;
            this.activationLbl.Location = new System.Drawing.Point(530, 40);
            this.activationLbl.Name = "activationLbl";
            this.activationLbl.Size = new System.Drawing.Size(53, 13);
            this.activationLbl.TabIndex = 9;
            this.activationLbl.Text = "activation";
            // 
            // binaryLbl
            // 
            this.binaryLbl.AutoSize = true;
            this.binaryLbl.Location = new System.Drawing.Point(530, 70);
            this.binaryLbl.Name = "binaryLbl";
            this.binaryLbl.Size = new System.Drawing.Size(37, 13);
            this.binaryLbl.TabIndex = 10;
            this.binaryLbl.Text = "output";
            // 
            // inputValue
            // 
            this.inputValue.Enabled = false;
            this.inputValue.Location = new System.Drawing.Point(530, 95);
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(100, 20);
            this.inputValue.TabIndex = 11;
            // 
            // activationValue
            // 
            this.activationValue.Enabled = false;
            this.activationValue.Location = new System.Drawing.Point(530, 125);
            this.activationValue.Name = "activationValue";
            this.activationValue.Size = new System.Drawing.Size(100, 20);
            this.activationValue.TabIndex = 12;
            // 
            // outputValue
            // 
            this.outputValue.Enabled = false;
            this.outputValue.Location = new System.Drawing.Point(530, 155);
            this.outputValue.Name = "outputValue";
            this.outputValue.Size = new System.Drawing.Size(100, 20);
            this.outputValue.TabIndex = 13;
            // 
            // HiddenLayerNeuron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputValue);
            this.Controls.Add(this.activationValue);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.binaryLbl);
            this.Controls.Add(this.activationLbl);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HiddenLayerNeuron";
            this.Text = "HiddenLayerNeuron";
            this.Load += new System.EventHandler(this.HiddenLayerNeuron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.Label activationLbl;
        private System.Windows.Forms.Label binaryLbl;
        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.TextBox activationValue;
        private System.Windows.Forms.TextBox outputValue;
    }
}