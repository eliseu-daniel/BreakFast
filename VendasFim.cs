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
    public partial class VendasFim : Form
    {
        public VendasFim()
        {
            InitializeComponent();
        }

        private void atualizarCombo(Object sender, EventArgs e)
        {
            lstProd.Items.Add(Combo.combo);
            
        }

        private void adicionais(Object sender, EventArgs e)
        {
            if(chkBox1.Checked == true)
            {
                lstProd.Items.Add(chkBox1.Text);

                if (chkBox1.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox2.Checked == true)
            {
                lstProd.Items.Add(chkBox2.Text);

                if (chkBox2.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox3.Checked == true)
            {
                lstProd.Items.Add(chkBox3.Text);

                if (chkBox3.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox4.Checked == true)
            {
                lstProd.Items.Add(chkBox4.Text);
                if (chkBox4.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox5.Checked == true)
            {
                lstProd.Items.Add(chkBox5.Text);
                if (chkBox5.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox6.Checked == true)
            {
                lstProd.Items.Add(chkBox6.Text);
                if (chkBox6.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox7.Checked == true)
            {
                lstProd.Items.Add(chkBox7.Text);
                if (chkBox7.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox8.Checked == true)
            {
                lstProd.Items.Add(chkBox8.Text);
                if (chkBox8.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox9.Checked == true)
            {
                lstProd.Items.Add(chkBox9.Text);
                if (chkBox9.Checked == false)
                {
                    limparCheck();
                }
            }
            if (chkBox10.Checked == true)
            {
                lstProd.Items.Add(chkBox10.Text);

                if (chkBox10.Checked == false)
                {
                    limparCheck();
                }
            }

        }

        private void limparCheck()
        {
            lstProd.Items.Clear();
        }

        private void btnEscCli_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();

            clientes.ShowDialog();

            string ClienteAtt = Cliente.cliente;
            // string[] dados = ClienteAtt.Split("|");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstProd.Items.Add(Combo.combo);
        }
    }
}
