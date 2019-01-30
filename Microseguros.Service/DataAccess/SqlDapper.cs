using Microseguros.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace Microseguros.Service.DataAccess
{
    public class SqlDapper<T> : ISqlDapper<T>
    {
        private readonly IConnectionBuilder _connectionBuilder;
        public SqlDapper(IConnectionBuilder connectionBuilder)
        {
            _connectionBuilder = connectionBuilder;
        }
        public async Task<IEnumerable<T>> GetAsync(string table, string where = null, string orderby = null, object values = null)
        {
            try
            {
                using (IDbConnection db = _connectionBuilder.GetConnection())
                {
                    string query = $@" select * from {table} {where} {orderby} ";
                    return await db.QueryAsync<T>(query, values);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public IEnumerable<T> Get(string table, string where = null, string orderby = null, object values = null)
        {
            try
            {
                using (IDbConnection db = _connectionBuilder.GetConnection())
                {
                    string query = $@" select * from {table} {where} {orderby} ";
                    return db.Query<T>(query, values);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
