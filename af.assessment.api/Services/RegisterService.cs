using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;
using af.assessment.api.Stores;

namespace af.assessment.api.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly IRegisterStore _registerStore;

        public RegisterService(IRegisterStore registerStore)
        {
            _registerStore = registerStore;
        }
        public async Task AddNewMember(Member member)
        {
           await _registerStore.AddNewMember(member);
        }
        public async Task GetUser(string id)
        {
            await _registerStore.GetUser(id);
        }
    }
}
