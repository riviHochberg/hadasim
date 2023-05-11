using Corona.BL;
using Corona.BL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Corona.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAndCoronaController : ControllerBase
    {
        private readonly IPatientAndCoronaInfoBL _patientAndCoronaInfoBL;
        public PatientAndCoronaController(IPatientAndCoronaInfoBL patientAndCoronaBL)
        {
            _patientAndCoronaInfoBL = patientAndCoronaBL;
        }

        [HttpGet("GetAllPatients")]
        public async Task<ActionResult> GetAllPatients()
        {
            List<PatientDTO> patientsDTO = await _patientAndCoronaInfoBL.GetAllPatientsAsync();
            return patientsDTO == null ? NotFound() : patientsDTO.Count == 0 ? NoContent() : Ok(patientsDTO);
        }

        [HttpGet("GetPatient/{tz}")]
        public async Task<ActionResult> GetPatient(string tz)
        {
            PatientDTO patientDTO = await _patientAndCoronaInfoBL.GetPatientAsync(tz);
            return patientDTO == null ? NotFound() : Ok(patientDTO);
        }

        [HttpPost("addPatient")]
        public async Task<ActionResult> addPatient([FromBody] PatientDTO patientDTO)
        {
            if (!patientDTO.PatientTz.All(char.IsDigit))
                return BadRequest("The tz feild does not contain only digits");
            bool res = await _patientAndCoronaInfoBL.addPatient(patientDTO);
            return !res ? BadRequest("An error occurred, please try again later") : Ok(res);
        }
    }
}
