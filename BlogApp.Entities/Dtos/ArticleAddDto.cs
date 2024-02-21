using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Abstact;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class ArticleAddDto 
    {

        [DisplayName("Title")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(5, ErrorMessage = "{0}  cannot be shorter than {1} character.")]
        public string Title { get; set; }
        [DisplayName("Content")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MinLength(20, ErrorMessage = "{0}  cannot be shorter than {1} character.")]
        public string Content { get; set; }
        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MaxLength(250, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(5, ErrorMessage = "{0}  cannot be shorter than {1} character.")]
        public string Thumbnail { get; set; }
        [DisplayName("Date")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Seo Author")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(0, ErrorMessage = "{0}  cannot be shorter than {1} character.")]
        public string SeoAuthor { get; set; }
        [DisplayName("Seo Description")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MaxLength(150, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(0, ErrorMessage = "{0}  cannot be shorter than {1} character.")]
        public string SeoDescription { get; set; }
        [DisplayName("Seo Tags")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MaxLength(70, ErrorMessage = "{0} cannot be longer than {1} character.")]
        [MinLength(5, ErrorMessage = "{0}  cannot be shorter than {1} character.")]
        public string SeoTags { get; set; }
        [DisplayName("Category")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [DisplayName("Is Active?")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        public bool IsActive { get; set; }

    }
}
