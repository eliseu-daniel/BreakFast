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
    public partial class CadEditCombos : Form
    {
        public CadEditCombos()
        {
            InitializeComponent();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               Close();
            }
        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            Combo.combo = cmbTipo.Text + ": " + txtBoxProd.Text;

            if (MessageBox.Show("Deseja realmente Salvar?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }


        }
    }
}
