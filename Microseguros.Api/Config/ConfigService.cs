using Microseguros.Core.Services;
using Microseguros.Service;
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
