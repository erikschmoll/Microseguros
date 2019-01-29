using Microseguros.Core;
using Microseguros.Core.DataAccess;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Microseguros.Service.DataAccess
{
    public class ConnectionBuilder : IConnectionBuilder
    {
        private readonly DBOptions _options;

        public ConnectionBuilder(IOptions<DBOptions> options)
        {
            _options = options.Value;
        }

        public SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(_options.ConnectionString);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
