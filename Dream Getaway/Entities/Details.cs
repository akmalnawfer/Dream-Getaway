using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dream_Getaway.Entities
{
    [Table("Details", Schema = "Tours")]
    public class Details
    {
        [Key]
        public int DetailId { get; set; }
        public Packages Packages { get; set; }
        public int PackageId { get; set; }
    }
}