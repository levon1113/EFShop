using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFShop.Data.Entities
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
