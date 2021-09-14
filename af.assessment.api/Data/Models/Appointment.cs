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