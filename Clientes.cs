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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            if (Cliente.cliente != null)
            {
                lstCliAtt.Items.Add(Cliente.cliente);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           Cliente.cliente = lstCliAtt.SelectedItem.ToString();
            if(MessageBox.Show("Deseja continuar?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
