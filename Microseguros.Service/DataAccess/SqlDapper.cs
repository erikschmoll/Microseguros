using Microseguros.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Microseguros.Service.DataAccess
{
    public class SqlDapper<T> : ISqlDapper<T>
    {
        private readonly ILogger<SqlDapper<T>> _logger;
        private readonly IConnectionBuilder _connectionBuilder;
        public SqlDapper(ILogger<SqlDapper<T>> logger, IConnectionBuilder connectionBuilder)
        {
            _logger = logger;
            _connectionBuilder = connectionBuilder;
        }
        public async Task<IEnumerable<T>> GetAsync(string query, object values = null)
        {
            try
            {
                using (IDbConnection db = _connectionBuilder.GetConnection())
                {
                    return await db.QueryAsync<T>(query, values);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SqlDapper<T>/GetAsync");
                throw ex;
            }

        }
        public IEnumerable<T> Get(string query, object values = null)
        {
            try
            {
                using (IDbConnection db = _connectionBuilder.GetConnection())
                {
                    return db.Query<T>(query, values);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SqlDapper<T>/Get");
                throw ex;
            }

        }
    }
}
