using System;
using System.Windows.Forms;
using HandsOfWork.Entities;

namespace HandsOfWork.Views
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente(ModoOperacao modoOperacao)
        {
            InitializeComponent();
            AlterarTituloDaJanela(modoOperacao);
        }

        private void AlterarTituloDaJanela(ModoOperacao modoOperacao)
        {
            Text = modoOperacao == ModoOperacao.Adicionar
                ? "Adicionar cliente"
                : "Alterar cliente";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}