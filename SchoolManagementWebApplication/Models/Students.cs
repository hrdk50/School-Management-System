using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApplication.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        
    }
}
