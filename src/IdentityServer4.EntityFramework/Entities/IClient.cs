using System.Collections.Generic;

namespace IdentityServer4.EntityFramework.Entities
{
    public interface IClient
    {
        int AbsoluteRefreshTokenLifetime { get; set; }
        int AccessTokenLifetime { get; set; }
        int AccessTokenType { get; set; }
        bool AllowAccessTokensViaBrowser { get; set; }
        List<ClientCorsOrigin> AllowedCorsOrigins { get; set; }
        List<ClientGrantType> AllowedGrantTypes { get; set; }
        List<ClientScope> AllowedScopes { get; set; }
        bool AllowOfflineAccess { get; set; }
        bool AllowPlainTextPkce { get; set; }
        bool AllowRememberConsent { get; set; }
        bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        bool AlwaysSendClientClaims { get; set; }
        int AuthorizationCodeLifetime { get; set; }
        List<ClientClaim> Claims { get; set; }
        string ClientId { get; set; }
        string ClientName { get; set; }
        List<ClientSecret> ClientSecrets { get; set; }
        string ClientUri { get; set; }
        bool Enabled { get; set; }
        bool EnableLocalLogin { get; set; }
        int Id { get; set; }
        List<ClientIdPRestriction> IdentityProviderRestrictions { get; set; }
        int IdentityTokenLifetime { get; set; }
        bool IncludeJwtId { get; set; }
        string LogoUri { get; set; }
        bool LogoutSessionRequired { get; set; }
        string LogoutUri { get; set; }
        List<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
        bool PrefixClientClaims { get; set; }
        string ProtocolType { get; set; }
        List<ClientRedirectUri> RedirectUris { get; set; }
        int RefreshTokenExpiration { get; set; }
        int RefreshTokenUsage { get; set; }
        bool RequireClientSecret { get; set; }
        bool RequireConsent { get; set; }
        bool RequirePkce { get; set; }
        int SlidingRefreshTokenLifetime { get; set; }
        bool UpdateAccessTokenClaimsOnRefresh { get; set; }

        Models.Client ToModel();
    }
}