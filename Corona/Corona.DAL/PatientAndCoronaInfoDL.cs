using Corona.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.DAL
{
    public class PatientAndCoronaInfoDL : IPatientAndCoronaInfoDL
    {
        private readonly IDbContextFactory<CoronaDBContext> _factory;

        public PatientAndCoronaInfoDL(IDbContextFactory<CoronaDBContext> factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            using var context = _factory.CreateDbContext();
            return await context.Patients.ToListAsync();
        }

        public async Task<Patient> GetPatientAsync(string tz)
        {
            using var context = _factory.CreateDbContext();
            return await context.Patients.FirstOrDefaultAsync(Patient => Patient.PatientTz.Equals(tz));
        }

        public async Task<bool> addPatient(Patient patient)
        {
            try
            {
                var context = _factory.CreateDbContext();
                await context.Patients.AddAsync(patient);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
