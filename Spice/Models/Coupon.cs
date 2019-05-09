using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Coupon")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Tipo de Coupon")]
        [Required]
        public string CouponType { get; set; }

        public enum ECouponType { Porcentagem=0, Reais=1 }

        [Display(Name = "Total de desconto")]
        [Required]
        public double Discount { get; set; }

        [Display(Name = "Valor Minimo")]
        [Required]
        public double MinimumAmount { get; set; }

        [Display(Name = "Imagem")]
        
        public byte[] Picture { get; set; }

        [Display(Name = "Ativo")]
        public bool IsActive { get; set; }
    }
}
