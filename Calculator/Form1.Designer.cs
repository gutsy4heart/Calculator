namespace Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            textBox1 = new TextBox();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(9, 87);
            button1.Name = "button1";
            button1.Size = new Size(49, 44);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(64, 87);
            button2.Name = "button2";
            button2.Size = new Size(49, 44);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(119, 87);
            button3.Name = "button3";
            button3.Size = new Size(49, 44);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(119, 137);
            button4.Name = "button4";
            button4.Size = new Size(49, 44);
            button4.TabIndex = 5;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(64, 137);
            button5.Name = "button5";
            button5.Size = new Size(49, 44);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(9, 137);
            button6.Name = "button6";
            button6.Size = new Size(49, 44);
            button6.TabIndex = 3;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(119, 187);
            button7.Name = "button7";
            button7.Size = new Size(49, 44);
            button7.TabIndex = 8;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(64, 187);
            button8.Name = "button8";
            button8.Size = new Size(49, 44);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Control;
            button9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(9, 187);
            button9.Name = "button9";
            button9.Size = new Size(49, 44);
            button9.TabIndex = 6;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NumberButton_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Control;
            button10.FlatAppearance.BorderSize = 0;
            button10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(232, 137);
            button10.Name = "button10";
            button10.Size = new Size(49, 44);
            button10.TabIndex = 12;
            button10.Text = "/";
            button10.UseVisualStyleBackColor = false;
            button10.Click += OperationButton_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Control;
            button11.FlatAppearance.BorderSize = 0;
            button11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(177, 137);
            button11.Name = "button11";
            button11.Size = new Size(49, 44);
            button11.TabIndex = 11;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = false;
            button11.Click += OperationButton_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Control;
            button12.FlatAppearance.BorderSize = 0;
            button12.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(232, 87);
            button12.Name = "button12";
            button12.Size = new Size(49, 44);
            button12.TabIndex = 10;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += OperationButton_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.Control;
            button13.FlatAppearance.BorderSize = 0;
            button13.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(177, 87);
            button13.Name = "button13";
            button13.Size = new Size(49, 44);
            button13.TabIndex = 9;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += OperationButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 47);
            textBox1.TabIndex = 13;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.Control;
            button14.FlatAppearance.BorderSize = 0;
            button14.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(177, 187);
            button14.Name = "button14";
            button14.Size = new Size(49, 44);
            button14.TabIndex = 14;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = false;
            button14.Click += buttonDot_Click;
            // 
            // button15
            // 
            button15.Cursor = Cursors.Hand;
            button15.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(94, 237);
            button15.Name = "button15";
            button15.Size = new Size(132, 55);
            button15.TabIndex = 15;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonEqual_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.Control;
            button16.FlatAppearance.BorderSize = 0;
            button16.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(228, 187);
            button16.Name = "button16";
            button16.Size = new Size(49, 108);
            button16.TabIndex = 16;
            button16.Text = "C";
            button16.UseVisualStyleBackColor = false;
            button16.Click += buttonClear_Click;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.Control;
            button17.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(9, 237);
            button17.Name = "button17";
            button17.Size = new Size(49, 44);
            button17.TabIndex = 17;
            button17.Text = "0";
            button17.UseVisualStyleBackColor = false;
            button17.Click += NumberButton_Click;
            // 
            // Form1
            // 
            BackColor = Color.Pink;
            ClientSize = new Size(288, 315);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
    }
}
