using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFShop.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [ForeignKey("Shop")]
        public int? ShopId { get; set; }
        public virtual Shop Shop { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Shop.Name}";
        }

        
    }
}
