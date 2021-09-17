/*
 * [2019] - [2021] Eblocks Software (Pty) Ltd, All Rights Reserved.
 * NOTICE: All information contained herein is, and remains the property of Eblocks
 * Software (Pty) Ltd.
 * and its suppliers (if any). The intellectual and technical concepts contained herein
 * are proprietary
 * to Eblocks Software (Pty) Ltd. and its suppliers (if any) and may be covered by South 
 * African, U.S.
 * and Foreign patents, patents in process, and are protected by trade secret and / or 
 * copyright law.
 * Dissemination of this information or reproduction of this material is forbidden unless
 * prior written
 * permission is obtained from Eblocks Software (Pty) Ltd.
*/

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