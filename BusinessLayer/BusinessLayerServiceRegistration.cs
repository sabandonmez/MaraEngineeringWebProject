using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class BusinessLayerServiceRegistration
    {
        public static void AddBusinessLayerServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IInstitutionalService, InstitutionalManager>();
            services.AddScoped<IReferenceService, ReferenceManager>();
            services.AddScoped<IServiceAreaService,ServiceAreaManager>();
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<ITeamService, TeamManager>();
            services.AddScoped<IUserService, UserManager>();

        }
    }
}
