using Sorschia.Data;

namespace Sorschia.Process
{
    public abstract class DbProcessBase : ProcessBase
    {
        protected const string DEFAULT_CONNECTION_STRING_KEY = "default";

        public DbProcessBase(IConnectionStringProvider connectionStringProvider)
        {
            ConnectionStringProvider = connectionStringProvider;
        }

        protected IConnectionStringProvider ConnectionStringProvider { get; }
    }
}
