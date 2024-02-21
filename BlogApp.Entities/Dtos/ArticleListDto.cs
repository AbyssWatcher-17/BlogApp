using BlogApp.Entities.Concrete;
using BlogApp.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class ArticleListDto
    {
        public IList<Article> Articles { get; set; }
        public ResultStatus ResultStatus { get; set; }
    }
}
