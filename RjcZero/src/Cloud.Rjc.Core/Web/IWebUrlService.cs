namespace Cloud.Rjc.Web
{
    public interface IWebUrlService
    {
        string GetSiteRootAddress(string tenancyName = null);

        bool SupportsTenancyNameInUrl { get; }
    }
}
