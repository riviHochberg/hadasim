using AutoMapper;
using Corona.BL.DTO;
using Corona.DAL;
using Corona.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.BL
{
    public class PatientAndCoronaInfoBL : IPatientAndCoronaInfoBL
    {
        private readonly IPatientAndCoronaInfoDL _patientAndCoronaInfoDL;
        private readonly IMapper _mapper;

        public PatientAndCoronaInfoBL(IPatientAndCoronaInfoDL patientAndCoronaInfoDL)
        {
            _patientAndCoronaInfoDL = patientAndCoronaInfoDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            _mapper = config.CreateMapper();
        }

        public async Task<List<PatientDTO>> GetAllPatientsAsync()
        {
            List<Patient> patients = await _patientAndCoronaInfoDL.GetAllPatientsAsync();
            List<PatientDTO> patientsDTO = patients.ConvertAll(patient => _mapper.Map<PatientDTO>(patient));
            return patientsDTO;
        }
        public async Task<PatientDTO> GetPatientAsync(string tz)
        {
            Patient patient = await _patientAndCoronaInfoDL.GetPatientAsync(tz);
            PatientDTO patientDTO = _mapper.Map<PatientDTO>(patient);
            return patientDTO;
        }
        public async Task<bool> addPatient(PatientDTO patientDTO)
        {
            Patient patient = _mapper.Map<Patient>(patientDTO);
            return await _patientAndCoronaInfoDL.addPatient(patient);
        }
    }
}
