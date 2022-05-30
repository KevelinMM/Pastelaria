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
    public partial class Cadastrar_Produto : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Cadastrar_Produto()
        {

            InitializeComponent();
            labelProdutoCadastrar.Text = Properties.Resources.ResourceManager.GetString("txtCadastrarProduto");
            labelProdutoID.Text = Properties.Resources.ResourceManager.GetString("txtID");
            labelProdutoNome.Text = Properties.Resources.ResourceManager.GetString("txtNome");
            labelPodutoPreco.Text = Properties.Resources.ResourceManager.GetString("txtPreco");
            labelProdutoDescricao.Text = Properties.Resources.ResourceManager.GetString("txtDescricao");
            labelProdutoImagem.Text = Properties.Resources.ResourceManager.GetString("txtImagem");
            textBoxProdutoDescricao.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxProdutoDescricao.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxProdutoNome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxProdutoNome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);


            salvar_VoltarProduto.Voltar.Click += Voltar_Click;
            salvar_VoltarProduto.Salvar.Click += Salvar_Click;
        }

        private void Salvar_Click(object? sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Voltar_Click(object? sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Cadastrar_Produto_KeyDown(object sender, KeyEventArgs e)
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

        private void Cadastrar_Produto_FormClosing(object sender, FormClosingEventArgs e)
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
