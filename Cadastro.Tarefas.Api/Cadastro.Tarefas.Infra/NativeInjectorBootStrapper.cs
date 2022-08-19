﻿using Cadastro.Tarefas.Core.Contextos.CadastroTarefas;
using Cadastro.Tarefas.Core.Interfaces.Repositories;
using Cadastro.Tarefas.Core.Repositories.CadastroTarefas;
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro.Tarefas.Infra
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra - Data
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<TarefasContext>();
        }
    }
}