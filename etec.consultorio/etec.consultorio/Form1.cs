using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace etec.consultorio
{
    public partial class Consultório : Form
    {
        public Consultório()
        {
            InitializeComponent();
        }

        private void Consultório_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Agendamento Agendamento = new Agendamento();

            Agendamento.MdiParent = this;

            Agendamento.Show();

        }

      

        private void tlblLogin_Click(object sender, EventArgs e)
        {
            Login Logar = new Login();

            Logar.MdiParent = this;

            Logar.Show();

        }

        

        private void tlblMedico_Click(object sender, EventArgs e)
        {
            Medico log = new Medico();

            log.MdiParent = this;

            log.Show();
        }

        private void tlblCadastrar_Click(object sender, EventArgs e)
        {
            cadastro cad = new cadastro();

            cad.MdiParent = this;

            cad.Show();
        }

        
    }
}
