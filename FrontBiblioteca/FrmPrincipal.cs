using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //try = Tratamento de exception
            try
            {
                //Inserir os dados na lista
                new ClienteService().Add(int.Parse(txtId.Text), 
                                         txtNome.Text, 
                                         txtTelefone.Text, 
                                         decimal.Parse(txtSalario.Text), 
                                         txtEndereco.Text);

                MessageBox.Show("Registro inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorre um erro ao receber os dados: " + ex.Message);
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = new ClienteService().ListAll();
        }
    }
}



//Carregar o objeto c (Cliente) com os dados da tela
/*Cliente c = new Cliente()
{
    Id = int.Parse(txtId.Text),
    Nome = txtNome.Text,
    Telefone = txtTelefone.Text,
    Endereco = txtEndereco.Text,
    Salario = decimal.Parse(txtSalario.Text)
};*/
