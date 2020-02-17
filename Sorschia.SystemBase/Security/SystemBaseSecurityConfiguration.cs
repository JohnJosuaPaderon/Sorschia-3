namespace Sorschia.SystemBase.Security
{
    public sealed class SystemBaseSecurityConfiguration
    {
        public sealed class CacheExpirationSection
        {
            public long? DeleteModule { get; set; } = 5;
        }

        public CacheExpirationSection CacheExpiration { get; set; } = new CacheExpirationSection();
    }
}
