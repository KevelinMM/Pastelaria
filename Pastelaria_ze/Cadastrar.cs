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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastrar_Produto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastro_Cliente();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Cadastro_Funcionario();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
