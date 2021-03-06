﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Item de Menu")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Nível Pimenta")]
        public string Spicyness { get; set; }
        public enum ESpicy {Sem=0, Fraco=1, Medio=2, Forte=3}

        [Display(Name = "Imagem")]
        public string Image { get; set; }

        [Display(Name= "Categoria")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "SubCategoria")]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }

        [Range(1,int.MaxValue, ErrorMessage = " Preço deve ser maior que ${1}")]
        public double Price { get; set; }
    }
}
