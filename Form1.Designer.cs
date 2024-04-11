
namespace Gerenciador_de_Vendas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCanCompra = new System.Windows.Forms.Button();
            this.btnConCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançaPatrimonialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iCMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emissãoNFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarNFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMBOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEditarCombosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCombos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 803);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCanCompra
            // 
            this.btnCanCompra.Location = new System.Drawing.Point(1178, 746);
            this.btnCanCompra.Name = "btnCanCompra";
            this.btnCanCompra.Size = new System.Drawing.Size(82, 24);
            this.btnCanCompra.TabIndex = 7;
            this.btnCanCompra.Text = "Cancelar";
            this.btnCanCompra.UseVisualStyleBackColor = true;
            this.btnCanCompra.Click += new System.EventHandler(this.btnCanCompra_Click);
            // 
            // btnConCompra
            // 
            this.btnConCompra.Location = new System.Drawing.Point(1342, 746);
            this.btnConCompra.Name = "btnConCompra";
            this.btnConCompra.Size = new System.Drawing.Size(82, 24);
            this.btnConCompra.TabIndex = 8;
            this.btnConCompra.Text = "Confirmar";
            this.btnConCompra.UseVisualStyleBackColor = true;
            this.btnConCompra.Click += new System.EventHandler(this.btnConCompra_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1152, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 80);
            this.label1.TabIndex = 9;
            this.label1.Text = "COMBOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.notaFiscalToolStripMenuItem,
            this.cOMBOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1481, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.totalVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // totalVendasToolStripMenuItem
            // 
            this.totalVendasToolStripMenuItem.Name = "totalVendasToolStripMenuItem";
            this.totalVendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.totalVendasToolStripMenuItem.Text = "Total Vendas";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balançaPatrimonialToolStripMenuItem,
            this.iCMSToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // balançaPatrimonialToolStripMenuItem
            // 
            this.balançaPatrimonialToolStripMenuItem.Name = "balançaPatrimonialToolStripMenuItem";
            this.balançaPatrimonialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.balançaPatrimonialToolStripMenuItem.Text = "Faturamento";
            // 
            // iCMSToolStripMenuItem
            // 
            this.iCMSToolStripMenuItem.Name = "iCMSToolStripMenuItem";
            this.iCMSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iCMSToolStripMenuItem.Text = "ICMS";
            // 
            // notaFiscalToolStripMenuItem
            // 
            this.notaFiscalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emissãoNFToolStripMenuItem,
            this.cancelarNFToolStripMenuItem});
            this.notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            this.notaFiscalToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // emissãoNFToolStripMenuItem
            // 
            this.emissãoNFToolStripMenuItem.Name = "emissãoNFToolStripMenuItem";
            this.emissãoNFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emissãoNFToolStripMenuItem.Text = "Emissão NF";
            // 
            // cancelarNFToolStripMenuItem
            // 
            this.cancelarNFToolStripMenuItem.Name = "cancelarNFToolStripMenuItem";
            this.cancelarNFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelarNFToolStripMenuItem.Text = "Cancelar NF";
            // 
            // cOMBOSToolStripMenuItem
            // 
            this.cOMBOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroEditarCombosToolStripMenuItem});
            this.cOMBOSToolStripMenuItem.Name = "cOMBOSToolStripMenuItem";
            this.cOMBOSToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cOMBOSToolStripMenuItem.Text = "COMBOS";
            // 
            // cadastroEditarCombosToolStripMenuItem
            // 
            this.cadastroEditarCombosToolStripMenuItem.Name = "cadastroEditarCombosToolStripMenuItem";
            this.cadastroEditarCombosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastroEditarCombosToolStripMenuItem.Text = "Cadastro/Editar Combos";
            this.cadastroEditarCombosToolStripMenuItem.Click += new System.EventHandler(this.cadastroEditarCombosToolStripMenuItem_Click);
            // 
            // lstCombos
            // 
            this.lstCombos.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstCombos.FormattingEnabled = true;
            this.lstCombos.Location = new System.Drawing.Point(1151, 148);
            this.lstCombos.Name = "lstCombos";
            this.lstCombos.Size = new System.Drawing.Size(305, 589);
            this.lstCombos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 846);
            this.Controls.Add(this.lstCombos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConCompra);
            this.Controls.Add(this.btnCanCompra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BreakFast";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCanCompra;
        private System.Windows.Forms.Button btnConCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMBOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iCMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançaPatrimonialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emissãoNFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarNFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEditarCombosToolStripMenuItem;
        public System.Windows.Forms.ListBox lstCombos;
    }
}

