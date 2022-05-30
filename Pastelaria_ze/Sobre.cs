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
    public partial class Sobre : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Sobre()
        {
            InitializeComponent();
            labelSobreNomeProduto.Text = Properties.Resources.ResourceManager.GetString("txtNomeProduto");
            labelSobreCompanhia.Text = Properties.Resources.ResourceManager.GetString("txtNomeCompanhia");
            labelSobreVersao.Text = Properties.Resources.ResourceManager.GetString("txtVersao");
            labelSobreDescricao.Text = Properties.Resources.ResourceManager.GetString("txtDescricao");
            buttonSobreVoltar.Text = Properties.Resources.ResourceManager.GetString("txtVoltar");
            textBoxSobreCopyright.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxSobreCopyright.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxSobreDescricao.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxSobreDescricao.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxSobreNome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxSobreNome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxSobreVersao.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxSobreVersao.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
        }

        private void Sobre_KeyDown(object sender, KeyEventArgs e)
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

        private void buttonSobreVoltar_Click(object sender, EventArgs e)
        {          
          Close();  
        }
    }
}
