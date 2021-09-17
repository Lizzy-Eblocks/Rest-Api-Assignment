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
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Services;
using af.assessment.api.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace af.assessment.api.Controllers
{
    [ApiController]
    [Route("/v3/")]
    public class LoginController
    {
        private readonly IRegisterService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = (IRegisterService)loginService;
        }

        [HttpPost]
        [SwaggerOperation("Login-User-Successfully")]
        [SwaggerResponse(200, type: typeof(Response), description: "Single user successfully registered")]
        public async Task<Response> LoginSuccessfully(LoginDetails loguser)
        {
            Member resultsM = await _loginService.LoginSuccessfully(loguser);
            Response mr = new Response();
            if (resultsM != null)
            {
                mr.message = "You've successfully logged In ";
            }
            else
            {
                mr.message = "Your login procedure was unsuccessful. ";
            }
            return mr;
        }

    }
}
