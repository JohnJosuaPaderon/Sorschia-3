namespace Sorschia
{
    public sealed class SorschiaDependencyConfiguration
    {
        internal SorschiaDependencyConfiguration()
        {
        }

        public sealed class SecurityConfiguration
        {
            internal SecurityConfiguration()
            {
            }

            public bool AddCryptor { get; set; } = true;
        }

        public SecurityConfiguration Security { get; } = new SecurityConfiguration();

        public bool AddDependencyProvider { get; set; } = true;
    }
}
