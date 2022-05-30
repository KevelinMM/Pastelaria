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
    public partial class Recuperarsenha : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Recuperarsenha()
        {
            InitializeComponent();
            labelRecuperaNomeFuncionario.Text = Properties.Resources.ResourceManager.GetString("txtNomeFuncionario");
            labelRecuperaInformeEmail.Text = Properties.Resources.ResourceManager.GetString("txtRecuperaSenha");
            labelRecuperaNovaSenha.Text = Properties.Resources.ResourceManager.GetString("txtNomeSenha");
            labelRecuperaConfirmacao.Text = Properties.Resources.ResourceManager.GetString("txtReSenha");
            buttonRecuperaSalvar.Text = Properties.Resources.ResourceManager.GetString("txtSalvar");

            textBoxReConfirma.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxReConfirma.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxReEmail.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxReEmail.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxReSenha.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxReSenha.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Recuperarsenha_KeyDown(object sender, KeyEventArgs e)
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
    }
}
