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
    /// <summary>
    /// 
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name = "AppointmentsId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name ="memberId")]
        public Guid MemberId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "dateSelected")]
        public DateTime DateSelected { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "availableDate")]
        public DateTime AvailableDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "status")]
        public AppointmentStatus Status { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "vaccineId")]
        [ForeignKey("vaccineId")]
        public Guid vaccineId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "vaccines")]
        public List<Vaccine> Vaccines { get; set; }
    }
}