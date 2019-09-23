using Microsoft.Extensions.Configuration;

namespace Sorschia.Data
{
    internal sealed class ConnectionStringProvider : IConnectionStringProvider
    {
        public ConnectionStringProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private readonly IConfiguration _configuration;

        public string this[string key]
        {
            get
            {
                ValidateKey(key);
                return _configuration.GetConnectionString(key);
            }
        }

        private void ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new SorschiaDataException("Connection string key cannot be null or white space");
            }
        }
    }
}
