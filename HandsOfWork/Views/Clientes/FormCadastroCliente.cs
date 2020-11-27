using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Services.Pessoas;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Views.Clientes
{
    public partial class FormCadastroCliente : Form
    {
        private readonly IPessoaService _pessoaService;

        public FormCadastroCliente(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
            InitializeComponent();
        }

        public Guid? IdPessoa { get; set; }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNome.Text))
            {
                MessageBox.Show("O campo nome deve ser informado.");
                return;
            }

            var pessoa = new Pessoa
            {
                Id = IdPessoa ?? Guid.Empty,
                Nome = lblNome.Text,
                Email = lblEmail.Text
            };

            if (IdPessoa is null)
                _pessoaService.Cadastrar(pessoa);
            else
                _pessoaService.Editar(pessoa);

            Close();
        }
    }
}