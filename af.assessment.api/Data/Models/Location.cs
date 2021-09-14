using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace af.assessment.api.Data.Models
{
    public class Location
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
        [DataMember(Name = "streetName")]
        public string StreetName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "postalCode")]
        public int PostalCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }
        
        
    }
}