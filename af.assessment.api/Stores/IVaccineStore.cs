using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;
using af.assessment.api.Enums;

namespace af.assessment.api.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public interface IVaccineStore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public Task<List<Appointment>> GetAppointmentByStatus(Guid memberId, AppointmentStatus? status);
    }
}