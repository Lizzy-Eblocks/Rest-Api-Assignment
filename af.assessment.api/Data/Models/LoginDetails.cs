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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace af.assessment.api.Data.Models
{
    public class LoginDetails
    {
        [Required]

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "memberName")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name = "password")]
        public string Password { get; set; }

       


    }
}
