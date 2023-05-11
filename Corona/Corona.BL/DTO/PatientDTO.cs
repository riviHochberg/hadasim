using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.BL.DTO
{
    public class PatientDTO
    {
        [MaxLength(9)]
        [MinLength(9)]
        [Required(ErrorMessage = "The TZ field is required.")]
        public string PatientTz { get; set; }

        [MaxLength(50)]
        [MinLength(2)]
        [Required(ErrorMessage = "The first name field is required.")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [MinLength(2)]
        [Required(ErrorMessage = "The last name field is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The city field is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "The street field is required.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "The house number field is required.")]
        public int HouseNumber { get; set; }

        [Required(ErrorMessage = "The birth date field is required.")]
        public DateTime BirthDate { get; set; }

        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "The cellphone number field is required.")]
        public string CellphoneNumber { get; set; }

        public DateTime? PositiveResultDate { get; set; }
        public DateTime? RecoveryDate { get; set; }
        public DateTime? FirstVaccineDate { get; set; }
        public string? FirstVaccineManufacturer { get; set; }
        public DateTime? SecondVaccineDate { get; set; }
        public string? SecondVaccineManufacturer { get; set; }
        public DateTime? ThirdVaccineDate { get; set; }
        public string? ThirdVaccineManufacturer { get; set; }
        public DateTime? FourthVaccineDate { get; set; }
        public string? FourthVaccineManufacturer { get; set; }
    }
}
