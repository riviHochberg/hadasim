using Corona.BL.DTO;

namespace Corona.BL
{
    public interface IPatientAndCoronaInfoBL
    {
        Task<bool> addPatient(PatientDTO patientDTO);
        Task<List<PatientDTO>> GetAllPatientsAsync();
        Task<PatientDTO> GetPatientAsync(string tz);
    }
}