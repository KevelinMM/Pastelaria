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
    public partial class Cadastro_Funcionario : Form
        
    {
        private readonly FuncionarioDAO dao;
        /// <summary>
        /// 
        /// </summary>
        public Cadastro_Funcionario()
        {
            InitializeComponent();
            labelFuncionarioCadastro.Text = Properties.Resources.ResourceManager.GetString("txtCadastroFuncionario");
            labelFuncionarioID.Text = Properties.Resources.ResourceManager.GetString("txtID");
            labelFuncionarioMatricula.Text = Properties.Resources.ResourceManager.GetString("txtMatricula");
            labelFuncionarioNomeCompleto.Text = Properties.Resources.ResourceManager.GetString("txtNomeCompleto");
            labelFuncionarioContato.Text = Properties.Resources.ResourceManager.GetString("txtContato");
            radioButtonFuncionarioAdm.Text = Properties.Resources.ResourceManager.GetString("txtAdministrador");
            radioButtonFuncionarioBalcao.Text = Properties.Resources.ResourceManager.GetString("txtBalcao");
            labelFuncionarioSenha.Text = Properties.Resources.ResourceManager.GetString("txtSenha");
            labelFuncionarioReSenha.Text = Properties.Resources.ResourceManager.GetString("txtReSenha");
            textBoxFuncionarioNome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxFuncionarioNome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxFuncionarioRe.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxFuncionarioRe.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxFuncionarioSenha.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxFuncionarioSenha.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            salvar_VoltarFuncionario.Salvar.Click += Salvar_Click;
            salvar_VoltarFuncionario.Voltar.Click += Voltar_Click;
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            dao = new FuncionarioDAO(provider, strConnection);
            AtualizaTela();

        }

        private void Voltar_Click(object? sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Salvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBoxFuncionarioNome.Text,
                Cpf = maskedTextBoxCPF.Text,
                Telefone = maskedTextBoxContato.Text,
                Senha = ClassFuncoes.Sha256Hash(textBoxFuncionarioSenha.Text),
                Matricula = maskedTextBoxMatricula.Text,
                Grupo = (radioButtonFuncionarioAdm.Checked) ? 1 : 2,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(funcionario);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cadastro_Funcionario_KeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                //subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                form.Close();
            }
        }

        private void Cadastro_Funcionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var mensagem = Properties.Resources.ResourceManager.GetString("alertExit");
                var titulo = Properties.Resources.ResourceManager.GetString("alertTitle");
                var result = MessageBox.Show(this, mensagem, titulo, MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void LimpaTela()
        {
            maskedTextBoxId.Text = "";
            maskedTextBoxMatricula.Text = "";
            textBoxFuncionarioNome.Text = "";
            textBoxFuncionarioRe.Text = "";
            textBoxFuncionarioSenha.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxContato.Text = "";
            radioButtonFuncionarioAdm.Checked = false;
            radioButtonFuncionarioBalcao.Checked = false;
        }
        /// <summary>
        /// 
        /// </summary>
        public void AtualizaTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    maskedTextBoxId.Text = row[0].ToString();
                    textBoxFuncionarioNome.Text = row[1].ToString();
                    maskedTextBoxCPF.Text = row[2].ToString();
                    maskedTextBoxContato.Text = row[3].ToString();
                    maskedTextBoxMatricula.Text = row[5].ToString();
                    if (row[4].ToString() == "1")
                    {
                        radioButtonFuncionarioAdm.Checked = true;
                    }
                    else
                    {
                        radioButtonFuncionarioBalcao.Checked = true;
                    }



                }
                textBoxFuncionarioNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridViewDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void ButtonExcluirFuncionario_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(maskedTextBoxId.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(funcionario);
                AtualizaTela();
                LimpaTela();
                MessageBox.Show("Dados excluidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonEditarFuncionario_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(maskedTextBoxId.Text),
                Nome = textBoxFuncionarioNome.Text,
                Cpf = maskedTextBoxCPF.Text,
                Telefone = maskedTextBoxContato.Text,
                Senha = ClassFuncoes.Sha256Hash(textBoxFuncionarioSenha.Text),
                Matricula = maskedTextBoxMatricula.Text,
                Grupo = (radioButtonFuncionarioAdm.Checked) ? 1 : 2,
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(funcionario);
                AtualizaTela();
                LimpaTela();
                MessageBox.Show("Dados editados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
