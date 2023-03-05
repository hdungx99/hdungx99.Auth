using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Test;
using System.Security.Claims;

namespace hdungx99.Auth.Configuration
{
    public static class InMemoryConfig
    {
        public static IEnumerable<IdentityResource> GetIdentityResources() =>
          new List<IdentityResource>
          {
          new IdentityResources.OpenId(),
          new IdentityResources.Profile()
          };

        public static List<TestUser> GetUsers() =>
          new List<TestUser>
          {
              new TestUser
              {
                  SubjectId = "a9ea0f25-b964-409f-bcce-c923266249b4",
                  Username = "dane.dung",
                  Password = "Sul@30ka#",
                  Claims = new List<Claim>
                  {
                      new Claim("given_name", "Dane"),
                      new Claim("family_name", "Dungx")
                  }
              }
          };

        public static IEnumerable<Client> GetClients() =>
            new List<Client>
            {
               new Client
               {
                    ClientId = "hdungx99.movies",
                    ClientSecrets = new [] { new Secret("hdungx99-movies".Sha512()) },
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = { IdentityServerConstants.StandardScopes.OpenId, "hdungx99.moviesAPI" }
               },
               new Client
               {
                    ClientId = "hdungx99.movies.mvc-client",
                    ClientSecrets = new [] { new Secret("hdungx99-movies.mvc-client".Sha512()) },
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    RedirectUris = new List<string>{ "https://localhost:5010/signin-oidc" },
                    RequirePkce = false,
                    AllowedScopes = { IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Profile }
               }
            };

        public static IEnumerable<ApiScope> GetApiScopes() =>
            new List<ApiScope> { new ApiScope("hdungx99.moviesAPI", "hdungx99 Movies API") };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>
            {
                new ApiResource("hdungx99.moviesAPI", "hdungx99 Movies API")
                {
                    Scopes = { "hdungx99.moviesAPI" }
                }
            };
    }
}
