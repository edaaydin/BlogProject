namespace MVC_BlogProject.Models.DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }

        // Etiketleri almak için sadece tag adlarını alıyoruz
        public List<string> Tags { get; set; }
    }
}
