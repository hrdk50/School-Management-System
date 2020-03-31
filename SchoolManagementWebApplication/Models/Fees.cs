using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApplication.Models
{
    public class Fees
    {
        [Key]
        public int FeesId { get; set; }
        public int Amount { get; set; }
        public int StudentId { get; set; }
        public int InstallmentId { get; set; }

    }
}
