namespace PDV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.imgPrincipal01 = new System.Windows.Forms.PictureBox();
            this.imgPrincipal02 = new System.Windows.Forms.PictureBox();
            this.imgPrincipal03 = new System.Windows.Forms.PictureBox();
            this.imgPrincipal04 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal04)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuRelatorio,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(72, 20);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(69, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(104, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.MenuRelatorio.Text = "Relatório";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            // 
            // imgPrincipal01
            // 
            this.imgPrincipal01.Location = new System.Drawing.Point(49, 57);
            this.imgPrincipal01.Name = "imgPrincipal01";
            this.imgPrincipal01.Size = new System.Drawing.Size(237, 128);
            this.imgPrincipal01.TabIndex = 1;
            this.imgPrincipal01.TabStop = false;
            // 
            // imgPrincipal02
            // 
            this.imgPrincipal02.Location = new System.Drawing.Point(439, 57);
            this.imgPrincipal02.Name = "imgPrincipal02";
            this.imgPrincipal02.Size = new System.Drawing.Size(237, 128);
            this.imgPrincipal02.TabIndex = 2;
            this.imgPrincipal02.TabStop = false;
            // 
            // imgPrincipal03
            // 
            this.imgPrincipal03.Location = new System.Drawing.Point(49, 282);
            this.imgPrincipal03.Name = "imgPrincipal03";
            this.imgPrincipal03.Size = new System.Drawing.Size(237, 128);
            this.imgPrincipal03.TabIndex = 3;
            this.imgPrincipal03.TabStop = false;
            // 
            // imgPrincipal04
            // 
            this.imgPrincipal04.Image = global::PDV.Properties.Resources.Captura_de_tela_2026_06_09_225030;
            this.imgPrincipal04.InitialImage = global::PDV.Properties.Resources.Captura_de_tela_2026_06_09_225030;
            this.imgPrincipal04.Location = new System.Drawing.Point(398, 217);
            this.imgPrincipal04.Name = "imgPrincipal04";
            this.imgPrincipal04.Size = new System.Drawing.Size(301, 207);
            this.imgPrincipal04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPrincipal04.TabIndex = 4;
            this.imgPrincipal04.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgPrincipal04);
            this.Controls.Add(this.imgPrincipal03);
            this.Controls.Add(this.imgPrincipal02);
            this.Controls.Add(this.imgPrincipal01);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox imgPrincipal01;
        private System.Windows.Forms.PictureBox imgPrincipal02;
        private System.Windows.Forms.PictureBox imgPrincipal03;
        private System.Windows.Forms.PictureBox imgPrincipal04;
    }
}

