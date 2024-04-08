
namespace Gerenciador_de_Vendas
{
    partial class CadEditCombos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEditCombos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxProd = new System.Windows.Forms.TextBox();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro/Edição de Combos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Combo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Bronze",
            "Prata",
            "Ouro"});
            this.cmbTipo.Location = new System.Drawing.Point(224, 115);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(113, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produtos";
            // 
            // txtBoxProd
            // 
            this.txtBoxProd.Location = new System.Drawing.Point(195, 188);
            this.txtBoxProd.Multiline = true;
            this.txtBoxProd.Name = "txtBoxProd";
            this.txtBoxProd.Size = new System.Drawing.Size(188, 93);
            this.txtBoxProd.TabIndex = 4;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Location = new System.Drawing.Point(99, 334);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(116, 37);
            this.btnCancelar2.TabIndex = 5;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.Location = new System.Drawing.Point(316, 334);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Size = new System.Drawing.Size(116, 37);
            this.btnSalvar2.TabIndex = 6;
            this.btnSalvar2.Text = "Salvar";
            this.btnSalvar2.UseVisualStyleBackColor = true;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // CadEditCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 383);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.txtBoxProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadEditCombos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Combos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxProd;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnSalvar2;
    }
}