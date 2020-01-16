using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Execution.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace hotchocolate_shell.Infrastructure
{
    public static class GraphqlInit
    {
        public static IServiceCollection
            AddCustomizedGraphQl(this IServiceCollection services, IWebHostEnvironment env)
        {
            return services
                    .AddDataLoaderRegistry()
                    .AddGraphQL(
                        provider =>
                        {
                            return SchemaBuilder.New()
                                .AddServices(provider)
                                .AddQueryType<QueryType>()
                                .AddMutationType<MutationType>()
                                .Create();
                        },
                        builder =>
                            builder
                                .UseDefaultPipeline()
                                .AddOptions(new QueryExecutionOptions {IncludeExceptionDetails = env.IsDevelopment()})
                    )
                ;
        }
    }
}