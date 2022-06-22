using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria_do_Zé
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Menu : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            labelMenuInicio.Text = Properties.Resources.ResourceManager.GetString("txtInicio");
            labelMenuConfig.Text = Properties.Resources.ResourceManager.GetString("txtConfiguracoes");
            labelMenuSobre.Text = Properties.Resources.ResourceManager.GetString("txtSobre");
            labelMenuCadastrar.Text = Properties.Resources.ResourceManager.GetString("txtCadastrar");
            labelMenuProdutos.Text = Properties.Resources.ResourceManager.GetString("txtProdutos");
            labelMenuClientes.Text = Properties.Resources.ResourceManager.GetString("txtClientes");
            labelMenuFuncionarios.Text = Properties.Resources.ResourceManager.GetString("txtFuncionarios");
            labelMenuNomeFuncionario.Text = Properties.Resources.ResourceManager.GetString("txtNomeFuncionario");
            buttonSairMenu.Text = Properties.Resources.ResourceManager.GetString("txtSair");

            textBoxInicio.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxInicio.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoes = new();
            configuracoes.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           Sobre sobre = new();
           sobre.Show();
        }

        private void Produto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastrar_Produto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastro_Cliente();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastro_Funcionario();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
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

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastrar_Produto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastro_Cliente();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void FuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastro_Funcionario();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoes = new();
            configuracoes.Show();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new();
            sobre.Show();
        }

        private void ButtonSairMenu_Click(object sender, EventArgs e)
        {
             var mensagem = Properties.Resources.ResourceManager.GetString("alertExit");
             var titulo = Properties.Resources.ResourceManager.GetString("alertTitle");
             var result = MessageBox.Show(this, mensagem, titulo, MessageBoxButtons.YesNo);
             if (result != DialogResult.No)

             {
             this.Hide();
             Form f = new Login();
             f.Closed += (s, args) => this.Close();
             f.Show();
             }         
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void NotifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }

        private void SairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sobre sobre = new();
            sobre.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCadastrados_Click(object sender, EventArgs e)
        {
            Lista lista = new();
            lista.Show();
        }

        private void ButtonMenuCadastrarComanda_Click(object sender, EventArgs e)
        {
            Comandas comandas = new();
            comandas.Show();
        }
    }
}
