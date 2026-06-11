using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Formularios
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.pessoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filtro;
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um campo para filtrar");
                return;
            }
            filtro = comboBox1.Text;
            string buscar = comboBox2.Text;
            if (buscar == "todos") {
                filtro = "";
            }
            else if (buscar == "Que começa com") {
                filtro += " LIKE '" + textBox1.Text + "%'";
            }
            else if (buscar == "Que termina com") {
                filtro += " LIKE '%" + textBox1.Text + "'";
            }
            else if (buscar == "Que contem") {
                filtro += " LIKE '%" + textBox1.Text + "%'";
            }
            else if (buscar == "igual") {
                filtro += " = '" + textBox1.Text + "'";
            }
            pessoaBindingSource.Filter = filtro;
        }
    }
}
