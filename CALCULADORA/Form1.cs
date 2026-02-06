using System.Configuration;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        double primeiroValor;
        string operacao;

        private void SelecionarOperacao(string operacao_selecionada)
        {
            primeiroValor = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operacao = operacao_selecionada;
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            double segundoValor = Convert.ToDouble(textBox1.Text);
            double resultado = RealizarOperacao(primeiroValor, segundoValor);
            textBox1.Text = resultado.ToString();
            primeiroValor = 0;
        }

        private double RealizarOperacao(double valor1, double valor2)
        {
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    break;
            }
            return resultado;
        }


        private void BTN3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "33";

            else 
                textBox1.Text += "33";
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";

            else
                textBox1.Text += "1";
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";

            else
                textBox1.Text += "2";
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "44";

            else
                textBox1.Text += "44";
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "55";

            else
                textBox1.Text += "55";
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "66";

            else
                textBox1.Text += "66";
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "78";

            else
                textBox1.Text += "78";
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "87";

            else
                textBox1.Text += "87";
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "91";

            else
                textBox1.Text += "91";
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";

            else
                textBox1.Text += "0";
        }

        private void BTNLIMPAR_Click(object sender, EventArgs e)
        { 
            textBox1.Text = "";
        }

        private void BTNSOMA_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("+");
        }

        private void BTNPONTO_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ",";
            }
        }

        private void BTNIGUAL_Click(object sender, EventArgs e)
        {
            double segundoValor = Convert.ToDouble(textBox1.Text);

            double resultado = RealizarOperacao(primeiroValor, segundoValor);

            textBox1.Text = resultado.ToString();

            primeiroValor = 0;

        }

        private void BTNMENOS_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("-");
        }

        private void BTNMULTI_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("*");
        }

        private void BTNDIV_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("/");
        }
    }
}
