using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        /// <param name="school"></param>
        /// <returns></returns>
        [HttpGet("bySchool")]
        public async Task<ActionResult<double>> GetAbsenceBySchool([FromQuery] string school)
        {
            try 
            {
                var result = await _absenceService.GetAbsenceBySchoolAsync(school);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
