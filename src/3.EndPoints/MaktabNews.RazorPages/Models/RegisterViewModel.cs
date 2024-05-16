namespace MaktabNews.RazorPages.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public bool IsReporter { get; set; }
        public bool IsVisitor { get; set; }
    }
}
