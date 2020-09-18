
using System.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WeatherStationAPI.Library.Internal.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess, IDisposable
    {
        public SqlDataAccess(IConfiguration config, ILogger<SqlDataAccess> logger)
        {
            _config = config;
            _logger = logger;
        }

        /// <summary>
        /// Gets the connection string from web.config
        /// </summary>
        /// <param name="name">The name of the connection string in web.config</param>
        /// <returns>The specified connection string</returns>
        public string GetConnectionString(string name)
        {
            return _config.GetConnectionString(name);
        }

        /// <summary>
        /// Generic Method to call stored procedure and load data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U">The parameters for the stored procedure</typeparam>
        /// <param name="storedProcedure">The name of the sp to call</param>
        /// <param name="parameters"></param>
        /// <param name="connectionStringName">The name of the connection string to use</param>
        /// <returns>A set of rows</returns>
        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();
                return rows;
            }
        }

        /// <summary>
        /// Save data to db
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedure">the name of the desired sp</param>
        /// <param name="parameters">the params for the sp</param>
        /// <param name="connectionStringName">the name of the connection string you will be using in web.config</param>
        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public void StartTransaction(string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            _transaction = _connection.BeginTransaction();

            isClosed = false;
        }

        public void SaveDataInTransaction<T>(string storedProcedure, T parameters)
        {
            _connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure, transaction: _transaction);
        }

        public List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters)
        {
            List<T> rows = _connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure, transaction: _transaction).ToList();
            return rows;
        }

        private bool isClosed = false;
        private readonly IConfiguration _config;
        private readonly ILogger<SqlDataAccess> _logger;

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _connection?.Close();

            isClosed = true;
        }

        public void RollBackTransaction()
        {
            _transaction?.Rollback();
            _connection?.Close();

            isClosed = true;
        }

        public void Dispose()
        {
            if (!isClosed)
            {
                try
                {
                    CommitTransaction();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Commit transaction failed in the dispose method");
                }
            }

            _transaction = null;
            _connection = null;
        }
    }
}
