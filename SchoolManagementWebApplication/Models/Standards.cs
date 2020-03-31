using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApplication.Models
{
    public class Standards
    {
        [Key]
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public int FeesId { get; set; }
    }
}
