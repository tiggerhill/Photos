using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Photos.Models.DataLayer
{
    public partial class Photos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FileName { get; set; }
        public int Occasion { get; set; }
        [Required]
        [StringLength(50)]
        public string FamilyMembers { get; set; }

        [ForeignKey(nameof(Occasion))]
        [InverseProperty(nameof(Occasions.Photos))]
        public virtual Occasions OccasionNavigation { get; set; }
    }
}
