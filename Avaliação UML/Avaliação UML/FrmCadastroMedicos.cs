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
    public partial class FrmCadastroMedicos : Form
    {
        private readonly Hospital hospital;

        public FrmCadastroMedicos()
        {
            InitializeComponent();
            hospital = new Hospital();
            AtualizarDataGridView();
            SetupPlaceholders();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCRM.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hospital.VerificarExistenciaMedico(txtCRM.Text))
            {
                MessageBox.Show("Já existe um médico cadastrado com o mesmo CRM.", "Erro de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dptData.Value == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, selecione o ano de residência no calendário.", "Seleção Necessária", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfissionalSaude novoMedico = new ProfissionalSaude
            {
                Nome = txtNome.Text,
                CRM = txtCRM.Text,
                TipoProfissional = txtTipo.Text,
                TitulacaoUniversitaria = txtTitulacao.Text,
                AnoResidencia = dptData.Value
            };

            hospital.AdicionarProfissional(novoMedico);

            MessageBox.Show("Médico cadastrado com sucesso!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
            AtualizarDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um médico para editar.", "Seleção Necessária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int idMedico = Convert.ToInt32(dgvMedicos.SelectedRows[0].Cells["Id"].Value);

                ProfissionalSaude medicoSelecionado = hospital.ObterProfissionalPorId(idMedico);
                if (medicoSelecionado != null)
                {
                    if (dgvMedicos.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Por favor, selecione um médico para editar.", "Seleção Necessária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dgvMedicos.ReadOnly = false;
                    dgvMedicos.BeginEdit(true);
                }
                else
                {
                    MessageBox.Show("O médico selecionado não pôde ser encontrado.", "Erro de Seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um médico para excluir.", "Seleção Necessária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Tem certeza de que deseja excluir este médico?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idMedico = (int)dgvMedicos.SelectedRows[0].Cells["Id"].Value;

                hospital.ExcluirProfissional(idMedico);
                MessageBox.Show("Médico excluído com sucesso!", "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarDataGridView();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idMedico = Convert.ToInt32(txtId.Text.Trim());

                ProfissionalSaude medicoEncontrado = hospital.ObterProfissionalPorId(idMedico);
                if (medicoEncontrado != null)
                {
                    txtNome.Text = medicoEncontrado.Nome;
                    txtCRM.Text = medicoEncontrado.CRM;
                    txtTipo.Text = medicoEncontrado.TipoProfissional;
                    txtTitulacao.Text = medicoEncontrado.TitulacaoUniversitaria;
                    dptData.Value = medicoEncontrado.AnoResidencia;
                }
                else
                {
                    MessageBox.Show("Médico não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarDataGridView()
        {
            dgvMedicos.DataSource = hospital.ObterTodosProfissionais();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCRM.Text = "";
            txtTipo.Text = "";
            txtTitulacao.Text = "";
        }

        private void SetupPlaceholders()
        {
            SetPlaceholder(txtId, "Id");
            SetPlaceholder(txtNome, "Nome do Médico");
            SetPlaceholder(txtTipo, "Tipo Profissional");
            SetPlaceholder(txtCRM, "CRM");
            SetPlaceholder(txtTitulacao, "Titulação Universitaria");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;
        }
    }
}
