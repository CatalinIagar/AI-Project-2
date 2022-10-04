namespace Prohect2
{
    partial class Form1
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.generateButton = new Prohect2.RoundButton();
            this.doStuffButton = new Prohect2.RoundButton();
            this.OutputLayer = new System.Windows.Forms.NumericUpDown();
            this.Hiden3Layer = new System.Windows.Forms.NumericUpDown();
            this.Hiden2Layer = new System.Windows.Forms.NumericUpDown();
            this.Hiden1Layer = new System.Windows.Forms.NumericUpDown();
            this.inputLayer = new System.Windows.Forms.NumericUpDown();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiden3Layer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiden2Layer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiden1Layer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftPanel.Controls.Add(this.generateButton);
            this.leftPanel.Controls.Add(this.doStuffButton);
            this.leftPanel.Controls.Add(this.OutputLayer);
            this.leftPanel.Controls.Add(this.Hiden3Layer);
            this.leftPanel.Controls.Add(this.Hiden2Layer);
            this.leftPanel.Controls.Add(this.Hiden1Layer);
            this.leftPanel.Controls.Add(this.inputLayer);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(139, 767);
            this.leftPanel.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.generateButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.generateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.generateButton.BorderRadius = 10;
            this.generateButton.BorderSize = 0;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(12, 102);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(115, 40);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate Network";
            this.generateButton.TextColor = System.Drawing.Color.White;
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // doStuffButton
            // 
            this.doStuffButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.doStuffButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.doStuffButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.doStuffButton.BorderRadius = 0;
            this.doStuffButton.BorderSize = 0;
            this.doStuffButton.FlatAppearance.BorderSize = 0;
            this.doStuffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doStuffButton.ForeColor = System.Drawing.Color.White;
            this.doStuffButton.Location = new System.Drawing.Point(24, 411);
            this.doStuffButton.Name = "doStuffButton";
            this.doStuffButton.Size = new System.Drawing.Size(83, 40);
            this.doStuffButton.TabIndex = 5;
            this.doStuffButton.Text = "Press me";
            this.doStuffButton.TextColor = System.Drawing.Color.White;
            this.doStuffButton.UseVisualStyleBackColor = false;
            // 
            // OutputLayer
            // 
            this.OutputLayer.Location = new System.Drawing.Point(7, 367);
            this.OutputLayer.Name = "OutputLayer";
            this.OutputLayer.Size = new System.Drawing.Size(120, 20);
            this.OutputLayer.TabIndex = 4;
            // 
            // Hiden3Layer
            // 
            this.Hiden3Layer.Location = new System.Drawing.Point(7, 331);
            this.Hiden3Layer.Name = "Hiden3Layer";
            this.Hiden3Layer.Size = new System.Drawing.Size(120, 20);
            this.Hiden3Layer.TabIndex = 3;
            // 
            // Hiden2Layer
            // 
            this.Hiden2Layer.Location = new System.Drawing.Point(8, 290);
            this.Hiden2Layer.Name = "Hiden2Layer";
            this.Hiden2Layer.Size = new System.Drawing.Size(120, 20);
            this.Hiden2Layer.TabIndex = 2;
            // 
            // Hiden1Layer
            // 
            this.Hiden1Layer.Location = new System.Drawing.Point(8, 254);
            this.Hiden1Layer.Name = "Hiden1Layer";
            this.Hiden1Layer.Size = new System.Drawing.Size(120, 20);
            this.Hiden1Layer.TabIndex = 1;
            // 
            // inputLayer
            // 
            this.inputLayer.Location = new System.Drawing.Point(8, 214);
            this.inputLayer.Name = "inputLayer";
            this.inputLayer.Size = new System.Drawing.Size(120, 20);
            this.inputLayer.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.topPanel.Location = new System.Drawing.Point(139, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1500, 84);
            this.topPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Location = new System.Drawing.Point(139, 84);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1500, 684);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.mainPanel_Scroll);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 487);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiden3Layer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiden2Layer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiden1Layer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private RoundButton doStuffButton;
        private System.Windows.Forms.NumericUpDown OutputLayer;
        private System.Windows.Forms.NumericUpDown Hiden3Layer;
        private System.Windows.Forms.NumericUpDown Hiden2Layer;
        private System.Windows.Forms.NumericUpDown Hiden1Layer;
        private System.Windows.Forms.NumericUpDown inputLayer;
        private RoundButton generateButton;
    }
}

