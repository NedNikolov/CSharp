using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PetClinic.Models;

namespace PetClinic.Dto.ImportDto
{
    public class PassportDto
    {
        [Key]
        [RegularExpression(@"^[A-Za-z]{7}[0-9]{3}$")]
        public int SerialNumber { get; set; }

        [Required]
        [RegularExpression(@"^\+359[0-9]{9}$|^0[0-9]{9}$")]
        public string OwnerPhoneNumber { get; set; }

        [Required]
        [MinLength(3), MaxLength(30)]
        public string OwnerName { get; set; }

        [Required]
        public string RegistrationDate { get; set; }
    }
}
