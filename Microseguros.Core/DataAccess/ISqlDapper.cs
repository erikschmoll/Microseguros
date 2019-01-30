using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Core.DataAccess
{
    public interface ISqlDapper<T>
    {
        IEnumerable<T> Get(string table, string where = null, string orderby = null, object values = null);
        Task<IEnumerable<T>> GetAsync(string table, string where = null, string orderby = null, object values = null);
    }
}
