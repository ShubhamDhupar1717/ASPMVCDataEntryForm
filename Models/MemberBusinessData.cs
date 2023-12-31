﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberDataEntryForm.Models
{
    public class MemberBusinessData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string BusinessName { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(3)]
        public string BusinessDetail { get; set; }
        [Required]
        [MaxLength(300)]
        [MinLength(3)]
        public string BusinessAddress { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string BusinessCity { get; set; }
        [Required]
        [MaxLength(6)]
        public string BusinessPostalCode { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string BusinessEmail { get; set; }
        public int? AuthId { get; set; }
        [Required]
        public int MemNo { get; set; }
        [ForeignKey("MemNo")]
        public virtual MemberData MemberData { get; set; }
    }
}
