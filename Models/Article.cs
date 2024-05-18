using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string? Title { get; set; }
       
        public string? Contenu { get; set; }
       
    }
}
