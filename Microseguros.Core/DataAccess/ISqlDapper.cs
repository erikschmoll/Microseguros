using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Microseguros.Core.DataAccess
{
    public interface ISqlDapper<T>
    {
        IEnumerable<T> Get(string table, string where = null, string orderby = null, object values = null);
    }
}
