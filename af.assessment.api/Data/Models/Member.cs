using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace af.assessment.api.Data.Models
{
    public class Member
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataMember(Name = "id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "memberName")]
        public string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "identificationNumber")]
        public long IdentificationNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "mobileNumber")]
        public int MobileNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "password")]
        public string Password { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "familyMember")]
        public List<FamilyMember> FamilyMember { get; set; }
    }
}