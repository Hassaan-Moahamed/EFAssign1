using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssign1.Data.Models
{  //poco class =>plain old clr object
    // 1- By Convention
    internal class Employee
    {
        public int Id { get; set; } //should be ID PK
        public string? EmployeeName { get; set; } //nVarChar (max)
        public decimal Salary { get; set; } //decimal (18,2)
        public int? age { get; set; } //nullable <INT>
                                      

    }
}
