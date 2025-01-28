using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MVC_BlogProject.Models.Entities
{
    public class Category
    {
        public Category()
        {
            Articles = new List<Article>(); // Navigation property için liste başlatılıyor
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Article> Articles { get; set; } // bir kategorinin birden fazla makalesi olabilir.
    }
}
