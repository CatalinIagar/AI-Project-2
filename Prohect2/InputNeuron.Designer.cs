namespace Prohect2
{
    partial class InputNeuron
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
            this.inputLbl = new System.Windows.Forms.Label();
            this.inputNr = new System.Windows.Forms.NumericUpDown();
            this.roundButton1 = new Prohect2.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputNr)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(10, 10);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(34, 13);
            this.inputLbl.TabIndex = 0;
            this.inputLbl.Text = "Input:";
            // 
            // inputNr
            // 
            this.inputNr.DecimalPlaces = 2;
            this.inputNr.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputNr.Location = new System.Drawing.Point(50, 7);
            this.inputNr.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputNr.Name = "inputNr";
            this.inputNr.Size = new System.Drawing.Size(55, 20);
            this.inputNr.TabIndex = 1;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 5;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(115, 7);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(50, 20);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "OK";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // InputNeuron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.inputNr);
            this.Controls.Add(this.inputLbl);
            this.Name = "InputNeuron";
            this.Text = "InputNeuron";
            ((System.ComponentModel.ISupportInitialize)(this.inputNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.NumericUpDown inputNr;
        private RoundButton roundButton1;
    }
}