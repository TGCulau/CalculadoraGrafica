using System.Windows.Forms.Design;

namespace CalculadoraGrafica.WinApp
{
    partial class TelaCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCalculadora));
            TxtBEntrada = new TextBox();
            lblTipoDaCalculadora = new Label();
            buttonCE = new Button();
            buttonPorcentagem = new Button();
            buttonC = new Button();
            buttonApagar = new Button();
            buttonN7 = new Button();
            buttonXQuadrado = new Button();
            buttonRaizQuadrada = new Button();
            buttonDivisao = new Button();
            buttonMultiplicacao = new Button();
            buttonSubtracao = new Button();
            buttonAdicao = new Button();
            buttonResultado = new Button();
            buttonN8 = new Button();
            buttonN9 = new Button();
            buttonFracao = new Button();
            buttonN4 = new Button();
            buttonN5 = new Button();
            buttonN6 = new Button();
            buttonN1 = new Button();
            buttonN2 = new Button();
            buttonN3 = new Button();
            buttonN0 = new Button();
            buttonInverterSinal = new Button();
            buttonVirgula = new Button();
            button1 = new Button();
            label1 = new Label();
            buttonSair = new Button();
            label2 = new Label();
            panelCabecalho = new Panel();
            splitter1 = new Splitter();
            buttonMinimizar = new Button();
            panelCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBEntrada
            // 
            TxtBEntrada.BackColor = Color.FromArgb(31, 31, 31);
            TxtBEntrada.BorderStyle = BorderStyle.None;
            TxtBEntrada.Font = new Font("Segoe UI Semibold", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBEntrada.ForeColor = Color.White;
            TxtBEntrada.Location = new Point(2, 103);
            TxtBEntrada.Multiline = true;
            TxtBEntrada.Name = "TxtBEntrada";
            TxtBEntrada.Size = new Size(317, 56);
            TxtBEntrada.TabIndex = 0;
            TxtBEntrada.Text = "0";
            TxtBEntrada.TextAlign = HorizontalAlignment.Right;
            TxtBEntrada.TextChanged += textBox1_TextChanged;
            // 
            // lblTipoDaCalculadora
            // 
            lblTipoDaCalculadora.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDaCalculadora.ForeColor = Color.White;
            lblTipoDaCalculadora.Image = (Image)resources.GetObject("lblTipoDaCalculadora.Image");
            lblTipoDaCalculadora.Location = new Point(4, 38);
            lblTipoDaCalculadora.Name = "lblTipoDaCalculadora";
            lblTipoDaCalculadora.Size = new Size(234, 41);
            lblTipoDaCalculadora.TabIndex = 1;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = Color.FromArgb(20, 20, 20);
            buttonCE.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonCE.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonCE.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonCE.FlatStyle = FlatStyle.Flat;
            buttonCE.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCE.ForeColor = Color.White;
            buttonCE.Location = new Point(84, 198);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(76, 52);
            buttonCE.TabIndex = 2;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            // 
            // buttonPorcentagem
            // 
            buttonPorcentagem.BackColor = Color.FromArgb(20, 20, 20);
            buttonPorcentagem.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonPorcentagem.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonPorcentagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonPorcentagem.FlatStyle = FlatStyle.Flat;
            buttonPorcentagem.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPorcentagem.ForeColor = Color.White;
            buttonPorcentagem.Location = new Point(6, 198);
            buttonPorcentagem.Name = "buttonPorcentagem";
            buttonPorcentagem.Size = new Size(76, 52);
            buttonPorcentagem.TabIndex = 2;
            buttonPorcentagem.Text = "%";
            buttonPorcentagem.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(20, 20, 20);
            buttonC.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonC.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonC.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonC.FlatStyle = FlatStyle.Flat;
            buttonC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonC.ForeColor = Color.White;
            buttonC.Location = new Point(162, 198);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(76, 52);
            buttonC.TabIndex = 2;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonApagar
            // 
            buttonApagar.BackColor = Color.FromArgb(20, 20, 20);
            buttonApagar.BackgroundImage = (Image)resources.GetObject("buttonApagar.BackgroundImage");
            buttonApagar.BackgroundImageLayout = ImageLayout.Center;
            buttonApagar.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonApagar.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonApagar.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonApagar.FlatStyle = FlatStyle.Flat;
            buttonApagar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApagar.ForeColor = Color.White;
            buttonApagar.Location = new Point(240, 198);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(76, 52);
            buttonApagar.TabIndex = 2;
            buttonApagar.UseVisualStyleBackColor = false;
            // 
            // buttonN7
            // 
            buttonN7.BackColor = Color.FromArgb(6, 6, 6);
            buttonN7.BackgroundImageLayout = ImageLayout.Center;
            buttonN7.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN7.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN7.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN7.FlatStyle = FlatStyle.Flat;
            buttonN7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonN7.ForeColor = Color.White;
            buttonN7.Location = new Point(5, 305);
            buttonN7.Name = "buttonN7";
            buttonN7.Size = new Size(76, 52);
            buttonN7.TabIndex = 2;
            buttonN7.Text = "7";
            buttonN7.UseVisualStyleBackColor = false;
            // 
            // buttonXQuadrado
            // 
            buttonXQuadrado.BackColor = Color.FromArgb(20, 20, 20);
            buttonXQuadrado.BackgroundImage = (Image)resources.GetObject("buttonXQuadrado.BackgroundImage");
            buttonXQuadrado.BackgroundImageLayout = ImageLayout.Center;
            buttonXQuadrado.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonXQuadrado.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonXQuadrado.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonXQuadrado.FlatStyle = FlatStyle.Flat;
            buttonXQuadrado.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXQuadrado.ForeColor = Color.White;
            buttonXQuadrado.Location = new Point(84, 251);
            buttonXQuadrado.Name = "buttonXQuadrado";
            buttonXQuadrado.Size = new Size(76, 52);
            buttonXQuadrado.TabIndex = 2;
            buttonXQuadrado.UseVisualStyleBackColor = false;
            // 
            // buttonRaizQuadrada
            // 
            buttonRaizQuadrada.BackColor = Color.FromArgb(20, 20, 20);
            buttonRaizQuadrada.BackgroundImage = (Image)resources.GetObject("buttonRaizQuadrada.BackgroundImage");
            buttonRaizQuadrada.BackgroundImageLayout = ImageLayout.Center;
            buttonRaizQuadrada.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonRaizQuadrada.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonRaizQuadrada.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonRaizQuadrada.FlatStyle = FlatStyle.Flat;
            buttonRaizQuadrada.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRaizQuadrada.ForeColor = Color.White;
            buttonRaizQuadrada.Location = new Point(162, 251);
            buttonRaizQuadrada.Name = "buttonRaizQuadrada";
            buttonRaizQuadrada.Size = new Size(76, 52);
            buttonRaizQuadrada.TabIndex = 2;
            buttonRaizQuadrada.UseVisualStyleBackColor = false;
            // 
            // buttonDivisao
            // 
            buttonDivisao.BackColor = Color.FromArgb(20, 20, 20);
            buttonDivisao.BackgroundImage = (Image)resources.GetObject("buttonDivisao.BackgroundImage");
            buttonDivisao.BackgroundImageLayout = ImageLayout.Center;
            buttonDivisao.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonDivisao.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonDivisao.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonDivisao.FlatStyle = FlatStyle.Flat;
            buttonDivisao.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivisao.ForeColor = Color.White;
            buttonDivisao.Location = new Point(240, 251);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(76, 52);
            buttonDivisao.TabIndex = 2;
            buttonDivisao.UseVisualStyleBackColor = false;
            // 
            // buttonMultiplicacao
            // 
            buttonMultiplicacao.BackColor = Color.FromArgb(20, 20, 20);
            buttonMultiplicacao.BackgroundImageLayout = ImageLayout.Center;
            buttonMultiplicacao.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonMultiplicacao.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonMultiplicacao.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonMultiplicacao.FlatStyle = FlatStyle.Flat;
            buttonMultiplicacao.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiplicacao.ForeColor = Color.White;
            buttonMultiplicacao.Location = new Point(240, 305);
            buttonMultiplicacao.Name = "buttonMultiplicacao";
            buttonMultiplicacao.Size = new Size(76, 52);
            buttonMultiplicacao.TabIndex = 2;
            buttonMultiplicacao.Text = "X";
            buttonMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // buttonSubtracao
            // 
            buttonSubtracao.BackColor = Color.FromArgb(20, 20, 20);
            buttonSubtracao.BackgroundImageLayout = ImageLayout.Center;
            buttonSubtracao.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonSubtracao.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonSubtracao.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonSubtracao.FlatStyle = FlatStyle.Flat;
            buttonSubtracao.Font = new Font("Lucida Sans Unicode", 20F);
            buttonSubtracao.ForeColor = Color.White;
            buttonSubtracao.Location = new Point(240, 358);
            buttonSubtracao.Name = "buttonSubtracao";
            buttonSubtracao.Size = new Size(76, 52);
            buttonSubtracao.TabIndex = 2;
            buttonSubtracao.Text = "  -";
            buttonSubtracao.TextAlign = ContentAlignment.TopLeft;
            buttonSubtracao.UseVisualStyleBackColor = false;
            // 
            // buttonAdicao
            // 
            buttonAdicao.BackColor = Color.FromArgb(20, 20, 20);
            buttonAdicao.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicao.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonAdicao.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonAdicao.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonAdicao.FlatStyle = FlatStyle.Flat;
            buttonAdicao.Font = new Font("Lucida Sans Unicode", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicao.ForeColor = Color.White;
            buttonAdicao.Location = new Point(240, 411);
            buttonAdicao.Name = "buttonAdicao";
            buttonAdicao.Size = new Size(76, 52);
            buttonAdicao.TabIndex = 2;
            buttonAdicao.Text = "+";
            buttonAdicao.TextAlign = ContentAlignment.TopCenter;
            buttonAdicao.UseVisualStyleBackColor = false;
            // 
            // buttonResultado
            // 
            buttonResultado.BackColor = Color.Indigo;
            buttonResultado.BackgroundImageLayout = ImageLayout.Center;
            buttonResultado.FlatAppearance.BorderColor = Color.Indigo;
            buttonResultado.FlatStyle = FlatStyle.Flat;
            buttonResultado.Font = new Font("Lucida Sans Unicode", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonResultado.ForeColor = Color.White;
            buttonResultado.Location = new Point(240, 464);
            buttonResultado.Name = "buttonResultado";
            buttonResultado.Size = new Size(76, 52);
            buttonResultado.TabIndex = 2;
            buttonResultado.Text = "=";
            buttonResultado.TextAlign = ContentAlignment.TopCenter;
            buttonResultado.UseVisualStyleBackColor = false;
            // 
            // buttonN8
            // 
            buttonN8.BackColor = Color.FromArgb(6, 6, 6);
            buttonN8.BackgroundImageLayout = ImageLayout.Center;
            buttonN8.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN8.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN8.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN8.FlatStyle = FlatStyle.Flat;
            buttonN8.Font = new Font("Segoe UI", 18F);
            buttonN8.ForeColor = Color.White;
            buttonN8.Location = new Point(84, 305);
            buttonN8.Name = "buttonN8";
            buttonN8.Size = new Size(76, 52);
            buttonN8.TabIndex = 2;
            buttonN8.Text = "8";
            buttonN8.UseVisualStyleBackColor = false;
            // 
            // buttonN9
            // 
            buttonN9.BackColor = Color.FromArgb(6, 6, 6);
            buttonN9.BackgroundImageLayout = ImageLayout.Center;
            buttonN9.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN9.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN9.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN9.FlatStyle = FlatStyle.Flat;
            buttonN9.Font = new Font("Segoe UI", 18F);
            buttonN9.ForeColor = Color.White;
            buttonN9.Location = new Point(162, 305);
            buttonN9.Name = "buttonN9";
            buttonN9.Size = new Size(76, 52);
            buttonN9.TabIndex = 2;
            buttonN9.Text = "9";
            buttonN9.UseVisualStyleBackColor = false;
            // 
            // buttonFracao
            // 
            buttonFracao.BackColor = Color.FromArgb(20, 20, 20);
            buttonFracao.BackgroundImage = (Image)resources.GetObject("buttonFracao.BackgroundImage");
            buttonFracao.BackgroundImageLayout = ImageLayout.Center;
            buttonFracao.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            buttonFracao.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 0, 244);
            buttonFracao.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 0, 142);
            buttonFracao.FlatStyle = FlatStyle.Flat;
            buttonFracao.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFracao.ForeColor = Color.White;
            buttonFracao.Location = new Point(6, 251);
            buttonFracao.Name = "buttonFracao";
            buttonFracao.Size = new Size(76, 52);
            buttonFracao.TabIndex = 2;
            buttonFracao.UseVisualStyleBackColor = false;
            // 
            // buttonN4
            // 
            buttonN4.BackColor = Color.FromArgb(6, 6, 6);
            buttonN4.BackgroundImageLayout = ImageLayout.Center;
            buttonN4.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN4.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN4.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN4.FlatStyle = FlatStyle.Flat;
            buttonN4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonN4.ForeColor = Color.White;
            buttonN4.Location = new Point(6, 358);
            buttonN4.Name = "buttonN4";
            buttonN4.Size = new Size(76, 52);
            buttonN4.TabIndex = 2;
            buttonN4.Text = "4";
            buttonN4.UseVisualStyleBackColor = false;
            // 
            // buttonN5
            // 
            buttonN5.BackColor = Color.FromArgb(6, 6, 6);
            buttonN5.BackgroundImageLayout = ImageLayout.Center;
            buttonN5.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN5.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN5.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN5.FlatStyle = FlatStyle.Flat;
            buttonN5.Font = new Font("Segoe UI", 18F);
            buttonN5.ForeColor = Color.White;
            buttonN5.Location = new Point(84, 358);
            buttonN5.Name = "buttonN5";
            buttonN5.Size = new Size(76, 52);
            buttonN5.TabIndex = 2;
            buttonN5.Text = "5";
            buttonN5.UseVisualStyleBackColor = false;
            // 
            // buttonN6
            // 
            buttonN6.BackColor = Color.FromArgb(6, 6, 6);
            buttonN6.BackgroundImageLayout = ImageLayout.Center;
            buttonN6.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN6.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN6.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN6.FlatStyle = FlatStyle.Flat;
            buttonN6.Font = new Font("Segoe UI", 18F);
            buttonN6.ForeColor = Color.White;
            buttonN6.Location = new Point(162, 358);
            buttonN6.Name = "buttonN6";
            buttonN6.Size = new Size(76, 52);
            buttonN6.TabIndex = 2;
            buttonN6.Text = "6";
            buttonN6.UseVisualStyleBackColor = false;
            // 
            // buttonN1
            // 
            buttonN1.BackColor = Color.FromArgb(6, 6, 6);
            buttonN1.BackgroundImageLayout = ImageLayout.Center;
            buttonN1.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN1.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN1.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN1.FlatStyle = FlatStyle.Flat;
            buttonN1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonN1.ForeColor = Color.White;
            buttonN1.Location = new Point(5, 411);
            buttonN1.Name = "buttonN1";
            buttonN1.Size = new Size(76, 52);
            buttonN1.TabIndex = 2;
            buttonN1.Text = "1";
            buttonN1.UseVisualStyleBackColor = false;
            // 
            // buttonN2
            // 
            buttonN2.BackColor = Color.FromArgb(6, 6, 6);
            buttonN2.BackgroundImageLayout = ImageLayout.Center;
            buttonN2.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN2.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN2.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN2.FlatStyle = FlatStyle.Flat;
            buttonN2.Font = new Font("Segoe UI", 18F);
            buttonN2.ForeColor = Color.White;
            buttonN2.Location = new Point(84, 411);
            buttonN2.Name = "buttonN2";
            buttonN2.Size = new Size(76, 52);
            buttonN2.TabIndex = 2;
            buttonN2.Text = "2";
            buttonN2.UseVisualStyleBackColor = false;
            // 
            // buttonN3
            // 
            buttonN3.BackColor = Color.FromArgb(6, 6, 6);
            buttonN3.BackgroundImageLayout = ImageLayout.Center;
            buttonN3.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN3.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN3.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN3.FlatStyle = FlatStyle.Flat;
            buttonN3.Font = new Font("Segoe UI", 18F);
            buttonN3.ForeColor = Color.White;
            buttonN3.Location = new Point(162, 411);
            buttonN3.Name = "buttonN3";
            buttonN3.Size = new Size(76, 52);
            buttonN3.TabIndex = 2;
            buttonN3.Text = "3";
            buttonN3.UseVisualStyleBackColor = false;
            // 
            // buttonN0
            // 
            buttonN0.BackColor = Color.FromArgb(6, 6, 6);
            buttonN0.BackgroundImageLayout = ImageLayout.Center;
            buttonN0.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonN0.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonN0.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonN0.FlatStyle = FlatStyle.Flat;
            buttonN0.Font = new Font("Segoe UI", 18F);
            buttonN0.ForeColor = Color.White;
            buttonN0.Location = new Point(84, 464);
            buttonN0.Name = "buttonN0";
            buttonN0.Size = new Size(76, 52);
            buttonN0.TabIndex = 2;
            buttonN0.Text = "0";
            buttonN0.UseVisualStyleBackColor = false;
            // 
            // buttonInverterSinal
            // 
            buttonInverterSinal.BackColor = Color.FromArgb(6, 6, 6);
            buttonInverterSinal.BackgroundImageLayout = ImageLayout.Center;
            buttonInverterSinal.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonInverterSinal.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonInverterSinal.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonInverterSinal.FlatStyle = FlatStyle.Flat;
            buttonInverterSinal.Font = new Font("Segoe UI", 14F);
            buttonInverterSinal.ForeColor = Color.White;
            buttonInverterSinal.Location = new Point(6, 464);
            buttonInverterSinal.Name = "buttonInverterSinal";
            buttonInverterSinal.Size = new Size(76, 52);
            buttonInverterSinal.TabIndex = 2;
            buttonInverterSinal.Text = "+/-";
            buttonInverterSinal.UseVisualStyleBackColor = false;
            // 
            // buttonVirgula
            // 
            buttonVirgula.BackColor = Color.FromArgb(6, 6, 6);
            buttonVirgula.BackgroundImageLayout = ImageLayout.Center;
            buttonVirgula.FlatAppearance.BorderColor = Color.FromArgb(6, 6, 6);
            buttonVirgula.FlatAppearance.MouseDownBackColor = Color.FromArgb(158, 0, 253);
            buttonVirgula.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 0, 132);
            buttonVirgula.FlatStyle = FlatStyle.Flat;
            buttonVirgula.Font = new Font("Segoe UI", 18F);
            buttonVirgula.ForeColor = Color.White;
            buttonVirgula.Location = new Point(162, 464);
            buttonVirgula.Name = "buttonVirgula";
            buttonVirgula.Size = new Size(76, 52);
            buttonVirgula.TabIndex = 2;
            buttonVirgula.Text = ",";
            buttonVirgula.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 31, 31);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(277, 41);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Calculadora";
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.FromArgb(31, 31, 31);
            buttonSair.BackgroundImage = (Image)resources.GetObject("buttonSair.BackgroundImage");
            buttonSair.BackgroundImageLayout = ImageLayout.Center;
            buttonSair.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            buttonSair.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            buttonSair.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Lucida Sans Unicode", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.White;
            buttonSair.Location = new Point(261, -1);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(59, 34);
            buttonSair.TabIndex = 2;
            buttonSair.TextAlign = ContentAlignment.TopCenter;
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "            ";
            // 
            // panelCabecalho
            // 
            panelCabecalho.AllowDrop = true;
            panelCabecalho.Controls.Add(splitter1);
            panelCabecalho.Controls.Add(label2);
            panelCabecalho.Controls.Add(label1);
            panelCabecalho.Controls.Add(buttonMinimizar);
            panelCabecalho.Controls.Add(buttonSair);
            panelCabecalho.ImeMode = ImeMode.NoControl;
            panelCabecalho.Location = new Point(2, 1);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(318, 33);
            panelCabecalho.TabIndex = 6;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 33);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.BackColor = Color.FromArgb(31, 31, 31);
            buttonMinimizar.BackgroundImage = (Image)resources.GetObject("buttonMinimizar.BackgroundImage");
            buttonMinimizar.BackgroundImageLayout = ImageLayout.Center;
            buttonMinimizar.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            buttonMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(6, 6, 6);
            buttonMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.Font = new Font("Lucida Sans Unicode", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinimizar.ForeColor = Color.White;
            buttonMinimizar.Location = new Point(202, -1);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(59, 34);
            buttonMinimizar.TabIndex = 2;
            buttonMinimizar.TextAlign = ContentAlignment.TopCenter;
            buttonMinimizar.UseVisualStyleBackColor = false;
            buttonMinimizar.Click += buttonMinimizar_Click;
            // 
            // TelaCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(321, 525);
            Controls.Add(panelCabecalho);
            Controls.Add(buttonResultado);
            Controls.Add(buttonAdicao);
            Controls.Add(buttonSubtracao);
            Controls.Add(buttonMultiplicacao);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonN3);
            Controls.Add(buttonN6);
            Controls.Add(buttonN9);
            Controls.Add(buttonRaizQuadrada);
            Controls.Add(buttonInverterSinal);
            Controls.Add(buttonVirgula);
            Controls.Add(buttonN0);
            Controls.Add(buttonN2);
            Controls.Add(buttonN5);
            Controls.Add(buttonN8);
            Controls.Add(buttonFracao);
            Controls.Add(buttonXQuadrado);
            Controls.Add(buttonN1);
            Controls.Add(buttonN4);
            Controls.Add(buttonN7);
            Controls.Add(buttonPorcentagem);
            Controls.Add(button1);
            Controls.Add(buttonApagar);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
            Controls.Add(lblTipoDaCalculadora);
            Controls.Add(TxtBEntrada);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(31, 31, 31);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaCalculadora";
            Opacity = 0.99D;
            Text = "CalculadoraADP";
            TransparencyKey = SystemColors.WindowFrame;
            Load += Calculadora_Load;
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBEntrada;
        private Label lblTipoDaCalculadora;
        private Button buttonCE;
        private Button buttonPorcentagem;
        private Button buttonC;
        private Button buttonApagar;
        private Button buttonN7;
        private Button buttonXQuadrado;
        private Button buttonRaizQuadrada;
        private Button buttonDivisao;
        private Button buttonMultiplicacao;
        private Button buttonSubtracao;
        private Button buttonAdicao;
        private Button buttonResultado;
        private Button buttonN8;
        private Button buttonN9;
        private Button buttonFracao;
        private Button buttonN4;
        private Button buttonN5;
        private Button buttonN6;
        private Button buttonN1;
        private Button buttonN2;
        private Button buttonN3;
        private Button buttonN0;
        private Button buttonInverterSinal;
        private Button buttonVirgula;
        private Button button1;
        private Label label1;
        private Button buttonSair;
        private Label label2;
        private Panel panelCabecalho;
        private Button buttonMinimizar;
        private Splitter splitter1;
    }
}
