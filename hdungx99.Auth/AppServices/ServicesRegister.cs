using hdungx99.Auth.Configuration;

namespace hdungx99.Auth.AppServices
{
    public static class ServicesRegister
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddIdentityServer()
              .AddInMemoryApiScopes(InMemoryConfig.GetApiScopes())
              .AddInMemoryApiResources(InMemoryConfig.GetApiResources())
              .AddInMemoryIdentityResources(InMemoryConfig.GetIdentityResources())
              .AddTestUsers(InMemoryConfig.GetUsers())
              .AddInMemoryClients(InMemoryConfig.GetClients())
              .AddDeveloperSigningCredential(); //not something we want to use in a production environment;
        }
    }
}
