namespace radiation_checker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ele1Label = new System.Windows.Forms.TextBox();
            this.ele1MassNum = new System.Windows.Forms.TextBox();
            this.ele1AtomNum = new System.Windows.Forms.TextBox();
            this.eminus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ele2AtomNum = new System.Windows.Forms.TextBox();
            this.ele2MassNum = new System.Windows.Forms.TextBox();
            this.ele2Label = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ele3AtomNum = new System.Windows.Forms.TextBox();
            this.ele3MassNum = new System.Windows.Forms.TextBox();
            this.ele3Label = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ele4AtomNum = new System.Windows.Forms.TextBox();
            this.ele4MassNum = new System.Windows.Forms.TextBox();
            this.ele4Label = new System.Windows.Forms.TextBox();
            this.decayButton = new System.Windows.Forms.Button();
            this.ele2FullName = new System.Windows.Forms.Label();
            this.ele3FullName = new System.Windows.Forms.Label();
            this.ele4FullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alpha decay (α)",
            "Beta decay (β) ",
            "Positron emission (β+)",
            "Electron capture (e−)"});
            this.comboBox1.Location = new System.Drawing.Point(211, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ele1Label
            // 
            this.ele1Label.BackColor = System.Drawing.Color.White;
            this.ele1Label.Location = new System.Drawing.Point(49, 18);
            this.ele1Label.MaxLength = 3;
            this.ele1Label.Name = "ele1Label";
            this.ele1Label.ReadOnly = true;
            this.ele1Label.Size = new System.Drawing.Size(43, 20);
            this.ele1Label.TabIndex = 1;
            // 
            // ele1MassNum
            // 
            this.ele1MassNum.Location = new System.Drawing.Point(5, 5);
            this.ele1MassNum.MaxLength = 3;
            this.ele1MassNum.Name = "ele1MassNum";
            this.ele1MassNum.Size = new System.Drawing.Size(40, 20);
            this.ele1MassNum.TabIndex = 4;
            // 
            // ele1AtomNum
            // 
            this.ele1AtomNum.Location = new System.Drawing.Point(5, 31);
            this.ele1AtomNum.MaxLength = 3;
            this.ele1AtomNum.Name = "ele1AtomNum";
            this.ele1AtomNum.Size = new System.Drawing.Size(40, 20);
            this.ele1AtomNum.TabIndex = 5;
            this.ele1AtomNum.TextChanged += new System.EventHandler(this.ele1AtomNum_TextChanged);
            // 
            // eminus
            // 
            this.eminus.BackColor = System.Drawing.Color.White;
            this.eminus.Location = new System.Drawing.Point(151, 19);
            this.eminus.MaxLength = 2;
            this.eminus.Name = "eminus";
            this.eminus.ReadOnly = true;
            this.eminus.Size = new System.Drawing.Size(39, 20);
            this.eminus.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "↓";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decay mode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Starting element";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "e- for EC";
            // 
            // ele2AtomNum
            // 
            this.ele2AtomNum.BackColor = System.Drawing.Color.White;
            this.ele2AtomNum.Location = new System.Drawing.Point(12, 117);
            this.ele2AtomNum.MaxLength = 3;
            this.ele2AtomNum.Name = "ele2AtomNum";
            this.ele2AtomNum.ReadOnly = true;
            this.ele2AtomNum.Size = new System.Drawing.Size(40, 20);
            this.ele2AtomNum.TabIndex = 16;
            // 
            // ele2MassNum
            // 
            this.ele2MassNum.BackColor = System.Drawing.Color.White;
            this.ele2MassNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ele2MassNum.Location = new System.Drawing.Point(12, 91);
            this.ele2MassNum.MaxLength = 3;
            this.ele2MassNum.Name = "ele2MassNum";
            this.ele2MassNum.ReadOnly = true;
            this.ele2MassNum.Size = new System.Drawing.Size(40, 20);
            this.ele2MassNum.TabIndex = 15;
            // 
            // ele2Label
            // 
            this.ele2Label.BackColor = System.Drawing.Color.White;
            this.ele2Label.Location = new System.Drawing.Point(56, 104);
            this.ele2Label.MaxLength = 3;
            this.ele2Label.Name = "ele2Label";
            this.ele2Label.ReadOnly = true;
            this.ele2Label.Size = new System.Drawing.Size(43, 20);
            this.ele2Label.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "+";
            // 
            // ele3AtomNum
            // 
            this.ele3AtomNum.BackColor = System.Drawing.Color.White;
            this.ele3AtomNum.Location = new System.Drawing.Point(124, 118);
            this.ele3AtomNum.MaxLength = 3;
            this.ele3AtomNum.Name = "ele3AtomNum";
            this.ele3AtomNum.ReadOnly = true;
            this.ele3AtomNum.Size = new System.Drawing.Size(40, 20);
            this.ele3AtomNum.TabIndex = 20;
            // 
            // ele3MassNum
            // 
            this.ele3MassNum.BackColor = System.Drawing.Color.White;
            this.ele3MassNum.Location = new System.Drawing.Point(124, 92);
            this.ele3MassNum.MaxLength = 3;
            this.ele3MassNum.Name = "ele3MassNum";
            this.ele3MassNum.ReadOnly = true;
            this.ele3MassNum.Size = new System.Drawing.Size(40, 20);
            this.ele3MassNum.TabIndex = 19;
            // 
            // ele3Label
            // 
            this.ele3Label.BackColor = System.Drawing.Color.White;
            this.ele3Label.Location = new System.Drawing.Point(168, 105);
            this.ele3Label.MaxLength = 3;
            this.ele3Label.Name = "ele3Label";
            this.ele3Label.ReadOnly = true;
            this.ele3Label.Size = new System.Drawing.Size(43, 20);
            this.ele3Label.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "+";
            // 
            // ele4AtomNum
            // 
            this.ele4AtomNum.BackColor = System.Drawing.Color.White;
            this.ele4AtomNum.Location = new System.Drawing.Point(232, 117);
            this.ele4AtomNum.MaxLength = 3;
            this.ele4AtomNum.Name = "ele4AtomNum";
            this.ele4AtomNum.ReadOnly = true;
            this.ele4AtomNum.Size = new System.Drawing.Size(40, 20);
            this.ele4AtomNum.TabIndex = 24;
            // 
            // ele4MassNum
            // 
            this.ele4MassNum.BackColor = System.Drawing.Color.White;
            this.ele4MassNum.Location = new System.Drawing.Point(232, 91);
            this.ele4MassNum.MaxLength = 3;
            this.ele4MassNum.Name = "ele4MassNum";
            this.ele4MassNum.ReadOnly = true;
            this.ele4MassNum.Size = new System.Drawing.Size(40, 20);
            this.ele4MassNum.TabIndex = 23;
            // 
            // ele4Label
            // 
            this.ele4Label.BackColor = System.Drawing.Color.White;
            this.ele4Label.Location = new System.Drawing.Point(276, 104);
            this.ele4Label.MaxLength = 3;
            this.ele4Label.Name = "ele4Label";
            this.ele4Label.ReadOnly = true;
            this.ele4Label.Size = new System.Drawing.Size(43, 20);
            this.ele4Label.TabIndex = 22;
            // 
            // decayButton
            // 
            this.decayButton.Location = new System.Drawing.Point(233, 55);
            this.decayButton.Name = "decayButton";
            this.decayButton.Size = new System.Drawing.Size(75, 30);
            this.decayButton.TabIndex = 25;
            this.decayButton.Text = "Decay!";
            this.decayButton.UseVisualStyleBackColor = true;
            this.decayButton.Click += new System.EventHandler(this.decayButton_Click);
            // 
            // ele2FullName
            // 
            this.ele2FullName.AutoSize = true;
            this.ele2FullName.Location = new System.Drawing.Point(35, 140);
            this.ele2FullName.Name = "ele2FullName";
            this.ele2FullName.Size = new System.Drawing.Size(34, 13);
            this.ele2FullName.TabIndex = 26;
            this.ele2FullName.Text = "Blank";
            // 
            // ele3FullName
            // 
            this.ele3FullName.AutoSize = true;
            this.ele3FullName.Location = new System.Drawing.Point(148, 140);
            this.ele3FullName.Name = "ele3FullName";
            this.ele3FullName.Size = new System.Drawing.Size(34, 13);
            this.ele3FullName.TabIndex = 27;
            this.ele3FullName.Text = "Blank";
            // 
            // ele4FullName
            // 
            this.ele4FullName.AutoSize = true;
            this.ele4FullName.Location = new System.Drawing.Point(254, 140);
            this.ele4FullName.Name = "ele4FullName";
            this.ele4FullName.Size = new System.Drawing.Size(34, 13);
            this.ele4FullName.TabIndex = 28;
            this.ele4FullName.Text = "Blank";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 159);
            this.Controls.Add(this.ele4FullName);
            this.Controls.Add(this.ele3FullName);
            this.Controls.Add(this.ele2FullName);
            this.Controls.Add(this.decayButton);
            this.Controls.Add(this.ele4AtomNum);
            this.Controls.Add(this.ele4MassNum);
            this.Controls.Add(this.ele4Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ele3AtomNum);
            this.Controls.Add(this.ele3MassNum);
            this.Controls.Add(this.ele3Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ele2AtomNum);
            this.Controls.Add(this.ele2MassNum);
            this.Controls.Add(this.ele2Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eminus);
            this.Controls.Add(this.ele1AtomNum);
            this.Controls.Add(this.ele1MassNum);
            this.Controls.Add(this.ele1Label);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Decay calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox ele1Label;
        private System.Windows.Forms.TextBox ele1MassNum;
        private System.Windows.Forms.TextBox ele1AtomNum;
        private System.Windows.Forms.TextBox eminus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ele2AtomNum;
        private System.Windows.Forms.TextBox ele2MassNum;
        private System.Windows.Forms.TextBox ele2Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ele3AtomNum;
        private System.Windows.Forms.TextBox ele3MassNum;
        private System.Windows.Forms.TextBox ele3Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ele4AtomNum;
        private System.Windows.Forms.TextBox ele4MassNum;
        private System.Windows.Forms.TextBox ele4Label;
        private System.Windows.Forms.Button decayButton;
        private System.Windows.Forms.Label ele2FullName;
        private System.Windows.Forms.Label ele3FullName;
        private System.Windows.Forms.Label ele4FullName;
    }
}

