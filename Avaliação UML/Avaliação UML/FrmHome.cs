using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliação_UML
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastroMedicos cadastro = new FrmCadastroMedicos();
            cadastro.ShowDialog();
        }

        private void btnPapeis_Click(object sender, EventArgs e)
        {
            FrmPapeisMedicos papeis = new FrmPapeisMedicos();
            papeis.ShowDialog();
        }

        private void btnSolicitarExames_Click(object sender, EventArgs e)
        {
            FrmSolicitarExames exames = new FrmSolicitarExames();
            exames.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
