using Microseguros.Core.Business;
using Microseguros.Business;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microseguros.Core.DataAccess;
using Microseguros.Service.DataAccess;
using Microseguros.Core.Models;
using Microseguros.Service.Business;

namespace Microseguros.Api.Config
{
    public static class ConfigService
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            #region Services
            services.AddSingleton<IDeviceService, DeviceService>();
            services.AddSingleton<IModelService, ModelService>();
            #endregion

            #region Repository
            services.AddSingleton<IConnectionBuilder, ConnectionBuilder>();
            services.AddSingleton(typeof(ISqlDapper<>), typeof(SqlDapper<>));
            services.AddSingleton<IDeviceRepository, DeviceRepository>();
            services.AddSingleton<IModelRepository, ModelRepository>();
            #endregion

            return services;
        }
    }
}
