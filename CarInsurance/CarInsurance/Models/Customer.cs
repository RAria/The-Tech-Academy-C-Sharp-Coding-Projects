using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Car Year")]
        public int CarYear { get; set; }

        [Display(Name = "Car Make")]
        public string CarMake { get; set; }

        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Display(Name = "Ever Got DUI?")]
        public bool EverGotDUI { get; set; }

        [Display(Name = "How Many Speeding Tickets to Date?")]
        public byte NumberOfSpeedingTickets { get; set; }

        [Display(Name = "Full Coverage?")]
        public bool FullCoverage { get; set; }

        [Display(Name = "Monthly Fee")]
        public double MonthlyFee { get; set; }

    }
}