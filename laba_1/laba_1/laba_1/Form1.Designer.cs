namespace laba_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            sizeBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(631, 81);
            label1.TabIndex = 0;
            label1.Text = "Boots Size Colculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(34, 119);
            label2.Name = "label2";
            label2.Size = new Size(277, 41);
            label2.TabIndex = 2;
            label2.Text = "Enter your size (sm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(49, 187);
            label3.Name = "label3";
            label3.Size = new Size(251, 41);
            label3.TabIndex = 3;
            label3.Text = "Choose a country";
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(49, 258);
            button1.Name = "button1";
            button1.Size = new Size(262, 96);
            button1.TabIndex = 4;
            button1.Text = "PRINT THE ASVER =>";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Wheat;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "American", "Russian", "European" });
            comboBox1.Location = new Point(344, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 33);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(329, 281);
            label4.Name = "label4";
            label4.Size = new Size(0, 54);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(342, 169);
            label5.Name = "label5";
            label5.Size = new Size(0, 54);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(454, 281);
            label6.Name = "label6";
            label6.Size = new Size(0, 54);
            label6.TabIndex = 8;
            // 
            // sizeBox
            // 
            sizeBox.Location = new Point(344, 129);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(264, 31);
            sizeBox.TabIndex = 9;
            sizeBox.KeyPress += sizeBox_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(721, 392);
            Controls.Add(sizeBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox sizeBox;
    }
}
