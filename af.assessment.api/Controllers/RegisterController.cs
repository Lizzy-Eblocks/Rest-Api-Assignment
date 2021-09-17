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
using af.assessment.api.Data.Models;
using af.assessment.api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace af.assessment.api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("/v2/")]
    public class RegisterController
    {
        private readonly IRegisterService _registerService;

        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }
        /// <summary>
        ///     Action method to register new users
        /// </summary>
        [HttpPost("newmember")]
        [Produces("application/json")]
        [SwaggerOperation("add-new-member")]
        [SwaggerResponse(200, type: typeof(Member), description: "Single user successfully registered")]
        public async Task AddNewMember(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException("cannot be null");
            }
            var user = new Member()
            {
                Id = member.Id,
                Email = member.Email,
                Name = member.Name,
                MobileNumber = member.MobileNumber,
                Password = member.Password,
                FamilyMember = member.FamilyMember,
                IdentificationNumber = member.IdentificationNumber

            };
            await _registerService.AddNewMember(user);
        }

       /* [HttpGet("user id {id}")]
        [Produces("application/json")]
        [SwaggerOperation("get-existing-member")]
        [SwaggerResponse(200, type: typeof(Member), description: "Single user is registered")]
        public async Task GetUser(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(" Null exception");
            }

            await _registerService.GetUser(id);
        }*/
    }
}
