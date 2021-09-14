using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Data;
using af.assessment.api.Data.Models;
using af.assessment.api.Enums;
using Microsoft.EntityFrameworkCore;

namespace af.assessment.api.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public class VaccineStore : IVaccineStore
    {
        private readonly VaccineDbContext _dbContext;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext">
        ///
        /// </param>
        public VaccineStore(VaccineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAppointmentByStatus(Guid memberId, AppointmentStatus? status)
        {
            return await _dbContext.Appointments
                .Include(a => a.Vaccines)
                .ThenInclude(l => l.Location)
                .Where(a => (a.Status == status || status == null) && memberId == a.MemberId)
                .ToListAsync();
        }
    }
}