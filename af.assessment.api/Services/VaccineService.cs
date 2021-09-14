using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;
using af.assessment.api.Enums;
using af.assessment.api.Stores;
using Microsoft.AspNetCore.Mvc;

namespace af.assessment.api.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class VaccineService : IVaccineService
    {
        private readonly IVaccineStore _vaccineStore;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vaccineStore"></param>
        public VaccineService(IVaccineStore vaccineStore)
        {
            _vaccineStore = vaccineStore;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<List<Appointment>> GetAppointmentsByStatus(Guid memberId, AppointmentStatus status)
        {
            if (memberId == null)
            {
                throw new ArgumentException();
            }
            
            return await _vaccineStore.GetAppointmentByStatus(memberId, status);
        }
    }
}