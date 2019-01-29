using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Microseguros.Core.DataAccess
{
    public interface IConnectionBuilder
    {
        SqlConnection GetConnection();
    }
}
