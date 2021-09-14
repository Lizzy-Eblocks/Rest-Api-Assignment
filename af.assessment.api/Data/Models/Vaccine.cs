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