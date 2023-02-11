namespace CalculadoraC_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal valor1=0, valor2=0, resultado=0;
        char operacao;

        private void potenciacao_Click(object sender, EventArgs e)
        {
            if (telaResposta.Text.Length != 0)
            {
                valor1 = decimal.Parse(telaResposta.Text);
                resultado = (valor1 * valor1);
                telaResposta.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Insira um número para efetuar a potenciação.");
            }
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            if (telaResposta.Text.Length != 0)
            {
                valor1 = decimal.Parse(telaResposta.Text);
                resultado = (valor1 / 100);
                telaResposta.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Insira um número para efetuar a porcentagem.");
            }
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (telaResposta.Text.Length != 0 && telaResposta.Text != ",")
            {
                telaResposta.Text += ",";
            }
            else
            {
                MessageBox.Show("Você não pode colocar vírgula!");
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            telaResposta.Text += "9";
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            operacao = '+';
            if (telaResposta.Text.Length != 0)
            {
                valor1 = decimal.Parse(telaResposta.Text);
                telaResposta.Text = "";
            }
            else
            {
                MessageBox.Show("Insira dois valores para efetuar a adição.");
            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            operacao = '-';
            if (telaResposta.Text.Length != 0)
            {
                valor1 = decimal.Parse(telaResposta.Text);
                telaResposta.Text = "";
            }
            else
            {
                MessageBox.Show("Insira dois valores para efetuar a subtração.");
            }
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            operacao = '*';
            if (telaResposta.Text.Length != 0)
            {
                valor1 = decimal.Parse(telaResposta.Text);
                telaResposta.Text = "";
            }
            else
            {
                MessageBox.Show("Insira dois valores para efetuar a multiplicação.");
            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if(telaResposta.Text.Length != 0)
            {
                operacao = '/';
                valor1 = decimal.Parse(telaResposta.Text);
                telaResposta.Text = "";
            }
            else
            {
                MessageBox.Show("Insira dois valores para efetuar a divisão.");
            }
        }

        private void igualdade_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(telaResposta.Text);

            if (operacao == '+')
            {
                resultado = (valor1 + valor2);
            }
            else if (operacao == '-')
            {
                resultado = (valor1 - valor2);
            }
            else if (operacao == '*')
            {
                resultado = (valor1 * valor2);
            }
            else
            {
                resultado = (valor1 / valor2);
            }

            telaResposta.Text = Convert.ToString(resultado);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            telaResposta.Text = "";
        }
    }
}