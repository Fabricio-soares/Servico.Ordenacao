using fgv.ordenacao.dominio;
using fgv.ordenacao.dominio.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace fgv.ordenacao.ioc
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IOrdenacaoLivro, OrdenacaoLivro>();
            return services;
        }
    }
}
