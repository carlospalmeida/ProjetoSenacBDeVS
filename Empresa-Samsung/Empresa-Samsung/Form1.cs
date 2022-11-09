using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_Samsung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'empresaDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.empresaDataSet.funcionarios);
            funcionariosBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(empresaDataSet.funcionarios);
            this.funcionariosTableAdapter.Fill(this.empresaDataSet.funcionarios);

            MessageBox.Show("Funcinarios cadastrado com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            funcionariosBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 janelanova = new Form2();
            janelanova.ShowDialog();
        }
    }
}
