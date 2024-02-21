﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MaxLength(70, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(3, ErrorMessage = "0} cannot be shorter than {1} character.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(3, ErrorMessage = "{0} cannot be shorter than {1} character.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(3, ErrorMessage = "{0} cannot be shorter than {1} character.")]
        public string Note { get; set; }
        [DisplayName("Is Active?")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        public bool IsActive { get; set; }
    }
}
