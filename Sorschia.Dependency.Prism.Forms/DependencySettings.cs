namespace Sorschia
{
    public sealed class DependencySettings
    {
        public sealed class SecuritySection
        {
            internal SecuritySection()
            {
            }

            public bool AddCryptor { get; set; } = true;
        }

        internal DependencySettings()
        {
        }

        public SecuritySection Security { get; } = new SecuritySection();

        public bool AddDependencyProvider { get; set; } = true;
        // Obsolete: Version 0.3.0
        //public bool AddSessionVariables { get; set; } = true;
    }
}
