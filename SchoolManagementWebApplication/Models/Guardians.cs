using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApplication.Models
{
    public class Guardians
    {
        [Key]
        public int GuardianId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FatherOccupation { get; set; }
        public int FatherSalary { get; set; }
        public string MotherOccupation { get; set; }
        public int MotherSalary { get; set; }
        public string SiblingName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
        
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public int StudentId { get; set; }
    }
}
