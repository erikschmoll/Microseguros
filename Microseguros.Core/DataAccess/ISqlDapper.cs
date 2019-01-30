using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Core.DataAccess
{
    public interface ISqlDapper<T>
    {
        IEnumerable<T> Get(string query, object values = null);
        Task<IEnumerable<T>> GetAsync(string query, object values = null);
    }
}
