using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dream_Getaway.Entities
{
    [Table("Categories",Schema = "Tours")]
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}