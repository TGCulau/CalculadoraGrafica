using CalculadoraGrafica.WinApp.Properties;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraGrafica.WinApp
{
    public partial class TelaCalculadora : Form
    {
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

        #region Carrega atributos especificas
        private void Calculadora_Load(object sender, EventArgs e)
        {
            // Defina a opacidade inicial do formulário
            this.Opacity = 1.0;
        }
        #endregion

        #region Verificação se está digitando apenas numeros
        public string aux = "0";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int posicaoCursor = TxtBEntrada.SelectionStart;

            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBEntrada.Text, "[0-9]$"))
            {
                aux = TxtBEntrada.Text;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBEntrada.Text, "[^0-9]"))
            {
                if (TxtBEntrada.Text == "0")
                {
                    TxtBEntrada.Text = TxtBEntrada.Text.Remove(TxtBEntrada.Text.Length - 1);
                    TxtBEntrada.Text = "0";
                }
                else
                {
                    TxtBEntrada.Text = TxtBEntrada.Text.Remove(TxtBEntrada.Text.Length - 1);
                    TxtBEntrada.Text = aux;
                }
            }

            TxtBEntrada.SelectionStart = posicaoCursor;
        }
        #endregion

        #region Botão de saida
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void buttonN1_Click(object sender, EventArgs e)
        {

        }

    }
}