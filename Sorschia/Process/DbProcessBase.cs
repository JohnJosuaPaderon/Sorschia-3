using Sorschia.Data;

namespace Sorschia.Process
{
    public abstract class DbProcessBase : ProcessBase
    {
        protected const string DEFAULT_CONNECTION_STRING_KEY = "default";

        private IConnectionStringProvider _connectionStringProvider;

        protected IConnectionStringProvider ConnectionStringProvider
        {
            get
            {
                if (_connectionStringProvider == null)
                {
                    _connectionStringProvider = Global.DependencyProvider.Get<IConnectionStringProvider>(true);
                }

                return _connectionStringProvider;
            }
        }
    }
}
