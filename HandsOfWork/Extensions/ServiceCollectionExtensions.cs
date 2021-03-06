﻿using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Entities.Produtos;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.Pessoas;
using HandsOfWork.Repositories.Produtos;
using HandsOfWork.Services.Categorias;
using HandsOfWork.Services.Pessoas;
using HandsOfWork.Services.Produtos;
using HandsOfWork.Views.Clientes;
using HandsOfWork.Views.MenuPrincipal;
using HandsOfWork.Views.Movimentacoes;
using HandsOfWork.Views.Produtos;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOfWork.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddForms(this IServiceCollection services)
            => services
                .AddTransient<FormPrincipal>()
                .AddTransient<FormCliente>()
                .AddTransient<FormCadastroCliente>()
                .AddTransient<FormProduto>()
                .AddTransient<FormCadastroProduto>()
                .AddTransient<FormMovimentacoes>();

        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services
                .AddScoped<ICrudRepository<Produto>, ProdutoRepository>()
                .AddScoped<ICrudRepository<PessoaFisica>, PessoaFisicaRepository>()
                .AddScoped<ICrudRepository<PessoaJuridica>, PessoaJuridicaRepository>();

        public static IServiceCollection AddServices(this IServiceCollection services)
            => services
                .AddScoped<IPessoaFisicaService, PessoaFisicaService>()
                .AddScoped<IPessoaJuridicaService, PessoaJuridicaService>()
                .AddScoped<IProdutoService, ProdutoService>()
                .AddScoped<ICategoriaService, CategoriaService>();
    }
}