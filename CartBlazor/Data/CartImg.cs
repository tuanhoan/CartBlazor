
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CartBlazor.Data
{
    [Table("CartImg")]
    public class CartImg
    {
        [Key]
        public int CartImgId { get; set; }
        [MaxLength(1000)]
        public string CartImgSrc { get; set; }
        public int CardId { get; set; }
        public Cart Cart { get; set; }

    }
}
