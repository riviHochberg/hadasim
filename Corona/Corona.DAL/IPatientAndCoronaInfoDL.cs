using Corona.DAL.Models;

namespace Corona.DAL
{
    public interface IPatientAndCoronaInfoDL
    {
        Task<bool> addPatient(Patient patient);
        Task<List<Patient>> GetAllPatientsAsync();
        Task<Patient> GetPatientAsync(string tz);
    }
}