using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Pastelaria_do_Zé
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Configuracoes : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Configuracoes()
        {
            InitializeComponent();
            labelConfiguracoes.Text = Properties.Resources.ResourceManager.GetString("txtConfiguracoes");
            labelConfigSistemasCobranca.Text = Properties.Resources.ResourceManager.GetString("txtSistemasCobraca");
            labelConfigPercentual.Text = Properties.Resources.ResourceManager.GetString("txtPercentualJuros");
            labelConfigMulta.Text = Properties.Resources.ResourceManager.GetString("txtMultas");
            labelConfigIdioma.Text = Properties.Resources.ResourceManager.GetString("txtIdioma");
            checkBoxSelecionarIdioma.Text = Properties.Resources.ResourceManager.GetString("txtSelecionar");
            buttonConfigSalvar.Text = Properties.Resources.ResourceManager.GetString("txtSalvar");
            textBoxConfig1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxConfig1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxConfig2.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxConfig2.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            TextBoxStringDeConexao.Text = connectionStringSettings.ConnectionString;
        }

        private void ButtonConfigSalvar_Click(object sender, EventArgs e)
        {
            
                //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //altera os valores de provider e da connectionStrings com nome BD
                config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
                config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = TextBoxStringDeConexao.Text;
                //salva as alterações
                config.Save(ConfigurationSaveMode.Modified, true);
                //recarrega os dados da seção especificada
                ConfigurationManager.RefreshSection("connectionStrings");
                //fecha a tela
                Close();
                //dispara msg para usuário
                _ = MessageBox.Show("Dados alterados com sucesso!");
            
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxConfig.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("AppSettings");

            Close();
            var mensagem = Properties.Resources.ResourceManager.GetString("txtRestart");
            _ = MessageBox.Show(mensagem);

            if (checkBoxSelecionarIdioma.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void Configuracoes_KeyDown(object sender, KeyEventArgs e)
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
        private void Configuracoes_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void buttonSairConfig_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
