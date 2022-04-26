using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class PlacementContract
    {
        public int PlacementContractId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        //FK
        public int LocationId { get; set; }
        public Location Location { get; set; }

        //One-To-Many
        public ICollection<Shift> Shifts { get; set; }
    }
}
