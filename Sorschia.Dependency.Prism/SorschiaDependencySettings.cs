namespace Sorschia
{
    public sealed class SorschiaDependencySettings
    {
        internal SorschiaDependencySettings()
        {
        }

        public sealed class SecuritySettings
        {
            internal SecuritySettings()
            {
            }

            public bool AddCryptor { get; set; } = true;
        }

        public SecuritySettings Security { get; } = new SecuritySettings();

        public bool AddDependencyProvider { get; set; } = true;
        public bool AddSessionVariables { get; set; } = true;
    }
}
