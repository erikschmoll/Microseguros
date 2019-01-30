using Microseguros.Core.DataAccess;
using Microseguros.Core.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Service.DataAccess
{
    public class ModelRepository : IModelRepository
    {
        private readonly ISqlDapper<Model> _sqlDapper;
        private readonly ILogger<ModelRepository> _logger;
        public ModelRepository(ILogger<ModelRepository> logger, ISqlDapper<Model> sqlDapper)
        {
            _logger = logger;
            _sqlDapper = sqlDapper;
        }

        public async Task<IEnumerable<Model>> GetAsync(ModelFilter modelFilter)
        {
            try
            {
                int top = modelFilter.Top.HasValue ? modelFilter.Top.Value : 20;
                int skip = modelFilter.Skip.HasValue ? modelFilter.Skip.Value : 0;
                /*TODO: guardar el valor 20 y 0 en el appsettings.json*/
                object param = new { End = top, Start = skip };
                string query = @"SELECT * FROM 
                                    ( SELECT *
			                            from models 
                                    ) SubQueryAlias
                             order by name desc
                            OFFSET @Start ROWS -- skip 10 rows
                            FETCH NEXT @End ROWS ONLY; -- take 10 rows";
                if (!string.IsNullOrEmpty(modelFilter.Patt) && modelFilter.BrandId.HasValue)
                {
                    param = new { End = top, Start = skip, Name = modelFilter.Patt, BrandId = modelFilter.BrandId.Value };
                    query = @"SELECT * FROM 
                            ( SELECT *
			                    from models 
                                where name like @Name
                                and brandId = @BrandId
                            ) SubQueryAlias
                     order by name desc
                    OFFSET @Start ROWS
                    FETCH NEXT @End ROWS ONLY";
                }
                else if(!string.IsNullOrEmpty(modelFilter.Patt))
                {
                    param = new { End = top, Start = skip, Name = modelFilter.Patt };
                    query = @"SELECT * FROM 
                            ( SELECT *
			                    from models 
                                where name like @Name
                            ) SubQueryAlias
                     order by name desc
                    OFFSET @Start ROWS
                    FETCH NEXT @End ROWS ONLY";
                }
                else if (modelFilter.BrandId.HasValue)
                {
                    param = new { End = top, Start = skip, BrandId = modelFilter.BrandId.Value };
                    query = @"SELECT * FROM 
                            ( SELECT *
			                    from models 
                                where brandId = @BrandId
                            ) SubQueryAlias
                     order by name desc
                    OFFSET @Start ROWS
                    FETCH NEXT @End ROWS ONLY";
                }
                return await _sqlDapper.GetAsync(query, param);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ModelRepository/GetAsync");
                throw ex;
            }
        }
    }
}
