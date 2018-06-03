using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dream_Getaway.Entities
{
    [Table("Packages", Schema = "Tours")]
    public class Packages
    {
        [Key]
        public int PackageId { get; set; }
        [Required]
        public string PackageTitle { get; set; }
        public int? NumberOfDays { get; set; }
        public float PackagePrice { get; set; }

        public Categories Categories { get; set; }
        public int CategoryId { get; set; }
    }
}