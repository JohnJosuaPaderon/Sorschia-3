using Sorschia.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class SqlProcessBase : DbProcessBase
    {
        public SqlProcessBase(IConnectionStringProvider connectionStringProvider) : base(connectionStringProvider)
        {
        }

        private SqlConnection InitializeConnection(string connectionStringKey = null)
        {
            return new SqlConnection(ConnectionStringProvider[connectionStringKey ?? DEFAULT_CONNECTION_STRING_KEY]);
        }
        
        protected SqlConnection OpenConnection(string connectionStringKey)
        {
            var connection = InitializeConnection(connectionStringKey);
            connection.Open();
            return connection;
        }

        protected SqlConnection OpenConnection()
        {
            return OpenConnection(null);
        }

        protected async Task<SqlConnection> OpenConnectionAsync(string connectionStringKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = InitializeConnection(connectionStringKey);
            await connection.OpenAsync(cancellationToken);
            return connection;
        }

        protected Task<SqlConnection> OpenConnectionAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return OpenConnectionAsync(null, cancellationToken);
        }
    }
}
