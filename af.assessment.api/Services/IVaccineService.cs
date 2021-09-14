using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;
using af.assessment.api.Enums;

namespace af.assessment.api.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IVaccineService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberId">
        ///
        /// </param>
        /// <param name="status">
        ///
        /// </param>
        /// <returns>
        ///
        /// </returns>
        public Task<List<Appointment>> GetAppointmentsByStatus(Guid memberId, AppointmentStatus status);
    }
}