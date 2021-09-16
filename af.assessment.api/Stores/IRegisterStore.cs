using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;

namespace af.assessment.api.Stores
{
    public interface IRegisterStore
    {
        Task AddNewMember(Member member);
    }
}
