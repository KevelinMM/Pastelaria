namespace Pastelaria_do_Zé
{
    public partial class Login : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Login()
        {
            InitializeComponent();
            labelLoginUsuario.Text = Properties.Resources.ResourceManager.GetString("txtUsuario");
            labelLoginSenha.Text = Properties.Resources.ResourceManager.GetString("txtSenha");
            labelLoginTitulo.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincial");
            buttonLoginEntrar.Text = Properties.Resources.ResourceManager.GetString("txtEntrar");
            buttonLoginEsqueciSenha.Text = Properties.Resources.ResourceManager.GetString("txtEsqueciSenha");
            textBoxLoginSenha.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxLoginSenha.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxLoginUsuario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxLoginUsuario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
        }       

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((textBoxLoginUsuario.Text != "") && (textBoxLoginSenha.Text != ""))
            {
                this.Hide();
                Menu menu = new();
                menu.FormClosed += (s, args) =>
                this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Alerta", MessageBoxButtons.OK);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Recuperarsenha recuperarsenha = new();
            recuperarsenha.Show(this);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBoxLoginUsuario.BackColor = Color.LightBlue;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            textBoxLoginUsuario.BackColor = Color.White;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            textBoxLoginSenha.BackColor = Color.White;
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBoxLoginSenha.BackColor = Color.LightBlue;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
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