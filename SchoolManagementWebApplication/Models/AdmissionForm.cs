using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApplication.Models
{
    public class AdmissionForm
    {
        [Key]
        public int AdmissionId { get; set; }
        public string StudentName { get; set; }
        public string BirthDate { get; set; }
        public Boolean ResultStatus { get; set; }
        public int StudentTypeId { get; set; }
        public int StandardId { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public int StudentId { get; set; }
    }
}
