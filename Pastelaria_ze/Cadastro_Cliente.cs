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
    public partial class Cadastro_Cliente : Form
    {
        /// <summary>
        ///
        /// </summary>
        private readonly ClienteDAO dao;

        /// <summary>
        ///
        /// </summary>
        /// 
        public Cadastro_Cliente()
        {
            InitializeComponent();
            labelClienteCadastro.Text = Properties.Resources.ResourceManager.GetString("txtCadastroCliente");
            labelClienteID.Text = Properties.Resources.ResourceManager.GetString("txtID");
            labelClienteNome.Text = Properties.Resources.ResourceManager.GetString("txtNome");
            labelClienteDescricao.Text = Properties.Resources.ResourceManager.GetString("txtDescricao");
            labelClienteContato.Text = Properties.Resources.ResourceManager.GetString("txtContato");
            labelClienteFiado.Text = Properties.Resources.ResourceManager.GetString("txtDataFiado");
            labelClienteSenha.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            labelClienteReSenha.Text = Properties.Resources.ResourceManager.GetString("txtReSenha");
            checkBoxFiado.Text = Properties.Resources.ResourceManager.GetString("txtFiado");
            maskedTextBoxCPF.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            maskedTextBoxCPF.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxClienteNome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxClienteNome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxClienteRe.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxClienteRe.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxClienteSenha.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxClienteSenha.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
           
            salvar_VoltarCliente.Voltar.Click += Voltar_Click;
            salvar_VoltarCliente.Salvar.Click += Salvar_Click;

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            dao = new ClienteDAO(provider, strConnection);
        }

        private void Salvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                 IdCliente = 0,
                 Nome = textBoxClienteNome.Text,
                 Cpf = maskedTextBoxCPF.Text,
                 Telefone = maskedTextBoxContato.Text,
                 Compra_fiado = checkBoxFiado.Checked,
                 Dia_fiado = numericUpDownDiaFiado.Text,
                 Senha = ClassFuncoes.Sha256Hash(textBoxClienteSenha.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(cliente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Voltar_Click(object? sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
        private void Cadastro_Cliente_KeyDown(object sender, KeyEventArgs e)
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
        private void Cadastro_Cliente_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
