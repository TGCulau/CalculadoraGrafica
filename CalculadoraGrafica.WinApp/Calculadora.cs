using CalculadoraGrafica.WinApp.Properties;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraGrafica.WinApp
{
    public partial class TelaCalculadora : Form
    {
        #region Caixa de variaveis de controle
        public bool eAdicao = false; //Ok
        public bool eSubtracao = false; //Ok
        public bool eMultiplicacao = false; //Ok
        public bool eDivisao = false;
        public bool ePorcentagem = false;
        public bool eXQuadrado = false;
        public bool eFracao = false;
        public decimal valor1 = 0;
        public decimal valor2 = 0;
        public string textoDoHitoricoAtual = "";
        #endregion

        #region Incialização de coisas
        private Point mouseDownLocation;
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        #endregion

        #region Construtor
        public TelaCalculadora()
        {
            InitializeComponent();
            panelCabecalho.MouseDown += PanelDrag_MouseDown;
            panelCabecalho.MouseMove += PanelDrag_MouseMove;
            timer1.Interval = 10; // Define o intervalo do timer
            timer1.Tick += new EventHandler(timer1_Tick); // Adiciona o evento Tick
            this.KeyPreview = true;
            this.KeyDown += TeclaMais;
            this.KeyDown += TeclaMenos;
            this.KeyDown += TeclaMultiplicacao;
            this.KeyDown += TeclaDivisao;
            TxtBEntrada.Enter += TxtBEntrada_TextChanged;
        }
        #endregion

        #region Minimizar com efeito
        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            //Inicia o timer
            timer1.Start();
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                //Reduz a opacidade em 5%
                this.Opacity -= 0.05;
            }
            else
            {
                // Minimiza a janela quando a opacidade chega a 0
                this.WindowState = FormWindowState.Minimized;
                //Restaura a opacidade para 1
                this.Opacity = 1;
                //Para o timer
                timer1.Stop();
            }
        }
        #endregion

        #region Fazer a janela se mecher
        private void PanelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseDownLocation = e.Location;
        }
        private void PanelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseDownLocation.X;
                this.Top += e.Y - mouseDownLocation.Y;
            }
        }
        #endregion

        #region Carrega atributos especificos (Load)
        private void Calculadora_Load(object sender, EventArgs e)
        {
            // Defina a opacidade inicial do formulário
            this.Opacity = 1.0;
        }
        #endregion

        #region Botão de saida
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Caixa de texto principal
        #region Verificação se está digitando apenas numeros
        public string AuxiliarDoTXTBox = "0";
        private void TxtBEntrada_TextChanged(object sender, EventArgs e)
        {
            TxtBEntrada.DeselectAll();
            int posicaoCursor = TxtBEntrada.SelectionStart;

            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBEntrada.Text, "[0-9,]$"))
            {
                AuxiliarDoTXTBox = TxtBEntrada.Text;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBEntrada.Text, "[^0-9,]"))
            {
                if (TxtBEntrada.Text == "0")
                {
                    TxtBEntrada.Text = TxtBEntrada.Text.Remove(TxtBEntrada.Text.Length - 1);
                    TxtBEntrada.Text = "0";
                }
                else
                {
                    TxtBEntrada.Text = TxtBEntrada.Text.Remove(TxtBEntrada.Text.Length - 1);
                    TxtBEntrada.Text = AuxiliarDoTXTBox;
                }
            }
            TxtBEntrada.SelectionStart = posicaoCursor;
        }
        #endregion
        #endregion

        #region Teclado Numerico
        private void buttonN0_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "0";
            }
            else
            {
                TxtBEntrada.Text += "0";
            }
        }
        private void buttonN1_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "1";
            }
            else
            {
                TxtBEntrada.Text += "1";
            }
        }
        private void buttonN2_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "2";
            }
            else
            {
                TxtBEntrada.Text += "2";
            }
        }
        private void buttonN3_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "3";
            }
            else
            {
                TxtBEntrada.Text += "3";
            }
        }
        private void buttonN4_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "4";
            }
            else
            {
                TxtBEntrada.Text += "4";
            }
        }
        private void buttonN5_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "5";
            }
            else
            {
                TxtBEntrada.Text += "5";
            }
        }
        private void buttonN6_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "6";
            }
            else
            {
                TxtBEntrada.Text += "6";
            }
        }
        private void buttonN7_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "7";
            }
            else
            {
                TxtBEntrada.Text += "7";
            }
        }
        private void buttonN8_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "8";
            }
            else
            {
                TxtBEntrada.Text += "8";
            }
        }
        private void buttonN9_Click(object sender, EventArgs e)
        {
            if (TxtBEntrada.Text == "0")
            {
                TxtBEntrada.Text = "9";
            }
            else
            {
                TxtBEntrada.Text += "9";
            }
        }
        #endregion

        #region Botões de operações básicas
        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            EventosDeAdicao();
        }
        private void TeclaMais(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                EventosDeAdicao();
            }
        }
        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            EventosDeSubtracao();
        }
        private void TeclaMenos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                EventosDeSubtracao();
            }
        }
        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            EventosDeMultiplicacao();
        }
        private void TeclaMultiplicacao(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                EventosDeMultiplicacao();
            }
        }
        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            EventosDeDivisao();
        }
        private void TeclaDivisao(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                EventosDeDivisao();
            }
        }
        private void buttonRaizQuadrada_Click(object sender, EventArgs e)
        {
            double valorDaRaiz = Convert.ToDouble(TxtBEntrada.Text);
            textoDoHitoricoAtual = $"√({valorDaRaiz})";
            textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
            valorDaRaiz = Math.Sqrt(valorDaRaiz);
            TxtBEntrada.Text = Convert.ToString(valorDaRaiz);
        }
        private void buttonXQuadrado_Click(object sender, EventArgs e)
        {
            double valorAoQuadrado = Convert.ToDouble(TxtBEntrada.Text);
            textoDoHitoricoAtual = $"sqr({valorAoQuadrado})";
            textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
            valorAoQuadrado = valorAoQuadrado * valorAoQuadrado;
            TxtBEntrada.Text = Convert.ToString(valorAoQuadrado);
        }
        private void buttonFracao_Click(object sender, EventArgs e)
        {
            double valorDividioPorUm = Convert.ToDouble(TxtBEntrada.Text);
            textoDoHitoricoAtual = $"1/({valorDividioPorUm})";
            textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
            valorDividioPorUm = 1.0 / valorDividioPorUm;
            TxtBEntrada.Text = Convert.ToString(valorDividioPorUm);
        }
        #endregion

        #region Botao Igual
        private void buttonResultado_Click(object sender, EventArgs e)
        {
            if (eAdicao)
            {
                eAdicao = false;
                textoDoHitoricoAtual += TxtBEntrada.Text + " = ";
                textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
                valor2 = Convert.ToDecimal(TxtBEntrada.Text);
                decimal aux = valor1 + valor2;
                string resultado = Convert.ToString(aux);
                TxtBEntrada.Text = resultado;
            }

            if (eSubtracao)
            {
                eSubtracao = false;
                textoDoHitoricoAtual += TxtBEntrada.Text + " = ";
                textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
                valor2 = Convert.ToDecimal(TxtBEntrada.Text);
                decimal aux = valor1 - valor2;
                string resultado = Convert.ToString(aux);
                TxtBEntrada.Text = resultado;
            }

            if (eMultiplicacao)
            {
                eSubtracao = false;
                textoDoHitoricoAtual += TxtBEntrada.Text + " = ";
                textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
                valor2 = Convert.ToDecimal(TxtBEntrada.Text);
                decimal aux = valor1 * valor2;
                string resultado = Convert.ToString(aux);
                TxtBEntrada.Text = resultado;
            }

            if (eDivisao)
            {
                eSubtracao = false;
                textoDoHitoricoAtual += TxtBEntrada.Text + " = ";
                textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
                valor2 = Convert.ToDecimal(TxtBEntrada.Text);
                decimal aux = valor1 / valor2;
                string resultado = Convert.ToString(aux);
                TxtBEntrada.Text = resultado;
            }

        }
        #endregion


        #region Limpa a tela quando digitar proximo numero
        public void LimpaAoDigitarTxtBEntrada(object sender, KeyEventArgs e)
        {
            //Verifica se a tecla pressionada é entre 0 e 9
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                TxtBEntrada.Text = string.Empty;
            }
        }
        #endregion


        #region Funcoes
        public void EventosDeAdicao()
        {
            valor1 = Convert.ToDecimal(TxtBEntrada.Text);
            textoDoHitoricoAtual = TxtBEntrada.Text + " + ";
            textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
            TxtBEntrada.Text = "0";
            eMultiplicacao = true;
        }
        public void EventosDeSubtracao()
        {
            valor1 = Convert.ToDecimal(TxtBEntrada.Text);
            textoDoHitoricoAtual = TxtBEntrada.Text + " - ";
            textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
            TxtBEntrada.Text = "0";
            eSubtracao = true;
        }
        public void EventosDeMultiplicacao()
        {
            valor1 = Convert.ToDecimal(TxtBEntrada.Text);
            textoDoHitoricoAtual = TxtBEntrada.Text + " X ";
            textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
            TxtBEntrada.Text = "0";
            eSubtracao = true;
        }
        public void EventosDeDivisao()
        {
            valor1 = Convert.ToDecimal(TxtBEntrada.Text);
            textoDoHitoricoAtual = TxtBEntrada.Text + " / ";
            textBoxHistoricoAtual.Text = textoDoHitoricoAtual;
            TxtBEntrada.Text = "0";
            eSubtracao = true;
        }
        #endregion



        
    }
}