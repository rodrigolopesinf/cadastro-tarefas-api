using Cadastro.Tarefas.Core.Contextos.CadastroTarefas;
using Cadastro.Tarefas.Core.Interfaces.Repositories;
using Cadastro.Tarefas.Core.Repositories.CadastroTarefas;
using Cadastro.Tarefas.Core.Services.CadastroTarefas;
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro.Tarefas.Infra
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<TarefasContext>();

            // Service
            services.AddScoped<ITarefaService, TarefaService>();
        }
    }
}