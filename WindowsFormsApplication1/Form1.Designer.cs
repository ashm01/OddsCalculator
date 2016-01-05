namespace WindowsFormsApplication1
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
            this.line1Input = new System.Windows.Forms.TextBox();
            this.line1Label = new System.Windows.Forms.Label();
            this.line2Input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stakeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decimalRadioButton = new System.Windows.Forms.RadioButton();
            this.fractionRadioButton = new System.Windows.Forms.RadioButton();
            this.line3Input = new System.Windows.Forms.TextBox();
            this.line4Input = new System.Windows.Forms.TextBox();
            this.line5Input = new System.Windows.Forms.TextBox();
            this.line2Label = new System.Windows.Forms.Label();
            this.line3Label = new System.Windows.Forms.Label();
            this.line4Label = new System.Windows.Forms.Label();
            this.line5Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // line1Input
            // 
            this.line1Input.Location = new System.Drawing.Point(133, 158);
            this.line1Input.Name = "line1Input";
            this.line1Input.Size = new System.Drawing.Size(100, 20);
            this.line1Input.TabIndex = 0;
            // 
            // line1Label
            // 
            this.line1Label.AutoSize = true;
            this.line1Label.Location = new System.Drawing.Point(92, 164);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(39, 13);
            this.line1Label.TabIndex = 4;
            this.line1Label.Text = "Line 1:";
            // 
            // line2Input
            // 
            this.line2Input.Location = new System.Drawing.Point(133, 184);
            this.line2Input.Name = "line2Input";
            this.line2Input.Size = new System.Drawing.Size(100, 20);
            this.line2Input.TabIndex = 5;
            this.line2Input.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stakeInput
            // 
            this.stakeInput.Location = new System.Drawing.Point(134, 82);
            this.stakeInput.Name = "stakeInput";
            this.stakeInput.Size = new System.Drawing.Size(100, 20);
            this.stakeInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stake:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Return:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // decimalRadioButton
            // 
            this.decimalRadioButton.AutoSize = true;
            this.decimalRadioButton.Location = new System.Drawing.Point(95, 34);
            this.decimalRadioButton.Name = "decimalRadioButton";
            this.decimalRadioButton.Size = new System.Drawing.Size(63, 17);
            this.decimalRadioButton.TabIndex = 12;
            this.decimalRadioButton.TabStop = true;
            this.decimalRadioButton.Text = "Decimal";
            this.decimalRadioButton.UseVisualStyleBackColor = true;
            // 
            // fractionRadioButton
            // 
            this.fractionRadioButton.AutoSize = true;
            this.fractionRadioButton.Location = new System.Drawing.Point(184, 34);
            this.fractionRadioButton.Name = "fractionRadioButton";
            this.fractionRadioButton.Size = new System.Drawing.Size(63, 17);
            this.fractionRadioButton.TabIndex = 13;
            this.fractionRadioButton.TabStop = true;
            this.fractionRadioButton.Text = "Fraction";
            this.fractionRadioButton.UseVisualStyleBackColor = true;
            // 
            // line3Input
            // 
            this.line3Input.Location = new System.Drawing.Point(133, 210);
            this.line3Input.Name = "line3Input";
            this.line3Input.Size = new System.Drawing.Size(100, 20);
            this.line3Input.TabIndex = 14;
            this.line3Input.Visible = false;
            // 
            // line4Input
            // 
            this.line4Input.Location = new System.Drawing.Point(133, 236);
            this.line4Input.Name = "line4Input";
            this.line4Input.Size = new System.Drawing.Size(100, 20);
            this.line4Input.TabIndex = 15;
            this.line4Input.Visible = false;
            // 
            // line5Input
            // 
            this.line5Input.Location = new System.Drawing.Point(133, 262);
            this.line5Input.Name = "line5Input";
            this.line5Input.Size = new System.Drawing.Size(100, 20);
            this.line5Input.TabIndex = 16;
            this.line5Input.Visible = false;
            // 
            // line2Label
            // 
            this.line2Label.AutoSize = true;
            this.line2Label.Location = new System.Drawing.Point(92, 191);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(39, 13);
            this.line2Label.TabIndex = 17;
            this.line2Label.Text = "Line 2:";
            this.line2Label.Visible = false;
            // 
            // line3Label
            // 
            this.line3Label.AutoSize = true;
            this.line3Label.Location = new System.Drawing.Point(92, 217);
            this.line3Label.Name = "line3Label";
            this.line3Label.Size = new System.Drawing.Size(39, 13);
            this.line3Label.TabIndex = 18;
            this.line3Label.Text = "Line 3:";
            this.line3Label.Visible = false;
            // 
            // line4Label
            // 
            this.line4Label.AutoSize = true;
            this.line4Label.Location = new System.Drawing.Point(92, 243);
            this.line4Label.Name = "line4Label";
            this.line4Label.Size = new System.Drawing.Size(39, 13);
            this.line4Label.TabIndex = 19;
            this.line4Label.Text = "Line 4:";
            this.line4Label.Visible = false;
            // 
            // line5Label
            // 
            this.line5Label.AutoSize = true;
            this.line5Label.Location = new System.Drawing.Point(92, 269);
            this.line5Label.Name = "line5Label";
            this.line5Label.Size = new System.Drawing.Size(39, 13);
            this.line5Label.TabIndex = 20;
            this.line5Label.Text = "Line 5:";
            this.line5Label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Number of lines:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(182, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 384);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line5Label);
            this.Controls.Add(this.line4Label);
            this.Controls.Add(this.line3Label);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.line5Input);
            this.Controls.Add(this.line4Input);
            this.Controls.Add(this.line3Input);
            this.Controls.Add(this.fractionRadioButton);
            this.Controls.Add(this.decimalRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stakeInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.line2Input);
            this.Controls.Add(this.line1Label);
            this.Controls.Add(this.line1Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox line1Input;
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.TextBox line2Input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stakeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton decimalRadioButton;
        private System.Windows.Forms.RadioButton fractionRadioButton;
        private System.Windows.Forms.TextBox line3Input;
        private System.Windows.Forms.TextBox line4Input;
        private System.Windows.Forms.TextBox line5Input;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.Label line3Label;
        private System.Windows.Forms.Label line4Label;
        private System.Windows.Forms.Label line5Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

