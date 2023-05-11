using System;
using System.Collections.Generic;

namespace Corona.DAL.Models
{
    public partial class Patient
    {
        public string PatientTz { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public int HouseNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string CellphoneNumber { get; set; } = null!;
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
