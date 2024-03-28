using System.Drawing;
using System.Drawing.Drawing2D;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double? FirstNumber;
        string? Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else textBox1.Text += button.Text;
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FirstNumber = double.Parse(textBox1.Text);
            Operation = button.Text;
            textBox1.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNumber = null;
            Operation = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (FirstNumber != null && Operation != null)
            {
                double SecondNumber = double.Parse(textBox1.Text);
                double Result = 0;
                switch (Operation)
                {
                    case "+":
                        Result = FirstNumber.Value + SecondNumber;
                        break;
                    case "-":
                        Result = FirstNumber.Value - SecondNumber;
                        break;
                    case "*":
                        Result = FirstNumber.Value * SecondNumber;
                        break;
                    case "/":
                        if (SecondNumber == 0)
                        {
                            textBox1.Text = "Cannot divide by zero";
                            return;
                        }
                        Result = FirstNumber.Value / SecondNumber;
                        break;
                    
                }

                textBox1.Text = Result.ToString();
                FirstNumber = Result;
                Operation = null;
            }
        }

        private void Form1_Load(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Operation != "")
            {
                double percentVal = double.Parse(textBox1.Text);
                double percentage = percentVal / 100;
                textBox1.Text = percentage.ToString();
            }
            else if (Operation == "")
            {
                double percentVal = double.Parse(textBox1.Text);
                double percentage = percentVal / 100;
                textBox1.Text = percentage.ToString();
            }         
        }

       
    }
}


