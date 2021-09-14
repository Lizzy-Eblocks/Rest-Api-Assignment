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