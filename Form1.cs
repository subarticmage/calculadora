using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora5._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "Erro")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text != "Erro")
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text != "Erro")
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text != "Erro")
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text != "Erro")
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;
                DataTable dt = new DataTable();
                object result = dt.Compute(expression, "");
                textBox1.Text = result.ToString();
            }
            catch (SyntaxErrorException)
            {
                textBox1.Text = "Erro: Expressão inválida";
            }
            catch (DivideByZeroException)
            {
                textBox1.Text = "Erro: Divisão por zero";
            }
            catch (Exception ex)
            {
                textBox1.Text = "Erro";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
