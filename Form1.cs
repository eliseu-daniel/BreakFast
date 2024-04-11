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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroEditarCombosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEditCombos cadastrarCombo = new CadEditCombos();

            cadastrarCombo.ShowDialog();
            if(Combo.combo != null)
            {
                lstCombos.Items.Add(Combo.combo);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente cadastrarCliente = new CadCliente();

            cadastrarCliente.ShowDialog();
        }

        private void btnConCompra_Click(object sender, EventArgs e)
        {
            VendasFim vendasfim = new VendasFim();

            vendasfim.Show();
        }

        private void btnCanCompra_Click(object sender, EventArgs e)
        {
            lstCombos.ClearSelected();
        }
    }
}
