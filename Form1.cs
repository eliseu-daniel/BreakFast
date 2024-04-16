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

            if(lstCombos.SelectedIndex >= 0)
            {
                ComboVenda.venda = lstCombos.SelectedItem.ToString();
                vendasfim.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um item para continuar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCanCompra_Click(object sender, EventArgs e)
        {
            lstCombos.ClearSelected();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProduto cadProduto = new CadProduto();
            cadProduto.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadFornecedor cadFornecedor = new CadFornecedor();
            cadFornecedor.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendProd vendProd = new vendProd();
            vendProd.Show();
        }

        private void totalVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendTT vendTT = new vendTT();
            vendTT.Show();
        }

        private void balançaPatrimonialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fatFin fatFin = new fatFin();
            fatFin.Show();
        }

        private void emissãoNFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emissaoNF emitirNF = new emissaoNF();
            emitirNF.Show();
        }

        private void cancelarNFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelarNF canNF = new cancelarNF();
            canNF.Show();
        }
    }
}
