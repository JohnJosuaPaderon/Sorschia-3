using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public abstract class SqlProcessBase : DbProcessBase
    {
        private SqlConnection InitializeConnection(string connectionStringKey = null)
        {
            return new SqlConnection(ConnectionStringProvider[connectionStringKey ?? DEFAULT_CONNECTION_STRING_KEY]);
        }

        protected SqlConnection OpenConnection(string connectionStringKey = null)
        {
            var connection = InitializeConnection(connectionStringKey);
            connection.Open();
            return connection;
        }

        protected async Task<SqlConnection> OpenConnectionAsync(string connectionStringKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = InitializeConnection(connectionStringKey);
            await connection.OpenAsync(cancellationToken);
            return connection;
        }
    }
}
