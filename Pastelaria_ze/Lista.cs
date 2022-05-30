using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPastelariaDoZe_2022.DAO;
using System.Configuration;

namespace Pastelaria_do_Zé
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Lista : Form

    {
        /// <summary>
        /// 
        /// </summary>
        private readonly FuncionarioDAO dao_fun;
        private readonly ClienteDAO dao_cli;
        /// <summary>
        /// 
        /// </summary>
        public Lista()
        {
            InitializeComponent();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            dao_fun = new FuncionarioDAO(provider, strConnection);
            dao_cli = new ClienteDAO(provider, strConnection);
        }

        private void ButtonFunCadastrados_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao_fun.SelectDbProvider(funcionario);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCliCadastrados_Click(object sender, EventArgs e)
        {
            {
                //Instância e Preenche o objeto com os dados da view
                var cliente = new Cliente
                {
                    IdCliente = 0,
                };
                try
                {
                    //chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = dao_cli.SelectDbProvider(cliente);
                    // seta o datasouce do dataGridView com os dados retornados
                    dataGridViewDados.Columns.Clear();
                    dataGridViewDados.AutoGenerateColumns = true;
                    dataGridViewDados.DataSource = linhas;
                    dataGridViewDados.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
