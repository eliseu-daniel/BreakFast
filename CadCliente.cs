using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Vendas
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void btnCliSalvar_Click(object sender, EventArgs e)
        {
            Cliente.cliente = txtBoxNome.Text + " | " + txtBoxEnd.Text + " | " + txtBoxEmail.Text;
            if (MessageBox.Show("Deseja realmente Salvar?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBoxNome.Text  =
                txtBoxEnd.Text   =
                txtBoxEmail.Text = string.Empty;
            }
        }
    }
}
