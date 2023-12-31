﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberDataEntryForm.Models
{
    public class MemberData
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is must!!!")]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "D.O.B is Necessary!!!")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please provide the Addess!!!")]
        [MaxLength(200)]
        [MinLength(3)]
        public string ResAddress { get; set; } = null!;

        [Required(ErrorMessage = "Enter the Valid Phone number!!!")]
        [MaxLength(10)]
        [MinLength(10)]
        public string ResPhone { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string OfficeNo { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Profession { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        [MinLength(3)]
        public string OfficeAddress { get; set; } = null!;

        [Required(ErrorMessage = "Enter the Valid Cell Number!!!")]
        [MaxLength(10)]
        [MinLength(10)]
        public string MobileNo { get; set; } = null!;

        [MaxLength(10)]
        [MinLength(10)]
        public string? AlternateMobileNo { get; set; }

        [Required(ErrorMessage = "Email is Mandatory!!!")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$")]
        [MaxLength(200)]
        public string Email { get; set; } = null!;

        [Required]
        public DateTime DateofMarriage { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string NameofSpouse { get; set; } = null!;

        [Required]
        public DateTime SpouseDob { get; set; }

        [MaxLength(20)]
        [MinLength(3)]
        public string? ChildName { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Sign { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? AuthId { get; set; }

        public MembersFamilyData FamilyData { get; set; }
        public MemberBusinessData BusinessData { get; set; }
        public MemberAddressData AddressData { get; set; }

    }
}
