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
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputButton = new Prohect2.RoundButton();
            this.outputButton = new Prohect2.RoundButton();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftPanel.Controls.Add(this.outputButton);
            this.leftPanel.Controls.Add(this.inputButton);
            this.leftPanel.Controls.Add(this.generateButton);
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
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.topPanel.Location = new System.Drawing.Point(139, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1550, 84);
            this.topPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Location = new System.Drawing.Point(139, 84);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1550, 684);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainPanel_Scroll);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.inputButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.inputButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.inputButton.BorderRadius = 10;
            this.inputButton.BorderSize = 0;
            this.inputButton.Enabled = false;
            this.inputButton.FlatAppearance.BorderSize = 0;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.ForeColor = System.Drawing.Color.White;
            this.inputButton.Location = new System.Drawing.Point(12, 148);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(115, 40);
            this.inputButton.TabIndex = 7;
            this.inputButton.Text = "Change Input Values";
            this.inputButton.TextColor = System.Drawing.Color.White;
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.outputButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.outputButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.outputButton.BorderRadius = 10;
            this.outputButton.BorderSize = 0;
            this.outputButton.Enabled = false;
            this.outputButton.FlatAppearance.BorderSize = 0;
            this.outputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputButton.ForeColor = System.Drawing.Color.White;
            this.outputButton.Location = new System.Drawing.Point(12, 194);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(115, 40);
            this.outputButton.TabIndex = 8;
            this.outputButton.Text = "Show Output Values";
            this.outputButton.TextColor = System.Drawing.Color.White;
            this.outputButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 581);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private RoundButton generateButton;
        private RoundButton outputButton;
        private RoundButton inputButton;
    }
}

