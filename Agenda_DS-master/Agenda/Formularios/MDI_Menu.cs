using Agenda.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta consulta = new consulta();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
