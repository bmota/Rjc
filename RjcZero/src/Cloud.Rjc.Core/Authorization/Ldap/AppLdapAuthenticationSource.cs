using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Cloud.Rjc.Authorization.Users;
using Cloud.Rjc.MultiTenancy;

namespace Cloud.Rjc.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
