using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApplication.Models
{
    public class Installments
    {
        [Key]
    public int InstallmentId { get; set; }
    public int First { get; set; }
    public int Second { get; set; }
    public int Third { get; set; }
    public int Fourth { get; set; }
    
    }
}
