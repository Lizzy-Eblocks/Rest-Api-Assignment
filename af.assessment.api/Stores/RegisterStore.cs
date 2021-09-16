using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Data;
using af.assessment.api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace af.assessment.api.Stores
{
    public class RegisterStore : IRegisterStore
    {

        private readonly RegisterDbContext _dbContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext">
        ///
        /// </param>
        public RegisterStore(RegisterDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddNewMember(Member member)
        {
            await _dbContext.Members.AddAsync(member);
                  _dbContext.SaveChanges();
        }
    }
}
