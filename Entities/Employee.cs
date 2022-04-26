using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int HomePhone { get; set; }

        [Required]
        public bool Active { get; set; }

        //Many-To-Many
        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }

    }
}
