using IdentityServer4;
using IdentityServer4.Models;
using IdentityModel;

namespace PokerCash.Auth.Identity
{
    public static class Configuration
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new("PokerCash.Backend.SignalR", "SignalR")
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new("PokerCash.Backend.SignalR", "SignalR", new []
                    { JwtClaimTypes.Name})
                {
                    Scopes = { "PokerCash.Backend.SignalR" }
                }
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new()
                {
                    ClientId = "wpf-app",
                    ClientName = "PokerCash.Console",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireClientSecret = false,
                    RequirePkce = true,
                    //Страница с подтверждениями прав доступа
                    RequireConsent = false,
                    // Включить в Id Token клаимы с токена доступа
                    // Второй способ на клиенте получить через config.GetClaimsFromUserInfoEndpoint
                    AlwaysIncludeUserClaimsInIdToken = true,
                    RedirectUris =
                    {
                        "http://localhost/sample-wpf-app"
                    },
                    AllowedCorsOrigins =
                    {
                        "http://localhost"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "PokerCash.Backend.SignalR"
                    },
                    AllowAccessTokensViaBrowser = true,
                    AccessTokenLifetime = 3600,
                    // Для Refresh Token
                    AllowOfflineAccess = true
                }
            };
    }
}
