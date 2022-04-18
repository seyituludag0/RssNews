using Business.Abstracts;
using Business.Concretes;
using Core.Security.JWT;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.EntityFramework.Contexts;
using DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configurations
{
    public static class ServiceRegistrations
    {
        public static void ServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<INewsService, NewsManager>();

            services.AddScoped<IUserDal, EfUserDal>();

            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<ITokenHelper, JwtHelper>();
        }
    }
}
