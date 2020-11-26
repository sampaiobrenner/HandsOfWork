using HandsOfWork.Extensions;
using HandsOfWork.Views.MenuPrincipal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HandsOfWork
{
    public static class Program
    {
        private static ServiceProvider BuildServiceProvider()
          => new ServiceCollection()
              .AddForms()
              .AddServices()
              .AddRepositories()
              .BuildServiceProvider();

        [STAThread]
        private static void Main()
        {
            var serviceProvider = BuildServiceProvider();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetService<FormPrincipal>());
        }
    }
}