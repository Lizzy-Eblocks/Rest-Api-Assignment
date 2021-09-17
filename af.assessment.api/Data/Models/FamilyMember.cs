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
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using af.assessment.api.Enums;

namespace af.assessment.api.Data.Models
{
    public class FamilyMember
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name = "Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name = "identificationNumber")]
        public long IdentificationNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "member")]
        public MemberType Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "appointment")]
        [ForeignKey("AppointmentsId")]
        public List<Appointment> Appointments { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "status")]
        public bool VaccineStatus { get; set; }
    }
}