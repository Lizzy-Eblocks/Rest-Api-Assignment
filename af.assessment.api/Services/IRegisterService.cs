using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;

namespace af.assessment.api.Services
{
    public interface IRegisterService
    {
        Task AddNewMember(Member member);
    }
}
