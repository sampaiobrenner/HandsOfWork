using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Services.Pessoas;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Views.Clientes
{
    public partial class FormCadastroCliente : Form
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;
        private readonly IPessoaJuridicaService _pessoaJuridicaService;

        public FormCadastroCliente(IPessoaFisicaService pessoaFisicaService, IPessoaJuridicaService pessoaJuridicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
            _pessoaJuridicaService = pessoaJuridicaService;
            InitializeComponent();
        }

        public Guid? IdPessoa { get; set; }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarDadosParaSalvarPessoa()) return;

            if (chkPessoaFisica.Checked)
                SalvarPessoaFisica();
            else
                SalvarPessoaJuridica();

            Close();
        }

        private void CarregarCliente()
        {
            if (IdPessoa is null) return;

            var pessoa = _pessoaFisicaService.ObterPorId(IdPessoa.Value);
            lblNome.Text = pessoa.Nome;
            lblEmail.Text = pessoa.Email;
            lblCpfCnpj.Text = pessoa.Cpf;
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        private void SalvarPessoaFisica()
        {
            var pessoa = new PessoaFisica()
            {
                Id = IdPessoa ?? Guid.Empty,
                Nome = lblNome.Text,
                Email = lblEmail.Text,
                Cpf = lblCpfCnpj.Text
            };

            if (IdPessoa is null)
                _pessoaFisicaService.Cadastrar(pessoa);
            else
                _pessoaFisicaService.Editar(pessoa);
        }

        private void SalvarPessoaJuridica()
        {
            var pessoa = new PessoaJuridica()
            {
                Id = IdPessoa ?? Guid.Empty,
                Nome = lblNome.Text,
                Email = lblEmail.Text,
                Cnpj = lblCpfCnpj.Text
            };

            if (IdPessoa is null)
                _pessoaJuridicaService.Cadastrar(pessoa);
            else
                _pessoaJuridicaService.Editar(pessoa);
        }

        private bool ValidarDadosParaSalvarPessoa()
        {
            if (string.IsNullOrEmpty(lblNome.Text))
            {
                MessageBox.Show("O campo nome deve ser informado.");
                lblNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(lblEmail.Text))
            {
                MessageBox.Show("O campo email deve ser informado.");
                lblEmail.Focus();
                return true;
            }

            if (!chkPessoaFisica.Checked && !chkPessoaJuridica.Checked)
            {
                MessageBox.Show("O tipo da pessoa deve ser informado.");
                return true;
            }

            return false;
        }
    }
}