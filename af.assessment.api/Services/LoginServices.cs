using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;
using af.assessment.api.Stores;

namespace af.assessment.api.Services
{
    public class LoginServices : ILoginService
    {
        private readonly IRegisterStore _registerStore;
        public LoginServices(IRegisterStore registerStore)
        {
            _registerStore = registerStore;
        }
        public Response LoginSuccessfully(LoginDetails loguser)
        {
            // we  write the authentication logic

            Response loginResponse = null;
            if (loguser.Email.Trim().Length > 0 && loguser.Name.Trim().Length > 0 && loguser.Password.Trim().Length > 0)
            {
                //case of invalid credentials
                new Response();
                loginResponse.valid = 1;
                loginResponse.message = "Successfull Login";
            }
            else
            {
                new Response();
                loginResponse.valid = 0;
                loginResponse.message = "Sorry check your credentuials again";
            }



            return loginResponse;
        }
    }
}

