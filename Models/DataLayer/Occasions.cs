using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Photos.Models.DataLayer
{
    public partial class Occasions
    {
        public Occasions()
        {
            Photos = new HashSet<Photos>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string OccasionName { get; set; }
        [Required]
        [StringLength(50)]
        public string Year { get; set; }
        public string Notes { get; set; }

        [InverseProperty("OccasionNavigation")]
        public virtual ICollection<Photos> Photos { get; set; }
    }
}
