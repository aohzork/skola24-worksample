using API.Data.OutputModels;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class AbsenceController : ControllerBase
    {
        private IAbsenceService _absenceService;
        public AbsenceController(IAbsenceService absenceService)
        {
            _absenceService = absenceService;
        }

        /// <summary>
        /// Get total absence from a School by name
        /// </summary>
        /// <param name="schoolName"></param>
        /// <returns></returns>
        [HttpGet("bySchool")]
        public async Task<ActionResult<double>> GetAbsenceBySchool([FromQuery] string schoolName)
        {
            try 
            {
                var result = await _absenceService.GetAbsenceBySchoolAsync(schoolName);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ofStudentsBySchool")]
        public async Task<ActionResult<List<StudentsAbsences>>> StudentsAbsenceBySchool([FromQuery] string schoolName)
        {
            try
            {
                var result = await _absenceService.GetStudentsAbsenceBySchool(schoolName);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
