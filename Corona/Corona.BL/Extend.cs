using Corona.DAL;
using Corona.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.BL
{
    public static class Extend
    {
        public static void ExtensionsDI(this IServiceCollection service)
        {
            service.AddScoped<IPatientAndCoronaInfoDL, PatientAndCoronaInfoDL>();
            service.AddScoped<IPatientAndCoronaInfoBL, PatientAndCoronaInfoBL>();
        }
        public static void ExtensionDbContext(this IServiceCollection service, string connection)
        {
            service.AddDbContextFactory<CoronaDBContext>(item => item.UseSqlServer(connection));
        }
    }
}
