namespace MedidasResumo
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
            txtEntrada = new TextBox();
            BtnCalcular = new Button();
            lblMedia = new Label();
            txtMedia = new TextBox();
            txtMediana = new TextBox();
            lblMediana = new Label();
            txtModa = new TextBox();
            lblModa = new Label();
            txtVarianca = new TextBox();
            lblVarianca = new Label();
            lblDesvioPadrao = new Label();
            txtDesvioPadrao = new TextBox();
            cbRelatorio = new CheckBox();
            SuspendLayout();
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(12, 12);
            txtEntrada.Multiline = true;
            txtEntrada.Name = "txtEntrada";
            txtEntrada.ScrollBars = ScrollBars.Vertical;
            txtEntrada.Size = new Size(747, 310);
            txtEntrada.TabIndex = 0;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(778, 13);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(92, 32);
            BtnCalcular.TabIndex = 1;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(12, 343);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(53, 21);
            lblMedia.TabIndex = 2;
            lblMedia.Text = "Média";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(98, 340);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(182, 29);
            txtMedia.TabIndex = 3;
            // 
            // txtMediana
            // 
            txtMediana.Location = new Point(98, 384);
            txtMediana.Name = "txtMediana";
            txtMediana.Size = new Size(182, 29);
            txtMediana.TabIndex = 5;
            // 
            // lblMediana
            // 
            lblMediana.AutoSize = true;
            lblMediana.Location = new Point(12, 387);
            lblMediana.Name = "lblMediana";
            lblMediana.Size = new Size(70, 21);
            lblMediana.TabIndex = 4;
            lblMediana.Text = "Mediana";
            // 
            // txtModa
            // 
            txtModa.Location = new Point(98, 432);
            txtModa.Name = "txtModa";
            txtModa.Size = new Size(182, 29);
            txtModa.TabIndex = 7;
            // 
            // lblModa
            // 
            lblModa.AutoSize = true;
            lblModa.Location = new Point(12, 435);
            lblModa.Name = "lblModa";
            lblModa.Size = new Size(50, 21);
            lblModa.TabIndex = 6;
            lblModa.Text = "Moda";
            // 
            // txtVarianca
            // 
            txtVarianca.Location = new Point(510, 340);
            txtVarianca.Name = "txtVarianca";
            txtVarianca.Size = new Size(210, 29);
            txtVarianca.TabIndex = 8;
            // 
            // lblVarianca
            // 
            lblVarianca.AutoSize = true;
            lblVarianca.Location = new Point(364, 343);
            lblVarianca.Name = "lblVarianca";
            lblVarianca.Size = new Size(69, 21);
            lblVarianca.TabIndex = 9;
            lblVarianca.Text = "Variança";
            // 
            // lblDesvioPadrao
            // 
            lblDesvioPadrao.AutoSize = true;
            lblDesvioPadrao.Location = new Point(364, 387);
            lblDesvioPadrao.Name = "lblDesvioPadrao";
            lblDesvioPadrao.Size = new Size(109, 21);
            lblDesvioPadrao.TabIndex = 10;
            lblDesvioPadrao.Text = "Desvio Padrão";
            // 
            // txtDesvioPadrao
            // 
            txtDesvioPadrao.Location = new Point(510, 384);
            txtDesvioPadrao.Name = "txtDesvioPadrao";
            txtDesvioPadrao.Size = new Size(210, 29);
            txtDesvioPadrao.TabIndex = 11;
            // 
            // cbRelatorio
            // 
            cbRelatorio.AutoSize = true;
            cbRelatorio.Location = new Point(788, 427);
            cbRelatorio.Name = "cbRelatorio";
            cbRelatorio.Size = new Size(88, 46);
            cbRelatorio.TabIndex = 12;
            cbRelatorio.Text = "Imprime\r\nsolução";
            cbRelatorio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 485);
            Controls.Add(cbRelatorio);
            Controls.Add(txtDesvioPadrao);
            Controls.Add(lblDesvioPadrao);
            Controls.Add(lblVarianca);
            Controls.Add(txtVarianca);
            Controls.Add(txtModa);
            Controls.Add(lblModa);
            Controls.Add(txtMediana);
            Controls.Add(lblMediana);
            Controls.Add(txtMedia);
            Controls.Add(lblMedia);
            Controls.Add(BtnCalcular);
            Controls.Add(txtEntrada);
            Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Medidas-resumo de Estatística";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEntrada;
        private Button BtnCalcular;
        private Label lblMedia;
        private TextBox txtMedia;
        private TextBox txtMediana;
        private Label lblMediana;
        private TextBox txtModa;
        private Label lblModa;
        private TextBox txtVarianca;
        private Label lblVarianca;
        private Label lblDesvioPadrao;
        private TextBox txtDesvioPadrao;
        private CheckBox cbRelatorio;
    }
}
