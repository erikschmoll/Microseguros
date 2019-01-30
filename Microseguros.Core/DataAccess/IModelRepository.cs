using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Core.DataAccess
{
    public interface IModelRepository
    {
        Task<IEnumerable<Model>> GetAsync(ModelFilter modelFilter);
    }
}
