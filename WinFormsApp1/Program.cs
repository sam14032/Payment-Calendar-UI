using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using POC.API.Lib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {
        static IMediator mediator;
        static ServiceCollection services;

        static void ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            mediator = services.BuildServiceProvider().GetRequiredService<IMediator>();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1(services));
        }
    }
}
