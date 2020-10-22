using CartBlazor.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CartBlazor.Data
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int CardId { get; set; } 
        [MaxLength(1000)]
        public string imgText { get; set; }
        public double money { get; set; }
        public int count { get; set; }
        public ICollection<CartImg> CartImgs { get; set; }
    }
}
