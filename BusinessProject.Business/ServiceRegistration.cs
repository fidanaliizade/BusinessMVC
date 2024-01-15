using BusinessProject.Business.Services.Implementations;
using BusinessProject.Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business
{
    public static class ServiceRegistration
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IBlogService, BlogService>();
        }
    }
}
