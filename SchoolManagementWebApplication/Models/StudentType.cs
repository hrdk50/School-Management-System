using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApplication.Models
{
    public class StudentType
    {
        [Key]
        public int StudentTypeId { get; set; }
        public byte StudentsType { get; set; }
        public string StudentTypeName { get; set; }
    }
}
