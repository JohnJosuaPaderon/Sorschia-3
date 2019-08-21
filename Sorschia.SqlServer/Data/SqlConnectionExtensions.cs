using System.Data;
using System.Data.SqlClient;

namespace Sorschia.Data
{
    public static class SqlConnectionExtensions
    {
        public static SqlCommand CreateCommand(this SqlConnection instance, string commandText, SqlTransaction transaction = null)
        {
            var command = instance.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = commandText;

            return command;
        }

        public static SqlCommand CreateProcedureCommand(this SqlConnection instance, string procedure, SqlTransaction transaction = null)
        {
            var command = instance.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = procedure;
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }

        public static SqlCommand CreateProcedureCommand(this SqlConnection instance, string schema, string procedure, SqlTransaction transaction = null)
        {
            return instance.CreateProcedureCommand($"{schema}.{procedure}", transaction);
        }
    }
}
