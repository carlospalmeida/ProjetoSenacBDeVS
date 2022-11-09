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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 janelanova = new Form1();
            janelanova.ShowDialog();
        }

        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 janelanova = new Form3();
            janelanova.ShowDialog();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesso negado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesso negado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesso negado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
