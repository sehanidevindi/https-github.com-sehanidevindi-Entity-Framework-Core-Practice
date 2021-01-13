using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Demo
{
    [Table("Pizza")]
    internal class Pizza
    {
        public int Id { get; set; }
        [Column("pizza_name")]
        public string Pizza_name { get; set; }
        [Column("ingredients")]
        public string Ingredients { get; set; }
        public int Price { get; set; }
        
    }
}
