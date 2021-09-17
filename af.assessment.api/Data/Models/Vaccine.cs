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

namespace af.assessment.api.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Vaccine
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name = "vaccineId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "dosage")]
        public double Dose { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "location")]
        public Location Location { get; set; }
        
        // /// <summary>
        // /// 
        // /// </summary>
        // public Guid LocationId { get; set; }
    }
}