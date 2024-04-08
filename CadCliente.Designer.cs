
namespace Gerenciador_de_Vendas
{
    partial class CadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxEnd = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnCliCanc = new System.Windows.Forms.Button();
            this.btnCliSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(82, 113);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(376, 20);
            this.txtBoxNome.TabIndex = 5;
            // 
            // txtBoxEnd
            // 
            this.txtBoxEnd.Location = new System.Drawing.Point(82, 152);
            this.txtBoxEnd.Name = "txtBoxEnd";
            this.txtBoxEnd.Size = new System.Drawing.Size(376, 20);
            this.txtBoxEnd.TabIndex = 6;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(82, 191);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(376, 20);
            this.txtBoxEmail.TabIndex = 7;
            // 
            // btnCliCanc
            // 
            this.btnCliCanc.Location = new System.Drawing.Point(100, 340);
            this.btnCliCanc.Name = "btnCliCanc";
            this.btnCliCanc.Size = new System.Drawing.Size(121, 30);
            this.btnCliCanc.TabIndex = 8;
            this.btnCliCanc.Text = "Cancelar";
            this.btnCliCanc.UseVisualStyleBackColor = true;
            // 
            // btnCliSalvar
            // 
            this.btnCliSalvar.Location = new System.Drawing.Point(320, 340);
            this.btnCliSalvar.Name = "btnCliSalvar";
            this.btnCliSalvar.Size = new System.Drawing.Size(121, 30);
            this.btnCliSalvar.TabIndex = 9;
            this.btnCliSalvar.Text = "Cadastrar";
            this.btnCliSalvar.UseVisualStyleBackColor = true;
            this.btnCliSalvar.Click += new System.EventHandler(this.btnCliSalvar_Click);
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 421);
            this.Controls.Add(this.btnCliSalvar);
            this.Controls.Add(this.btnCliCanc);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxEnd);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxEnd;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnCliCanc;
        private System.Windows.Forms.Button btnCliSalvar;
    }
}