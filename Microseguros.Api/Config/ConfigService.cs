using Microseguros.Core.Business;
using Microseguros.Business;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microseguros.Api.Config
{
    public static class ConfigService
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            services.AddSingleton<IDeviceService, DeviceService>();
            return services;
        }
    }
}
