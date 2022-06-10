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
    public partial class Cadastrar_Produto : Form
    {
        private readonly ProdutoDAO dao;
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
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            dao = new ProdutoDAO(provider, strConnection); // No evento do botão salvar, vamos chamar o método da nossa
            AtualizaTela();
        }

        private void Salvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
                Nome = textBoxProdutoNome.Text,
                Descricao = textBoxProdutoDescricao.Text,
                ValorUnitario = double.Parse(maskedTextBoxProduto.Text),
                Foto = ClassFuncoes.ConverteImagemParaByteArray(pictureBoxProduto.Image),
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(produto);
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
        private void PictureBoxProduto_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Title = "Imagem do produto";
            openFileDialogImagem.Filter = "Images (*.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.)|*.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.icon; *.JFIF";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxProduto.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBoxProduto.Image = (Image)(new Bitmap(pictureBoxProduto.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void LimpaTela()
        {
            textBoxProdutoDescricao.Text = "";
            maskedTextBox1.Text = "";
            textBoxProdutoNome.Text = "";
            maskedTextBoxProduto.Text = "";
            pictureBoxProduto.Image = null;
        }
        /// <summary>
        /// 
        /// </summary>
        public void AtualizaTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(produto);
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
            var produto = new Produto
            {
                IdProduto = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(produto);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    maskedTextBox1.Text = row[0].ToString();
                    textBoxProdutoNome.Text = row[1].ToString();
                    maskedTextBoxProduto.Text = row[2].ToString();
                    textBoxProdutoDescricao.Text = row[3].ToString();
                    pictureBoxProduto.Image = ClassFuncoes.ConverteByteArrayParaImagem((byte[])row[4]);
                }
                textBoxProdutoNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ButtonEditarProduto_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = int.Parse(maskedTextBox1.Text),
                Nome = textBoxProdutoNome.Text,
                Descricao = textBoxProdutoDescricao.Text,
                ValorUnitario = double.Parse(maskedTextBoxProduto.Text),
                Foto = ClassFuncoes.ConverteImagemParaByteArray(pictureBoxProduto.Image),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(produto);
                AtualizaTela();
                LimpaTela();
                MessageBox.Show("Dados editados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonExcluirProduto_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = int.Parse(maskedTextBox1.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(produto);
                AtualizaTela();
                LimpaTela();
                MessageBox.Show("Dados excluidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }
    }
}
