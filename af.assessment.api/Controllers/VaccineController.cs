using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;
using af.assessment.api.Enums;
using af.assessment.api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace af.assessment.api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("/v1/")]
    public class VaccineController : ControllerBase
    {
        private readonly IVaccineService _vaccineService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vaccineService"></param>
        public VaccineController(IVaccineService vaccineService)
        {
            _vaccineService = vaccineService;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberId">
        ///
        /// </param>
        /// <returns>
        ///
        /// </returns>
        [HttpGet("appointments/{memberId}")]
        [Produces("application/json")]
        [SwaggerOperation("get-all-appointments")]
        [SwaggerResponse(200, type: typeof(Appointment), description: "Appointment list successfully retrieved")]
        public async Task<List<Appointment>> GetAppointmentsByStatus(Guid memberId)
        {
            var _memberId = memberId;

            return await _vaccineService.GetAppointmentsByStatus(_memberId, AppointmentStatus.UpComing);
        }
    }
}